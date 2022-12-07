namespace PatternDesignCli.Singleton;

public class Log
{

    private static Log _instance;
    private string _path = "log.txt";


    public static Log Instance => _instance ?? new Log();

    private Log()
    {
        
    }

    public void Save(string message)
    {
        File.AppendAllText(_path, message + Environment.NewLine);
    }
}