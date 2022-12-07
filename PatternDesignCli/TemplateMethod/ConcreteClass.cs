namespace PatternDesignCli.TemplateMethod;

public class ConcreteClass : AbstractClass
{
    protected override void RequiredOperation1()
    {
        Console.WriteLine("Operacion requerida 1, metodo implementado en la clase concreta");
    }

    protected override void RequiredOperation2()
    {
        Console.WriteLine("Operacion requerida 2, metodo implementado en la clase concreta");
    }

    protected override void Hook2()
    {
        Console.WriteLine("Hook2 implementado en la clase concreta");
    }
}