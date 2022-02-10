using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelingFabrik.Domain
{
    public class Component : Subcomponent
    {
        protected List<Subcomponent> _children = new List<Subcomponent>();
        public string Type { get; set; }
        public bool Polished { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }

        public void Add(Subcomponent subcomponent)
        {
            _children.Add(subcomponent);
        }
        public void Remove(Subcomponent subcomponent)
        {
            _children.Remove(subcomponent);
        }

        public override double GetPrice()
        {
            return _children.Sum(c => c.GetPrice() + 120);
        }
    }
}

