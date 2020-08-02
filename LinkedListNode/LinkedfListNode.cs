
namespace LinkedListNode
{
  public class LinkedfListNode
    {
        public object Value { get; private set; }
        public LinkedfListNode Next { get; internal set; }
        public LinkedfListNode Prev { get; internal set; }
        public LinkedfListNode(object value)
        {
            this.Value = value;
        }
    }
}
