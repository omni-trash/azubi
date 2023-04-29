namespace PasswordGenerator
{
    class PasswordRulez
    {
        public static PasswordChecker.Spec SimpleRule = new()
        {
            length  = 0,
            lower   = 3,
            upper   = 3,
            digit   = 1,
            special = 1,
            unknown = 0
        };

        public static PasswordChecker.Spec BetterRule = new()
        {
            length  = 12,
            lower   = 4,
            upper   = 4,
            digit   = 2,
            special = 1,
            unknown = 0
        };

        // sure? to be discuss (entropy)
        public static PasswordChecker.Spec MegaSafeRule = new()
        {
            length  = 24,
            lower   = 8,
            upper   = 8,
            digit   = 6,
            special = 2,
            unknown = 0
        };

        public static PasswordChecker.Spec NumberRule = new()
        {
            length  = 0,
            lower   = 0,
            upper   = 0,
            digit   = 12,
            special = 0,
            unknown = 0
        };

        public static PasswordChecker.Spec Sms2FaRule = new()
        {
            length  = 0,
            lower   = 0,
            upper   = 0,
            digit   = 6,
            special = 0,
            unknown = 0
        };

        public static PasswordChecker.Spec Sms2FaUnsafeRule = new()
        {
            length  = 0,
            lower   = 0,
            upper   = 0,
            digit   = 3,
            special = 0,
            unknown = 0
        };

        public static PasswordChecker.Spec JavaRule = new()
        {
            length  = 10,
            lower   = 0,
            upper   = 0,
            digit   = 0,
            special = 0,
            unknown = 0
        };

        public static PasswordChecker.Spec DefaultRule = SimpleRule;
    }
}
