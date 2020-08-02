using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingAndVirtualMethods
{
    abstract class BaseClass
    {
        private int basePrivateMemberVariable;
        protected int baseProtectedMemberVariable;
        protected string BaseProtectedMethod()
        {
            return "this is BaseProtectedMethod ";
        }
        public string BasePublicMethod()
        {
            return "this is BasePublicMethod ";
        }
        private string BasePrivateMethod()
        {
            return "this is BasePrivateMethod ";

        }
        protected virtual string BaseProtectedVirtualMethod()
        {
            return "this is BaseProtectedVirtualMethod ";

        }
        public abstract string BaseAbstractMethod();
    }
}
