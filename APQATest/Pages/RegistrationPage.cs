using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APQATest.Pages
{
    public class RegistrationPage : BasePage
    {
        private IWebElement signInButton => driver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[1]/a"));
        private IWebElement emailButton => driver.FindElement(By.XPath("//*[@id='email_create']"));
        private IWebElement createAccountButton => driver.FindElement(By.XPath("//*[@id='SubmitCreate']/span"));
        private IWebElement gender => driver.FindElement(By.XPath("//*[@id='id_gender1']"));
        private IWebElement firstN => driver.FindElement(By.XPath("//*[@id='customer_firstname']"));
        private IWebElement lastN=> driver.FindElement(By.XPath("//*[@id='customer_lastname']"));
        private IWebElement passwordButton => driver.FindElement(By.XPath("//*[@id='passwd']"));
        private IWebElement birthDay => driver.FindElement(By.XPath("//*[@id='days']/option[3]"));

       


        private IWebElement birthMonth => driver.FindElement(By.XPath("//*[@id='months']/option[2]"));
        private IWebElement birthYear => driver.FindElement(By.XPath("//*[@id='years']/option[36]"));
        private IWebElement firstNameReg => driver.FindElement(By.XPath("//*[@id='firstname']"));
        private IWebElement lastNameReg => driver.FindElement(By.XPath("//*[@id='lastname']"));
        private IWebElement adressReg => driver.FindElement(By.XPath("//*[@id='address1']"));
        private IWebElement cityReg => driver.FindElement(By.XPath("//*[@id='city']"));
        private IWebElement stateReg => driver.FindElement(By.XPath("//*[@name='id_state']/option[3]"));
        private IWebElement zypCodeReg => driver.FindElement(By.XPath("//*[@id='postcode']"));
        private IWebElement countryReg => driver.FindElement(By.XPath("//*[@id='id_country']/option[2]"));
        private IWebElement mobilePhoneReg => driver.FindElement(By.XPath("//*[@id='phone_mobile']"));
        private IWebElement adressAliasReg => driver.FindElement(By.XPath("//*[@id='alias']"));
        public RegistrationPage(IWebDriver driver) : base(driver) { }
        public RegistrationPage RegisterUser(string email, string password, string name, string lastName)
        {
            signInButton.Click();
            emailButton.SendKeys(email);
            createAccountButton.Click();
            gender.Click();
            firstN.SendKeys(name);
            lastN.SendKeys(lastName);
            passwordButton.SendKeys(password);
            birthDay.Click();
            birthMonth.Click();
            birthYear.Click();
            firstNameReg.SendKeys(name);
            lastNameReg.SendKeys(lastName);
            adressReg.SendKeys("adresaTest");
            cityReg.SendKeys("CityTest");
            stateReg.Click();
            zypCodeReg.Click();
            countryReg.Click();
            mobilePhoneReg.SendKeys("061102057");
            adressReg.SendKeys("TestAdress");


           


            return new RegistrationPage(driver);
        }

      


    }
}
