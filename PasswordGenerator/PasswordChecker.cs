namespace PasswordGenerator
{
    class PasswordChecker
    {
        public struct Spec
        {
            public int length;
            public int lower;
            public int upper;
            public int digit;
            public int special;
            public int unknown;

            public int RequiredLength()
            {
                return Math.Max(length, lower + upper + digit + special);
            }
        }

        public struct Charset
        {
            public string lower;
            public string upper;
            public string digit;
            public string special;

            public string All()
            {
                return string.Concat(lower, upper, digit, special);
            }
        }

        /// <summary>
        /// Rule to use
        /// </summary>
        public Spec Rule { get; set; } = PasswordRulez.DefaultRule;

        /// <summary>
        /// Charset to use
        /// </summary>
        public Charset Chars { get; set; } = PasswordChars.DefaultCharset;

        void ValidateSelf()
        {
            bool isIncompatible = (
                (Rule.lower   > 0 && Chars.lower.Length   == 0) ||
                (Rule.upper   > 0 && Chars.upper.Length   == 0) ||
                (Rule.digit   > 0 && Chars.digit.Length   == 0) ||
                (Rule.special > 0 && Chars.special.Length == 0)
            );

            if (isIncompatible)
            {
                throw new InvalidOperationException("Rule and Chars are not compatible");
            }
        }

        // Returns true when password is ok for the rule we use
        public bool IsPasswordOk(string password)
        {
            ValidateSelf();
            return CheckSpec(GetSpec(password));
        }

        // Metric Analyse
        Spec GetSpec(string password)
        {
            Spec spec = new();

            spec.length = password.Length;

            foreach (var c in password)
            {
                if (Chars.lower.Contains(c))
                {
                    ++spec.lower;
                    continue;
                }

                if (Chars.upper.Contains(c))
                {
                    ++spec.upper;
                    continue;
                }

                if (Chars.digit.Contains(c))
                {
                    ++spec.digit;
                    continue;
                }

                if (Chars.special.Contains(c))
                {
                    ++spec.special;
                    continue;
                }

                ++spec.unknown;
            }

            return spec;
        }

        // Returns true when spec is valid by rule
        bool CheckSpec(Spec spec)
        {
            bool isWrong = (
                spec.length  < Rule.length  ||
                spec.lower   < Rule.lower   ||
                spec.upper   < Rule.upper   ||
                spec.digit   < Rule.digit   ||
                spec.special < Rule.special ||
                spec.unknown > 0
            );

            return !isWrong;
        }
    }
}
