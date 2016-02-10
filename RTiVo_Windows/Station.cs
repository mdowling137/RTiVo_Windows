using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTiVo_Windows
{
    public class Station : IComparable
    {
        private int frequency;
        private String name;
        public Station(int freq)
        {
            this.frequency = freq;
            int topF = freq / 100;
            int bFreq = (freq - topF*100)/10;
            this.name = String.Format("{0,-3}.{1,-1}", topF, bFreq);
            System.Diagnostics.Debug.WriteLine(name + " - " + frequency);
        }
        public int getFrequency()
        {
            return frequency;
        }
        public String getName()
        {
            return name;
        }
        public int CompareTo(object obj)
        {
            Station other = obj as Station;
            if (other.frequency < frequency)
            {
                return 1;
            }
            if (other.frequency > frequency)
            {
                return -1;
            }

            // The orders are equivalent.
            return 0;
        }

    }
}
