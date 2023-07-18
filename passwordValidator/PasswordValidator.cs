namespace passwordValidator
{
    internal class PasswordValidator
    {
        public PasswordValidator()
        {
        }

        internal bool Validate(string password)
        {
            return password.Length > 6;
        }
    }
}