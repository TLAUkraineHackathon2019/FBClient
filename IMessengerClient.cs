using System.Threading.Tasks;
using YC.FacebookMessenger.Models.Response;

namespace YC.FacebookMessenger
{
    public interface IMessengerClient
    {
        Task SendTextMessageAsync(TextMessageRequest request);
        Task SendReplyMessageAsync(QuickRepliesRequest request);
        Task UpdateProfileSettings(ProfileSettings settings);
        Task SendButtonsTemplateAsync(AttachmentMessageRequest<ButtonsTemplatePayload> message);
        Task SendGenericTemplateAsync(AttachmentMessageRequest<GenericTemplatePayload> message);
        Task SendListTemplateAsync(AttachmentMessageRequest<ListTemplatePayload> message);
        Task SendAttachmentTemplateAsync(AttachmentMessageRequest<AttachmentTemplatePayload> message);
        Task SendChatActionAsync(ActionRequest message);
    }
}
