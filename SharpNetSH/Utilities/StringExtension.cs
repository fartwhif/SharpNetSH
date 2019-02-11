namespace SharpNetSH.Utilities
{
    public static class StringExtension
    {
        public static bool IsNullOrWhiteSpace(this string value)
        {
            if (string.IsNullOrEmpty(value)) return true;
            if (value.Trim() == string.Empty) return true;
            return false;
        }
    }
}
