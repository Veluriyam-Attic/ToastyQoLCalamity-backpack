using CalamityMod;
using CalamityMod.Buffs.DamageOverTime;
using CalamityMod.Buffs.StatBuffs;
using CalamityMod.Items;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using ToastyQoLCalamity.Content.NPCs;
using ToastyQoLCalamity.Content.Projectiles;
using ToastyQoLCalamity.Core.Systems;
using static ToastyQoLCalamity.ToastyQoLCalamity;

namespace ToastyQoLCalamity.Core.Globals
{
    internal class TCPlayer : ModPlayer
    {
        public int KeepRageMaxedTimer;

        public override void PostUpdateBuffs()
        {
            if (Player.Calamity().trippy && !GetToggleStatus("ShroomsExtraDamage"))
            {
                Player.GetDamage<GenericDamageClass>() -= 0.5f;
            }
        }

        public override void PreUpdate()
        {
            if (KeepRageMaxedTimer > 0)
            {
                KeepRageMaxedTimer--;
                Player.Calamity().rage = Player.Calamity().rageMax;
            }

            // Update extra Instant Death toggle effects
            if (GetToggleStatus("InstantDeath"))
            {
                if (Player.FindBuffIndex(ModContent.BuffType<HolyInferno>()) > -1)
                    Player.KillMe(PlayerDeathReason.ByCustomReason(Player.name + " was burnt by the Holy Inferno"), 1000.0, 0, false);

                if (Player.FindBuffIndex(ModContent.BuffType<VulnerabilityHex>()) > -1)
                    Player.KillMe(PlayerDeathReason.ByCustomReason(Player.name + "'s mental fortitude faded away"), 1000.0, 0, false);

                Player.buffImmune[ModContent.BuffType<TarragonImmunity>()] = true;
                Player.Calamity().tarragonImmunity = false;          
            }
        }

        public override bool? CanHitNPCWithItem(Item item, NPC target)
        {
            //make sure that no direct strikes can hit the Doll of Fury dummy
            if (target.type == ModContent.NPCType<DollDummy>())
            {
                return false;
            }
            return null;
        }

        public override bool? CanHitNPCWithProj(Projectile proj, NPC target)
        {
            //make sure that no other projectile than DollStrike can hit the Doll of Fury dummy
            if (target.type == ModContent.NPCType<DollDummy>() && proj.type == ModContent.ProjectileType<DollStrike>())
            {
                return true;
            }
            else if (target.type == ModContent.NPCType<DollDummy>())
            {
                return false;
            }
            else if (proj.type == ModContent.ProjectileType<DollStrike>())
            {
                return false;
            }
            return null;
        }

        public override void OnRespawn()
        {
            if (CalToggles.AutoChargeDraedonWeapons)
            {
                for (int i = 0; i < Player.inventory.Length; i++)
                {
                    Item item = Player.inventory[i];
                    if (item.type >= 5125)
                    {
                        CalamityGlobalItem modItem = item.Calamity();
                        if (modItem != null && modItem.UsesCharge)
                        {
                            modItem.Charge = modItem.MaxCharge;
                        }
                    }
                }
            }
        }

        public override void OnEnterWorld() => LoadSaveSystem.CalamityCallQueued = false;

    }
}
