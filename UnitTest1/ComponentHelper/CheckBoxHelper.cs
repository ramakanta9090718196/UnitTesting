﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1.ComponentHelper
{
    
    public class CheckBoxHelper
    {
        private static IWebElement element;
        public static void CheckCheckBox(By locator)
        {
            element = GenericHelper.GetElement(locator);
            element.Click();
        }

        public static bool IsCheckBoxChecked(By locator)
        {
            element=GenericHelper.GetElement(locator);
            String flag = element.GetAttribute("checked");
            if(flag==null)
            {
                return false;
            }
            else
            {
                return flag.Equals("true") || flag.Equals("checked");
            }
        }
    }
}
