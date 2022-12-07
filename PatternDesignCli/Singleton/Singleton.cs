namespace PatternDesignCli.Singleton;

public  class Singleton
{
    private static Singleton _instance;

    public static Singleton GetInstance()
    {
        return _instance ?? (_instance = new Singleton());
    }

    private protected Singleton()
    {
        
    }


}