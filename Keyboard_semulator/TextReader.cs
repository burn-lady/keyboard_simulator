using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Keyboard_semulator
{
     

    class TextReader
    {
        public static string FILE_NAME = "text_file.txt";

        public TextReader()
        {

        }
        public List<string> read(string appPatch, string fileName)
        {
            List<string> listText = new List<string>();
            listText.AddRange(File.ReadAllLines(appPatch + "//" + fileName));
            return listText;
        }

        //public string readTextFile(string appPatch, string fileName);
        //{
        //  //  List<string> listText = File.ReadLines();
        //    return " ";
        //}

    }
}
