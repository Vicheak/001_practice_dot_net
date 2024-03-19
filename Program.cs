using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            //PascalCase
            //camelCase
            //snake_case
            //UPPERCASE 
            //lowercase

            //create an object from class Person
            //Person person = new Person(); //instance
            //person.SetName("James");

            ////string interpolation, string format
            //Console.WriteLine($"Person name : {person.name, 20}");
            //Console.WriteLine(string.Format("Person name : {0}", person.name));

            ////inference type
            //var phone = new Item();
            ////dot notation
            //phone.name = "iPhone 13 Pro Max";
            //phone.description = "Just Black, 256GB 6GB RAM";
            //phone.quantity = 2;
            //phone.price = 1359;
            //Console.WriteLine("== Item Information ==");
            ////using string format
            //Console.WriteLine(string.Format(" Name: {0}", phone.name));
            //Console.WriteLine(" Description: {0}", phone.description);
            //Console.WriteLine(" Quantity: {0}", phone.quantity);
            //Console.WriteLine(" Price: {0}", phone.price);

            ////behavior
            //Console.WriteLine($" Total Price : {phone.GetTotalPrice()}");
            //Console.WriteLine(" Total Price : {0:C}", phone.GetTotalPrice());

            //generics class
            List<Person> people = new List<Person>();
            var dara = new Person("dara", 23, "phnom penh");
            people.Add(dara);

            people.Add(new Person("thida", 25, "kandal")); 

            //iterate
            for(int i = 0; i < people.Count; i++) 
            {
                //using indexing to access element of the list
                Console.WriteLine(people[i].GetInfo()); 
            }
        }
    }

}
