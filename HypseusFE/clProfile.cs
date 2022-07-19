using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMS.Profile;

namespace HypseusFE
{
    internal class clProfile
    {
        public static string GetProfileValue(string section, string key)
        {
            Xml profile = new Xml(@"resources\HypseusFE.xml");
            return profile.GetValue(section, key).ToString();
        }

        public static void SetProfileValue(string section, string key, string value)
        {
            Xml profile = new Xml(@"resources\HypseusFE.xml");
            profile.SetValue(section, key, value);            
        }
    }
}
