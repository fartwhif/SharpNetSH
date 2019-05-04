using System;

namespace SharpNetSH
{
    [AttributeUsage(AttributeTargets.Method)]
    public class AdministratorRequiredAttribute : Attribute
    {
    }
}