namespace CSVParser
{
    public class CSVParser_Should
    {
        [Fact]
        public void ParseSameLinesWhenCorrect()
        {
            var validContent = @"Num_Factura, Fecha, Bruto, Neto, IVA, IGIC, Concepto, CIF_cliente, NIF_cliente
1,02/05/2019,1008,810,19,,ACERLaptop,B76430134,";

            var parser = new CSVParser(validContent);

            parser.Parse()
                .Should()
                .Be(validContent);
        }

        [Fact]
        public void RemoveLinesWithSameInvoiceNumber()
        {
            Assert.Fail("TODO");
        }

        [Fact]
        public void RemoveLinesWithCIFAndNIFSet()
        {
            Assert.Fail("TODO");
        }

        [Fact]
        public void RemoveLinesWhenTaxesAreNotCorrectlyApplied()
        {
            Assert.Fail("TODO");
        }

        [Fact]
        public void NoInvoiceDataCanBeParsed()
        {
            var validContent = @"Num_Factura, Fecha, Bruto, Neto, IVA, IGIC, Concepto, CIF_cliente, NIF_cliente";

            var parser = new CSVParser(validContent);

            parser.Parse()
                .Should()
                .Be(validContent);
        }

    }
}
}