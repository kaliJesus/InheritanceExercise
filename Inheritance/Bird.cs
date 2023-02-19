using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public Bird() 
        {
            Legs = 2;
            Eats = "Seed";
            Breaths = true;
            Age = 10;

        }
        public bool Fly { get; set; }
        public bool Sing { get; set; }
        public double beaks { get; set; }
        public int Wings { get; set; }


        
    }






}


    

