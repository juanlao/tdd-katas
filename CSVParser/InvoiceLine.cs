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

            cif = fields[7];
            nif = fields[8];

            Number = fields[0];
        }

        public Taxes Taxes { get; private set; }

        private string cif;

        public string Number { get; private set; }

        internal bool IsValid()
        {
            return Taxes.IsValid();
        }
    }
}