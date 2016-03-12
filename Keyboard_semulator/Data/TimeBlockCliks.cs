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
        public int secondStartSession; // По идее, самое первое значение будет равно 5, а не 0
        public int countClicks;

        public TimeBlockCliks(int secondStartSession, int countClicks)
        {
            this.secondStartSession = secondStartSession;
            this.countClicks = countClicks;
        }
    }
}
