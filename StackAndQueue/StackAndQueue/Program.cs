using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackAndQueue
{
    public class StackAndQueue<T>
    {
        private Node<T> top;
        public StackAndQueue()
        {
            this.top = null;
        }
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} Pushed to stack", value);
        }
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top  of the  stack", this.top.data);
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty,Deletion is not Possible");
                return;
            }
            Console.WriteLine("Value Popped is {0}", this.top.data);
            this.top = this.top.next;
        }
        public void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
        public void Display()
        {
            Node<T> temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}