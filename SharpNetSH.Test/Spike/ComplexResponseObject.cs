﻿using System.Collections;
using System.Collections.Generic;

namespace Ignite.SharpNetSH.Test.Spike
{
	public class ComplexResponseObject : IResponseProcessor, IMultiResponseProcessor
	{
		internal ComplexResponseObject()
		{

		}

		object IResponseProcessor.ProcessResponse(IEnumerable<string> responseLines)
		{
			return this;
		}

		IEnumerable IMultiResponseProcessor.ProcessResponse(IEnumerable<string> responseLines)
		{
			return new List<ComplexResponseObject>();
		}
	}
}