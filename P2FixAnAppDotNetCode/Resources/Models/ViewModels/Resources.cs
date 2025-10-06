using System;
using System.Resources;
using System.Reflection;
using System.Globalization;

namespace P2FixAnAppDotNetCode.Resources.Models.ViewModels.Resources
{
    public static class ErrorMessages
    {
        private static ResourceManager resourceManager = new ResourceManager("P2FixAnAppDotNetCode.Resources.Models.ViewModels.Order", Assembly.GetExecutingAssembly());
        private static CultureInfo resourceCulture;

        public static string ErrorMissingName
        {
            get
            {
                return resourceManager.GetString("ErrorMissingName", resourceCulture);
            }
        }
        public static string ErrorMissingAddress
        {
            get
            {
                return resourceManager.GetString("ErrorMissingAddress", resourceCulture);
            }
        }
        public static string ErrorMissingCity
        {
            get
            {
                return resourceManager.GetString("ErrorMissingCity", resourceCulture);
            }
        }
        public static string ErrorMissingCountry
        {
            get
            {
                return resourceManager.GetString("ErrorMissingCountry", resourceCulture);
            }
        }
    }
}

