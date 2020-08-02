using System;

namespace IDisposableAndDestructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var resourceholder = new ResourceHolder();
            resourceholder.Dispose();
        }
    }
    public class ResourceHolder : IDisposable
    {
        private bool isDisposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    // Cleanup objects by calling their methods
                }
                isDisposed = true;
            }
            //~ResourceHolder()
            // {
            //    Dispose(false);
            //  }
            void SomeMethod()
            {
                // Ensure object not already disposed before execution of any method
                if (isDisposed)
                {
                    throw new ObjectDisposedException("ResourceHolder");
                } // method implementation

            }
        }
    }
}
