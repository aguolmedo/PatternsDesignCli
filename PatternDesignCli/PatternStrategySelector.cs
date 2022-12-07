using PatternDesign.FactoryMethod;
using PatternDesignCli.Builder;
using PatternDesignCli.State;
using PatternDesignCli.Strategy;

namespace PatternDesignCli.TemplateMethod;

public  class PatternStrategySelector
{
    public static PatternStrategy selectPatternStrategy(PatternStrategy concreteStrategy)
    {
        var type = concreteStrategy.GetType();

        if (type == typeof(ClienteBuilder)) return new ClienteBuilder();
        
        if (type == typeof(ClienteState)) return new ClienteState();
        
        if (type == typeof(ClienteFactoryMethod)) return new ClienteFactoryMethod();
        
        if (type == typeof(ClienteStrategy)) return new ClienteStrategy();
        
        if (type == typeof(ClienteTemplateMethod)) return new ClienteTemplateMethod();

        return new EmptyStrategy();
    }
}

public class EmptyStrategy : PatternStrategy
{
    public void ejecutarCliente() {}
}
    