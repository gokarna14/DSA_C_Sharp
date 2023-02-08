using System.Collections.Generic;
namespace DSA_CS
{
    public class LinkedList<T>
    {   
        public T? val { get; set; }
        public LinkedList<T>? next { get; set; }
        public LinkedList<T>? prev { get; set; }
        LinkedList<T>? root;

        public LinkedList()
        {
        }

        public LinkedList(T[] values)
        {
            foreach(T value in values)
            {
                LinkedList<T> node = new LinkedList<T>();
                node.val = value;

                if (this.root == null)
                {
                    this.root = node;
                }
                else
                {
                    LinkedList<T> temp = this.root;

                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }

                    temp.next = node;
                    node.prev = node;
                }
            }
        }

        public void PrintElements()
        {
            if (this.root == null)
            {
                System.Console.WriteLine("There are no elements in the list");
                return;
            }
            LinkedList<T> temp = this.root;

            while (temp.val != null)
            {
                System.Console.WriteLine("Value: {0}", temp.val);
            }
        }

    }
}