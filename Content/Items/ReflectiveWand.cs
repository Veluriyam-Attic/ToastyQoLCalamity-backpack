using CalamityMod;
using CalamityMod.Items.Materials;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using ToastyQoLCalamity.Content.NPCs;

namespace ToastyQoLCalamity.Content.Items
{
    public class ReflectiveWand : ModItem
    {
        public static int BHType
        {
            get;
            private set;
        } = 1;

        private string TypeText = Language.GetTextValue($"Mods.ToastyQoLCalamity.Items.ReflectiveWand.1");

        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Reflective Wand");
            /* Tooltip.SetDefault("Summons a simulation of Supreme Calamitas' bullet hells\n" +
                "Right click to change type of bullet hell forward or backward depending on mouse position\nCurrent Type"); */
        }

        public override void SetDefaults()
        {
            Item item = Item;
            item.width = 88;
            item.height = 88;
            item.maxStack = 1;
            item.rare = ItemRarityID.Purple;
            item.useAnimation = 20;
            item.useTime = 20;
            item.useStyle = ItemUseStyleID.Swing;
        }

        public override bool AltFunctionUse(Player player) => true;
        public override bool? UseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                int Direction = Math.Sign(Main.MouseWorld.X - player.position.X);
                int bhType = BHType;
                bhType += Direction;
                if (bhType > 5)
                    bhType = 1;
                if (bhType < 1)
                    bhType = 5;

                TypeText = bhType switch
                {
                    1 => Language.GetTextValue($"Mods.ToastyQoLCalamity.Items.ReflectiveWand.1"),
                    2 => Language.GetTextValue($"Mods.ToastyQoLCalamity.Items.ReflectiveWand.2"),
                    3 => Language.GetTextValue($"Mods.ToastyQoLCalamity.Items.ReflectiveWand.3"),
                    4 => Language.GetTextValue($"Mods.ToastyQoLCalamity.Items.ReflectiveWand.4"),
                    5 => Language.GetTextValue($"Mods.ToastyQoLCalamity.Items.ReflectiveWand.5"),
                    _ => Language.GetTextValue($"Mods.ToastyQoLCalamity.Items.ReflectiveWand.6"),
                };
                BHType = bhType;
                ToastyQoLUtils.DisplayText(Language.GetTextValue($"Mods.ToastyQoLCalamity.Items.ReflectiveWand.Type", TypeText), Color.DarkRed);
            }
            else
                CalamityUtils.SpawnBossBetter(player.Center + new Vector2(0, -1), ModContent.NPCType<BulletHellSimulator>());

            return true;
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            TooltipLine nameLine = tooltips.FirstOrDefault((x) => x.Name == "ItemName" && x.Mod == "Terraria");
            if (nameLine != null)
                nameLine.OverrideColor = ToastyQoLUtils.TwoColorPulse(new Color(104, 13, 13), new Color(190, 145, 55), 2f);

            foreach (TooltipLine l in tooltips)
            {
                if (l.Text == null)
                    continue;

                if (l.Text.StartsWith(Language.GetTextValue($"Mods.ToastyQoLCalamity.Items.ReflectiveWand.Type", TypeText)))
                {
                    if (TypeText != null)
                    {
                        l.OverrideColor = Color.Firebrick;
                        l.Text = Language.GetTextValue($"Mods.ToastyQoLCalamity.Items.ReflectiveWand.Type", TypeText);
                    }
                }
            }
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe(1);
            recipe.AddIngredient(ModContent.ItemType<AuricBar>(), 1);
            recipe.AddIngredient(ModContent.ItemType<AshesofCalamity>(), 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}