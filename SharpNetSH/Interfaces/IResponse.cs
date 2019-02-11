namespace Ignite.SharpNetSH
{
    public interface IResponse
    {
        string Response { get; }
        object ResponseObject { get; }
        int ExitCode { get; }
        bool IsNormalExit { get; }
    }
}