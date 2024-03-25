namespace _24414
{
    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double BasicSalary { get; set; }

        public Employee(string firstName, string lastName, double basicSalary)
        {
            FirstName = firstName;
            LastName = lastName;
            BasicSalary = basicSalary;
        }

        public void show()
        {
            Console.WriteLine("Name: " + FirstName+ " " + LastName + ", Salary: " + BasicSalary);
        }
    }
}
