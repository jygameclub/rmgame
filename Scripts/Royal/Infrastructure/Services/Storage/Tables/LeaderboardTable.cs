using UnityEngine;

namespace Royal.Infrastructure.Services.Storage.Tables
{
    public static class LeaderboardTable
    {
        // Fields
        public const byte Facebook = 1;
        public const byte League = 2;
        public const byte LocalPlayers = 3;
        public const byte WorldPlayers = 4;
        public const byte LocalTeams = 5;
        public const byte WorldTeams = 6;
        public const byte KingsCup = 7;
        public const byte TeamBattleTeams = 8;
        public const byte TeamBattlePlayers = 9;
        
        // Methods
        public static bool InsertOrReplace(Royal.Infrastructure.Services.Storage.DatabaseService db, Royal.Infrastructure.Services.Storage.Tables.Leader leader)
        {
            return (bool)((db.InsertOrReplace(dto:  null)) > 0) ? 1 : 0;
        }
        public static System.Collections.Generic.List<Royal.Infrastructure.Services.Storage.Tables.Leader> GetLeaderboard(Royal.Infrastructure.Services.Storage.DatabaseService db, byte type)
        {
            object[] val_1 = new object[1];
            val_1[0] = type;
            return (System.Collections.Generic.List<Royal.Infrastructure.Services.Storage.Tables.Leader>)db.database.CreateCommand(cmdText:  "SELECT * FROM Leader WHERE Type = ? ORDER BY LeagueLevel DESC, Level DESC, LevelUpdateTime ASC", ps:  val_1).ExecuteQuery<Royal.Infrastructure.Services.Storage.Tables.Leader>();
        }
        public static bool ClearLeaderboard(Royal.Infrastructure.Services.Storage.DatabaseService db, byte type)
        {
            object[] val_1 = new object[1];
            val_1[0] = type;
            return (bool)((db.database.CreateCommand(cmdText:  "DELETE FROM Leader WHERE Type = ?", ps:  val_1).ExecuteNonQuery()) > 0) ? 1 : 0;
        }
        public static void IncrementMyLevelWithEvents(int increment)
        {
            var val_13;
            Plugins.Sqlite.SQLiteConnection val_14;
            var val_15;
            Plugins.Sqlite.SQLiteConnection val_16;
            var val_17;
            var val_18;
            var val_19;
            val_13 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Storage.DatabaseService>(id:  4);
            val_14 = Royal.Player.Context.UserContext.Get<Royal.Infrastructure.Services.Storage.DatabaseService>(id:  0);
            string val_3 = System.String.Format(format:  "Update Leader Set Level = CASE WHEN Type in (1, 2, 3, 4) THEN Level + 1 WHEN Type in (7, 9) THEN Level + {0} END, LevelUpdateTime = {1} WHERE Level >= 0 AND UserId = {2} AND Type in (1, 2, 3, 4, 7, 9)", arg0:  increment, arg1:  9223372036854775807, arg2:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name);
            val_15 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_15 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_15 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_15 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            int val_5 = val_1.database.CreateCommand(cmdText:  val_3, ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteNonQuery();
            val_16 = val_2.database;
            val_17 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_17 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_17 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_17 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            int val_7 = val_16.CreateCommand(cmdText:  val_3, ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteNonQuery();
            string val_8 = System.String.Format(format:  "Update Leader Set Level = CASE WHEN Type in (5, 6) THEN Level + 1 WHEN Type in (8) THEN Level + {0} END, LevelUpdateTime = {1} WHERE TeamId = {2} AND Type in (5, 6, 8)", arg0:  increment, arg1:  9223372036854775807, arg2:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_this_arg);
            val_16 = public static T[] System.Array::Empty<System.Object>();
            val_18 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_18 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_18 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_18 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            int val_10 = val_1.database.CreateCommand(cmdText:  val_8, ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteNonQuery();
            val_14 = val_2.database;
            val_19 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_19 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_19 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_19 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_13 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
            val_13 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
            int val_12 = val_14.CreateCommand(cmdText:  val_8, ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteNonQuery();
        }
        public static void IncrementMyLeagueScoreWithEvents(int increment)
        {
            int val_19;
            var val_20;
            var val_21;
            var val_22;
            Plugins.Sqlite.SQLiteConnection val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            val_19 = increment;
            Royal.Infrastructure.Services.Storage.DatabaseService val_1 = Royal.Player.Context.UserContext.Get<Royal.Infrastructure.Services.Storage.DatabaseService>(id:  0);
            val_20 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Storage.DatabaseService>(id:  4);
            string val_3 = System.String.Format(format:  "Update Leader Set LeagueLevel = LeagueLevel + {0}, LevelUpdateTime = {1} WHERE UserId = {2} AND Type in (1, 2, 3, 4)", arg0:  val_19, arg1:  9223372036854775807, arg2:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name);
            val_21 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_21 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_21 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_21 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            int val_5 = val_2.database.CreateCommand(cmdText:  val_3, ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteNonQuery();
            val_22 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_22 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_22 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_22 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            int val_7 = val_1.database.CreateCommand(cmdText:  val_3, ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteNonQuery();
            val_23 = val_1.database;
            val_24 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_24 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_24 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_24 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            int val_10 = val_23.CreateCommand(cmdText:  System.String.Format(format:  "Update Leader Set Level = Level + {0}, LevelUpdateTime = {1} WHERE Level >= 0 AND UserId = {2} AND Type in (7, 9)", arg0:  val_19, arg1:  9223372036854775807, arg2:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name), ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteNonQuery();
            string val_11 = System.String.Format(format:  "Update Leader Set Level = Level + {0}, LevelUpdateTime = {1} WHERE TeamId = {2} AND Type in (5, 6)", arg0:  val_19, arg1:  9223372036854775807, arg2:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_this_arg);
            val_25 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_25 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_25 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_25 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            int val_13 = val_2.database.CreateCommand(cmdText:  val_11, ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteNonQuery();
            val_26 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_26 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_26 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_26 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_23 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
            val_23 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
            int val_15 = val_1.database.CreateCommand(cmdText:  val_11, ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteNonQuery();
            val_19 = System.String.Format(format:  "Update Leader Set Level = Level + {0}, LevelUpdateTime = {1} WHERE Level >= 0 AND TeamId = {2} AND Type in (8)", arg0:  val_19, arg1:  9223372036854775807, arg2:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_this_arg);
            val_27 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_27 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_27 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_27 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_20 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
            val_20 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
            int val_18 = val_1.database.CreateCommand(cmdText:  val_19, ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteNonQuery();
        }
        public static void IncrementMyEventScores(int increment)
        {
            int val_8;
            string val_9;
            var val_10;
            var val_11;
            val_8 = increment;
            Royal.Infrastructure.Services.Storage.DatabaseService val_1 = Royal.Player.Context.UserContext.Get<Royal.Infrastructure.Services.Storage.DatabaseService>(id:  0);
            val_9 = System.String.Format(format:  "Update Leader Set Level = Level + {0}, LevelUpdateTime = {1} WHERE Level >= 0 AND UserId = {2} AND Type in (7, 9)", arg0:  val_8, arg1:  9223372036854775807, arg2:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name);
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            int val_4 = val_1.database.CreateCommand(cmdText:  val_9, ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteNonQuery();
            val_8 = System.String.Format(format:  "Update Leader Set Level = Level + {0}, LevelUpdateTime = {1} WHERE Level >= 0 AND TeamId = {2} AND Type in (8)", arg0:  val_8, arg1:  9223372036854775807, arg2:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_this_arg);
            val_11 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_11 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_11 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_11 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
            int val_7 = val_1.database.CreateCommand(cmdText:  val_8, ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteNonQuery();
        }
        public static void UpdateMyName(string userName)
        {
            var val_8;
            var val_9;
            string val_1 = System.String.Format(format:  "Update Leader Set UserName = \'{0}\' WHERE UserId = {1}", arg0:  userName, arg1:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name);
            Royal.Infrastructure.Services.Storage.DatabaseService val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Storage.DatabaseService>(id:  4);
            val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            int val_4 = val_2.database.CreateCommand(cmdText:  val_1, ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteNonQuery();
            Royal.Infrastructure.Services.Storage.DatabaseService val_5 = Royal.Player.Context.UserContext.Get<Royal.Infrastructure.Services.Storage.DatabaseService>(id:  0);
            val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            int val_7 = val_5.database.CreateCommand(cmdText:  val_1, ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteNonQuery();
        }
        public static void UpdateMyTeam(long teamId, int teamLogo, string teamName)
        {
            int val_9;
            var val_10;
            var val_11;
            object[] val_1 = new object[4];
            val_1[0] = teamId;
            val_9 = val_1.Length;
            val_1[1] = teamLogo;
            if(teamName != null)
            {
                    val_9 = val_1.Length;
            }
            
            val_1[2] = teamName;
            val_1[3] = Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name;
            string val_2 = System.String.Format(format:  "Update Leader Set TeamId = {0}, TeamLogo = {1}, TeamName = \'{2}\' WHERE UserId = {3} AND Type in (1, 2, 3, 4, 5, 6, 7)", args:  val_1);
            Royal.Infrastructure.Services.Storage.DatabaseService val_3 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Storage.DatabaseService>(id:  4);
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            int val_5 = val_3.database.CreateCommand(cmdText:  val_2, ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteNonQuery();
            Royal.Infrastructure.Services.Storage.DatabaseService val_6 = Royal.Player.Context.UserContext.Get<Royal.Infrastructure.Services.Storage.DatabaseService>(id:  0);
            val_11 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_11 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_11 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_11 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            int val_8 = val_6.database.CreateCommand(cmdText:  val_2, ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteNonQuery();
        }
        public static bool UpdateTeam(long teamId, int capacity, int score)
        {
            var val_9;
            var val_10;
            string val_1 = System.String.Format(format:  "Update Leader Set FacebookId = {0}, Level = {1} WHERE TeamId = {2} AND UserId = 0 AND (FacebookId != {0} OR Level != {1}) AND Type in (5, 6)", arg0:  capacity, arg1:  score, arg2:  teamId);
            Royal.Infrastructure.Services.Storage.DatabaseService val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Storage.DatabaseService>(id:  4);
            val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Storage.DatabaseService val_5 = Royal.Player.Context.UserContext.Get<Royal.Infrastructure.Services.Storage.DatabaseService>(id:  0);
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            System.Object[] val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184;
            val_9 = (val_5.database.CreateCommand(cmdText:  val_1, ps:  val_9).ExecuteNonQuery()) + (val_2.database.CreateCommand(cmdText:  val_1, ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteNonQuery());
            return (bool)(val_9 > 0) ? 1 : 0;
        }
        public static int GetMyRank(Royal.Infrastructure.Services.Storage.DatabaseService db, byte type)
        {
            var val_2;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Storage.Tables.Leader> val_1 = Royal.Infrastructure.Services.Storage.Tables.LeaderboardTable.GetLeaderboard(db:  db, type:  type);
            Royal.Player.Context.Data.UserId val_2 = Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<UserId>k__BackingField;
            if(0 < val_2)
            {
                    if(val_2 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_2 = val_2 + (0 * 80);
                val_2 = 0 + 1;
                return (int)val_2;
            }
            
            val_2 = 0;
            return (int)val_2;
        }
        public static int GetMyScore(Royal.Infrastructure.Services.Storage.DatabaseService db, byte type)
        {
            Plugins.Sqlite.SQLiteConnection val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            if((type & 255) != 2)
            {
                goto label_4;
            }
            
            val_8 = db.database;
            val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
            System.Collections.Generic.List<T> val_4 = val_8.CreateCommand(cmdText:  System.String.Format(format:  "SELECT LeagueLevel FROM Leader WHERE UserId = {0} AND Type = {1}", arg0:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name, arg1:  2), ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteQuery<Royal.Infrastructure.Services.Storage.Tables.Leader>();
            if((public System.Collections.Generic.List<T> Plugins.Sqlite.SQLiteCommand::ExecuteQuery<Royal.Infrastructure.Services.Storage.Tables.Leader>()) == 0)
            {
                goto label_27;
            }
            
            val_11 = "114ca50f7a8e2f3f657c1108d9d44cfd8";
            return (int)val_11;
            label_4:
            val_8 = db.database;
            val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
            System.Collections.Generic.List<T> val_7 = val_8.CreateCommand(cmdText:  System.String.Format(format:  "SELECT Level FROM Leader WHERE UserId = {0} AND Type = {1}", arg0:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name, arg1:  type), ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteQuery<Royal.Infrastructure.Services.Storage.Tables.Leader>();
            if((public System.Collections.Generic.List<T> Plugins.Sqlite.SQLiteCommand::ExecuteQuery<Royal.Infrastructure.Services.Storage.Tables.Leader>()) != 0)
            {
                    return (int)val_11;
            }
            
            label_27:
            val_11 = 0;
            return (int)val_11;
        }
        public static int GetTeamLevel(Royal.Infrastructure.Services.Storage.DatabaseService db, byte type)
        {
            var val_4;
            var val_5;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            System.Collections.Generic.List<T> val_3 = db.database.CreateCommand(cmdText:  System.String.Format(format:  "SELECT Level FROM Leader WHERE TeamId = {0} AND Type = {1}", arg0:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_this_arg, arg1:  type), ps:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184).ExecuteQuery<Royal.Infrastructure.Services.Storage.Tables.Leader>();
            if((public System.Collections.Generic.List<T> Plugins.Sqlite.SQLiteCommand::ExecuteQuery<Royal.Infrastructure.Services.Storage.Tables.Leader>()) != 0)
            {
                    return (int)val_5;
            }
            
            val_5 = 0;
            return (int)val_5;
        }
    
    }

}
