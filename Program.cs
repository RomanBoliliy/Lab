using lab3_KPP;
using System;


namespace Lab3_KPP
{
    class Program
    {
        static void Main()

        {
            string login, password;
            MotherClass user = new MotherClass();
            SetLog set= new SetLog();
            LogIN log= new LogIN();
            user.Refreshing();

            Console.WriteLine("Sign In first. \nEnter Login: ");
            login = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            password = Console.ReadLine();
            set.SetLogin(login);    
            set.SetPassword(password);  

            Console.WriteLine("Time to Log In. \nLogin: ");
            login = Console.ReadLine();
            Console.WriteLine("Password: ");
            password = Console.ReadLine();

            if (log.CheckLogin(login) && log.CheckPassword(password))
                Console.WriteLine("Signed succesfull");
            else { Console.WriteLine("Access denied"); }


        }
    }
}