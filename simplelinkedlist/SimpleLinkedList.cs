using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simplelinkedlist
{
    internal class SimpleLinkedList<T>
    {
        public Node<T> First;

        public void AddFirst(T data)
        {
            // skapa ett nytt Node-objekt och lägg in värdet data
            Node<T> newNode = new Node<T>();
            newNode.Value = data;

            // om det redan finns ett element (nod) inlagd, så
            // länka den nya noden till den gamla noden
            if (First != null)
            {
                newNode.Next = First;
            }
                

            // sätt listans första nod till att vara den nya noden
            First = newNode;
        }

        public int Count()
        {
            Node<T> minNod = First;
            int count = 0;
            while (minNod != null)
            {
                minNod = minNod.Next;
                count++;
            }
            
            return count;
        }
        
        public void Clear()
        {
            First = null;
        }

        public T ElementAt(int index)
        {
            // TODO
            return null;
        }




    }
}
