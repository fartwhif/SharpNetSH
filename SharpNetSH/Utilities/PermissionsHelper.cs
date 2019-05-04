using System.Security.Principal;

namespace SharpNetSH.Utilities
{
    public class PermissionsHelper
    {
        public static bool IsRunAsAdministrator()
        {
            var windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());

            return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
