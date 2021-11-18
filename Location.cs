using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public class Location
    {
        public string Name { get; set; }

        public string Description { get; set; }
        public string Story { get; set; }

        public List<Item> Items { get; set; } = new List<Item>();
        public List<Item> RequiredItems { get; set; } = new List<Item>();


    }
}
