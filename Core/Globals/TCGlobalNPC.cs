using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ToastyQoLCalamity.Core.Globals
{
    public class TCGlobalNPC : GlobalNPC
    {
        public override void OnKill(NPC npc)
        {
            if (BossRushModPlayer.IsBossRushActive && ToastyQoLCalamity.GetToggleStatus("MNLIndicator") && npc.boss == true)
            {
                TimeSpan time = TimeSpan.FromSeconds(BossRushModPlayer.BossRushActiveFrames / 60);

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
                ToastyQoLUtils.DisplayText(Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.MNL", line));
            }
        }
    }
}
