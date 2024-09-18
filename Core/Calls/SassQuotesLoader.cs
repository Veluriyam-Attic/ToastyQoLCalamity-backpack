using CalamityMod.NPCs.AquaticScourge;
using CalamityMod.NPCs.Crabulon;
using CalamityMod.NPCs.Cryogen;
using CalamityMod.NPCs.ExoMechs.Apollo;
using CalamityMod.NPCs.ExoMechs.Ares;
using CalamityMod.NPCs.ExoMechs.Artemis;
using CalamityMod.NPCs.ExoMechs.Thanatos;
using CalamityMod.NPCs.HiveMind;
using CalamityMod.NPCs.Leviathan;
using CalamityMod.NPCs.OldDuke;
using CalamityMod.NPCs.PlaguebringerGoliath;
using CalamityMod.NPCs.SupremeCalamitas;
using CalamityMod.NPCs.Yharon;
using Terraria.Localization;
using Terraria.ModLoader;
using static ToastyQoLCalamity.ToastyQoLCalamity;

namespace ToastyQoLCalamity.Core.Calls
{
    public static class SassQuotesLoader
    {
        public static void Load()
        {
            AddSassQuoteLose(Language.GetTextValue($"Mods.ToastyQoLCalamity.SassQuotes.DifficultyIndicator"));
            AddSassQuoteLose(Language.GetTextValue($"Mods.ToastyQoLCalamity.SassQuotes.CMT"));

            AddSassQuoteWin(Language.GetTextValue($"Mods.ToastyQoLCalamity.SassQuotes.Calamity.1") +
                Language.GetTextValue($"Mods.ToastyQoLCalamity.SassQuotes.Calamity.2") +
                Language.GetTextValue($"Mods.ToastyQoLCalamity.SassQuotes.Calamity.3"));

            AddBossSpecificSassQuote(ModContent.NPCType<Cryogen>(), ["You need to chill out."]);
            AddBossSpecificSassQuote(ModContent.NPCType<Yharon>(), [Language.GetTextValue($"Mods.ToastyQoLCalamity.SassQuotes.Yharon")]);
            AddBossSpecificSassQuote(ModContent.NPCType<SupremeCalamitas>(), [ "I bet you're going to go spam ping someone in #nohit-discussion now aren't you. Spoiler: No one cares.", 
                "Another BH1 death?" ]);
            AddBossSpecificSassQuote(ModContent.NPCType<Apollo>(), [Language.GetTextValue($"Mods.ToastyQoLCalamity.SassQuotes.Draedon")]);
            AddBossSpecificSassQuote(ModContent.NPCType<Artemis>(), [Language.GetTextValue($"Mods.ToastyQoLCalamity.SassQuotes.Draedon")]);
            AddBossSpecificSassQuote(ModContent.NPCType<AresBody>(), [Language.GetTextValue($"Mods.ToastyQoLCalamity.SassQuotes.Draedon")]);
            AddBossSpecificSassQuote(ModContent.NPCType<ThanatosHead>(), [Language.GetTextValue($"Mods.ToastyQoLCalamity.SassQuotes.Draedon")]);
            AddBossSpecificSassQuote(ModContent.NPCType<HiveMind>(), ["'Hive' got a plan for you: Give up."]);
            AddBossSpecificSassQuote(ModContent.NPCType<PlaguebringerGoliath>(), ["'Hive' got a plan for you: Give up."]);
            AddBossSpecificSassQuote(ModContent.NPCType<Crabulon>(), ["I better not see this RRed 10 times..."]);
            AddBossSpecificSassQuote(ModContent.NPCType<AquaticScourgeHead>(), ["Excessive Salt can lead to high blood pressure."]);
            AddBossSpecificSassQuote(ModContent.NPCType<Leviathan>(), ["Excessive Salt can lead to high blood pressure.", "Don't fish for compliments."]);
            AddBossSpecificSassQuote(ModContent.NPCType<Anahita>(), ["Excessive Salt can lead to high blood pressure.", "Don't fish for compliments."]);
            AddBossSpecificSassQuote(ModContent.NPCType<OldDuke>(), ["Don't fish for compliments.", "Double tap to dash!"]);
        }
    }
}
