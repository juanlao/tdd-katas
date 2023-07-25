namespace CSVParser
{
    public class CSVParser
    {
        private readonly string content;
        private readonly List<string> lines;

        public CSVParser(string content, List<string> lines)
        {
            this.content = content;
            this.lines = lines;
        }

        internal List<string> InvoiceLines()
        {
            if (this.lines == null)
            {
                return new List<string>();
            }

            var filteredLines = RemoveInvalidLines(this.lines);

            return filteredLines;
        }

        private List<string> RemoveInvalidLines(List<string> lines)
        {
            var filteredLines = new List<string>();
            foreach (var line in lines)
            {
                var invoiceLine = new InvoiceLine(line);

                if (invoiceLine.IsValid())
                {
                    filteredLines.Add(line);
                }
            }

            return filteredLines;
        }
    }
}