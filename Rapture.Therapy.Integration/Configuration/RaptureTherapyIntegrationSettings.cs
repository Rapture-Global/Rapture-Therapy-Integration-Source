namespace Rapture.Therapy.Integration.Configuration
{
    public class RaptureTherapyIntegrationSettings
    {
        public const string SectionName = "RaptureTherapyIntegration";

        public class ApiSettings
        {
            public string BaseUrl { get; set; }
        }

        public ApiSettings Api { get; set; }
    }
}
