using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.Configuration;

namespace UnitTest1.Interface
{
    public interface IConfig
    {
        BrowserTypes GetBrowser();
        string GetUsername();
        string GetPassword();

        string GetWebsite();

        int PageLoadTimeOut();
    }
}
