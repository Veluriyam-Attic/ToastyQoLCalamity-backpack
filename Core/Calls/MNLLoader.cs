using CalamityMod.NPCs.PrimordialWyrm;
using CalamityMod.NPCs.AquaticScourge;
using CalamityMod.NPCs.AstrumAureus;
using CalamityMod.NPCs.AstrumDeus;
using CalamityMod.NPCs.BrimstoneElemental;
using CalamityMod.NPCs.Bumblebirb;
using CalamityMod.NPCs.CalClone;
using CalamityMod.NPCs.CeaselessVoid;
using CalamityMod.NPCs.Crabulon;
using CalamityMod.NPCs.Cryogen;
using CalamityMod.NPCs.DesertScourge;
using CalamityMod.NPCs.DevourerofGods;
using CalamityMod.NPCs.ExoMechs.Apollo;
using CalamityMod.NPCs.ExoMechs.Ares;
using CalamityMod.NPCs.ExoMechs.Artemis;
using CalamityMod.NPCs.ExoMechs.Thanatos;
using CalamityMod.NPCs.HiveMind;
using CalamityMod.NPCs.Leviathan;
using CalamityMod.NPCs.OldDuke;
using CalamityMod.NPCs.Perforator;
using CalamityMod.NPCs.PlaguebringerGoliath;
using CalamityMod.NPCs.Polterghast;
using CalamityMod.NPCs.ProfanedGuardians;
using CalamityMod.NPCs.Providence;
using CalamityMod.NPCs.Ravager;
using CalamityMod.NPCs.Signus;
using CalamityMod.NPCs.SlimeGod;
using CalamityMod.NPCs.StormWeaver;
using CalamityMod.NPCs.SupremeCalamitas;
using CalamityMod.NPCs.Yharon;
using CalamityMod.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria.ID;
using Terraria.ModLoader;
using static ToastyQoLCalamity.ToastyQoLCalamity;

namespace ToastyQoLCalamity.Core.Calls
{
    /// <summary>
    /// An example of how to add MNL Sets to use when certain conditions are met, done via modifying the weight value based on said conditions.
    /// </summary>
    public static class MNLLoader
    {
        // This is being used here to ensure that this is never picked over the base expert ones.
        public const float DontUseWeight = -1f;

        public const float RevengeWeight = 2f;

        public const float DeathWeight = 3f;

        public const float InfernumWeight = 4f;

        public static Dictionary<int, int> RevengeanceBossMNLS => new()
        {
            // PreHardmode
            [NPCID.KingSlime] = 2100,
            [ModContent.NPCType<DesertScourgeHead>()] = 2100,
            [NPCID.EyeofCthulhu] = 2700,
            [ModContent.NPCType<Crabulon>()] = 2700,
            [NPCID.EaterofWorldsHead] = 3000,
            [NPCID.BrainofCthulhu] = 3000,
            [ModContent.NPCType<HiveMind>()] = 3600,
            [ModContent.NPCType<PerforatorHive>()] = 3600,
            [NPCID.QueenBee] = 2700,
            [NPCID.Deerclops] = 3300,
            [NPCID.SkeletronHead] = 3600,
            [ModContent.NPCType<SlimeGodCore>()] = 4800,
            [NPCID.WallofFlesh] = 2400,
            // Hardmode
            [NPCID.QueenSlimeBoss] = 3900,
            [ModContent.NPCType<Cryogen>()] = 4200,
            [NPCID.Retinazer] = 4800,
            [NPCID.Spazmatism] = 4800,
            [ModContent.NPCType<BrimstoneElemental>()] = 4500,
            [NPCID.TheDestroyer] = 3900,
            [ModContent.NPCType<AquaticScourgeHead>()] = 3300,
            [NPCID.SkeletronPrime] = 4500,
            [ModContent.NPCType<CalamitasClone>()] = 6600,
            [NPCID.Plantera] = 4200,
            [ModContent.NPCType<Leviathan>()] = 6000,
            [ModContent.NPCType<Anahita>()] = 6000,
            [ModContent.NPCType<AstrumAureus>()] = 4200,
            [NPCID.Golem] = 3300,
            [ModContent.NPCType<PlaguebringerGoliath>()] = 3600,
            [NPCID.HallowBoss] = 5100,
            [NPCID.DukeFishron] = 3600,
            [ModContent.NPCType<RavagerBody>()] = 4200,
            [NPCID.CultistBoss] = 3300,
            [ModContent.NPCType<AstrumDeusHead>()] = 5100,
            [NPCID.MoonLordCore] = 7200,
            // PostMoonlord
            [ModContent.NPCType<ProfanedGuardianCommander>()] = 4200,
            [ModContent.NPCType<Bumblefuck>()] = 3900,
            [ModContent.NPCType<Providence>()] = 7200,
            [ModContent.NPCType<StormWeaverHead>()] = 3300,
            [ModContent.NPCType<CeaselessVoid>()] = 5100,
            [ModContent.NPCType<Signus>()] = 3300,
            [ModContent.NPCType<Polterghast>()] = 5100,
            [ModContent.NPCType<OldDuke>()] = 4800,
            [ModContent.NPCType<DevourerofGodsHead>()] = 7800,
            [ModContent.NPCType<Yharon>()] = 7200,
            [ModContent.NPCType<SupremeCalamitas>()] = 12000,
            [ModContent.NPCType<Artemis>()] = 9000,
            [ModContent.NPCType<Apollo>()] = 9000,
            [ModContent.NPCType<AresBody>()] = 9000,
            [ModContent.NPCType<ThanatosHead>()] = 9000,
        };

        public static Dictionary<int, int> DeathModeMNLs => new()
        {
            // PreHardmode
            [NPCID.KingSlime] = 2100,
            [ModContent.NPCType<DesertScourgeHead>()] = 2100,
            [NPCID.EyeofCthulhu] = 2700,
            [ModContent.NPCType<Crabulon>()] = 2700,
            [NPCID.EaterofWorldsHead] = 3000,
            [NPCID.BrainofCthulhu] = 3000,
            [ModContent.NPCType<HiveMind>()] = 3600,
            [ModContent.NPCType<PerforatorHive>()] = 3600,
            [NPCID.QueenBee] = 2700,
            [NPCID.Deerclops] = 3300,
            [NPCID.SkeletronHead] = 3600,
            [ModContent.NPCType<SlimeGodCore>()] = 4800,
            [NPCID.WallofFlesh] = 2400,
            // Hardmode
            [NPCID.QueenSlimeBoss] = 3900,
            [ModContent.NPCType<Cryogen>()] = 4200,
            [NPCID.Retinazer] = 4800,
            [NPCID.Spazmatism] = 4800,
            [ModContent.NPCType<BrimstoneElemental>()] = 4500,
            [NPCID.TheDestroyer] = 3900,
            [ModContent.NPCType<AquaticScourgeHead>()] = 3300,
            [NPCID.SkeletronPrime] = 4500,
            [ModContent.NPCType<CalamitasClone>()] = 6600,
            [NPCID.Plantera] = 4200,
            [ModContent.NPCType<Leviathan>()] = 5700,
            [ModContent.NPCType<Anahita>()] = 5700,
            [ModContent.NPCType<AstrumAureus>()] = 4200,
            [NPCID.Golem] = 3300,
            [ModContent.NPCType<PlaguebringerGoliath>()] = 3600,
            [NPCID.HallowBoss] = 5100,
            [NPCID.DukeFishron] = 3600,
            [ModContent.NPCType<RavagerBody>()] = 4200,
            [NPCID.CultistBoss] = 3300,
            [ModContent.NPCType<AstrumDeusHead>()] = 5700,
            [NPCID.MoonLordCore] = 7200,
            // PostMoonlord
            [ModContent.NPCType<ProfanedGuardianCommander>()] = 4200,
            [ModContent.NPCType<Bumblefuck>()] = 3900,
            [ModContent.NPCType<Providence>()] = 7200,
            [ModContent.NPCType<StormWeaverHead>()] = 3300,
            [ModContent.NPCType<CeaselessVoid>()] = 5100,
            [ModContent.NPCType<Signus>()] = 3300,
            [ModContent.NPCType<Polterghast>()] = 5100,
            [ModContent.NPCType<OldDuke>()] = 4800,
            [ModContent.NPCType<DevourerofGodsHead>()] = 7800,
            [ModContent.NPCType<Yharon>()] = 7200,
            [ModContent.NPCType<SupremeCalamitas>()] = 12000,
            [ModContent.NPCType<Artemis>()] = 9000,
            [ModContent.NPCType<Apollo>()] = 9000,
            [ModContent.NPCType<AresBody>()] = 9000,
            [ModContent.NPCType<ThanatosHead>()] = 9000,
        };

        public static Dictionary<int, int> InfernumModeMNLs => new()
        {
            [NPCID.KingSlime] = 2400,
            [ModContent.NPCType<DesertScourgeHead>()] = 2700,
            [NPCID.EyeofCthulhu] = 3000,
            [ModContent.NPCType<Crabulon>()] = 3300,
            [NPCID.EaterofWorldsHead] = 3300,
            [NPCID.BrainofCthulhu] = 3300,
            [ModContent.NPCType<HiveMind>()] = 4200,
            [ModContent.NPCType<PerforatorHive>()] = 4800,
            [NPCID.QueenBee] = 3600,
            [NPCID.Deerclops] = 3600,
            [NPCID.SkeletronHead] = 4500,
            [ModContent.NPCType<SlimeGodCore>()] = 3900,
            [NPCID.WallofFlesh] = 3600,
            // Hardmode
            [NPCID.BloodNautilus] = 3600,
            [NPCID.QueenSlimeBoss] = 3900,
            [ModContent.NPCType<Cryogen>()] = 4500,
            [NPCID.Retinazer] = 5400,
            [NPCID.Spazmatism] = 5400,
            [ModContent.NPCType<BrimstoneElemental>()] = 4800,
            [NPCID.TheDestroyer] = 4500,
            [ModContent.NPCType<AquaticScourgeHead>()] = 5700,
            [NPCID.SkeletronPrime] = 4500,
            [ModContent.NPCType<CalamitasClone>()] = 6300,
            [NPCID.Plantera] = 4800,
            [ModContent.NPCType<Leviathan>()] = 6000,
            [ModContent.NPCType<Anahita>()] = 6000,
            [ModContent.NPCType<AstrumAureus>()] = 4200,
            [NPCID.Golem] = 5700,
            [ModContent.NPCType<PlaguebringerGoliath>()] = 4500,
            [NPCID.HallowBoss] = 6600,
            [NPCID.DukeFishron] = 3900,
            [ModContent.NPCType<RavagerBody>()] = 4500,
            [NPCID.CultistBoss] = 4200,
            [ModContent.NPCType<AstrumDeusHead>()] = 5400,
            [NPCID.MoonLordCore] = 6000,
            // PostMoonlord
            [ModContent.NPCType<ProfanedGuardianCommander>()] = 4800,
            [ModContent.NPCType<Bumblefuck>()] = 4200,
            [ModContent.NPCType<Providence>()] = 11100,
            [ModContent.NPCType<StormWeaverHead>()] = 3900,
            [ModContent.NPCType<CeaselessVoid>()] = 5400,
            [ModContent.NPCType<Signus>()] = 3900,
            [ModContent.NPCType<Polterghast>()] = 7500,
            [ModContent.NPCType<OldDuke>()] = 5100,
            [ModContent.NPCType<DevourerofGodsHead>()] = 6000,
            [ModContent.NPCType<Yharon>()] = 9600,
            [ModContent.NPCType<PrimordialWyrmHead>()] = 5100,
            [ModContent.NPCType<SupremeCalamitas>()] = 12000,
            [ModContent.NPCType<Artemis>()] = 1,
            [ModContent.NPCType<Apollo>()] = 1,
            [ModContent.NPCType<AresBody>()] = 1,
            [ModContent.NPCType<ThanatosHead>()] = 1,
        };

        public static Dictionary<int, int> TesterKilltimes => new()
        {
            // Pre Hardmode
            [NPCID.KingSlime] = 3600,
            [ModContent.NPCType<DesertScourgeHead>()] = 3600,
            [NPCID.EyeofCthulhu] = 5400,
            [ModContent.NPCType<Crabulon>()] = 5400,
            [NPCID.BrainofCthulhu] = 5400,
            [NPCID.EaterofWorldsHead] = 7200,
            [ModContent.NPCType<PerforatorHive>()] = 7200,
            [ModContent.NPCType<HiveMind>()] = 7200,
            [NPCID.QueenBee] = 7200,
            [NPCID.Deerclops] = 5400,
            [NPCID.SkeletronHead] = 7200,
            [ModContent.NPCType<SlimeGodCore>()] = 9000,
            [NPCID.WallofFlesh] = 7200,

            // Hardmode
            [NPCID.QueenSlimeBoss] = 7200,
            [ModContent.NPCType<Cryogen>()] = 10800,
            [ModContent.NPCType<BrimstoneElemental>()] = 10800,
            [ModContent.NPCType<AquaticScourgeHead>()] = 7200,
            [NPCID.TheDestroyer] = 10800,
            [NPCID.Retinazer] = 10800,
            [NPCID.Spazmatism] = 10800,
            [NPCID.SkeletronPrime] = 10800,
            [ModContent.NPCType<CalamitasClone>()] = 14400,
            [NPCID.Plantera] = 10800,
            [ModContent.NPCType<Leviathan>()] = 10800,
            [ModContent.NPCType<Anahita>()] = 10800,
            [ModContent.NPCType<AstrumAureus>()] = 10800,
            [NPCID.Golem] = 9000,
            [ModContent.NPCType<PlaguebringerGoliath>()] = 10800,
            [NPCID.HallowBoss] = 10800,
            [NPCID.DukeFishron] = 9000,
            [ModContent.NPCType<RavagerBody>()] = 10800,
            [NPCID.CultistBoss] = 9000,
            [ModContent.NPCType<AstrumDeusHead>()] = 10800,
            [NPCID.MoonLordCore] = 14400,

            // Post Moonlord
            [ModContent.NPCType<ProfanedGuardianCommander>()] = 5400,
            [ModContent.NPCType<Bumblefuck>()] = 7200,
            [ModContent.NPCType<Providence>()] = 14400,
            [ModContent.NPCType<StormWeaverHead>()] = 8100,
            [ModContent.NPCType<CeaselessVoid>()] = 10800,
            [ModContent.NPCType<Signus>()] = 7200,
            [ModContent.NPCType<Polterghast>()] = 10800,
            [ModContent.NPCType<OldDuke>()] = 10800,
            [ModContent.NPCType<DevourerofGodsHead>()] = 14400,
            [ModContent.NPCType<Yharon>()] = 14400,
            [ModContent.NPCType<SupremeCalamitas>()] = 18000,
            [ModContent.NPCType<Artemis>()] = 21600,
            [ModContent.NPCType<Apollo>()] = 21600,
            [ModContent.NPCType<AresBody>()] = 21600,
            [ModContent.NPCType<ThanatosHead>()] = 21600,
        };

        public static void Load()
        {
            AddMNLSet(RevengeanceBossMNLS, () =>
            {
                if (!CalamityWorld.revenge)
                    return DontUseWeight;

                if (CalToggles.TesterTimes)
                    return DontUseWeight;

                return RevengeWeight;
            });

            AddMNLSet(DeathModeMNLs, () =>
            {
                if (!CalamityWorld.death)
                    return DontUseWeight;

                if (CalToggles.TesterTimes)
                    return DontUseWeight;

                return DeathWeight;
            });

            if (InfernumMod != null)
            {
                AddMNLSet(InfernumModeMNLs, () =>
                {
                    if (!InfernumModeEnabled)
                        return DontUseWeight;

                    if (CalToggles.TesterTimes)
                        return DontUseWeight;

                    return InfernumWeight;
                });
            }

            AddMNLSet(TesterKilltimes, () =>
            {
                if (CalToggles.TesterTimes)
                    return DeathWeight;

                return DontUseWeight;
            });
        }
    }
}
