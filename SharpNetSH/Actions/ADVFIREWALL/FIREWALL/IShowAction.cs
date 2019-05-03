using System;

namespace SharpNetSH.Actions.ADVFIREWALL.FIREWALL
{
    public interface IShowAction
    {
        /// <summary>
        /// Lists firewall rules of given name.
        /// </summary>
        /// <param name="name">Specifies the rule name. If unspecified, implies all rules.</param>
        [MethodName("rule")]
        [ResponseProcessor(typeof(HeaderedBlockProcessor), @":\s+")]
        IResponse Rule([ParameterName("name")] String name = "all");
    }
}