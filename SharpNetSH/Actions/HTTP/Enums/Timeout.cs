using System.ComponentModel;

namespace SharpNetSH.HTTP.Enums
{
    public enum Timeout
    {
        [Description("idleconnectiontimeout")]
        IdleConnectionTimeout,
        [Description("headerwaittimeout")]
        HeaderWaitTimeout
    }
}