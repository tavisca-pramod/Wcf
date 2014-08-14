using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Web;

namespace ExampleWcfService
{
    public class ExampleServiceMessageInspector : IDispatchMessageInspector
    {
        public object AfterReceiveRequest(ref System.ServiceModel.Channels.Message request, System.ServiceModel.IClientChannel channel, System.ServiceModel.InstanceContext instanceContext)
        {
            using (MessageBuffer buffer = request.CreateBufferedCopy(Int32.MaxValue))
            {
                request = buffer.CreateMessage();
                var action = request.Headers.Action.Split('/');

                Console.WriteLine("Received request for :\n{0}", action.Last());

             //   Console.ReadKey();
                return request;
            }
        }

        public void BeforeSendReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {}
    }
}