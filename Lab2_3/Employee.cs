public class Employee
{
    private string lastName;
    private string firstName;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }
    public double CalculateSalary(string position, int experience)
    {
        double basesalary = 0;

        switch (position)
        {
            case "director":
                basesalary = 2500.0;
                break;
            case "manager":
                basesalary = 2000.0;
                break;
            case "secretary":
                basesalary = 1500.0;
                break;
        }
        double experienceBonus = 0;
        if (experience > 10)
        { experienceBonus = 1500; }

        double salary = basesalary + experienceBonus;
        double tax = 0.3 * salary;
        return salary - tax;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"First Name: {lastName}");   
        Console.WriteLine($"last name: {firstName}");   
    }
}

