class User
{
    private string login;
    private string firstName;
    private string lastName;
    private int age;
    private DateTime registrstionDate;
    public User(string login, string firstName,string lastName, int age, DateTime registrationDate)
    {
      this.login = login;
      this.firstName = firstName;
      this.lastName = lastName;
      this.age = age;
      this.registrstionDate = registrationDate;
    }
    public void DisplayUserInfo()
    {
        Console.WriteLine($"Login; {login}");
        Console.WriteLine($"Name: {firstName}");
        Console.WriteLine($"Surname: {lastName}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Registrstion date: {registrstionDate}");
    }
}