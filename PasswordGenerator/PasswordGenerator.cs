﻿using System.Text;

namespace PasswordGenerator
{
    class PasswordGenerator
    {
        // Pseudo-Zufallszahlen Generator
        static Random random = new Random();

        public PasswordChecker Checker { get; set; } = new();

        void AppendRandom(StringBuilder sb, string source, int count)
        {
            if (source.Length == 0)
            {
                // invalid source
                return;
            }

            while (count-- > 0)
            {
                int index = (int)(random.NextDouble() * source.Length);
                sb.Append(source[index]);
            }
        }

        public string CreatePassword()
        {
            // Maybe Rule.length is not set
            int len = Checker.Rule.RequiredLength();

            if (len == 0)
            {
                return string.Empty;
            }

            StringBuilder sb = new();

            // Fill out with minimal requirements
            AppendRandom(sb, Checker.Chars.lower,   Checker.Rule.lower);
            AppendRandom(sb, Checker.Chars.upper,   Checker.Rule.upper);
            AppendRandom(sb, Checker.Chars.digit,   Checker.Rule.digit);
            AppendRandom(sb, Checker.Chars.special, Checker.Rule.special);

            // Fill out to length
            while (sb.Length < Checker.Rule.length)
            {
                AppendRandom(sb, Checker.Chars.lower,   1);
                AppendRandom(sb, Checker.Chars.upper,   1);
                AppendRandom(sb, Checker.Chars.digit,   1);
                AppendRandom(sb, Checker.Chars.special, 1);
            }

            // Take the char array (beware min requirements are not truncated)
            char[] chars = sb.ToString().Substring(0, len).ToCharArray();
            Shuffle(chars, 1_000);

            string password = new string(chars);

            // We have to pass
            if (!Checker.IsPasswordOk(password))
            {
                throw new InvalidOperationException("Unable to generate password");
            }

            return password;
        }

        void Shuffle(char[] chars, int loops)
        {
            // Shuffle chars
            for (int i = 0; i < loops; ++i)
            {
                int ix1 = (int)(random.NextDouble() * chars.Length);
                int ix2 = (int)(random.NextDouble() * chars.Length);

                // Use tuple to swap values
                (chars[ix2], chars[ix1]) = (chars[ix1], chars[ix2]);
            }
        }
    }
}
