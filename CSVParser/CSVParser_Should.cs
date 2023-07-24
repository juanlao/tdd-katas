namespace CSVParser
{
    public class CSVParser_Should
    {
        private string header = @"Num_Factura, Fecha, Bruto, Neto, IVA, IGIC, Concepto, CIF_cliente, NIF_cliente";

        [Fact]
        public void ParseSameLinesWhenCorrect()
        {
            var validLine = "1,02/05/2019,1008,810,19,,ACERLaptop,B76430134,";
            var lines = new List<string> { validLine };

            var parser = new CSVParser(header, lines);

            parser.filteredLines()
                .First()
                .Should()
                .Be(validLine);
        }

        [Fact]
        public void RemoveLinesWhenIVAAndIGICareNotSet()
        {
            var lineWithoutTaxes = "1,02/05/2019,1008,810,,,ACERLaptop,B76430134,";
            var lines = new List<string> { lineWithoutTaxes };

            var parser = new CSVParser(header, lines);

            parser.filteredLines()
                .Should()
                .BeEmpty();
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
            var parser = new CSVParser(header, null);

            parser.filteredLines()
                .Should()
                .BeEmpty();
        }

        [Fact]
        public void WhenThereIsNoHeader()
        {
            Assert.Fail("TODO");
        }
    }
}
