namespace Restaurant.Interfaces
{
    public interface IEmailService
    {
        void SendEmail(string emailBody, string emailTo);
    }
}
