using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithGame
{
    public class Player
    {
        public char DisplayedChar { get; set; }
        public string Name { get; set; }
        public int Live { get; set; }

        public void Hit()
        {
            Live--;
        }

        public Player(string name, char displayedchar)
        {
            Live = 1;
            Name = name;
            DisplayedChar = displayedchar;
        }

    }
}
