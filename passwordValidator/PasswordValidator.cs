namespace passwordValidator
{
    internal class PasswordValidator
    {
        internal bool Validate(string password)
        {
            return !string.IsNullOrWhiteSpace(password)
                && password.Length > 6
                && ContainsCapitalLetter(password);
        }

        private bool ContainsCapitalLetter(string password)
        {
            return password.Any(c => char.IsUpper(c));
        }
    }
}