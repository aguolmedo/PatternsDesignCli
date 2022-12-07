namespace PatternDesign.FactoryMethod;

public class InternetSaleFactory : ISaleFactory
{
    private int _discount;

    public InternetSaleFactory(int discount)
    {
        _discount = discount;
    }

    public InternetSaleFactory()
    {
        throw new NotImplementedException();
    }

    public ISale GetSale()
    {
        return new InternetSale(_discount);
    }
}