using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WCFHost
{
    class Program
    {
        static void Main()
        {
            using(ServiceHost host =new ServiceHost(typeof(WCF.Service.Service1)))
            {
                host.Open();
                Console.WriteLine("open Host @" + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
