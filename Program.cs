using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        public int age;
        public string name;
        public void SayHi()
        {
            Console.WriteLine("Hi!");
        }
    }
    class Dog
    {
        public string name;
        public int age;
        public double age_Human;
        public double DogAgeToHumanAge(int Dog_Age)
        {
            double HumanAge = 0;
            if (Dog_Age > 2)
            {
                for (int i = Dog_Age; i > 0; i--)
                {
                    if (i <= 2)
                    {
                        HumanAge = HumanAge + 10.5;
                    }
                    else
                    {
                        HumanAge = HumanAge + 4;
                    }
                }
            }
            else
            {
                for (int i = Dog_Age; i > 0; i--)
                {
                    HumanAge = HumanAge + 10.5;
                }
            }
            return HumanAge;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.SayHi();
            p1.name = "Dennis";
            p1.age = 21;
            Dog d1 = new Dog();
            Console.WriteLine("What is your dog's name?");
            d1.name = Console.ReadLine();
            Console.WriteLine("How old is {0}",d1.name);
            d1.age = Convert.ToInt32(Console.ReadLine());
            d1.age_Human = d1.DogAgeToHumanAge(d1.age);
            Console.WriteLine("{0} is {1} in human years.", d1.name, d1.age_Human);
            //Encapsulation is through use of access modifiers.
            /* There are six types of access modifiers
             * public       : An external class can access this
             * private      : Access is only from within the class
             * protected    : Discussed Later
             * internal     : Discussed Later
             * protected internal : Discussed Later
             */
            Bank b1 = new Bank();
            Console.WriteLine("{0}",b1.Name);
            Console.WriteLine("{0}",b1.accountNumber);
            Console.WriteLine("{0}",b1.ShowBalance());
            b1.Name = p1.name;
            b1.Deposit(11000.222);
            b1.Withdraw(212.212);
            double balance = b1.ShowBalance();
            Console.WriteLine("{0}", b1.Name);
            Console.WriteLine("{0}", b1.accountNumber);
            Console.WriteLine("{0}", b1.ShowBalance());
            Console.WriteLine("You have {0} in your account", balance);
            /*
             * So now let us try the power of constructors
             * Constructors are basically components of the class that need to be executed
             * each time an object is created.
             * Maybe the first time a 'bank account' is created, you need
             * to send an email to the person whose account it is, etc.
             */
            Bank b2 = new Bank();
            b2.Name = "Bob";
            Console.WriteLine(b2.Name);

        }
    }
    class Bank
    {
        private string accountHolderName;
        private double balance = 0;
        public int accountNumber;
        public Bank()
        {
            balance = 0;
            accountHolderName = "";
            accountNumber = 1234567890;
        }
        public string Name
        {
            get { return accountHolderName; }
            set { accountHolderName = value; }
        }
        public void Deposit(double money)
        {
            balance += money;
        }
        public void Withdraw(double money)
        {
            balance -= money;

        }
        public double ShowBalance()
        {
            return balance;
        }
        //Now let us check something called class properties
        //Properties use accessors like - get and set to assign values to a private member of the class
    }
}

/*
static void Main(string[] args)
{
    //Module 1
    Console.WriteLine("Hello World");
    /*int randomNumber = 5;
    *Console.WriteLine("The Random Number is {0}", randomNumber);
    *string yourName;
    *Console.WriteLine("What is your name?");
    *yourName = Console.ReadLine();
    *Console.WriteLine("Hello {0}. It is a pleasure to meet you.", yourName);
    *int yourAge;
    *Console.WriteLine("Could I please ask you for your age?");
    *yourAge = Convert.ToInt32(Console.ReadLine());
    *Console.WriteLine("Oh! So you are {0} years old then!", yourAge);
    //The above code is just random examples of input and output
    /*
     * This infact is an example of just how commenting works.

    *var randomInformation = true;
    //Console.WriteLine(randomInformation);
    const double Pi = 3.14;
    //Console.WriteLine("The value of Pi is {0}", Pi);
    //Module 1 ends here
    */
/*
Console.WriteLine("Module 1 ends here, Module 2 begins");
//Module 2
/*
if (Pi * yourAge > 3.1 * 21)
{
    Console.WriteLine("You are old enough to drink!");
    Console.WriteLine("So, how would you like to celebrate? Wait... before that.. I need to know \nHow much marks did you get?");
    double marks = Convert.ToDouble(Console.ReadLine());
    if (marks > 50)
    {
        Console.Write("Congrats!");
        if (marks == 100)
        {
            Console.Write(" You have a perfect score!\n");
        }
        else if (marks > 90)
        {
            Console.Write(" That is a high score! Wow!");
        }
        Console.WriteLine("Here is your drink!");
    }
    else
    {
        Console.WriteLine("No Drinks for you!");
    }
}
else
{
    Console.WriteLine("UNDERAGE!! FELONY!!");
}
Console.WriteLine("\nLet us try the Switch Case now!");
int num = 10;
switch (num)
{
    case 1:
        Console.WriteLine("The num is {0}", num);
        break;
    case 10:
        Console.WriteLine("The num is {0}", num);
        break;
    case 3:
        Console.WriteLine("The num is {0}", num);
        break;
    default:
        Console.WriteLine("Your num is not found!");
        break;
}

Console.WriteLine("Now! While Loop!");
num = 1;
while (num < 6)
{
    Console.WriteLine("{0} now!", num);
    num++;
}

Console.WriteLine("\nIt is now time for loop! :P\n");
num = 1;
int sum = 0;
for (num = 0; num < 100; num++)
{
    sum = sum + num;
}
Console.WriteLine("The Sum is {0}", sum);
Console.WriteLine("\n\nNow it is time for some do-while!\n");
num = 1;
do
{
    Console.WriteLine("{0}", num);
    num = num + 2;
} while (num < 10);

Console.WriteLine("\n\nNow time for some break and continue.\n");
num = 1;
while (num < 10)
{
    Console.WriteLine("{0}", num);
    num++;
    if (num <= 6)
    {
        continue;
        //break;
    }
    else
    {
        break;
    }

}
Console.WriteLine("There is another way of using if-else by using ? operator");
string msg;
msg = randomInformation ? "Welcome" : "Sorry";
Console.WriteLine("{0}", msg);
Console.WriteLine("Let us make a calculator\n\n\n");
int transaction = 0;
do
{
    string exit;
    Console.Write("x = ");
    exit = Console.ReadLine();
    if (exit == "exit")
    {
        break;
    }
    double x = Convert.ToDouble(exit);
    Console.Write("y = ");
    exit = Console.ReadLine();
    if (exit == "exit")
    {
        break;
    }
    double y = Convert.ToDouble(exit);
    double sum2 = x + y;
    Console.WriteLine("The sum is {0}", sum2);
    transaction++;
} while (transaction < 12);
}

//Module 2 ends here
Console.WriteLine("Module 2 ends here, Module 3 begins");
// Module 3
int result;
double m = 24.2;
double resultD = Sqr(ref m);
Console.WriteLine("The square of {0} is {1}", m, resultD);
Console.WriteLine("The answer of {0} multiplied by 2 is {1}", 10, prod(10));
Console.WriteLine("The answer of {0} multiplied by {1} is {2}", 10, 20, prod(10, 20));
result = prod(y: 10, x: 20);
Console.WriteLine("{0}", result);
int x = 100;
int y = 200;
Console.WriteLine("Pass by value");
result = prod(x, y);
Console.WriteLine("Pass by reference");
Console.WriteLine("Before, {0} is the value of x", x);
result = Sqr(ref x);
Console.WriteLine("After, {0} is the value of x", x);
Console.WriteLine("{0}", result);
Console.WriteLine("Now we can check the OUT parameter");
int a,
    b;
GetValue(out a, out b);
Console.WriteLine("{0}, {1}", a, b);
Console.WriteLine("Let us find factorial of some number.");
Console.WriteLine("Write a number");
double numb = Convert.ToDouble(Console.ReadLine());
resultD = Fact(numb);
Console.WriteLine("Factorial of {0} is {1}", numb, resultD);
Console.WriteLine("Lets make a Pyramid");
Console.WriteLine("How many layers should it have");
int layer = Convert.ToInt32(Console.ReadLine());
Pyra(layer);
}
static double Fact(double x)
{
if (x == 1)
{
    return 1;
}
return (x * Fact(x - 1));
}
static void GetValue(out int x, out int y)
{
x = 5;
y = 70;

}
static int Sqr(ref int x)
{
int result = x * x;
x = x + 1;
return result;
}
static double Sqr(ref double x)
{
double result = x * x;
return result;
}
static int prod(int x, int y = 2)
{
return x * y;
}
static void Pyra(int layer, int space = 0)
{
int layer2 = layer;
for (int i = 0; i < layer; i++)
{
    for (int k = 0; k < layer2; k++)
    {
        Console.Write(" ");
    }
    layer2--;
    for (int j = i + 1; j > 0; j--)
    {
        Console.Write(" *");
    }
    Console.WriteLine();
}
}
//Module 3 ends
//Module 4 starts
*/
