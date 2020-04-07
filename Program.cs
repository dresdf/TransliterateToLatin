using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace TransliterateToLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            string bulgarian = "КОЛОР СТУДИО - ЕООД";
            string greek = "καθημερινών";
            string french = "gênés";


            Debug.WriteLine("################################### Initial slavic: " + bulgarian);
            Debug.WriteLine("################################### Initial greek: " + greek);
            Debug.WriteLine("################################### Initial french: " + french);

            bulgarian = Transliterate(bulgarian);
            greek = Transliterate(greek);
            french = Transliterate(french);

            Debug.WriteLine("################################### Result slavic: " + bulgarian);
            Debug.WriteLine("################################### Result greek: " + greek);
            Debug.WriteLine("################################### Result french: " + french);
        }

        private static string Transliterate(string input)
        {
            //transliterate from cyrillic to latin
            input = Slavic.SlavicToLatin(input);

            //transliterate from greek to latin
            input = Greek.GreekToLatin(input);

            //replace diacritics
            StringBuilder sbReturn = new StringBuilder();
            var arrayText = input.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach(char letter in arrayText)
            {
                if(CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                {
                    sbReturn.Append(letter);
                }
            }

            return sbReturn.ToString();
        }
    }
}
