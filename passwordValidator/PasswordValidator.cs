namespace passwordValidator
{
    internal class PasswordValidator
    {
        internal bool Validate(string password)
        {
            return IsNotNullNeitherWhiteSpace(password)
                && HasMinimalLength(password)
                && ContainsCapitalLetter(password)
                && ContainsLowerLetter(password)
                && ContainsANumber(password)
                && ContainsUnderscore(password);
        }

        private bool IsNotNullNeitherWhiteSpace(string password)
        {
            return !string.IsNullOrWhiteSpace(password);
        }

        private bool HasMinimalLength(string password)
        {
            return password.Length > 6;
        }        

        private bool ContainsCapitalLetter(string password)
        {
            return password.Any(c => char.IsUpper(c));
        }

        private bool ContainsLowerLetter(string password)
        {
            return password.Any(c => char.IsLower(c));
        }

        private bool ContainsANumber(string password)
        {
            return password.Any(c => char.IsNumber(c));
        }

        private bool ContainsUnderscore(string password)
        {
            return password.Contains("_");
        }
    }
}