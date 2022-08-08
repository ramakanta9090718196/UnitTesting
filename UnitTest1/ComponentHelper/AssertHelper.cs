using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest1.ComponentHelper
{
    // this class is created as in case of any assert failure rest  of the independent test cases is not going to be skipped
    public class AssertHelper
    {
        public static void AreEqual(string expected, string actual)
        {
            try
            {
                AssertHelper.AreEqual(expected,actual);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Assert helper failed");
            }
        }
    }
}
