/*
 * Kenneth Rodriguez
 */

namespace CoreLibrary.Extensions
{
   public static class StringExtension
    {
        public static bool IsNullOrWhiteSpace(this string content)
        {
            return string.IsNullOrWhiteSpace(content);
        }

        public static bool IsNullOrEmpty(this string content)
        {
            return string.IsNullOrEmpty(content);
        }

        public static string Left(this string content, int numCharacters)
        {
            if (content == null) return null;

            if (content.Length < numCharacters) return content;

            return content.Substring(
                startIndex: 0,
                length: numCharacters);
        }

        public static string Right(this string content, int numCharacters)
        {
            if (content == null) return null;

            if (content.Length < numCharacters) return content;

            return content.Substring(
                startIndex: content.Length - numCharacters,
                length: numCharacters);
        }

    }
}