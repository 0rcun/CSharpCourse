using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id=1,FirstName="Orcun",LastName="Demir",City="Isparta"};

            Customer customer2 = new Customer(2,"Sıla","Güven","Aydın");

            Customer customer3 = new Customer();
            customer3.Id = 3;

            Console.ReadLine();
        }
    }

    class Customer
    {
        // default constructor
        public Customer()
        {
            
        }
        public Customer(int id, string firstname, string lastname,string city)
        {
            FirstName=firstname;
            LastName=lastname;
            Id=id;
            City=city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
