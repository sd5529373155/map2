
namespace map2
{
    internal class GeolocationRequset
    {
        private GeolocationAccuracy high;
        private TimeSpan timeSpan;

        public GeolocationRequset(GeolocationAccuracy high, TimeSpan timeSpan)
        {
            this.high = high;
            this.timeSpan = timeSpan;
        }
    }
}