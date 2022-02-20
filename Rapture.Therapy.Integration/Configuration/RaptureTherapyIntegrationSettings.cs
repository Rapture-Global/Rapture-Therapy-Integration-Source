namespace Rapture.Therapy.Integration.Configuration
{
    public class RaptureTherapyIntegrationSettings
    {
        public const string SectionName = "RaptureTherapyIntegration";

        public class ApiSettings
        {
            public string ApiBaseUrl { get; set; }
        }

        public ApiSettings Api { get; set; }
    }
}
