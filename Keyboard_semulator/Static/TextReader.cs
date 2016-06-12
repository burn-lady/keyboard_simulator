using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Keyboard_semulator
{
     

    class MyTextReader
    {
        public static string LETTERS = "letters.txt";
        public static string CONTROL_WORDS = "words_text_file.txt";
        public static string CONTROL_TEXT = "control_text.txt";
        public static string CONTROL_LETTERS = "control_letters.txt";
        public static string TUTORIAL_PROGRAM_FILE = "Tutorial_Program.txt";

        public static List<string> read (string path)
        {
            try
            {
                List<string> listText = new List<string>();
                listText.AddRange(File.ReadAllLines(path, Encoding.Default));
                return listText;
             } catch (FileNotFoundException)
            {                
                return null;
            }
            
        }
    }
}
