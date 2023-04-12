namespace DependancyInjection.Models
{
    public class MessageClass : IMessageClass
    {

        public string Message { get; set; }

        public MessageClass()
        {
            Message = "This is a message";
        }
    }
}
