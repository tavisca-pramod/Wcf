using Consumer.ExampleService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new ExampleServiceClient())
            {
                var airLines = client.GetAllAirlines();             
                
            }
        }
    }
}
