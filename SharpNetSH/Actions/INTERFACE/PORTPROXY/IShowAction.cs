using System;
using System.Net;

namespace SharpNetSH.Actions.INTERFACE.PORTPROXY
{
    public interface IShowAction
    {
        [MethodName("all")]
        [ResponseProcessor(typeof(StandardResponse))]
        IResponse all();

        [MethodName("v4tov4")]
        [ResponseProcessor(typeof(StandardResponse))]
        IResponse v4tov4();

        [MethodName("v4tov6")]
        [ResponseProcessor(typeof(StandardResponse))]
        IResponse v4tov6();

        [MethodName("v6tov4")]
        [ResponseProcessor(typeof(StandardResponse))]
        IResponse v6tov4();

        [MethodName("v6tov6")]
        [ResponseProcessor(typeof(StandardResponse))]
        IResponse v6tov6();
    }
}