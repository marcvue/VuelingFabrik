using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingFabrik.Domain;

namespace VuelingFabrik.Domain.Order
{
    class OrderDto
    {
        public string Type { get; set; }

        public IEnumerable<Subcomponent> { get; set;}
    }
}
