using Microsoft.VisualStudio.TestTools.UnitTesting;

using SharpNetSH.Test.Spike;

using System.Net;

namespace SharpNetSH.Test.INTERFACE.PORTPROXY
{
    [TestClass]
    public class DeleteActionTests
    {
        [TestMethod]
        public void VerifyRuleOutput()
        {
            var harness = new StringHarness();
            new NetSH(harness).Interface.PortProxy.Delete.v4tov4(IPAddress.Parse("1.2.3.4"), 12345);
            Assert.AreEqual("netsh interface portproxy delete v4tov4 listenaddress=1.2.3.4 listenport=12345", harness.Value);
        }
    }
}