using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyboard_semulator
{
    class Controller
    {

        public static string generateTask_Words (List<string> lines, int maxWords)
        {
            int number;
            int count = 0;
            StringBuilder SB = new StringBuilder();
            while (lines.Count > 0 && maxWords > count)
            {
                number = new Random().Next(0, lines.Count);
                SB.Append(lines[number] + " ");
                lines.Remove(lines[number]);
                count++;
            }

            return SB.ToString();
        }

        public static string generateTask_Letters(List<string> lines)
        {
            StringBuilder SB = new StringBuilder();
            foreach (string line in lines) SB.Append(line);
            return SB.ToString();
        }

        public static string generateTask_ControlText(List<string> lines)
        {
            return lines[new Random().Next(0, lines.Count)];
        }

        public static string visibleLine(string task, int step)
        {
            StringBuilder SB = new StringBuilder();
            for (int i = 0; i < 60; i++)
            {
                if (step + i < task.Length) SB.Append(task[step + i]);
                else break;
            }
            return SB.ToString(); 
        }
    }
}
