using SharpNetSH.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpNetSH
{
    public sealed class StandardResponse : IResponseProcessor, IResponse
    {
        public string Response { get; internal set; }
        public object ResponseObject { get; internal set; }
        public int ExitCode { get; internal set; }
        public bool IsNormalExit { get; internal set; }

        internal StandardResponse()
        { }

		StandardResponse IResponseProcessor.ProcessResponse(IEnumerable<string> responseLines, int exitCode, string splitRegEx)
		{
			ExitCode = exitCode;
			IsNormalExit = exitCode == 0;
            var nonEmptyLines = responseLines.Where(x => !StringExtension.IsNullOrWhiteSpace(x)).ToList();
			Response = nonEmptyLines.Any() ? nonEmptyLines.Aggregate((current, next) => current + Environment.NewLine + next) : string.Empty;
			return this;
		}
    }
}