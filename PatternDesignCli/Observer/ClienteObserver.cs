
using PatternDesignCli;
public class ClienteObserver : PatternStrategy {


    public void ejecutarCliente()
    {
        // Parte de creacion del pedido, puedes crear un pedido nuevo, y pide seleccionar como quiere que se le avise
        // De esta manera tmb se crean los observadores concretos (notificaciones)

        Console.WriteLine("Ingrese que es lo que desea pedir: ");
        var nombePedido = Console.ReadLine();
        var pedido = new Pedido(nombePedido);
        ISubscriptor notificacion;

        here:
        Console.WriteLine("Seleccione por donde quiere que le avisemos cuando su pedido este listo");
        Console.WriteLine("1 - Mail");
        Console.WriteLine("2 - SMS");
        Console.WriteLine("3 - Whatsapp");
        var op = Convert.ToInt32(Console.ReadLine());
        switch(op) {
            case 1: notificacion = new NotficacionSMS(pedido.name,)
        }
        Console.WriteLine("Desea que le avisemos por algun medio mas? (no repitas) s/n");
        var seguir = Console.ReadLine();
        if (seguir == "s") goto here;
        

        Console.WriteLine("Preparando pedido");
        Thread.Sleep(10 * 1000);
        pedido.estaListo = true;


        if (pedido.estaListo) {
        
            var notficaciones = new GestorNotificaciones();
        


            notficaciones.


        }


    }
}