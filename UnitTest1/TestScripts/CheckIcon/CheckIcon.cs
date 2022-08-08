using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.ComponentHelper;
using UnitTest1.Settings;

namespace UnitTest1.TestScripts
{
   
    public class CheckIcon
    {
        [Test]
        public void Check()
        {
            
             NavigationHelper.NavigateToUrl("https://www.tutorialspoint.com/how-to-verify-if-an-element-is-displayed-on-screen-in-selenium");
           
            IWebElement element= ObjectRepository.Driver.FindElement(By.XPath("//img[@src='/images/java8.png']"));
            
            IWebElement element2 = ObjectRepository.Driver.FindElement(By.XPath("//ul[@class='toc chapters trending']/li/a[@href='/questions/category/Java']"));

            bool verify= ImageValidate(element,element2,"Java");

            Assert.IsTrue(verify);

        }

        private bool ImageValidate(IWebElement image,IWebElement text,String verfytext)
        {
            if(image.Displayed && text.Text== verfytext)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
