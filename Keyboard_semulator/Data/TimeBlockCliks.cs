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
        public int secondStartSession; 
        public int countClicks;

        public TimeBlockCliks(int secondStartSession, int countClicks)
        {
            this.secondStartSession = secondStartSession;
            this.countClicks = countClicks;
        }
    }
}
