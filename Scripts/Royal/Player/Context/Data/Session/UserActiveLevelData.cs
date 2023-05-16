using UnityEngine;

namespace Royal.Player.Context.Data.Session
{
    public class UserActiveLevelData
    {
        // Fields
        public bool isAdmin;
        public bool isOnline;
        public int number;
        public string name;
        public int moveCount;
        public bool isBonus;
        public int leagueIndex;
        public sbyte difficulty;
        public int storyLevel;
        public bool wasStory;
        public int episodeId;
        public Royal.Player.Context.Data.Session.ActiveLevelState state;
        public int leftMoves;
        public int madeMoves;
        public int egoPurchaseCount;
        public int remainingMovesCoins;
        public int noPossibleMoveShuffleCount;
        public readonly Royal.Player.Context.Data.Session.BeforeAfterData star;
        public readonly Royal.Player.Context.Data.Session.BeforeAfterData cloche;
        public readonly Royal.Player.Context.Data.Session.BeforeAfterData piggy;
        public readonly Royal.Player.Context.Data.Session.AnimationData animationData;
        public readonly Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemCounts specialItemCounts;
        public readonly Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemCounts matchItemCounts;
        public float levelStartTime;
        
        // Properties
        public bool IsLeague { get; }
        public bool IsHard { get; }
        public bool IsStart { get; }
        public bool IsWin { get; }
        public bool IsLoad { get; }
        public bool IsStory { get; }
        public int StoryLevelTryCount { get; }
        
        // Methods
        public UserActiveLevelData(Royal.Player.Context.Data.Session.AnimationData data)
        {
            this.animationData = data;
            this.star = new Royal.Player.Context.Data.Session.BeforeAfterData();
            this.cloche = new Royal.Player.Context.Data.Session.BeforeAfterData();
            this.piggy = new Royal.Player.Context.Data.Session.BeforeAfterData();
            this.specialItemCounts = new Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemCounts();
            this.matchItemCounts = new Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemCounts();
        }
        public bool get_IsLeague()
        {
            return (bool)(this.leagueIndex > 0) ? 1 : 0;
        }
        public bool get_IsHard()
        {
            return (bool)(this.difficulty > 0) ? 1 : 0;
        }
        public bool get_IsStart()
        {
            return (bool)(this.state == 2) ? 1 : 0;
        }
        public bool get_IsWin()
        {
            return (bool)(this.state == 3) ? 1 : 0;
        }
        public bool get_IsLoad()
        {
            return (bool)(this.state == 1) ? 1 : 0;
        }
        public bool get_IsStory()
        {
            return (bool)this.storyLevel >> 31;
        }
        public int get_StoryLevelTryCount()
        {
            return UnityEngine.PlayerPrefs.GetInt(key:  "SLTC");
        }
        public void Reset()
        {
            this.state = 0;
        }
        public void Load(int levelNo, string levelName, int moves, bool admin = False, bool online = False)
        {
            int val_4;
            this.number = levelNo;
            this.moveCount = moves;
            this.name = levelName;
            this.isAdmin = admin;
            this.isOnline = online;
            this.state = 1;
            object[] val_3 = new object[3];
            val_4 = val_3.Length;
            val_3[0] = this.number;
            if(this.name != null)
            {
                    val_4 = val_3.Length;
            }
            
            val_3[1] = this.name;
            val_3[2] = this.leagueIndex;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "Load Level: {0} - {1} - {2}", values:  val_3);
        }
        public void Start()
        {
            int val_2;
            this.ResetValues(isRestart:  false);
            object[] val_1 = new object[3];
            val_2 = val_1.Length;
            val_1[0] = this.number;
            if(this.name != null)
            {
                    val_2 = val_1.Length;
            }
            
            val_1[1] = this.name;
            val_1[2] = this.leagueIndex;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "Start Level: {0} - {1} - {2}", values:  val_1);
        }
        public void Restart()
        {
            int val_2;
            this.ResetValues(isRestart:  true);
            object[] val_1 = new object[3];
            val_2 = val_1.Length;
            val_1[0] = this.number;
            if(this.name != null)
            {
                    val_2 = val_1.Length;
            }
            
            val_1[1] = this.name;
            val_1[2] = this.leagueIndex;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "Restart Level: {0} - {1} - {2}", values:  val_1);
        }
        private void ResetValues(bool isRestart)
        {
            this.star = 0;
            this.star = typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_14;
            this.star = typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_14;
            int val_1 = GetCloche();
            this.cloche = 0;
            this.cloche = val_1;
            this.cloche = val_1;
            int val_2 = GetPiggy();
            this.piggy = 0;
            this.piggy = val_2;
            this.piggy = val_2;
            this.animationData.coin = 0;
            this.animationData.coin = Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_name;
            this.animationData.coin = Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_name;
            this.animationData.completed1000ThLevelCoin = 0;
            this.animationData.completed1000ThLevelCoin = 0;
            this.animationData.completed1000ThLevelCoin = 0;
            this.animationData.madness.Init(isStory:  this.storyLevel >> 31, isRestart:  isRestart);
            this.animationData.royalPass.Init(isStory:  this.storyLevel >> 31, isRestart:  isRestart);
            this.animationData.kingsCup = 0;
            this.animationData.kingsCup = 0;
            this.animationData.kingsCup = 0;
            this.animationData.teamBattle = 0;
            this.animationData.teamBattle = 0;
            this.animationData.teamBattle = 0;
            this.animationData.leagueCrown = 0;
            this.animationData.leagueCrown = 0;
            this.animationData.leagueCrown = 0;
            this.egoPurchaseCount = 0;
            this.state = 2;
            this.noPossibleMoveShuffleCount = 0;
            this.levelStartTime = UnityEngine.Time.time;
            this.specialItemCounts.Reset();
            this.matchItemCounts.Reset();
            this.IncrementStoryLevelTryCount();
        }
        private void IncrementStoryLevelTryCount()
        {
            if((this.storyLevel & 2147483648) == 0)
            {
                    return;
            }
            
            UnityEngine.PlayerPrefs.SetInt(key:  "SLTC", value:  (UnityEngine.PlayerPrefs.GetInt(key:  "SLTC")) + 1);
        }
        public void Win(Royal.Scenes.Game.Levels.Units.MoveManager moveManager, int bonusCoins)
        {
            int val_8;
            this.leftMoves = moveManager.<LeftMoves>k__BackingField;
            this.state = 3;
            this.madeMoves = moveManager.<MadeMoves>k__BackingField;
            object[] val_1 = new object[3];
            val_8 = val_1.Length;
            val_1[0] = this.number;
            if(this.name != null)
            {
                    val_8 = val_1.Length;
            }
            
            val_1[1] = this.name;
            val_1[2] = this.leagueIndex;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "Win Level: {0} - {1} - {2}", values:  val_1);
            if(this.isAdmin != false)
            {
                    return;
            }
            
            this.animationData.coin = 0;
            this.animationData.coin = Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_name;
            this.animationData.coin = Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_name;
            int val_8 = this.animationData.coin.before;
            this.animationData.coin = 1;
            val_8 = val_8 + bonusCoins;
            this.animationData.coin = val_8;
            if((this.leagueIndex <= 0) && (this.number == 1000))
            {
                    Royal.Player.Context.Data.InventoryPackage val_2 = Royal.Player.Context.Data.InventoryPackage.Get1000ThLevelPackage();
                int val_9 = val_2.coins;
                this.animationData.completed1000ThLevelCoin = 1;
                val_9 = this.animationData.completed1000ThLevelCoin.before + val_9;
                this.animationData.completed1000ThLevelCoin = val_9;
            }
            
            if((this.storyLevel & 2147483648) != 0)
            {
                goto label_25;
            }
            
            if(this.leagueIndex < 1)
            {
                goto label_26;
            }
            
            this.animationData.AddLeagueCrown();
            goto label_28;
            label_25:
            this.leftMoves = moveManager.<Seconds>k__BackingField;
            return;
            label_26:
            int val_10 = this.star.before;
            this.star = 1;
            val_10 = val_10 + 1;
            this.star = val_10;
            label_28:
            Royal.Player.Context.Units.KingsCupManager val_3 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.KingsCupManager>(id:  7);
            if(val_3.groupId >= 1)
            {
                    this.animationData.AddKingsCup(difficulty:  this.difficulty);
            }
            
            if((Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.TeamBattleManager>(id:  9).IsInAGroup) != false)
            {
                    this.animationData.AddTeamBattle(difficulty:  this.difficulty);
            }
            
            if(this.animationData.royalPass.IsEventValid() != false)
            {
                    sbyte val_11 = this.difficulty;
                val_11 = (val_11 == 1) ? 3 : ((val_11 == 2) ? 5 : (0 + 1));
                val_11 = W13 + val_11;
                this.animationData.royalPass = 1;
                this.animationData.royalPass = val_11;
            }
            
            if(this.leagueIndex <= 0)
            {
                    int val_12 = this.number;
                val_12 = val_12 + 1;
                if(val_12 < 32)
            {
                    return;
            }
            
            }
            
            int val_13 = this.cloche.before;
            if(val_13 > 2)
            {
                    return;
            }
            
            val_13 = val_13 + 1;
            this.cloche = 1;
            this.cloche = val_13;
        }
        public void SpecialItemCreated(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel createdItem, UnityEngine.Vector3 position, int animationDelayInFrames)
        {
            this.animationData.madness.TryAddMadnessSpecial(itemModel:  createdItem, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, difficulty:  this.difficulty, animationDelayInFrames:  animationDelayInFrames);
        }
        public void TryCollectMadness(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType, UnityEngine.Vector3 originPosition, int count, int animationDelayInFrames, Royal.Scenes.Game.Mechanics.Items.Config.ItemModel createdItem, bool remainingMoves = False)
        {
            if((this.state != 2) && (remainingMoves != true))
            {
                    return;
            }
            
            this.animationData.madness.TryAddMadnessMatch(matchType:  matchType, originPosition:  new UnityEngine.Vector3() {x = originPosition.x, y = originPosition.y, z = originPosition.z}, count:  count, difficulty:  this.difficulty, animationDelayInFrames:  animationDelayInFrames, createdItem:  createdItem);
        }
        public void TryCollectMadnessForExploder(UnityEngine.Vector3 originPosition, Royal.Scenes.Game.Mechanics.Explode.ExplodeData explodeData, int animationDelayInFrames)
        {
            if(this.state != 2)
            {
                    return;
            }
            
            this.animationData.madness.TryAddMadnessMatch(matchType:  this.animationData.madness.MatchTypeToCollect, originPosition:  new UnityEngine.Vector3() {x = originPosition.x, y = originPosition.y, z = originPosition.z}, count:  this.animationData.madness.GetMadnessForExploderId(exploderId:  268435460), difficulty:  this.difficulty, animationDelayInFrames:  animationDelayInFrames, createdItem:  0);
        }
        public void IncrementMadnessMatchItemCount(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType, int exploderId)
        {
            if(this.state != 2)
            {
                    return;
            }
            
            this.animationData.madness.TryIncrementMadnessForExploderId(matchType:  matchType, exploderId:  exploderId);
        }
        public void RemainingMovesEnd(int notReplacedMoves, int extraCoins)
        {
            if(Royal.Player.Context.Data.Persistent.AbTestData.IsPiggyBankEnabled() == false)
            {
                goto label_6;
            }
            
            if(this.leagueIndex <= 0)
            {
                goto label_1;
            }
            
            label_7:
            int val_2 = Royal.Player.Context.Units.PiggyBankManager.CalculateExtraPiggyCoins(currentPiggy:  this.piggy.after, newCoins:  extraCoins);
            if(val_2 < 1)
            {
                goto label_6;
            }
            
            int val_3 = this.piggy.after;
            this.piggy = 1;
            val_3 = val_3 + val_2;
            this.piggy = val_3;
            goto label_6;
            label_1:
            if(this.isBonus != true)
            {
                    if(this.number >= 16)
            {
                goto label_7;
            }
            
            }
            
            label_6:
            int val_4 = this.animationData.coin.after;
            this.animationData.coin = 1;
            val_4 = val_4 + extraCoins;
            this.animationData.coin = val_4;
            this.remainingMovesCoins = extraCoins;
            this.animationData.madness.TryAddMadnessForRemainingMoves(notReplacedMoves:  notReplacedMoves, difficulty:  this.difficulty);
        }
        public void Fail(Royal.Scenes.Game.Levels.Units.MoveManager moveManager)
        {
            int val_2;
            this.FailOrQuit(moveManager:  moveManager);
            this.state = 4;
            object[] val_1 = new object[3];
            val_2 = val_1.Length;
            val_1[0] = this.number;
            if(this.name != null)
            {
                    val_2 = val_1.Length;
            }
            
            val_1[1] = this.name;
            val_1[2] = this.leagueIndex;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "Fail Level: {0} - {1} - {2}", values:  val_1);
        }
        public void Quit(Royal.Scenes.Game.Levels.Units.MoveManager moveManager)
        {
            int val_2;
            this.FailOrQuit(moveManager:  moveManager);
            this.state = 5;
            object[] val_1 = new object[3];
            val_2 = val_1.Length;
            val_1[0] = this.number;
            if(this.name != null)
            {
                    val_2 = val_1.Length;
            }
            
            val_1[1] = this.name;
            val_1[2] = this.leagueIndex;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "Quit Level: {0} - {1} - {2}", values:  val_1);
        }
        private void FailOrQuit(Royal.Scenes.Game.Levels.Units.MoveManager moveManager)
        {
            if(this.isAdmin == false)
            {
                goto label_0;
            }
            
            label_7:
            this.animationData.madness = 0;
            this.animationData.madness = 0;
            this.animationData.madness = 0;
            var val_1 = (this.storyLevel < 0) ? 48 : 36;
            this.leftMoves = null;
            this.madeMoves = moveManager.<MadeMoves>k__BackingField;
            return;
            label_0:
            if(((this.storyLevel & 2147483648) != 0) || (this.cloche.before < 1))
            {
                goto label_7;
            }
            
            this.cloche = 1;
            this.cloche = 0;
            goto label_7;
        }
        public void Pause()
        {
            int val_4;
            Royal.Scenes.Game.Levels.Units.MoveManager val_1 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.MoveManager>(contextId:  10);
            var val_2 = (this.storyLevel < 0) ? 48 : 36;
            this.leftMoves = null;
            this.state = 6;
            this.madeMoves = val_1.<MadeMoves>k__BackingField;
            object[] val_3 = new object[3];
            val_4 = val_3.Length;
            val_3[0] = this.number;
            if(this.name != null)
            {
                    val_4 = val_3.Length;
            }
            
            val_3[1] = this.name;
            val_3[2] = this.leagueIndex;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "Pause Level: {0} - {1} - {2}", values:  val_3);
        }
    
    }

}
