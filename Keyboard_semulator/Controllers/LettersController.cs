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
        public static int LINE_LENGHT = 30;
        public static List<char> letters = new List<char>();
        public static Dictionary<char, int> statisticLetters = new Dictionary<char, int>();

        private static StringBuilder line = new StringBuilder();
        
      

        public static string getLine()
        {
            line.Remove(0, 1);
            if (line.Length < LINE_LENGHT)
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
            Random r = new Random();
            for (int i = 0; i < choiseLetters.Length; i++) choiseLetters[i] = letters[r.Next(letters.Count)]; 
            foreach (KeyValuePair<char, int> keyValue in statisticLetters)
            {
                if (keyValue.Value > maxMiniseconds)
                {
                    maxMiniseconds = keyValue.Value;
                    //for (int i = 1; i < choiseLetters.Length - 2; i++)
                    //    choiseLetters[i] = choiseLetters[i - 1];

                    // Мой маленький китай     
                    choiseLetters[3] = choiseLetters[2];
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

        public static string init()
        {        
            initLeters();
            initStatisticLetters();
            return getRandomLine();           
        }

        public static string getRandomLine()
        {
            Random r = new Random();
            for (int i = 0; i < letters.Count; i++)
            {
                line.Append(letters[r.Next(letters.Count)]);
            }
            return line.ToString();
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
