namespace PatternDesignCli.State;

public class NewState : IState
{
    public void AñadirSaldo(CustomerContext customerContext, decimal amount)
    {
        customerContext.Residue = amount;
        customerContext.SetState(new StateNoDeudor());
        
    }

    public void Comprar(CustomerContext customerContext, decimal amount)
    {
        Console.WriteLine("Not implemented, un cliente inicial no deberia poder comprar ya que no posee saldo");
    }
}