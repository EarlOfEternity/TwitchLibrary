using System.Collections;
using System.Collections.ObjectModel;

namespace Twitch.Authentication.Access
{
    public class Scopes
    {
        public static class Name
        {
            public const string AnalyticsReadExtensions = "analytics:read:extensions";
            public const string AnalyticsReadGames = "analytics:read:games";
            public const string BitsRead = "bits:read";
            public const string ChannelManageAds = "channel:manage:ads";
            public const string ChannelReadAds = "channel:read:ads";
            public const string ChannelManageBroadcast = "channel:manage:broadcast";
            public const string ChannelReadCharity = "channel:read:charity";
            public const string ChannelEditCommercial = "channel:edit:commercial";
            public const string ChannelReadEditors = "channel:read:editors";
            public const string ChannelManageExtensions = "channel:manage:extensions";
            public const string ChannelReadGoals = "channel:read:goals";
            public const string ChannelReadGuestStar = "channel:read:guest_star";
            public const string ChannelManageGuestStar = "channel:manage:guest_star";
            public const string ChannelReadHypeTrain = "channel:read:hype_train";
            public const string ChannelManageModerators = "channel:manage:moderators";
            public const string ChannelReadPolls = "channel:read:polls";
            public const string ChannelManagePolls = "channel:manage:polls";
            public const string ChannelReadPredictions = "channel:read:predictions";
            public const string ChannelManagePredictions = "channel:manage:predictions";
            public const string ChannelManageRaids = "channel:manage:raids";
            public const string ChannelReadRedemptions = "channel:read:redemptions";
            public const string ChannelManageRedemptions = "channel:manage:redemptions";
            public const string ChannelManageSchedule = "channel:manage:schedule";
            public const string ChannelReadStreamKey = "channel:read:stream_key";
            public const string ChannelReadSubscriptions = "channel:read:subscriptions";
            public const string ChannelManageVideos = "channel:manage:videos";
            public const string ChannelReadVips = "channel:read:vips";
            public const string ChannelManageVips = "channel:manage:vips";
            public const string ClipsEdit = "clips:edit";
            public const string ModerationRead = "moderation:read";
            public const string ModeratorManageAnnouncements = "moderator:manage:announcements";
            public const string ModeratorManageAutomod = "moderator:manage:automod";
            public const string ModeratorReadAutomodSettings = "moderator:read:automod_settings";
            public const string ModeratorManageAutomodSettings = "moderator:manage:automod_settings";
            public const string ModeratorManageBannedUsers = "moderator:manage:banned_users";
            public const string ModeratorReadBlockedTerms = "moderator:read:blocked_terms";
            public const string ModeratorManageBlockedTerms = "moderator:manage:blocked_terms";
            public const string ModeratorManageChatMessages = "moderator:manage:chat_messages";
            public const string ModeratorReadChatSettings = "moderator:read:chat_settings";
            public const string ModeratorManageChatSettings = "moderator:manage:chat_settings";
            public const string ModeratorReadChatters = "moderator:read:chatters";
            public const string ModeratorReadFollowers = "moderator:read:followers";
            public const string ModeratorReadGuestStar = "moderator:read:guest_star";
            public const string ModeratorManageGuestStar = "moderator:manage:guest_star";
            public const string ModeratorReadShieldMode = "moderator:read:shield_mode";
            public const string ModeratorManageShieldMode = "moderator:manage:shield_mode";
            public const string ModeratorReadShoutouts = "moderator:read:shoutouts";
            public const string ModeratorManageShoutouts = "moderator:manage:shoutouts";
            public const string UserEdit = "user:edit";
            public const string UserEditFollows = "user:edit:follows";
            public const string UserReadBlockedUsers = "user:read:blocked_users";
            public const string UserManageBlockedUsers = "user:manage:blocked_users";
            public const string UserReadBroadcast = "user:read:broadcast";
            public const string UserManageChatColor = "user:manage:chat_color";
            public const string UserReadEmail = "user:read:email";
            public const string UserReadFollows = "user:read:follows";
            public const string UserReadSubscriptions = "user:read:subscriptions";
            public const string UserManageWhispers = "user:manage:whispers";
            public const string ChannelBot = "channel:bot";
            public const string ChannelModerate = "channel:moderate";
            public const string ChatEdit = "chat:edit";
            public const string ChatRead = "chat:read";
            public const string UserBot = "user:bot";
            public const string UserReadChat = "user:read:chat";
            public const string WhispersRead = "whispers:read";
            public const string WhispersEdit = "whispers:edit";
        }
        public class Builder
        {
            public bool AnalyticsReadExtensions { get; set; }
            public bool AnalyticsReadGames { get; set; }
            public bool BitsRead { get; set; }
            public bool ChannelManageAds { get; set; }
            public bool ChannelReadAds { get; set; }
            public bool ChannelManageBroadcast { get; set; }
            public bool ChannelReadCharity { get; set; }
            public bool ChannelEditCommercial { get; set; }
            public bool ChannelReadEditors { get; set; }
            public bool ChannelManageExtensions { get; set; }
            public bool ChannelReadGoals { get; set; }
            public bool ChannelReadGuestStar { get; set; }
            public bool ChannelManageGuestStar { get; set; }
            public bool ChannelReadHypeTrain { get; set; }
            public bool ChannelManageModerators { get; set; }
            public bool ChannelReadPolls { get; set; }
            public bool ChannelManagePolls { get; set; }
            public bool ChannelReadPredictions { get; set; }
            public bool ChannelManagePredictions { get; set; }
            public bool ChannelManageRaids { get; set; }
            public bool ChannelReadRedemptions { get; set; }
            public bool ChannelManageRedemptions { get; set; }
            public bool ChannelManageSchedule { get; set; }
            public bool ChannelReadStreamKey { get; set; }
            public bool ChannelReadSubscriptions { get; set; }
            public bool ChannelManageVideos { get; set; }
            public bool ChannelReadVips { get; set; }
            public bool ChannelManageVips { get; set; }
            public bool ClipsEdit { get; set; }
            public bool ModerationRead { get; set; }
            public bool ModeratorManageAnnouncements { get; set; }
            public bool ModeratorManageAutomod { get; set; }
            public bool ModeratorReadAutomodSettings { get; set; }
            public bool ModeratorManageAutomodSettings { get; set; }
            public bool ModeratorManageBannedUsers { get; set; }
            public bool ModeratorReadBlockedTerms { get; set; }
            public bool ModeratorManageBlockedTerms { get; set; }
            public bool ModeratorManageChatMessages { get; set; }
            public bool ModeratorReadChatSettings { get; set; }
            public bool ModeratorManageChatSettings { get; set; }
            public bool ModeratorReadChatters { get; set; }
            public bool ModeratorReadFollowers { get; set; }
            public bool ModeratorReadGuestStar { get; set; }
            public bool ModeratorManageGuestStar { get; set; }
            public bool ModeratorReadShieldMode { get; set; }
            public bool ModeratorManageShieldMode { get; set; }
            public bool ModeratorReadShoutouts { get; set; }
            public bool ModeratorManageShoutouts { get; set; }
            public bool UserEdit { get; set; }
            public bool UserEditFollows { get; set; }
            public bool UserReadBlockedUsers { get; set; }
            public bool UserManageBlockedUsers { get; set; }
            public bool UserReadBroadcast { get; set; }
            public bool UserManageChatColor { get; set; }
            public bool UserReadEmail { get; set; }
            public bool UserReadFollows { get; set; }
            public bool UserReadSubscriptions { get; set; }
            public bool UserManageWhispers { get; set; }
            public bool ChannelBot { get; set; }
            public bool ChannelModerate { get; set; }
            public bool ChatEdit { get; set; }
            public bool ChatRead { get; set; }
            public bool UserBot { get; set; }
            public bool UserReadChat { get; set; }
            public bool WhispersRead { get; set; }
            public bool WhispersEdit { get; set; }

            public Scopes Build() => new()
            {
                AnalyticsReadExtensions = AnalyticsReadExtensions,
                AnalyticsReadGames = AnalyticsReadGames,
                BitsRead = BitsRead,
                ChannelManageAds = ChannelManageAds,
                ChannelReadAds = ChannelReadAds,
                ChannelManageBroadcast = ChannelManageBroadcast,
                ChannelReadCharity = ChannelReadCharity,
                ChannelEditCommercial = ChannelEditCommercial,
                ChannelReadEditors = ChannelReadEditors,
                ChannelManageExtensions = ChannelManageExtensions,
                ChannelReadGoals = ChannelReadGoals,
                ChannelReadGuestStar = ChannelReadGuestStar,
                ChannelManageGuestStar = ChannelManageGuestStar,
                ChannelReadHypeTrain = ChannelReadHypeTrain,
                ChannelManageModerators = ChannelManageModerators,
                ChannelReadPolls = ChannelReadPolls,
                ChannelManagePolls = ChannelManagePolls,
                ChannelReadPredictions = ChannelReadPredictions,
                ChannelManagePredictions = ChannelManagePredictions,
                ChannelManageRaids = ChannelManageRaids,
                ChannelReadRedemptions = ChannelReadRedemptions,
                ChannelManageRedemptions = ChannelManageRedemptions,
                ChannelManageSchedule = ChannelManageSchedule,
                ChannelReadStreamKey = ChannelReadStreamKey,
                ChannelReadSubscriptions = ChannelReadSubscriptions,
                ChannelManageVideos = ChannelManageVideos,
                ChannelReadVips = ChannelReadVips,
                ChannelManageVips = ChannelManageVips,
                ClipsEdit = ClipsEdit,
                ModerationRead = ModerationRead,
                ModeratorManageAnnouncements = ModeratorManageAnnouncements,
                ModeratorManageAutomod = ModeratorManageAutomod,
                ModeratorReadAutomodSettings = ModeratorReadAutomodSettings,
                ModeratorManageAutomodSettings = ModeratorManageAutomodSettings,
                ModeratorManageBannedUsers = ModeratorManageBannedUsers,
                ModeratorReadBlockedTerms = ModeratorReadBlockedTerms,
                ModeratorManageBlockedTerms = ModeratorManageBlockedTerms,
                ModeratorManageChatMessages = ModeratorManageChatMessages,
                ModeratorReadChatSettings = ModeratorReadChatSettings,
                ModeratorManageChatSettings = ModeratorManageChatSettings,
                ModeratorReadChatters = ModeratorReadChatters,
                ModeratorReadFollowers = ModeratorReadFollowers,
                ModeratorReadGuestStar = ModeratorReadGuestStar,
                ModeratorManageGuestStar = ModeratorManageGuestStar,
                ModeratorReadShieldMode = ModeratorReadShieldMode,
                ModeratorManageShieldMode = ModeratorManageShieldMode,
                ModeratorReadShoutouts = ModeratorReadShoutouts,
                ModeratorManageShoutouts = ModeratorManageShoutouts,
                UserEdit = UserEdit,
                UserEditFollows = UserEditFollows,
                UserReadBlockedUsers = UserReadBlockedUsers,
                UserManageBlockedUsers = UserManageBlockedUsers,
                UserReadBroadcast = UserReadBroadcast,
                UserManageChatColor = UserManageChatColor,
                UserReadEmail = UserReadEmail,
                UserReadFollows = UserReadFollows,
                UserReadSubscriptions = UserReadSubscriptions,
                UserManageWhispers = UserManageWhispers,
                ChannelBot = ChannelBot,
                ChannelModerate = ChannelModerate,
                ChatEdit = ChatEdit,
                ChatRead = ChatRead,
                UserBot = UserBot,
                UserReadChat = UserReadChat,
                WhispersRead = WhispersRead,
                WhispersEdit = WhispersEdit
            };
        }

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

        public Scopes() { }
        public Scopes(string line) : this(line.Split(' ')) { }  
        public Scopes(IEnumerable<string> scopes)
        {
            foreach (string scope in scopes)
            {
                switch (scope)
                {
                    case Name.AnalyticsReadExtensions:
                        AnalyticsReadExtensions = true;
                        break;
                    case Name.AnalyticsReadGames:
                        AnalyticsReadGames = true;
                        break;
                    case Name.BitsRead:
                        BitsRead = true;
                        break;
                    case Name.ChannelManageAds:
                        ChannelManageAds = true;
                        break;
                    case Name.ChannelReadAds:
                        ChannelReadAds = true;
                        break;
                    case Name.ChannelManageBroadcast:
                        ChannelManageBroadcast = true;
                        break;
                    case Name.ChannelReadCharity:
                        ChannelReadCharity = true;
                        break;
                    case Name.ChannelEditCommercial:
                        ChannelEditCommercial = true;
                        break;
                    case Name.ChannelReadEditors:
                        ChannelReadEditors = true;
                        break;
                    case Name.ChannelManageExtensions:
                        ChannelManageExtensions = true;
                        break;
                    case Name.ChannelReadGoals:
                        ChannelReadGoals = true;
                        break;
                    case Name.ChannelReadGuestStar:
                        ChannelReadGuestStar = true;
                        break;
                    case Name.ChannelManageGuestStar:
                        ChannelManageGuestStar = true;
                        break;
                    case Name.ChannelReadHypeTrain:
                        ChannelReadHypeTrain = true;
                        break;
                    case Name.ChannelManageModerators:
                        ChannelManageModerators = true;
                        break;
                    case Name.ChannelReadPolls:
                        ChannelReadPolls = true;
                        break;
                    case Name.ChannelManagePolls:
                        ChannelManagePolls = true;
                        break;
                    case Name.ChannelReadPredictions:
                        ChannelReadPredictions = true;
                        break;
                    case Name.ChannelManagePredictions:
                        ChannelManagePredictions = true;
                        break;
                    case Name.ChannelManageRaids:
                        ChannelManageRaids = true;
                        break;
                    case Name.ChannelReadRedemptions:
                        ChannelReadRedemptions = true;
                        break;
                    case Name.ChannelManageRedemptions:
                        ChannelManageRedemptions = true;
                        break;
                    case Name.ChannelManageSchedule:
                        ChannelManageSchedule = true;
                        break;
                    case Name.ChannelReadStreamKey:
                        ChannelReadStreamKey = true;
                        break;
                    case Name.ChannelReadSubscriptions:
                        ChannelReadSubscriptions = true;
                        break;
                    case Name.ChannelManageVideos:
                        ChannelManageVideos = true;
                        break;
                    case Name.ChannelReadVips:
                        ChannelReadVips = true;
                        break;
                    case Name.ChannelManageVips:
                        ChannelManageVips = true;
                        break;
                    case Name.ClipsEdit:
                        ClipsEdit = true;
                        break;
                    case Name.ModerationRead:
                        ModerationRead = true;
                        break;
                    case Name.ModeratorManageAnnouncements:
                        ModeratorManageAnnouncements = true;
                        break;
                    case Name.ModeratorManageAutomod:
                        ModeratorManageAutomod = true;
                        break;
                    case Name.ModeratorReadAutomodSettings:
                        ModeratorReadAutomodSettings = true;
                        break;
                    case Name.ModeratorManageAutomodSettings:
                        ModeratorManageAutomodSettings = true;
                        break;
                    case Name.ModeratorManageBannedUsers:
                        ModeratorManageBannedUsers = true;
                        break;
                    case Name.ModeratorReadBlockedTerms:
                        ModeratorReadBlockedTerms = true;
                        break;
                    case Name.ModeratorManageBlockedTerms:
                        ModeratorManageBlockedTerms = true;
                        break;
                    case Name.ModeratorManageChatMessages:
                        ModeratorManageChatMessages = true;
                        break;
                    case Name.ModeratorReadChatSettings:
                        ModeratorReadChatSettings = true;
                        break;
                    case Name.ModeratorManageChatSettings:
                        ModeratorManageChatSettings = true;
                        break;
                    case Name.ModeratorReadChatters:
                        ModeratorReadChatters = true;
                        break;
                    case Name.ModeratorReadFollowers:
                        ModeratorReadFollowers = true;
                        break;
                    case Name.ModeratorReadGuestStar:
                        ModeratorReadGuestStar = true;
                        break;
                    case Name.ModeratorManageGuestStar:
                        ModeratorManageGuestStar = true;
                        break;
                    case Name.ModeratorReadShieldMode:
                        ModeratorReadShieldMode = true;
                        break;
                    case Name.ModeratorManageShieldMode:
                        ModeratorManageShieldMode = true;
                        break;
                    case Name.ModeratorReadShoutouts:
                        ModeratorReadShoutouts = true;
                        break;
                    case Name.ModeratorManageShoutouts:
                        ModeratorManageShoutouts = true;
                        break;
                    case Name.UserEdit:
                        UserEdit = true;
                        break;
                    case Name.UserEditFollows:
                        UserEditFollows = true;
                        break;
                    case Name.UserReadBlockedUsers:
                        UserReadBlockedUsers = true;
                        break;
                    case Name.UserManageBlockedUsers:
                        UserManageBlockedUsers = true;
                        break;
                    case Name.UserReadBroadcast:
                        UserReadBroadcast = true;
                        break;
                    case Name.UserManageChatColor:
                        UserManageChatColor = true;
                        break;
                    case Name.UserReadEmail:
                        UserReadEmail = true;
                        break;
                    case Name.UserReadFollows:
                        UserReadFollows = true;
                        break;
                    case Name.UserReadSubscriptions:
                        UserReadSubscriptions = true;
                        break;
                    case Name.UserManageWhispers:
                        UserManageWhispers = true;
                        break;
                    case Name.ChannelBot:
                        ChannelBot = true;
                        break;
                    case Name.ChannelModerate:
                        ChannelModerate = true;
                        break;
                    case Name.ChatEdit:
                        ChatEdit = true;
                        break;
                    case Name.ChatRead:
                        ChatRead = true;
                        break;
                    case Name.UserBot:
                        UserBot = true;
                        break;
                    case Name.UserReadChat:
                        UserReadChat = true;
                        break;
                    case Name.WhispersRead:
                        WhispersRead = true;
                        break;
                    case Name.WhispersEdit:
                        WhispersEdit = true;
                        break;
                }
            }
        }

        public static bool operator ==(Scopes scopesB1, Scopes scopesB2) => scopesB1.Equals(scopesB2);
        public static bool operator !=(Scopes scopesB1, Scopes scopesB2) => !scopesB1.Equals(scopesB2);

        public ReadOnlyCollection<string> GetReadOnlyCollection()
        {
            List<string> scopes = [];

            if (AnalyticsReadExtensions) scopes.Add(Name.AnalyticsReadExtensions);
            if (AnalyticsReadGames) scopes.Add(Name.AnalyticsReadGames);
            if (BitsRead) scopes.Add(Name.BitsRead);
            if (ChannelManageAds) scopes.Add(Name.ChannelManageAds);
            if (ChannelReadAds) scopes.Add(Name.ChannelReadAds);
            if (ChannelManageBroadcast) scopes.Add(Name.ChannelManageBroadcast);
            if (ChannelReadCharity) scopes.Add(Name.ChannelReadCharity);
            if (ChannelEditCommercial) scopes.Add(Name.ChannelEditCommercial);
            if (ChannelReadEditors) scopes.Add(Name.ChannelReadEditors);
            if (ChannelManageExtensions) scopes.Add(Name.ChannelManageExtensions);
            if (ChannelReadGoals) scopes.Add(Name.ChannelReadGoals);
            if (ChannelReadGuestStar) scopes.Add(Name.ChannelReadGuestStar);
            if (ChannelManageGuestStar) scopes.Add(Name.ChannelManageGuestStar);
            if (ChannelReadHypeTrain) scopes.Add(Name.ChannelReadHypeTrain);
            if (ChannelManageModerators) scopes.Add(Name.ChannelManageModerators);
            if (ChannelReadPolls) scopes.Add(Name.ChannelReadPolls);
            if (ChannelManagePolls) scopes.Add(Name.ChannelManagePolls);
            if (ChannelReadPredictions) scopes.Add(Name.ChannelReadPredictions);
            if (ChannelManagePredictions) scopes.Add(Name.ChannelManagePredictions);
            if (ChannelManageRaids) scopes.Add(Name.ChannelManageRaids);
            if (ChannelReadRedemptions) scopes.Add(Name.ChannelReadRedemptions);
            if (ChannelManageRedemptions) scopes.Add(Name.ChannelManageRedemptions);
            if (ChannelManageSchedule) scopes.Add(Name.ChannelManageSchedule);
            if (ChannelReadStreamKey) scopes.Add(Name.ChannelReadStreamKey);
            if (ChannelReadSubscriptions) scopes.Add(Name.ChannelReadSubscriptions);
            if (ChannelManageVideos) scopes.Add(Name.ChannelManageVideos);
            if (ChannelReadVips) scopes.Add(Name.ChannelReadVips);
            if (ChannelManageVips) scopes.Add(Name.ChannelManageVips);
            if (ClipsEdit) scopes.Add(Name.ClipsEdit);
            if (ModerationRead) scopes.Add(Name.ModerationRead);
            if (ModeratorManageAnnouncements) scopes.Add(Name.ModeratorManageAnnouncements);
            if (ModeratorManageAutomod) scopes.Add(Name.ModeratorManageAutomod);
            if (ModeratorReadAutomodSettings) scopes.Add(Name.ModeratorReadAutomodSettings);
            if (ModeratorManageAutomodSettings) scopes.Add(Name.ModeratorManageAutomodSettings);
            if (ModeratorManageBannedUsers) scopes.Add(Name.ModeratorManageBannedUsers);
            if (ModeratorReadBlockedTerms) scopes.Add(Name.ModeratorReadBlockedTerms);
            if (ModeratorManageBlockedTerms) scopes.Add(Name.ModeratorManageBlockedTerms);
            if (ModeratorManageChatMessages) scopes.Add(Name.ModeratorManageChatMessages);
            if (ModeratorReadChatSettings) scopes.Add(Name.ModeratorReadChatSettings);
            if (ModeratorManageChatSettings) scopes.Add(Name.ModeratorManageChatSettings);
            if (ModeratorReadChatters) scopes.Add(Name.ModeratorReadChatters);
            if (ModeratorReadFollowers) scopes.Add(Name.ModeratorReadFollowers);
            if (ModeratorReadGuestStar) scopes.Add(Name.ModeratorReadGuestStar);
            if (ModeratorManageGuestStar) scopes.Add(Name.ModeratorManageGuestStar);
            if (ModeratorReadShieldMode) scopes.Add(Name.ModeratorReadShieldMode);
            if (ModeratorManageShieldMode) scopes.Add(Name.ModeratorManageShieldMode);
            if (ModeratorReadShoutouts) scopes.Add(Name.ModeratorReadShoutouts);
            if (ModeratorManageShoutouts) scopes.Add(Name.ModeratorManageShoutouts);
            if (UserEdit) scopes.Add(Name.UserEdit);
            if (UserEditFollows) scopes.Add(Name.UserEditFollows);
            if (UserReadBlockedUsers) scopes.Add(Name.UserReadBlockedUsers);
            if (UserManageBlockedUsers) scopes.Add(Name.UserManageBlockedUsers);
            if (UserReadBroadcast) scopes.Add(Name.UserReadBroadcast);
            if (UserManageChatColor) scopes.Add(Name.UserManageChatColor);
            if (UserReadEmail) scopes.Add(Name.UserReadEmail);
            if (UserReadFollows) scopes.Add(Name.UserReadFollows);
            if (UserReadSubscriptions) scopes.Add(Name.UserReadSubscriptions);
            if (UserManageWhispers) scopes.Add(Name.UserManageWhispers);
            if (ChannelBot) scopes.Add(Name.ChannelBot);
            if (ChannelModerate) scopes.Add(Name.ChannelModerate);
            if (ChatEdit) scopes.Add(Name.ChatEdit);
            if (ChatRead) scopes.Add(Name.ChatRead);
            if (UserBot) scopes.Add(Name.UserBot);
            if (UserReadChat) scopes.Add(Name.UserReadChat);
            if (WhispersRead) scopes.Add(Name.WhispersRead);
            if (WhispersEdit) scopes.Add(Name.WhispersEdit);

            return scopes.AsReadOnly();
        }
        public string GetString() => string.Join(' ', GetReadOnlyCollection());
        public override bool Equals(object? obj)
        {
            if (obj is Scopes permission)
            {
                if (AnalyticsReadExtensions != permission.AnalyticsReadExtensions) return false;
                if (AnalyticsReadGames != permission.AnalyticsReadGames) return false;
                if (BitsRead != permission.BitsRead) return false;
                if (ChannelManageAds != permission.ChannelManageAds) return false;
                if (ChannelReadAds != permission.ChannelReadAds) return false;
                if (ChannelManageBroadcast != permission.ChannelManageBroadcast) return false;
                if (ChannelReadCharity != permission.ChannelReadCharity) return false;
                if (ChannelEditCommercial != permission.ChannelEditCommercial) return false;
                if (ChannelReadEditors != permission.ChannelReadEditors) return false;
                if (ChannelManageExtensions != permission.ChannelManageExtensions) return false;
                if (ChannelReadGoals != permission.ChannelReadGoals) return false;
                if (ChannelReadGuestStar != permission.ChannelReadGuestStar) return false;
                if (ChannelManageGuestStar != permission.ChannelManageGuestStar) return false;
                if (ChannelReadHypeTrain != permission.ChannelReadHypeTrain) return false;
                if (ChannelManageModerators != permission.ChannelManageModerators) return false;
                if (ChannelReadPolls != permission.ChannelReadPolls) return false;
                if (ChannelManagePolls != permission.ChannelManagePolls) return false;
                if (ChannelReadPredictions != permission.ChannelReadPredictions) return false;
                if (ChannelManagePredictions != permission.ChannelManagePredictions) return false;
                if (ChannelManageRaids != permission.ChannelManageRaids) return false;
                if (ChannelReadRedemptions != permission.ChannelReadRedemptions) return false;
                if (ChannelManageRedemptions != permission.ChannelManageRedemptions) return false;
                if (ChannelManageSchedule != permission.ChannelManageSchedule) return false;
                if (ChannelReadStreamKey != permission.ChannelReadStreamKey) return false;
                if (ChannelReadSubscriptions != permission.ChannelReadSubscriptions) return false;
                if (ChannelManageVideos != permission.ChannelManageVideos) return false;
                if (ChannelReadVips != permission.ChannelReadVips) return false;
                if (ChannelManageVips != permission.ChannelManageVips) return false;
                if (ClipsEdit != permission.ClipsEdit) return false;
                if (ModerationRead != permission.ModerationRead) return false;
                if (ModeratorManageAnnouncements != permission.ModeratorManageAnnouncements) return false;
                if (ModeratorManageAutomod != permission.ModeratorManageAutomod) return false;
                if (ModeratorReadAutomodSettings != permission.ModeratorReadAutomodSettings) return false;
                if (ModeratorManageAutomodSettings != permission.ModeratorManageAutomodSettings) return false;
                if (ModeratorManageBannedUsers != permission.ModeratorManageBannedUsers) return false;
                if (ModeratorReadBlockedTerms != permission.ModeratorReadBlockedTerms) return false;
                if (ModeratorManageBlockedTerms != permission.ModeratorManageBlockedTerms) return false;
                if (ModeratorManageChatMessages != permission.ModeratorManageChatMessages) return false;
                if (ModeratorReadChatSettings != permission.ModeratorReadChatSettings) return false;
                if (ModeratorManageChatSettings != permission.ModeratorManageChatSettings) return false;
                if (ModeratorReadChatters != permission.ModeratorReadChatters) return false;
                if (ModeratorReadFollowers != permission.ModeratorReadFollowers) return false;
                if (ModeratorReadGuestStar != permission.ModeratorReadGuestStar) return false;
                if (ModeratorManageGuestStar != permission.ModeratorManageGuestStar) return false;
                if (ModeratorReadShieldMode != permission.ModeratorReadShieldMode) return false;
                if (ModeratorManageShieldMode != permission.ModeratorManageShieldMode) return false;
                if (ModeratorReadShoutouts != permission.ModeratorReadShoutouts) return false;
                if (ModeratorManageShoutouts != permission.ModeratorManageShoutouts) return false;
                if (UserEdit != permission.UserEdit) return false;
                if (UserEditFollows != permission.UserEditFollows) return false;
                if (UserReadBlockedUsers != permission.UserReadBlockedUsers) return false;
                if (UserManageBlockedUsers != permission.UserManageBlockedUsers) return false;
                if (UserReadBroadcast != permission.UserReadBroadcast) return false;
                if (UserManageChatColor != permission.UserManageChatColor) return false;
                if (UserReadEmail != permission.UserReadEmail) return false;
                if (UserReadFollows != permission.UserReadFollows) return false;
                if (UserReadSubscriptions != permission.UserReadSubscriptions) return false;
                if (UserManageWhispers != permission.UserManageWhispers) return false;
                if (ChannelBot != permission.ChannelBot) return false;
                if (ChannelModerate != permission.ChannelModerate) return false;
                if (ChatEdit != permission.ChatEdit) return false;
                if (ChatRead != permission.ChatRead) return false;
                if (UserBot != permission.UserBot) return false;
                if (UserReadChat != permission.UserReadChat) return false;
                if (WhispersRead != permission.WhispersRead) return false;
                if (WhispersEdit != permission.WhispersEdit) return false;

                return true;
            }
            return false;
        }
        public override int GetHashCode() => base.GetHashCode();
    }
}