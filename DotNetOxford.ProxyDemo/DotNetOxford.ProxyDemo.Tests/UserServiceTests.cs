using DotNetOxford.ProxyDemo.Model;
using DotNetOxford.ProxyDemo.Services;
using Moq;
using Xunit;

namespace DotNetOxford.ProxyDemo.Tests;

public class UserServiceTests
{
    [Fact]
    public void DisplayUserMessage_ForManager_DisplaysMessageWithUserService()
    {
        var messageService = new Mock<IMessageService>();
        var userService = new UserService(messageService.Object);
        var manager = new EngineeringManager("Dave");

        userService.DisplayUserMessage(manager, "Do some work!");

        messageService.Verify(x => x.DisplayMessageBox(It.IsAny<string>(), It.IsAny<string>()));
    }
}