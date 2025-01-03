using Terraria.Localization;
using CalamityMod;
using static ToastyQoLCalamity.ToastyQoLCalamity;

namespace ToastyQoLCalamity.Core.Calls
{
    /// <summary>
    /// An example of how to add boss toggles to the boss toggle UI.
    /// </summary>
    public static class BossToggleLoader
    {
        public static void SetupBossToggles()
        {
            AddBossToggle("ToastyQoLCalamity/Assets/UI/desertScourge", Language.GetTextValue($"Mods.CalamityMod.NPCs.DesertScourgeHead.DisplayName"),
                typeof(DownedBossSystem).GetField("_downedDesertScourge", ToastyQoLUtils.UniversalBindingFlags), 1.5f, 0.8f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/crabulon", Language.GetTextValue($"Mods.CalamityMod.NPCs.Crabulon.DisplayName"),
                typeof(DownedBossSystem).GetField("_downedCrabulon", ToastyQoLUtils.UniversalBindingFlags), 2.5f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/hiveMind", Language.GetTextValue($"Mods.CalamityMod.NPCs.HiveMind.DisplayName"),
                typeof(DownedBossSystem).GetField("_downedHiveMind", ToastyQoLUtils.UniversalBindingFlags), 4.4f, 0.8f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/perforators", Language.GetTextValue($"Mods.CalamityMod.NPCs.PerforatorHive.DisplayName"),
                typeof(DownedBossSystem).GetField("_downedPerforator", ToastyQoLUtils.UniversalBindingFlags), 4.6f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/slimeGod", Language.GetTextValue($"Mods.CalamityMod.NPCs.SlimeGodCore.DisplayName"),
                typeof(DownedBossSystem).GetField("_downedSlimeGod", ToastyQoLUtils.UniversalBindingFlags), 7.5f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/cryogen", Language.GetTextValue($"Mods.CalamityMod.NPCs.Cryogen.DisplayName"),
                typeof(DownedBossSystem).GetField("_downedCryogen", ToastyQoLUtils.UniversalBindingFlags), 9.5f, 0.9f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/brimmy", Language.GetTextValue($"Mods.CalamityMod.NPCs.BrimstoneElemental.DisplayName"),
                typeof(DownedBossSystem).GetField("_downedBrimstoneElemental", ToastyQoLUtils.UniversalBindingFlags), 10.5f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/aquaticScourge", Language.GetTextValue($"Mods.CalamityMod.NPCs.AquaticScourgeHead.DisplayName"),
                typeof(DownedBossSystem).GetField("_downedAquaticScourge", ToastyQoLUtils.UniversalBindingFlags), 11.5f, 0.9f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/clone", Language.GetTextValue($"Mods.CalamityMod.NPCs.CalamitasClone.DisplayName"),
                typeof(DownedBossSystem).GetField("_downedCalamitasClone", ToastyQoLUtils.UniversalBindingFlags), 13.3f, 0.9f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/levi", Language.GetTextValue($"Mods.CalamityMod.Items.Lore.LoreLeviathanAnahita.DisplayName"),
                typeof(DownedBossSystem).GetField("_downedLeviathan", ToastyQoLUtils.UniversalBindingFlags), 13.5f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/aureus", Language.GetTextValue($"Mods.CalamityMod.NPCs.AstrumAureus.DisplayName"),
                typeof(DownedBossSystem).GetField("_downedAstrumAureus", ToastyQoLUtils.UniversalBindingFlags), 13.8f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/pbg", Language.GetTextValue($"Mods.CalamityMod.NPCs.PlaguebringerGoliath.DisplayName"),
                typeof(DownedBossSystem).GetField("_downedPlaguebringer", ToastyQoLUtils.UniversalBindingFlags), 14.5f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/ravager", Language.GetTextValue($"Mods.CalamityMod.NPCs.RavagerBody.DisplayName"),
                typeof(DownedBossSystem).GetField("_downedRavager", ToastyQoLUtils.UniversalBindingFlags), 16.5f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/deus", Language.GetTextValue($"Mods.CalamityMod.NPCs.AstrumDeusHead.DisplayName"),
                typeof(DownedBossSystem).GetField("_downedAstrumDeus", ToastyQoLUtils.UniversalBindingFlags), 17.5f, 0.9f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/guardians", Language.GetTextValue($"Mods.CalamityMod.BossChecklistIntegration.ProfanedGuardians.EntryName"),
                typeof(DownedBossSystem).GetField("_downedGuardians", ToastyQoLUtils.UniversalBindingFlags), 19f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/folly", Language.GetTextValue($"Mods.CalamityMod.NPCs.Bumblefuck.DisplayName"),
                typeof(DownedBossSystem).GetField("_downedDragonfolly", ToastyQoLUtils.UniversalBindingFlags), 20f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/provi", Language.GetTextValue($"Mods.CalamityMod.NPCs.Providence.DisplayName"),
                typeof(DownedBossSystem).GetField("_downedProvidence", ToastyQoLUtils.UniversalBindingFlags), 21f, 0.8f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/void", Language.GetTextValue($"Mods.CalamityMod.NPCs.CeaselessVoid.DisplayName"),
                typeof(DownedBossSystem).GetField("_downedCeaselessVoid", ToastyQoLUtils.UniversalBindingFlags), 22f, 0.8f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/weaver", Language.GetTextValue($"Mods.CalamityMod.NPCs.StormWeaverHead.DisplayName"),
                typeof(DownedBossSystem).GetField("_downedStormWeaver", ToastyQoLUtils.UniversalBindingFlags), 23f, 0.8f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/signus", Language.GetTextValue($"Mods.CalamityMod.NPCs.Signus.DisplayName"),
                typeof(DownedBossSystem).GetField("_downedSignus", ToastyQoLUtils.UniversalBindingFlags), 24f, 0.8f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/polter", Language.GetTextValue($"Mods.CalamityMod.NPCs.Polterghast.DisplayName"),
                typeof(DownedBossSystem).GetField("_downedPolterghast", ToastyQoLUtils.UniversalBindingFlags), 25f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/oldDuke", Language.GetTextValue($"Mods.CalamityMod.NPCs.OldDuke.DisplayName"),
                typeof(DownedBossSystem).GetField("_downedBoomerDuke", ToastyQoLUtils.UniversalBindingFlags), 26f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/dog", Language.GetTextValue($"Mods.CalamityMod.NPCs.DevourerofGodsHead.DisplayName"),
                typeof(DownedBossSystem).GetField("_downedDoG", ToastyQoLUtils.UniversalBindingFlags), 27f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/yharon", Language.GetTextValue($"Mods.CalamityMod.NPCs.Yharon.DisplayName"),
                typeof(DownedBossSystem).GetField("_downedYharon", ToastyQoLUtils.UniversalBindingFlags), 28f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/chin", Language.GetTextValue($"Mods.CalamityMod.BossChecklistIntegration.ExoMechs.EntryName"),
                typeof(DownedBossSystem).GetField("_downedExoMechs", ToastyQoLUtils.UniversalBindingFlags), 29f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/scal", Language.GetTextValue($"Mods.CalamityMod.NPCs.SupremeCalamitas.DisplayName"),
                typeof(DownedBossSystem).GetField("_downedCalamitas", ToastyQoLUtils.UniversalBindingFlags), 30f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/aew", Language.GetTextValue($"Mods.CalamityMod.NPCs.PrimordialWyrmHead.DisplayName"),
                typeof(DownedBossSystem).GetField("_downedPrimordialWyrm", ToastyQoLUtils.UniversalBindingFlags), 31f);
        }
    }
}
