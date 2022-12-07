namespace PatternDesignCli.Builder;

public class BuilderAutoAutomatico : IAutoBuilder 
{
    private AutoAutomatico _producto;

    public void SetSeats(int nroAsientos)
    {
        _producto.setSeats(nroAsientos);
    }

    public void SetMotor(string motor)
    { 
        _producto.setMotor(motor);
    }

    public void SetCajaDeCambios(string tipoCajaCambios)
    {
        _producto.setCajaDeCambios(tipoCajaCambios);
    }

    public AutoAutomatico GetProducto()
    {
        return _producto;
    }
}