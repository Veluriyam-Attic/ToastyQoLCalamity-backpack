using CalamityMod;
using CalamityMod.Buffs.Alcohol;
using CalamityMod.Buffs.Potions;
using Terraria;
using Terraria.ModLoader;
using static ToastyQoL.Content.UI.Weights;
using static ToastyQoLCalamity.ToastyQoLCalamity;

namespace ToastyQoLCalamity.Core.Calls
{
    /// <summary>
    /// An example of creating a PotionMod for our mod, and adding potions to it. You can also add potions to other mods sections safely, via correct use of the
    /// <see cref="CheckIfPotionModIsRegistered(string)"/> call.
    /// </summary>
    public static class PotionLoader
    {
        public const string ModName = "Calamity";

        public static void Load()
        {
            AddPotionMod(ModName, "ToastyQoLCalamity/Assets/UI/calamityIcon");

            if (CheckIfPotionModIsRegistered(ModName))
            {
                AddPotionElementToMod(ModName, "Bloody Mary", "Boosts damage and movement speed by 10% during a Blood Moon. Reduces life regen by 4 and defense by 4%",
                    "ToastyQoLCalamity/Assets/UI/Potions/bloodyMary", ModContent.BuffType<BloodyMaryBuff>(), () => DownedBossSystem.downedAstrumAureus, PostPlantera + 0.66f, 0.8f);

                AddPotionElementToMod(ModName, "Bounding", "Grants 5% increased jump speed, 25 extra blocks of fall damage resistance, and increased jump height",
                    "ToastyQoLCalamity/Assets/UI/Potions/bounding", ModContent.BuffType<BoundingBuff>(), () => true, PreBoss, 0.8f);

                AddPotionElementToMod(ModName, "Calcium", "Grants immunity to fall damage",
                    "ToastyQoLCalamity/Assets/UI/Potions/calcium", ModContent.BuffType<CalciumBuff>(), () => true, PreBoss, 0.8f);

                AddPotionElementToMod(ModName, "Caribbean Rum", "Boosts life regen by 2, movement speed by 10% and wing flight time by 20% chance. Makes you floaty, -10 defense",
                    "ToastyQoLCalamity/Assets/UI/Potions/caribbeanRum", ModContent.BuffType<CaribbeanRumBuff>(), () => NPC.downedPlantBoss, PostPlantera, 0.8f);

                AddPotionElementToMod(ModName, "Cinnamon Roll", "Boosts mana regeneration rate and multiplies all fire-based debuff damage by 1.5. -10% defense",
                    "ToastyQoLCalamity/Assets/UI/Potions/cinnamonRoll", ModContent.BuffType<CinnamonRollBuff>(), () => NPC.downedGolemBoss, PostGolem, 0.8f);

                AddPotionElementToMod(ModName, "Everclear", "Boosts damage by 25%. Reduces life regen by 10 and defense by 30%",
                    "ToastyQoLCalamity/Assets/UI/Potions/everclear", ModContent.BuffType<EverclearBuff>(), () => DownedBossSystem.downedAstrumAureus, PostPlantera + 0.66f, 0.7f);

                AddPotionElementToMod(ModName, "Evergreen Gin", "Multiplies all sickness and water-related debuff damage by 1.25. Reduces life regen by 1",
                    "ToastyQoLCalamity/Assets/UI/Potions/evergreenGin", ModContent.BuffType<EvergreenGinBuff>(), () => NPC.downedPlantBoss, PostPlantera, 0.8f);

                AddPotionElementToMod(ModName, "Fabsol's Vodka", "Boosts all damage stats by 8% but lowers defense by 10%. Increases immune time after being struck",
                    "ToastyQoLCalamity/Assets/UI/Potions/fabsolsVodka", ModContent.BuffType<FabsolVodkaBuff>(), () => Main.hardMode, PostWallOfFlesh, 0.7f);

                AddPotionElementToMod(ModName, "Fireball", "Multiplies all fire-based debuff damage by 1.25. Reduces life regen by 1",
                    "ToastyQoLCalamity/Assets/UI/Potions/fireball", ModContent.BuffType<FireballBuff>(), () => Main.hardMode, PostWallOfFlesh, 0.8f);

                AddPotionElementToMod(ModName, "Flask of Crumbling", "Melee, Whip, and Rogue attacks inflict Crumbling on enemies",
                    "ToastyQoLCalamity/Assets/UI/Potions/flaskOfCrumbling", ModContent.BuffType<WeaponImbueCrumbling>(), () => Main.hardMode, PostWallOfFlesh, 0.8f);

                AddPotionElementToMod(ModName, "Gravity Normalizer", "Disables the low gravity of space and grants immunity to the distorted debuff",
                    "ToastyQoLCalamity/Assets/UI/Potions/gravityNormalizer", ModContent.BuffType<GravityNormalizerBuff>(), () => DownedBossSystem.downedAstrumAureus, PostPlantera + 0.66f, 0.8f);

                AddPotionElementToMod(ModName, "Moonshine", "Increases defense by 10 and damage reduction by 3%. Reduces life regen by 1",
                    "ToastyQoLCalamity/Assets/UI/Potions/moonshine", ModContent.BuffType<MoonshineBuff>(), () => NPC.downedGolemBoss, PostGolem, 0.8f);

                AddPotionElementToMod(ModName, "Moscow Mule", "Boosts damage and knockback by 9% and critical strike chance by 3%. Reduces life regen by 2",
                    "ToastyQoLCalamity/Assets/UI/Potions/moscowMule", ModContent.BuffType<MoscowMuleBuff>(), () => NPC.downedGolemBoss, PostGolem, 0.8f);

                AddPotionElementToMod(ModName, "Omniscience", "Highlights nearby creatures, enemy projectiles, danger sources, and treasure",
                    "ToastyQoLCalamity/Assets/UI/Potions/omniscience", ModContent.BuffType<Omniscience>(), () => NPC.downedBoss3, PostSkeletron, 0.8f);

                AddPotionElementToMod(ModName, "Photosynthesis", "You regen life quickly while not moving, this effect is five times as strong during daytime. Dropped hearts heal more HP",
                    "ToastyQoLCalamity/Assets/UI/Potions/photosynthesis", ModContent.BuffType<PhotosynthesisBuff>(), () => Main.hardMode, PostWallOfFlesh, 0.8f);

                AddPotionElementToMod(ModName, "Rum", "Boosts life regen by 2 and movement speed by 10%. Reduces defense by 5%",
                    "ToastyQoLCalamity/Assets/UI/Potions/rum", ModContent.BuffType<RumBuff>(), () => Main.hardMode, PostWallOfFlesh, 0.8f);

                AddPotionElementToMod(ModName, "Screwdriver", "Multiplies piercing projectile damage by 1.05. Reduces life regen by 1",
                    "ToastyQoLCalamity/Assets/UI/Potions/screwdriver", ModContent.BuffType<ScrewdriverBuff>(), () => NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3, PostSkeletronPrime, 0.8f);

                AddPotionElementToMod(ModName, "Shadow", "Rogue weapons spawn projectiles on hit Stealth generation is increased by 8%",
                    "ToastyQoLCalamity/Assets/UI/Potions/shadow", ModContent.BuffType<ShadowBuff>(), () => NPC.downedBoss3, PostSkeletron, 0.8f);

                AddPotionElementToMod(ModName, "Soaring", "Increases flight time and horizontal flight speed by 10%. Restores a fraction of your wing flight time after a true melee strike",
                    "ToastyQoLCalamity/Assets/UI/Potions/soaring", ModContent.BuffType<Soaring>(), () => Main.hardMode, PostWallOfFlesh, 0.8f);

                AddPotionElementToMod(ModName, "Star Beam Rye", "Boosts max mana by 50, magic damage by 8%, and reduces mana usage by 10%. -6% defense and -1 life regen",
                    "ToastyQoLCalamity/Assets/UI/Potions/starBeamRye", ModContent.BuffType<StarBeamRyeBuff>(), () => DownedBossSystem.downedAstrumAureus, PostPlantera + 0.66f, 0.8f);

                AddPotionElementToMod(ModName, "Sulphurskin", "Reduces the effects of the sulphuric waters",
                    "ToastyQoLCalamity/Assets/UI/Potions/sulphurskin", ModContent.BuffType<SulphurskinBuff>(), () => true, PreBoss, 0.8f);

                AddPotionElementToMod(ModName, "Tequila", "Boosts damage, DR, and knockback by 3%, critical strike chance by 2%, defense by 5 during daytime. -1 life regen",
                    "ToastyQoLCalamity/Assets/UI/Potions/tequila", ModContent.BuffType<TequilaBuff>(), () => Main.hardMode, PostWallOfFlesh, 0.8f);

                AddPotionElementToMod(ModName, "Tequila Sunrise", "Boosts damage, DR, and knockback by 7%, critical strike chance by 3%, defense by 10 during daytime. -1 life regen",
                    "ToastyQoLCalamity/Assets/UI/Potions/tequilaSunrise", ModContent.BuffType<TequilaSunriseBuff>(), () => NPC.downedGolemBoss, PostGolem, 0.8f);

                AddPotionElementToMod(ModName, "Tesla", "Summons an aura of electricity that electrifies and slows enemies. Reduces the duration of the Electrified debuff",
                    "ToastyQoLCalamity/Assets/UI/Potions/tesla", ModContent.BuffType<TeslaBuff>(), () => DownedBossSystem.downedPerforator, PostBrainOfCthulhu + 0.5f, 0.8f);

                AddPotionElementToMod(ModName, "Vodka", "Boosts damage by 6% and critical strike chance by 2%. Reduces life regen by 1 and defense by 5%",
                    "ToastyQoLCalamity/Assets/UI/Potions/vodka", ModContent.BuffType<VodkaBuff>(), () => NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3, PostSkeletronPrime, 0.8f);

                AddPotionElementToMod(ModName, "Whiskey", "Boosts damage and knockback by 4% and critical strike chance by 2%. Reduces defense by 5%",
                    "ToastyQoLCalamity/Assets/UI/Potions/whiskey", ModContent.BuffType<WhiskeyBuff>(), () => Main.hardMode, PostWallOfFlesh, 0.8f);

                AddPotionElementToMod(ModName, "White Wine", "Restores 400 mana and boosts magic damage by 10%. Reduces defense by 6% and life regen by 1",
                    "ToastyQoLCalamity/Assets/UI/Potions/whiteWine", ModContent.BuffType<WhiteWineBuff>(), () => NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3, PostSkeletronPrime, 0.7f);

                AddPotionElementToMod(ModName, "Zen", "Vastly decreases enemy spawn rate",
                    "ToastyQoLCalamity/Assets/UI/Potions/zen", ModContent.BuffType<Zen>(), () => DownedBossSystem.downedSlimeGod, PostSkeletron + 0.5f, 0.8f);

                AddPotionElementToMod(ModName, "Zerg", "Vastly increases enemy spawn rate",
                    "ToastyQoLCalamity/Assets/UI/Potions/zerg", ModContent.BuffType<Zerg>(), () => DownedBossSystem.downedSlimeGod, PostSkeletron + 0.5f, 0.8f);

                AddPotionElementToMod(ModName, "Old Fashioned", "Multiplies all accessory and set bonus damage by 1.5x. Decreases all damage by 25%",
                    "ToastyQolCalamity/Assets/UI/Potions/oldFashioned", ModContent.BuffType<OldFashionedBuff>(), () => NPC.downedPlantBoss, PostPlantera, 0.8f);
            }
        }
    }
}
