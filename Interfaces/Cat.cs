using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Cat : Animal
    {
        public bool Meow { get; set; } = true;

        public bool Purr { get; set; } = true;

        public string HasBabies()
        {
            if (BornAlive == true)
            {
                return "Take care of new kittens";
            }
            else
            {
                return "No kittens to take care of";
            }
        }
           
	

	}

    
}
