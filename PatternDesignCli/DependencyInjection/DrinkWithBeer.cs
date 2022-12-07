namespace PatternDesignCli.DependencyInjection;

public class DrinkWithBeer
{
    private Beer _beer;
    private decimal _water;
    private decimal _sugar;


    public DrinkWithBeer(Beer beer, decimal water, decimal sugar)
    {
        _beer = beer;
        _water = water;
        _sugar = sugar;
    }

    public void build()
    {
        Console.WriteLine($"Prepararemos la bebida con : \n" +
                          $"Cerveza : {_beer.getName()} \n" +
                          $"Marca: {_beer.getBrand()} \n" +
                          $"Agua(ml): {_water} \n" +
                          $"Azucar(grs): {_sugar}");
    }
}