namespace PatternDesignCli.State;

public class StateDeudor : IState
{
    public void Comprar(CustomerContext customerContext, decimal amount)
    {
        Console.WriteLine("No se puede comprar siendo deudor");
    }

    public void AñadirSaldo(CustomerContext customerContext, decimal amount)
    {
        if (customerContext.Residue + amount < 0)
        {
        }
        else
        {
            customerContext.Residue += amount;
            customerContext.SetState(new StateNoDeudor());
        }
    }
}