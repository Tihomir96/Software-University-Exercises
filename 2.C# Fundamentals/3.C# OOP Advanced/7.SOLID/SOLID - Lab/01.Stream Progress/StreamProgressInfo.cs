namespace _01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private IStreamable stream;

        
        public StreamProgressInfo(File stream)
        {
            this.stream = stream;
        }

        public int CalculateCurrentPercent()
        {
            return (this.stream.BytesSent * 100) / this.stream.Length;
        }
    }
}