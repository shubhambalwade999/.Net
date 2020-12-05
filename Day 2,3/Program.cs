using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            CEO o = new CEO("shubham",3,80000);

            Console.WriteLine("EmpNo    :   " + o.EmpNo);
            Console.WriteLine("Name     :   " + o.Name);
            Console.WriteLine("DeptNo   :   " + o.DeptNo);
            Console.WriteLine("Basic    :   " + o.Basic);
            o.Insert();
            o.Update();
            o.Delete();
            Console.WriteLine();

            GeneralManager o1 = new GeneralManager("perks","GM","akshay",4);

            Console.WriteLine("Perks        :   " + o1.Perks);
            Console.WriteLine("Designation  :   " + o1.Designation);
            Console.WriteLine("EmpNo        :   " + o1.EmpNo);
            Console.WriteLine("Name         :   " + o1.Name);
            Console.WriteLine("DeptNo       :   " + o1.DeptNo);
            Console.WriteLine("Basic        :   " + o1.Basic);
            o1.Insert();
            o1.Update();
            o1.Delete();
      
            Console.WriteLine();

            Manager o2 = new Manager();
          
            Console.WriteLine("Designation  :   " + o2.Designation);
            Console.WriteLine("EmpNo        :   " + o2.EmpNo);
            Console.WriteLine("Name         :   " + o2.Name);
            Console.WriteLine("DeptNo       :   " + o2.DeptNo);
            Console.WriteLine("Basic        :   " + o2.Basic);
            o2.Insert();
            o2.Update();
            o2.Delete();
           
            Console.ReadLine();
        }
    }
    //Interface
    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }
    //class
    public abstract class Employee:IDbFunctions
    {
        //fields
        private static int cnt;
        private int empno;
        private string name;
        private short deptno;
        protected decimal basic;

        //abstract method CalcNetSalary
        public abstract decimal CalcNetSalary();

        public void Insert()
        {
            Console.WriteLine("eClass1 - IDb.Insert");
        }

        public void Update()
        {
            Console.WriteLine("eClass1 - IDb.Update");
        }

        public void Delete()
        {
            Console.WriteLine("eClass1 - IDb.Delete");
        }

        //contr. with default args.
        public Employee(string name = "noName", short deptno = 0, decimal basic = 1000)
        {
            this.empno = ++cnt;
            this.name = name;
            this.deptno = deptno;
            this.basic = basic;
        }

        //Properties
        //readonly property
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

        public short DeptNo
        {
            get
            {
                return deptno;
            }
            set
            {
                if (deptno > 0 && deptno <= 10)
                    deptno = value;
                else
                    Console.WriteLine("Invalid DeptNo");
            }
        }

        public abstract decimal Basic
        {
            get;

            set;

        }

    }

    //class Manager : Employee 
    class Manager : Employee,IDbFunctions
    {
        //fields
        private string designation;

        //param. cntr with default args
        public Manager(string designation = "Manager", string name = "noName", short deptno = 1, decimal basic = 21000) : base(name, deptno, basic)
        {
            this.designation = designation;
        }

        //overriden method from Employee class
        public override decimal CalcNetSalary()
        {
            return this.basic - this.basic * 5 / 100;
        }

        public new void Insert()
        {
           Console.WriteLine("mClass1 - IDb.Insert");
        }

        public  new void Update()
        {
            Console.WriteLine("mClass1 - IDb.Update");
        }

        public new void Delete()
        {
            Console.WriteLine("mClass1 - IDb.Delete");
        }

        //overriden property from Employee class
        public override decimal Basic
        {

            get
            {
                return this.basic;
            }

            set
            {
                if (basic > 20000 && basic <= 40000)
                {
                    basic = value;
                }
            }
        }

        public  string Designation
        {

            get
            {
                return this.designation;
            }

            set
            {
                    this.designation = value;

            }
        }

    }

    //class GeneralManager : Manager
    class GeneralManager : Manager,IDbFunctions
    {
        //fields
        private string perks;

        //param. cntr with default args
        public GeneralManager(string perks = "none", string designation = "GeneralManager", string name = "noName", short deptno = 2, decimal basic = 41000) : base(designation, name, deptno, basic)
        {
            this.perks = perks;
        }

        //overriden method from Manager class
        public override decimal CalcNetSalary()
        {
            return this.basic - this.basic * 5 / 100;
        }

        public new void Insert()
        {
            Console.WriteLine("gmClass1 - IDb.Insert");
        }

        public new void Update()
        {
            Console.WriteLine("gmClass1 - IDb.Update");
        }

        public new void Delete()
        {
            Console.WriteLine("gmClass1 - IDb.Delete");
        }

        //overriden property from Manager class
        public override decimal Basic
        {

            get
            {
                return this.basic;
            }

            set
            {
                if (basic > 40000 && basic <= 60000)
                {
                    this.basic = value;
                }
            }
        }

        public string Perks
        {

            get
            {
                return this.perks;
            }

            set
            {
                this.perks = value;
            }
        }

    }

    //CEO : Employee
    public class CEO : Employee,IDbFunctions
    {
        public CEO(string name = "noName", short deptno = 3, decimal basic = 61000):base(name,deptno,basic)
        {
           // Console.WriteLine("CEO cntr called");
        }

        //overriden method from Employee class
        public override decimal CalcNetSalary()
        {
            return this.basic - this.basic * 5 / 100;
        }

        public new void Insert()
        {
            Console.WriteLine("ceoClass1 - IDb.Insert");
        }

        public  new void Update()
        {
            Console.WriteLine("ceoClass1 - IDb.Update");
        }

        public new  void Delete()
        {
            Console.WriteLine("ceoClass1 - IDb.Delete");
        }

        //overriden property from Employee class
        public override decimal Basic {
            get
            {
                return basic;
            } 
            set
            {
                if(basic >60000 && basic <= 100000)
                {
                    this.basic = value;
                }
            }
        }
        
    }



}
