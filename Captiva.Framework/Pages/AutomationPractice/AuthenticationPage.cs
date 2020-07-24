using Captiva.Framework.Controls;
using Captiva.Framework.Core;
using Captiva.Framework.Pages.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Captiva.Framework.Pages.AutomationPractice
{
    public class AuthenticationPage : Page
    {
        public AuthenticationPage() : base("Authentication")
        {

        }
        private Button CreatedAnAccount => new Button(Locator.CssSelector, "div button#SubmitCreate", "SubmitCreate");
        private TextBox EmailAddress => new TextBox(Locator.Id, "email_create", "Email address");
        private Control ErrorMessage => new Control(Locator.XPath, "//div[@id='create_account_error']//li", "Invalid email address.");

        public void ClickOnCreateAnAccount()
        {
            CreatedAnAccount.Click();
           
        }

        public void TypeEmailAddress(string text)
        {
            EmailAddress.SetText(text);
        }

        public string GetErrorMessage()
        {
            var text = ErrorMessage.GetText();
            return text;
        }

    }
}
