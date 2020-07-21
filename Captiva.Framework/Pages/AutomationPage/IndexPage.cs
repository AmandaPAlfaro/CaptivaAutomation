using Captiva.Framework.Controls;
using Captiva.Framework.Core;
using Captiva.Framework.Pages.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Captiva.Framework.Pages.AutomationPage
{
    public class IndexPage : Page
    {
        public IndexPage() : base("")
        {
        }

        private Button SignIn => new Button(Locator.ClassName, "loging", "Sign In");

        public FromIndexPageTo ClickSingIn() 
        {
            SignIn.Click();
            return new FromIndexPageTo();
        }
    }

    public class FromIndexPageTo
    {
        public AuthenticationPage AuthenticationPage
        {
            get
            {
                return new AuthenticationPage();
            }
        }
    }
}
