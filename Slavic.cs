using System;
using System.Collections.Generic;
using System.Text;

namespace TransliterateToLatin
{
    public class Slavic
    {
        public static string SlavicToLatin(string input)
        {
            Dictionary<string, string> characters = new Dictionary<string, string>();
            characters.Add("а", "a");
            characters.Add("б", "b");
            characters.Add("в", "v");
            characters.Add("г", "g");
            characters.Add("д", "d");
            characters.Add("е", "e");
            characters.Add("ё", "yo");
            characters.Add("ж", "zh");
            characters.Add("з", "z");
            characters.Add("и", "i");
            characters.Add("й", "j");
            characters.Add("к", "k");
            characters.Add("л", "l");
            characters.Add("м", "m");
            characters.Add("н", "n");
            characters.Add("о", "o");
            characters.Add("п", "p");
            characters.Add("р", "r");
            characters.Add("с", "s");
            characters.Add("т", "t");
            characters.Add("у", "u");
            characters.Add("ф", "f");
            characters.Add("х", "h");
            characters.Add("ц", "c");
            characters.Add("ч", "ch");
            characters.Add("ш", "sh");
            characters.Add("щ", "sch");
            characters.Add("ъ", "j");
            characters.Add("ы", "i");
            characters.Add("ь", "j");
            characters.Add("э", "e");
            characters.Add("ю", "yu");
            characters.Add("я", "ya");
            characters.Add("А", "A");
            characters.Add("Б", "B");
            characters.Add("В", "V");
            characters.Add("Г", "G");
            characters.Add("Д", "D");
            characters.Add("Е", "E");
            characters.Add("Ё", "Yo");
            characters.Add("Ж", "Zh");
            characters.Add("З", "Z");
            characters.Add("И", "I");
            characters.Add("Й", "J");
            characters.Add("К", "K");
            characters.Add("Л", "L");
            characters.Add("М", "M");
            characters.Add("Н", "N");
            characters.Add("О", "O");
            characters.Add("П", "P");
            characters.Add("Р", "R");
            characters.Add("С", "S");
            characters.Add("Т", "T");
            characters.Add("У", "U");
            characters.Add("Ф", "F");
            characters.Add("Х", "H");
            characters.Add("Ц", "C");
            characters.Add("Ч", "Ch");
            characters.Add("Ш", "Sh");
            characters.Add("Щ", "Sch");
            characters.Add("Ъ", "J");
            characters.Add("Ы", "I");
            characters.Add("Ь", "J");
            characters.Add("Э", "E");
            characters.Add("Ю", "Yu");
            characters.Add("Я", "Ya");

            foreach(KeyValuePair<string, string> pair in characters)
            {
                input = input.Replace(pair.Key, pair.Value);
            }
            return input;

        }
    }
}
