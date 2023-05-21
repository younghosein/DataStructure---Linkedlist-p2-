using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist_Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Linkedlist L = new Linkedlist();

            L.head = new Node(23);
            Node sec = new Node(870);
            Node thi = new Node(92);
            Node fou = new Node(113);
            Node fif = new Node(250);
            L.head.next = sec;
            sec.next = thi;
            thi.next = fou;
            fou.next = fif;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Linkedlist Is :");
            L.print();
            Console.ResetColor();

            //Console.WriteLine("\nEnter The Number To Be Added :");
            //int nump = int.Parse(Console.ReadLine());
            //L.push(nump);
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("\nNow Linkedlist Is( Add At First ) :");
            //L.print();
            //Console.ResetColor();

            //Console.WriteLine("\nEnter The Number To Be Added :");
            //int numaf = int.Parse(Console.ReadLine());
            //L.addafter(L.head.next.next, numaf);
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("\nNow Linkedlist Is( Add After [ third Node / Second Pointer ] ) :");
            //L.print();
            //Console.ResetColor();

            //Console.WriteLine("\nEnter The Number To Be Added :");
            //int numa = int.Parse(Console.ReadLine());
            //L.append(numa);
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("\nNow Linkedlist Is( Add At End ) :");
            //L.print();
            //Console.ResetColor();

            //Console.WriteLine("\nEnter The Number To Be Deleted :");
            //int numd = int.Parse(Console.ReadLine());
            //Object dd = L.deld(numd);
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("\nNow Linkedlist Is ( Del Node [ " + dd + " ]  ) :");
            //L.print();
            //Console.ResetColor();

            //Console.WriteLine("\nEnter The Position Of Number To Be Deleted :");
            //int numdp = int.Parse(Console.ReadLine());
            //L.deld(numd);
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("\nNow Linkedlist Is ( Del Node [ Entered Key ]  ) :");
            //L.print();
            //Console.ResetColor();

            Console.Write("\nMax Is : ");
            L.DelMax(L.head);
            Console.WriteLine("\nNow Linkedlist Is ( Del Max ) :");
            L.print();
            //Console.WriteLine("\nEnter The Number To Be Added : [ Sort ]");
            //int sd = int.Parse(Console.ReadLine());
            //L.addiSort(sd);
            //Console.WriteLine("\nNow Linkedlist Is ( Add In Sort ) :");
            //L.print();
            //Console.WriteLine(m);



            Console.ReadKey();
        }
    }
}
