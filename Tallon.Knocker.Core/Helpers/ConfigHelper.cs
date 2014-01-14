using System.Configuration;

namespace Tallon.Knocker.Core.Helpers
{
    public static class ConfigHelper
    {
        public static string PortName
        {
            get { return ConfigurationManager.AppSettings["PortName"]; }
        }

        public static int BaudRate
        {
            get
            {
                var configData = ConfigurationManager.AppSettings["BaudRate"];
                int result;
                int.TryParse(configData, out result);
                return result;
            }
        }
    }
}
