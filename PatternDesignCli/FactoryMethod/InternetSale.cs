namespace PatternDesign.FactoryMethod;

public class InternetSale : ISale
{
    private int _discount;
    
    public InternetSale(int discount)
    {
        _discount = discount;
    }
    
    public void Sell(decimal total)
    {
        Console.WriteLine($"La venta en INTERNET tiene un total de  { total - total * _discount/100 }");
    }
}