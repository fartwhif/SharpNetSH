using System;
using System.Net;

namespace SharpNetSH.Actions.INTERFACE.PORTPROXY
{
    /// <summary>
    /// Deletes firewall rule
    /// </summary>
    public interface IDeleteAction
    {
        [MethodName("v4tov4")]
        [AdministratorRequired]
        IResponse v4tov4(
           [ParameterName("listenaddress")] IPAddress listenaddress,
           [ParameterName("listenport")] int listenport);

        [MethodName("v4tov6")]
        [AdministratorRequired]
        IResponse v4tov6(
           [ParameterName("listenaddress")] IPAddress listenaddress,
           [ParameterName("listenport")] int listenport);

        [MethodName("v6tov4")]
        [AdministratorRequired]
        IResponse v6tov4(
           [ParameterName("listenaddress")] IPAddress listenaddress,
           [ParameterName("listenport")] int listenport);

        [MethodName("v6tov6")]
        [AdministratorRequired]
        IResponse v6tov6(
           [ParameterName("listenaddress")] IPAddress listenaddress,
           [ParameterName("listenport")] int listenport);

    }
}