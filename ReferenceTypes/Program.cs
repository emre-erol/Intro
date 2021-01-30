using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Emre";
            person2 = person1;
            person1.FirstName = "İrem";
            //Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Mert";
            customer.CreditCardNumber = "1234567890"    ;

            Employee employee = new Employee();
            employee.FirstName = "Kağan";
            Person person3 = customer;
            customer.FirstName = "Derin";

            //Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonerManager personerManager = new PersonerManager();
            personerManager.Add(employee);

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonerManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
