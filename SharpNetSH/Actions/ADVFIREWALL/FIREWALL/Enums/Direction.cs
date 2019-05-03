using System.ComponentModel;

namespace SharpNetSH.ADVFIREWALL.FIREWALL.Enums
{
    /// <summary>
    /// Firewall rule direction
    /// </summary>
    public enum Direction
    {
        /// <summary>
        /// In
        /// </summary>
        [Description("in")]
        In,
        /// <summary>
        /// Out
        /// </summary>
        [Description("out")]
        Out
    }
}