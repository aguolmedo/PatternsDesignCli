namespace PatternDesignCli.State;

public class StateNoDeudor : IState
{
    public void Comprar(CustomerContext customerContext, decimal amount)
    {
        if (customerContext.Residue - amount > -15)
        {
            customerContext.Discount(amount);
            Console.WriteLine($"Solicitud permitia, gasta {amount} \n" +
                              $"Saldo restante: {customerContext.Residue}");
            if (customerContext.Residue < 0)
            {
                customerContext.SetState(new StateDeudor());
            } 
            Console.WriteLine($"Estado actual: {customerContext.GetState()}");
        }
        else
        {
            Console.WriteLine($"Solicitud invalida \n" +
                              $"Monto requerido: {amount} \n" +
                              $"Saldo disponible: {customerContext.Residue} \n" +
                              $"El maximo saldo negativo disponible es -15");
            Console.WriteLine($"Estado actual: {customerContext.GetState()}");

        }
        
        
    }

    public void AñadirSaldo(CustomerContext customerContext, decimal amount)
    {
        customerContext.Residue += amount;
    }
}