using System;
using System.Net;

namespace SharpNetSH.Actions.INTERFACE.PORTPROXY
{
    public interface IShowAction
    {
        [MethodName("all")]
        [ResponseProcessor(typeof(HeaderedBlockProcessor), @":\s+")]
        IResponse all();

        [MethodName("v4tov4")]
        [ResponseProcessor(typeof(HeaderedBlockProcessor), @":\s+")]
        IResponse v4tov4();

        [MethodName("v4tov6")]
        [ResponseProcessor(typeof(HeaderedBlockProcessor), @":\s+")]
        IResponse v4tov6();

        [MethodName("v6tov4")]
        [ResponseProcessor(typeof(HeaderedBlockProcessor), @":\s+")]
        IResponse v6tov4();

        [MethodName("v6tov6")]
        [ResponseProcessor(typeof(HeaderedBlockProcessor), @":\s+")]
        IResponse v6tov6();
    }
}