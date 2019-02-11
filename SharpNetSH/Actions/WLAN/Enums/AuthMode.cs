using System.ComponentModel;

namespace SharpNetSH.WLAN.Enums
{
    public enum AuthMode
    {
        [Description("machineOrUser")]
        MachineOrUser,
        [Description("machineOnly")]
        MachineOnly,
        [Description("userOnly")]
        UserOnly,
        [Description("guest")]
        Guest
    }
}
