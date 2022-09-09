// See https://aka.ms/new-console-template for more information
namespace Single_Responsibility_Principle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Single Responsibility 
            // Her sinifin veya metodun tek bir sorumlulugu olmali

            // " bir tek seyi yap ve onu en iyi yap ! "

            // kodlamaya baslamadan once sorulacak sorular
            // bu metod bu sinif icinde mi yer almali ?
            // bu gorevi yerine getirmek bu metodun veya sinifin isi mi?
        }
    }
    // kotu kod
    public class Customer
	{
         public void Add()
         {
            try
            {
                // veritabanina ekle
                Console.WriteLine("Customer Added");
            }
            catch (Exception ex)
            {

                // hatayi dosyaya logla
                System.IO.File.WriteAllText(@"c:\Hata.txt", ex.ToString());
            }
         }
	}

    // loglama islemi ve musteri ekleme birbirinden farkli islemlerdir
    // bu yuzden hata loglama kodlari ayri bir yerde yazilmalidir

    // dogru kod

    public class FileLog
    {
        public void Log(string exception)
        {
            System.IO.File.WriteAllText(@"c:\Hata.txt", exception.ToString());        
        }
    }
    public class NewCustomer
    {
        public void Add()
        {
            try
            {
                // veritabanina ekleme
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
