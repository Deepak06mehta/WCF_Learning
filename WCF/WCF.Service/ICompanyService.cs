using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICompanyService" in both code and config file together.
    //use name in service contract attribute to change service interface naem without breaking the service
    [ServiceContract(Name = "ICompanyService")]
    public interface ICompanyService_someting
    {
        [OperationContract]
        string GetPubicInformation();
    } 

    [ServiceContract]
    public interface ICompanyConfidentialService 
    {
        [OperationContract]
        string GetConfidentialInformation();
    }
}
