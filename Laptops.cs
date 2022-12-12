using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_KPP
{
    internal class Laptops : Staff
    {
        private string model;
        private string CPU;
        private string GPU;

        public void Add(int id, string name, int num, string mod, string cpu, string gpu) { ID = id; Name = name; Number = num; model = mod; CPU = cpu; GPU = gpu; }
        public void CheckSegment(int id)
        {
            if (model == null && GPU== null && CPU==null ) { model = CPU = GPU = "Unknown "; }
            if (ID == id)
            { Console.WriteLine("ID is: " + ID + "; Name is: " + Name + "; Number is: " + Number + "; Model is: "+ model +"; CPU type is: "+ CPU +"; GPU type is: "+GPU); }
            else
            { Console.WriteLine("No more Staff with such ID. "); }
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
