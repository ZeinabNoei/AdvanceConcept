
namespace EventHandler
{
    public delegate void Handler(int value);
    public class Publisher
    {

        public event Handler UpdateStatusHandler;
        public void DoAJob()
        {
            for (int i = 0; i < 10; i++)
            {
                UpdateStatus(i);
                System.Threading.Thread.Sleep(1000);
            }
        }
        private void UpdateStatus(int value)
        {
            if (this.UpdateStatusHandler != null)
            {
                UpdateStatusHandler(value);
            }
        }

    }
}
