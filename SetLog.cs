using System;

namespace lab3_KPP
{
     class SetLog : MotherClass
    {
        public string SetPassword(string UserPassword) { Password = UserPassword; return Password; }
        public string SetLogin(string UserLogin) { Login = UserLogin; return Password; }

    }
}
