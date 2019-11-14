using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Translator
{
    public class PigGreekTranslator : ITranslator
    {
        string vowels = "aeiouAEIOU";
        public string Translate(string text)
        {
            StringBuilder FinalString = new StringBuilder();


            Regex numbers = new Regex("/[0-9]*/");

            foreach (string word in text.Split(' '))
            {
                StringBuilder sb = new StringBuilder(word);

                //Starts with a Vowel                
                if (vowels.Contains(sb[0]))
                {
                    FinalString.Append(this.Vowel(word));
                }
                //If it contains a @ or numbers don't do anything
                else if (word.Contains("@") || numbers.Match(word).Length > 0)
                {
                    FinalString.Append(word);
                }
                //Starts with a Consonant
                else if (!vowels.Contains(sb[0]))
                {
                    FinalString.Append(this.Consonant(word));
                }
                else
                {
                    FinalString.Append(word);
                }

                FinalString.Append(" ");

            }

            return FinalString.ToString();

        }

        protected string Punctuation(string word, out string pun)
        {
            string p = ".,?!";
            pun = "";
            if (p.Contains(word[word.Length - 1]))
            {
                pun = word.Substring(word.Length - 1);
                return word.Substring(0, word.Length - 1);
            }

            return word;
        }

        protected string Vowel(string word)
        {

            string pun = "";
            word = this.Punctuation(word, out pun);

            //Check to see if the string starts with a Y
            if (word[0].ToString().ToLower() == "y")
                return this.Consonant(word);

            word += "oi";

            return word + pun;
        }

        protected string Consonant(String word)
        {
            string pun;
            word = this.Punctuation(word, out pun);

            //Check for uppercase first word
            Regex upper = new Regex("^[A-Z]");
            bool up_first = false;
            if (upper.IsMatch(word))
            {

                up_first = true;
                StringBuilder sb = new StringBuilder(word);
                sb[0] = sb[0].ToString().ToLower().ToCharArray()[0];
                word = sb.ToString();
            }

            string y_vowel = vowels + "yY"; //Add 'Y' for consonants
            for (int i = 1; i < word.Length; i++)
            {
                if (y_vowel.Contains("" + word.ToCharArray()[i]))
                {
                    string start = word.Substring(0, i);
                    string end = word.Substring(i);
                    word = end + start + "omatos";
                    break;
                }
            }

            //If First was upper, make it upper again
            if (up_first)
            {
                StringBuilder sb = new StringBuilder(word);
                sb[0] = sb[0].ToString().ToUpper().ToCharArray()[0];
                word = sb.ToString();
            }

            return word + pun;
        }
    }
}
