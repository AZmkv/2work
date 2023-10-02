
 class Converter
 {
     private double usd;
     private double eur;
     private double pln;

    public Converter(double usd, double eur, double pln)
    {
       this.usd = usd;
       this.eur = eur;
       this.pln = pln;
    }
    public double UAHtoUSD(double uahAmount)
    { return uahAmount / usd; }
    public double UAHtoEUR(double uahAmount)
    { return uahAmount / eur; }
    public double UAHtoPLN(double uahAmount)
    { return uahAmount / pln; }
    public double UStoUAH(double usdAmount)
    { return usdAmount / eur; }
    public double EURtoUAH(double eurAmount)
    { return eurAmount * eur; }
    public double PLNtoUAH(double plnAmount)
    { return plnAmount * pln; }
 } 