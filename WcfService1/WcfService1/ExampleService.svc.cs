using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Web;
using System.Text;

namespace ExampleWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ExampleService : IExampleService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


        public List<AirLine> GetAllAirlines()
        {
            try
            {
                //throw new Exception(" i dont like u ");
                return new List<AirLine>()
            {
                
                new AirLine()
                {
                Code = "xyz",
                Name = "Blah"
                }
            };
            }
            catch (Exception e)
            {
                throw FaultException.CreateFault(
                    MessageFault.CreateFault(
                    new FaultCode("101"), "creating fault exception"));
            }
        }


        public string ConvertToString(int input) {
            return input.ToString();
        }
    }
}
