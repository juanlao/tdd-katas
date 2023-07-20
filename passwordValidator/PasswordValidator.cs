namespace passwordValidator
{
    internal class PasswordValidator
    {
        internal bool Validate(string password)
        {
            return !string.IsNullOrWhiteSpace(password)
                && password.Length > 6
                && ContainsCapitalLetter(password)
                && ContainsLowerLetter(password)
                && ContainsANumber(password);
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
    }
}