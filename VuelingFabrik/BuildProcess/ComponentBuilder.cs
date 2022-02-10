using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingFabrik.ComposeProcess;
using VuelingFabrik.Domain;

namespace VuelingFabrik.BuildProcess
{
    class ComponentBuilder
    {
        private Component _component;
        private ComponentBuilder BuildNewComponent(string type)
        {
            _component = new Component() { Type = type};
            return this;
        }

        public ComponentBuilder AddPart(Subcomponent subcomponent)
        {
            if (_component == null) throw new ArgumentNullException(nameof(House), "A new house must be built before adding parts");
            _component.Add(subcomponent);
            return this;
        }

        public Component Build() {
            return _component;
        }
    }
}
