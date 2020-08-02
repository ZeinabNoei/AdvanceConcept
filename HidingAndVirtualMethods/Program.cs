
namespace HidingAndVirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var deriveclass = new DerivedClass();
            deriveclass.BaseAbstractMethod();
            deriveclass.BasePublicMethod();
        }
    }  
}
