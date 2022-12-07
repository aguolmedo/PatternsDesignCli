using System.Diagnostics;
using System.Globalization;
using PatternDesignCli.TemplateMethod;

namespace PatternDesignCli.Strategy;

public  class ClienteStrategy : PatternStrategy
{
    
    public  void ejecutarCliente()
    {
        here: 
        Console.Clear();
        Console.WriteLine("Seleccione el tipo de vehiculo");
        Console.WriteLine("1 - Auto");
        Console.WriteLine("2 - Moto");
        Console.WriteLine("3 - Camion");

        var vehiculo = Convert.ToInt32(Console.ReadLine());
        IVehiculosStrategy concreteVehiculosStrategy;
        
        switch (vehiculo)
        {
            case 1:
                concreteVehiculosStrategy = new CarVehiculosStrategy();
                break;
            case 2:
                concreteVehiculosStrategy = new MotoVehiculosStrategy();
                break;
            case 3:
                concreteVehiculosStrategy = new CamionVehiculosStrategy();
                break;
            default: 
                Console.WriteLine("No selecciono un vehiculo valido");
                return;
            
        }
        
        /*Creamos contexto, inyectandole por dependencia la estrategia concreta.
        Tambien se podria crear el contexto sin parametros, y despues asignarle la estraregia concreta mediante
        el metodo selectStrategy(IStrategy).
        */ 
        var strategyContext = new Context(concreteVehiculosStrategy);
        
        /* Metodo Polimorfico, en tiempo de compilacion el cliente solo sabe que debe ser un objeto que cumpla con la
        interfaz IStrategy, es en tiempo de ejecucion mediante la composicion de objetos que el cliente conoce que que
        estrategia concreta debe ejecutar el metodo.
         */
        strategyContext.Run();
        
        Console.WriteLine("Desea cambiar de vehiculo? s/n");
        var selectStrategy = Convert.ToString(Console.ReadLine());
        if (selectStrategy == "n") return;
        goto here;
    }
}