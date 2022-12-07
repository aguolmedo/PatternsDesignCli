namespace PatternDesignCli.Builder;

public class BuilderAutoManual : IAutoBuilder 
{
    private AutoManual _producto;

    public BuilderAutoManual()
    {
        _producto = new AutoManual();
    }

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

    public AutoManual GetProducto()
    {
        return _producto;
    }
}

