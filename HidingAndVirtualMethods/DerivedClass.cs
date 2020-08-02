using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingAndVirtualMethods
{
    class DerivedClass : BaseClass
    {
        public string DerivedPublicMethod()
        {
            return "this is DerivedPublicMethod ";

        }
        public string BasePublicMethod()
        {
            return "this is BasePublicMethod ";

        }
        public sealed override string BaseAbstractMethod()
        {
            return "this is concrete implementation of BaseAbstractMethod ";

        }
    }
}
