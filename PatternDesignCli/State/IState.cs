using PatternDesignCli.Strategy;

namespace PatternDesignCli.State;

public interface IState
{
    public void Comprar(CustomerContext customerContext, decimal amount);
    public void AñadirSaldo(CustomerContext customerContext, decimal amount);
}