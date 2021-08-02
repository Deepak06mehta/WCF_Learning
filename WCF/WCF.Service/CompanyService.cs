using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CompanyService" in both code and config file together.
    public class CompanyService : ICompanyService,ICompanyConfidentialService
    {
        //since client and WCF service are on same system , both methods are running.
        public string GetPubicInformation()
        {
            return "thid id public information available over http outside Firewall";
        }

        public string GetConfidentialInformation()
        {
            return "This information is available over tcp under firewall";
        }
    }
}
