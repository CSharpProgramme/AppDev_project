using System;
using System.Collections.Generic;

namespace GymManagementSystem.Localization
{
    internal static class MainPanelLocalization
    {
        private static readonly Dictionary<string, string> ReverseToEnglish =
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        static MainPanelLocalization()
        {
            AddReverse(MainPanelFrenchStrings.EnglishToFrench);
            AddReverse(MainPanelSpanishStrings.EnglishToSpanish);
        }

        private static void AddReverse(IReadOnlyDictionary<string, string> forward)
        {
            foreach (var pair in forward)
            {
                if (!string.IsNullOrEmpty(pair.Value) && !ReverseToEnglish.ContainsKey(pair.Value))
                {
                    ReverseToEnglish[pair.Value] = pair.Key;
                }
            }
        }

        internal static string ToEnglishKey(string currentText)
        {
            if (string.IsNullOrEmpty(currentText))
            {
                return currentText;
            }

            if (ReverseToEnglish.TryGetValue(currentText, out string english))
            {
                return english;
            }

            if (MainPanelEnglishStrings.EnglishToDisplay.ContainsKey(currentText))
            {
                return currentText;
            }

            return currentText;
        }

        internal static string TranslateFromEnglish(string englishKey, string twoLetterIso)
        {
            if (string.IsNullOrEmpty(englishKey))
            {
                return englishKey;
            }

            switch (twoLetterIso?.ToLowerInvariant())
            {
                case "fr":
                    return MainPanelFrenchStrings.EnglishToFrench.TryGetValue(englishKey, out string fr)
                        ? fr
                        : englishKey;
                case "es":
                    return MainPanelSpanishStrings.EnglishToSpanish.TryGetValue(englishKey, out string es)
                        ? es
                        : englishKey;
                default:
                    return MainPanelEnglishStrings.EnglishToDisplay.TryGetValue(englishKey, out string en)
                        ? en
                        : englishKey;
            }
        }

        internal static string TranslateVisibleText(string source, string twoLetterIso)
        {
            string english = ToEnglishKey(source);
            return TranslateFromEnglish(english, twoLetterIso);
        }
    }
}
