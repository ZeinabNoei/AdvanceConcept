using System.Windows;

namespace Events
{
    public class WeakCarInfoEventManager : WeakEventManager
    {
        private WeakCarInfoEventManager() { }
        //custom manager
        public static WeakCarInfoEventManager CurrentManager
        {
            get
            {   //اگر وجود داشت از getcurrentManager میگیره 
                //WeakCarInfoEventManager manager = GetCurrentManager(typeof(WeakCarInfoEventManager)) as WeakCarInfoEventManager;
                WeakCarInfoEventManager manager = GetCurrentManager(typeof(WeakCarInfoEventManager)) as WeakCarInfoEventManager;
                if (manager == null)
                {
                    manager = new WeakCarInfoEventManager();
                    SetCurrentManager(typeof(WeakCarInfoEventManager), manager);
                }
                return manager;
            }
        }
        private void WeakCarInfoEventManager_NewCarInfo(object sender, CarInfoEventArgs e)
        {
            DeliverEvent(sender, e);
        }
        protected override void StartListening(object source)
        {
            // write start listening code here...
            (source as CarDealer).NewCarInfo += WeakCarInfoEventManager_NewCarInfo;
        }
        protected override void StopListening(object source)
        {
            (source as CarDealer).NewCarInfo -= WeakCarInfoEventManager_NewCarInfo;
            // write stop listening code here...
        }
        public static void AddListener(object source, IWeakEventListener listener)
        {
            CurrentManager.ProtectedAddListener(source, listener);
        }
        public static void RemoveListener(object source, IWeakEventListener listener)
        {
            CurrentManager.ProtectedRemoveListener(source, listener);
        }
    }
}
