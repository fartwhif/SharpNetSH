using SharpNetSH.Actions.INTERFACE.PORTPROXY;

namespace SharpNetSH.INTERFACE
{
    public interface IInterfaceAction
    {
        IPortProxyAction PortProxy { get; }
    }
}