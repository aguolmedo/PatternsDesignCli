using System.Diagnostics;

namespace PatternDesignCli.Builder;

public static class ClienteBuilder
{
    public static void ejecutarCliente()
    {
        
        Console.WriteLine("Seleccione que Auto desea crear: ");
        Console.WriteLine("1 - Manual");
        Console.WriteLine("2 - Automatico");
        var op = Convert.ToInt32(Console.ReadLine());
        Director director;
        switch (op)
        {
            case 1:
                var builderManual = new BuilderAutoManual();
                director = new Director(builderManual);
                director.construirManual("V8", 5, "manual");
                var autoManual = builderManual.GetProducto();
                autoManual.imprimirProducto();
                break;
            case 2:
                var builderAutoAutomatico = new BuilderAutoAutomatico();
                director = new Director(builderAutoAutomatico);
                director.construirAutomatico("V7", 3, "automatico");
                var autoAutomatico = builderAutoAutomatico.GetProducto();
                autoAutomatico.imprimirProducto();
                break;
            default:
                Console.WriteLine("No se seleeciono un producto valido");
                return;
        }
        
        

        

        


    }
}