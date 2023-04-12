using DependancyInjection.Models.Interfaces;

namespace DependancyInjection.Models
{
    public class GoodMorningMessage : IGoodMorningMessage
    {
        public string Message { get; set; }

        public GoodMorningMessage()
        {
            Message = "Good Morning User!";
        }

    }
}
