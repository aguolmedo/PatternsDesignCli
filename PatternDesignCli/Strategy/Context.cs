namespace PatternDesignCli.Strategy;

public class Context
{
    private IVehiculosStrategy _strategiaConcreta;

    public Context(IVehiculosStrategy strategiaConcreta)
    {
        _strategiaConcreta = strategiaConcreta;
    }

    public void Run()
    {
        _strategiaConcreta.run();
    }

    public void SelectStrategy(IVehiculosStrategy strategiaConcreta)
    {
        _strategiaConcreta = strategiaConcreta;
    }
}