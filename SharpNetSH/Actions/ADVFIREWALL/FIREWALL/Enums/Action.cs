using System.ComponentModel;

namespace SharpNetSH.ADVFIREWALL.FIREWALL.Enums
{
    public enum Action
    {
        [Description("allow")]
        Allow,
        [Description("block")]
        Block,
        [Description("bypass")]
        Bypass
    }
}