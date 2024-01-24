namespace Twitch.Authentication
{
    public readonly struct Scopes
    {
        #region API Scopes
        public bool AnalyticsReadExtensions { get; }
        public bool AnalyticsReadGames { get; }
        public bool BitsRead { get; }
        public bool ChannelManageAds { get; }
        public bool ChannelReadAds { get; }
        public bool ChannelManageBroadcast { get; }
        public bool ChannelReadCharity { get; }
        public bool ChannelEditCommercial { get; }
        public bool ChannelReadEditors { get; }
        public bool ChannelManageExtensions { get; }
        public bool ChannelReadGoals { get; }
        public bool ChannelReadGuestStar { get; }
        public bool ChannelManageGuestStar { get; }
        public bool ChannelReadHypeTrain { get; }
        public bool ChannelManageModerators { get; }
        public bool ChannelReadPolls { get; }
        public bool ChannelManagePolls { get; }
        public bool ChannelReadPredictions { get; }
        public bool ChannelManagePredictions { get; }
        public bool ChannelManageRaids { get; }
        public bool ChannelReadRedemptions { get; }
        public bool ChannelManageRedemptions { get; }
        public bool ChannelManageSchedule { get; }
        public bool ChannelReadStreamKey { get; }
        public bool ChannelReadSubscriptions { get; }
        public bool ChannelManageVideos { get; }
        public bool ChannelReadVips { get; }
        public bool ChannelManageVips { get; }
        public bool ClipsEdit { get; }
        public bool ModerationRead { get; }
        public bool ModeratorManageAnnouncements { get; }
        public bool ModeratorManageAutomod { get; }
        public bool ModeratorReadAutomodSettings { get; }
        public bool ModeratorManageAutomodSettings { get; }
        public bool ModeratorManageBannedUsers { get; }
        public bool ModeratorReadBlockedTerms { get; }
        public bool ModeratorManageBlockedTerms { get; }
        public bool ModeratorManageChatMessages { get; }
        public bool ModeratorReadChatSettings { get; }
        public bool ModeratorManageChatSettings { get; }
        public bool ModeratorReadChatters { get; }
        public bool ModeratorReadFollowers { get; }
        public bool ModeratorReadGuestStar { get; }
        public bool ModeratorManageGuestStar { get; }
        public bool ModeratorReadShieldMode { get; }
        public bool ModeratorManageShieldMode { get; }
        public bool ModeratorReadShoutouts { get; }
        public bool ModeratorManageShoutouts { get; }
        public bool UserEdit { get; }
        public bool UserEditFollows { get; }
        public bool UserReadBlockedUsers { get; }
        public bool UserManageBlockedUsers { get; }
        public bool UserReadBroadcast { get; }
        public bool UserManageChatColor { get; }
        public bool UserReadEmail { get; }
        public bool UserReadFollows { get; }
        public bool UserReadSubscriptions { get; }
        public bool UserManageWhispers { get; }
        #endregion

        #region Chat&PubSub Scopes
        public bool ChannelBot { get; }
        public bool ChannelModerate { get; }
        public bool ChatEdit { get; }
        public bool ChatRead { get; }
        public bool UserBot { get; }
        public bool UserReadChat { get; }
        public bool WhispersRead { get; }
        public bool WhispersEdit { get; }
        #endregion

        internal Scopes(ScopesBuilder scopesBuilder)
        {
            AnalyticsReadExtensions = scopesBuilder.AnalyticsReadExtensions;
            AnalyticsReadGames = scopesBuilder.AnalyticsReadGames;
            BitsRead = scopesBuilder.BitsRead;
            ChannelManageAds = scopesBuilder.ChannelManageAds;
            ChannelReadAds = scopesBuilder.ChannelReadAds;
            ChannelManageBroadcast = scopesBuilder.ChannelManageBroadcast;
            ChannelReadCharity = scopesBuilder.ChannelReadCharity;
            ChannelEditCommercial = scopesBuilder.ChannelEditCommercial;
            ChannelReadEditors = scopesBuilder.ChannelReadEditors;
            ChannelManageExtensions = scopesBuilder.ChannelManageExtensions;
            ChannelReadGoals = scopesBuilder.ChannelReadGoals;
            ChannelReadGuestStar = scopesBuilder.ChannelReadGuestStar;
            ChannelManageGuestStar = scopesBuilder.ChannelManageGuestStar;
            ChannelReadHypeTrain = scopesBuilder.ChannelReadHypeTrain;
            ChannelManageModerators = scopesBuilder.ChannelManageModerators;
            ChannelReadPolls = scopesBuilder.ChannelReadPolls;
            ChannelManagePolls = scopesBuilder.ChannelManagePolls;
            ChannelReadPredictions = scopesBuilder.ChannelReadPredictions;
            ChannelManagePredictions = scopesBuilder.ChannelManagePredictions;
            ChannelManageRaids = scopesBuilder.ChannelManageRaids;
            ChannelReadRedemptions = scopesBuilder.ChannelReadRedemptions;
            ChannelManageRedemptions = scopesBuilder.ChannelManageRedemptions;
            ChannelManageSchedule = scopesBuilder.ChannelManageSchedule;
            ChannelReadStreamKey = scopesBuilder.ChannelReadStreamKey;
            ChannelReadSubscriptions = scopesBuilder.ChannelReadSubscriptions;
            ChannelManageVideos = scopesBuilder.ChannelManageVideos;
            ChannelReadVips = scopesBuilder.ChannelReadVips;
            ChannelManageVips = scopesBuilder.ChannelManageVips;
            ClipsEdit = scopesBuilder.ClipsEdit;
            ModerationRead = scopesBuilder.ModerationRead;
            ModeratorManageAnnouncements = scopesBuilder.ModeratorManageAnnouncements;
            ModeratorManageAutomod = scopesBuilder.ModeratorManageAutomod;
            ModeratorReadAutomodSettings = scopesBuilder.ModeratorReadAutomodSettings;
            ModeratorManageAutomodSettings = scopesBuilder.ModeratorManageAutomodSettings;
            ModeratorManageBannedUsers = scopesBuilder.ModeratorManageBannedUsers;
            ModeratorReadBlockedTerms = scopesBuilder.ModeratorReadBlockedTerms;
            ModeratorManageBlockedTerms = scopesBuilder.ModeratorManageBlockedTerms;
            ModeratorManageChatMessages = scopesBuilder.ModeratorManageChatMessages;
            ModeratorReadChatSettings = scopesBuilder.ModeratorReadChatSettings;
            ModeratorManageChatSettings = scopesBuilder.ModeratorManageChatSettings;
            ModeratorReadChatters = scopesBuilder.ModeratorReadChatters;
            ModeratorReadFollowers = scopesBuilder.ModeratorReadFollowers;
            ModeratorReadGuestStar = scopesBuilder.ModeratorReadGuestStar;
            ModeratorManageGuestStar = scopesBuilder.ModeratorManageGuestStar;
            ModeratorReadShieldMode = scopesBuilder.ModeratorReadShieldMode;
            ModeratorManageShieldMode = scopesBuilder.ModeratorManageShieldMode;
            ModeratorReadShoutouts = scopesBuilder.ModeratorReadShoutouts;
            ModeratorManageShoutouts = scopesBuilder.ModeratorManageShoutouts;
            UserEdit = scopesBuilder.UserEdit;
            UserEditFollows = scopesBuilder.UserEditFollows;
            UserReadBlockedUsers = scopesBuilder.UserReadBlockedUsers;
            UserManageBlockedUsers = scopesBuilder.UserManageBlockedUsers;
            UserReadBroadcast = scopesBuilder.UserReadBroadcast;
            UserManageChatColor = scopesBuilder.UserManageChatColor;
            UserReadEmail = scopesBuilder.UserReadEmail;
            UserReadFollows = scopesBuilder.UserReadFollows;
            UserReadSubscriptions = scopesBuilder.UserReadSubscriptions;
            UserManageWhispers = scopesBuilder.UserManageWhispers;
            ChannelBot = scopesBuilder.ChannelBot;
            ChannelModerate = scopesBuilder.ChannelModerate;
            ChatEdit = scopesBuilder.ChatEdit;
            ChatRead = scopesBuilder.ChatRead;
            UserBot = scopesBuilder.UserBot;
            UserReadChat = scopesBuilder.UserReadChat;
            WhispersRead = scopesBuilder.WhispersRead;
            WhispersEdit = scopesBuilder.WhispersEdit;
        }

        internal List<string> GetScopes()
        {
            List<string> scopesList = new();

            if (AnalyticsReadExtensions) scopesList.Add("analytics:read:extensions");
            if (AnalyticsReadGames) scopesList.Add("analytics:read:games");
            if (BitsRead) scopesList.Add("bits:read");
            if (ChannelManageAds) scopesList.Add("channel:manage:ads");
            if (ChannelReadAds) scopesList.Add("channel:read:ads");
            if (ChannelManageBroadcast) scopesList.Add("channel:manage:broadcast");
            if (ChannelReadCharity) scopesList.Add("channel:read:charity");
            if (ChannelEditCommercial) scopesList.Add("channel:edit:commercial");
            if (ChannelReadEditors) scopesList.Add("channel:read:editors");
            if (ChannelManageExtensions) scopesList.Add("channel:manage:extensions");
            if (ChannelReadGoals) scopesList.Add("channel:read:goals");
            if (ChannelReadGuestStar) scopesList.Add("channel:read:guest_star");
            if (ChannelManageGuestStar) scopesList.Add("channel:manage:guest_star");
            if (ChannelReadHypeTrain) scopesList.Add("channel:read:hype_train");
            if (ChannelManageModerators) scopesList.Add("channel:manage:moderators");
            if (ChannelReadPolls) scopesList.Add("channel:read:polls");
            if (ChannelManagePolls) scopesList.Add("channel:manage:polls");
            if (ChannelReadPredictions) scopesList.Add("channel:read:predictions");
            if (ChannelManagePredictions) scopesList.Add("channel:manage:predictions");
            if (ChannelManageRaids) scopesList.Add("channel:manage:raids");
            if (ChannelReadRedemptions) scopesList.Add("channel:read:redemptions");
            if (ChannelManageRedemptions) scopesList.Add("channel:manage:redemptions");
            if (ChannelManageSchedule) scopesList.Add("channel:manage:schedule");
            if (ChannelReadStreamKey) scopesList.Add("channel:read:stream_key");
            if (ChannelReadSubscriptions) scopesList.Add("channel:read:subscriptions");
            if (ChannelManageVideos) scopesList.Add("channel:manage:videos");
            if (ChannelReadVips) scopesList.Add("channel:read:vips");
            if (ChannelManageVips) scopesList.Add("channel:manage:vips");
            if (ClipsEdit) scopesList.Add("clips:edit");
            if (ModerationRead) scopesList.Add("moderation:read");
            if (ModeratorManageAnnouncements) scopesList.Add("moderator:manage:announcements");
            if (ModeratorManageAutomod) scopesList.Add("moderator:manage:automod");
            if (ModeratorReadAutomodSettings) scopesList.Add("moderator:read:automod_settings");
            if (ModeratorManageAutomodSettings) scopesList.Add("moderator:manage:automod_settings");
            if (ModeratorManageBannedUsers) scopesList.Add("moderator:manage:banned_users");
            if (ModeratorReadBlockedTerms) scopesList.Add("moderator:read:blocked_terms");
            if (ModeratorManageBlockedTerms) scopesList.Add("moderator:manage:blocked_terms");
            if (ModeratorManageChatMessages) scopesList.Add("moderator:manage:chat_messages");
            if (ModeratorReadChatSettings) scopesList.Add("moderator:read:chat_settings");
            if (ModeratorManageChatSettings) scopesList.Add("moderator:manage:chat_settings");
            if (ModeratorReadChatters) scopesList.Add("moderator:read:chatters");
            if (ModeratorReadFollowers) scopesList.Add("moderator:read:followers");
            if (ModeratorReadGuestStar) scopesList.Add("moderator:read:guest_star");
            if (ModeratorManageGuestStar) scopesList.Add("moderator:manage:guest_star");
            if (ModeratorReadShieldMode) scopesList.Add("moderator:read:shield_mode");
            if (ModeratorManageShieldMode) scopesList.Add("moderator:manage:shield_mode");
            if (ModeratorReadShoutouts) scopesList.Add("moderator:read:shoutouts");
            if (ModeratorManageShoutouts) scopesList.Add("moderator:manage:shoutouts");
            if (UserEdit) scopesList.Add("user:edit");
            if (UserEditFollows) scopesList.Add("user:edit:follows");
            if (UserReadBlockedUsers) scopesList.Add("user:read:blocked_users");
            if (UserManageBlockedUsers) scopesList.Add("user:manage:blocked_users");
            if (UserReadBroadcast) scopesList.Add("user:read:broadcast");
            if (UserManageChatColor) scopesList.Add("user:manage:chat_color");
            if (UserReadEmail) scopesList.Add("user:read:email");
            if (UserReadFollows) scopesList.Add("user:read:follows");
            if (UserReadSubscriptions) scopesList.Add("user:read:subscriptions");
            if (UserManageWhispers) scopesList.Add("user:manage:whispers");
            if (ChannelBot) scopesList.Add("channel:bot");
            if (ChannelModerate) scopesList.Add("channel:moderate");
            if (ChatEdit) scopesList.Add("chat:edit");
            if (ChatRead) scopesList.Add("chat:read");
            if (UserBot) scopesList.Add("user:bot");
            if (UserReadChat) scopesList.Add("user:read:chat");
            if (WhispersRead) scopesList.Add("whispers:read");
            if (WhispersEdit) scopesList.Add("whispers:edit");

            return scopesList;
        }
    }
}
