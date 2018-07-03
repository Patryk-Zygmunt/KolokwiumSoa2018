using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelPatZyg
{
    public class Toy
    {
       public int Id { get; set; }
        public int Price { get; set; }
        public int Value { get; set; }
        public string Name { get; set; }

        public Toy()
        {
           
        }  

        public Toy(int id, int price, int value, string name)
        {
            Id = id;
            Price = price;
            Value = value;
            Name = name;
        }
    }
}
