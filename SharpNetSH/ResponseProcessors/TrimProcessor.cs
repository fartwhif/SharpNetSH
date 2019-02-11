using SharpNetSH.Utilities;
using System.Collections.Generic;
using System.Linq;

namespace SharpNetSH
{
    internal class TrimProcessor : IResponseProcessor
    {
        StandardResponse IResponseProcessor.ProcessResponse(IEnumerable<string> responseLines, int exitCode, string splitRegEx = null)
        {
            IResponseProcessor response = new StandardResponse();

            var entries = new List<string>();
            entries = responseLines.Skip(3).Where(line => !StringExtension.IsNullOrWhiteSpace(line)).Select(line => line.Trim()).ToList();

            var respObj = response.ProcessResponse(entries, exitCode);
            respObj.ResponseObject = entries;
            return respObj;
        }
    }
}