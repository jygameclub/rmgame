using UnityEngine;

namespace Royal.Infrastructure.Services.Storage.Tables
{
    public static class UserLeaderboard
    {
        // Fields
        private static Royal.Infrastructure.Services.Storage.DatabaseService DbService;
        
        // Properties
        private static Royal.Infrastructure.Services.Storage.DatabaseService DatabaseService { get; }
        
        // Methods
        private static Royal.Infrastructure.Services.Storage.DatabaseService get_DatabaseService()
        {
            if(Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.DbService != null)
            {
                    return val_1;
            }
            
            Royal.Infrastructure.Services.Storage.DatabaseService val_1 = Royal.Player.Context.UserContext.Get<Royal.Infrastructure.Services.Storage.DatabaseService>(id:  0);
            Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.DbService = val_1;
            return val_1;
        }
        public static void ResetConnection()
        {
            Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.DbService = 0;
        }
        public static bool ClearLeaderboard(byte type)
        {
            return Royal.Infrastructure.Services.Storage.Tables.LeaderboardTable.ClearLeaderboard(db:  Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.DatabaseService, type:  type);
        }
        public static bool AddOrUpdateLeader(Royal.Infrastructure.Services.Storage.Tables.Leader leader)
        {
            return (bool)Royal.Infrastructure.Services.Storage.Tables.LeaderboardTable.InsertOrReplace(db:  Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.DatabaseService, leader:  new Royal.Infrastructure.Services.Storage.Tables.Leader() {<IsGold>k__BackingField = false});
        }
        public static System.Collections.Generic.List<Royal.Infrastructure.Services.Storage.Tables.Leader> GetLeaderboard(byte type)
        {
            return Royal.Infrastructure.Services.Storage.Tables.LeaderboardTable.GetLeaderboard(db:  Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.DatabaseService, type:  type);
        }
        public static int GetMyRank(byte type)
        {
            return Royal.Infrastructure.Services.Storage.Tables.LeaderboardTable.GetMyRank(db:  Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.DatabaseService, type:  type);
        }
        public static int GetMyScore(byte type)
        {
            return Royal.Infrastructure.Services.Storage.Tables.LeaderboardTable.GetMyScore(db:  Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.DatabaseService, type:  type);
        }
        public static int GetTeamLevel(byte type)
        {
            return Royal.Infrastructure.Services.Storage.Tables.LeaderboardTable.GetTeamLevel(db:  Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.DatabaseService, type:  type);
        }
    
    }

}
