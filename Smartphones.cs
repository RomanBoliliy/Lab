using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab4_KPP
{
    internal class Smartphones : Staff
    {
        private string model;
        private string colour;
        public void Add(int id, string name, int num, string col, string mod) { ID = id; Name = name; Number = num; model = mod; colour = col; }
        public void CheckSegment(int id)
        {
            if (model == null && colour == null) { model =colour= "Unknown "; }
            if (ID == id)
            { Console.WriteLine("ID is: " + ID + "; Name is: " + Name + "; Number is: " + Number + "; Model is: "+model+"; Colour is: "+ colour); }
            else
            { Console.WriteLine("No more Smartphones with such ID. "); }
        }
        public void Get(int id)
        {
            if (ID == id && Number > 0)
            { Console.WriteLine("Number of Staff with ID " + ID + " Is equal: " + Number); }
            else
            { Console.WriteLine("Error. No more staff with this ID."); }
        }
        public void Delete(int id, int num)
        {
            if (ID == id)
            { Number -= num; Console.WriteLine(num + " Staff with ID: " + ID + " Was removed. " + Number + " left."); }
            else
            { Console.WriteLine("Error. Invalid ID. "); }

            check();
        }

    }
}
