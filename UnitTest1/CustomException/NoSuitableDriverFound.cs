﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1.CustomException
{
   public class NoSuitableDriverFound:Exception
    {
        public NoSuitableDriverFound(String msg): base(msg)
        {

        }
    }
}
