namespace LoginPassCheck
{
    static class LoginPassCheck
    {   /// <summary>
        /// Checks - does string consist of Latins.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsLatin(this string str)
        {
            bool isCorrect = true;

            for (int i = 0; i < str.Length; i++)
            {
                int chCode = (int)str[i];

                bool isLatin = (chCode >= (int)'A' && chCode <= (int)'Z') ||
                               (chCode >= (int)'a' && chCode <= (int)'z');

                if (!isLatin) isCorrect = false;
            }
            return isCorrect;
        }

        /// <summary>
        /// Checks - does string consist of Numbers ans Symbols.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNumSymb(this string str)
        {
            bool isCorrect = true;

            for (int i = 0; i < str.Length; i++)
            {
                int chCode = (int)str[i];

                bool isNumSymb = (chCode >= (int)'!' && chCode <= (int)'@');

                if (!isNumSymb) isCorrect = false;
            }
            return isCorrect;
        }
    }
}
