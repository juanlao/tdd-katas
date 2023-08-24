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

            cif = new FiscalIdentity(fields[7]);
            nif = new FiscalIdentity(fields[8]);

            netAmmount = fields[3];
            grossAmmount = fields[2];
            Number = fields[0];
        }

        public Taxes Taxes { get; private set; }

        private FiscalIdentity cif;
        private FiscalIdentity nif;
        private string netAmmount;
        private string grossAmmount;

        public string Number { get; private set; }

        internal bool IsValid()
        {
            if (CifAndNifAreFilled())
                return false;

            if (!NetAmmountIsCorrect())
                return false;

            return Taxes.IsValid();
        }

        private bool NetAmmountIsCorrect()
        {
            var grossValue = decimal.Parse(grossAmmount);
            var correctNetAmmount = Taxes.GetNetAmmount(grossValue);

            return correctNetAmmount == netAmmount;
        }

        private bool CifAndNifAreFilled()
        {
            return cif.IsFilled() 
                && nif.IsFilled();
        }
    }
}