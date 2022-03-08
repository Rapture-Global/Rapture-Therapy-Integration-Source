using Eadent.Common.WebApi.ApiClient;
using Eadent.Common.WebApi.DataTransferObjects.Sessions.Users;
using Eadent.Common.WebApi.Definitions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Rapture.Therapy.Integration.Configuration;

namespace Rapture.Therapy.Integration
{
    public partial class MainForm : Form
    {
        private ILoggerFactory LoggerFactory { get; }

        private ILogger Logger { get; }

        private RaptureTherapyIntegrationSettings AppSettings { get; }

        public MainForm(ILoggerFactory loggerFactory, RaptureTherapyIntegrationSettings appSettings)
        {
            LoggerFactory = loggerFactory;

            Logger = loggerFactory.CreateLogger<MainForm>();

            AppSettings = appSettings;

            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void ButtonDevelopment_Click(object sender, EventArgs e)
        {
            using (var apiClient = new ApiClientJson(Logger, AppSettings.Api.BaseUrl))
            {
                var requestDto = new UserSessionSignInRequestDto()
                {
                    EMailAddress = "Eamonn@Duffy.global",
                    PlainTextPassword = "Eamonn123456"
                };

                var signInResponse = await apiClient.PostAsync<UserSessionSignInRequestDto, UserSessionSignInResponseDto>("/Users/Sessions", requestDto, null);

                if ((signInResponse.HttpStatusCode == StatusCodes.Status201Created) &&
                    (signInResponse.ResponseDto.DeveloperCode == (long)CommonDeveloperCode.Success))
                {
                    var optionalHeaders = new ApiHeaders
                    {
                        { EadentHeaders.SessionTokenName, signInResponse.ResponseDto.SessionToken }
                    };

                    var signOutResponse = await apiClient.DeleteAsync<UserSessionSignOutResponseDto>("/Users/Sessions", optionalHeaders);
                }
            }
        }
    }
}