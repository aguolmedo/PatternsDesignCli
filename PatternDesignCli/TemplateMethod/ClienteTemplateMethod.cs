namespace PatternDesignCli.TemplateMethod;

public class ClienteTemplateMethod : PatternStrategy
{
    public void ejecutarCliente() { 

       var concreteClassInstance = new ConcreteClass();
       
       concreteClassInstance.TemplateMethod();
    
    }    
}