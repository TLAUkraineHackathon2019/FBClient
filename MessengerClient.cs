using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using YC.FacebookMessenger.Config;
using YC.FacebookMessenger.Models.Response;

namespace YC.FacebookMessenger
{
    public class MessengerClient : IMessengerClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly MessengerClientConfig _config;
        private readonly ILogger _logger;

        public MessengerClient(IHttpClientFactory httpClientFactory, IOptions<MessengerClientConfig> config, ILoggerFactory loggerFactory)
        {
            _httpClientFactory = httpClientFactory;
            _config = config?.Value;
            _logger = loggerFactory.CreateLogger<MessengerClient>();
        }

        private Uri MessagesEndpoint
        {
            get
            {
                return new Uri(_config.ApiUrl, $"messages?access_token={_config.PageToken}");
            }
        }

        private Uri ProfileEndpoint
        {
            get
            {
                return new Uri(_config.ApiUrl, $"messenger_profile?access_token={_config.PageToken}");
            }
        }

        public Task SendTextMessageAsync(TextMessageRequest request)
        {
            return SendApiRequest(MessagesEndpoint, request);
        }
        
        public Task SendReplyMessageAsync(QuickRepliesRequest request)
        {
            return SendApiRequest(MessagesEndpoint, request);
        }

        public Task UpdateProfileSettings(ProfileSettings settings)
        {
            return SendApiRequest(ProfileEndpoint, settings);
        }

        public Task SendButtonsTemplateAsync(AttachmentMessageRequest<ButtonsTemplatePayload> message)
        {
            return SendApiRequest(MessagesEndpoint, message);
        }

        public Task SendGenericTemplateAsync(AttachmentMessageRequest<GenericTemplatePayload> message)
        {
            return SendApiRequest(MessagesEndpoint, message);
        }

        public Task SendListTemplateAsync(AttachmentMessageRequest<ListTemplatePayload> message)
        {
            return SendApiRequest(MessagesEndpoint, message);
        }

        public Task SendAttachmentTemplateAsync(AttachmentMessageRequest<AttachmentTemplatePayload> message)
        {
            return SendApiRequest(MessagesEndpoint,  message);
        }

        public Task SendChatActionAsync(ActionRequest message)
        {
            return SendApiRequest(MessagesEndpoint, message);
        }

        private async Task SendApiRequest(Uri url, object payload)
        {
            string content = JsonConvert.SerializeObject(payload);

            using (var message = new HttpRequestMessage(HttpMethod.Post, url))
            {
                using (var stringContent = new StringContent(content, Encoding.UTF8, "application/json"))
                {
                    message.Content = stringContent;

                    using (var response = await _httpClientFactory.CreateClient().SendAsync(message))
                    {
                        string responseMessage = await response.Content.ReadAsStringAsync();

                        try
                        {
                            response.EnsureSuccessStatusCode();
                        }
                        catch (Exception)
                        {
                            _logger.LogError($"API requets error. Request: {content}\r\nresplonse: {responseMessage}");
                            throw;
                        }
                    }
                }
            }
        }
    }
}
