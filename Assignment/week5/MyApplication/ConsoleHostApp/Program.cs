using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfMyService;
using System.ServiceModel;

namespace ConsoleHostApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(MyService));
            host.AddServiceEndpoint(typeof(IMyService), new NetTcpBinding(), "net.tcp://localhost:8989/MyService");
            host.AddServiceEndpoint(typeof(IMyService), new WSHttpBinding(), "http://localhost:8888/MyService");
            host.Open();

            Console.WriteLine("Server started ...");
            Console.ReadLine();
        }
    }
}
