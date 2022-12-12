using lab4_KPP;
using System;

namespace lab4_KPP
{

    class Program
    {
        static void Main()
        {

        Staff Pen = new Staff();
        Smartphones Lenovo = new Smartphones();
        Laptops Acer = new Laptops();
            Console.WriteLine("");

            Lenovo.Add(20, "a228t", 5 );
            Lenovo.CheckSegment(20);    
            Lenovo.Get(20);
            Lenovo.Delete(20, 4);

            Console.WriteLine("");

            Acer.Add(20,"Gaming", 2);
            Acer.CheckSegment(20);
            Acer.Get(20);
            Acer.Delete(20, 1);

            Console.WriteLine("");
            
            Pen.Add(100, "PenPenPen", 20);
            Pen.Get(100);
            Pen.CheckSegment(100);
            Pen.Delete(100, 20);
            Pen.CheckSegment(100);

        }
    
    
    }












}