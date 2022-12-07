namespace PatternDesignCli.State;

public class CustomerContext
{
    private IState _state;
    
    public CustomerContext(IState initialState)
    {
        _state = initialState;
    }

    public CustomerContext()
    {
        _state = new NewState();
    }

    public decimal Residue { get; set; }
    
    public void SetState(IState state) => _state = state;

    public IState GetState() => _state;

    //Metodo delegado, delega la accion al estado concreto.
    public void Comprar(decimal amount) => _state.Comprar(this,amount);

    public void AñadirSaldo(decimal amount) => _state.AñadirSaldo(this, amount);
    
    public void Discount(decimal amount) => Residue -= amount;
}