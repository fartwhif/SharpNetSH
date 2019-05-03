using SharpNetSH.Test.Spike;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpNetSH.ADVFIREWALL.FIREWALL.Enums;

namespace SharpNetSH.Test.ADVFIREWALL.FIREWALL
{
    [TestClass]
    public class SetActionTests
    {
        [TestMethod]
        public void VerifyRuleOutput()
        {
            var harness = new StringHarness();
            new NetSH(harness).AdvFirewall.Firewall.Set.Rule("testrule", Direction.In);
            Assert.AreEqual("netsh advfirewall firewall set rule name=testrule new dir=in", harness.Value);

            new NetSH(harness).AdvFirewall.Firewall.Set.Rule("testrule", Direction.Out);
            Assert.AreEqual("netsh advfirewall firewall set rule name=testrule new dir=out", harness.Value);

            new NetSH(harness).AdvFirewall.Firewall.Set.Rule("testrule", Direction.Out, Action.Allow);
            Assert.AreEqual("netsh advfirewall firewall set rule name=testrule new dir=out action=allow", harness.Value);

            new NetSH(harness).AdvFirewall.Firewall.Set.Rule("testrule", action: Action.Allow);
            Assert.AreEqual("netsh advfirewall firewall set rule name=testrule new action=allow", harness.Value);

            new NetSH(harness).AdvFirewall.Firewall.Set.Rule("testrule", action: Action.Block);
            Assert.AreEqual("netsh advfirewall firewall set rule name=testrule new action=block", harness.Value);

            new NetSH(harness).AdvFirewall.Firewall.Set.Rule("testrule", action: Action.Bypass);
            Assert.AreEqual("netsh advfirewall firewall set rule name=testrule new action=bypass", harness.Value);

            new NetSH(harness).AdvFirewall.Firewall.Set.Rule("testrule", protocol: Protocol.Tcp);
            Assert.AreEqual("netsh advfirewall firewall set rule name=testrule new protocol=tcp", harness.Value);

            new NetSH(harness).AdvFirewall.Firewall.Set.Rule("testrule", protocol: Protocol.Udp);
            Assert.AreEqual("netsh advfirewall firewall set rule name=testrule new protocol=udp", harness.Value);

            new NetSH(harness).AdvFirewall.Firewall.Set.Rule("testrule", localport: 2345);
            Assert.AreEqual("netsh advfirewall firewall set rule name=testrule new localport=2345", harness.Value);
        }
    }
}