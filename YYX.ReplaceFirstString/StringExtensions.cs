namespace YYX.ReplaceFirstString
{
    public static class StringExtensions
    {
        public static string ReplaceFirst(this string input, string oldValue, string newValue)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            if (oldValue == null)
            {
                throw new ArgumentNullException("oldValue");
            }

            if (newValue == null)
            {
                throw new ArgumentNullException("newValue");
            }

            int index = input.IndexOf(oldValue, StringComparison.Ordinal);
            if (index == -1)
            {
                return input;
            }

            string preString = input.Substring(0, index);
            string endString = input.Substring(index + oldValue.Length);
            string result = string.Format("{0}{1}{2}", preString, newValue, endString);
            return result;
        }
    }
}
