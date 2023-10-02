class Program
{
    static void Main(string[] args)
    {
        DateTime registrationDate = DateTime.Now;
        User user = new User("user88", "Lesia", "Nikityk", 12, registrationDate);
        user.DisplayUserInfo();

        Console.ReadLine();
    }
}