using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOLS_lab3.TV
{
    public class Channel
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string CurrentTelecast { get; set; }
        public Channel()
        {

        }
        public Channel(int number, string name, string currentTelecast)
        {
            Number = number;
            Name = name;
            CurrentTelecast = currentTelecast;
        }

        public override string ToString()
        {
            return $"{Number}: {Name} - {CurrentTelecast}";
        }
    }
}
