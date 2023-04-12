using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Mammal : IMammal
    {
        public bool IsWarmBlooded { get; set; } = true;
        public bool ProducesMilk { get; set; } = true;
        public bool HasHairOrFur { get; set; } = true;
        public bool BornAlive { get; set; } = true;
    }
}
