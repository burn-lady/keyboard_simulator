using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Keyboard_semulator.Controllers
{

    public class LettersController
    {
        public static int DEFAULT_MINISECOND_OF_LETTERS = 10000;
        public static List<char> letters = new List<char>();
        public static Dictionary<char, int> statisticLetters = new Dictionary<char, int>();
        private static char lastLetter = 'a';

        private static StringBuilder line = new StringBuilder();
        

        public static string getLine()
        {
            line.Remove(0, 1);
            if (line.Length < 20)
            {
                char[] mLetters = getLettersHasMaxMiniseconds();
                line.Append(mLetters[0]);
                for (int i = 0; i < mLetters.Length - 1; i++)
                    line.Append(mLetters[i]);
            }
            return line.ToString();
        }
               
        public static char[] getLettersHasMaxMiniseconds()
        {
            int maxMiniseconds = 0;
            char[] choiseLetters = new char[4];
            choiseLetters[0] = letters[0];
            choiseLetters[1] = letters[1];
            foreach (KeyValuePair<char, int> keyValue in statisticLetters)
            {
                if (keyValue.Value > maxMiniseconds)
                {
                    maxMiniseconds = keyValue.Value;
                    //for (int i = 1; i < choiseLetters.Length - 2; i++)
                    //    choiseLetters[i] = choiseLetters[i - 1];
                    choiseLetters[2] = choiseLetters[1];
                    choiseLetters[1] = choiseLetters[0];
                    choiseLetters[0] = keyValue.Key;
                }
            }
            return choiseLetters;
         
        }
        public static void setLetter(char letter, int newValue)
        {
            int oldValue = statisticLetters[letter];
            int sValue = (oldValue + newValue) / 2;
            statisticLetters[letter] = sValue;
            LettersLogger.writeLog(letter, sValue);
        }

        public static void init()
        {        
            initLeters();
            initStatisticLetters();
            Random r = new Random();
            for (int i =0; i < letters.Count * 2; i++)
            {
                line.Append(letters[r.Next(letters.Count)]);
            }
            //foreach (char letter in letters)
            //    line.Append(letter);
        }
                       
        public static void initLeters()
        {
            List<string> lines = MyTextReader.read(MyTextReader.LETTERS);
            letters = new List<char>();
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
