using System;


namespace lab3_KPP
{
     class MotherClass
    {
        
        protected static string Password = "123";
        protected static string Login = "qwe";

        public void Refreshing() { Password = "0000"; Login = "0000"; }
       
    }
}
