using System.ComponentModel;

namespace SharpNetSH.WLAN.Enums
{
    public enum Permission
    {
        [Description("allow")]
        Allow,
        [Description("block")]
        Block,
        [Description("denyall")]
        DenyAll
    }
}
