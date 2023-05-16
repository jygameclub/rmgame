using UnityEngine;

namespace Royal.Scenes.Game.Levels
{
    public class LevelContext : IGameContextBehaviour, IGameContextUnit, IContextUnit, IContextBehaviour
    {
        // Fields
        private static Royal.Scenes.Game.Levels.LevelContext Instance;
        private static bool <IsActive>k__BackingField;
        private readonly Royal.Infrastructure.Contexts.ContextContainer<Royal.Scenes.Game.Context.IGameContextUnit> container;
        private Royal.Scenes.Game.Mechanics.DeltaTime.IDeltaTimeManager deltaTimeManager;
        
        // Properties
        public static int FrameCount { get; }
        public static float DeltaTime { get; }
        public static float Time { get; }
        public static float TimeScale { get; }
        public static bool IsSparseUpdateReady { get; }
        public static bool IsActive { get; set; }
        public int Id { get; }
        
        // Methods
        public static int get_FrameCount()
        {
            Royal.Scenes.Game.Mechanics.DeltaTime.IDeltaTimeManager val_3 = null;
            if((mem[null + 294]) == 0)
            {
                    return FrameCount;
            }
            
            var val_1 = mem[null + 176];
            var val_2 = 0;
            val_1 = val_1 + 8;
            label_5:
            if(((mem[null + 176] + 8) + -8) == null)
            {
                goto label_4;
            }
            
            val_2 = val_2 + 1;
            val_1 = val_1 + 16;
            if(val_2 < (mem[null + 294]))
            {
                goto label_5;
            }
            
            return FrameCount;
            label_4:
            val_3 = val_3 + (((mem[null + 176] + 8)) << 4);
            return FrameCount;
        }
        public static float get_DeltaTime()
        {
            Royal.Scenes.Game.Mechanics.DeltaTime.IDeltaTimeManager val_4 = null;
            if((mem[null + 294]) == 0)
            {
                    return DeltaTime;
            }
            
            var val_1 = mem[null + 176];
            var val_2 = 0;
            val_1 = val_1 + 8;
            label_5:
            if(((mem[null + 176] + 8) + -8) == null)
            {
                goto label_4;
            }
            
            val_2 = val_2 + 1;
            val_1 = val_1 + 16;
            if(val_2 < (mem[null + 294]))
            {
                goto label_5;
            }
            
            return DeltaTime;
            label_4:
            var val_3 = val_1;
            val_3 = val_3 + 1;
            val_4 = val_4 + val_3;
            return DeltaTime;
        }
        public static float get_Time()
        {
            Royal.Scenes.Game.Mechanics.DeltaTime.IDeltaTimeManager val_4 = null;
            if((mem[null + 294]) == 0)
            {
                    return Time;
            }
            
            var val_1 = mem[null + 176];
            var val_2 = 0;
            val_1 = val_1 + 8;
            label_5:
            if(((mem[null + 176] + 8) + -8) == null)
            {
                goto label_4;
            }
            
            val_2 = val_2 + 1;
            val_1 = val_1 + 16;
            if(val_2 < (mem[null + 294]))
            {
                goto label_5;
            }
            
            return Time;
            label_4:
            var val_3 = val_1;
            val_3 = val_3 + 2;
            val_4 = val_4 + val_3;
            return Time;
        }
        public static float get_TimeScale()
        {
            Royal.Scenes.Game.Mechanics.DeltaTime.IDeltaTimeManager val_4 = null;
            if((mem[null + 294]) == 0)
            {
                    return TimeScale;
            }
            
            var val_1 = mem[null + 176];
            var val_2 = 0;
            val_1 = val_1 + 8;
            label_5:
            if(((mem[null + 176] + 8) + -8) == null)
            {
                goto label_4;
            }
            
            val_2 = val_2 + 1;
            val_1 = val_1 + 16;
            if(val_2 < (mem[null + 294]))
            {
                goto label_5;
            }
            
            return TimeScale;
            label_4:
            var val_3 = val_1;
            val_3 = val_3 + 3;
            val_4 = val_4 + val_3;
            return TimeScale;
        }
        public static bool get_IsSparseUpdateReady()
        {
            int val_1 = Royal.Scenes.Game.Levels.LevelContext.FrameCount;
            return (bool)(0 == 0) ? 1 : 0;
        }
        public static bool get_IsActive()
        {
            return (bool)Royal.Scenes.Game.Levels.LevelContext.<IsActive>k__BackingField;
        }
        private static void set_IsActive(bool value)
        {
            Royal.Scenes.Game.Levels.LevelContext.<IsActive>k__BackingField = value;
        }
        public int get_Id()
        {
            return 2;
        }
        public LevelContext()
        {
            System.String[] val_2 = System.Enum.GetNames(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            Royal.Infrastructure.Contexts.ContextContainer<Royal.Scenes.Game.Context.IGameContextUnit> val_3 = new Royal.Infrastructure.Contexts.ContextContainer<Royal.Scenes.Game.Context.IGameContextUnit>(contextUnitCount:  val_2.Length);
            this.container = val_3;
            Royal.Scenes.Game.Levels.LevelContext.Instance = this;
            val_3.Add(unit:  new Royal.Scenes.Game.Levels.Units.LevelTutorials.LevelTutorialManager());
            val_3.Add(unit:  new Royal.Scenes.Game.Levels.Units.State.GameStateManager());
            val_3.Add(unit:  new Royal.Scenes.Game.Levels.Units.GoalManager());
            val_3.Add(unit:  new Royal.Scenes.Game.Levels.Units.MoveManager());
            val_3.Add(unit:  new Royal.Scenes.Game.Levels.Units.LevelRandomManager());
            val_3.Add(unit:  new Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory());
            val_3.Add(unit:  new Royal.Scenes.Game.Levels.Units.CellGridManager());
            val_3.Add(unit:  new Royal.Scenes.Game.Levels.Units.Combo.ComboManager());
            val_3.Add(unit:  new Royal.Scenes.Game.Levels.Units.Touch.LevelTouchManager());
            val_3.Add(unit:  new Royal.Scenes.Game.Mechanics.Matches.MatchManager());
            val_3.Add(unit:  new Royal.Scenes.Game.Levels.Units.Booster.BoosterManager());
            val_3.Add(unit:  new Royal.Scenes.Game.Levels.Units.ParticlesManager());
            val_3.Add(unit:  new Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager());
            val_3.Add(unit:  new Royal.Scenes.Game.Levels.Units.Explode.ExplodeTargetFinder());
            val_3.Add(unit:  new Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainHelper());
            Royal.Scenes.Game.Levels.Units.Ego.EgoManager val_19 = null;
            .currentStep = 0;
            val_19 = new Royal.Scenes.Game.Levels.Units.Ego.EgoManager();
            val_3.Add(unit:  val_19);
            val_3.Add(unit:  new Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesManager());
            val_3.Add(unit:  new Royal.Scenes.Game.Levels.Units.Replay.RecordManager());
            val_3.Add(unit:  new Royal.Scenes.Game.Levels.Units.Explode.AutoExplodeManager());
            val_3.Add(unit:  new Royal.Scenes.Game.Levels.Units.FallManager());
            val_3.Add(unit:  new Royal.Scenes.Game.Levels.Units.WinFail.WinFailManager());
            val_3.Add(unit:  new Royal.Scenes.Game.Levels.Units.Shuffle.ShuffleManager());
            val_3.Add(unit:  new Royal.Scenes.Game.Levels.Units.MatchHint.HintManager());
        }
        public void Bind()
        {
        
        }
        public void Clear(bool gameExit)
        {
            var val_7;
            Royal.Scenes.Game.Levels.LevelContext.<IsActive>k__BackingField = false;
            Royal.Scenes.Game.Mechanics.Explode.Exploder.Reset();
            var val_6 = 0;
            var val_5 = 0;
            val_5 = val_5 + 1;
            (Royal.Infrastructure.Contexts.__il2cppRuntimeField_20 == 0) ? 0 : (Royal.Infrastructure.Contexts.__il2cppRuntimeField_20).Clear(gameExit:  gameExit);
            val_6 = val_6 + 1;
            if(gameExit != false)
            {
                    this.RemoveLateUnits();
            }
            
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  1, log:  "LevelContext de-activated", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public void RemoveLateUnits()
        {
            this.container.RemoveLateUnits();
        }
        private void ArrangeRecordReplay(bool forNewLevel)
        {
            Royal.Scenes.Game.Context.IGameContextUnit val_10;
            int val_11;
            val_10 = forNewLevel;
            Royal.Scenes.Game.Levels.Units.LevelRandomManager val_1 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0);
            if(val_10 == false)
            {
                goto label_1;
            }
            
            if((Royal.Scenes.Game.Context.Units.GameManager.<IsReplay>k__BackingField) == false)
            {
                goto label_4;
            }
            
            this.container.Remove(id:  9);
            this.container.Remove(id:  8);
            Royal.Scenes.Game.Levels.Units.Replay.ReplayManager val_2 = new Royal.Scenes.Game.Levels.Units.Replay.ReplayManager();
            this.container.AddToFirst(unit:  val_2);
            this.deltaTimeManager = new Royal.Scenes.Game.Mechanics.DeltaTime.ReplayDeltaTimeManager(manager:  val_2);
            val_1.SetSeed(seed:  val_2.GetSeed());
            return;
            label_1:
            val_1.ResetSeed();
            Royal.Scenes.Game.Levels.Units.Replay.RecordManager val_5 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Replay.RecordManager>(contextId:  9);
            val_11 = val_1.seed;
            goto label_11;
            label_4:
            this.container.Remove(id:  8);
            val_1.ResetSeed();
            if((this.container.Has(id:  9)) == false)
            {
                goto label_14;
            }
            
            val_10 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Replay.RecordManager>(contextId:  9);
            if(val_10 != null)
            {
                goto label_15;
            }
            
            label_14:
            Royal.Scenes.Game.Levels.Units.Replay.RecordManager val_8 = null;
            val_10 = val_8;
            val_8 = new Royal.Scenes.Game.Levels.Units.Replay.RecordManager();
            this.container.AddToFirst(unit:  val_8);
            label_15:
            val_11 = val_1.seed;
            label_11:
            val_8.Init(seed:  val_11);
            this.deltaTimeManager = new Royal.Scenes.Game.Mechanics.DeltaTime.DeltaTimeManager();
        }
        public void ManualUpdate()
        {
            this.container.ManualUpdate();
        }
        public void Activate(bool forNewLevel)
        {
            var val_1;
            forNewLevel = forNewLevel;
            this.ArrangeRecordReplay(forNewLevel:  forNewLevel);
            if(forNewLevel != false)
            {
                    this.ArrangeWinFailManager();
                BindAll();
            }
            
            Royal.Scenes.Game.Levels.LevelContext.<IsActive>k__BackingField = true;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  1, log:  "LevelContext activated", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        private void ArrangeWinFailManager()
        {
            var val_5;
            var val_6;
            Royal.Infrastructure.Contexts.ContextContainer<Royal.Scenes.Game.Context.IGameContextUnit> val_7;
            var val_8;
            Royal.Scenes.Game.Context.IGameContextUnit val_10;
            val_5 = this;
            val_6 = this.container.Get<Royal.Scenes.Game.Levels.Units.WinFail.IWinFailManager>(id:  15);
            if(Royal.Player.Context.Units.LevelManager.IsStoryLevel == false)
            {
                goto label_2;
            }
            
            val_7 = this.container;
            Royal.Scenes.Game.Levels.Units.WinFail.StoryWinFailManager val_3 = null;
            val_8 = val_3;
            val_3 = new Royal.Scenes.Game.Levels.Units.WinFail.StoryWinFailManager();
            if(val_7 != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_2:
            Royal.Scenes.Game.Levels.Units.WinFail.WinFailManager val_4 = null;
            val_10 = val_4;
            val_4 = new Royal.Scenes.Game.Levels.Units.WinFail.WinFailManager();
            label_6:
            val_7.Replace(unit:  val_4);
        }
        public void Deactivate(bool gameExit)
        {
            this.Clear(gameExit:  gameExit);
        }
        public static T Get<T>(Royal.Scenes.Game.Levels.LevelContextId contextId)
        {
            goto __RuntimeMethodHiddenParam + 48;
        }
        public static T GetLate<T>(Royal.Scenes.Game.Levels.LevelContextId contextId)
        {
            var val_2;
            var val_3;
            var val_4;
            val_2 = __RuntimeMethodHiddenParam;
            if((Royal.Scenes.Game.Levels.LevelContext.IsLateContextRequired(contextId:  contextId)) != false)
            {
                    val_3 = Royal.Scenes.Game.Levels.LevelContext.Instance.container;
            }
            else
            {
                    val_3 = 0;
                val_2 = val_2 + 48;
            }
            
            if(val_3 != 0)
            {
                    if(X0 == true)
            {
                    return (Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemHelper)val_4;
            }
            
            }
            
            val_4 = 0;
            return (Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemHelper)val_4;
        }
        public static bool IsLateContextRequired(Royal.Scenes.Game.Levels.LevelContextId contextId)
        {
            var val_8;
            Royal.Player.Context.Units.LevelManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2);
            val_8 = 1;
            if((contextId - 23) > 12)
            {
                    return (bool)( == true) ? 1 : 0;
            }
            
            var val_8 = 36587864 + ((contextId - 23)) << 2;
            val_8 = val_8 + 36587864;
            goto (36587864 + ((contextId - 23)) << 2 + 36587864);
        }
        public static bool Has(Royal.Scenes.Game.Levels.LevelContextId contextId)
        {
            return Has(id:  contextId);
        }
        public static Royal.Scenes.Game.Context.IGameContextUnit[] GetAllUnits()
        {
            return (Royal.Scenes.Game.Context.IGameContextUnit[])Royal.Infrastructure.Contexts.ContextContainer<T>.__il2cppRuntimeField_namespaze;
        }
        public static void SetTimeScale(float timeScale)
        {
            Royal.Scenes.Game.Mechanics.DeltaTime.IDeltaTimeManager val_4 = null;
            if((mem[null + 294]) == 0)
            {
                goto label_6;
            }
            
            var val_1 = mem[null + 176];
            var val_2 = 0;
            val_1 = val_1 + 8;
            label_5:
            if(((mem[null + 176] + 8) + -8) == null)
            {
                goto label_4;
            }
            
            val_2 = val_2 + 1;
            val_1 = val_1 + 16;
            if(val_2 < (mem[null + 294]))
            {
                goto label_5;
            }
            
            goto label_6;
            label_4:
            var val_3 = val_1;
            val_3 = val_3 + 4;
            val_4 = val_4 + val_3;
            label_6:
            SetTimeScale(timeScale:  timeScale);
        }
    
    }

}
