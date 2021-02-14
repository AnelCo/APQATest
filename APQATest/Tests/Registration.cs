using NUnit.Framework;
using APQATest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APQATest.Tests
{
    [TestFixture]
    public class Registration : TestBase
    {
        [Test]
        public void VerifyThatUserCanRegister()
        {

            LoginPage loginPage = basePage.OpenLoginForm();
            RegistrationPage registerPage = loginPage.SelectRegisterOption();
            //registerPage.RegisterUser("kollidsfds@sda.com", "Password!", "yyuyuyyuuyrtyu","coko");
            //registerPage.VerifyThatUserIsRegistered("yyuyuyyuuyrtyu");
        }
        [Test]
        public void RegisterUser()
        {
            LoginPage loginPage = basePage.OpenLoginForm();
            RegistrationPage registerUser= loginPage.SelectRegisterNewUser();

           
        }
    }
}


