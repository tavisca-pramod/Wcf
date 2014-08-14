using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Dispatcher;
using System.Web;

namespace ExampleWcfService
{
    public class ExampleServiceMessageDispatcher : IClientMessageInspector, IDispatchMessageInspector
    {
        // client
        public void AfterReceiveReply(ref System.ServiceModel.Channels.Message reply, 
            object correlationState)
        {
            throw new NotImplementedException();
        }

        public object BeforeSendRequest(ref System.ServiceModel.Channels.Message request, 
            System.ServiceModel.IClientChannel channel)
        {
            throw new NotImplementedException();
        }

        //server
        public object AfterReceiveRequest(ref System.ServiceModel.Channels.Message request, 
            System.ServiceModel.IClientChannel channel, System.ServiceModel.InstanceContext instanceContext)
        {
            var requestDetails = request;

            var channelDetails = channel;

            var instanceContextDetails = instanceContext;

            return null;

        }

        public void BeforeSendReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
            throw new NotImplementedException();
        }
    }
}