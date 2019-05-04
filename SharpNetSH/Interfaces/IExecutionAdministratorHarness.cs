using System;
using System.Collections.Generic;

namespace SharpNetSH
{
    public interface IExecutionAdministratorHarness
    {
        IEnumerable<String> ExecuteAsAdministrator(string action, out int exitCode);
    }
}