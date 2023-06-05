using DotNetOxford.ProxyDemo.Model;

namespace DotNetOxford.ProxyDemo.Services
{
    public class UserService
    {
        private readonly IMessageService _messageService;

        public UserService(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void DisplayUserMessage(DevTeamMember member, string message)
        {
            _messageService.DisplayMessageBox(
                $"{member.Name} ({member.RoleName}): {message}",
                "Dev Team Member message");
        }
    }
}
