namespace Open_Closed_Principle
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
            // .....
            return true;
        }
    }

    public class DbLog
    {
        public bool Log(string value)
        {
            // .....
            return true;
        }
    }
    enum LogType
    {
        Xml,Db
    }

    class Logger
    {
        readonly XmlLog _xmlLog;
        readonly DbLog _dbLog;

        public Logger(XmlLog xmlLog, DbLog dbLog)
        {
            _xmlLog = xmlLog;
            _dbLog = dbLog;
        }
        public void Log(LogType type,string value) 
        {
            switch (type)
            {
                case LogType.Xml:
                    _xmlLog.Log(value);
                    break;
                case LogType.Db:
                    _dbLog.Log(value);
                    break;
                default:
                    break;
            }
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
    public class DbLogNew : ILogger
    {
        public bool Log(string value)
        {
            return true;
        }
    }
    public class JsonLog : ILogger
    {
        public bool Log(string value)
        {
            return true;
        }
    }
    public class NewLogger
    {
        readonly ILogger _logger;

        public NewLogger(ILogger logger)
        {
            _logger = logger;
        }
        public void Log(string value)
        {
            _logger.Log(value);
        }
    }
}
