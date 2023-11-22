namespace Business.CCS;

public class DatabaseLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("It has been logged to database");
    }
}