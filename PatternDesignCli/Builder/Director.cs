using System.Runtime.CompilerServices;

namespace PatternDesignCli.Builder;

public class Director
{
    private IAutoBuilder _builder;

    public Director(IAutoBuilder builderConcreto)
    {
        _builder = builderConcreto;
    }

    public void construirAutomatico(string motor, int asientos, string tipoCajaDeCambios)
    {
        _builder.SetMotor(motor);
        _builder.SetSeats(asientos);
        _builder.SetCajaDeCambios(tipoCajaDeCambios);

    }

    public void construirManual(string motor, int asientos,string tipoCajaDeCambios)
    {
        _builder.SetMotor(motor);
        _builder.SetCajaDeCambios(tipoCajaDeCambios);
        _builder.SetSeats(asientos);
    }

}