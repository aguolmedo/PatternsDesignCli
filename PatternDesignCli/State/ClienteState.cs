using PatternDesignCli.TemplateMethod;

namespace PatternDesignCli.State;

public class ClienteState : PatternStrategy
{
    public void ejecutarCliente()
    {

        var customer = new CustomerContext();

        var flag = true;
        while (flag)
        {
            Console.Clear();
            Console.WriteLine("-- Patron State --");
            Console.WriteLine($"Estado actual: {customer.GetState()}");
            Console.WriteLine($"Saldo: {customer.Residue}");
            Console.WriteLine("Opciones: ");
            Console.WriteLine("1 - Añadir Saldo");
            Console.WriteLine("2 - Comprar (Gastar saldo)");
            Console.WriteLine("3 - Salir");
            var op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1: 
                    Console.Clear();
                    Console.WriteLine("Cuanto Saldo agregar?: ");
                    var saldo = Convert.ToDecimal(Console.ReadLine());
                    customer.AñadirSaldo(saldo);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Cantidad a gastar?: ");
                    var gasto = Convert.ToDecimal(Console.ReadLine());
                    customer.Comprar(gasto);
                    break;
                case 3:
                    Console.Clear();
                    flag = false;
                    break;
            }
        }





        
        
        
    }
}