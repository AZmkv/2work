class Program
{
    static void Main(string[] args)
    {
        Converter converter = new Converter(28.0, 34.0, 7.5);

        double uahAmount = 1000.0;
        double usdEquivalent = converter.UAHtoUSD(uahAmount);
        Console.WriteLine($"{uahAmount} UAH = {usdEquivalent} USD");

        double usdAmount = 50.0;
        double uahEquivalent = converter.UStoUAH(usdAmount);
        Console.WriteLine($"{usdAmount} USD = {uahEquivalent} UAH");


        double uahAmountToEUR = 1000;
        double eurEquivalent = converter.UAHtoEUR(uahAmountToEUR);
        Console.WriteLine($"{uahAmountToEUR} UAH = {eurEquivalent} EUR");

        double eurAmountToUAH = 50.0;
        double uahEquivalentFromEUR = converter.EURtoUAH(eurAmountToUAH);
        Console.WriteLine($"{eurAmountToUAH} EUR = {uahEquivalentFromEUR} UAH");

        double uahAmountToPLN = 2000.0;
        double plnEquivalent = converter.UAHtoPLN(uahAmountToPLN);
        Console.WriteLine($"{uahAmountToPLN} UAH = {plnEquivalent} PLN");

        double plnAmountToUAH = 75.0;
        double uahEquivalentFromPLN = converter.PLNtoUAH(plnAmountToUAH);
        Console.WriteLine($"{plnAmountToUAH} PLN = {uahEquivalentFromPLN} UAH");

        Console.ReadLine();
    }
}