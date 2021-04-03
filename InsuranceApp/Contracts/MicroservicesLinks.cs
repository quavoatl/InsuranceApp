namespace InsuranceApp.Contracts
{
    public static class MicroservicesLinks
    {
        public const string Root = "api";
        public const string Version = "v1";
        public const string Base = Root + "/" + Version;

        public static class Limits
        {
            public const string Host = "https://localhost:5001/";

            public const string GetAll = Host + Base + "/limits";
        }
        
        public static class Covers
        {
            public const string Host = "https://localhost:5045/";

            public const string GetAll = Host + Base + "/covers";
        }
        
    }
}