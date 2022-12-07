namespace PatternDesignCli.DependencyInjection;

public class Beer
{
    private string _name;
    private string _brand;

    public Beer(string name, string brand)
    {
        _name = name;
        _brand = brand;
    }

    public string getName()
    {
        return _name;
    }

    public string getBrand()
    {
        return _brand;
    }
}