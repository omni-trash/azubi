namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var passgen = new PasswordGenerator();

            // **********************************************
            passgen.Checker = PasswordCategory.ActiveDirectory;

            PrintChecker("ActiveDirectory", passgen.Checker);

            for (var i = 0; i < 10; i++)
            {
                string password = passgen.CreatePassword();
                Console.WriteLine($"password is: {password}");
            }

            // **********************************************
            passgen.Checker = PasswordCategory.Banking;

            PrintChecker("Banking", passgen.Checker);

            for (var i = 0; i < 10; i++)
            {
                string password = passgen.CreatePassword();
                Console.WriteLine($"password is: {password}");
            }

            // **********************************************
            passgen.Checker = PasswordCategory.ServiceAccount;

            PrintChecker("ServiceAccount", passgen.Checker);

            for (var i = 0; i < 10; i++)
            {
                string password = passgen.CreatePassword();
                Console.WriteLine($"password is: {password}");
            }

            // **********************************************
            passgen.Checker = PasswordCategory.Telephone;

            PrintChecker("Telephone", passgen.Checker);

            for (var i = 0; i < 10; i++)
            {
                string password = passgen.CreatePassword();
                Console.WriteLine($"password is: {password}");
            }

            // **********************************************
            passgen.Checker = PasswordCategory.TelephoneUnsafe;

            PrintChecker("TelephoneUnsafe", passgen.Checker);

            for (var i = 0; i < 10; i++)
            {
                string password = passgen.CreatePassword();
                Console.WriteLine($"password is: {password}");
            }

            // **********************************************
            passgen.Checker = PasswordCategory.Java;

            PrintChecker("Java", passgen.Checker);

            for (var i = 0; i < 10; i++)
            {
                string password = passgen.CreatePassword();
                Console.WriteLine($"password is: {password}");
            }
        }

        static void PrintChecker(string name, PasswordChecker checker)
        {
            Console.WriteLine($"-------------------------");
            Console.WriteLine(name);
            Console.WriteLine($"");
            PrintRule(checker.Rule);
            PrintChars(checker.Chars);
        }

        static void PrintRule(PasswordChecker.Spec rule)
        {
            Console.WriteLine("Rule:");
            Console.WriteLine($"length  {rule.length}");
            Console.WriteLine($"lower   {rule.lower}");
            Console.WriteLine($"upper   {rule.upper}");
            Console.WriteLine($"digit   {rule.digit}");
            Console.WriteLine($"special {rule.special}");
            Console.WriteLine($"unknown {rule.unknown}");
            Console.WriteLine($"");
        }

        static void PrintChars(PasswordChecker.Charset chars)
        {
            Console.WriteLine("Charset:");
            Console.WriteLine($"lower   {chars.lower}");
            Console.WriteLine($"upper   {chars.upper}");
            Console.WriteLine($"digit   {chars.digit}");
            Console.WriteLine($"special {chars.special}");
            Console.WriteLine($"");
        }
    }
}