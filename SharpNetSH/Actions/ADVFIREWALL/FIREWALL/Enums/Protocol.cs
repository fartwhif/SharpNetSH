using System.ComponentModel;

namespace SharpNetSH.ADVFIREWALL.FIREWALL.Enums
{
    /// <summary>
    /// Firewall rule protocol
    /// </summary>
    public enum Protocol
    {
        /// <summary>
        /// Any
        /// </summary>
        [Description("any")]
        Any,
        /// <summary>
        /// Tcp
        /// </summary>
        [Description("tcp")]
        Tcp,
        /// <summary>
        /// Udp
        /// </summary>
        [Description("udp")]
        Udp
    }
}