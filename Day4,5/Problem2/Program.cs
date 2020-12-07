using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Rows;
            int Cols;
            Console.WriteLine("Enter No  Of Batches:");
            Rows = Convert.ToInt32(Console.ReadLine());
            
            

            //Student Object's Array
            Student[][] arr = new Student[Rows][];
            for(int i=0; i<Rows; i++)
            {
                Console.WriteLine("Enter No of Students for batch {0}:",i+1);
                Cols = Convert.ToInt32(Console.ReadLine());
                arr[i] = new Student[Cols];
            }
            //Accept Student Details
            for (int i=0; i < Rows; i++)
            {
                for(int j=0; j < arr[i].Length; j++)
                {
                    string studentname;
                    decimal marks;
                    string batchname;
                    Console.WriteLine("Enter Name of student {0}:",j+1);
                    studentname = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter Marks of student {0}:",j+1);
                    marks = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Enter Batch Name for student {0}:",j+1);
                    batchname = Convert.ToString(Console.ReadLine());
                    arr[i][j] = new Student(studentname, marks,batchname);
                    Console.WriteLine();
                }

                for(int k=0;i<Rows;k++)
                {
                    for(int j=0;j<arr.Length;j++)
                    {
                        arr[k][j].DisplayDetails();
                    }
                    
                }
            }
            Console.ReadLine();
            
        }
    }

    //class Batch
    public class Batch
    {
        //fields
        private static int cnt;
        private int batchno;
        private string batchname;

        //param cntr with default args
        public Batch(string batchname="noName")
        {
            batchno = ++cnt;
            this.batchname = batchname;
        }
        
        //properties
        public int BatchNo
        {
            get { return batchno; }
        }
        
        public string BatchName
        {
            get
            {
                return batchname;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Invalid batchname");
                }
                else
                {
                    batchname = value;
                }
            }
        }
    }

    //class student
    public class Student:Batch
    {
        //fields
        private static int cnt;
        private int rollno;
        private string studentname;
        private decimal marks;

        //cntr with default param
        public Student(string studentname = "noName", decimal marks = 1234,string batchname="noName"):base(batchname)
        {
            rollno = ++cnt;
            this.studentname = studentname;
            this.marks = marks;
        }
        //method
        public void DisplayDetails()
        {
            Console.WriteLine("Student RollNo   :   {0}", RollNo);
            Console.WriteLine("Student Name     :   {0}", StudentName);
            Console.WriteLine("Batch No         :   {0}", BatchNo);
            Console.WriteLine("Batch Name       :   {0}", BatchName);
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

        public string StudentName
        {
            get
            {
                return studentname;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Invalid name");
                }
                else
                {
                    studentname = value;
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
