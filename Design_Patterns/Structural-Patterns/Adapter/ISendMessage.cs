namespace Design_Patterns.Structural_Patterns.Adapter
{
    public interface ISendMessage
    {
        void Send(string message);
    }
    public class Telegram : ISendMessage
    {
        public void Send(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine($"Send Message With {nameof(Telegram)}  class....");
        }
    }
    public class Whatsapp : ISendMessage
    {
        public void Send(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine($"Send Message With {nameof(Whatsapp)}  class....");
        }
    }
    public class GmailAdapter : ISendMessage
    {
        private readonly GmailServiceGoogle _gmailService;
        public GmailAdapter(GmailServiceGoogle gmailService)
        {
            _gmailService = gmailService;

        }
        public void Send(string Text)
        {
            _gmailService.SendMail(Text);
        }
    }
    public class GmailServiceGoogle
    {
        public void SendMail(string Text)
        {
            Console.WriteLine(Text);
            Console.WriteLine($"Send Message With {nameof(GmailServiceGoogle)}  class....");
        }
    }

    //static void Main(string[] args)
    //{
    //    ISendMessage telegram = new Telegram();
    //    telegram.Send("my test message");
    //
    //    ISendMessage whatsapp = new Whatsapp();
    //    whatsapp.Send("my message");
    //
    //    GmailServiceGoogle gmailServiceGoogle = new GmailServiceGoogle();
    //    ISendMessage gmail = new GmailAdapter(gmailServiceGoogle);
    //
    //    gmail.Send("my test message ");
    //}
}
