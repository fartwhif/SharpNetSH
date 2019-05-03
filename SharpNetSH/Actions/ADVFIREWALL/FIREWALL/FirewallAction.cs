using System;

namespace SharpNetSH.Actions.ADVFIREWALL.FIREWALL
{
    internal class FirewallAction : IFirewallAction, IAction
    {
        private bool _initialized;
        private IExecutionHarness _harness;
        private String _priorText;

        private FirewallAction()
        {
        }

        public string ActionName => "firewall";

        public void Initialize(string priorText, IExecutionHarness harness)
        {
            _initialized = true;
            _priorText = priorText + " " + ActionName;
            _harness = harness;
        }

        internal static IFirewallAction CreateAction(String priorText, IExecutionHarness harness)
        {
            var action = new FirewallAction();
            action.Initialize(priorText, harness);
            return action;
        }

        public IAddAction Add
        {
            get
            {
                if (!_initialized)
                    throw new Exception("Actions must be initialized prior to use.");
                return ActionProxy<IAddAction>.Create("add", _priorText, _harness);
            }
        }

        public IDeleteAction Delete
        {
            get
            {
                if (!_initialized)
                    throw new Exception("Actions must be initialized prior to use.");
                return ActionProxy<IDeleteAction>.Create("delete", _priorText, _harness);
            }
        }

        public ISetAction Set
        {
            get
            {
                if (!_initialized)
                    throw new Exception("Actions must be initialized prior to use.");
                return ActionProxy<ISetAction>.Create("set", _priorText, _harness);
            }
        }

        public IShowAction Show
        {
            get
            {
                if (!_initialized)
                    throw new Exception("Actions must be initialized prior to use.");

                return ActionProxy<IShowAction>.Create("show", _priorText, _harness);
            }
        }
    }
}
