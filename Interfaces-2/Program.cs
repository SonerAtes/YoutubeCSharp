using System;

namespace Interfaces_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface New' lenemez.
            //IPersonManager personManager = new IPersonManager();

            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();

            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());
        }
    }
    interface IPersonManager
    {
        //Implemented Operation (Tamamlanmış Operasyon)
        public void Add();
        public void Update();
    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //Müşteri ekleme kodları yazılır.
            Console.WriteLine("Müşteri eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi.");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //Personel Ekleme Kodlar Buraya Yazılır.
            Console.WriteLine("Personel Eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi.");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Güncellendi.");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
