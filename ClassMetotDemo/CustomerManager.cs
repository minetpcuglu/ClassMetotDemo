using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager  // (Manager,Service,Data acces vsvs) Operasyon tutan sınıfda Operasyonlarımızı ( olay ) tanımladık 
    {

        //Ekleme silme seçme güncelleme işlemleri bir operasyondur. 

        public void Add(Customer customer) //ne ekleyecigimizi sormak için Add() içine parametre içinde değerin nereden alındıgı  yazılır ve kullanılır
        {
            Console.WriteLine(customer.Id + " Numaralı ID'ye sahip " + customer.Name + " isimli " + customer.LastName + " Soyadlı " + customer.City + " Şehrinden " + " Müşteri Eklendi ");
        }

        public void Delete(Customer customer)  //ne Sileceğimizi sormak için Delete() içine parametre içinde değerin nereden alındıgı  yazılır ve kullanılır
        {
            Console.WriteLine(customer.Id + " Numaralı ID'ye sahip " + customer.Name + " isimli " + customer.LastName + " Soyadlı " + customer.City + " Şehrinden " + " Müşteri Silindi "); 

        }
        public void CustomerList(Customer customer)
        {
            Console.WriteLine(customer.Id + " Numaralı ID'ye sahip " + customer.Name + " isimli " + customer.LastName + " Soyadlı " + customer.City + " Şehrinden " + " Müşteri Listelendi ");
        }
    }
        
    }
