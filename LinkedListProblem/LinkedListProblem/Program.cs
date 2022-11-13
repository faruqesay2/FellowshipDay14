using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListProblem
{
    public class LinkedList<T> where T : IComparable<T>
    {
        public Node<T> head;
        //UC1
        //Add method to insert into linkedlist
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        //UC2
        /// <summary>
        /// Method create "AddInReverseOrder" 
        /// </summary>
        /// <param name="data"></param>
        internal void AddInReverseOrder(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node<T> temp = this.head;
                head = newNode;
                head.next = temp;
            }
        }
        public void Append(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> node1 = head;
                while (node1.next != null)
                {
                    node1 = node1.next;
                }
                node1.next = node;
            }
            Console.WriteLine("{0} append into linked list", node.data);
        }
        public Node<T> InsertAtParticularPosition(int Position, T data)
        {
            Node<T> node = new Node<T>(data);
            if (Position < 1)
            {
                Console.WriteLine("Invalid Position");

            }
            else if (Position == 1)
            {
                node.next = this.head;
                head = node;
            }
            else
            {
                Node<T> temp = head;
                while (Position > 2)
                {
                    temp = temp.next;
                    Position--;
                }
                node.next = temp.next;
                temp.next = node;
            }
            return node;
        }
        public Node<T> Pop()
        {
            Node<T> node = head;
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                head = head.next;
            }
            return node;
        }
        public Node<T> PopLast()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
                return null;
            }
            else
            {
                Node<T> n = head;
                while (n.next.next != null)
                {
                    n = n.next;
                }

                n.next = null;
                return n;
            }
        }
        public int Search(T data)
        {
            int count = 0;
            Node<T> temp = head;
            if (this.head == null)
            {
                Console.WriteLine("Element Not found plz try Again");
                return 0;
            }
            while (temp != null)
            {
                if (temp.data.Equals(data))
                {
                    Console.WriteLine("Element Found sucessfully");
                    return count;
                }
                temp = temp.next;
                count++;
            }
            return 0;
        }
        public void InsertNodeAfterParticularNode(T data, T dataToSearch)
        {
            int position = Search(dataToSearch);
            if (position == 0)
            {
                Console.WriteLine("No such element found");
                return;
            }
            Node<T> node = new Node<T>(data);
            Node<T> temp = this.head;
            for (int i = 1; i < position; i++)
            {
                temp = temp.next;
            }
            node.next = temp.next;
            temp.next = node;
        }
        public void DeleteMiddleNode(T data)
        {
            int posation = Search(data);
            if (posation == 0)
            {
                Console.WriteLine("No Such element found");
                return;
            }
            Node<T> temp = head;
            for (int i = 1; i < posation; i++)
            {
                temp = temp.next;
            }
            temp.next = temp.next.next;
        }
        public void Size()
        {

            Node<T> temp = this.head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
                count++;
            }
            Console.WriteLine($"Linked List Size is {count}");

        }
        public void AscendingOrderSort(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> temp;
            if (head == null || (head.data.CompareTo(node.data)) < 0)
            {
                node.next = head;
                head = node;
            }
            else
            {
                temp = head;
                while (temp.next != null && (temp.next.data.CompareTo(node.data)) < 0)
                {
                    temp = temp.next;
                    node.next = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("Data inserted " + node.data);
        }
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linkedlist is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}