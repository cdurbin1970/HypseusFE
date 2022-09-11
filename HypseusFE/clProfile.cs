using System;
using AMS.Profile;
using LogEntry;

namespace HypseusFE
{
    internal class clProfile
    {
        public static string GetProfileValue(string section, string key)
        {
            try
            {
                Xml profile = new Xml(@"resources\HypseusFE.xml");
                return profile.GetValue(section, key).ToString();
            }
            catch (Exception)
            {
                ClLogEntry.WriteLogEntry("Unable to read Section: " + section + " Key: " + key);
                return string.Empty;
            }
        }

        public static void SetProfileValue(string section, string key, string value)
        {
            try
            {
                Xml profile = new Xml(@"resources\HypseusFE.xml");
                profile.SetValue(section, key, value);
            }
            catch (Exception) {
                ClLogEntry.WriteLogEntry("Unable to write Section: " + section + " Key: " + key + " Value: " + value);
            }           
        }
    }
}
