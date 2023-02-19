using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public Reptile()
        {
            Legs = 4;
            Eats = "Insects";
            Breaths = true;
            Age = 15;

        }
        public bool ColdBlooded { get; set; }
        public bool LaysEggs { get; set; }
        public string Habitat { get; set; }
        public bool tail { get; set; }



       

    }

    
}
