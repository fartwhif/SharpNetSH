using SharpNetSH.Test.Spike;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SharpNetSH.Test.ADVFIREWALL.FIREWALL
{
    [TestClass]
    public class ShowActionTests
    {
        [TestMethod]
        public void VerifyRuleOutput()
        {
            var harness = new StringHarness();
            new NetSH(harness).AdvFirewall.Firewall.Show.Rule();
            Assert.AreEqual("netsh advfirewall firewall show rule name=all", harness.Value);

            new NetSH(harness).AdvFirewall.Firewall.Show.Rule("testrule");
            Assert.AreEqual("netsh advfirewall firewall show rule name=testrule", harness.Value);
        }
    }
}