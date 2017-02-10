using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class MyGeneric<T>
    {
        public T Add(T firstNum, T lastNum)
        {
            dynamic x = firstNum;
            dynamic y = lastNum;
            return x + y;
        }
    }
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double PhoneNum { get; set; }

        public void FullName()
        {
            Console.WriteLine("The FullName is " + FirstName + " " + LastName);
            Console.WriteLine("The PhoneNumber is " + PhoneNum);
        }
    }
    class FullTimeEmployee : Employee
    {
        public double YearlySalary { get; set; }
        public DateTime HiredDate { get; set; }


        public new void FullName()
        {
            Console.WriteLine("The FullName is " + FirstName + " " + LastName + " - FullTime");
            Console.WriteLine("The PhoneNumber is " + PhoneNum);
            Console.WriteLine("HiredDate is " + HiredDate);
        }

    }

    class ContractEmployee : Employee
    {
        public double HourlySalary { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime LastDate { get; set; }

        public new void FullName()
        {
            Console.WriteLine("The FullName is " + FirstName + " " + LastName + " - Contract");
            Console.WriteLine("The PhoneNumber is " + PhoneNum);
            Console.WriteLine("StartDate is " + StartDate);
            Console.WriteLine("LastDate is " + LastDate);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Employee e = new Employee();
            //e.FirstName = "Venu";
            //e.LastName = "Reddy";
            //e.PhoneNum = 9963487077;
            //e.FullName();

            MyGeneric<Int32> g = new MyGeneric<int>();
            int value = g.Add(10, 15);
            Console.WriteLine("The addition using generic method is " + value);
            Console.WriteLine("---------------------------------");

           

            FullTimeEmployee f = new FullTimeEmployee();
            f.FirstName = "Madhav";
            f.LastName = "Challa";
            f.PhoneNum = 2165719138;
            f.YearlySalary = 85000;
            f.HiredDate = new DateTime(2017, 02, 10);
            f.FullName();
            Console.WriteLine("---------------------------------");

            ContractEmployee c = new ContractEmployee();
            c.FirstName = "Sridhar";
            c.LastName = "Reddy";
            c.PhoneNum = 9346630434;
            c.HourlySalary = 55;
            c.StartDate = new DateTime(2017, 02, 15);
            c.LastDate = new DateTime(2017, 07, 20);
            c.FullName();
            Console.ReadLine();
        }
    }

}
