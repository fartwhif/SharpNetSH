using SharpNetSH.Actions.ADVFIREWALL.FIREWALL;

namespace SharpNetSH.ADVFIREWALL
{
    public interface IAdvFirewallAction
    {
        IFirewallAction Firewall { get; }
    }
}