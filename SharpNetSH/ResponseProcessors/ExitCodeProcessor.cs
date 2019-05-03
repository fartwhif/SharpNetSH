using System.Collections.Generic;

namespace SharpNetSH
{
    internal class ExitCodeProcessor : IResponseProcessor
    {
		StandardResponse IResponseProcessor.ProcessResponse(IEnumerable<string> responseLines, int exitCode, string splitRegEx)
		{
			IResponseProcessor response = new StandardResponse();
			response.ProcessResponse(responseLines, exitCode);
			return (StandardResponse)response;
		}
    }
}