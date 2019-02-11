using System.Collections.Generic;

namespace SharpNetSH
{
    internal interface IResponseProcessor
    {
        StandardResponse ProcessResponse(IEnumerable<string> responseLines, int exitCode, string splitRegEx = null);
    }
}