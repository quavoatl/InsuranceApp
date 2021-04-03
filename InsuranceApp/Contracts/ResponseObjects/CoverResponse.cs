namespace InsuranceApp.Contracts.ResponseObjects
{
    public class CoverResponse
    {
        public int CoverId { get; set; }
        public string BrokerId { get; set; }
        public string Type { get; set; }
        public double LimitMultiplier { get; set; }
    }
}