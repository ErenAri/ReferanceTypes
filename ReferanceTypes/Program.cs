using System;

namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;

            //sayi2 = 100;
            //Console.WriteLine("Sayı 1 = " + sayi1);

            //int[] sayilar1 = new int[] { 1, 2, 3, };
            //int[] sayilar2 = new int[] { 10, 20, 30 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;

            //Console.WriteLine("Sayılar 1' in ilk elemanı = " + sayilar1[0]);

            Person Person1 = new Person();
            Person Person2 = new Person();
           
            Person1.FirstName = "Eren";
            Person1 = Person2;
            Person1.FirstName = "Engin";

            Console.WriteLine("müşteri ismi : " + Person1.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Ahmet";
            customer.CreditNumber = 5157557012462171;

            Employee employee = new Employee();

            Person Person3 = customer;
            customer.FirstName = "Salih";

            Console.WriteLine(((Customer)Person3).CreditNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
            

        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer:Person
        {
            public long CreditNumber { get; set; }
        }
        class Employee:Person
        {
            public int EmployeeId { get; set; }
        }

        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
