namespace Interface_Segregation_Principle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Interface Segregation Principle
            // arayuzlerin ayrilmasi prensibi
            // sorumluluklarin hepsi bir arayuze toplamak yerine
            // ozellestirilmis arayuzler olusturmaliyiz


        }
    }

    // kotu kod

    public interface IBaseApi
    {
        void Put(int id);
        void Post(int id);
        void Get(int id);
        void Delete(int id);
    }

    public class News : IBaseApi
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public void Get(int id)
        {
            throw new NotImplementedException();
        }
        public void Post(int id)
        {
            throw new NotImplementedException();
        }
        public void Put(int id)
        {
            throw new NotImplementedException();
        }
    }
    public class Video:IBaseApi
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public void Get(int id)
        {
            throw new NotImplementedException();
        }
        public void Post(int id)
        {
            throw new NotImplementedException();
        }
        public void Put(int id)
        {
            throw new NotImplementedException();
        }
    }

    // sadece get yapacagimiz bir durum olursa IBaseApi isimizi gormez
    // bu durumlarin olmamasi icin Get metodu ayri interface olarak yazilir

    // dogru kod

    public interface IGet
    {
        void Get(int id);
    }
    public interface IBaseApiNew:IGet
    {
        void Put(int id);
        void Post(int id);
        void Delete(int id);
    }
    public class VideoNew : IBaseApiNew
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public void Get(int id)
        {
            throw new NotImplementedException();
        }
        public void Post(int id)
        {
            throw new NotImplementedException();
        }
        public void Put(int id)
        {
            throw new NotImplementedException();
        }
    }
    public class Notification : IGet
    {
        public void Get(int id)
        {
            throw new NotImplementedException();
        }
    }

    // boylelikle notification sadece get metodunu icerirken
    // video sinifi hepsini icerir

}
