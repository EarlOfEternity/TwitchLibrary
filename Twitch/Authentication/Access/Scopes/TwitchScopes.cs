namespace Twitch.Authentication.Access.Scopes
{
    public class TwitchScopes
    {
        public bool AnalyticsReadExtensions { get; init; }
        public bool AnalyticsReadGames { get; init; }
        public bool BitsRead { get; init; }
        public bool ChannelManageAds { get; init; }
        public bool ChannelReadAds { get; init; }
        public bool ChannelManageBroadcast { get; init; }
        public bool ChannelReadCharity { get; init; }
        public bool ChannelEditCommercial { get; init; }
        public bool ChannelReadEditors { get; init; }
        public bool ChannelManageExtensions { get; init; }
        public bool ChannelReadGoals { get; init; }
        public bool ChannelReadGuestStar { get; init; }
        public bool ChannelManageGuestStar { get; init; }
        public bool ChannelReadHypeTrain { get; init; }
        public bool ChannelManageModerators { get; init; }
        public bool ChannelReadPolls { get; init; }
        public bool ChannelManagePolls { get; init; }
        public bool ChannelReadPredictions { get; init; }
        public bool ChannelManagePredictions { get; init; }
        public bool ChannelManageRaids { get; init; }
        public bool ChannelReadRedemptions { get; init; }
        public bool ChannelManageRedemptions { get; init; }
        public bool ChannelManageSchedule { get; init; }
        public bool ChannelReadStreamKey { get; init; }
        public bool ChannelReadSubscriptions { get; init; }
        public bool ChannelManageVideos { get; init; }
        public bool ChannelReadVips { get; init; }
        public bool ChannelManageVips { get; init; }
        public bool ClipsEdit { get; init; }
        public bool ModerationRead { get; init; }
        public bool ModeratorManageAnnouncements { get; init; }
        public bool ModeratorManageAutomod { get; init; }
        public bool ModeratorReadAutomodSettings { get; init; }
        public bool ModeratorManageAutomodSettings { get; init; }
        public bool ModeratorManageBannedUsers { get; init; }
        public bool ModeratorReadBlockedTerms { get; init; }
        public bool ModeratorManageBlockedTerms { get; init; }
        public bool ModeratorManageChatMessages { get; init; }
        public bool ModeratorReadChatSettings { get; init; }
        public bool ModeratorManageChatSettings { get; init; }
        public bool ModeratorReadChatters { get; init; }
        public bool ModeratorReadFollowers { get; init; }
        public bool ModeratorReadGuestStar { get; init; }
        public bool ModeratorManageGuestStar { get; init; }
        public bool ModeratorReadShieldMode { get; init; }
        public bool ModeratorManageShieldMode { get; init; }
        public bool ModeratorReadShoutouts { get; init; }
        public bool ModeratorManageShoutouts { get; init; }
        public bool UserEdit { get; init; }
        public bool UserEditFollows { get; init; }
        public bool UserReadBlockedUsers { get; init; }
        public bool UserManageBlockedUsers { get; init; }
        public bool UserReadBroadcast { get; init; }
        public bool UserManageChatColor { get; init; }
        public bool UserReadEmail { get; init; }
        public bool UserReadFollows { get; init; }
        public bool UserReadSubscriptions { get; init; }
        public bool UserManageWhispers { get; init; }
        public bool ChannelBot { get; init; }
        public bool ChannelModerate { get; init; }
        public bool ChatEdit { get; init; }
        public bool ChatRead { get; init; }
        public bool UserBot { get; init; }
        public bool UserReadChat { get; init; }
        public bool WhispersRead { get; init; }
        public bool WhispersEdit { get; init; }

        internal TwitchScopes(TwitchScopesBuilder scopesBuilder)
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
        public string GetLineOfScopes()
        {
            string result = string.Empty;

            if (AnalyticsReadExtensions) result += "analytics:read:extensions ";
            if (AnalyticsReadGames) result += "analytics:read:games ";
            if (BitsRead) result += "bits:read ";
            if (ChannelManageAds) result += "channel:manage:ads ";
            if (ChannelReadAds) result += "channel:read:ads ";
            if (ChannelManageBroadcast) result += "channel:manage:broadcast ";
            if (ChannelReadCharity) result += "channel:read:charity ";
            if (ChannelEditCommercial) result += "channel:edit:commercial ";
            if (ChannelReadEditors) result += "channel:read:editors ";
            if (ChannelManageExtensions) result += "channel:manage:extensions ";
            if (ChannelReadGoals) result += "channel:read:goals ";
            if (ChannelReadGuestStar) result += "channel:read:guest_star ";
            if (ChannelManageGuestStar) result += "channel:manage:guest_star ";
            if (ChannelReadHypeTrain) result += "channel:read:hype_train ";
            if (ChannelManageModerators) result += "channel:manage:moderators ";
            if (ChannelReadPolls) result += "channel:read:polls ";
            if (ChannelManagePolls) result += "channel:manage:polls ";
            if (ChannelReadPredictions) result += "channel:read:predictions ";
            if (ChannelManagePredictions) result += "channel:manage:predictions ";
            if (ChannelManageRaids) result += "channel:manage:raids ";
            if (ChannelReadRedemptions) result += "channel:read:redemptions ";
            if (ChannelManageRedemptions) result += "channel:manage:redemptions ";
            if (ChannelManageSchedule) result += "channel:manage:schedule ";
            if (ChannelReadStreamKey) result += "channel:read:stream_key ";
            if (ChannelReadSubscriptions) result += "channel:read:subscriptions ";
            if (ChannelManageVideos) result += "channel:manage:videos ";
            if (ChannelReadVips) result += "channel:read:vips ";
            if (ChannelManageVips) result += "channel:manage:vips ";
            if (ClipsEdit) result += "clips:edit ";
            if (ModerationRead) result += "moderation:read ";
            if (ModeratorManageAnnouncements) result += "moderator:manage:announcements ";
            if (ModeratorManageAutomod) result += "moderator:manage:automod ";
            if (ModeratorReadAutomodSettings) result += "moderator:read:automod_settings ";
            if (ModeratorManageAutomodSettings) result += "moderator:manage:automod_settings ";
            if (ModeratorManageBannedUsers) result += "moderator:manage:banned_users ";
            if (ModeratorReadBlockedTerms) result += "moderator:read:blocked_terms ";
            if (ModeratorManageBlockedTerms) result += "moderator:manage:blocked_terms ";
            if (ModeratorManageChatMessages) result += "moderator:manage:chat_messages ";
            if (ModeratorReadChatSettings) result += "moderator:read:chat_settings ";
            if (ModeratorManageChatSettings) result += "moderator:manage:chat_settings ";
            if (ModeratorReadChatters) result += "moderator:read:chatters ";
            if (ModeratorReadFollowers) result += "moderator:read:followers ";
            if (ModeratorReadGuestStar) result += "moderator:read:guest_star ";
            if (ModeratorManageGuestStar) result += "moderator:manage:guest_star ";
            if (ModeratorReadShieldMode) result += "moderator:read:shield_mode ";
            if (ModeratorManageShieldMode) result += "moderator:manage:shield_mode ";
            if (ModeratorReadShoutouts) result += "moderator:read:shoutouts ";
            if (ModeratorManageShoutouts) result += "moderator:manage:shoutouts ";
            if (UserEdit) result += "user:edit ";
            if (UserEditFollows) result += "user:edit:follows ";
            if (UserReadBlockedUsers) result += "user:read:blocked_users ";
            if (UserManageBlockedUsers) result += "user:manage:blocked_users ";
            if (UserReadBroadcast) result += "user:read:broadcast ";
            if (UserManageChatColor) result += "user:manage:chat_color ";
            if (UserReadEmail) result += "user:read:email ";
            if (UserReadFollows) result += "user:read:follows ";
            if (UserReadSubscriptions) result += "user:read:subscriptions ";
            if (UserManageWhispers) result += "user:manage:whispers ";
            if (ChannelBot) result += "channel:bot ";
            if (ChannelModerate) result += "channel:moderate ";
            if (ChatEdit) result += "chat:edit ";
            if (ChatRead) result += "chat:read ";
            if (UserBot) result += "user:bot ";
            if (UserReadChat) result += "user:read:chat ";
            if (WhispersRead) result += "whispers:read ";
            if (WhispersEdit) result += "whispers:edit ";

            return result.TrimEnd();
        }
        public string[] GetArrayOfScopes() => GetLineOfScopes().Split(' ');
    }
}
