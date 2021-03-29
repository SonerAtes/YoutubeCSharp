using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hem oracle a hem de sql e yazdırmak istersek aşağıdaki kodu kullanıyoruz.
            //Bir dataya elimizdeki bütün verileri göndermek için kullanıyoruz.
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new OracleCustomerDal());

            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Soner",
                LastName = "ATEŞ",
                Address = "ANTALYA"
            };

            Student student = new Student
            {
                Id = 2,
                FirstName = "Mürsel",
                LastName = "Akyıldız",
                Departmant = "Bilgi İşlem"
            };
            manager.Add(student);
            manager.Add(customer);
            Console.ReadLine();
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName + " " + person.LastName);
        }
    }
}