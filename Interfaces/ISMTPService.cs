using ASPNET_Site_1.SMTP;

namespace ASPNET_Site_1.Interfaces;

public interface ISMTPService
{
    Task<bool> SendMessageAsync(Message message);
}
