using Captiva.Framework.Pages.AutomationPractice;
using Captiva.TestCase.Base;
using NUnit.Framework;
using System.Threading;

namespace Captiva.TestCase
{
    public class Tests : BaseTest
    {

        [Test]
        public void Test1()
        {
            var page = new IndexPage();

            var title = page.ClickSingIn()
                .AuthenticationPage
                .Title;

            Thread.Sleep(30000);
            Assert.Pass();
        }
    }
}