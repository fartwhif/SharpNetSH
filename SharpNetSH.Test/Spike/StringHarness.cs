using System;
using System.Collections.Generic;

namespace Ignite.SharpNetSH.Test.Spike
{
	public class StringHarness : IExecutionHarness
	{
	    public string Value { get; private set; }

	    public IEnumerable<string> Execute(string action, out int exitCode)
		{
			Value = action;
			exitCode = 0;
			return new List<string>();
		}
	}
}