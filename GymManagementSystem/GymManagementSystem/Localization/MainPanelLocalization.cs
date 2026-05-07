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

        // Translates a dialog form's title and all its child controls.
        // Call this right after creating a dialog form, before ShowDialog().
        public static void ApplyToForm(System.Windows.Forms.Form form)
        {
            string lang = System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;

            // Translate the form's title bar text
            if (!string.IsNullOrWhiteSpace(form.Text))
                form.Text = TranslateVisibleText(form.Text, lang);

            // Recursively translate all controls inside the form
            ApplyToControls(form, lang);
        }

        // Recursively walks through all child controls and translates their Text.
        private static void ApplyToControls(System.Windows.Forms.Control root, string lang)
        {
            foreach (System.Windows.Forms.Control control in root.Controls)
            {
                if (!string.IsNullOrWhiteSpace(control.Text))
                    control.Text = TranslateVisibleText(control.Text, lang);

                if (control.HasChildren)
                    ApplyToControls(control, lang);
            }
        }
    }
}
