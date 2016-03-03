using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyboard_semulator
{
    class Controller
    {

        public static string generateTask (List<string> lines)
        {
            int number;
            StringBuilder SB = new StringBuilder();
            Random r = new Random();
            while (lines.Count > 0)
            {
                number = r.Next(0, lines.Count);
                SB.Append(lines[number] + " ");
                lines.Remove(lines[number]);
            }

            return SB.ToString();
        }

        public static string visibleLine(string task, int step)
        {
            StringBuilder SB = new StringBuilder();
            for (int i = 0; i < 20; i++)
            {
                if (step + i < task.Length) SB.Append(task[step + i]);
                else break;
            }
            return SB.ToString(); 
        }
    }
}
