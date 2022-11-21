using WebApiTest.Services.Interface;

namespace WebApiTest.Services.Service
{
    public class ConsoleLogWriter: ILogWriter
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
