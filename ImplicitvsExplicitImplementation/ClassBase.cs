
namespace ImplicitvsExplicitImplementation
{
    public class ClassBase
    {
        public string Method()
        {
            return "Parent.Method (Public)";
        }
        public string Method1()
        {
            return "Parent.Method1 (Public)";
        }
        public string Method2()
        {
            return "Parent.Method2 (Public)";
        }
        private string Method3()
        {
            return ("Parent.Method5 (Private)");
        }
    }
}
