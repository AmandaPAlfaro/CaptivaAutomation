using Captiva.Framework.Pages.AutomationPractice;
using Captiva.TestCase.Base;
using NUnit.Framework;
using System.Threading;

namespace Captiva.TestCase
{
    public class Tests : BaseTest
    {

        //[Test]
        //public void Test1()
        //{
        //    var page = new IndexPage();

        //    var title = page.ClickSingIn()
        //        .AuthenticationPage
        //        .Title;

        //    Thread.Sleep(30000);
        //    Assert.Pass();
        //}

        [Test]
        public void Test1()
        {
            var indexpage = new IndexPage();

            var authenticationPage = indexpage.ClickSingIn().AuthenticationPage;

            authenticationPage.TypeEmailAddress("asdfasdf");
            authenticationPage.ClickOnCreateAnAccount();
            var message = authenticationPage.GetErrorMessage();
       
            Assert.AreEqual("Invalid email address.",message);
        }
    }
}