// See https://aka.ms/new-console-template for more information


using System.Globalization;
using PatternDesign.FactoryMethod;
using PatternDesignCli.Builder;
using PatternDesignCli.State;
using PatternDesignCli.Strategy;
using PatternDesignCli.TemplateMethod;

PatternStrategy patternStrategy = null;
here:
Console.Clear();
Console.WriteLine("--Pattern Design Cli --");
Console.WriteLine("1 - Builder");
Console.WriteLine("2 - Factory Method");
Console.WriteLine("3 - State");
Console.WriteLine("4 - Strategy");
Console.WriteLine("5 - Template Method");
Console.WriteLine("Select one: ");
var op = Convert.ToInt32(Console.ReadLine());

switch (op)
{
    case 1:
        patternStrategy = PatternStrategySelector.selectPatternStrategy(new ClienteBuilder());
        break;
    case 2: 
        patternStrategy = PatternStrategySelector.selectPatternStrategy(new ClienteFactoryMethod());
        break;
    case 3: 
        patternStrategy = PatternStrategySelector.selectPatternStrategy(new ClienteState());
        break;
    case 4: 
        patternStrategy = PatternStrategySelector.selectPatternStrategy(new ClienteStrategy());
        break;
    case 5: 
        patternStrategy = PatternStrategySelector.selectPatternStrategy(new ClienteTemplateMethod());
        break;
    default:
        goto here;
        
}


if (patternStrategy is not null)
{
    patternStrategy.ejecutarCliente();
    Console.WriteLine("Ejecucion de patron terminada, desea volver al menú principal? s/n");
    var continuar = Console.ReadLine();
    if (continuar == "s") goto here;
}

