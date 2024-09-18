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

            AddBossSpecificSassQuote(ModContent.NPCType<Cryogen>(), [Language.GetTextValue($"Mods.ToastyQoLCalamity.SassQuotes.Cryogen")]);
            AddBossSpecificSassQuote(ModContent.NPCType<Yharon>(), [Language.GetTextValue($"Mods.ToastyQoLCalamity.SassQuotes.Yharon")]);
            AddBossSpecificSassQuote(ModContent.NPCType<SupremeCalamitas>(), [ Language.GetTextValue($"Mods.ToastyQoLCalamity.SassQuotes.Scal"), Language.GetTextValue($"Mods.ToastyQoLCalamity.SassQuotes.ScalAlt")]);
            AddBossSpecificSassQuote(ModContent.NPCType<Apollo>(), [Language.GetTextValue($"Mods.ToastyQoLCalamity.SassQuotes.Draedon")]);
            AddBossSpecificSassQuote(ModContent.NPCType<Artemis>(), [Language.GetTextValue($"Mods.ToastyQoLCalamity.SassQuotes.Draedon")]);
            AddBossSpecificSassQuote(ModContent.NPCType<AresBody>(), [Language.GetTextValue($"Mods.ToastyQoLCalamity.SassQuotes.Draedon")]);
            AddBossSpecificSassQuote(ModContent.NPCType<ThanatosHead>(), [Language.GetTextValue($"Mods.ToastyQoLCalamity.SassQuotes.Draedon")]);
            AddBossSpecificSassQuote(ModContent.NPCType<HiveMind>(), [Language.GetTextValue($"Mods.ToastyQoL.SassQuotes.Specific.QueenBee")]);
            AddBossSpecificSassQuote(ModContent.NPCType<PlaguebringerGoliath>(), [Language.GetTextValue($"Mods.ToastyQoL.SassQuotes.Specific.QueenBee")]);
            AddBossSpecificSassQuote(ModContent.NPCType<Crabulon>(), [Language.GetTextValue($"Mods.ToastyQoLCalamity.SassQuotes.Crabulon")]);
            AddBossSpecificSassQuote(ModContent.NPCType<AquaticScourgeHead>(), [Language.GetTextValue($"Mods.ToastyQoLCalamity.SassQuotes.Salt")]);
            AddBossSpecificSassQuote(ModContent.NPCType<Leviathan>(), [Language.GetTextValue($"Mods.ToastyQoLCalamity.SassQuotes.Salt"), Language.GetTextValue($"Mods.ToastyQoL.SassQuotes.Specific.Fishron")]);
            AddBossSpecificSassQuote(ModContent.NPCType<Anahita>(), [Language.GetTextValue($"Mods.ToastyQoLCalamity.SassQuotes.Salt"), Language.GetTextValue($"Mods.ToastyQoL.SassQuotes.Specific.Fishron")]);
            AddBossSpecificSassQuote(ModContent.NPCType<OldDuke>(), [Language.GetTextValue($"Mods.ToastyQoL.SassQuotes.Specific.Fishron"), Language.GetTextValue($"Mods.ToastyQoL.SassQuotes.FishronAlt")]);
        }
    }
}
