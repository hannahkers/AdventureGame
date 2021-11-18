using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdventureGame
{
    public class Player
    {

        //character name + properties
        public string Name { get; set; }

        public List<Item> Inventory { get; set; } = new List<Item>();
    }
}
