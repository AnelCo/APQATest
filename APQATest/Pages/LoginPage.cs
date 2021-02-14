using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APQATest.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver) { }

        public LoginPage OpenLoginForm()
        {
            driver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[1]/a")).Click();

            return new LoginPage(driver);
        }
        public RegistrationPage SelectRegisterOption()
        {
            driver.FindElement(By.XPath("//*[@id='create-account_form']/h3")).Click();
            

            return new RegistrationPage(driver);
        }

        public RegistrationPage SelectRegisterNewUser()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
           


            driver.FindElement(By.XPath("//*[@id='email_create']")).SendKeys("anel"+randomInt+"@hotmail.com");
            driver.FindElement(By.XPath("//*[@id='SubmitCreate']/span")).Click();
            

            return new RegistrationPage(driver);
        }


    }
}
