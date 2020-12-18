  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ambdas_assignment
{
    class Program
    {
        static void Main1(string[] args)
        {
            //1. decimal SimpleInterest(decimal P, decimal N, decimal R) -> returns calculated SimpleInterest 

            Console.WriteLine("Simple Interst");
            Console.WriteLine("Enter Principle amount");
            decimal p1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter rate");
            decimal r1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter no of years");
            decimal n1 = Convert.ToDecimal(Console.ReadLine());

            Func<decimal, decimal, decimal, decimal> f = (p, r, n) => p * r * n / 100;
            Console.WriteLine(f(p1, r1, n1));
        }
        static void Main2()
        {
            //2. bool IsGreater(int a, int b) -> returns true if a is > b

            Console.WriteLine("Enter value");
            Console.WriteLine("Enter a");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b");
            int y = Convert.ToInt32(Console.ReadLine());
            Func<int, int, bool> p = (a, b) => a > b;

            Console.WriteLine(p(x, y));
        }
        static void Main3()
        {
            //3. decimal GetBasic(Employee e) -> returns the Basic salary of the employee

            Employee e1 = new Employee();

            Func<Employee, decimal> f = e => e.Pbasic;

            Console.WriteLine(f(e1));


        }
        static void Main4()
        {
            //5. bool IsGreaterThan10000(Employee e) -> returns true if the Basic Salary is > 10000

            Employee e1=new Employee();
            Console.WriteLine("Enter basic salary");
            decimal basic = Convert.ToDecimal(Console.ReadLine());
            e1.Pbasic = basic;
            
            Func<Employee, bool> f = e => e.Pbasic>10000;

            Console.WriteLine(f(e1));


        }

        static void Main()
        {
            //4. bool IsEven(int num) -> returns true if the number is an even number

            Func<int, bool> f = a => a % 2 == 0;
            Console.WriteLine("Enter no");
            int no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(f(no));
        }

    }
    public class Employee
    {
        private int empNo;
        private decimal basic;

        public Employee()
        {
            empNo = 0;
            basic = 20000;
        }
        public int PempNo
        {
            set { this.empNo = value; }
            get { return empNo; }
        }
        public decimal Pbasic
        {
            set { this.basic = value; }
            get { return basic; }
        }
    }



}