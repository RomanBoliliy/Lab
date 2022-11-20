#include <iostream>;
#include <string>;
using namespace std;
//Система авторизації



//Об'єднання
union SignStatus
{
	bool Signed;
	bool UnSigned;
};


//Віртуальний Клас
class SignIn
{
protected:

	string EnteredLog;
	string EnteredPassword;
	SignStatus Status;

public:

	string CorrectLog;
	string CorrectPassword;
	//Методи для перевірки логіну та паролю
	virtual void SetLog(string lo) { EnteredLog = lo; }
	virtual void SetPassword(string pa) { EnteredPassword = pa; }
	bool Check() {
		if (CorrectLog == EnteredLog && CorrectPassword == EnteredPassword) { cout << "Signed in success" << endl; Status.Signed = true; }
		else { cout << "Sign in error" << endl;  Status.Signed = false; }
		return Status.Signed;
	}
	void isSigned(bool ck) { if (ck) { cout << "You are signed\n"; } else { cout << "You aren`t signed\n"; } }
};



//Клас 
class SignUP : public SignIn 
{ 
	
public:
	/*Створення цієї змінної на мою думку є неправильним кроком, але я не зміг придумати альтернативу.Через неї довелося вивести 	string CorrectLog; string CorrectPassword; у public
 секцію. Але без цієї змінної не вдавалося змінювати логін та пароль*/ 

	SignIn a;

	//Методи для зміни логіну/паролю

	void SetLog(string l) { a.CorrectLog = l; cout << "Login was chenged;\n"; }
	void SetPassword(string p) { a.CorrectPassword = p; cout << "Password was chenged;\n";
	}
};




int main()
{
	SignIn test; SignUP test1;
	short int choise;
	string l, p;
	test1.a.Check();
	cout << "You want sign up (0) or sign in (1) or exit (2)?\n";
	cin >> choise;
	cin.ignore(32767, '\n');

	//Цикл для можливості або входження в систему, або зміни логіна і пароля
	do
	{
		cout << "Enter Login: \n";
		getline(cin, l);
		cout << "Enter Password: \n";
		getline(cin, p);

	if (choise == 1) {
	
		test1.a.SetLog(l);
		test1.a.SetPassword(p);
		test1.a.isSigned(test1.a.Check());
	
	}
	else if (choise == 0) {
		

		cout << "Login before: " << test1.a.CorrectLog << " Password before: " << test1.a.CorrectPassword << endl;
		test1.SetLog(l);
		test1.SetPassword(p);
		cout << "Login after: " << test1.a.CorrectLog << " Password after: " << test1.a.CorrectPassword << endl;
	}
	cout << "You want sign up (0) or sign in (1) or exit (2)?\n";
	cin >> choise;
	cin.ignore(32767, '\n');
	} while (choise < 2);
	return 0;
 
}
