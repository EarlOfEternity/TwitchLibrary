using static System.Formats.Asn1.AsnWriter;

namespace Twitch.Authentication
{
    public class ScopesBuilder
    {
        #region API Scopes
        public bool AnalyticsReadExtensions{ get; set; } = false;
        public bool AnalyticsReadGames{ get; set; } = false;
        public bool BitsRead{ get; set; } = false;
        public bool ChannelManageAds{ get; set; } = false;
        public bool ChannelReadAds{ get; set; } = false;
        public bool ChannelManageBroadcast{ get; set; } = false;
        public bool ChannelReadCharity{ get; set; } = false;
        public bool ChannelEditCommercial{ get; set; } = false;
        public bool ChannelReadEditors{ get; set; } = false;
        public bool ChannelManageExtensions{ get; set; } = false;
        public bool ChannelReadGoals{ get; set; } = false;
        public bool ChannelReadGuestStar{ get; set; } = false;
        public bool ChannelManageGuestStar{ get; set; } = false;
        public bool ChannelReadHypeTrain{ get; set; } = false;
        public bool ChannelManageModerators{ get; set; } = false;
        public bool ChannelReadPolls{ get; set; } = false;
        public bool ChannelManagePolls{ get; set; } = false;
        public bool ChannelReadPredictions{ get; set; } = false;
        public bool ChannelManagePredictions{ get; set; } = false;
        public bool ChannelManageRaids{ get; set; } = false;
        public bool ChannelReadRedemptions{ get; set; } = false;
        public bool ChannelManageRedemptions{ get; set; } = false;
        public bool ChannelManageSchedule{ get; set; } = false;
        public bool ChannelReadStreamKey{ get; set; } = false;
        public bool ChannelReadSubscriptions{ get; set; } = false;
        public bool ChannelManageVideos{ get; set; } = false;
        public bool ChannelReadVips{ get; set; } = false;
        public bool ChannelManageVips{ get; set; } = false;
        public bool ClipsEdit{ get; set; } = false;
        public bool ModerationRead{ get; set; } = false;
        public bool ModeratorManageAnnouncements{ get; set; } = false;
        public bool ModeratorManageAutomod{ get; set; } = false;
        public bool ModeratorReadAutomodSettings{ get; set; } = false;
        public bool ModeratorManageAutomodSettings{ get; set; } = false;
        public bool ModeratorManageBannedUsers{ get; set; } = false;
        public bool ModeratorReadBlockedTerms{ get; set; } = false;
        public bool ModeratorManageBlockedTerms{ get; set; } = false;
        public bool ModeratorManageChatMessages{ get; set; } = false;
        public bool ModeratorReadChatSettings{ get; set; } = false;
        public bool ModeratorManageChatSettings{ get; set; } = false;
        public bool ModeratorReadChatters{ get; set; } = false;
        public bool ModeratorReadFollowers{ get; set; } = false;
        public bool ModeratorReadGuestStar{ get; set; } = false;
        public bool ModeratorManageGuestStar{ get; set; } = false;
        public bool ModeratorReadShieldMode{ get; set; } = false;
        public bool ModeratorManageShieldMode{ get; set; } = false;
        public bool ModeratorReadShoutouts{ get; set; } = false;
        public bool ModeratorManageShoutouts{ get; set; } = false;
        public bool UserEdit{ get; set; } = false;
        public bool UserEditFollows{ get; set; } = false;
        public bool UserReadBlockedUsers{ get; set; } = false;
        public bool UserManageBlockedUsers{ get; set; } = false;
        public bool UserReadBroadcast{ get; set; } = false;
        public bool UserManageChatColor{ get; set; } = false;
        public bool UserReadEmail{ get; set; } = false;
        public bool UserReadFollows{ get; set; } = false;
        public bool UserReadSubscriptions{ get; set; } = false;
        public bool UserManageWhispers{ get; set; } = false;
        #endregion

        #region Chat&PubSub Scopes
        public bool ChannelBot{ get; set; } = false;
        public bool ChannelModerate{ get; set; } = false;
        public bool ChatEdit{ get; set; } = false;
        public bool ChatRead{ get; set; } = false;
        public bool UserBot{ get; set; } = false;
        public bool UserReadChat{ get; set; } = false;
        public bool WhispersRead{ get; set; } = false;
        public bool WhispersEdit{ get; set; } = false;
        #endregion

        public ScopesBuilder() 
        {
            
        }
        public ScopesBuilder(string[] scopes)
        {
            foreach (string scope in scopes)
            {
                SetByName(scope);
            }
        }
        public void SetByName(string scope)
        {
            switch (scope)
            {
                case "analytics:read:extensions":
                    AnalyticsReadExtensions = !AnalyticsReadExtensions;
                    return;
                case "analytics:read:games":
                    AnalyticsReadGames = !AnalyticsReadGames;
                    return;
                case "bits:read":
                    BitsRead = !BitsRead;
                    return;
                case "channel:manage:ads":
                    ChannelManageAds = !ChannelManageAds;
                    return;
                case "channel:read:ads":
                    ChannelReadAds = !ChannelReadAds;
                    return;
                case "channel:manage:broadcast":
                    ChannelManageBroadcast = !ChannelManageBroadcast;
                    return;
                case "channel:read:charity":
                    ChannelReadCharity = !ChannelReadCharity;
                    return;
                case "channel:edit:commercial":
                    ChannelEditCommercial = !ChannelEditCommercial;
                    return;
                case "channel:read:editors":
                    ChannelReadEditors = !ChannelReadEditors;
                    return;
                case "channel:manage:extensions":
                    ChannelManageExtensions = !ChannelManageExtensions;
                    return;
                case "channel:read:goals":
                    ChannelReadGoals = !ChannelReadGoals;
                    return;
                case "channel:read:guest_star":
                    ChannelReadGuestStar = !ChannelReadGuestStar;
                    return;
                case "channel:manage:guest_star":
                    ChannelManageGuestStar = !ChannelManageGuestStar;
                    return;
                case "channel:read:hype_train":
                    ChannelReadHypeTrain = !ChannelReadHypeTrain;
                    return;
                case "channel:manage:moderators":
                    ChannelManageModerators = !ChannelManageModerators;
                    return;
                case "channel:read:polls":
                    ChannelReadPolls = !ChannelReadPolls;
                    return;
                case "channel:manage:polls":
                    ChannelManagePolls = !ChannelManagePolls;
                    return;
                case "channel:read:predictions":
                    ChannelReadPredictions = !ChannelReadPredictions;
                    return;
                case "channel:manage:predictions":
                    ChannelManagePredictions = !ChannelManagePredictions;
                    return;
                case "channel:manage:raids":
                    ChannelManageRaids = !ChannelManageRaids;
                    return;
                case "channel:read:redemptions":
                    ChannelReadRedemptions = !ChannelReadRedemptions;
                    return;
                case "channel:manage:redemptions":
                    ChannelManageRedemptions = !ChannelManageRedemptions;
                    return;
                case "channel:manage:schedule":
                    ChannelManageSchedule = !ChannelManageSchedule;
                    return;
                case "channel:read:stream_key":
                    ChannelReadStreamKey = !ChannelReadStreamKey;
                    return;
                case "channel:read:subscriptions":
                    ChannelReadSubscriptions = !ChannelReadSubscriptions;
                    return;
                case "channel:manage:videos":
                    ChannelManageVideos = !ChannelManageVideos;
                    return;
                case "channel:read:vips":
                    ChannelReadVips = !ChannelReadVips;
                    return;
                case "channel:manage:vips":
                    ChannelManageVips = !ChannelManageVips;
                    return;
                case "clips:edit":
                    ClipsEdit = !ClipsEdit;
                    return;
                case "moderation:read":
                    ModerationRead = !ModerationRead;
                    return;
                case "moderator:manage:announcements":
                    ModeratorManageAnnouncements = !ModeratorManageAnnouncements;
                    return;
                case "moderator:manage:automod":
                    ModeratorManageAutomod = !ModeratorManageAutomod;
                    return;
                case "moderator:read:automod_settings":
                    ModeratorReadAutomodSettings = !ModeratorReadAutomodSettings;
                    return;
                case "moderator:manage:automod_settings":
                    ModeratorManageAutomodSettings = !ModeratorManageAutomodSettings;
                    return;
                case "moderator:manage:banned_users":
                    ModeratorManageBannedUsers = !ModeratorManageBannedUsers;
                    return;
                case "moderator:read:blocked_terms":
                    ModeratorReadBlockedTerms = !ModeratorReadBlockedTerms;
                    return;
                case "moderator:manage:blocked_terms":
                    ModeratorManageBlockedTerms = !ModeratorManageBlockedTerms;
                    return;
                case "moderator:manage:chat_messages":
                    ModeratorManageChatMessages = !ModeratorManageChatMessages;
                    return;
                case "moderator:read:chat_settings":
                    ModeratorReadChatSettings = !ModeratorReadChatSettings;
                    return;
                case "moderator:manage:chat_settings":
                    ModeratorManageChatSettings = !ModeratorManageChatSettings;
                    return;
                case "moderator:read:chatters":
                    ModeratorReadChatters = !ModeratorReadChatters;
                    return;
                case "moderator:read:followers":
                    ModeratorReadFollowers = !ModeratorReadFollowers;
                    return;
                case "moderator:read:guest_star":
                    ModeratorReadGuestStar = !ModeratorReadGuestStar;
                    return;
                case "moderator:manage:guest_star":
                    ModeratorManageGuestStar = !ModeratorManageGuestStar;
                    return;
                case "moderator:read:shield_mode":
                    ModeratorReadShieldMode = !ModeratorReadShieldMode;
                    return;
                case "moderator:manage:shield_mode":
                    ModeratorManageShieldMode = !ModeratorManageShieldMode;
                    return;
                case "moderator:read:shoutouts":
                    ModeratorReadShoutouts = !ModeratorReadShoutouts;
                    return;
                case "moderator:manage:shoutouts":
                    ModeratorManageShoutouts = !ModeratorManageShoutouts;
                    return;
                case "user:edit":
                    UserEdit = !UserEdit;
                    return;
                case "user:edit:follows":
                    UserEditFollows = !UserEditFollows;
                    return;
                case "user:read:blocked_users":
                    UserReadBlockedUsers = !UserReadBlockedUsers;
                    return;
                case "user:manage:blocked_users":
                    UserManageBlockedUsers = !UserManageBlockedUsers;
                    return;
                case "user:read:broadcast":
                    UserReadBroadcast = !UserReadBroadcast;
                    return;
                case "user:manage:chat_color":
                    UserManageChatColor = !UserManageChatColor;
                    return;
                case "user:read:email":
                    UserReadEmail = !UserReadEmail;
                    return;
                case "user:read:follows":
                    UserReadFollows = !UserReadFollows;
                    return;
                case "user:read:subscriptions":
                    UserReadSubscriptions = !UserReadSubscriptions;
                    return;
                case "user:manage:whispers":
                    UserManageWhispers = !UserManageWhispers;
                    return;
                case "channel:bot":
                    ChannelBot = !ChannelBot;
                    return;
                case "channel:moderate":
                    ChannelModerate = !ChannelModerate;
                    return;
                case "chat:edit":
                    ChatEdit = !ChatEdit;
                    return;
                case "chat:read":
                    ChatRead = !ChatRead;
                    return;
                case "user:bot":
                    UserBot = !UserBot;
                    return;
                case "user:read:chat":
                    UserReadChat = !UserReadChat;
                    return;
                case "whispers:read":
                    WhispersRead = !WhispersRead;
                    return;
                case "whispers:edit":
                    WhispersEdit = !WhispersEdit;
                    return;
            }

        }
        public static bool operator ==(ScopesBuilder scopesB1, ScopesBuilder scopesB2) => scopesB1.Equals(scopesB2);
        public static bool operator !=(ScopesBuilder scopesB1, ScopesBuilder scopesB2) => !scopesB1.Equals(scopesB2);

        public static ScopesBuilder Create(string line) => new(line.Split(' '));
        public string GetScopes()
        {
            string scopes = "";

            if (AnalyticsReadExtensions) scopes += " analytics:read:extensions";
            if (AnalyticsReadGames) scopes += " analytics:read:games";
            if (BitsRead) scopes += " bits:read";
            if (ChannelManageAds) scopes += " channel:manage:ads";
            if (ChannelReadAds) scopes += " channel:read:ads";
            if (ChannelManageBroadcast) scopes += " channel:manage:broadcast";
            if (ChannelReadCharity) scopes += " channel:read:charity";
            if (ChannelEditCommercial) scopes += " channel:edit:commercial";
            if (ChannelReadEditors) scopes += " channel:read:editors";
            if (ChannelManageExtensions) scopes += " channel:manage:extensions";
            if (ChannelReadGoals) scopes += " channel:read:goals";
            if (ChannelReadGuestStar) scopes += " channel:read:guest_star";
            if (ChannelManageGuestStar) scopes += " channel:manage:guest_star";
            if (ChannelReadHypeTrain) scopes += " channel:read:hype_train";
            if (ChannelManageModerators) scopes += " channel:manage:moderators";
            if (ChannelReadPolls) scopes += " channel:read:polls";
            if (ChannelManagePolls) scopes += " channel:manage:polls";
            if (ChannelReadPredictions) scopes += " channel:read:predictions";
            if (ChannelManagePredictions) scopes += " channel:manage:predictions";
            if (ChannelManageRaids) scopes += " channel:manage:raids";
            if (ChannelReadRedemptions) scopes += " channel:read:redemptions";
            if (ChannelManageRedemptions) scopes += " channel:manage:redemptions";
            if (ChannelManageSchedule) scopes += " channel:manage:schedule";
            if (ChannelReadStreamKey) scopes += " channel:read:stream_key";
            if (ChannelReadSubscriptions) scopes += " channel:read:subscriptions";
            if (ChannelManageVideos) scopes += " channel:manage:videos";
            if (ChannelReadVips) scopes += " channel:read:vips";
            if (ChannelManageVips) scopes += " channel:manage:vips";
            if (ClipsEdit) scopes += " clips:edit";
            if (ModerationRead) scopes += " moderation:read";
            if (ModeratorManageAnnouncements) scopes += " moderator:manage:announcements";
            if (ModeratorManageAutomod) scopes += " moderator:manage:automod";
            if (ModeratorReadAutomodSettings) scopes += " moderator:read:automod_settings";
            if (ModeratorManageAutomodSettings) scopes += " moderator:manage:automod_settings";
            if (ModeratorManageBannedUsers) scopes += " moderator:manage:banned_users";
            if (ModeratorReadBlockedTerms) scopes += " moderator:read:blocked_terms";
            if (ModeratorManageBlockedTerms) scopes += " moderator:manage:blocked_terms";
            if (ModeratorManageChatMessages) scopes += " moderator:manage:chat_messages";
            if (ModeratorReadChatSettings) scopes += " moderator:read:chat_settings";
            if (ModeratorManageChatSettings) scopes += " moderator:manage:chat_settings";
            if (ModeratorReadChatters) scopes += " moderator:read:chatters";
            if (ModeratorReadFollowers) scopes += " moderator:read:followers";
            if (ModeratorReadGuestStar) scopes += " moderator:read:guest_star";
            if (ModeratorManageGuestStar) scopes += " moderator:manage:guest_star";
            if (ModeratorReadShieldMode) scopes += " moderator:read:shield_mode";
            if (ModeratorManageShieldMode) scopes += " moderator:manage:shield_mode";
            if (ModeratorReadShoutouts) scopes += " moderator:read:shoutouts";
            if (ModeratorManageShoutouts) scopes += " moderator:manage:shoutouts";
            if (UserEdit) scopes += " user:edit";
            if (UserEditFollows) scopes += " user:edit:follows";
            if (UserReadBlockedUsers) scopes += " user:read:blocked_users";
            if (UserManageBlockedUsers) scopes += " user:manage:blocked_users";
            if (UserReadBroadcast) scopes += " user:read:broadcast";
            if (UserManageChatColor) scopes += " user:manage:chat_color";
            if (UserReadEmail) scopes += " user:read:email";
            if (UserReadFollows) scopes += " user:read:follows";
            if (UserReadSubscriptions) scopes += " user:read:subscriptions";
            if (UserManageWhispers) scopes += " user:manage:whispers";
            if (ChannelBot) scopes += " channel:bot";
            if (ChannelModerate) scopes += " channel:moderate";
            if (ChatEdit) scopes += " chat:edit";
            if (ChatRead) scopes += " chat:read";
            if (UserBot) scopes += " user:bot";
            if (UserReadChat) scopes += " user:read:chat";
            if (WhispersRead) scopes += " whispers:read";
            if (WhispersEdit) scopes += " whispers:edit";

            return scopes.Trim();
        }

        public override bool Equals(object? obj)
        {
            if (obj is ScopesBuilder scopesBuilder)
            {
                if (AnalyticsReadExtensions != scopesBuilder.AnalyticsReadExtensions) return false;
                if (AnalyticsReadGames != scopesBuilder.AnalyticsReadGames) return false;
                if (BitsRead != scopesBuilder.BitsRead) return false;
                if (ChannelManageAds != scopesBuilder.ChannelManageAds) return false;
                if (ChannelReadAds != scopesBuilder.ChannelReadAds) return false;
                if (ChannelManageBroadcast != scopesBuilder.ChannelManageBroadcast) return false;
                if (ChannelReadCharity != scopesBuilder.ChannelReadCharity) return false;
                if (ChannelEditCommercial != scopesBuilder.ChannelEditCommercial) return false;
                if (ChannelReadEditors != scopesBuilder.ChannelReadEditors) return false;
                if (ChannelManageExtensions != scopesBuilder.ChannelManageExtensions) return false;
                if (ChannelReadGoals != scopesBuilder.ChannelReadGoals) return false;
                if (ChannelReadGuestStar != scopesBuilder.ChannelReadGuestStar) return false;
                if (ChannelManageGuestStar != scopesBuilder.ChannelManageGuestStar) return false;
                if (ChannelReadHypeTrain != scopesBuilder.ChannelReadHypeTrain) return false;
                if (ChannelManageModerators != scopesBuilder.ChannelManageModerators) return false;
                if (ChannelReadPolls != scopesBuilder.ChannelReadPolls) return false;
                if (ChannelManagePolls != scopesBuilder.ChannelManagePolls) return false;
                if (ChannelReadPredictions != scopesBuilder.ChannelReadPredictions) return false;
                if (ChannelManagePredictions != scopesBuilder.ChannelManagePredictions) return false;
                if (ChannelManageRaids != scopesBuilder.ChannelManageRaids) return false;
                if (ChannelReadRedemptions != scopesBuilder.ChannelReadRedemptions) return false;
                if (ChannelManageRedemptions != scopesBuilder.ChannelManageRedemptions) return false;
                if (ChannelManageSchedule != scopesBuilder.ChannelManageSchedule) return false;
                if (ChannelReadStreamKey != scopesBuilder.ChannelReadStreamKey) return false;
                if (ChannelReadSubscriptions != scopesBuilder.ChannelReadSubscriptions) return false;
                if (ChannelManageVideos != scopesBuilder.ChannelManageVideos) return false;
                if (ChannelReadVips != scopesBuilder.ChannelReadVips) return false;
                if (ChannelManageVips != scopesBuilder.ChannelManageVips) return false;
                if (ClipsEdit != scopesBuilder.ClipsEdit) return false;
                if (ModerationRead != scopesBuilder.ModerationRead) return false;
                if (ModeratorManageAnnouncements != scopesBuilder.ModeratorManageAnnouncements) return false;
                if (ModeratorManageAutomod != scopesBuilder.ModeratorManageAutomod) return false;
                if (ModeratorReadAutomodSettings != scopesBuilder.ModeratorReadAutomodSettings) return false;
                if (ModeratorManageAutomodSettings != scopesBuilder.ModeratorManageAutomodSettings) return false;
                if (ModeratorManageBannedUsers != scopesBuilder.ModeratorManageBannedUsers) return false;
                if (ModeratorReadBlockedTerms != scopesBuilder.ModeratorReadBlockedTerms) return false;
                if (ModeratorManageBlockedTerms != scopesBuilder.ModeratorManageBlockedTerms) return false;
                if (ModeratorManageChatMessages != scopesBuilder.ModeratorManageChatMessages) return false;
                if (ModeratorReadChatSettings != scopesBuilder.ModeratorReadChatSettings) return false;
                if (ModeratorManageChatSettings != scopesBuilder.ModeratorManageChatSettings) return false;
                if (ModeratorReadChatters != scopesBuilder.ModeratorReadChatters) return false;
                if (ModeratorReadFollowers != scopesBuilder.ModeratorReadFollowers) return false;
                if (ModeratorReadGuestStar != scopesBuilder.ModeratorReadGuestStar) return false;
                if (ModeratorManageGuestStar != scopesBuilder.ModeratorManageGuestStar) return false;
                if (ModeratorReadShieldMode != scopesBuilder.ModeratorReadShieldMode) return false;
                if (ModeratorManageShieldMode != scopesBuilder.ModeratorManageShieldMode) return false;
                if (ModeratorReadShoutouts != scopesBuilder.ModeratorReadShoutouts) return false;
                if (ModeratorManageShoutouts != scopesBuilder.ModeratorManageShoutouts) return false;
                if (UserEdit != scopesBuilder.UserEdit) return false;
                if (UserEditFollows != scopesBuilder.UserEditFollows) return false;
                if (UserReadBlockedUsers != scopesBuilder.UserReadBlockedUsers) return false;
                if (UserManageBlockedUsers != scopesBuilder.UserManageBlockedUsers) return false;
                if (UserReadBroadcast != scopesBuilder.UserReadBroadcast) return false;
                if (UserManageChatColor != scopesBuilder.UserManageChatColor) return false;
                if (UserReadEmail != scopesBuilder.UserReadEmail) return false;
                if (UserReadFollows != scopesBuilder.UserReadFollows) return false;
                if (UserReadSubscriptions != scopesBuilder.UserReadSubscriptions) return false;
                if (UserManageWhispers != scopesBuilder.UserManageWhispers) return false;
                if (ChannelBot != scopesBuilder.ChannelBot) return false;
                if (ChannelModerate != scopesBuilder.ChannelModerate) return false;
                if (ChatEdit != scopesBuilder.ChatEdit) return false;
                if (ChatRead != scopesBuilder.ChatRead) return false;
                if (UserBot != scopesBuilder.UserBot) return false;
                if (UserReadChat != scopesBuilder.UserReadChat) return false;
                if (WhispersRead != scopesBuilder.WhispersRead) return false;
                if (WhispersEdit != scopesBuilder.WhispersEdit) return false;

                return true;
            }

            return false;
        }
        public override int GetHashCode() => base.GetHashCode();

    }
}
