using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SharpNetSH.Test
{
    [TestClass]
    public class BasicTests
    {
        [TestMethod]
        public void FullUrlAclTest()
        {
            var testUrl = "http://localhost:8030/test";
            var testUser = Environment.UserDomainName + "\\" + Environment.UserName;

            var cmd = new CommandLineHarness();
            var netsh = new NetSH(
                cmd);
            var http = netsh.Http;

            var showResponse = http.Show.UrlAcl();
            var addResponse = http.Add.UrlAcl(url: testUrl, user: testUser, sddl: null);
        }
    }
}
