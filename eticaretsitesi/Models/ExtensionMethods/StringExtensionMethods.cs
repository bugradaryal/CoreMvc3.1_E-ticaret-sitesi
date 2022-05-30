using System.Text;

namespace eticaretsitesi.Models
{
    public static class StringExtensions
    {
        public static string Slug(this string s)
        {
            var sb = new StringBuilder();
            foreach (var c in s)
            {
                if (!char.IsPunctuation(c) || c == '-')
                {
                    sb.Append(c);
                }
            }

            return sb.ToString().Replace(' ', '-').ToLower();
        }
        public static bool EqualsNoCase(this string s, string toCompare)
        {
            return s?.ToLower() == toCompare?.ToLower();
        }
        public static int ToInt(this string s)
        {
            int.TryParse(s, out var id);
            return id;
        }
        public static string Capitalize(this string s)
        {
            return s?.Substring(0, 1)?.ToUpper() + s?.Substring(1);
        }
    }
}