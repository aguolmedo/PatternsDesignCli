namespace PatternDesign.FactoryMethod;

public class StoreSale : ISale
{

    private decimal _extra;

    public StoreSale(decimal extra)
    {
        _extra = extra;
    }
    
    public void Sell(decimal total)
    {
        Console.WriteLine($"La venta en TIENDA tiene un total de  {total + total * _extra/100}");
    }
}