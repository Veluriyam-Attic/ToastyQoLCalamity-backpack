using CalamityMod.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader.IO;
using Terraria.ModLoader;
using ToastyQoL.Core.Systems.MNLSystems;
using Terraria;

namespace ToastyQoLCalamity.Core.Globals
{
    public class BossRushModPlayer : ModPlayer
    {
        // Boss Rush Stats
        internal static bool IsBossRushActive = false;

        internal static bool WasBossRushJustDisabled = false;

        internal static int BossRushActiveFrames = 0;

        public const int BossRushMNL = 34200;

        internal static int BRDelayTimer = 0;

        public Dictionary<string, int> BRAttempts = new()
        {
            ["Boss Rush"] = 0
        };

        public override void PreUpdate()
        {
            if (WasBossRushJustDisabled)
            {
                if (BRDelayTimer == 0)
                {
                    WasBossRushJustDisabled = false;
                    IsBossRushActive = false;
                    int finalBRTimeFrames = BossRushActiveFrames;
                    int amountUnder = BossRushMNL - BossRushActiveFrames;
                    BossRushActiveFrames = 0;
                    bool overMNL = amountUnder >= 0;
                    TimeSpan time = TimeSpan.FromSeconds(finalBRTimeFrames / 60);

                    string hours;
                    if (time.Hours < 1 && time.Days < 1)
                        hours = "";
                    else
                        hours = (time.Days * 24 + time.Hours).ToString() + ":";

                    string minutes;
                    if (hours != "" || time.Minutes >= 10)
                        minutes = time.Minutes.ToString() + ":";
                    else
                        minutes = "0" + time.Minutes.ToString() + ":";

                    string seconds;
                    if (time.Seconds >= 10)
                        seconds = time.Seconds.ToString();
                    else
                        seconds = "0" + time.Seconds.ToString();

                    string line = hours + minutes + seconds;
                    TimeSpan mnlTime = TimeSpan.FromSeconds(amountUnder / 60);

                    if (mnlTime.Hours < 1 && mnlTime.Days < 1)
                        hours = "";
                    else
                        hours = (mnlTime.Days * 24 + mnlTime.Hours).ToString() + ":";

                    if (hours != "" || mnlTime.Minutes >= 10)
                        minutes = mnlTime.Minutes.ToString() + ":";
                    else
                        minutes = "0" + mnlTime.Minutes.ToString() + ":";

                    if (mnlTime.Seconds >= 10)
                        seconds = mnlTime.Seconds.ToString();
                    else
                        seconds = "0" + mnlTime.Seconds.ToString();
                    string line2 = hours + minutes + seconds;

                    string underOrOverString = overMNL ? "over" : "under";
                    ToastyQoLUtils.DisplayText($"[c/e9341f:Boss Rush Attempt] {BRAttempts["Boss Rush"]} [c/e9341f:Stats:]");
                    ToastyQoLUtils.DisplayText($"[c/e7684b:Total Length:] [c/fccccf:{line}]");
                    ToastyQoLUtils.DisplayText($"[c/e7684b:Amount {underOrOverString} MNL:] [c/fccccf:{line2}]");
                }
                else
                    BRDelayTimer--;
            }

            if (BossRushEvent.BossRushActive && !IsBossRushActive && ToastyQoLCalamity.GetToggleStatus("MNLIndicator"))
                IsBossRushActive = true;

            if (!BossRushEvent.BossRushActive && IsBossRushActive && !WasBossRushJustDisabled)
            {
                BRAttempts["Boss Rush"]++;
                WasBossRushJustDisabled = true;
                BRDelayTimer = Main.LocalPlayer.respawnTimer + 7;
            }
        }

        public override void PostUpdateMiscEffects()
        {
            if (IsBossRushActive && !WasBossRushJustDisabled)
                BossRushActiveFrames++;
        }

        public override void OnRespawn(Player player)
        {
            if (player.whoAmI == Main.myPlayer)
                MNLsHandler.PlayerRespawnChecks();
        }

        public override void LoadData(TagCompound tag)
        {
            if (Main.netMode != NetmodeID.Server && Player.whoAmI == Main.myPlayer)
                BRAttempts["Boss Rush"] = tag.GetInt("Attempts");
        }
        public override void SaveData(TagCompound tag)
        {
            if (Main.netMode != NetmodeID.Server && Player.whoAmI == Main.myPlayer)
                tag["Attempts"] = BRAttempts.GetValueOrDefault("Boss Rush");
        }
    }
}
