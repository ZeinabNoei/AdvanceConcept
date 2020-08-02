using System.Collections.Generic;

namespace Document
{
    class DocumentManager<TDocument> where TDocument : IDocument
    {
        private readonly Queue<TDocument> documnetQueue = new Queue<TDocument>();
        //public void AddDocumnet (TDocument documnetQueue)
        public bool IsDocumnetAvailable
        {
            get { return documnetQueue.Count > 0; }
        }
        public TDocument GetDocumnet()
        {
            TDocument doc = default(TDocument);
            lock (this)
            {
                doc = documnetQueue.Dequeue();
            }
            return doc;
        }
        public void AddtDocumnet(TDocument documnet)
        {
            lock (this)
            {
                documnetQueue.Enqueue(documnet);
            }
        }
        public List<string> GetTitles()
        {
            List<string> titles = new List<string>();
            foreach (TDocument doc in documnetQueue)
            {
                titles.Add(doc.Title);
            }
            return titles;
        }
    }
}
