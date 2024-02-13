using System;
using SharpNetSH.Actions.INTERFACE.PORTPROXY;
using SharpNetSH.INTERFACE;

namespace SharpNetSH.WLAN
{
    internal class InterfaceAction : IInterfaceAction, IAction
    {
        private bool _initialized;
        private IExecutionHarness _harness;
        private String _priorText;

        private InterfaceAction()
        {
        }

        public string ActionName => "interface";

        public void Initialize(string priorText, IExecutionHarness harness)
        {
            _initialized = true;
            _priorText = priorText + " " + ActionName;
            _harness = harness;
        }

        internal static IInterfaceAction CreateAction(String priorText, IExecutionHarness harness)
        {
            var action = new InterfaceAction();
            action.Initialize(priorText, harness);
            return action;
        }

        public IPortProxyAction PortProxy
        {
            get
            {
                if (!_initialized)
                    throw new Exception("Actions must be initialized prior to use.");
                return PortProxyAction.CreateAction(_priorText, _harness);
            }
        }
    }
}
