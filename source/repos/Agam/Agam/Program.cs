using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Agam
{
    internal class Program
    {
        public static void InsertIfCostumerIsValid(Queue<Costumer> q, Costumer c)
        {
            if (c.Gettempereture() >= 38)
            {
                Console.WriteLine("This Costumer have too high of a tempereture, he can't enter");
            }
            if (c.GetisBidud() == true)
            {
                Console.WriteLine("This Costumer needs to be in bidud, he can't enter");
            }
            if (c.GetisMask() == false)
            {
                Console.WriteLine("This Costumer does'nt have a mask, he can't enter");
            }

            q.Enqueue(c);
            Console.WriteLine("The Costumer " + c.GetName() + " " + c.GetLastName() + " has entered the queue");
        }
        public static void InsertXNumberOfCostumers(Queue<Costumer> q)
        {
            Console.WriteLine("Choose number of costumers you want to enter to queue");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("enter name of Costumer");
                string name = Console.ReadLine();

                Console.WriteLine("enter last name of Costumer");
                string lastName = Console.ReadLine();

                Console.WriteLine("enter Costumer's tempereture");
                double tempereture = double.Parse(Console.ReadLine());

                Console.WriteLine("does the costumer have corona? yes or no");
                string corona = Console.ReadLine();
                bool isCorona = true;
                if (corona == "yes")
                {
                    isCorona= true;
                }
                else if (corona == "no")
                {
                    isCorona = false;
                }

                Console.WriteLine("does the Costumer wear a mask? enter yes or no");
                string mask = Console.ReadLine();
                bool isMask = true;
                if (mask == "yes")
                {
                    isMask = true;
                }
                else if (mask == "no")
                {
                    isMask = false;
                }

                Console.WriteLine("does the Costumer needs to be in bidud? enter yes or no");
                string bidud = Console.ReadLine();
                bool isBidud = true;
                if (mask == "yes")
                {
                    isMask = true;
                }
                else if (mask == "no")
                {
                    isMask = false;
                }
                Costumer c = new Costumer(name, lastName, tempereture, isMask, isBidud, isCorona); 

                InsertIfCostumerIsValid(q, c);
            }
        }
        public static void PrintCostumersInQueue(Queue<Costumer> q)
        {
            
            string firstCostumerName;
            string firstCostumerLastName;
            if (q.Count() > 0)
            {
                firstCostumerLastName = q.Peek().GetLastName();
                firstCostumerName= q.Peek().GetName();
            }

            Queue<Costumer> temp = new Queue<Costumer>();

            for (int i = 0; i < q.Count(); i++)
            {
                Console.WriteLine(q.Peek().ToString());
                temp.Enqueue(q.Dequeue());
            }

            for (int i = 0; i < temp.Count(); i++)
            {
                q.Enqueue(temp.Dequeue());
            }
        
        }
        static void Main(string[] args)
        {
            Costumer c = new Costumer("s", "s", 3, true, false, false);
            Queue<Costumer> q = new Queue<Costumer>();
            Console.WriteLine("To add costumer to queue press 1");
            int x = int.Parse(Console.ReadLine());
            if (x == 1) 
            {
                InsertIfCostumerIsValid(q,c);
            }
            Console.WriteLine("To add an x number of costumer to queue press 2");
            int y = int.Parse(Console.ReadLine());
            if (y == 2)
            {
                InsertXNumberOfCostumers(q);
            }
            Console.WriteLine("To print the costumers information press 3");
            int z = int.Parse(Console.ReadLine());
            if (z == 3) 
            {
                PrintCostumersInQueue(q);
            }
            
            
            


        }
    }
}
