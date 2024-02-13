using Microsoft.VisualStudio.TestTools.UnitTesting;

using SharpNetSH.Test.Spike;

namespace SharpNetSH.Test.INTERFACE.PORTPROXY
{
    [TestClass]
    public class ShowActionTests
    {
        [TestMethod]
        public void VerifyRuleOutput()
        {
            var harness = new StringHarness();
            new NetSH(harness).Interface.PortProxy.Show.all();
            Assert.AreEqual("netsh interface portproxy show all", harness.Value);

        }
    }
}