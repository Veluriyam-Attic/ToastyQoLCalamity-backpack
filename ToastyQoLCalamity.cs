global using ToastyQoL;
using Terraria.ModLoader;
using ToastyQoLCalamity.Core.Calls;

namespace ToastyQoLCalamity
{
    public partial class ToastyQoLCalamity : Mod
	{
        public static Mod ToastyQoLMod
        {
            get;
            private set;
        }
        
        public static Mod InfernumMod
        {
            get;
            private set;
        }

        public static bool InfernumModeEnabled
        {
            get
            {
                if (InfernumMod == null)
                    return false;

                return (bool)InfernumMod.Call("GetInfernumActive");
            }
        }

        public override void Load()
        {
            if (ModLoader.TryGetMod("InfernumMode", out Mod infernumMod))
                InfernumMod = infernumMod;

            if (ModLoader.TryGetMod("ToastyQoL", out var mod))
                ToastyQoLMod = mod;
            else
                return;

            UpgradesPage.Create();
            BossToggleLoader.SetupBossToggles();
            LockInformationLoader.LoadLockInfo();
            OtherTogglesLoader.Load();
            ShroomDrawingExtraInfo.LoadExtraShroomDrawFuncs();
            MNLLoader.Load();
            PotionLoader.Load();
        }

        public override void Unload()
        {
            ToastyQoLMod = null;
        }
    }
}