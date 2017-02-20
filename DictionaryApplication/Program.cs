using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Customr Customer1 = new Customr();
            Customer1.ID = 119;
            Customer1.Name = "Rohan";
            Customer1.Salary = 5000;

            Customr Customer2 = new Customr();
            Customer2.ID = 120;
            Customer2.Name = "Ram";
            Customer2.Salary = 6000;

            Customr Customer3 = new Customr();
            Customer3.ID = 121;
            Customer3.Name = "Ravi";
            Customer3.Salary = 7000;

            Dictionary<int, Customr> dictionarycustomer = new Dictionary<int, Customr>();
            dictionarycustomer.Add(Customer1.ID, Customer1);
            dictionarycustomer.Add(Customer2.ID, Customer2);
            dictionarycustomer.Add(Customer3.ID, Customer3);

            //Customr customer119 = dictionarycustomer[119];
             //Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer119.ID, customer119.Name, customer119.Salary);
            foreach(KeyValuePair<int, Customr> CustomerKeyValuePair in dictionarycustomer)
            {
                Console.WriteLine("Key={0}", CustomerKeyValuePair.Key);
                Customr cust = CustomerKeyValuePair.Value;
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
                Console.WriteLine("---------------------------------------");
                Console.ReadLine();
            }
            
        }
    }
    public class Customr
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
