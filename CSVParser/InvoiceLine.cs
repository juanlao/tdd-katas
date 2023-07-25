namespace CSVParser
{
    internal class InvoiceLine
    {

        public InvoiceLine(string line)
        {
            var fields = line.Split(',');

            var iva = fields[4];
            var igic = fields[5];

            Taxes = new Taxes(iva, igic);
        }

        public Taxes Taxes { get; private set; }

        internal bool IsValid()
        {
            return Taxes.IsValid();
        }
    }
}