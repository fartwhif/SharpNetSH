using System;
using System.Linq;

namespace Ignite.SharpNetSH
{
	[AttributeUsage(AttributeTargets.Method)]
	internal class ResponseProcessorAttribute : Attribute
	{
		public Type ResponseProcessorType { get; }
		public string SplitRegEx { get; private set; }

		public ResponseProcessorAttribute(Type responseProcessorType, string splitRegEx = null)
		{
			if (!responseProcessorType.GetInterfaces().Contains(typeof (IResponseProcessor)))
				throw new Exception("Invalid response processor type applied to attribute");
			ResponseProcessorType = responseProcessorType;
			SplitRegEx = splitRegEx;
		}
	}
}