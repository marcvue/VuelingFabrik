using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelingFabrik.Validation
{
    interface IValidation<T>
    {
        bool Validate(T context);
    }
}
