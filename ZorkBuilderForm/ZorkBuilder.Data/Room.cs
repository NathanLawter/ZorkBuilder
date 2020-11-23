using System;
using System.Collections.Generic;
using System.Text;

namespace ZorkBuilder.Data
{
    public class Room
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Neighbor Neighbors { get; set; }

        public Room()
        {
            Neighbors = new Neighbor();
        }
    }
}
