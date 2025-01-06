using CalamityMod.Events;
using CalamityMod.Items.SummonItems;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ToastyQoLCalamity.Content.Items
{
    public class BrokenRitual : ModItem
    {
        public int BRType = 1;
        public string TypeText = "King Slime";
        public int TierType = 1;
        public Color TextColor = new(225, 174, 255);

        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 1;
            // DisplayName.SetDefault("Broken Ritual");
            /* Tooltip.SetDefault("Set to a specific boss in Boss Rush\n" +
                "Right click to change boss forward or backward depending on mouse position\n" +
                "Use while the event is active to instantly end the event\nBoss Count" + (IsInfernumOn ? "\nInfernum Enabled" : "")); */
        }

        public override void SetDefaults()
        {
            Item.width = 54;
            Item.height = 68;
            Item.maxStack = 1;
            Item.rare = ItemRarityID.Red;
            Item.useAnimation = 10;
            Item.useTime = 10;
            Item.UseSound = SoundID.Item123;
            Item.useStyle = ItemUseStyleID.Shoot;
        }

        public override bool AltFunctionUse(Player player) => true;
        private static bool IsInfernumOn => ToastyQoLCalamity.InfernumMod is not null;
        public override bool? UseItem(Player player)/* Suggestion: Return null instead of false */
        {
            if (player.altFunctionUse == 2)
            {
                // negative 1 is left of the player, positive 1 is right of the player.
                int Direction = Math.Sign(Main.MouseWorld.X - player.position.X);
                BRType += Direction;
                int maxBosses = IsInfernumOn ? 45 : 44;

                if (BRType > maxBosses)
                    BRType = 1;
                else if (BRType < 1)
                    BRType = maxBosses;

                switch (BRType)
                {
                    case 1:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"NPCName.KingSlime") : Language.GetTextValue($"NPCName.KingSlime");
                        TextColor = new Color(225, 174, 255); //E1EAFF
                        TierType = 1;
                        break;
                    case 2:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"NPCName.EyeofCthulhu") : Language.GetTextValue($"Mods.CalamityMod.NPCs.DesertScourgeHead.DisplayName");
                        break;
                    case 3:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"NPCName.EaterofWorldsHead") : Language.GetTextValue($"NPCName.EyeofCthulhu");
                        break;
                    case 4:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"NPCName.WallofFlesh") : Language.GetTextValue($"Mods.CalamityMod.NPCs.Crabulon.DisplayName");
                        break;
                    case 5:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Mods.CalamityMod.NPCs.PerforatorHive.DisplayName") : Language.GetTextValue($"NPCName.EaterofWorldsHead");
                        break;
                    case 6:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"NPCName.QueenBee") : Language.GetTextValue($"NPCName.BrainofCthulhu");
                        break;
                    case 7:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"NPCName.QueenSlimeBoss") : Language.GetTextValue($"Mods.CalamityMod.NPCs.HiveMind.DisplayName");
                        break;
                    case 8:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Mods.CalamityMod.NPCs.AstrumAureus.DisplayName") : Language.GetTextValue($"Mods.CalamityMod.NPCs.PerforatorHive.DisplayName");
                        break;
                    case 9:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Mods.CalamityMod.NPCs.Crabulon.DisplayName") : Language.GetTextValue($"NPCName.QueenBee");
                        break;
                    case 10:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Mods.CalamityMod.NPCs.AquaticScourgeHead.DisplayName") : Language.GetTextValue($"NPCName.Deerclops");
                        break;
                    case 11:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Mods.CalamityMod.NPCs.DesertScourgeHead.DisplayName") : Language.GetTextValue($"NPCName.SkeletronHead");
                        break;
                    case 12:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Mods.CalamityMod.BossChecklistIntegration.ProfanedGuardians.EntryName") : Language.GetTextValue($"Mods.CalamityMod.NPCs.SlimeGodCore.DisplayName");
                        break;
                    case 13:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Mods.CalamityMod.NPCs.StormWeaverHead.DisplayName") : Language.GetTextValue($"NPCName.WallofFlesh");
                        TextColor = new Color(225, 174, 255);
                        TierType = 1;
                        break;
                    case 14:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Mods.CalamityMod.NPCs.BrimstoneElemental.DisplayName") : Language.GetTextValue($"NPCName.QueenSlimeBoss");
                        TextColor = new Color(134, 151, 189); //8697BD
                        TierType = 2;
                        break;
                    case 15:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Mods.CalamityMod.Items.Lore.LoreLeviathanAnahita.DisplayName") : Language.GetTextValue($"Mods.CalamityMod.NPCs.Cryogen.DisplayName");
                        break;
                    case 16:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Mods.CalamityMod.NPCs.RavagerBody.DisplayName") : Language.GetTextValue($"Enemies.TheTwins");
                        break;
                    case 17:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Mods.CalamityMod.NPCs.HiveMind.DisplayName") : Language.GetTextValue($"Mods.CalamityMod.NPCs.AquaticScourgeHead.DisplayName");
                        break;
                    case 18:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"NPCName.DukeFishron") : Language.GetTextValue($"NPCName.TheDestroyer");
                        break;
                    case 19:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Mods.CalamityMod.NPCs.Cryogen.DisplayName") : Language.GetTextValue($"Mods.CalamityMod.NPCs.BrimstoneElemental.DisplayName");
                        break;
                    case 20:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"NPCName.BrainofCthulhu") : Language.GetTextValue($"NPCName.SkeletronPrime");
                        break;
                    case 21:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"NPCName.Deerclops") : Language.GetTextValue($"Mods.CalamityMod.NPCs.CalamitasClone.DisplayName");
                        break;
                    case 22:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Mods.CalamityMod.NPCs.Signus.DisplayName") : Language.GetTextValue($"NPCName.Plantera");
                        TextColor = new Color(134, 151, 189); //8697BD
                        TierType = 2;
                        break;
                    case 23:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Mods.CalamityMod.NPCs.Bumblefuck.DisplayName") : Language.GetTextValue($"Mods.CalamityMod.Items.Lore.LoreLeviathanAnahita.DisplayName");
                        TextColor = new Color(111, 214, 255);
                        TierType = 3;
                        break;
                    case 24:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Mods.CalamityMod.NPCs.SlimeGodCore.DisplayName") : Language.GetTextValue($"Mods.CalamityMod.NPCs.AstrumAureus.DisplayName");
                        break;
                    case 25:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"NPCName.SkeletronHead") : Language.GetTextValue($"NPCName.Golem");
                        break;
                    case 26:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"NPCName.Plantera") : Language.GetTextValue($"Mods.CalamityMod.NPCs.PlaguebringerGoliath.DisplayName");
                        break;
                    case 27:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"NPCName.TheDestroyer") : Language.GetTextValue($"NPCName.HallowBoss");
                        break;
                    case 28:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Mods.CalamityMod.NPCs.PlaguebringerGoliath.DisplayName") : Language.GetTextValue($"NPCName.DukeFishron");
                        break;
                    case 29:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Mods.CalamityMod.NPCs.AstrumDeusHead.DisplayName") : Language.GetTextValue($"Mods.CalamityMod.NPCs.RavagerBody.DisplayName");
                        break;
                    case 30:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"NPCName.CultistBoss") : Language.GetTextValue($"NPCName.CultistBoss");
                        break;
                    case 31:
                        TypeText = IsInfernumOn ? "Lunatic Cultist 2" : Language.GetTextValue($"Mods.CalamityMod.NPCs.AstrumDeusHead.DisplayName");
                        TextColor = new Color(111, 214, 255);
                        TierType = 3;
                        break;
                    case 32:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"NPCName.SkeletronPrime") : Language.GetTextValue($"Enemies.MoonLord");
                        TextColor = new Color(230, 126, 35); //E67E23
                        TierType = 4;
                        break;
                    case 33:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Mods.CalamityMod.NPCs.OldDuke.DisplayName") : Language.GetTextValue($"Mods.CalamityMod.BossChecklistIntegration.ProfanedGuardians.EntryName");
                        break;
                    case 34:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"NPCName.Golem") : Language.GetTextValue($"Mods.CalamityMod.NPCs.Bumblefuck.DisplayName");
                        break;
                    case 35:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"NPCName.HallowBoss") : Language.GetTextValue($"Mods.CalamityMod.NPCs.Providence.DisplayName");
                        break;
                    case 36:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Enemies.TheTwins") : Language.GetTextValue($"Mods.CalamityMod.NPCs.CeaselessVoid.DisplayName");
                        break;
                    case 37:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Mods.CalamityMod.NPCs.Polterghast.DisplayName") : Language.GetTextValue($"Mods.CalamityMod.NPCs.StormWeaverHead.DisplayName");
                        break;
                    case 38:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Enemies.MoonLord") : Language.GetTextValue($"Mods.CalamityMod.NPCs.Signus.DisplayName");
                        break;
                    case 39:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Mods.CalamityMod.NPCs.CeaselessVoid.DisplayName") : Language.GetTextValue($"Mods.CalamityMod.NPCs.Polterghast.DisplayName");
                        break;
                    case 40:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Mods.CalamityMod.NPCs.CalamitasClone.DisplayName") : Language.GetTextValue($"Mods.CalamityMod.NPCs.OldDuke.DisplayName");
                        break;
                    case 41:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Mods.CalamityMod.NPCs.DevourerofGodsHead.DisplayName") : Language.GetTextValue($"Mods.CalamityMod.NPCs.DevourerofGodsHead.DisplayName");
                        TextColor = new Color(230, 126, 35); //E67E23
                        TierType = 4;
                        break;
                    case 42:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Mods.CalamityMod.NPCs.Yharon.DisplayName") : Language.GetTextValue($"Mods.CalamityMod.NPCs.Yharon.DisplayName");
                        TextColor = Color.White;
                        TierType = 5;
                        break;
                    case 43:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Mods.CalamityMod.NPCs.Providence.DisplayName") : Language.GetTextValue($"Mods.CalamityMod.BossChecklistIntegration.ExoMechs.EntryName");
                        break;
                    case 44:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Mods.CalamityMod.BossChecklistIntegration.ExoMechs.EntryName") : Language.GetTextValue($"Mods.CalamityMod.NPCs.SupremeCalamitas.DisplayName");
                        TextColor = Color.White;
                        TierType = 5;
                        break;
                    case 45:
                        TypeText = IsInfernumOn ? Language.GetTextValue($"Mods.CalamityMod.NPCs.SupremeCalamitas.DisplayName") : Language.GetTextValue($"Mods.CalamityMod.NPCs.SupremeCalamitas.DisplayName");
                        TextColor = Color.White;
                        TierType = 5;
                        break;
                }
                Main.NewText(Language.GetTextValue($"Mods.ToastyQoLCalamity.Items.BrokenRitual.BossCountInfo", TypeText, TierType, BRType), TextColor);
            }
            else
            {
                if (BossRushEvent.BossRushActive || BossRushEvent.StartTimer > 0)
                {
                    if (Main.netMode != NetmodeID.MultiplayerClient)
                        BossRushEvent.End();
                }
                else
                {
                    BossRushEvent.BossRushStage = BRType - 1;
                    BossRushEvent.BossRushActive = true;
                }
            }

            return true;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            Player player = Main.player[Main.myPlayer];
            if (player is null)
                return;
            foreach (TooltipLine l in tooltips)
            {
                if (l.Text == null)
                    continue;

                if (l.Text.StartsWith("[Boss Count]"))
                {
                    l.OverrideColor = TextColor;

                    l.Text = Language.GetTextValue($"Mods.ToastyQoLCalamity.Items.BrokenRitual.BossCountInfo", TypeText, TierType, BRType);
                }
            }
            if (IsInfernumOn)
            {
                tooltips.Add(new TooltipLine(Mod, "InfernumMessage", Language.GetTextValue($"Mods.ToastyQoLCalamity.Items.BrokenRitual.InfernumMessage")) { OverrideColor = ToastyQoLUtils.TwoColorPulse(Color.Firebrick, Color.Orange, 2f) });
            }
        }
        public override void AddRecipes()
        {
            CreateRecipe().
            AddIngredient<Terminus>().
            AddTile(TileID.Anvils).
            Register();
        }
    }
}