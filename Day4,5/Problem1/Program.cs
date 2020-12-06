using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter Size Of Array:");
            size = Convert.ToInt32(Console.ReadLine());

            //Employee Object's Array
            Employee[] arr = new Employee[size];

            //Accept Employee Details
                for (int i = 0; i < size; i++)
                {
                    string name;
                    decimal basic;
                    Console.WriteLine("Enter Employee Name:");
                    name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter Employee Basic:");
                    basic = Convert.ToDecimal(Console.ReadLine());
                    arr[i] = new Employee(name, basic);
                }
                 Console.WriteLine();
            //search highest salary
                decimal d = 0;
                foreach(Employee item in arr)
                {
                    if(d < item.Basic)
                    {
                        d = item.Basic;
                    }
                       
                }
                //Employee with Highest Salary
                Console.WriteLine("Employee With Highest Salary");
                foreach(Employee item in arr)
                {
                    if (d == item.Basic)
                        item.DisplayDetails();
                }
                Console.WriteLine();

                //display  desired Employee details
                Console.WriteLine("Enter Employee No to search:");
                int x = Convert.ToInt32(Console.ReadLine());
                foreach(Employee item in arr)
                {
                    if (x == item.EmpNo)
                        item.DisplayDetails();
                }

                Console.ReadLine();
            }
        }

    //class Employee
    public class Employee
    {
        //fields
        private static int cnt;
        private int empno;
        private string name;
        private decimal basic;

        //cntr with default param
        public Employee(string name="noName",decimal basic=1234)
        {
            empno = ++cnt;
            this.name = name;
            this.basic = basic;
        }
        //method
        public void DisplayDetails()
        {
            Console.WriteLine("Emploee No   :   {0}", EmpNo);
            Console.WriteLine("Emploee Name :   {0}", Name);
            Console.WriteLine("Basic        :   {0}", Basic);
            Console.WriteLine();
        }

        //properties
        public int EmpNo
        {
            get
            {
                return empno;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Invalid name");
                }
                else
                {
                    name = value;
                }
            }
        }

 

        public decimal Basic
        {

            get
            {
                return basic;
            }

            set
            {
                if (value > 0 && value != null)
                {
                    basic = value;
                }
            }
        }

    }
}

