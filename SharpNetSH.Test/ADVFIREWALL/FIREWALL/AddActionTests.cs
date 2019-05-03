using SharpNetSH.Test.Spike;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpNetSH.ADVFIREWALL.FIREWALL.Enums;

namespace SharpNetSH.Test.ADVFIREWALL.FIREWALL
{
    [TestClass]
    public class AddActionTests
    {
        [TestMethod]
        public void VerifyRuleOutput()
        {
            var harness = new StringHarness();
            new NetSH(harness).AdvFirewall.Firewall.Add.Rule("testrule", Direction.In, Action.Allow);
            Assert.AreEqual("netsh advfirewall firewall add rule name=testrule dir=in action=allow", harness.Value);

            new NetSH(harness).AdvFirewall.Firewall.Add.Rule("testrule", Direction.Out, Action.Allow);
            Assert.AreEqual("netsh advfirewall firewall add rule name=testrule dir=out action=allow", harness.Value);

            new NetSH(harness).AdvFirewall.Firewall.Add.Rule("testrule", Direction.In, Action.Allow);
            Assert.AreEqual("netsh advfirewall firewall add rule name=testrule dir=in action=allow", harness.Value);

            new NetSH(harness).AdvFirewall.Firewall.Add.Rule("testrule", Direction.In, Action.Block);
            Assert.AreEqual("netsh advfirewall firewall add rule name=testrule dir=in action=block", harness.Value);

            new NetSH(harness).AdvFirewall.Firewall.Add.Rule("testrule", Direction.In, Action.Bypass);
            Assert.AreEqual("netsh advfirewall firewall add rule name=testrule dir=in action=bypass", harness.Value);

            new NetSH(harness).AdvFirewall.Firewall.Add.Rule("testrule", Direction.In, Action.Allow, protocol: Protocol.Tcp);
            Assert.AreEqual("netsh advfirewall firewall add rule name=testrule dir=in action=allow protocol=tcp", harness.Value);

            new NetSH(harness).AdvFirewall.Firewall.Add.Rule("testrule", Direction.In, Action.Allow, protocol: Protocol.Udp);
            Assert.AreEqual("netsh advfirewall firewall add rule name=testrule dir=in action=allow protocol=udp", harness.Value);

            new NetSH(harness).AdvFirewall.Firewall.Add.Rule("testrule", Direction.In, Action.Allow, Protocol.Tcp, localport: 2345);
            Assert.AreEqual("netsh advfirewall firewall add rule name=testrule dir=in action=allow protocol=tcp localport=2345", harness.Value);
        }
    }
}