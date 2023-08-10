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

        internal List<InvoiceLine> InvoiceLines()
        {
            if (this.lines == null)
            {
                return new List<InvoiceLine>();
            }

            var allLines = lines.Select(c => new InvoiceLine(c)).ToList();
            var validLines = RemoveInvalidLines(allLines);

            validLines = RemoveRepeated(validLines);

            return validLines;
        }

        private List<InvoiceLine> RemoveRepeated(List<InvoiceLine> validLines)
        {
            var unrepeated = validLines.DistinctBy(c => c.Number)
                .ToList();

            return unrepeated;
        }

        private List<InvoiceLine> RemoveInvalidLines(List<InvoiceLine> lines)
        {
            var filteredLines = new List<InvoiceLine>();
            foreach (var line in lines)
            {
                if (line.IsValid())
                {
                    filteredLines.Add(line);
                }
            }

            return filteredLines;
        }
    }
}