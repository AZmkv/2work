class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("Nikityk", "Lesia");
        employee.DisplayInfo();
        double salary = employee.CalculateSalary("Director", 12);
        Console.WriteLine($"Salary: {salary} usd");
        
        Console.ReadLine();
    }
}