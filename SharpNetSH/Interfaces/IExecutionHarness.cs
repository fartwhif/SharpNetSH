using System;
using System.Collections.Generic;

namespace SharpNetSH
{
    public interface IExecutionHarness
    {
        IEnumerable<String> Execute(string action, out int exitCode);
    }
}