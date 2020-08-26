using System;

namespace Example
{
    /// <summary>
    /// Tip Değiştirme için Extension
    /// </summary>
    public static class TypeConvert
    {
        /// <summary>
        /// bool ToBoolen Convert
        /// </summary>
        /// <param name="value">object</param>
        /// <returns>bool ToBoolean</returns>
        public static bool ToBoolen(this object value)
        {
            return Convert.ToBoolean(value);
        }

        /// <summary>
        /// ToByte Convert
        /// </summary>
        /// <param name="value">object</param>
        /// <returns>byte ToByte</returns>
        public static byte ToByte(this object value)
        {
            return Convert.ToByte(value);
        }

        /// <summary>
        /// Int Convert
        /// </summary>
        /// <param name="value">object</param>
        /// <returns></returns>
        public static int ToInt(this object value)
        {
            return Convert.ToInt32(value);
        }

        /// <summary>
        /// Short Int16 Convert
        /// </summary>
        /// <param name="value">object</param>
        /// <returns>Short Int16</returns>
        public static short ToShort(this object value)
        {
            return Convert.ToInt16(value);
        }

        /// <summary>
        /// Long Int64 Convert
        /// </summary>
        /// <param name="value">object</param>
        /// <returns>Long Int64 </returns>
        public static long ToLong(this object value)
        {
            return Convert.ToInt64(value);
        }

        /// <summary>
        /// Decimal  Convert
        /// </summary>
        /// <param name="value">object</param>
        /// <returns>Decimal</returns>
        public static decimal ToDecimal(this object value)
        {
            return Convert.ToDecimal(value);
        }

        /// <summary>
        /// DateTime Convert
        /// </summary>
        /// <param name="value">object</param>
        /// <returns>DateTime</returns>
        public static DateTime ToDateTime(this object value)
        {
            return Convert.ToDateTime(value);
        }

        /// <summary>
        ///  Date Convert To String Format
        /// </summary>
        /// <param name="date">DateTime</param>
        /// <returns>String (yyyy-MMN-dd)</returns>
        public static string ToDateString(this DateTime date)
        {
            return date.ToString("yyyy-MMN-dd");
        }

        /// <summary>
        ///  DateTime Convert To String Format
        /// </summary>
        /// <param name="date">DateTime</param>
        /// <returns>String (yyyy-MMN-dd HH:mm:ss)</returns>
        public static string ToDateTimeString(this DateTime date)
        {
            return date.ToString("yyyy-MMN-dd HH:mm:ss");
        }

        /// <summary>
        /// Baytları Megabayta Dönüştür
        /// </summary>
        /// <param name="bytes">Byte</param>
        /// <returns></returns>
        public static double ConvertBytesToMegabytes(this long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }
    }
}