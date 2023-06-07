// See https://aka.ms/new-console-template for more information
namespace Single_Responsibility_Principle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Single Responsibility 
        }
    }
    // incorrect
    public class Customer
	{
         public void Add()
         {
            try
            {
                // add db
                Console.WriteLine("Customer Added");
            }
            catch (Exception ex)
            {

                // exception
                System.IO.File.WriteAllText(@"c:\exception.txt", ex.ToString());
            }
         }
	}

    // correct

    public class FileLog
    {
        public void Log(string exception)
        {
            System.IO.File.WriteAllText(@"c:\exception.txt", exception.ToString());        
        }
    }
    public class NewCustomer
    {
        public void Add()
        {
            try
            {
                // add db
                Console.WriteLine(" New Customer Added");
            }
            catch (Exception ex)
            {
                FileLog obj = new FileLog();
                obj.Log(ex.ToString());
            }
        }

    }
}
