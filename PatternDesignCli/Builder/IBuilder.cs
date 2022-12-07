namespace PatternDesignCli.Builder;

public interface IAutoBuilder
{
    public void SetSeats(int nroAsientos);
    public void SetMotor(string motor);
    public void SetCajaDeCambios(string tipoCajaCambios);

}