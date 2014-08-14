using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.Web;

namespace ExampleWcfService
{
    public class ExampleServiceBehavior : IEndpointBehavior
    {
        //public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        //{
        //}

        //public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        //{
        //    throw new Exception("Behavior not supported on the consumer side!");
        //}

        //public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        //{
        //    ConsoleOutputMessageInspector inspector = new ConsoleOutputMessageInspector();
        //    endpointDispatcher.DispatchRuntime.MessageInspectors.Add(inspector);
        //}

        //public void Validate(ServiceEndpoint endpoint)
        //{
        //}
        public void AddBindingParameters(ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
            //throw new NotImplementedException();
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime)
        {
            //throw new NotImplementedException();
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher)
        {
            ExampleServiceMessageInspector inspector = new ExampleServiceMessageInspector();
            endpointDispatcher.DispatchRuntime.MessageInspectors.Add(inspector);
        }

        public void Validate(ServiceEndpoint endpoint)
        {
            //throw new NotImplementedException();
        }
    }
}