namespace Liskovs_Substitution_Principle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print("value");

            Console.WriteLine("************************");

            PrinterNew printerNew = new PrinterNew();
            printerNew.Print("value");
        }
    }

    // incorrect
    public abstract class BasePrinter
    {
        public abstract void Print(string value);
        public abstract void Scan(string value);
    }
    public class HpPrinter : BasePrinter
    {
        public override void Print(string value)
        {
            // .....
            Console.WriteLine("Hp Printer print ");
        }
        public override void Scan(string value)
        {
            throw new NotImplementedException();
        }
    }
    public class CanonPrinter : BasePrinter
    {
        public override void Print(string value)
        {
            // ....
            Console.WriteLine("Canon Printer print ");
        }
        public override void Scan(string value)
        {
            //...
            Console.WriteLine("Canon Printer scan ");
        }
    }
    public class Printer
    {
        readonly BasePrinter _canonPrinter = new CanonPrinter();
        readonly BasePrinter _hpPrinter = new HpPrinter();

        public void Print(string value)
        {
            _canonPrinter.Print(value);
            _canonPrinter.Scan(value);

            _hpPrinter.Print(value);
            _hpPrinter.Scan(value);
        }
    }

    // correct

    public abstract class BasePrinterNew
    {
        public abstract void Print(string value);
    }
    public interface IScan
    {
        void Scan(string value);
    }

    public class CanonPrinterNew : BasePrinterNew, IScan
    {
        public override void Print(string value)
        {
            Console.WriteLine("Canon Printer print ");
        }
        public void Scan(string value)
        {
            Console.WriteLine("Canon Printer scan ");
        }
    }
    public class HpPrinterNew : BasePrinterNew
    {
        public override void Print(string value)
        {
            Console.WriteLine("Hp Printer print ");
        }
    }
    public class PrinterNew
    {
        readonly BasePrinterNew _canonPrinter = new CanonPrinterNew();
        readonly CanonPrinterNew _canonScaner = new CanonPrinterNew();
        readonly BasePrinterNew _hpPrinter = new HpPrinterNew();

        public void Print(string value)
        {
            _canonPrinter.Print(value);
            _canonScaner.Scan(value);

            _hpPrinter.Print(value);


        }
    }
}

