namespace Twitch
{
    public class TwitchClient
    {
        public string ID { get; }
        public string Secret { get; }
        public TwitchClient(string id, string secret)
        {
            ID = id;
            Secret = secret;    
        }  
    }
}