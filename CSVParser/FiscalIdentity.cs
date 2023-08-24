namespace CSVParser
{
    internal class FiscalIdentity
    {
        private readonly string identification;

        public FiscalIdentity(string value)
        {
            identification = value;
        }

        internal bool IsFilled()
        {
            return !string.IsNullOrWhiteSpace(identification);
        }
    }
}