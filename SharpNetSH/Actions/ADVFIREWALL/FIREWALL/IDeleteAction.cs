using System;

namespace SharpNetSH.Actions.ADVFIREWALL.FIREWALL
{
    /// <summary>
    /// Deletes firewall rule
    /// </summary>
    public interface IDeleteAction
    {
        /// <summary>
        /// Deletes a reserved URL.
        /// See <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/cc307231(v=vs.85).aspx">MSDN</a>.
        /// </summary>
        /// <param name="name">Specifies the fully qualified URL.</param>
        [MethodName("rule")]
        IResponse Rule([ParameterName("name")] String name);
    }
}