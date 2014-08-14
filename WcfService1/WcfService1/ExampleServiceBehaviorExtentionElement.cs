using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Web;

namespace ExampleWcfService
{
    public class ExampleServiceBehaviorExtentionElement : BehaviorExtensionElement
    {
        protected override object CreateBehavior()
        {
            return new ExampleServiceBehavior();
        }

        public override Type BehaviorType
        {
            get
            {
                return typeof(ExampleServiceBehavior);
            }
        }
    }
}