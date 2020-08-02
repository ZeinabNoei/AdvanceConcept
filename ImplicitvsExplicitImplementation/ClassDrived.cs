
namespace ImplicitvsExplicitImplementation
{
    public class ClassDrived : ClassBase
    {
        public string Method1()
        {
            return "Child.Method1";
        }
        public string Method2()
        {
            return "Child.Method2";
        }
          private string Method4()
        {
            return "Child.Method4";
        }
        public string Method5()
        {
            return "Child.Method5";
        }
    }
}
