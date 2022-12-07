using System.Diagnostics;
using PatternDesignCli.TemplateMethod;

namespace PatternDesign.FactoryMethod;

public class ClienteFactoryMethod : PatternStrategy
{
    public void ejecutarCliente()
    {
        here:
        Console.WriteLine("Seleccione metodo de compra: ");
        Console.WriteLine("Recuerde que en internet hay un 10% de descuento!!");
        Console.WriteLine("1 - Internet");
        Console.WriteLine("2 - Store");

        var op = Convert.ToInt32(Console.ReadLine());
        ISaleFactory factory;
        
        
        switch (op)
        {
            case 1:
                factory = new InternetSaleFactory(10);
                break;
            case 2:
                factory = new StoreSaleFactory(10);
                break;
            default:
                return;
        }
        
        Console.WriteLine("Ingrese monto de la compra: ");
        var total = Convert.ToInt32(Console.ReadLine());
        
        var sale = factory.GetSale();
        
        sale.Sell(total);

        Console.WriteLine("Otra venta?: s/n");
        var otra = Convert.ToString(Console.ReadLine());
        if (otra != "s") return;
        goto here;
    }
}