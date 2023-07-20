namespace passwordValidator
{
    internal class Password
    {
        public Password(string password) :
            this(password, new PasswordValidator())
        {
        }

        private Password(
            string password,
            PasswordValidator validator)
        {
            IsValid = validator.Validate(password);
        }

        public bool IsValid { get; internal set; }
    }
}