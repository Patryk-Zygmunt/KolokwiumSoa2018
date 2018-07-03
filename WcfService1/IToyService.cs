using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IToyService
    {

        [OperationContract]
        ToyWcf GetToy(string name);

        [OperationContract]
        String CreateToy(ToyWcf toyWcf);

        
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class ToyWcf
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Price { get; set; }
        [DataMember]
        public int Value { get; set; }
        [DataMember]
        public string Name { get; set; }    
       
    }
}
