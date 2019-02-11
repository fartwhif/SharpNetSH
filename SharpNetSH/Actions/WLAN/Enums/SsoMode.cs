using System.ComponentModel;

namespace SharpNetSH.WLAN.Enums
{
    public enum SsoMode
    {
        [Description("preLogon")]
        PreLogon,
        [Description("postLogon")]
        PostLogon,
        [Description("none")]
        None
    }
}
