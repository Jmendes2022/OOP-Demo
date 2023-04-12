using System;

namespace OOPdemo
{
    public class Message
    {
        private string PrivateMessage { get { return PrivateMessage; } set { PrivateMessage = "This is a private message"; } }

        public string PublicMessage { get { return PublicMessage; } set { PublicMessage = "This is a public message"; } }

        

        public string pubMessage()
        {
            return PublicMessage;
            
        }

        public string privMessage()
        {
            return PrivateMessage;
        }
    }
}
