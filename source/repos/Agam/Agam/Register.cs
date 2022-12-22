using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Agam
{
    internal class Register
    {
        private Queue<Costumer> registersQueue;
        public Register(Worker worker) 
        {
            this.registersQueue = new Queue<Costumer>();
        }

        public void InsertCostumerToRegister(Costumer costumer)
        {
            Console.WriteLine("which product the costumer purchased?");
            string nameOfProduct = Console.ReadLine();
            costumer.GetProduct().SetNameOfProduct(nameOfProduct);
            registersQueue.Enqueue(costumer);
        }



        public string GetWorkerDate(Worker worker) 
        {
           return worker.GetDate();
        }
    }
}
