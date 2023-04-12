namespace DependancyInjection.Models.Interfaces
{
    public interface IGoodNightMessage
    {
        public string Message { get; set; }

        public string MessageToSend()
        {
            return "Good Night User!";
        }
    }
}
