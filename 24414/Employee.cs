namespace _24414
{
    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double BasicSalary { get; set; }

        public void show()
        {
            Console.WriteLine("Name: " + FirstName + LastName + " Salary: " + BasicSalary);
        }
    }
}
