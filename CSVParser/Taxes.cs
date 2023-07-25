using System.Runtime.InteropServices;

namespace CSVParser
{
    internal class Taxes
    {
        private readonly Tax iva;
        private readonly Tax igic;

        public Taxes(string iva, string igic)
        {
            this.iva = new Tax(iva);
            this.igic = new Tax(igic);
        }

        internal bool IsValid()
        {
            if (ArePresent(iva, igic)
                && AreValid(iva, igic))
                return true;

            return false;
        }

        private bool AreValid(Tax iva, Tax igic)
        {
            return iva.IsValid() || igic.IsValid();
        }

        private bool ArePresent(Tax iva, Tax igic)
        {
            return iva.Exist || igic.Exist;
        }
    }

    internal class Tax
    {
        private readonly string tax;

        public Tax(string tax)
        {
            this.tax = tax;
        }

        public bool Exist { get => !string.IsNullOrWhiteSpace(tax);}

        internal bool IsValid()
        {
            return decimal.TryParse(tax, out decimal result);
        }
    }
}