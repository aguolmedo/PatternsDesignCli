namespace PatternDesignCli.TemplateMethod;

public abstract class AbstractClass
{
    
    public void TemplateMethod()
    {
        BaseOperation1();
        RequiredOperation1();
        BaseOperation2();
        RequiredOperation2();
        Hook();
        BaseOperation3();
        Hook2();
    }

    
    /*  BASE OPERATIONS
     *  Estas operaciones poseen implementacion default
     *  En el caso de C# no se puede hacer override a un metodo si este no es declarado virtual (hooks) o abstract (requiredMethods).
     *  En esta implementacion no los declaré virtual entonces no podrian sobreescribirse. A fines del comportamiento del patron, esto depende
     *  de cada uno.
     */
    private void BaseOperation1()
    {
        Console.WriteLine("Ejecutando Operacion Base 1, esta es la implementacion por defecto del metodo.");
    }
    private void BaseOperation2()
    {
        Console.WriteLine("Ejecutando Operacion Base 2, esta es la implementacion por defecto del metodo.");
    }
    
    private void BaseOperation3()
    {
        Console.WriteLine("Ejecutando Operacion Base 3, esta es la implementacion por defecto del metodo.");
    }

    /*  REQUIRED OPERATIONS
     *  Estas operaciones forzosamente deben implementarse en las clases concretas
     *  No poseen implementacion default
     */
    protected abstract void RequiredOperation1();
    protected abstract void RequiredOperation2();
    
    /*  HOOKS
     *  Estas operaciones pueden implementarse (override) en las clases concretas, pero no es obligatorio
     *  ya que poseen una implementacion default (vacía).
     *  Los Hooks aportan una extension de comportamiento en partes clave del algoritmo.
     */
    protected virtual void Hook() {}
    protected virtual void Hook2() {}

    

   

   

   
}