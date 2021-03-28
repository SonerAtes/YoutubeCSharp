using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kalıtıma (Miras) Giriş
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="Soner" }, 
                new Student{FirstName="İbrahim"}, 
                new Person{FirstName="Salih"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
            
        }
    }
    //Person baba, Customer evlat gibi düşünebiliriz. Customer, Personun çocuğudur ve bir çocuğun birden fazla babası olamaz bu sebeple Person2 diye bir class oluşturmayız.
    //Classların tek başına bir anlamları vardır fakat interfacelerin tek başına bir anlamı yoktur.
    //Abstrak classlar bizim için bir inheritance dır.
    //Youtube Ders 46
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public string City { get; set; }
    }
    class Student:Person
    {
        public string Department { get; set; }
    }
}
