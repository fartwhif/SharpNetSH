using System.ComponentModel;

namespace SharpNetSH.WLAN.Enums
{
    public enum Encryption
    {
        [Description("none")]
        None,
        [Description("WEP")]
        Wep,
        [Description("TKIP")]
        Tkip,
        [Description("AES")]
        Aes,
    }
}
