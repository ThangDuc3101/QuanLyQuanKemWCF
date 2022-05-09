using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFBanKem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        List<Ice_cream> getIceCream();

        [OperationContract]
        int addIceCream(Ice_cream i);

        [OperationContract]
        int editIceCream(Ice_cream i);

        [OperationContract]
        int deleteIceCream(Ice_cream i);

        [OperationContract]
        int datKem(Ice_cream i);

        [OperationContract]
        List<Ice_cream> banduoc();

        [OperationContract]
        List<Ice_cream> tonlai();

        [OperationContract]
        List<Ice_cream> findIceCream(Ice_cream i);


        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WCFBanKem.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
