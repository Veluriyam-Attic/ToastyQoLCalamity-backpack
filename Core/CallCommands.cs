using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ToastyQoLCalamity
{
    /// <summary>
    /// This handles every command that can be called to the main mod, providing simple methods for calling each one. Each command is used in static classes in "Core/Calls".
    /// </summary>
    public partial class ToastyQoLCalamity
    {
        public const string AddToggleCommand = "AddNewUIToggleToRegisteredPage";
        public const string AddNewPageCommand = "AddNewEmptyPageUI";
        public const string CheckIfPageIsRegisteredCommand = "CheckIfPageIsRegistered";
        public const string AddBossToggleCommand = "AddBossToggle";
        public const string AddLockInformationCommand = "AddNewBossLockInformation";
        public const string GetToggleStatusCommand = "GetToggleStatus";
        public const string AddShroomDrawMethodCommand = "AddShroomsDrawMethod";
        public const string AddMNLSetCommand = "AddMNLSet";
        public const string AddPotionModCommand = "AddPotionMod";
        public const string AddPotionElementToModCommand = "AddPotionElementToMod";
        public const string CheckIfPotionModIsRegisteredCommand = "CheckIfPotionModIsRegistered";
        public const string AddSassQuoteLoseCommand = "AddSassQuoteLose";
        public const string AddSassQuoteWinCommand = "AddSassQuoteWin";
        public const string AddBossSpecificSassQuoteCommand = "AddBossSpecificSassQuote";


        public static void AddPage(string pageName, string description, Texture2D wheelIconTexture, float layer, bool useSmallerBackground, Action onClick, Vector2? drawOffset)
           => ToastyQoLMod.Call(AddNewPageCommand, pageName, description, wheelIconTexture, layer, useSmallerBackground, onClick, drawOffset);

        public static bool PageExists(string pageName) => (bool)ToastyQoLMod.Call(CheckIfPageIsRegisteredCommand, pageName);

        public static void AddToggle(string managerName, Texture2D texture, Texture2D glowTexture, Func<string> descriptionText, Func<string> hoverText, float layer,
            Action onClickAction, FieldInfo assosiatedField, bool useToggleBlock = false, Func<bool> canToggleFunc = null, string extraHoverText = null)
        {
            if (useToggleBlock)
                ToastyQoLMod.Call(AddToggleCommand, managerName, texture, glowTexture, descriptionText, hoverText, layer, onClickAction, assosiatedField == null ? "required" : assosiatedField, useToggleBlock, canToggleFunc, extraHoverText);
            else
                ToastyQoLMod.Call(AddToggleCommand, managerName, texture, glowTexture, descriptionText, hoverText, layer, onClickAction, assosiatedField == null ? "required" : assosiatedField, useToggleBlock);
        }

        public static void AddBossToggle(string texturePath, string nameSingular, FieldInfo downedBool, float layer, float scale = 1f)
            => ToastyQoLMod.Call(AddBossToggleCommand, texturePath, nameSingular, downedBool, layer, scale);

        public static void AddLockInformation(Func<bool> condition, string bossName, List<int> assosiatedItemTypes, bool forPotion = false)
            => ToastyQoLMod.Call(AddLockInformationCommand, condition, bossName, assosiatedItemTypes, forPotion);

        public static bool GetToggleStatus(string toggle) => (bool)ToastyQoLMod.Call(GetToggleStatusCommand, toggle);

        public static void AddShroomDrawMethod(Action<SpriteBatch> action) => ToastyQoLMod.Call(AddShroomDrawMethodCommand, action);

        public static void AddMNLSet(Dictionary<int, int> assosiatedIDsAndFightLength, Func<float> weight) => ToastyQoLMod.Call(AddMNLSetCommand, assosiatedIDsAndFightLength, weight);

        public static void AddPotionMod(string modName, string uiIconPath) => ToastyQoLMod.Call(AddPotionModCommand, modName, uiIconPath);

        public static void AddPotionElementToMod(string modName, string potionName, string potionDescription, string potionTexturePath, int potionBuffID, Func<bool> isAvailable, float weight, float scale = 1f) =>
            ToastyQoLMod.Call(AddPotionElementToModCommand, modName, potionName, potionDescription, potionTexturePath, potionBuffID, isAvailable, weight, scale);

        public static bool CheckIfPotionModIsRegistered(string modName) => (bool)ToastyQoLMod.Call(CheckIfPotionModIsRegisteredCommand, modName);

        public static void AddSassQuoteLose(string quote) => ToastyQoLMod.Call(AddSassQuoteLoseCommand, quote);

        public static void AddSassQuoteWin(string quote) => ToastyQoLMod.Call(AddSassQuoteWinCommand, quote);

        public static void AddBossSpecificSassQuote(int bossID, List<string> quotes) => ToastyQoLMod.Call(AddBossSpecificSassQuoteCommand, bossID, quotes);
    }
}
