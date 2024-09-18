using CalamityMod;
using CalamityMod.Buffs.Alcohol;
using CalamityMod.Buffs.Potions;
using Terraria;
using Terraria.Localization;
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
                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.BloodyMary.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.BloodyMary.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/bloodyMary", ModContent.BuffType<BloodyMaryBuff>(), () => DownedBossSystem.downedAstrumAureus, PostPlantera + 0.66f, 0.8f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Bounding.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Bounding.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/bounding", ModContent.BuffType<BoundingBuff>(), () => true, PreBoss, 0.8f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Calcium.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Calcium.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/calcium", ModContent.BuffType<CalciumBuff>(), () => true, PreBoss, 0.8f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.CaribbeanRum.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.CaribbeanRum.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/caribbeanRum", ModContent.BuffType<CaribbeanRumBuff>(), () => NPC.downedPlantBoss, PostPlantera, 0.8f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.CinnamonRoll.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.CinnamonRoll.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/cinnamonRoll", ModContent.BuffType<CinnamonRollBuff>(), () => NPC.downedGolemBoss, PostGolem, 0.8f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Everclear.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Everclear.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/everclear", ModContent.BuffType<EverclearBuff>(), () => DownedBossSystem.downedAstrumAureus, PostPlantera + 0.66f, 0.7f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.EvergreenGin.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.EvergreenGin.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/evergreenGin", ModContent.BuffType<EvergreenGinBuff>(), () => NPC.downedPlantBoss, PostPlantera, 0.8f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.FabsolVodka.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.FabsolVodka.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/fabsolsVodka", ModContent.BuffType<FabsolVodkaBuff>(), () => Main.hardMode, PostWallOfFlesh, 0.7f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Fireball.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Fireball.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/fireball", ModContent.BuffType<FireballBuff>(), () => Main.hardMode, PostWallOfFlesh, 0.8f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.FlaskCrumbling.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.FlaskCrumbling.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/flaskOfCrumbling", ModContent.BuffType<WeaponImbueCrumbling>(), () => Main.hardMode, PostWallOfFlesh, 0.8f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.GravityNormalizer.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.GravityNormalizer.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/gravityNormalizer", ModContent.BuffType<GravityNormalizerBuff>(), () => DownedBossSystem.downedAstrumAureus, PostPlantera + 0.66f, 0.8f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Moonshine.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Moonshine.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/moonshine", ModContent.BuffType<MoonshineBuff>(), () => NPC.downedGolemBoss, PostGolem, 0.8f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.MoscowMule.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.MoscowMule.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/moscowMule", ModContent.BuffType<MoscowMuleBuff>(), () => NPC.downedGolemBoss, PostGolem, 0.8f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Omniscience.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Omniscience.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/omniscience", ModContent.BuffType<Omniscience>(), () => NPC.downedBoss3, PostSkeletron, 0.8f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Photosynthesis.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Photosynthesis.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/photosynthesis", ModContent.BuffType<PhotosynthesisBuff>(), () => Main.hardMode, PostWallOfFlesh, 0.8f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Rum.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Rum.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/rum", ModContent.BuffType<RumBuff>(), () => Main.hardMode, PostWallOfFlesh, 0.8f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Screwdriver.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Screwdriver.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/screwdriver", ModContent.BuffType<ScrewdriverBuff>(), () => NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3, PostSkeletronPrime, 0.8f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Shadow.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Shadow.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/shadow", ModContent.BuffType<ShadowBuff>(), () => NPC.downedBoss3, PostSkeletron, 0.8f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Soaring.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Soaring.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/soaring", ModContent.BuffType<Soaring>(), () => Main.hardMode, PostWallOfFlesh, 0.8f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.StarBeamRye.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.StarBeamRye.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/starBeamRye", ModContent.BuffType<StarBeamRyeBuff>(), () => DownedBossSystem.downedAstrumAureus, PostPlantera + 0.66f, 0.8f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.SulphurSkin.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.SulphurSkin.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/sulphurskin", ModContent.BuffType<SulphurskinBuff>(), () => true, PreBoss, 0.8f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Tequila.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Tequila.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/tequila", ModContent.BuffType<TequilaBuff>(), () => Main.hardMode, PostWallOfFlesh, 0.8f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.TequilaSunrise.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.TequilaSunrise.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/tequilaSunrise", ModContent.BuffType<TequilaSunriseBuff>(), () => NPC.downedGolemBoss, PostGolem, 0.8f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Tesla.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Tesla.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/tesla", ModContent.BuffType<TeslaBuff>(), () => DownedBossSystem.downedPerforator, PostBrainOfCthulhu + 0.5f, 0.8f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Vodka.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Vodka.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/vodka", ModContent.BuffType<VodkaBuff>(), () => NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3, PostSkeletronPrime, 0.8f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Whiskey.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Whiskey.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/whiskey", ModContent.BuffType<WhiskeyBuff>(), () => Main.hardMode, PostWallOfFlesh, 0.8f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.WhiteWine.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.WhiteWine.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/whiteWine", ModContent.BuffType<WhiteWineBuff>(), () => NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3, PostSkeletronPrime, 0.7f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Zen.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Zen.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/zen", ModContent.BuffType<Zen>(), () => DownedBossSystem.downedSlimeGod, PostSkeletron + 0.5f, 0.8f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Zerg.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.Zerg.Description"),
                    "ToastyQoLCalamity/Assets/UI/Potions/zerg", ModContent.BuffType<Zerg>(), () => DownedBossSystem.downedSlimeGod, PostSkeletron + 0.5f, 0.8f);

                AddPotionElementToMod(ModName, Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.OldFashioned.Name"), Language.GetTextValue($"Mods.ToastyQoLCalamity.UI.Potions.OldFashioned.Description"),
                    "ToastyQolCalamity/Assets/UI/Potions/oldFashioned", ModContent.BuffType<OldFashionedBuff>(), () => NPC.downedPlantBoss, PostPlantera, 0.8f);
            }

          
        }
    }
}
