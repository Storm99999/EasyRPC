using DiscordRPC;

namespace EasyRPC
{
    public class RPC
    {
        public static DiscordRpcClient client;
        public static void ActivateRPC(string applicationId, string state, string buttonText, string buttonUrl, string details, string largeImageKey, string LargeImageText)
        {
            ButtonText = buttonText;
            ButtonUrl = buttonUrl;
            State = state;
            Details = details;
            LargeImageKey1 = largeImageKey;
            LargeImageText1 = LargeImageText;
            RPC.client = new DiscordRpcClient(applicationId);
            RPC.client.Initialize();
            RPC.SetState(state, false);
        }

        public static string ButtonText = "";
        public static string ButtonUrl = "";
        public static string Details = "";
        public static string State = "";
        public static string LargeImageKey1 = "";
        public static string LargeImageText1 = "";
        private static void SetState(string state, bool watching)
        {
            DiscordRpcClient client = RPC.client;
            RichPresence presence = new RichPresence();
            Button[] buttonArray = new Button[1]
            {
                new Button()
                {
                    Label = ButtonText,
                    Url = ButtonUrl
                }
            };
            presence.Details = Details;
            presence.State = State;
            presence.Assets = new Assets()
            {
                LargeImageKey = LargeImageKey1,
                LargeImageText = LargeImageText1,
            };
            presence.Buttons = buttonArray;
            client.SetPresence(presence);
        }
    }
}