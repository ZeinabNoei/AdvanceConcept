using System.Collections;

namespace LinkedListNode
{
    public class LinkedfList : IEnumerable
    {
        public LinkedfListNode First { get; private set; }
        public LinkedfListNode Last { get; private set; }
        public LinkedfListNode AddLast(object node)
        {
            var newNode = new LinkedfListNode(node);
            if (First == null)
            {
                First = newNode;
                Last = First;
            }
            else
            {
                Last.Next = newNode;
                Last = newNode;
            }

            return newNode;
        }
        public IEnumerator GetEnumerator()
        {
            LinkedfListNode current = First;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
    }
}
