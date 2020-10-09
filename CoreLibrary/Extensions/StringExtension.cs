namespace CoreLibrary // I deleted ".Extensions" since I couldn't figure out extensions folder namepsace provider
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

        /// <summary>
        /// The Right extension method encapsulates the process of extracting the right-hand
        /// characters from the source content while handling possible error conditions.
        /// </summary>
        /// <param name="content">source content from string extension</param>
        /// <param name="numCharacters">the integer number of characters to return</param>
        /// <returns>the content, stripped to the designated number of characters</returns>
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