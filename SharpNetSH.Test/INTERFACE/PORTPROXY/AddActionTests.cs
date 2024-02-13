using Microsoft.VisualStudio.TestTools.UnitTesting;

using SharpNetSH.Test.Spike;

using System.Net;

namespace SharpNetSH.Test.INTERFACE.PORTPROXY
{
    [TestClass]
    public class AddActionTests
    {
        [TestMethod]
        public void VerifyRuleOutput()
        {
            var harness = new StringHarness();
            new NetSH(harness).Interface.PortProxy.Add.v4tov4(IPAddress.Parse("1.2.3.4"), 12345, IPAddress.Parse("4.3.3.1"), 56321);
            Assert.AreEqual("netsh interface portproxy add v4tov4 listenaddress=1.2.3.4 listenport=12345 connectaddress=4.3.3.1 connectport=56321", harness.Value);
        }
    }
}