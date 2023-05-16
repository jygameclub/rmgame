using UnityEngine;

namespace Royal.Player.Context.Units
{
    public class LevelManager : IContextUnit
    {
        // Fields
        public const int MaxLevelCount = 1000;
        public const int MaxStoryLevelCount = 3;
        private Royal.Player.Context.Units.LevelEpisodeHelper <LevelEpisodeHelper>k__BackingField;
        public Royal.Scenes.Game.Utils.LevelParser.LevelParser parser;
        public System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Goal.GoalType, Royal.Scenes.Game.Mechanics.Goal.GoalTuple> goals;
        private System.Collections.Generic.Dictionary<int, int> counts;
        private int curtainCellCount;
        private int drillCount;
        private int chainCount;
        private bool propellerIgnoresChain;
        private int maxPublishedLevel;
        private int parsedLevel;
        private bool isThereHoneyInLevel;
        private bool isThereHatInLevel;
        private bool isThereSoilInLevel;
        private bool isThereBirdInLevel;
        private bool isThereFrogInLevel;
        private bool isThereIceCrusherInLevel;
        private bool isThereMetalCrusherInLevel;
        private bool isThereCaldronItemInLevel;
        private Royal.Player.Context.Units.UserManager userManager;
        private Royal.Player.Context.Units.LifeHelper lifeHelper;
        private Royal.Infrastructure.Services.Analytics.AnalyticsManager analyticsManager;
        private bool <IsThereAnyLevelToPlay>k__BackingField;
        
        // Properties
        public static bool IsStoryLevel { get; }
        public static bool WasStoryLevel { get; }
        public Royal.Player.Context.Units.LevelEpisodeHelper LevelEpisodeHelper { get; set; }
        public int Id { get; }
        public bool IsNewLevelPublished { get; }
        public bool IsThereAnyLevelToPlay { get; set; }
        
        // Methods
        public static bool get_IsStoryLevel()
        {
            return (bool)Royal.Player.Context.Data.Session.__il2cppRuntimeField_30 >> 31;
        }
        public static bool get_WasStoryLevel()
        {
            return (bool)Royal.Player.Context.Data.Session.__il2cppRuntimeField_34;
        }
        public Royal.Player.Context.Units.LevelEpisodeHelper get_LevelEpisodeHelper()
        {
            return (Royal.Player.Context.Units.LevelEpisodeHelper)this.<LevelEpisodeHelper>k__BackingField;
        }
        private void set_LevelEpisodeHelper(Royal.Player.Context.Units.LevelEpisodeHelper value)
        {
            this.<LevelEpisodeHelper>k__BackingField = value;
        }
        public int get_Id()
        {
            return 2;
        }
        public bool get_IsNewLevelPublished()
        {
            return (bool)(this.maxPublishedLevel > 1000) ? 1 : 0;
        }
        public bool get_IsThereAnyLevelToPlay()
        {
            return (bool)this.<IsThereAnyLevelToPlay>k__BackingField;
        }
        private void set_IsThereAnyLevelToPlay(bool value)
        {
            this.<IsThereAnyLevelToPlay>k__BackingField = value;
        }
        public bool IsThereGrassInLevel()
        {
            if(this.goals == null)
            {
                    return (bool)this.goals;
            }
            
            return this.goals.ContainsKey(key:  13);
        }
        public bool IsThereHoneyInLevel()
        {
            return (bool)this.isThereHoneyInLevel;
        }
        public bool IsThereHatInLevel()
        {
            return (bool)this.isThereHatInLevel;
        }
        public bool IsThereSoilInLevel()
        {
            return (bool)this.isThereSoilInLevel;
        }
        public bool IsThereDrillInLevel()
        {
            return (bool)(this.drillCount > 0) ? 1 : 0;
        }
        public bool IsThereBirdInLevel()
        {
            return (bool)this.isThereBirdInLevel;
        }
        public bool IsThereFrogInLevel()
        {
            return (bool)this.isThereFrogInLevel;
        }
        public bool IsThereIceCrusherInLevel()
        {
            return (bool)this.isThereIceCrusherInLevel;
        }
        public bool IsThereMetalCrusherInLevel()
        {
            return (bool)this.isThereMetalCrusherInLevel;
        }
        public bool IsThereGeneratorInLevel()
        {
            return (bool)this.isThereCaldronItemInLevel;
        }
        public bool IsThereChainInLevel()
        {
            return (bool)(this.chainCount > 0) ? 1 : 0;
        }
        public bool GetPropellerIgnoresChain()
        {
            return (bool)this.propellerIgnoresChain;
        }
        public LevelManager()
        {
            this.maxPublishedLevel = UnityEngine.Mathf.Max(a:  Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetInt(key:  "MaxPublishedLevel", defaultValue:  0), b:  232);
        }
        public void Bind()
        {
            this.userManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1);
            this.lifeHelper = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LifeHelper>(id:  3);
            this.<LevelEpisodeHelper>k__BackingField = new Royal.Player.Context.Units.LevelEpisodeHelper();
            this.analyticsManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.HomeContext>(id:  10).add_OnActivate(value:  new System.Action(object:  this, method:  public System.Void Royal.Player.Context.Units.LevelManager::ResourcesLoad()));
        }
        public void AdminLevelLoad(int index, byte[] data, bool isOnline, int levelNo = 0)
        {
            this.parsedLevel = levelNo;
            this.Parse(level:  index, data:  data, leagueLevel:  0);
            this.CreatePools();
            this.<LevelEpisodeHelper>k__BackingField.SetEpisodeId(levelNo:  index);
            Load(levelNo:  index, levelName:  this.parser.LevelName, moves:  this.parser.<MoveCount>k__BackingField, admin:  true, online:  isOnline);
        }
        public void LevelLoad()
        {
            var val_4;
            if(this.parser != null)
            {
                    if(this.parser.ShouldForceReloadLevel() != false)
            {
                    this.parsedLevel = 0;
            }
            
            }
            
            this.ResourcesLoad();
            if(this.parser != null)
            {
                    this.<LevelEpisodeHelper>k__BackingField.SetEpisodeId(levelNo:  this.parsedLevel);
                Load(levelNo:  this.parsedLevel, levelName:  this.parser.LevelName, moves:  this.<LevelEpisodeHelper>k__BackingField.CalculateMoveCountWithSkill(moveCount:  this.parser.<MoveCount>k__BackingField), admin:  false, online:  false);
                return;
            }
            
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "There is no level to play", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        private void Parse(int level, byte[] data, int leagueLevel = 0)
        {
            bool val_24;
            System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Goal.GoalType, Royal.Scenes.Game.Mechanics.Goal.GoalTuple> val_25;
            Royal.Scenes.Game.Utils.LevelParser.LevelParser val_2 = new Royal.Scenes.Game.Utils.LevelParser.LevelParser(itemFactory:  Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1));
            this.parser = val_2;
            val_2.Parse(levelNo:  level, rawData:  data, goalDict: out  this.goals, counts: out  this.counts, curtainCellCount: out  this.curtainCellCount, drillCount: out  this.drillCount, chainCount: out  this.chainCount);
            if(this.goals != null)
            {
                    val_24 = this.goals.ContainsKey(key:  14);
            }
            else
            {
                    val_24 = false;
            }
            
            this.isThereHoneyInLevel = val_24;
            this.isThereHatInLevel = this.counts.ContainsKey(key:  22);
            if(this.goals == null)
            {
                goto label_5;
            }
            
            this.isThereSoilInLevel = this.goals.ContainsKey(key:  35);
            if(this.goals == null)
            {
                goto label_6;
            }
            
            val_25 = this.goals;
            this.isThereBirdInLevel = this.goals.ContainsKey(key:  23);
            if(val_25 == null)
            {
                goto label_8;
            }
            
            val_25 = val_25.ContainsKey(key:  37);
            goto label_8;
            label_5:
            this.isThereSoilInLevel = false;
            label_6:
            val_25 = false;
            this.isThereBirdInLevel = false;
            label_8:
            this.isThereFrogInLevel = val_25;
            this.isThereIceCrusherInLevel = this.counts.ContainsKey(key:  19);
            this.isThereMetalCrusherInLevel = this.counts.ContainsKey(key:  32);
            Royal.Scenes.Game.Utils.LevelParser.LevelParser val_23 = this.parser;
            this.isThereCaldronItemInLevel = this.counts.ContainsKey(key:  35);
            val_23 = val_23.GetPropellerIgnoresChain();
            this.propellerIgnoresChain = val_23;
            this.UpdateActiveLevelData(leagueLevel:  leagueLevel);
        }
        private void UpdateActiveLevelData(int leagueLevel)
        {
            sbyte val_2;
            Royal.Player.Context.Data.Session.__il2cppRuntimeField_28 = leagueLevel;
            Royal.Player.Context.Data.Session.__il2cppRuntimeField_24 = this.parser.<IsBonusLevel>k__BackingField;
            if(leagueLevel > 0)
            {
                    val_2 = 0;
            }
            else
            {
                    val_2 = this.parser.<Difficulty>k__BackingField;
            }
            
            Royal.Player.Context.Data.Session.__il2cppRuntimeField_2C = val_2;
            Royal.Player.Context.Data.Session.__il2cppRuntimeField_34 = Royal.Player.Context.Data.Session.__il2cppRuntimeField_30 >> 31;
            int val_2 = this.parsedLevel;
            val_2 = val_2 & (val_2 >> 31);
            Royal.Player.Context.Data.Session.__il2cppRuntimeField_30 = val_2;
        }
        public void CreatePools()
        {
            Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory val_1 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsLowEnd != false)
            {
                    long val_3 = val_1.CreatePermanentPoolsFirstPart();
                val_1.CreatePermanentPoolsSecondPart();
            }
            
            val_1.CreateLevelPools(goals:  this.goals, counts:  this.counts, curtainCellCount:  this.curtainCellCount, drillCount:  this.drillCount, chainCount:  this.chainCount);
        }
        public void LevelStart()
        {
            if(this.lifeHelper.HasLives() != false)
            {
                    Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(id:  2).LoadGameScene();
                return;
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Life.ShowMoreLivesDialogAction(originType:  2));
        }
        public void LevelEnd()
        {
        
        }
        public void RemainingMovesEnd()
        {
        
        }
        public void ResourcesLoad()
        {
            System.Object[] val_19;
            System.Byte[] val_21;
            this.<IsThereAnyLevelToPlay>k__BackingField = true;
            int val_1 = StoryLevel;
            val_19 = val_1;
            int val_2 = (val_1 >= 0) ? (typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14) : (val_1);
            if(((val_19 & 2147483648) == 0) && (Royal.Player.Context.Units.LevelManager.WasStoryLevel != false))
            {
                    Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager>(id:  25).UnloadBundle(bundleType:  3);
            }
            
            if(this.parsedLevel == val_2)
            {
                    this.UpdateActiveLevelData(leagueLevel:  0);
                return;
            }
            
            this.parsedLevel = val_2;
            System.Byte[] val_8 = Royal.Infrastructure.Services.Remote.RemoteLevels.GetRemoteLevel(levelNo:  val_2);
            if(val_8 != null)
            {
                    val_21 = val_8;
                object[] val_9 = new object[1];
                val_19 = val_9;
                val_19[0] = this.parsedLevel;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "RemoteLevel {0} will be used.", values:  val_9);
            }
            else
            {
                    if((val_19 & 2147483648) == 0)
            {
                    val_21 = UnityEngine.Resources.Load<UnityEngine.TextAsset>(path:  this.parsedLevel.ToString()).bytes;
            }
            else
            {
                    val_21 = UnityEngine.Resources.Load<UnityEngine.TextAsset>(path:  "story" + val_2).bytes;
                Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle val_18 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager>(id:  25).GetBundle(bundleType:  3);
            }
            
            }
            
            this.Parse(level:  val_2, data:  val_21, leagueLevel:  0);
        }
        public void UpdateMaxPublishedLevel(int newMaxPublishedLevel)
        {
            if(this.maxPublishedLevel == newMaxPublishedLevel)
            {
                    return;
            }
            
            this.maxPublishedLevel = newMaxPublishedLevel;
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetInt(key:  "MaxPublishedLevel", value:  newMaxPublishedLevel);
            object[] val_2 = new object[1];
            val_2[0] = this.maxPublishedLevel;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "Max publish level is updated to value: {0}", values:  val_2);
        }
        public static bool IsAllLevelsCompleted()
        {
            return (bool)(typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14 > 1000) ? 1 : 0;
        }
    
    }

}
