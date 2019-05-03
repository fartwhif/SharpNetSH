using SharpNetSH.Test.Spike;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SharpNetSH.Test.ADVFIREWALL.FIREWALL
{
    [TestClass]
    public class DeleteActionTests
    {
        [TestMethod]
        public void VerifyRuleOutput()
        {
            var harness = new StringHarness();
            new NetSH(harness).AdvFirewall.Firewall.Delete.Rule("testrule");
            Assert.AreEqual("netsh advfirewall firewall delete rule name=testrule", harness.Value);
        }
    }
}