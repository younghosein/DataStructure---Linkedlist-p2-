using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist_Example_1
{
    class Linkedlist
    {
        public Node head;
        int loc = 0;

        public void print()
        {
            Node n = head;

            while (n != null)
            {
                Console.WriteLine(n.data);
                loc++;
                n = n.next;
            }
        }

        public void push(int nd)
        {
            Node nn = new Node(nd);

            nn.next = head;

            head = nn;
        }

        public void addafter(Node bn, int nd)
        {
            Node nn = new Node(nd);

            if (bn == null)
            {
                Console.WriteLine("\nNode Connot Be Null...!");
                return;
            }

            nn.next = bn.next;

            bn.next = nn;
        }

        public void append(int nd)
        {
            if (head == null)
            {
                head = new Node(nd);
                return;
            }

            Node nn = new Node(nd);

            nn.next = null;

            Node last = head;

            while (last.next != null)
            {
                last = last.next;
            }

            last.next = nn;
        }
        //
        public object deld(int d)
        {
            Node n = head;
            Node bn = null;

            if (n != null && n.data == d)
            {
                head = n.next;
                return d;
            }

            while (n != null && n.data != d)
            {
                bn = n;
                n = n.next;
            }

            if (n == null)
                return null;

            bn.next = n.next;
            return d;
        }
        //
        public void delp(int p)
        {
            if (head == null)
                return;

            Node n = head;

            if (p == 0)
            {
                head = n.next;
                return;
            }

            for (int i = 0; n != null && i < p - 1; i++)
                n = n.next;

            if (n == null || n.next == null)
                return;

            Node next = n.next.next;

            n.next = next;
        }
        public void DelMax(Node hed)
        {

            int max = int.MinValue;

            while (hed != null)
            {
                if (max < hed.data)
                    max = hed.data;
                hed = hed.next;
            }
            int d = max;
            Console.Write(d+"\n");

            Node n = head;
            Node bn = null;

            if (n != null && n.data == d)
            {
                head = n.next;
                return;
            }

            while (n != null && n.data != d)
            {
                bn = n;
                n = n.next;
            }

            if (n == null)
                return;

            bn.next = n.next;
        }

        public void addiSort(int num)
        {
            Node nn = new Node(num);

            if (head == null)
            {
                head = nn;
            }
            else
            {
                Node n = head;
                Node end = null;
                int temp = 0;
                while (n != null && temp==0)
                {
                    if (n.data > num)
                    {
                        temp = 1;
                    }
                    else
                    {
                        end = n;
                        n = n.next;
                    }
                }
                if (end == null)
                {
                    nn.next = head;
                    head = nn;
                }
                else
                {
                    nn.next =n;
                    end.next = nn;
                }
            }
        }
    }

}
