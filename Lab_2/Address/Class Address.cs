namespace Lab_2;

class Address
{
    private string index;
    private string country;
    private string city;
    private string street;
    private string house;

    public string Index
    {
        get { return index; }
        set { index = value; }
    }

    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    public string House
    {
        get { return house; }
        set { house = value; }
    }
    public Address(string index, string country, string city, string street, string house)
    {
        Index = index;
        Country = country;
        City = city;
        Street = street;
        House = house;
    }
    public void Display()
    {
        Console.WriteLine("Post address:");
        Console.WriteLine($"Index - {index};");
        Console.WriteLine($"Country - {country};");
        Console.WriteLine($"City - {city};");
        Console.WriteLine($"Street - {street};");
        Console.WriteLine($"House - {house};");
    }
} 