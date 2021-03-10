using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Customer clası kodları 

            Customer customer = new Customer();
            customer.City = "Kastamonu";
            customer.Id = 5;
            customer.Name = "Mine";
            customer.LastName = "Tek ";

            Customer customer1 = new Customer();
            customer1.Id = 10;
            customer1.LastName = "Kuz";
            customer1.Name = "Mine";
            customer1.City = "Ankara";

            Customer customer2 = new Customer();
            customer2.City = "Karabük";
            customer2.Id = 20;
            customer2.Name = "Emre";
            customer2.LastName = "İhsan";
         

            Customer[] customers = new Customer[] { customer, customer1, customer2 };

            //************CustomerManager kısmı kodları ***********
            Console.WriteLine("******* Metot kullanımı *********");

            CustomerManager customerManager = new CustomerManager(); //sınıfımızı kullanabilmek için nesne türetildi

            Console.WriteLine("************************");
            customerManager.Add(customer1);      //metot bu sekilde cagrılır ve   eklencek parametre Add() içine yazılarak cagrılır 
            
            Console.WriteLine("************************");
            customerManager.Delete(customer2);   //metot bu sekilde cagrılır ve silincek parametre Delete() içine yazılarak cagrılır
           
            Console.WriteLine("************************");
            customerManager.CustomerList(customer);  //metot bu sekilde cagrılır ve  listelenmesini istediğimiz parametre CustomerList() içine yazılarak cagrılır 


            Console.Read();
            
        }
    }
}
