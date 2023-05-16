using UnityEngine;

namespace Royal.Scenes.Game.Context
{
    public class GameContext : IContextBehaviour, IContextUnit
    {
        // Fields
        private static readonly Royal.Infrastructure.Contexts.ContextContainer<Royal.Scenes.Game.Context.IGameContextUnit> Container;
        private static Royal.Scenes.Game.Context.GameContextController <Controller>k__BackingField;
        private static System.Action OnManualLateUpdate;
        private System.Action OnActivate;
        private Royal.Scenes.Game.Context.Units.GameManager gameManager;
        private static bool IsActive;
        
        // Properties
        public static Royal.Scenes.Game.Context.GameContextController Controller { get; set; }
        public int Id { get; }
        
        // Methods
        public static Royal.Scenes.Game.Context.GameContextController get_Controller()
        {
            null = null;
            return (Royal.Scenes.Game.Context.GameContextController)Royal.Scenes.Game.Context.GameContext.<Controller>k__BackingField;
        }
        private static void set_Controller(Royal.Scenes.Game.Context.GameContextController value)
        {
            null = null;
            Royal.Scenes.Game.Context.GameContext.<Controller>k__BackingField = value;
        }
        private static void add_OnManualLateUpdate(System.Action value)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            do
            {
                if((System.Delegate.Combine(a:  Royal.Scenes.Game.Context.GameContext.OnManualLateUpdate, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_4;
            }
            
            }
            
                val_3 = null;
                val_3 = null;
            }
            while(Royal.Scenes.Game.Context.GameContext.OnManualLateUpdate != 1152921505122717712);
            
            return;
            label_4:
        }
        private static void remove_OnManualLateUpdate(System.Action value)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            do
            {
                if((System.Delegate.Remove(source:  Royal.Scenes.Game.Context.GameContext.OnManualLateUpdate, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_4;
            }
            
            }
            
                val_3 = null;
                val_3 = null;
            }
            while(Royal.Scenes.Game.Context.GameContext.OnManualLateUpdate != 1152921505122717712);
            
            return;
            label_4:
        }
        public void add_OnActivate(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnActivate, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnActivate != 1152921524131781632);
            
            return;
            label_2:
        }
        public void remove_OnActivate(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnActivate, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnActivate != 1152921524131918208);
            
            return;
            label_2:
        }
        public int get_Id()
        {
            return 11;
        }
        public void Bind()
        {
            Royal.Scenes.Game.Context.Units.GameTouchListener val_2 = Royal.Scenes.Game.Context.GameContext.Add<Royal.Scenes.Game.Context.Units.GameTouchListener>(unit:  new Royal.Scenes.Game.Context.Units.GameTouchListener());
            Royal.Scenes.Game.Levels.LevelContext val_4 = Royal.Scenes.Game.Context.GameContext.Add<Royal.Scenes.Game.Levels.LevelContext>(unit:  new Royal.Scenes.Game.Levels.LevelContext());
            Royal.Scenes.Game.Context.Units.GameManager val_5 = new Royal.Scenes.Game.Context.Units.GameManager();
            this.gameManager = val_5;
            Royal.Scenes.Game.Context.Units.GameManager val_6 = Royal.Scenes.Game.Context.GameContext.Add<Royal.Scenes.Game.Context.Units.GameManager>(unit:  val_5);
            Royal.Scenes.Game.Context.GameContext.Container.BindAll();
        }
        public void Activate(Royal.Scenes.Game.Context.GameContextController controller)
        {
            var val_6;
            var val_7;
            val_6 = null;
            val_6 = null;
            Royal.Scenes.Game.Context.GameContext.<Controller>k__BackingField = controller;
            Royal.Scenes.Game.Context.GameContext.IsActive = true;
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  1, log:  "GameContext activated", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsLowEnd != false)
            {
                    Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2).CreatePools();
            }
            
            if(this.OnActivate != null)
            {
                    this.OnActivate.Invoke();
            }
            
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsLowEnd != false)
            {
                    UnityEngine.AsyncOperation val_5 = UnityEngine.Resources.UnloadUnusedAssets();
            }
            
            this.gameManager.StartGame();
            throw new NullReferenceException();
        }
        private void Deactivate()
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            val_9 = null;
            val_9 = null;
            Royal.Scenes.Game.Context.GameContext.IsActive = false;
            Royal.Scenes.Game.Context.GameContext.OnManualLateUpdate = 0;
            var val_8 = Royal.Scenes.Game.Context.GameContext.Container + 24 + 24;
            if(val_8 < 1)
            {
                goto label_5;
            }
            
            var val_12 = 0;
            val_8 = val_8 & 4294967295;
            label_13:
            var val_1 = (Royal.Scenes.Game.Context.GameContext.Container + 24) + 0;
            var val_2 = (((Royal.Scenes.Game.Context.GameContext.Container + 24 + 0) + 32) == 0) ? 0 : ((Royal.Scenes.Game.Context.GameContext.Container + 24 + 0) + 32);
            if(((Royal.Scenes.Game.Context.GameContext.Container + 24 + 0) + 32) == 0)
            {
                goto label_7;
            }
            
            var val_11 = val_2;
            if(((Royal.Scenes.Game.Context.GameContext.Container + 24 + 0) + 32 == 0x0 ? 0 : (Royal.Scenes.Game.Context.GameContext.Container + 24 + 0) + 32 + 294) == 0)
            {
                goto label_12;
            }
            
            var val_9 = (Royal.Scenes.Game.Context.GameContext.Container + 24 + 0) + 32 == 0x0 ? 0 : (Royal.Scenes.Game.Context.GameContext.Container + 24 + 0) + 32 + 176;
            var val_10 = 0;
            val_9 = val_9 + 8;
            label_11:
            if((((Royal.Scenes.Game.Context.GameContext.Container + 24 + 0) + 32 == 0x0 ? 0 : (Royal.Scenes.Game.Context.GameContext.Container + 24 + 0) + 32 + 176 + 8) + -8) == null)
            {
                goto label_10;
            }
            
            val_10 = val_10 + 1;
            val_9 = val_9 + 16;
            if(val_10 < ((Royal.Scenes.Game.Context.GameContext.Container + 24 + 0) + 32 == 0x0 ? 0 : (Royal.Scenes.Game.Context.GameContext.Container + 24 + 0) + 32 + 294))
            {
                goto label_11;
            }
            
            goto label_12;
            label_10:
            val_11 = val_11 + ((((Royal.Scenes.Game.Context.GameContext.Container + 24 + 0) + 32 == 0x0 ? 0 : (Royal.Scenes.Game.Context.GameContext.Container + 24 + 0) + 32 + 176 + 8)) << 4);
            val_10 = val_11 + 304;
            label_12:
            val_2.Clear(gameExit:  true);
            label_7:
            val_12 = val_12 + 1;
            if(val_12 < ((Royal.Scenes.Game.Context.GameContext.Container + 24 + 24) << ))
            {
                goto label_13;
            }
            
            label_5:
            int val_3 = DG.Tweening.DOTween.KillAll(complete:  false);
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_4 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            val_11 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_11 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_11 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_11 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  1, log:  "GameContext de-activated", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsLowEnd != false)
            {
                    Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1).ClearPools();
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(id:  2).LoadHomeScene();
            val_12 = null;
            val_12 = null;
            Royal.Scenes.Game.Context.GameContext.<Controller>k__BackingField = 0;
        }
        public void ManualUpdate()
        {
            var val_1 = null;
            if(Royal.Scenes.Game.Context.GameContext.IsActive == false)
            {
                    return;
            }
            
            if(this.gameManager.shouldExitGame != false)
            {
                    this.Deactivate();
                return;
            }
            
            Royal.Scenes.Game.Context.GameContext.__il2cppRuntimeField_static_fields.ManualUpdate();
        }
        public static T Get<T>(Royal.Scenes.Game.Context.GameContextId id)
        {
            null = null;
            goto __RuntimeMethodHiddenParam + 48;
        }
        private static T Add<T>(T unit)
        {
            null = null;
            Royal.Scenes.Game.Context.GameContext.Container.Add(unit:  unit);
            return (Royal.Scenes.Game.Context.Units.GameManager)unit;
        }
        private static void Remove(Royal.Scenes.Game.Context.GameContextId id)
        {
            null = null;
            Royal.Scenes.Game.Context.GameContext.Container.Remove(id:  id);
        }
        public static void RegisterToLateUpdate(System.Action lateUpdate)
        {
            Royal.Scenes.Game.Context.GameContext.add_OnManualLateUpdate(value:  lateUpdate);
        }
        public static void ManualLateUpdate()
        {
            null = null;
            if(Royal.Scenes.Game.Context.GameContext.OnManualLateUpdate == null)
            {
                    return;
            }
            
            Royal.Scenes.Game.Context.GameContext.OnManualLateUpdate.Invoke();
        }
        public static Royal.Infrastructure.Contexts.ContextContainer<Royal.Scenes.Game.Context.IGameContextUnit> GetContainer()
        {
            null = null;
            return (Royal.Infrastructure.Contexts.ContextContainer<Royal.Scenes.Game.Context.IGameContextUnit>)Royal.Scenes.Game.Context.GameContext.Container;
        }
        public static UnityEngine.Coroutine ManualStartCoroutine(System.Collections.IEnumerator iEnumerator)
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            if(Royal.Scenes.Game.Context.GameContext.IsActive == false)
            {
                    return 0;
            }
            
            val_2 = null;
            val_2 = null;
            return Royal.Scenes.Game.Context.GameContext.<Controller>k__BackingField.StartCoroutine(routine:  iEnumerator);
        }
        public static void ManualStopCoroutine(UnityEngine.Coroutine coroutine)
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            if(Royal.Scenes.Game.Context.GameContext.IsActive == false)
            {
                    return;
            }
            
            val_2 = null;
            val_2 = null;
            Royal.Scenes.Game.Context.GameContext.<Controller>k__BackingField.StopCoroutine(routine:  coroutine);
        }
        public GameContext()
        {
        
        }
        private static GameContext()
        {
            System.String[] val_2 = System.Enum.GetNames(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            Royal.Scenes.Game.Context.GameContext.Container = new Royal.Infrastructure.Contexts.ContextContainer<Royal.Scenes.Game.Context.IGameContextUnit>(contextUnitCount:  val_2.Length);
        }
    
    }

}
