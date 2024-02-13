using SharpNetSH.INTERFACE;
using SharpNetSH.HTTP;
using SharpNetSH.WLAN;
using SharpNetSH.ADVFIREWALL;

namespace SharpNetSH
{
    public sealed class NetSH : INetSH
    {
        private readonly IExecutionHarness _harness;

        public NetSH(IExecutionHarness harness)
        {
            _harness = harness;
        }

		/// <summary>
		/// Instantiates a new instance of NetSH with a CommandLineHarness
		/// </summary>
		public static NetSH CMD
		{
		    get { return new NetSH(new CommandLineHarness()); }
		}

	    public IHttpAction Http
	    {
	        get { return HttpAction.CreateAction("netsh", _harness); }
	    }

	    public IWlanAction Wlan
	    {
	        get { return WlanAction.CreateAction("netsh", _harness); }
	    }

        public IAdvFirewallAction AdvFirewall => AdvFirewallAction.CreateAction("netsh", _harness);

        public IInterfaceAction Interface => InterfaceAction.CreateAction("netsh", _harness);
    }
}