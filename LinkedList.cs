using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemoPractice
{
    public class LinkedList
    {
        Node head;
            public void Add(int data)
            {
                Node node = new Node(data);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    Node temp = head;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = node;
                }
                Console.WriteLine("[0] inserted into LinkedList", node.data);
                }
            public void Display()
            {
                Node temp = this.head;

                if(temp == null)
                {
                    Console.WriteLine("LinkedList is empty");
                    return;
                }
                while(temp!=null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
            }
        public Node InsertAtPosition(int position,int data)
        {
            if(position <1)
                Console.WriteLine("invalid Position");
            if(position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode; 
            }
            else
            {
                while(position-- !=0)
                {
                    if(position ==1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head=head.next;

                }
                if (position != 1)
                    Console.WriteLine("Position Out of range");
            }
            return head;
        }
        public Node RemoveFirstNode()
        {
            if(this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
        public Node RemoveLastNode()
        {
            if (this.head == null)
            {
                return null;
            }
            if(head.next == null)
            {
                return null;
            }
            Node NewNode = head;
            while(NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;
            return head;
        }
        public Node search(int value)
        {
            while(this.head != null)
            {
                if(this.head.data == value)
                {
                    return this.head;
                }
                this.head=this.head.next;
            }
            return null;
        }
    }
}
