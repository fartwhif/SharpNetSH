using SharpNetSH.ADVFIREWALL.FIREWALL.Enums;

namespace SharpNetSH.Actions.ADVFIREWALL.FIREWALL
{
    /// <summary>
    /// Add firewall rule
    /// </summary>
    public interface IAddAction
    {
        /// <summary>
        /// Reserves the specified URL for non-administrator users and accounts. The discretionary access control list (DACL) can be specified by using an account name with the listen and delegate parameters or by using a security descriptor definition language (SDDL) string.
        /// See <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/cc307223(v=vs.85).aspx">MSDN</a>.
        /// </summary>
        /// <param name="name">Specifies the fully qualified URL.</param>
        /// <param name="dir">Specifies the user or user group name.</param>
        /// <param name="action">True: Allows the user to register URLs. This is the default value.<br></br>
        ///     False: Denies the user from registering URLs.</param>
        /// <param name="protocol">True: Allows the user to delegate URLs.<br></br>
        ///     False: Denies the user from delegating URLs. This is the default value.</param>
        /// <param name="localport">True: Allows the user to delegate URLs.<br></br>
        ///     False: Denies the user from delegating URLs. This is the default value.</param>
        /// <remarks>
        /// </remarks>
        [MethodName("rule")]
        IResponse Rule([ParameterName("name")] string name,
            [ParameterName("dir")] Direction dir,
            [ParameterName("action")] Action action,
            [ParameterName("protocol")] Protocol? protocol = null,
            [ParameterName("localport")] int? localport = null);
    }
}