namespace CSVParser
{
    internal class Taxes
    {
        private string iva;
        private string igic;

        public Taxes(string iva, string igic)
        {
            this.iva = iva;
            this.igic = igic;
        }

        internal bool IsValid()
        {
            if (AreNotPresent(iva, igic))
                return false;

            return true;
        }

        private bool AreNotPresent(string iva, string igic)
        {
            return string.IsNullOrWhiteSpace(iva)
                && string.IsNullOrWhiteSpace(igic);
        }
    }
}