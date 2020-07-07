using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.MasGlobal.Common.Helpers
{
    public class ConfigurationHelper
    {
        public static string Get(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
