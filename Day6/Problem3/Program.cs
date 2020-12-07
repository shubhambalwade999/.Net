
namespace Assignment5Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> li = new List<Employee>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter EmpNo: ");
                int empNo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter EmpName: ");
                String empName = Console.ReadLine();
                Console.Write("Enter EmpBasic: ");
                decimal basic = decimal.Parse(Console.ReadLine());
                Console.Write("Enter DeptNo: ");
                short deptNo = short.Parse(Console.ReadLine());
                Console.WriteLine();

                li.Add(new Employee(empNo, empName, basic, deptNo));
            }

            Employee[] empArr = li.ToArray();
            foreach (Employee e in empArr)
            {
                Console.WriteLine("EmpNo: " + e.EmpNo);
                Console.WriteLine("EmpName: " + e.Name);
                Console.WriteLine("Salary: " + e.Basic);
                Console.WriteLine("DeptNo: " + e.DeptNo);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

    public class Employee
    {

        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public short DeptNo { get; set; }

        public Employee(int EmpNo = 0, string Name = "xyz", decimal Basic = 0, short DeptNo = 0)
        {
            this.EmpNo = EmpNo;
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }
    }
}