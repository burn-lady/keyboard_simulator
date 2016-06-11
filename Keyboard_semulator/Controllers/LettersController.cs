using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyboard_semulator.Controllers
{

    public class LettersController
    {
        public static int DEFAULT_MINISECOND_OF_LETTERS = 5000;
        public static List<char> letters = new List<char>();
        public static Dictionary<char, int> statisticLetters = new Dictionary<char, int>();
        private static char lastLetter = 'a';
                   
        public static char getLetterHasMaxMiniseconds()
        {
            int maxMiniseconds = 0;
            char choiseLetter = 'e';
            foreach (KeyValuePair<char, int> keyValue in statisticLetters)
            {
                if (keyValue.Value > maxMiniseconds)
                {
                    maxMiniseconds = keyValue.Value;
                    choiseLetter = keyValue.Key;
                }
            }
            if (lastLetter != choiseLetter)
            {
                lastLetter = choiseLetter;
                return choiseLetter;
            }
            else
            {
                lastLetter = choiseLetter;
                return letters[new Random().Next(letters.Count)];
            }
        }
        public static void setLetter(char letter, int newValue)
        {
            int oldValue = statisticLetters[letter];
            statisticLetters[letter] = (oldValue + newValue) / 2;
        }

        public static void initLettersAndStatistic()
        {
            initLeters();
            initStatisticLetters();
        }
                       
        public static void initLeters()
        {
            List<string> lines = MyTextReader.read(MyTextReader.LETTERS);
            foreach (string line in lines)           
               letters.Add(line[0]);           
        } 
        
        public static void initStatisticLetters()
        {
            statisticLetters = new Dictionary<char, int>();
            foreach (char letter in letters)
                statisticLetters[letter] = DEFAULT_MINISECOND_OF_LETTERS;
        }          
    }
}
