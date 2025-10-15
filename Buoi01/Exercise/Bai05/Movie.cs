using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Exercise.Bai05
{
    public class Movie
    {
        public string Name { get; set; }
        public decimal StandardPrice { get; set; }
        public List<int> Rooms { get; set; }

        public Movie(string name, decimal standardPrice, List<int> rooms)
        {
            Name = name;
            StandardPrice = standardPrice;
            Rooms = rooms;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
