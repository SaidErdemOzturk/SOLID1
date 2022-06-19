using System;

namespace SOLIDCalisma2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CustomerManager customerManager = new CustomerManager(new SqlDatabase());
            
        }
    }

    interface IInterface
    {

    }
    class CustomerManager
    {
        private ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public void Add()
        {
            _customerDal.Ekle();
        }
    }
    interface ICustomerDal
    {
        void Ekle();
        void Sil();
        void Guncelle();
    }

    class SqlDatabase : ICustomerDal
    {
        public void Ekle()
        {
            Console.WriteLine("Sql Veritabanına eklendi");
        }

        public void Guncelle()
        {
            throw new NotImplementedException();
        }

        public void Sil()
        {
            throw new NotImplementedException();
        }
    }
    class MSSql : ICustomerDal
    {
        public void Ekle()
        {
            Console.WriteLine("Sql Veritabanına eklendi");
        }

        public void Guncelle()
        {
            throw new NotImplementedException();
        }

        public void Sil()
        {
            throw new NotImplementedException();
        }
    }
}
