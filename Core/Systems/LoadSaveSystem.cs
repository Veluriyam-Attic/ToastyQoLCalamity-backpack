using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using static ToastyQoLCalamity.Core.CalToggles;

namespace ToastyQoLCalamity.Core.Systems
{
    public class LoadSaveSystem : ModSystem
    {
        internal static bool CalamityCallQueued = false;
        private static void ResetToggles()
        {
            AutomatedSystem = false;
            AutoChargeDraedonWeapons = false;
            TesterTimes = false;
        }

        public override void OnWorldLoad() => ResetToggles();

        public override void PreWorldGen() => ResetToggles();

        public override void LoadWorldData(TagCompound tag)
        {
            AutomatedSystem = tag.GetBool("TQCAutomatedSystem");
            AutoChargeDraedonWeapons = tag.GetBool("TQCAutoChargeDraedonWeapons");
            TesterTimes = tag.GetBool("TQCTesterTimes");
        }

        public override void SaveWorldData(TagCompound tag)
        {
            tag["TQCAutomatedSystem"] = AutomatedSystem;
            tag["TQCAutoChargeDraedonWeapons"] = AutoChargeDraedonWeapons;
            tag["TQCTesterTimes"] = TesterTimes;
        }

        public override void PreUpdateEntities()
        {
            if (CalamityCallQueued)
            {
                if (ModLoader.TryGetMod("CalamityMod", out Mod calamity))
                {
                    bool instantDeathActive = ToastyQoLCalamity.GetToggleStatus("InstantDeath");
                    calamity.Call(new object[3] { "SetDifficultyActive", "armageddon", instantDeathActive });
                    calamity.Call(new object[2] { "DisableAllDodges", instantDeathActive });
                }
                CalamityCallQueued = false;
            }
        }
    }
}
