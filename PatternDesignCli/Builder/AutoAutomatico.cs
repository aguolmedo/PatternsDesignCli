namespace PatternDesignCli.Builder;

public class AutoAutomatico
{
    private string _name = "AutoAutomatico";

    private string _motor;

    private int _asientos;
    
    private string _cajaDeCambios;


    public void imprimirProducto()
    {
        Console.WriteLine(_name);
        Console.WriteLine(_motor);
        Console.WriteLine(_asientos);
    }
    
    public void setSeats(int nroAsientos)
    {
        _asientos = nroAsientos;
    }

    public void setMotor(string motor)
    {
        _motor = motor;
    }
    
    public void setCajaDeCambios(string tipoCajaCambios)
    {
        _cajaDeCambios = tipoCajaCambios;
    }
}