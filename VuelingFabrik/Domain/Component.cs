using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelingFabrik.Domain
{
    public abstract class Component : Subcomponent
    {
        public string Type { get; set; }
        public bool Polished { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }


    }
}
