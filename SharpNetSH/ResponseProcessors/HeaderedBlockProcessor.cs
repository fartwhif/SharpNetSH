using SharpNetSH.Utilities;
using System.Collections.Generic;
using System.Linq;

namespace SharpNetSH
{
    internal class HeaderedBlockProcessor : IResponseProcessor
    {
        StandardResponse IResponseProcessor.ProcessResponse(IEnumerable<string> responseLines, int exitCode, string splitRegEx = null)
        {
            var lines = responseLines.ToList();
            var standardResponse = new StandardResponse();
            ((IResponseProcessor)standardResponse).ProcessResponse(lines, exitCode);

            if (exitCode != 0) return standardResponse;

            var objects = new List<Tree>();
            Tree currentObject = null;
            List<string> currentObjectRows = null;

            foreach (var line in lines)
            {
                if (StringExtension.IsNullOrWhiteSpace(line))
                {
                    if (currentObject != null)
                    {
                        currentObject.Children.AddRange(currentObjectRows.Select(d => new Tree(d, 1, splitRegEx)));
                        objects.Add(currentObject);
                    }
                    currentObject = null;
                    currentObjectRows = null;
                }
                else if (line.Contains("------"))
                {
                    currentObjectRows = new List<string>();
                }
                else
                {
                    if (currentObject == null)
                    {
                        currentObject = new Tree(line, 0, splitRegEx);
                    }
                    else
                    {
                        currentObjectRows.Add(line);
                    }
                }
            }

            standardResponse.ResponseObject = new Tree { Children = objects };
            return standardResponse;
        }
    }
}