using System.Web;

namespace Twitch.Authentication
{
    public class TwitchAcessScopes
    {
       private bool _analyticsReadExtensions = false;
       private bool _analyticsReadGames = false;
       private bool _bitsRead = false;
       private bool _channelManageAds = false;
       private bool _channelReadAds = false;
       private bool _channelManageBroadcast = false;
       private bool _channelReadCharity = false;
       private bool _channelEditCommercial = false;
       private bool _channelReadEditors = false;
       private bool _channelManageExtensions = false;
       private bool _channelReadGoals = false;
       private bool _channelReadGuestStar = false;
       private bool _channelManageGuestStar = false;
       private bool _channelReadHypeTrain = false;
       private bool _channelManageModerators = false;
       private bool _channelReadPolls = false;
       private bool _channelManagePolls = false;
       private bool _channelReadPredictions = false;
       private bool _channelManagePredictions = false;
       private bool _channelManageRaids = false;
       private bool _channelReadRedemptions = false;
       private bool _channelManageRedemptions = false;
       private bool _channelManageSchedule = false;
       private bool _channelReadStreamKey = false;
       private bool _channelReadSubscriptions = false;
       private bool _channelManageVideos = false;
       private bool _channelReadVips = false;
       private bool _channelManageVips = false;
       private bool _clipsEdit = false;
       private bool _moderationRead = false;
       private bool _moderatorManageAnnouncements = false;
       private bool _moderatorManageAutomod = false;
       private bool _moderatorReadAutomodSettings = false;
       private bool _moderatorManageAutomodSettings = false;
       private bool _moderatorManageBannedUsers = false;
       private bool _moderatorReadBlockedTerms = false;
       private bool _moderatorManageBlockedTerms = false;
       private bool _moderatorManageChatMessages = false;
       private bool _moderatorReadChatSettings = false;
       private bool _moderatorManageChatSettings = false;
       private bool _moderatorReadChatters = false;
       private bool _moderatorReadFollowers = false;
       private bool _moderatorReadGuestStar = false;
       private bool _moderatorManageGuestStar = false;
       private bool _moderatorReadShieldMode = false;
       private bool _moderatorManageShieldMode = false;
       private bool _moderatorReadShoutouts = false;
       private bool _moderatorManageShoutouts = false;
       private bool _userEdit = false;
       private bool _userEditFollows = false;
       private bool _userReadBlockedUsers = false;
       private bool _userManageBlockedUsers = false;
       private bool _userReadBroadcast = false;
       private bool _userManageChatColor = false;
       private bool _userReadEmail = false;
       private bool _userReadFollows = false;
       private bool _userReadSubscriptions = false;
       private bool _userManageWhispers = false;
       private bool _channelBot = false;
       private bool _channelModerate = false;
       private bool _chatEdit = false;
       private bool _chatRead = false;
       private bool _userBot = false;
       private bool _userReadChat = false;
       private bool _whispersRead = false;
       private bool _whispersEdit = false;

        public bool AnalyticsReadExtensions
        {
            get { return _analyticsReadExtensions; }
            set { Manage(value, "analytics:read:extensions", ref _analyticsReadExtensions); }
        }
        public bool AnalyticsReadGames
        {
            get { return _analyticsReadGames; }
            set { Manage(value, "analytics:read:games", ref _analyticsReadGames); }
        }
        public bool BitsRead
        {
            get { return _bitsRead; }
            set { Manage(value, "bits:read", ref _bitsRead); }
        }
        public bool ChannelManageAds
        {
            get { return _channelManageAds; }
            set { Manage(value, "channel:manage:ads", ref _channelManageAds); }
        }
        public bool ChannelReadAds
        {
            get { return _channelReadAds; }
            set { Manage(value, "channel:read:ads", ref _channelReadAds); }
        }
        public bool ChannelManageBroadcast
        {
            get { return _channelManageBroadcast; }
            set { Manage(value, "channel:manage:broadcast", ref _channelManageBroadcast); }
        }
        public bool ChannelReadCharity
        {
            get { return _channelReadCharity; }
            set { Manage(value, "channel:read:charity", ref _channelReadCharity); }
        }
        public bool ChannelEditCommercial
        {
            get { return _channelEditCommercial; }
            set { Manage(value, "channel:edit:commercial", ref _channelEditCommercial); }
        }
        public bool ChannelReadEditors
        {
            get { return _channelReadEditors; }
            set { Manage(value, "channel:read:editors", ref _channelReadEditors); }
        }
        public bool ChannelManageExtensions
        {
            get { return _channelManageExtensions; }
            set { Manage(value, "channel:manage:extensions", ref _channelManageExtensions); }
        }
        public bool ChannelReadGoals
        {
            get { return _channelReadGoals; }
            set { Manage(value, "channel:read:goals", ref _channelReadGoals); }
        }
        public bool ChannelReadGuestStar
        {
            get { return _channelReadGuestStar; }
            set { Manage(value, "channel:read:guest_star", ref _channelReadGuestStar); }
        }
        public bool ChannelManageGuestStar
        {
            get { return _channelManageGuestStar; }
            set { Manage(value, "channel:manage:guest_star", ref _channelManageGuestStar); }
        }
        public bool ChannelReadHypeTrain
        {
            get { return _channelReadHypeTrain; }
            set { Manage(value, "channel:read:hype_train", ref _channelReadHypeTrain); }
        }
        public bool ChannelManageModerators
        {
            get { return _channelManageModerators; }
            set { Manage(value, "channel:manage:moderators", ref _channelManageModerators); }
        }
        public bool ChannelReadPolls
        {
            get { return _channelReadPolls; }
            set { Manage(value, "channel:read:polls", ref _channelReadPolls); }
        }
        public bool ChannelManagePolls
        {
            get { return _channelManagePolls; }
            set { Manage(value, "channel:manage:polls", ref _channelManagePolls); }
        }
        public bool ChannelReadPredictions
        {
            get { return _channelReadPredictions; }
            set { Manage(value, "channel:read:predictions", ref _channelReadPredictions); }
        }
        public bool ChannelManagePredictions
        {
            get { return _channelManagePredictions; }
            set { Manage(value, "channel:manage:predictions", ref _channelManagePredictions); }
        }
        public bool ChannelManageRaids
        {
            get { return _channelManageRaids; }
            set { Manage(value, "channel:manage:raids", ref _channelManageRaids); }
        }
        public bool ChannelReadRedemptions
        {
            get { return _channelReadRedemptions; }
            set { Manage(value, "channel:read:redemptions", ref _channelReadRedemptions); }
        }
        public bool ChannelManageRedemptions
        {
            get { return _channelManageRedemptions; }
            set { Manage(value, "channel:manage:redemptions", ref _channelManageRedemptions); }
        }
        public bool ChannelManageSchedule
        {
            get { return _channelManageSchedule; }
            set { Manage(value, "channel:manage:schedule", ref _channelManageSchedule); }
        }
        public bool ChannelReadStreamKey
        {
            get { return _channelReadStreamKey; }
            set { Manage(value, "channel:read:stream_key", ref _channelReadStreamKey); }
        }
        public bool ChannelReadSubscriptions
        {
            get { return _channelReadSubscriptions; }
            set { Manage(value, "channel:read:subscriptions", ref _channelReadSubscriptions); }
        }
        public bool ChannelManageVideos
        {
            get { return _channelManageVideos; }
            set { Manage(value, "channel:manage:videos", ref _channelManageVideos); }
        }
        public bool ChannelReadVips
        {
            get { return _channelReadVips; }
            set { Manage(value, "channel:read:vips", ref _channelReadVips); }
        }
        public bool ChannelManageVips
        {
            get { return _channelManageVips; }
            set { Manage(value, "channel:manage:vips", ref _channelManageVips); }
        }
        public bool ClipsEdit
        {
            get { return _clipsEdit; }
            set { Manage(value, "clips:edit", ref _clipsEdit); }
        }
        public bool ModerationRead
        {
            get { return _moderationRead; }
            set { Manage(value, "moderation:read", ref _moderationRead); }
        }
        public bool ModeratorManageAnnouncements
        {
            get { return _moderatorManageAnnouncements; }
            set { Manage(value, "moderator:manage:announcements", ref _moderatorManageAnnouncements); }
        }
        public bool ModeratorManageAutomod
        {
            get { return _moderatorManageAutomod; }
            set { Manage(value, "moderator:manage:automod", ref _moderatorManageAutomod); }
        }
        public bool ModeratorReadAutomodSettings
        {
            get { return _moderatorReadAutomodSettings; }
            set { Manage(value, "moderator:read:automod_settings", ref _moderatorReadAutomodSettings); }
        }
        public bool ModeratorManageAutomodSettings
        {
            get { return _moderatorManageAutomodSettings; }
            set { Manage(value, "moderator:manage:automod_settings", ref _moderatorManageAutomodSettings); }
        }
        public bool ModeratorManageBannedUsers
        {
            get { return _moderatorManageBannedUsers; }
            set { Manage(value, "moderator:manage:banned_users", ref _moderatorManageBannedUsers); }
        }
        public bool ModeratorReadBlockedTerms
        {
            get { return _moderatorReadBlockedTerms; }
            set { Manage(value, "moderator:read:blocked_terms", ref _moderatorReadBlockedTerms); }
        }
        public bool ModeratorManageBlockedTerms
        {
            get { return _moderatorManageBlockedTerms; }
            set { Manage(value, "moderator:manage:blocked_terms", ref _moderatorManageBlockedTerms); }
        }
        public bool ModeratorManageChatMessages
        {
            get { return _moderatorManageChatMessages; }
            set { Manage(value, "moderator:manage:chat_messages", ref _moderatorManageChatMessages); }
        }
        public bool ModeratorReadChatSettings
        {
            get { return _moderatorReadChatSettings; }
            set { Manage(value, "moderator:read:chat_settings", ref _moderatorReadChatSettings); }
        }
        public bool ModeratorManageChatSettings
        {
            get { return _moderatorManageChatSettings; }
            set { Manage(value, "moderator:manage:chat_settings", ref _moderatorManageChatSettings); }
        }
        public bool ModeratorReadChatters
        {
            get { return _moderatorReadChatters; }
            set { Manage(value, "moderator:read:chatters", ref _moderatorReadChatters); }
        }
        public bool ModeratorReadFollowers
        {
            get { return _moderatorReadFollowers; }
            set { Manage(value, "moderator:read:followers", ref _moderatorReadFollowers); }
        }
        public bool ModeratorReadGuestStar
        {
            get { return _moderatorReadGuestStar; }
            set { Manage(value, "moderator:read:guest_star", ref _moderatorReadGuestStar); }
        }
        public bool ModeratorManageGuestStar
        {
            get { return _moderatorManageGuestStar; }
            set { Manage(value, "moderator:manage:guest_star", ref _moderatorManageGuestStar); }
        }
        public bool ModeratorReadShieldMode
        {
            get { return _moderatorReadShieldMode; }
            set { Manage(value, "moderator:read:shield_mode", ref _moderatorReadShieldMode); }
        }
        public bool ModeratorManageShieldMode
        {
            get { return _moderatorManageShieldMode; }
            set { Manage(value, "moderator:manage:shield_mode", ref _moderatorManageShieldMode); }
        }
        public bool ModeratorReadShoutouts
        {
            get { return _moderatorReadShoutouts; }
            set { Manage(value, "moderator:read:shoutouts", ref _moderatorReadShoutouts); }
        }
        public bool ModeratorManageShoutouts
        {
            get { return _moderatorManageShoutouts; }
            set { Manage(value, "moderator:manage:shoutouts", ref _moderatorManageShoutouts); }
        }
        public bool UserEdit
        {
            get { return _userEdit; }
            set { Manage(value, "user:edit", ref _userEdit); }
        }
        public bool UserEditFollows
        {
            get { return _userEditFollows; }
            set { Manage(value, "user:edit:follows", ref _userEditFollows); }
        }
        public bool UserReadBlockedUsers
        {
            get { return _userReadBlockedUsers; }
            set { Manage(value, "user:read:blocked_users", ref _userReadBlockedUsers); }
        }
        public bool UserManageBlockedUsers
        {
            get { return _userManageBlockedUsers; }
            set { Manage(value, "user:manage:blocked_users", ref _userManageBlockedUsers); }
        }
        public bool UserReadBroadcast
        {
            get { return _userReadBroadcast; }
            set { Manage(value, "user:read:broadcast", ref _userReadBroadcast); }
        }
        public bool UserManageChatColor
        {
            get { return _userManageChatColor; }
            set { Manage(value, "user:manage:chat_color", ref _userManageChatColor); }
        }
        public bool UserReadEmail
        {
            get { return _userReadEmail; }
            set { Manage(value, "user:read:email", ref _userReadEmail); }
        }
        public bool UserReadFollows
        {
            get { return _userReadFollows; }
            set { Manage(value, "user:read:follows", ref _userReadFollows); }
        }
        public bool UserReadSubscriptions
        {
            get { return _userReadSubscriptions; }
            set { Manage(value, "user:read:subscriptions", ref _userReadSubscriptions); }
        }
        public bool UserManageWhispers
        {
            get { return _userManageWhispers; }
            set { Manage(value, "user:manage:whispers", ref _userManageWhispers); }
        }
        public bool ChannelBot
        {
            get { return _channelBot; }
            set { Manage(value, "channel:bot", ref _channelBot); }
        }
        public bool ChannelModerate
        {
            get { return _channelModerate; }
            set { Manage(value, "channel:moderate", ref _channelModerate); }
        }
        public bool ChatEdit
        {
            get { return _chatEdit; }
            set { Manage(value, "chat:edit", ref _chatEdit); }
        }
        public bool ChatRead
        {
            get { return _chatRead; }
            set { Manage(value, "chat:read", ref _chatRead); }
        }
        public bool UserBot
        {
            get { return _userBot; }
            set { Manage(value, "user:bot", ref _userBot); }
        }
        public bool UserReadChat
        {
            get { return _userReadChat; }
            set { Manage(value, "user:read:chat", ref _userReadChat); }
        }
        public bool WhispersRead
        {
            get { return _whispersRead; }
            set { Manage(value, "whispers:read", ref _whispersRead); }
        }
        public bool WhispersEdit
        {
            get { return _whispersEdit; }
            set { Manage(value, "whispers:edit", ref _whispersEdit); }
        }   
        private void Manage(bool value, string scope, ref bool parameter)
        {
            if (value is true) { if (Scopes.Add(scope)) parameter = true; }
            else { if (Scopes.Remove(scope)) parameter = false; }
        }
        private readonly HashSet<string> Scopes = new();

        public TwitchAcessScopes() { }
        public TwitchAcessScopes(TwitchAcessScopes scopes)
        {
            AnalyticsReadExtensions = scopes.AnalyticsReadExtensions;
            AnalyticsReadGames = scopes.AnalyticsReadGames;
            BitsRead = scopes.BitsRead;
            ChannelManageAds = scopes.ChannelManageAds;
            ChannelReadAds = scopes.ChannelReadAds;
            ChannelManageBroadcast = scopes.ChannelManageBroadcast;
            ChannelReadCharity = scopes.ChannelReadCharity;
            ChannelEditCommercial = scopes.ChannelEditCommercial;
            ChannelReadEditors = scopes.ChannelReadEditors;
            ChannelManageExtensions = scopes.ChannelManageExtensions;
            ChannelReadGoals = scopes.ChannelReadGoals;
            ChannelReadGuestStar = scopes.ChannelReadGuestStar;
            ChannelManageGuestStar = scopes.ChannelManageGuestStar;
            ChannelReadHypeTrain = scopes.ChannelReadHypeTrain;
            ChannelManageModerators = scopes.ChannelManageModerators;
            ChannelReadPolls = scopes.ChannelReadPolls;
            ChannelManagePolls = scopes.ChannelManagePolls;
            ChannelReadPredictions = scopes.ChannelReadPredictions;
            ChannelManagePredictions = scopes.ChannelManagePredictions;
            ChannelManageRaids = scopes.ChannelManageRaids;
            ChannelReadRedemptions = scopes.ChannelReadRedemptions;
            ChannelManageRedemptions = scopes.ChannelManageRedemptions;
            ChannelManageSchedule = scopes.ChannelManageSchedule;
            ChannelReadStreamKey = scopes.ChannelReadStreamKey;
            ChannelReadSubscriptions = scopes.ChannelReadSubscriptions;
            ChannelManageVideos = scopes.ChannelManageVideos;
            ChannelReadVips = scopes.ChannelReadVips;
            ChannelManageVips = scopes.ChannelManageVips;
            ClipsEdit = scopes.ClipsEdit;
            ModerationRead = scopes.ModerationRead;
            ModeratorManageAnnouncements = scopes.ModeratorManageAnnouncements;
            ModeratorManageAutomod = scopes.ModeratorManageAutomod;
            ModeratorReadAutomodSettings = scopes.ModeratorReadAutomodSettings;
            ModeratorManageAutomodSettings = scopes.ModeratorManageAutomodSettings;
            ModeratorManageBannedUsers = scopes.ModeratorManageBannedUsers;
            ModeratorReadBlockedTerms = scopes.ModeratorReadBlockedTerms;
            ModeratorManageBlockedTerms = scopes.ModeratorManageBlockedTerms;
            ModeratorManageChatMessages = scopes.ModeratorManageChatMessages;
            ModeratorReadChatSettings = scopes.ModeratorReadChatSettings;
            ModeratorManageChatSettings = scopes.ModeratorManageChatSettings;
            ModeratorReadChatters = scopes.ModeratorReadChatters;
            ModeratorReadFollowers = scopes.ModeratorReadFollowers;
            ModeratorReadGuestStar = scopes.ModeratorReadGuestStar;
            ModeratorManageGuestStar = scopes.ModeratorManageGuestStar;
            ModeratorReadShieldMode = scopes.ModeratorReadShieldMode;
            ModeratorManageShieldMode = scopes.ModeratorManageShieldMode;
            ModeratorReadShoutouts = scopes.ModeratorReadShoutouts;
            ModeratorManageShoutouts = scopes.ModeratorManageShoutouts;
            UserEdit = scopes.UserEdit;
            UserEditFollows = scopes.UserEditFollows;
            UserReadBlockedUsers = scopes.UserReadBlockedUsers;
            UserManageBlockedUsers = scopes.UserManageBlockedUsers;
            UserReadBroadcast = scopes.UserReadBroadcast;
            UserManageChatColor = scopes.UserManageChatColor;
            UserReadEmail = scopes.UserReadEmail;
            UserReadFollows = scopes.UserReadFollows;
            UserReadSubscriptions = scopes.UserReadSubscriptions;
            UserManageWhispers = scopes.UserManageWhispers;
            ChannelBot = scopes.ChannelBot;
            ChannelModerate = scopes.ChannelModerate;
            ChatEdit = scopes.ChatEdit;
            ChatRead = scopes.ChatRead;
            UserBot = scopes.UserBot;
            UserReadChat = scopes.UserReadChat;
            WhispersRead = scopes.WhispersRead;
            WhispersEdit = scopes.WhispersEdit;
        }
        public bool Contains(string scope) => Scopes.Contains(scope);
        public static TwitchAcessScopes Parse(string[] scopes)
        {
            TwitchAcessScopes permissions = new();
            foreach (string scope in scopes) 
                permissions.Scopes.Add(scope);
            return permissions;
        }
        public void ParseScope(string scope)
        {
            switch (scope)
            {
                case "analytics:read:extensions":
                    AnalyticsReadExtensions = true;
                    return;
                case "analytics:read:games":
                    AnalyticsReadGames = true;
                    return;
                case "bits:read":
                    BitsRead = true;
                    return;
                case "channel:manage:ads":
                    ChannelManageAds = true;
                    return;
                case "channel:read:ads":
                    ChannelReadAds = true;
                    return;
                case "channel:manage:broadcast":
                    ChannelManageBroadcast = true;
                    return;
                case "channel:read:charity":
                    ChannelReadCharity = true;
                    return;
                case "channel:edit:commercial":
                    ChannelEditCommercial = true;
                    return;
                case "channel:read:editors":
                    ChannelReadEditors = true;
                    return;
                case "channel:manage:extensions":
                    ChannelManageExtensions = true;
                    return;
                case "channel:read:goals":
                    ChannelReadGoals = true;
                    return;
                case "channel:read:guest_star":
                    ChannelReadGuestStar = true;
                    return;
                case "channel:manage:guest_star":
                    ChannelManageGuestStar = true;
                    return;
                case "channel:read:hype_train":
                    ChannelReadHypeTrain = true;
                    return;
                case "channel:manage:moderators":
                    ChannelManageModerators = true;
                    return;
                case "channel:read:polls":
                    ChannelReadPolls = true;
                    return;
                case "channel:manage:polls":
                    ChannelManagePolls = true;
                    return;
                case "channel:read:predictions":
                    ChannelReadPredictions = true;
                    return;
                case "channel:manage:predictions":
                    ChannelManagePredictions = true;
                    return;
                case "channel:manage:raids":
                    ChannelManageRaids = true;
                    return;
                case "channel:read:redemptions":
                    ChannelReadRedemptions = true;
                    return;
                case "channel:manage:redemptions":
                    ChannelManageRedemptions = true;
                    return;
                case "channel:manage:schedule":
                    ChannelManageSchedule = true;
                    return;
                case "channel:read:stream_key":
                    ChannelReadStreamKey = true;
                    return;
                case "channel:read:subscriptions":
                    ChannelReadSubscriptions = true;
                    return;
                case "channel:manage:videos":
                    ChannelManageVideos = true;
                    return;
                case "channel:read:vips":
                    ChannelReadVips = true;
                    return;
                case "channel:manage:vips":
                    ChannelManageVips = true;
                    return;
                case "clips:edit":
                    ClipsEdit = true;
                    return;
                case "moderation:read":
                    ModerationRead = true;
                    return;
                case "moderator:manage:announcements":
                    ModeratorManageAnnouncements = true;
                    return;
                case "moderator:manage:automod":
                    ModeratorManageAutomod = true;
                    return;
                case "moderator:read:automod_settings":
                    ModeratorReadAutomodSettings = true;
                    return;
                case "moderator:manage:automod_settings":
                    ModeratorManageAutomodSettings = true;
                    return;
                case "moderator:manage:banned_users":
                    ModeratorManageBannedUsers = true;
                    return;
                case "moderator:read:blocked_terms":
                    ModeratorReadBlockedTerms = true;
                    return;
                case "moderator:manage:blocked_terms":
                    ModeratorManageBlockedTerms = true;
                    return;
                case "moderator:manage:chat_messages":
                    ModeratorManageChatMessages = true;
                    return;
                case "moderator:read:chat_settings":
                    ModeratorReadChatSettings = true;
                    return;
                case "moderator:manage:chat_settings":
                    ModeratorManageChatSettings = true;
                    return;
                case "moderator:read:chatters":
                    ModeratorReadChatters = true;
                    return;
                case "moderator:read:followers":
                    ModeratorReadFollowers = true;
                    return;
                case "moderator:read:guest_star":
                    ModeratorReadGuestStar = true;
                    return;
                case "moderator:manage:guest_star":
                    ModeratorManageGuestStar = true;
                    return;
                case "moderator:read:shield_mode":
                    ModeratorReadShieldMode = true;
                    return;
                case "moderator:manage:shield_mode":
                    ModeratorManageShieldMode = true;
                    return;
                case "moderator:read:shoutouts":
                    ModeratorReadShoutouts = true;
                    return;
                case "moderator:manage:shoutouts":
                    ModeratorManageShoutouts = true;
                    return;
                case "user:edit":
                    UserEdit = true;
                    return;
                case "user:edit:follows":
                    UserEditFollows = true;
                    return;
                case "user:read:blocked_users":
                    UserReadBlockedUsers = true;
                    return;
                case "user:manage:blocked_users":
                    UserManageBlockedUsers = true;
                    return;
                case "user:read:broadcast":
                    UserReadBroadcast = true;
                    return;
                case "user:manage:chat_color":
                    UserManageChatColor = true;
                    return;
                case "user:read:email":
                    UserReadEmail = true;
                    return;
                case "user:read:follows":
                    UserReadFollows = true;
                    return;
                case "user:read:subscriptions":
                    UserReadSubscriptions = true;
                    return;
                case "user:manage:whispers":
                    UserManageWhispers = true;
                    return;
                case "channel:bot":
                    ChannelBot = true;
                    return;
                case "channel:moderate":
                    ChannelModerate = true;
                    return;
                case "chat:edit":
                    ChatEdit = true;
                    return;
                case "chat:read":
                    ChatRead = true;
                    return;
                case "user:bot":
                    UserBot = true;
                    return;
                case "user:read:chat":
                    UserReadChat = true;
                    return;
                case "whispers:read":
                    WhispersRead = true;
                    return;
                case "whispers:edit":
                    WhispersEdit = true;
                    return;
            }
        }
        public static TwitchAcessScopes ParseFromLine(string line)
        {
            TwitchAcessScopes result = new();
            if (line.Contains("analytics:read:extensions"))
                result.AnalyticsReadExtensions = true;
            if (line.Contains("analytics:read:games"))
                result.AnalyticsReadGames = true;
            if (line.Contains("bits:read"))
                result.BitsRead = true;
            if (line.Contains("channel:manage:ads"))
                result.ChannelManageAds = true;
            if (line.Contains("channel:read:ads"))
                result.ChannelReadAds = true;
            if (line.Contains("channel:manage:broadcast"))
                result.ChannelManageBroadcast = true;
            if (line.Contains("channel:read:charity"))
                result.ChannelReadCharity = true;
            if (line.Contains("channel:edit:commercial"))
                result.ChannelEditCommercial = true;
            if (line.Contains("channel:read:editors"))
                result.ChannelReadEditors = true;
            if (line.Contains("channel:manage:extensions"))
                result.ChannelManageExtensions = true;
            if (line.Contains("channel:read:goals"))
                result.ChannelReadGoals = true;
            if (line.Contains("channel:read:guest_star"))
                result.ChannelReadGuestStar = true;
            if (line.Contains("channel:manage:guest_star"))
                result.ChannelManageGuestStar = true;
            if (line.Contains("channel:read:hype_train"))
                result.ChannelReadHypeTrain = true;
            if (line.Contains("channel:manage:moderators"))
                result.ChannelManageModerators = true;
            if (line.Contains("channel:read:polls"))
                result.ChannelReadPolls = true;
            if (line.Contains("channel:manage:polls"))
                result.ChannelManagePolls = true;
            if (line.Contains("channel:read:predictions"))
                result.ChannelReadPredictions = true;
            if (line.Contains("channel:manage:predictions"))
                result.ChannelManagePredictions = true;
            if (line.Contains("channel:manage:raids"))
                result.ChannelManageRaids = true;
            if (line.Contains("channel:read:redemptions"))
                result.ChannelReadRedemptions = true;
            if (line.Contains("channel:manage:redemptions"))
                result.ChannelManageRedemptions = true;
            if (line.Contains("channel:manage:schedule"))
                result.ChannelManageSchedule = true;
            if (line.Contains("channel:read:stream_key"))
                result.ChannelReadStreamKey = true;
            if (line.Contains("channel:read:subscriptions"))
                result.ChannelReadSubscriptions = true;
            if (line.Contains("channel:manage:videos"))
                result.ChannelManageVideos = true;
            if (line.Contains("channel:read:vips"))
                result.ChannelReadVips = true;
            if (line.Contains("channel:manage:vips"))
                result.ChannelManageVips = true;
            if (line.Contains("clips:edit"))
                result.ClipsEdit = true;
            if (line.Contains("moderation:read"))
                result.ModerationRead = true;
            if (line.Contains("moderator:manage:announcements"))
                result.ModeratorManageAnnouncements = true;
            if (line.Contains("moderator:manage:automod"))
                result.ModeratorManageAutomod = true;
            if (line.Contains("moderator:read:automod_settings"))
                result.ModeratorReadAutomodSettings = true;
            if (line.Contains("moderator:manage:automod_settings"))
                result.ModeratorManageAutomodSettings = true;
            if (line.Contains("moderator:manage:banned_users"))
                result.ModeratorManageBannedUsers = true;
            if (line.Contains("moderator:read:blocked_terms"))
                result.ModeratorReadBlockedTerms = true;
            if (line.Contains("moderator:manage:blocked_terms"))
                result.ModeratorManageBlockedTerms = true;
            if (line.Contains("moderator:manage:chat_messages"))
                result.ModeratorManageChatMessages = true;
            if (line.Contains("moderator:read:chat_settings"))
                result.ModeratorReadChatSettings = true;
            if (line.Contains("moderator:manage:chat_settings"))
                result.ModeratorManageChatSettings = true;
            if (line.Contains("moderator:read:chatters"))
                result.ModeratorReadChatters = true;
            if (line.Contains("moderator:read:followers"))
                result.ModeratorReadFollowers = true;
            if (line.Contains("moderator:read:guest_star"))
                result.ModeratorReadGuestStar = true;
            if (line.Contains("moderator:manage:guest_star"))
                result.ModeratorManageGuestStar = true;
            if (line.Contains("moderator:read:shield_mode"))
                result.ModeratorReadShieldMode = true;
            if (line.Contains("moderator:manage:shield_mode"))
                result.ModeratorManageShieldMode = true;
            if (line.Contains("moderator:read:shoutouts"))
                result.ModeratorReadShoutouts = true;
            if (line.Contains("moderator:manage:shoutouts"))
                result.ModeratorManageShoutouts = true;
            if (line.Contains("user:edit"))
                result.UserEdit = true;
            if (line.Contains("user:edit:follows"))
                result.UserEditFollows = true;
            if (line.Contains("user:read:blocked_users"))
                result.UserReadBlockedUsers = true;
            if (line.Contains("user:manage:blocked_users"))
                result.UserManageBlockedUsers = true;
            if (line.Contains("user:read:broadcast"))
                result.UserReadBroadcast = true;
            if (line.Contains("user:manage:chat_color"))
                result.UserManageChatColor = true;
            if (line.Contains("user:read:email"))
                result.UserReadEmail = true;
            if (line.Contains("user:read:follows"))
                result.UserReadFollows = true;
            if (line.Contains("user:read:subscriptions"))
                result.UserReadSubscriptions = true;
            if (line.Contains("user:manage:whispers"))
                result.UserManageWhispers = true;
            if (line.Contains("channel:bot"))
                result.ChannelBot = true;
            if (line.Contains("channel:moderate"))
                result.ChannelModerate = true;
            if (line.Contains("chat:edit"))
                result.ChatEdit = true;
            if (line.Contains("chat:read"))
                result.ChatRead = true;
            if (line.Contains("user:bot"))
                result.UserBot = true;
            if (line.Contains("user:read:chat"))
                result.UserReadChat = true;
            if (line.Contains("whispers:read"))
                result.WhispersRead = true;
            if (line.Contains("whispers:edit"))
                result.WhispersEdit = true;
            return result;
        }
        public static bool Equals(TwitchAcessScopes permissions, string[] scopes)
        {
            if (permissions.Scopes.Count == scopes.Length)
            {
                foreach (string scope in scopes) 
                    if (!permissions.Contains(scope)) 
                        return false;
                return true;
            }
            else 
                return true;
        }
        public static bool Equals(TwitchAcessScopes internalPermissions, TwitchAcessScopes externalPermissions)
        {
            if (internalPermissions.AnalyticsReadExtensions != externalPermissions.AnalyticsReadExtensions)
                return false;
            if (internalPermissions.AnalyticsReadGames != externalPermissions.AnalyticsReadGames)
                return false;
            if (internalPermissions.BitsRead != externalPermissions.BitsRead)
                return false;
            if (internalPermissions.ChannelManageAds != externalPermissions.ChannelManageAds)
                return false;
            if (internalPermissions.ChannelReadAds != externalPermissions.ChannelReadAds)
                return false;
            if (internalPermissions.ChannelManageBroadcast != externalPermissions.ChannelManageBroadcast)
                return false;
            if (internalPermissions.ChannelReadCharity != externalPermissions.ChannelReadCharity)
                return false;
            if (internalPermissions.ChannelEditCommercial != externalPermissions.ChannelEditCommercial)
                return false;
            if (internalPermissions.ChannelReadEditors != externalPermissions.ChannelReadEditors)
                return false;
            if (internalPermissions.ChannelManageExtensions != externalPermissions.ChannelManageExtensions)
                return false;
            if (internalPermissions.ChannelReadGoals != externalPermissions.ChannelReadGoals)
                return false;
            if (internalPermissions.ChannelReadGuestStar != externalPermissions.ChannelReadGuestStar)
                return false;
            if (internalPermissions.ChannelManageGuestStar != externalPermissions.ChannelManageGuestStar)
                return false;
            if (internalPermissions.ChannelReadHypeTrain != externalPermissions.ChannelReadHypeTrain)
                return false;
            if (internalPermissions.ChannelManageModerators != externalPermissions.ChannelManageModerators)
                return false;
            if (internalPermissions.ChannelReadPolls != externalPermissions.ChannelReadPolls)
                return false;
            if (internalPermissions.ChannelManagePolls != externalPermissions.ChannelManagePolls)
                return false;
            if (internalPermissions.ChannelReadPredictions != externalPermissions.ChannelReadPredictions)
                return false;
            if (internalPermissions.ChannelManagePredictions != externalPermissions.ChannelManagePredictions)
                return false;
            if (internalPermissions.ChannelManageRaids != externalPermissions.ChannelManageRaids)
                return false;
            if (internalPermissions.ChannelReadRedemptions != externalPermissions.ChannelReadRedemptions)
                return false;
            if (internalPermissions.ChannelManageRedemptions != externalPermissions.ChannelManageRedemptions)
                return false;
            if (internalPermissions.ChannelManageSchedule != externalPermissions.ChannelManageSchedule)
                return false;
            if (internalPermissions.ChannelReadStreamKey != externalPermissions.ChannelReadStreamKey)
                return false;
            if (internalPermissions.ChannelReadSubscriptions != externalPermissions.ChannelReadSubscriptions)
                return false;
            if (internalPermissions.ChannelManageVideos != externalPermissions.ChannelManageVideos)
                return false;
            if (internalPermissions.ChannelReadVips != externalPermissions.ChannelReadVips)
                return false;
            if (internalPermissions.ChannelManageVips != externalPermissions.ChannelManageVips)
                return false;
            if (internalPermissions.ClipsEdit != externalPermissions.ClipsEdit)
                return false;
            if (internalPermissions.ModerationRead != externalPermissions.ModerationRead)
                return false;
            if (internalPermissions.ModeratorManageAnnouncements != externalPermissions.ModeratorManageAnnouncements)
                return false;
            if (internalPermissions.ModeratorManageAutomod != externalPermissions.ModeratorManageAutomod)
                return false;
            if (internalPermissions.ModeratorReadAutomodSettings != externalPermissions.ModeratorReadAutomodSettings)
                return false;
            if (internalPermissions.ModeratorManageAutomodSettings != externalPermissions.ModeratorManageAutomodSettings)
                return false;
            if (internalPermissions.ModeratorManageBannedUsers != externalPermissions.ModeratorManageBannedUsers)
                return false;
            if (internalPermissions.ModeratorReadBlockedTerms != externalPermissions.ModeratorReadBlockedTerms)
                return false;
            if (internalPermissions.ModeratorManageBlockedTerms != externalPermissions.ModeratorManageBlockedTerms)
                return false;
            if (internalPermissions.ModeratorManageChatMessages != externalPermissions.ModeratorManageChatMessages)
                return false;
            if (internalPermissions.ModeratorReadChatSettings != externalPermissions.ModeratorReadChatSettings)
                return false;
            if (internalPermissions.ModeratorManageChatSettings != externalPermissions.ModeratorManageChatSettings)
                return false;
            if (internalPermissions.ModeratorReadChatters != externalPermissions.ModeratorReadChatters)
                return false;
            if (internalPermissions.ModeratorReadFollowers != externalPermissions.ModeratorReadFollowers)
                return false;
            if (internalPermissions.ModeratorReadGuestStar != externalPermissions.ModeratorReadGuestStar)
                return false;
            if (internalPermissions.ModeratorManageGuestStar != externalPermissions.ModeratorManageGuestStar)
                return false;
            if (internalPermissions.ModeratorReadShieldMode != externalPermissions.ModeratorReadShieldMode)
                return false;
            if (internalPermissions.ModeratorManageShieldMode != externalPermissions.ModeratorManageShieldMode)
                return false;
            if (internalPermissions.ModeratorReadShoutouts != externalPermissions.ModeratorReadShoutouts)
                return false;
            if (internalPermissions.ModeratorManageShoutouts != externalPermissions.ModeratorManageShoutouts)
                return false;
            if (internalPermissions.UserEdit != externalPermissions.UserEdit)
                return false;
            if (internalPermissions.UserEditFollows != externalPermissions.UserEditFollows)
                return false;
            if (internalPermissions.UserReadBlockedUsers != externalPermissions.UserReadBlockedUsers)
                return false;
            if (internalPermissions.UserManageBlockedUsers != externalPermissions.UserManageBlockedUsers)
                return false;
            if (internalPermissions.UserReadBroadcast != externalPermissions.UserReadBroadcast)
                return false;
            if (internalPermissions.UserManageChatColor != externalPermissions.UserManageChatColor)
                return false;
            if (internalPermissions.UserReadEmail != externalPermissions.UserReadEmail)
                return false;
            if (internalPermissions.UserReadFollows != externalPermissions.UserReadFollows)
                return false;
            if (internalPermissions.UserReadSubscriptions != externalPermissions.UserReadSubscriptions)
                return false;
            if (internalPermissions.UserManageWhispers != externalPermissions.UserManageWhispers)
                return false;
            if (internalPermissions.ChannelBot != externalPermissions.ChannelBot)
                return false;
            if (internalPermissions.ChannelModerate != externalPermissions.ChannelModerate)
                return false;
            if (internalPermissions.ChatEdit != externalPermissions.ChatEdit)
                return false;
            if (internalPermissions.ChatRead != externalPermissions.ChatRead)
                return false;
            if (internalPermissions.UserBot != externalPermissions.UserBot)
                return false;
            if (internalPermissions.UserReadChat != externalPermissions.UserReadChat)
                return false;
            if (internalPermissions.WhispersRead != externalPermissions.WhispersRead)
                return false;
            if (internalPermissions.WhispersEdit != externalPermissions.WhispersEdit)
                return false;
            return true;
        }
        public string ToUrlEncodedString()
        {
            string result = "";
            foreach (string parameter in Scopes) result += $" {parameter}";
            result = result.Trim();
            return HttpUtility.UrlEncode(result);
        }
    }
}
