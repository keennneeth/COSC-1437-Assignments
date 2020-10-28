using System;
using System.Diagnostics;
using System.Net.Http;
/*
 * Kenneth Rodriguez
 */

namespace CoreLibrary
{
    /// <summary>
    ///  Various Extension methods for boolean manipulation
    /// <summary>
   
    public static class BooleanExtension
    {
        public static bool ToBool(this object content, bool defaultValue)
        {
            try
            {
                bool boolResult;

                var conversionSuccessful = (bool.TryParse(content.ToString(), out boolResult));
                
                return conversionSuccessful ? boolResult : defaultValue;
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
                return defaultValue;
            }
        }
    }
}
