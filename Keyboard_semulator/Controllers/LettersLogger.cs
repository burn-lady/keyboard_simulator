using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Keyboard_semulator.Controllers
{
    public class LettersLogger
    {
        public static string DIR_LOG = Application.StartupPath + "/users_logs";
        private static string username = "default";
        private static string pathToLog = ""; 

        

        public static void setUserAndCreateLog(string userName)
        {
            username = userName;
            Directory.CreateDirectory(DIR_LOG + "/" + username);
            pathToLog =  DIR_LOG + "/" + username + "/" + username + "-" + DateTime.Now.DayOfYear  + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + ".txt";
            File.AppendAllLines(pathToLog, new string[] {
                "Упражнение выполнил(а) " + username,
                "Дата " + DateTime.Now,
                " "
            });
        }

     

        public static void writeLog(char letter, int value)
        {
            File.AppendAllLines(pathToLog, new string[] {
            letter + " - " + DateTime.Now + " " + DateTime.Now.Millisecond,
            value.ToString(),
            "-------------------------------"
            });
        }
    }
}
