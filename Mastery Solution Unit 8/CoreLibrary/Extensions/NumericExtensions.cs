using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CoreLibrary
{
    public static class NumericExtensions
    {
        /// <summary>
        /// Safely converts an object into a standard int, or assigns a default value
        /// </summary>
        /// <author> Kenneth Rodriguez </author>
        /// <param name="content" >extended object variable </param>
        /// <param name="defaultValue" >value to return if not convertible </param>
        /// <returns> either the converted value, or the default </returns>

        public static int ToInt(this object content, int defaultValue = 0)
        {
            try
            {
                int intResult;
                if (int.TryParse(content.ToString(), out intResult)) return intResult;

                double dblResult;
                if (double.TryParse(content.ToString(), out dblResult))
                {
                    var forceSuccessfulConversionToInteger = Convert.ToInt32(dblResult);
                    return forceSuccessfulConversionToInteger;
                }

                return defaultValue;
            }
            catch
            {
                return defaultValue;
            }
        }
    }
}
