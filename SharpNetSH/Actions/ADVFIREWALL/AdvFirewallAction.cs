using System;
using SharpNetSH.Actions.ADVFIREWALL.FIREWALL;
using SharpNetSH.ADVFIREWALL;

namespace SharpNetSH.WLAN
{
    internal class AdvFirewallAction : IAdvFirewallAction, IAction
    {
        private bool _initialized;
        private IExecutionHarness _harness;
        private String _priorText;

        private AdvFirewallAction()
        {
        }

        public string ActionName => "advfirewall";

        public void Initialize(string priorText, IExecutionHarness harness)
        {
            _initialized = true;
            _priorText = priorText + " " + ActionName;
            _harness = harness;
        }

        internal static IAdvFirewallAction CreateAction(String priorText, IExecutionHarness harness)
        {
            var action = new AdvFirewallAction();
            action.Initialize(priorText, harness);
            return action;
        }

        public IFirewallAction Firewall
        {
            get
            {
                if (!_initialized)
                    throw new Exception("Actions must be initialized prior to use.");
                return FirewallAction.CreateAction(_priorText, _harness);
            }
        }
    }
}
