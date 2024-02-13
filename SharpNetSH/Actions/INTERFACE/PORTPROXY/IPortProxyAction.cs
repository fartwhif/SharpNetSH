namespace SharpNetSH.Actions.INTERFACE.PORTPROXY
{
    public interface IPortProxyAction
    {
        /// <summary>
        /// Represents an additive action
        /// </summary>
        IAddAction Add { get; }

        /// <summary>
        /// Represents a removal action
        /// </summary>
        IDeleteAction Delete { get; }

        /// <summary>
        /// Represents a querying action
        /// </summary>
        IShowAction Show { get; }
    }
}