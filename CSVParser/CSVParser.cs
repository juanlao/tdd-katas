namespace CSVParser
{
    public class CSVParser
    {
        private string content;

        public CSVParser(string content)
        {
            this.content = content;
        }

        internal string Parse()
        {
            return content;
        }
    }
}