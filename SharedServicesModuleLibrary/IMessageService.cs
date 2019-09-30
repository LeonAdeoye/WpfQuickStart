
namespace SharedServicesModuleLibrary
{
    public interface IMessageService
    {
        bool SendMessage(string url, string payload, string method);
        void SendMessage(string url, string method = "GET");
    }
}
