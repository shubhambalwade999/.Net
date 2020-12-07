namespace Assignment5Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] empArr = new Employee[5];
            for (int i = 0; i < empArr.Length; i++)
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

                empArr[i] = new Employee(empNo, empName, basic, deptNo);
            }
            List<Employee> objEmps = new List<Employee>(empArr);

            foreach (Employee e in objEmps)
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
