namespace PasswordGenerator
{
    class PasswordCategory
    {
        public static PasswordChecker ActiveDirectory = new()
        {
            Rule  = PasswordRulez.BetterRule,
            Chars = PasswordChars.UserBewareCharset
        };

        public static PasswordChecker Banking = new()
        {
            Rule  = PasswordRulez.MegaSafeRule,
            Chars = PasswordChars.UserBewareCharset
        };

        public static PasswordChecker ServiceAccount = new()
        {
            Rule  = PasswordRulez.MegaSafeRule,
            Chars = PasswordChars.AsciiCharset
        };

        public static PasswordChecker Telephone = new()
        {
            Rule  = PasswordRulez.Sms2FaRule,
            Chars = PasswordChars.NumberCharset
        };

        public static PasswordChecker TelephoneUnsafe = new()
        {
            Rule  = PasswordRulez.Sms2FaUnsafeRule,
            Chars = PasswordChars.NumberCharset
        };

        public static PasswordChecker Java = new()
        {
            Rule  = PasswordRulez.JavaRule,
            Chars = PasswordChars.JavaCharset
        };
    }
}
