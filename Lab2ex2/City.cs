using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2ex2
{
    public class City
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public Dictionary<City, int> NeighboringCities { get; set; } 

    }
}
