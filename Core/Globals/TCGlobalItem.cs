using CalamityMod;
using CalamityMod.Buffs.Placeables;
using CalamityMod.Items;
using CalamityMod.Items.Accessories;
using CalamityMod.Items.Placeables.Furniture;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ModLoader;
using ToastyQoLCalamity.Content.Items;
using ToastyQoLCalamity.Content.Items.PostMoonlord;
using ToastyQoLCalamity.Core.Systems;
using static ToastyQoLCalamity.ToastyQoLCalamity;


namespace ToastyQoLCalamity.Core.Globals
{
    internal class TCGlobalItem : GlobalItem
    {
        public override bool InstancePerEntity => true;

        public readonly List<int> SCalTooltips =
		[
			ModContent.ItemType<ReflectiveWand>(),
            ModContent.ItemType<BrimstoneTorch>(),
        ];

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            // Communitys tooltip.
            if (item.type == ModContent.ItemType<TheCommunity>())
            {
                string bossName = ProgressionSystem.GetLatestBossKilled();
                TooltipLine obj2 = new(Mod, "ProgressionTooltip", "Current power level: " + bossName);
                tooltips.Add(obj2);
            }

            // Set the name color for the items that require it.
            TooltipLine nameLine = tooltips.FirstOrDefault((x) => x.Name == "ItemName" && x.Mod == "Terraria");

            if (nameLine != null && SCalTooltips.Contains(item.type))
                nameLine.OverrideColor = ToastyQoLUtils.TwoColorPulse(new Color(255, 132, 22), new Color(221, 85, 7), 4f);
        }

        public override void UpdateInventory(Item item, Player player)
        {
            if (GetToggleStatus("ItemLock") && item.type == ModContent.ItemType<NormalityRelocator>() && !NPC.downedMoonlord)
                player.Calamity().normalityRelocator = false;

            if (GetToggleStatus("InfinitePotions"))
            {
                if (item.type == ModContent.ItemType<CrimsonEffigy>())
                    player.AddBuff(ModContent.BuffType<CrimsonEffigyBuff>(), 2);

                if (item.type == ModContent.ItemType<CorruptionEffigy>())
                    player.AddBuff(ModContent.BuffType<CorruptionEffigyBuff>(), 2);
            }
        }
    }
}
