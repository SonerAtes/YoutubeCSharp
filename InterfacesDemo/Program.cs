using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ÇOKLU İMPLEMENTASYON
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager(),
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }

        }
    }
    interface IWorker
    {
        void Work();
    }
    //SOLID, Interface Segregation
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Çalışanlar Yemek Yesin");
        }

        public void GetSalary()
        {
            Console.WriteLine("Çalışan Ücretleri");
        }

        public void Work()
        {
            Console.WriteLine("İşçiler Çalışın");
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("İşçiler Yemek Saati");
        }

        public void GetSalary()
        {
            Console.WriteLine("Maaş Zamanı");
        }

        public void Work()
        {
            Console.WriteLine("Çalışma Zamanı");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Makineler İçin Çalışma Zamanı");
        }
    }
}
