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
    public class Home : TestBase
    {
        [Test]
        public void VerifyCategory()
        {

            HomePage women = homePage.OpenWomenPage();
            HomePage dress = homePage.OpenDressPage();
            HomePage tshirt = homePage.OpenTShirtPage();
        }

        [Test]
        public void VerifyThatPopularHaseSevenProduct()
        {
            HomePage popularcategory = homePage.OpenPopularCategory();
            HomePage popular = homePage.VerifiyThatPopularCategoryHas7Products();
        }

        [Test]
        public void VerifyThatBestSellerHaseSevenProduct()
        {
            HomePage bestsellercategory = homePage.OpenBestSellerCategory();
            HomePage popular = homePage.VerifiyThatBestSellerCategoryHas7Products();
        }
    }
}


