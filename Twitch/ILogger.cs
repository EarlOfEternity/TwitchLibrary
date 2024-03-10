namespace Twitch
{
    public interface ILogger    
    {
        void ErrorLog(string message) { }
        void FlowLog(HttpRequestMessage req, HttpResponseMessage resp) { }
    }

}
