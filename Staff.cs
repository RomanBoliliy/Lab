using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_KPP
{
    internal class Staff
    {
 
        protected int ID;
        protected string Name;
        protected int Number;

        public void Add(int id, string name, int num) { ID = id; Name = name; Number = num; }
        public void CheckSegment(int id) {
            if (ID == id)
            { Console.WriteLine("ID is: " + ID + "; Name is: " + Name + "; Number is: " + Number); }
            else
            { Console.WriteLine("No more Staff with such ID. "); }
                    }
        public void Get(int id) 
        { 
            if (ID == id && Number > 0)
            { Console.WriteLine("Number of Staff with ID "+ID+" Is equal: "+Number); } 
            else 
            { Console.WriteLine("Error. No more staff with this ID.");  } 
        }
        public void Delete(int id, int num) 
        {
            if (ID == id)
            { Number -= num; Console.WriteLine(num + " Staff with ID: " + ID + " Was removed. "+ Number+" left." ); }
            else
            { Console.WriteLine("Error. Invalid ID. "); }

            check();
        }
        
        protected void check() { if (Number == 0) { ID = 0; Name = null; } }


    }
}
