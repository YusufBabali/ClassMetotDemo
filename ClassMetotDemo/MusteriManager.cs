using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri1)
        {
            Console.WriteLine("Musteri sisteme eklendi");
            Console.WriteLine("Musteri ismi: " + musteri1.Name);
            Console.WriteLine("Musteri maasi: " + musteri1.Salary);
            Console.WriteLine("Musteri Id: " + musteri1.ID);
        }

        public void List(Musteri musteri1)
        {           
           
                Console.WriteLine("Musteri listeye eklendi");
                Console.WriteLine("Musteri ismi: " + musteri1.Name);
                Console.WriteLine("Musteri maasi: " + musteri1.Salary);
                Console.WriteLine("Musteri Id: " + musteri1.ID);
            
                
               
        }
        public void Delete(Musteri musteri1)
        {
            Console.WriteLine(musteri1 + " Sistemden silinmistir.");
        }
    }
}
