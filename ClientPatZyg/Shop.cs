using ClientPatZyg.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPatZyg
{
    class Shop
    {
        
        public string CreateToy(ToyWcf toy) {
            var client = new ToyServiceClient();
          return   client.CreateToy(toy);
        }

        public ToyWcf GetToy(String  name)
        {
            var client = new ToyServiceClient();
         return   client.GetToy(name);
        }


        static void Main(string[] args)
        {
            Shop shop = new Shop();

            var client = new ToyServiceClient();
            shop.CreateToy(new ToyWcf() { Name = "Nazwa", Price = 12, Value = 123 });
            Console.Write(shop.GetToy("Nazwa").Price);
            Console.ReadKey();
        }
    }
}
