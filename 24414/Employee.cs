namespace _24414
{
    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double BasicSalary { get; set; }

        public Employee(string fName, string lName, double bSalary)
        {
            FirstName = fName;
            LastName = lName;
            BasicSalary = bSalary;
        }

        public void print()
        {
            Console.WriteLine("Name: " + FirstName+ " " + LastName + ", Salary: " + BasicSalary);
        }
    }
}
