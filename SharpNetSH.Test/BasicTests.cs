using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SharpNetSH.Test
{
    [TestClass]
    public class BasicTests
    {
        [TestMethod]
        [Ignore]
        public void FullUrlAclTest()
        {
            var testUrl = "http://localhost:8030/test/";
            var testUser = Environment.UserDomainName + "\\" + Environment.UserName;

            var http = NetSH.CMD.Http;

            var delete = http.Delete.UrlAcl(url: testUrl);
            Assert.AreNotEqual(0, delete.ExitCode, delete.Response);

            var show = http.Show.UrlAcl(testUrl);
            Assert.AreEqual(0, show.ExitCode, show.Response);
            var tree = show.ResponseObject as Tree;
            Assert.IsNotNull(tree, show.Response);
            Assert.AreEqual(0, tree.Children.Count, show.Response);

            var add = http.Add.UrlAcl(url: testUrl, user: testUser, sddl: null);
            Assert.AreEqual(0, add.ExitCode, add.Response);

            add = http.Add.UrlAcl(url: testUrl, user: testUser, sddl: null);
            Assert.AreNotEqual(0, add.ExitCode, add.Response);

            show = http.Show.UrlAcl(testUrl);
            Assert.AreEqual(0, show.ExitCode, show.Response);
            tree = show.ResponseObject as Tree;
            Assert.IsNotNull(tree, show.Response);

            var urlNode = tree.Children[0];
            Assert.AreEqual(testUrl, urlNode.Value, show.Response);

            var userNode = urlNode.Children[0];
            Assert.AreEqual(testUser, userNode.Value);

            delete = http.Delete.UrlAcl(url: testUrl);
            Assert.AreEqual(0, delete.ExitCode, delete.Response);
        }
    }
}
