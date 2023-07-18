namespace passwordValidator
{
    internal class Password
    {
        public Password(string password)
        {
            IsValid = Validate(password);
        }

        public bool IsValid { get; internal set; }

        internal bool Validate(string password)
        {
            return password.Length > 6;
        }
    }
}