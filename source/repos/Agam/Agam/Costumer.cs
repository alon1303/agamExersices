using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agam
{
    internal class Costumer :Person 
    {
        
        private Stack<Product> products = new Stack<Product>();
        
        public Costumer(string name, string lastName, double tempereture, bool isMask, bool isBidud, bool corona) : base(name, lastName, tempereture, isMask, isBidud, corona)
        {
           
        }
        public void SetProducts()
        {

            products.Push(product);
        }
        public Product GetProducts() 
        {
            return ; 
        }
        public override string ToString()
        {
            
                return "Costumer's information: " + "\nname: " + name + "\nlast name: " + lastName + "\nCostumer tempereture: " + tempereture + "\ndoes he have a mask? " + isMask + "\nIs he in bidud? " + isBidud;
            
           
        }
    }
}
