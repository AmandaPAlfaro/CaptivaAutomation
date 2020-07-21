using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Captiva.Framework.Browser;

namespace Captiva.TestCase.Base
{
 
    public class BaseTest
    {
        [OneTimeSetUp]
        public void SetUpReporter() 
        {
        }

        [SetUp]
        public void MyTestInitialize() 
        {
            try
            {
                BrowserManager.Instance.Init();
                BrowserManager.Instance.Visit("http://automationpractice.com/index.php");
            }
            catch (Exception ex)
            {
                var errorMessage = $"{ex.Message} :: {ex.StackTrace}";
                throw new Exception(errorMessage);
            }
        }

        [TearDown]
        public void MyCleanup() 
        {
            BrowserManager.Instance.Quit();
        }

        [OneTimeTearDown]
        public void CloseReporter() 
        {
        }
  
    }
}
