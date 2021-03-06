﻿using Blog.UI.Tests.Models;
using OpenQA.Selenium;


namespace Blog.UI.Tests.Pages.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver)
            :base(driver)
        {
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl("http://localhost:60634/Account/Register");
        }

        public void FillRegistrationForm(User user)
        {
			Type(this.Email, user.Email);
            Type(this.FullName, user.FullName);                     
            Type(this.Password, user.Password);
            Type(this.ConfirmPassword, user.ConfirmPassword);
            this.SubmitButton.Click();
        }

        

        private void Type(IWebElement element, string text)
        {
            element.Clear();

            if (!text.Equals("String.Empty"))
            {
                element.SendKeys(text);
            }
        }
    }
}
