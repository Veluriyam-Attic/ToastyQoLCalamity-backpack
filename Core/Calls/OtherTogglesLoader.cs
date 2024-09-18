using CalamityMod;
using CalamityMod.Items;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.ModLoader;
using static ToastyQoLCalamity.ToastyQoLCalamity;
using static ToastyQoL.ToastyQoLUtils;
using Terraria.Localization;

namespace ToastyQoLCalamity.Core.Calls
{
    /// <summary>
    /// An example of adding toggles to existing/registered pages.
    /// </summary>
    public static class OtherTogglesLoader
    {
        public static void Load()
        {
            AddToggle("MiscManager", ModContent.Request<Texture2D>("ToastyQoLCalamity/Assets/UI/charge", AssetRequestMode.ImmediateLoad).Value, 
                ModContent.Request<Texture2D>("ToastyQoLCalamity/Assets/UI/charge", AssetRequestMode.ImmediateLoad).Value,
                () => Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Toggles.Other.ArsenalRecharge.Name"), () => Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Toggles.Other.ArsenalRecharge.Description"), 5.5f, () =>
                {
                    CalToggles.AutoChargeDraedonWeapons = !CalToggles.AutoChargeDraedonWeapons;
                    for (int i = 0; i < Main.LocalPlayer.inventory.Length; i++)
                    {
                        Item item = Main.LocalPlayer.inventory[i];
                        if (item.type >= 5125)
                        {
                            CalamityGlobalItem modItem = item.Calamity();
                            if (modItem != null && modItem.UsesCharge)
                                modItem.Charge = modItem.MaxCharge;
                        }
                    }
                }, typeof(CalToggles).GetField("AutoChargeDraedonWeapons", UniversalBindingFlags));

            AddToggle("MiscManager", ModContent.Request<Texture2D>("ToastyQoLCalamity/Assets/UI/tester", AssetRequestMode.ImmediateLoad).Value,
                ModContent.Request<Texture2D>("ToastyQoLCalamity/Assets/UI/tester", AssetRequestMode.ImmediateLoad).Value,
                () => Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Toggles.Other.FightLength.Name"), () => Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Toggles.Other.FightLength.Description"), 8.5f, () =>
                {
                    CalToggles.TesterTimes = !CalToggles.TesterTimes;
                }, typeof(CalToggles).GetField("TesterTimes", UniversalBindingFlags));
        }
    }
}
