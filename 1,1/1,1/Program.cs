using System;
namespace _1_1
{

    class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
        public string Index { get; set; }

    }
    class Program
    {
        static void Main()
        {
          Address address = new Address();
            address.Index = "07455";
            address.Country = "Ukraine";
           address.City = "Kniajichi";
            address.Street = "Lagunovoi";
            address.House = "315";
            address.Apartment = "1A";
            
                       Console.WriteLine(address.Country);
            Console.WriteLine(address.City);
            Console.WriteLine(address.Street);
            Console.WriteLine(address.House);
            Console.WriteLine(address.Apartment);
            Console.WriteLine(address.Index);
            
            Console.ReadKey();
        }
    }
}
//роботу виконав Мозговий Микола 