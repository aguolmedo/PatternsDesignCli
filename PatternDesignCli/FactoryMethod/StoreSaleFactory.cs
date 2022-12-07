namespace PatternDesign.FactoryMethod;

public class StoreSaleFactory : ISaleFactory
{

    private decimal _extra;

    public StoreSaleFactory(decimal extra)
    {
        _extra = extra;
    }

    public ISale GetSale()
    {
        return new StoreSale(_extra);
    }
}