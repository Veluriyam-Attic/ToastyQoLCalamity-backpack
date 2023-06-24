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
            AddBossToggle("ToastyQoLCalamity/Assets/UI/desertScourge", "Desert Scourge",
                typeof(DownedBossSystem).GetField("_downedDesertScourge", ToastyQoLUtils.UniversalBindingFlags), 1.5f, 0.8f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/crabulon", "Crabulon",
                typeof(DownedBossSystem).GetField("_downedCrabulon", ToastyQoLUtils.UniversalBindingFlags), 2.5f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/hiveMind", "Hive Mind",
                typeof(DownedBossSystem).GetField("_downedHiveMind", ToastyQoLUtils.UniversalBindingFlags), 4.4f, 0.8f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/perforators", "Perforator Hive",
                typeof(DownedBossSystem).GetField("_downedPerforator", ToastyQoLUtils.UniversalBindingFlags), 4.6f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/slimeGod", "Slime God",
                typeof(DownedBossSystem).GetField("_downedSlimeGod", ToastyQoLUtils.UniversalBindingFlags), 7.5f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/cryogen", "Cryogen",
                typeof(DownedBossSystem).GetField("_downedCryogen", ToastyQoLUtils.UniversalBindingFlags), 9.5f, 0.9f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/brimmy", "Brimstone Elemental",
                typeof(DownedBossSystem).GetField("_downedBrimstoneElemental", ToastyQoLUtils.UniversalBindingFlags), 10.5f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/aquaticScourge", "Aquatic Scourge",
                typeof(DownedBossSystem).GetField("_downedAquaticScourge", ToastyQoLUtils.UniversalBindingFlags), 11.5f, 0.9f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/clone", "Calamitas",
                typeof(DownedBossSystem).GetField("_downedCalamitasClone", ToastyQoLUtils.UniversalBindingFlags), 13.3f, 0.9f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/levi", "Leviathan",
                typeof(DownedBossSystem).GetField("_downedLeviathan", ToastyQoLUtils.UniversalBindingFlags), 13.5f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/aureus", "Astrum Aureus",
                typeof(DownedBossSystem).GetField("_downedAstrumAureus", ToastyQoLUtils.UniversalBindingFlags), 13.8f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/pbg", "Plaguebringer Goliath",
                typeof(DownedBossSystem).GetField("_downedPlaguebringer", ToastyQoLUtils.UniversalBindingFlags), 14.5f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/ravager", "Ravager",
                typeof(DownedBossSystem).GetField("_downedRavager", ToastyQoLUtils.UniversalBindingFlags), 16.5f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/deus", "Astrum Deus",
                typeof(DownedBossSystem).GetField("_downedAstrumDeus", ToastyQoLUtils.UniversalBindingFlags), 17.5f, 0.9f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/guardians", "Profaned Guardian",
                typeof(DownedBossSystem).GetField("_downedGuardians", ToastyQoLUtils.UniversalBindingFlags), 19f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/folly", "Dragonfolly",
                typeof(DownedBossSystem).GetField("_downedDragonfolly", ToastyQoLUtils.UniversalBindingFlags), 20f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/provi", "Providence",
                typeof(DownedBossSystem).GetField("_downedProvidence", ToastyQoLUtils.UniversalBindingFlags), 21f, 0.8f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/void", "Ceaseless Void",
                typeof(DownedBossSystem).GetField("_downedCeaselessVoid", ToastyQoLUtils.UniversalBindingFlags), 22f, 0.8f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/weaver", "Storm Weaver",
                typeof(DownedBossSystem).GetField("_downedStormWeaver", ToastyQoLUtils.UniversalBindingFlags), 23f, 0.8f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/signus", "Signus",
                typeof(DownedBossSystem).GetField("_downedSignus", ToastyQoLUtils.UniversalBindingFlags), 24f, 0.8f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/polter", "Polterghast",
                typeof(DownedBossSystem).GetField("_downedPolterghast", ToastyQoLUtils.UniversalBindingFlags), 25f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/oldDuke", "Old Duke",
                typeof(DownedBossSystem).GetField("_downedBoomerDuke", ToastyQoLUtils.UniversalBindingFlags), 26f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/dog", "Devourer of God",
                typeof(DownedBossSystem).GetField("_downedDoG", ToastyQoLUtils.UniversalBindingFlags), 27f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/yharon", "Yharon",
                typeof(DownedBossSystem).GetField("_downedYharon", ToastyQoLUtils.UniversalBindingFlags), 28f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/chin", "Exo Mech",
                typeof(DownedBossSystem).GetField("_downedExoMechs", ToastyQoLUtils.UniversalBindingFlags), 29f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/scal", "Supreme Calamitas",
                typeof(DownedBossSystem).GetField("_downedCalamitas", ToastyQoLUtils.UniversalBindingFlags), 30f);

            AddBossToggle("ToastyQoLCalamity/Assets/UI/aew", "Adult Eidolon Wyrm",
                typeof(DownedBossSystem).GetField("_downedAdultEidolonWyrm", ToastyQoLUtils.UniversalBindingFlags), 31f);
        }
    }
}
