using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.Settings;

namespace UnitTest1.ComponentHelper
{
    class AlertHelper
    {
        private static bool CheckAlert()
        {
            try
            {
                ObjectRepository.Driver.SwitchTo().Alert();
                return true;
            }
            catch(NoAlertPresentException)
            {
                return false;
            }
        }

        public static string GetAlertText()
        {
            if(CheckAlert())
            {
                return ObjectRepository.Driver.SwitchTo().Alert().Text;
            }
            else
            {
                return "";
            }
        }

        public static void AcceptAlert()
        {
            if (CheckAlert())
            {
                ObjectRepository.Driver.SwitchTo().Alert().Accept();
            }
            else
            {
                return ;
            }
        }
        public static void CancelAlert()
        {
            if (CheckAlert())
            {
                ObjectRepository.Driver.SwitchTo().Alert().Dismiss();
            }
            else
            {
                return;
            }
        }

        public static void FillPrompt(string text)
        {
            if (CheckAlert())
            {
                ObjectRepository.Driver.SwitchTo().Alert().SendKeys(text);
            }
            else
            {
                return;
            }
        }
    }
}
