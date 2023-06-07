namespace Dependency_Inversion_Principle
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }
    }

    // incorrect

    public class XmlLog
    {
        public bool Log(string value)
        {
            return true;
        }
    }
    public class Logger
    {
        private readonly XmlLog _xmlLog= new XmlLog();
        public void Log(string value)
        {
            _xmlLog.Log(value);
        }
    }

    // correct

    public interface ILogger
    {
        bool Log(string value);
    }

    public class XmlLogNew : ILogger
    {
        public bool Log(string value)
        {
            return true;
        }
    }

    public class LoggerNew
    {
        private readonly ILogger _logger;

        public LoggerNew(ILogger logger)
        {
            _logger = logger;
        }

        public void Log(string value)
        {
            _logger.Log(value);
        }
    }
}
