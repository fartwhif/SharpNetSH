namespace SharpNetSH.Actions.ADVFIREWALL.FIREWALL
{
    public interface IFirewallAction
    {
        /// <summary>
        /// Represents an additive action
        /// </summary>
        IAddAction Add { get; }

        /// <summary>
        /// Represents a removal action
        /// </summary>
        IDeleteAction Delete { get; }

        ///// <summary>
        ///// </summary>
        ISetAction Set { get; }

        /// <summary>
        /// Represents a querying action
        /// </summary>
        IShowAction Show { get; }
    }
}