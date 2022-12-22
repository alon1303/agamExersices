using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agam
{
    internal class Person
    {
       
        protected string name;
        protected string lastName;
        protected double tempereture;
        protected bool isMask;
        protected bool isBidud;
        protected bool corona;
        protected Person(string name, string lastName, double tempereture, bool isMask, bool isBidud, bool corona)
        {
            
            this.name = name;
            this.lastName = lastName;
            this.tempereture = tempereture;
            this.isMask = isMask;
            this.isBidud = isBidud;        

        }

        //פעולות שמחזירות תכונות
        public string GetName()
        {
            return this.name;
        }
        public string GetLastName()
        {
            return this.lastName;
        }
        public double Gettempereture()
        {
            return this.tempereture;
        }
        public bool GetisMask()
        {
            return this.isMask;
        }
        public bool GetisBidud() 
        {
            return this.isBidud;
        }

        //פעולות שמגדירות תכונות
        public void SetName(string name)
        { 
            this.name = name;
        }
        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }
        public void SetTempereture(Double tempereture)
        {
            this.tempereture = tempereture;
        }
        public void SetIsMask(Boolean isMask)
        {
            this.isMask = isMask;
        }
        public void SetIsBidud(Boolean isBidud)
        {
            this.isBidud = isBidud;
        }

            
    }
}
