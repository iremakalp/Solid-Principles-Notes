namespace Dependency_Inversion_Principle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Dependency Inversion Principle
            // katmanli mimarilerde ust seviye moduller
            // alt seviyedeki modullere dogrudan bagimli olmamali

            // siniflar arasi bagimliliklar az olmalı
            // ozellikle ust siniflar alt siniflara bagimli olmamali
        }
    }

    // kotu kod

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

    // dogru kod
    // bir interface kullanilarak yazildiginda xml sinifina bagimli olmamis oluruz

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
