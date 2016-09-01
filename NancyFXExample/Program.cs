using Nancy;
using Nancy.Hosting.Self;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyFXExample
{
    class Program
    
    {
        static void Main(string[] args)
        {
            var url = "http://localhost:8080";
            HostConfiguration hostConfigs = new HostConfiguration();
            hostConfigs.UrlReservations.CreateAutomatically = true;
            using (var host = new NancyHost(new Uri(url), new DefaultNancyBootstrapper(), hostConfigs))
            {
                host.Start();
                Console.Write("Nancy Server Listening on {0}" ,url);
                Console.ReadLine();
            
            }
        }
    }
}
