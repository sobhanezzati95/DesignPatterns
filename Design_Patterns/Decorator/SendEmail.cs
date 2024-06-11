namespace Design_Patterns.Decorator
{
    public interface ISendEmail
    {
        void Send();
    }
    public class SendEmail : ISendEmail
    {
        public void Send()
        {
            Console.WriteLine("SendEmail...Send()");
        }
    }

    public class SendEmailDecorator : ISendEmail
    {
        private readonly ISendEmail _sendEmail;

        public SendEmailDecorator(ISendEmail sendEmail)
        {
            _sendEmail = sendEmail;
        }


        public void Send()
        {
            _sendEmail.Send();
            Console.WriteLine("SendEmailDecorator...Send()");
        }
    }

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ISendEmail sendEmail = new SendEmail();
    //        SendEmailDecorator sendEmailDecorator = new SendEmailDecorator(sendEmail);
    //        sendEmailDecorator.Send();
    //    }
    //}
}
