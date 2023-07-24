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

        internal List<string> filteredLines()
        {
            if(this.lines == null)
            {
                return new List<string>();
            }

            var filteredLines = RemoveLinesWhereIVANeitherIGICArePresent(this.lines);

            return filteredLines;
        }

        private List<string> RemoveLinesWhereIVANeitherIGICArePresent(List<string> lines)
        {
            var filteredLines = new List<string>();
            foreach(var line in lines)
            {
                var fields = line.Split(',');
                var iva = fields[4];
                var igic = fields[5];
                if (string.IsNullOrWhiteSpace(iva)
                    && string.IsNullOrWhiteSpace(igic))
                {
                    break;
                }

                filteredLines.Add(line);
            }

            return filteredLines;
        }
    }
}