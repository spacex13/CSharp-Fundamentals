namespace P01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private IStreamable iStreamable;

        public StreamProgressInfo(IStreamable iStreamable)
        {
            this.iStreamable = iStreamable;
        }

        public int CalculateCurrentPercent()
        {
            return (this.iStreamable.BytesSent * 100) / this.iStreamable.Length;
        }
    }
}
