using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyboard_semulator.Data
{
    [Serializable()]
    public class TimeBlockCliks
    {
    
        public int minisecondStartSession; 
        public int countClicks;

        public TimeBlockCliks(int secondStartSession, int countClicks)
        {
            this.minisecondStartSession = secondStartSession;
            this.countClicks = countClicks;
        }
    }
}
