using ModelPatZyg;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service1 : IToyService
    {
        private readonly LiteRepository repository = new LiteRepository();
        public ToyWcf GetToy(string name)
        {
            
            return Map(repository.GetAll().Where(n=>n.Name == name).First());
        }

        public String CreateToy(ToyWcf toyWcf)
        {
            if (toyWcf == null)
            {
                throw new ArgumentNullException("Toy");
            }
            repository.Add(InverseMap(toyWcf));
            return toyWcf.Name;
        }

        public ToyWcf Map(Toy toy)
        {
            if (toy == null)
                return null;
            return new ToyWcf() { Id = toy.Id, Name = toy.Name, Price = toy.Price, Value = toy.Value };
        }

        public Toy InverseMap(ToyWcf toy)
        {
            if (toy == null)
                return null;
            return new Toy() { Id = toy.Id, Name = toy.Name, Price = toy.Price, Value = toy.Value };
        }
    }
}
