using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APQATest.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver) { }

        public HomePage OpenWomenPage()
        {
            driver.FindElement(By.XPath("//*[@id='block_top_menu']/ul/li[1]/a")).Click();

            return new HomePage(driver);
        }
        public HomePage OpenDressPage()
        {
            driver.FindElement(By.XPath("//*[@id='block_top_menu']/ul/li[2]/a")).Click();

            return new HomePage(driver);
        }
        public HomePage OpenTShirtPage()
        {
            driver.FindElement(By.XPath("//*[@id='block_top_menu']/ul/li[3]/a")).Click();

            return new HomePage(driver);
        }

        public HomePage OpenPopularCategory()
        {
            driver.FindElement(By.XPath("//*[@id='home-page-tabs']/li[1]/a")).Click();

            return new HomePage(driver);
        }

        public HomePage OpenBestSellerCategory()
        {
            driver.FindElement(By.XPath("//*[@id='home-page-tabs']/li[2]/a")).Click();

            return new HomePage(driver);
        }

        public HomePage VerifiyThatPopularCategoryHas7Products()
        {
            driver.FindElement(By.XPath("//*[@id='homefeatured']/li[1]/div/div[1]/div/a[1]/img"));
            driver.FindElement(By.XPath("//*[@id='homefeatured']/li[2]/div/div[1]/div/a[1]/img"));
            driver.FindElement(By.XPath("//*[@id='homefeatured']/li[3]/div/div[1]/div/a[1]/img"));
            driver.FindElement(By.XPath("//*[@id='homefeatured']/li[4]/div/div[1]/div/a[1]/img"));
            driver.FindElement(By.XPath("//*[@id='homefeatured']/li[5]/div/div[1]/div/a[1]/img"));
            driver.FindElement(By.XPath("//*[@id='homefeatured']/li[6]/div/div[1]/div/a[1]/img"));
            driver.FindElement(By.XPath("//*[@id='homefeatured']/li[7]/div/div[1]/div/a[1]/img"));



            return new HomePage(driver);
        }

        public HomePage VerifiyThatBestSellerCategoryHas7Products()
        {
            driver.FindElement(By.XPath("//*[@id='blockbestsellers']/li[1]/div/div[1]/div/a[1]/img"));
            driver.FindElement(By.XPath("//*[@id='blockbestsellers']/li[2]/div/div[1]/div/a[1]/img"));
            driver.FindElement(By.XPath("//*[@id='blockbestsellers']/li[3]/div/div[1]/div/a[1]/img"));
            driver.FindElement(By.XPath("//*[@id='blockbestsellers']/li[4]/div/div[1]/div/a[1]/img"));
            driver.FindElement(By.XPath("//*[@id='blockbestsellers']/li[5]/div/div[1]/div/a[1]/img"));
            driver.FindElement(By.XPath("//*[@id='blockbestsellers']/li[6]/div/div[1]/div/a[1]/img"));
            driver.FindElement(By.XPath("//*[@id='blockbestsellers']/li[7]/div/div[1]/div/a[1]/img"));


            return new HomePage(driver);
        }



    }
}
