namespace PasswordGenerator
{
    class PasswordChars
    {
        public static PasswordChecker.Charset AsciiCharset = new()
        {
            lower   = "abcdefghijklmnopqrstuvwxyz",
            upper   = "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            digit   = "0123456789",
            special = "?=/&%$!#"
        };

        public static PasswordChecker.Charset NumberCharset = new()
        {
            lower   = "",
            upper   = "",
            digit   = "0123456789",
            special = ""
        };

        public static PasswordChecker.Charset UserBewareCharset = new()
        {
            lower   = "abcdefghjkmnpqrstuvwxyz",
            upper   = "ABCDEFGHJKLMNPQRSTUVWXYZ",
            digit   = "23456789",
            special = "=/&%$!#"
        };

        public static PasswordChecker.Charset JavaCharset = new()
        {
            lower   = "abcdef",
            upper   = "",
            digit   = "0123456789",
            special = ""
        };

        public static PasswordChecker.Charset DefaultCharset = AsciiCharset;
    }
}
