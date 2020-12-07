using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter Size Of Array:");
            size = Convert.ToInt32(Console.ReadLine());

            //Student Object's Array
            Student[] arr = new Student[size];

            //Accept Student Details
            for (int i = 0; i < size; i++)
            {
                string name;
                decimal marks;
                Console.WriteLine("Enter Student Name:");
                name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter Student Marks:");
                marks = Convert.ToDecimal(Console.ReadLine());
                arr[i] = new Student(name, marks);
            }
            Console.WriteLine();
            foreach(Student item in arr)
            {
                Console.WriteLine("{0}  {1}  {2}",item.RollNo,item.Name,item.Marks);
            }
            Console.ReadLine();
        }
    }

    //struct student
    public struct Student
    {
        //fields
        private static int cnt;
        private int rollno;
        private string name;
        private decimal marks;

        //cntr with default param
        public Student(string name = "noName", decimal marks = 1234)
        {
            rollno = ++cnt;
            this.name = name;
            this.marks = marks;
        }
        //method
        public void DisplayDetails()
        {
            Console.WriteLine("Student RollNo   :   {0}", RollNo);
            Console.WriteLine("Student Name     :   {0}", Name);
            Console.WriteLine("Marks            :   {0}", Marks);
            Console.WriteLine();
        }

        //properties
        public int RollNo
        {
            get
            {
                return rollno;
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



        public decimal Marks
        {

            get
            {
                return marks;
            }

            set
            {
                if (value > 0 && value != null)
                {
                    marks = value;
                }
            }
        }

    }
}
