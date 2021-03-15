using System;

namespace YoutubeCSharp
{
    //CLASS lar içerilerinde metotları barındırır. Yani içerisindeki methotları gruplandırır.
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Uptade();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Soner";
            customer.LastName = "ATEŞ";
            customer.City = "ANTALYA";
            Console.WriteLine(customer.FirstName + " " + customer.LastName);

            //**Alttaki ile Üstteki arasında hiçbir fark yok iki şekilde de kullanılabilir.

            Customer customer2 = new Customer
            {
                Id = 2, FirstName="İlknur", LastName="ATEŞ", City="BURDUR"
            };
            Console.WriteLine(customer2.FirstName + " " + customer2.LastName);

            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added !");
        }

        public void Uptade()
        {
            Console.WriteLine("Customer Updated !");
        }
    }

    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added !");
        }
        public void Update()
        {
            Console.WriteLine("Product Updated !");
        }
    }
}
