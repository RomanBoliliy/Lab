using System;
using System.Security.Cryptography.X509Certificates;

namespace lab3_KPP
{
    class LogIN :  MotherClass
    {
        public bool CheckPassword(string UserPassword) { if (Password == UserPassword) return true; else return false; }
        public bool CheckLogin(string UserLogin) { if (Login == UserLogin) return true; else return false; }


    }
}
