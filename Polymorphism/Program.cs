using System;

namespace Polymorphism
{
    public class Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintFullName() 
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    public class FullTimeEmployee : Employee 
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "Full Time");
        }
    }
    class Progarm
    {
        static void Main(string[] args)
        {
            Employee fte = new FullTimeEmployee();
            fte.PrintFullName();
        }
    }
}

/* Polymorphism in C#
 

Defination: Polymorphism allows you to invoke derived class methods through a base class reference during runtime is known as polymorphism.

Note Points:

1.In base class the method is declared virtual, and in the derived class we override the same method.

2.The virtual keyword indicates, the method can be overridden in any derived class.
 
 





 */