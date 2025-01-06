using CalamityMod;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using static ToastyQoL.ToastyQoLUtils;
using static ToastyQoLCalamity.Core.CalToggles;
using static ToastyQoLCalamity.ToastyQoLCalamity;

namespace ToastyQoLCalamity.Core.Calls
{
    /// <summary>
    /// An example of creating a custom page to the main toggle wheel, and then adding toggles to it.
    /// </summary>
    public static class UpgradesPage
    {
        public static void Create()
        {
            AddPage("UpgradesManager", Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Upgrades.Name"), ModContent.Request<Texture2D>("ToastyQoLCalamity/Assets/UI/UpgradesUIIcon", AssetRequestMode.ImmediateLoad).Value
                , 3f, false, () => { }, null);

            if (PageExists("UpgradesManager"))
            {
                AddToggle("UpgradesManager", ModContent.Request<Texture2D>("ToastyQoLCalamity/Assets/UI/Auto", AssetRequestMode.ImmediateLoad).Value,
                    ModContent.Request<Texture2D>("ToastyQoLCalamity/Assets/UI/AutoGlow", AssetRequestMode.ImmediateLoad).Value, () => { return Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Upgrades.ToggleAutoSystem.Name"); },
                    () => { return Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Upgrades.ToggleAutoSystem.Description"); }, 1f, () => { AutomatedSystem = !AutomatedSystem; },
                    typeof(CalToggles).GetField("AutomatedSystem", UniversalBindingFlags));

                AddToggle("UpgradesManager", ModContent.Request<Texture2D>("ToastyQoLCalamity/Assets/UI/BloodOrange", AssetRequestMode.ImmediateLoad).Value,
                    ModContent.Request<Texture2D>("ToastyQoLCalamity/Assets/UI/BloodOrangeGlow", AssetRequestMode.ImmediateLoad).Value, () => { return Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Upgrades.ToggleHP"); },
                    () =>
                    {
                        string nextUpgrade;
                        if (Main.LocalPlayer.Calamity().dFruit)
                            nextUpgrade = Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Upgrades.NoUpgrades");
                        else if (Main.LocalPlayer.Calamity().eBerry)
                            nextUpgrade = Language.GetTextValue($"Mods.CalamityMod.Items.Misc.Dragonfruit.DisplayName");
                        else if (Main.LocalPlayer.Calamity().mFruit)
                            nextUpgrade = Language.GetTextValue($"Mods.CalamityMod.Items.Misc.Elderberry.DisplayName");
                        else if (Main.LocalPlayer.Calamity().bOrange)
                            nextUpgrade = Language.GetTextValue($"Mods.CalamityMod.Items.Misc.MiracleFruit.DisplayName");
                        else
                            nextUpgrade = Language.GetTextValue($"Mods.CalamityMod.Items.Misc.BloodOrange.DisplayName");

                        return Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Upgrades.NextUpgrade", nextUpgrade);
                    }, 2f,
                    () =>
                    {
                        // if you have max upgrades, turn them all off.
                        if (Main.LocalPlayer.Calamity().dFruit)
                        {
                            Main.LocalPlayer.Calamity().bOrange = false;
                            Main.LocalPlayer.Calamity().mFruit = false;
                            Main.LocalPlayer.Calamity().eBerry = false;
                            Main.LocalPlayer.Calamity().dFruit = false;
                        }
                        else if (Main.LocalPlayer.Calamity().eBerry)
                        {
                            Main.LocalPlayer.Calamity().bOrange = true;
                            Main.LocalPlayer.Calamity().mFruit = true;
                            Main.LocalPlayer.Calamity().eBerry = true;
                            Main.LocalPlayer.Calamity().dFruit = true;
                        }
                        else if (Main.LocalPlayer.Calamity().mFruit)
                        {
                            Main.LocalPlayer.Calamity().bOrange = true;
                            Main.LocalPlayer.Calamity().mFruit = true;
                            Main.LocalPlayer.Calamity().eBerry = true;
                            Main.LocalPlayer.Calamity().dFruit = false;
                        }
                        else if (Main.LocalPlayer.Calamity().bOrange)
                        {
                            Main.LocalPlayer.Calamity().bOrange = true;
                            Main.LocalPlayer.Calamity().mFruit = true;
                            Main.LocalPlayer.Calamity().eBerry = false;
                            Main.LocalPlayer.Calamity().dFruit = false;
                        }
                        else
                        {
                            Main.LocalPlayer.Calamity().bOrange = true;
                            Main.LocalPlayer.Calamity().mFruit = false;
                            Main.LocalPlayer.Calamity().eBerry = false;
                            Main.LocalPlayer.Calamity().dFruit = false;
                        }
                    }, null, true, () => !AutomatedSystem, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Upgrades.AutoSystemDisable"));

                AddToggle("UpgradesManager", ModContent.Request<Texture2D>("ToastyQoLCalamity/Assets/UI/CometShard", AssetRequestMode.ImmediateLoad).Value,
                    ModContent.Request<Texture2D>("ToastyQoLCalamity/Assets/UI/CometShardGlow", AssetRequestMode.ImmediateLoad).Value, () => { return Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Upgrades.ToggleMana"); },
                    () =>
                    {
                        string nextUpgrade;
                        if (Main.LocalPlayer.Calamity().pHeart)
                            nextUpgrade = Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Upgrades.NoUpgrades");
                        else if (Main.LocalPlayer.Calamity().eCore)
                            nextUpgrade = Language.GetTextValue($"Mods.CalamityMod.Items.Misc.PhantomHeart.DisplayName");
                        else if (Main.LocalPlayer.Calamity().cShard)
                            nextUpgrade = Language.GetTextValue($"Mods.CalamityMod.Items.Misc.EtherealCore.DisplayName");
                        else
                            nextUpgrade = Language.GetTextValue($"Mods.CalamityMod.Items.Misc.CometShard.DisplayName");

                        return Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Upgrades.NextUpgrade", nextUpgrade);
                    }, 3f,
                    () =>
                    {
                        if (Main.LocalPlayer.Calamity().pHeart)
                        {
                            Main.LocalPlayer.Calamity().cShard = false;
                            Main.LocalPlayer.Calamity().eCore = false;
                            Main.LocalPlayer.Calamity().pHeart = false;
                        }
                        else if (Main.LocalPlayer.Calamity().eCore)
                        {
                            Main.LocalPlayer.Calamity().cShard = true;
                            Main.LocalPlayer.Calamity().eCore = true;
                            Main.LocalPlayer.Calamity().pHeart = true;
                        }
                        else if (Main.LocalPlayer.Calamity().cShard)
                        {
                            Main.LocalPlayer.Calamity().cShard = true;
                            Main.LocalPlayer.Calamity().eCore = true;
                            Main.LocalPlayer.Calamity().pHeart = false;
                        }
                        else
                        {
                            Main.LocalPlayer.Calamity().cShard = true;
                            Main.LocalPlayer.Calamity().eCore = false;
                            Main.LocalPlayer.Calamity().pHeart = false;
                        }
                    }, null, true, () => !AutomatedSystem, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Upgrades.AutoSystemDisable"));

                AddToggle("UpgradesManager", ModContent.Request<Texture2D>("ToastyQoLCalamity/Assets/UI/MushroomPlasmaRoot", AssetRequestMode.ImmediateLoad).Value,
                    ModContent.Request<Texture2D>("ToastyQoLCalamity/Assets/UI/MushroomPlasmaRootGlow", AssetRequestMode.ImmediateLoad).Value, () => { return Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Upgrades.ToggleRage"); },
                    () =>
                    {
                        string nextUpgrade;
                        if (Main.LocalPlayer.Calamity().rageBoostThree)
                            nextUpgrade = Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Upgrades.NoUpgrades");
                        else if (Main.LocalPlayer.Calamity().rageBoostTwo)
                            nextUpgrade = Language.GetTextValue($"Mods.CalamityMod.Items.Misc.RedLightningContainer.DisplayName");
                        else if (Main.LocalPlayer.Calamity().rageBoostOne)
                            nextUpgrade = Language.GetTextValue($"Mods.CalamityMod.Items.Misc.InfernalBlood.DisplayName");
                        else
                            nextUpgrade = Language.GetTextValue($"Mods.CalamityMod.Items.Misc.MushroomPlasmaRoot.DisplayName");

                        return Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Upgrades.NextUpgrade", nextUpgrade);
                    }, 4f,
                    () =>
                    {
                        if (Main.LocalPlayer.Calamity().rageBoostThree)
                        {
                            Main.LocalPlayer.Calamity().rageBoostOne = false;
                            Main.LocalPlayer.Calamity().rageBoostTwo = false;
                            Main.LocalPlayer.Calamity().rageBoostThree = false;
                        }
                        else if (Main.LocalPlayer.Calamity().rageBoostTwo)
                        {
                            Main.LocalPlayer.Calamity().rageBoostOne = true;
                            Main.LocalPlayer.Calamity().rageBoostTwo = true;
                            Main.LocalPlayer.Calamity().rageBoostThree = true;
                        }
                        else if (Main.LocalPlayer.Calamity().rageBoostOne)
                        {
                            Main.LocalPlayer.Calamity().rageBoostOne = true;
                            Main.LocalPlayer.Calamity().rageBoostTwo = true;
                            Main.LocalPlayer.Calamity().rageBoostThree = false;
                        }
                        else
                        {
                            Main.LocalPlayer.Calamity().rageBoostOne = true;
                            Main.LocalPlayer.Calamity().rageBoostTwo = false;
                            Main.LocalPlayer.Calamity().rageBoostThree = false;
                        }
                    }, null, true, () => !AutomatedSystem, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Upgrades.AutoSystemDisable"));

                AddToggle("UpgradesManager", ModContent.Request<Texture2D>("ToastyQoLCalamity/Assets/UI/ElectrolyteGelPack", AssetRequestMode.ImmediateLoad).Value,
                    ModContent.Request<Texture2D>("ToastyQoLCalamity/Assets/UI/ElectrolyteGelPackGlow", AssetRequestMode.ImmediateLoad).Value, () => { return Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Upgrades.ToggleAdren"); },
                    () =>
                    {
                        string nextUpgrade;
                        if (Main.LocalPlayer.Calamity().adrenalineBoostThree)
                            nextUpgrade = Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Upgrades.NoUpgrades");
                        else if (Main.LocalPlayer.Calamity().adrenalineBoostTwo)
                            nextUpgrade = Language.GetTextValue($"Mods.CalamityMod.Items.Misc.Ectoheart.DisplayName");
                        else if (Main.LocalPlayer.Calamity().adrenalineBoostOne)
                            nextUpgrade = Language.GetTextValue($"Mods.CalamityMod.Items.Misc.StarlightFuelCell.DisplayName");
                        else
                            nextUpgrade = Language.GetTextValue($"Mods.CalamityMod.Items.Misc.ElectrolyteGelPack.DisplayName");

                        return Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Upgrades.NextUpgrade", nextUpgrade);
                    }, 5f,
                    () =>
                    {
                        if (Main.LocalPlayer.Calamity().adrenalineBoostThree)
                        {
                            Main.LocalPlayer.Calamity().adrenalineBoostOne = false;
                            Main.LocalPlayer.Calamity().adrenalineBoostTwo = false;
                            Main.LocalPlayer.Calamity().adrenalineBoostThree = false;
                        }
                        else if (Main.LocalPlayer.Calamity().adrenalineBoostTwo)
                        {
                            Main.LocalPlayer.Calamity().adrenalineBoostOne = true;
                            Main.LocalPlayer.Calamity().adrenalineBoostTwo = true;
                            Main.LocalPlayer.Calamity().adrenalineBoostThree = true;
                        }
                        else if (Main.LocalPlayer.Calamity().adrenalineBoostOne)
                        {
                            Main.LocalPlayer.Calamity().adrenalineBoostOne = true;
                            Main.LocalPlayer.Calamity().adrenalineBoostTwo = true;
                            Main.LocalPlayer.Calamity().adrenalineBoostThree = false;
                        }
                        else
                        {
                            Main.LocalPlayer.Calamity().adrenalineBoostOne = true;
                            Main.LocalPlayer.Calamity().adrenalineBoostTwo = false;
                            Main.LocalPlayer.Calamity().adrenalineBoostThree = false;
                        }
                    }, null, true, () => !AutomatedSystem, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Upgrades.AutoSystemDisable"));

                AddToggle("UpgradesManager", ModContent.Request<Texture2D>("ToastyQoLCalamity/Assets/UI/DemonHeart", AssetRequestMode.ImmediateLoad).Value,
                    ModContent.Request<Texture2D>("ToastyQoLCalamity/Assets/UI/DemonHeartGlow", AssetRequestMode.ImmediateLoad).Value, () => { return Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Upgrades.ToggleAccessory"); },
                    () =>
                    {
                        string nextUpgrade;
                        if (Main.LocalPlayer.Calamity().extraAccessoryML)
                            nextUpgrade = Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Upgrades.NoUpgrades");
                        else if (Main.LocalPlayer.extraAccessory)
                            nextUpgrade = Language.GetTextValue($"Mods.CalamityMod.Items.Misc.CelestialOnion.DisplayName");
                        else
                            nextUpgrade = Language.GetTextValue($"ItemName.DemonHeart");

                        return Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Upgrades.NextUpgrade", nextUpgrade);
                    }, 6f,
                    () =>
                    {
                        if (Main.LocalPlayer.Calamity().extraAccessoryML)
                        {
                            Main.LocalPlayer.extraAccessory = false;
                            Main.LocalPlayer.Calamity().extraAccessoryML = false;
                        }
                        else if (Main.LocalPlayer.extraAccessory)
                        {
                            Main.LocalPlayer.extraAccessory = true;
                            Main.LocalPlayer.Calamity().extraAccessoryML = true;
                        }
                        else
                        {
                            Main.LocalPlayer.extraAccessory = true;
                            Main.LocalPlayer.Calamity().extraAccessoryML = false;
                        }
                    }, null, true, () => !AutomatedSystem, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Upgrades.AutoSystemDisable"));
            }
        }
    }
}
