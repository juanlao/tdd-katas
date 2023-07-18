namespace passwordValidator
{
    internal class Password
    {
        public Password()
        {
        }

        internal bool Validate(string password)
        {
            return password.Length > 6;
        }
    }
}