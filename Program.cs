using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company 
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee o1 = new Employee("Amol", 123465, 10);
            Employee o2 = new Employee("Amol", 123465);
            Employee o3 = new Employee("Amol");
            Employee o4 = new Employee();
            
            Console.WriteLine(o1.EmpNo + " " + o1.Name + " " + o1.Basic + " " + o1.DeptNo);
            Console.WriteLine(o2.EmpNo + " " + o2.Name + " " + o2.Basic + " " + o2.DeptNo);
            Console.WriteLine(o3.EmpNo + " " + o3.Name + " " + o3.Basic + " " + o3.DeptNo);
            Console.WriteLine(o4.EmpNo + " " + o4.Name + " " + o4.Basic + " " + o4.DeptNo);

            Console.WriteLine("================================================================");

            o1.Name = " ";
            o1.DeptNo = 0;
            o1.DeptNo = 11;
            o1.Basic = 9999;
            o1.Basic = 21000;

            Console.WriteLine("================================================================");

            Console.WriteLine(o1.GetNetSalary());

            Console.WriteLine("================================================================");

            /*
             Test Cases
            Employee o1 = new Employee();
            Employee o2 = new Employee();
            Employee o3 = new Employee();
            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);

            Console.WriteLine("================================================================");

            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);
            */
            Console.ReadLine();
        }
    }

    class Employee
    {
        private static int count;
        private string name;
        private int empno;
        private decimal basic;
        private short deptno;

        public Employee(string name = null, decimal basic = 0, short deptno = 0)
        {
            empno = ++count;
            this.name = name;
            this.basic = basic;
            this.deptno = deptno;
        }

        public decimal GetNetSalary()
        {
            return basic - basic * 5 / 100;
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

        public int EmpNo
        {
            get
            {
                return empno;
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
                if(value >= 10000 && value <=20000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Invalid basic");
                }
            }
        }
        public short DeptNo
        {
            get
            {
                return deptno;
            }
            set
            {
                if (value > 0 && value <= 10)
                {
                    deptno = value;
                }
                else
                {
                   Console.WriteLine("Invalid deptno");
                }
            }
        }

    }

}
