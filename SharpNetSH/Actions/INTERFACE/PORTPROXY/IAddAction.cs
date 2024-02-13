using System.Net;

namespace SharpNetSH.Actions.INTERFACE.PORTPROXY
{
    /// <summary>
    /// Add port forwarding
    /// </summary>
    public interface IAddAction
    {
        [MethodName("v4tov4")]
        [AdministratorRequired]
        IResponse v4tov4(
            [ParameterName("listenaddress")] IPAddress listenaddress,
            [ParameterName("listenport")] int listenport,
            [ParameterName("connectaddress")] IPAddress connectaddress,
            [ParameterName("connectport")] int connectport);

        [MethodName("v4tov6")]
        [AdministratorRequired]
        IResponse v4tov6(
            [ParameterName("listenaddress")] IPAddress listenaddress,
            [ParameterName("listenport")] int listenport,
            [ParameterName("connectaddress")] IPAddress connectaddress,
            [ParameterName("connectport")] int connectport);

        [MethodName("v6tov4")]
        [AdministratorRequired]
        IResponse v6tov4(
            [ParameterName("listenaddress")] IPAddress listenaddress,
            [ParameterName("listenport")] int listenport,
            [ParameterName("connectaddress")] IPAddress connectaddress,
            [ParameterName("connectport")] int connectport);

        [MethodName("v6tov6")]
        [AdministratorRequired]
        IResponse v6tov6(
            [ParameterName("listenaddress")] IPAddress listenaddress,
            [ParameterName("listenport")] int listenport,
            [ParameterName("connectaddress")] IPAddress connectaddress,
            [ParameterName("connectport")] int connectport);
    }
}