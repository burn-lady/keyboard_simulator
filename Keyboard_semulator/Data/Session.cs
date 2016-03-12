using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyboard_semulator.Data
{
    [Serializable()]
    public class Session
    {
        public static string WORDS_SESSION = "Тип сессии: слова";
        public static string CONTROL_TEXT_SESSION = "Тип сессии: контрольный текст";

        public DateTime dateTime;
        public string typeSession;

        public int totalClicks;
        public int errorClicks;
        public int sessionTime;
        public int maxWords; // не используется в данный момент
        public int totalWords;

        public Dictionary<char, int> errorLetters;
        public List<TimeBlockCliks> listTimeBlockClicks;


        public Session(string typeSession, int totalClicks, int errorClicks, int sessionTime, int maxWords)
        {
            dateTime = DateTime.Now;
            this.typeSession = typeSession;
            this.totalClicks = totalClicks; this.errorClicks = errorClicks;
            this.sessionTime = sessionTime; this.maxWords = maxWords;
            errorLetters = new Dictionary<char, int>();
            listTimeBlockClicks = new List<TimeBlockCliks>();
        }

        public Session(string typeSession, int totalClicks, int errorClicks, int sessionTime,
            int maxWords, Dictionary<char, int> errorLetters, List<TimeBlockCliks> listTimeBlockClicks)
        {
            dateTime = DateTime.Now;
            this.typeSession = typeSession;
            this.totalClicks = totalClicks; this.errorClicks = errorClicks;
            this.sessionTime = sessionTime; this.maxWords = maxWords;
            this.errorLetters = errorLetters;
            this.listTimeBlockClicks = listTimeBlockClicks;
        }

      /*  public void addErrorLetter(char letter)
        {
            if (errorLetters.ContainsKey(letter)) errorLetters[letter]++;
            else errorLetters.Add(letter, 1);
        } */
 
        public string[] getArrayStringErrorLetters ()
        {
            List<string> lines = new List<string>();
            foreach (KeyValuePair<char, int> item in errorLetters)
                lines.Add(item.Key + " - " + item.Value);
            return lines.ToArray();
        }


        public static Session searchSession (User user, string DateTimeString)
        {
            foreach (Session session in user.listSessions)
                if (session.dateTime.ToString() == DateTimeString) return session;
            return null;
        }

    }
}
