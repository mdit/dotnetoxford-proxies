using DotNetOxford.ProxyDemo.Model;
using DotNetOxford.ProxyDemo.Services;
using Xunit;

namespace DotNetOxford.ProxyDemo.Tests;

public class UserServiceTests
{
    [Fact]
    public void DisplayUserMessage_ForManager_DisplaysMessageWithUserService()
    {
        var messageService = new MessageService();
        var userService = new UserService(messageService);
        var manager = new EngineeringManager("Dave");

        userService.DisplayUserMessage(manager, "Do some work!");
    }
}