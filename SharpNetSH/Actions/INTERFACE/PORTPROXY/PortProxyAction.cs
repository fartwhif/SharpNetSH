using System;

namespace SharpNetSH.Actions.INTERFACE.PORTPROXY
{
    internal class PortProxyAction : IPortProxyAction, IAction
    {
        private bool _initialized;
        private IExecutionHarness _harness;
        private String _priorText;

        private PortProxyAction()
        {
        }

        public string ActionName => "portproxy";

        public void Initialize(string priorText, IExecutionHarness harness)
        {
            _initialized = true;
            _priorText = priorText + " " + ActionName;
            _harness = harness;
        }

        internal static IPortProxyAction CreateAction(String priorText, IExecutionHarness harness)
        {
            var action = new PortProxyAction();
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
