using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.Settings;

namespace UnitTest1.ComponentHelper
{
    class WindowHelper
    {
        public static string GetTitle()
        {
            return ObjectRepository.Driver.Title;
        }
    }
}
