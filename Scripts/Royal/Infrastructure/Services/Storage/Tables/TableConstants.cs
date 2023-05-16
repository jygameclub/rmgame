using UnityEngine;

namespace Royal.Infrastructure.Services.Storage.Tables
{
    public static class TableConstants
    {
        // Fields
        public const char Delimiter = '\xa7';
        public const byte AutoDialogStateNew = 0;
        public const byte AutoDialogStateInfo = 1;
        public const byte AutoDialogStateEntered = 2;
        public const byte AutoDialogStateFinished = 3;
        public const string AdvertisingId = "AdvertisingId";
        public const string TempLevelKill = "TempLevelKill";
        public const string CrashFlag = "CrashFlag";
        public const string StoryLevelTryCount = "SLTC";
        public const string UserId = "UserId";
        public const string Token = "Token";
        public const string UserCloudBackup = "UserIdAndToken";
        public const string InstallId = "InstallId";
        public const string InstallTime = "InstallTime";
        public const string StoredProducts = "StoredProducts";
        public const string Version = "Version";
        public const string ForceVersion = "ForceVersion";
        public const string ConsentState = "ConsentState";
        public const string RequestNotificationPermission = "RequestNotificationPermission";
        public const string SessionCount = "SessionCount";
        public const string ReplayFile = "ReplayFile";
        public const string Music = "Music";
        public const string Sfx = "Sfx";
        public const string Hint = "Hint";
        public const string Notification = "Notification";
        public const string GuestId = "GuestId";
        public const string GuestToken = "GuestToken";
        public const string MaxPublishedLevel = "MaxPublishedLevel";
        public const string RequiredLeagueLevel = "RequiredLeagueLevel";
        public const string Location = "Location";
        public const string BadWordsFilterVersion = "BadWordsFilterVersion";
        public const string ActiveLeague = "ActiveLeague";
        public const string LeagueLevels = "LeagueLevels";
        public const string ServerTimeDiff = "STD";
        public const string LastClientTime = "LCT";
        public const string LastServerTime = "LST";
        public const string LifeCountOnPause = "LCP";
        public const string EarnedLifeCount = "ELC";
        public const string OfflineUnlimitedLifeTime = "OULT";
        public const string Madness = "Madness";
        public const string MadnessConfig = "MadnessConfig";
        public const string TotalSpending = "Spending";
        public const string LadderOffer = "LadderOffer";
        public const string LadderOfferConfig = "LadderOfferConfig";
        public const string RoyalPass = "RoyalPass";
        public const string RoyalPassConfig = "RoyalPassConfig";
        public const string VerifiedInMaintenance = "VIM";
        public const string SyncId = "SyncId";
        public const string Level = "Level";
        public const string FullLivesTimeInMs = "FullLivesTimeInMs";
        public const string UnlimitedLivesEndTimeInMs = "UnlimitedLivesEndTimeInMs";
        public const string UserData = "UserData";
        public const string Coins = "Coins";
        public const string Stars = "Stars";
        public const string Inbox = "Inbox";
        public const string Chest = "Chest";
        public const string RocketEndTime = "RET";
        public const string TntEndTime = "TET";
        public const string LightBallEndTime = "LET";
        public const string EventInventory = "EventInventory";
        public const string InGameInventory = "InGameInventory";
        public const string PreLevelInventory = "PreLevelInventory";
        public const string Area = "Area";
        public const string LeagueLevel = "LeagueLevel";
        public const string LevelWinMultipliers = "LWM";
        public const string RemainingBoosterTimes = "RemainingBoosterTimes";
        public const string RoyalPassProgress = "RoyalPassProgress";
        public const string RoyalPassFree = "RoyalPassFree";
        public const string RoyalPassGold = "RoyalPassGold";
        public const string LastCompletedTaskId = "LastCompletedTaskId";
        public const string FacebookId = "FacebookId";
        public const string AppleId = "AppleId";
        public const string Leaderboard = "Leaderboard";
        public const string UserName = "UserName";
        public const string TeamId = "TeamId";
        public const string LastClaimedUnlockedBooster = "LastClaimedUnlockedBooster";
        public const string PrelevelBoosterTutorialShowed = "PrelevelBoosterTutorialShowed";
        public const string ChatOn = "ChatOn";
        public const string LeagueRewards = "LeagueRewards";
        public const string LeagueRank = "LeagueRank";
        public const string LeagueGroup = "LeagueGroup";
        public const string LeagueAutoDialogState = "LeagueShowed";
        public const string LocalName = "LocalName";
        public const string RealArea = "NextArea";
        public const string LeagueButtonClicked = "LeagueButtonClicked";
        public const string ClocheTutorialShowed = "ClocheTutorialShowed";
        public const string KingsCup = "KingsCup";
        public const string KingsCupClaimNotFinished = "KCCNF";
        public const string KingsCupAutoDialogState = "KingsCupShowed";
        public const string PiggyBankAutoDialogState = "PiggyBankAutoDialogState";
        public const string PiggyBankLastSeenPercentage = "PiggyBankLastSeenRatio";
        public const string TeamBattle = "TeamBattle";
        public const string TeamBattleClaimNotFinished = "TBCNF";
        public const string TeamBattleAutoDialogState = "TeamBattleShowed";
        public const string MadnessAutoDialogState = "MadnessAutoDialogState";
        public const string LadderOfferAutoDialogState = "LadderOfferAutoDialogState";
        public const string LadderOfferAutoDialogLastSeenDate = "LadderOfferAutoDialogLastSeenDate";
        public const string KingsCupStartDialogShowCount = "KingsCupStartDialogShowCount";
        public const string AbTestData = "AbTestData";
        
        // Methods
        public static string GetBadWordsKeyForLanguage(string language)
        {
            return language + "BadWords";
        }
    
    }

}
