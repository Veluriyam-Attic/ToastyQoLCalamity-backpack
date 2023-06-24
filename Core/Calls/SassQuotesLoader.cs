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
using Terraria.ModLoader;
using static ToastyQoLCalamity.ToastyQoLCalamity;

namespace ToastyQoLCalamity.Core.Calls
{
    public static class SassQuotesLoader
    {
        public static void Load()
        {
            AddSassQuoteLose("You can adjust the difficulty by clicking on the difficulty indicator in the top right corner!");
            AddSassQuoteLose("Did you get your loadout from CMT?");

            AddSassQuoteWin("You have been a Calamity to my kingdom.I only wanted my Revengeance, but you in your Vanities have led me to my Death. " +
                "Your Iron Heart is truly full of Malice. You may have Defiled this world and Catalyzed the arrival of Armageddon upon it, but I will not allow you to send me to the " +
                "depths of Infernum!");

            AddBossSpecificSassQuote(ModContent.NPCType<Cryogen>(), new() { "You need to chill out." });
            AddBossSpecificSassQuote(ModContent.NPCType<Yharon>(), new() { "This is my MESSAGE TO MY MASTER, this is a FIGHT YOU DID NOT WIN!" });
            AddBossSpecificSassQuote(ModContent.NPCType<SupremeCalamitas>(), new() { "I bet you're going to go spam ping someone in #nohit-discussion now aren't you. Spoiler: No one cares.", 
                "Another BH1 death?" });
            AddBossSpecificSassQuote(ModContent.NPCType<Apollo>(), new() { "You fell right into his calculations..." });
            AddBossSpecificSassQuote(ModContent.NPCType<Artemis>(), new() { "You fell right into his calculations..." });
            AddBossSpecificSassQuote(ModContent.NPCType<AresBody>(), new() { "You fell right into his calculations..." });
            AddBossSpecificSassQuote(ModContent.NPCType<ThanatosHead>(), new() { "You fell right into his calculations..." });
            AddBossSpecificSassQuote(ModContent.NPCType<HiveMind>(), new() { "'Hive' got a plan for you: Give up." });
            AddBossSpecificSassQuote(ModContent.NPCType<PlaguebringerGoliath>(), new() { "'Hive' got a plan for you: Give up." });
            AddBossSpecificSassQuote(ModContent.NPCType<Crabulon>(), new() { "I better not see this RRed 10 times..." });
            AddBossSpecificSassQuote(ModContent.NPCType<AquaticScourgeHead>(), new() { "Excessive Salt can lead to high blood pressure." });
            AddBossSpecificSassQuote(ModContent.NPCType<Leviathan>(), new() { "Excessive Salt can lead to high blood pressure.", "Don't fish for compliments." });
            AddBossSpecificSassQuote(ModContent.NPCType<Anahita>(), new() { "Excessive Salt can lead to high blood pressure.", "Don't fish for compliments." });
            AddBossSpecificSassQuote(ModContent.NPCType<OldDuke>(), new() { "Don't fish for compliments.", "Double tap to dash!" });
        }
    }
}
