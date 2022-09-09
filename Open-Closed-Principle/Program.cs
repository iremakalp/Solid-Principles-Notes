namespace Open_Closed_Principle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Open-Closed-Principle
            // siniflar degisiklige kapali ancak gelisime acik olmalidir
            // bir sinif davranisini degistirmemeli, yeni ozellikler kazanabilmeli

        }
    }

    // kotu kod

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

    // bu sekilde yazdigimizde yeni bir loglama formati eklenirse
    // ornegin json formatinda LogType icerisine yeni bir type eklememiz gerekir
    // ardindan Logger icerisinde degistirmemiz gerekir
    // baska bir format gelirse ayni islemleri onun icinde yapmaliyiz
    // bu sekilde yapmak prensibe aykiridir

    // dogru kod


    // ILogger interface olusturduk ve tum loglama siniflari ILoggerdan implemente edildi
    // artik yeni bir loglama formati eklense bile Logger sinifini degistirmemize gerek kalmaz

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
