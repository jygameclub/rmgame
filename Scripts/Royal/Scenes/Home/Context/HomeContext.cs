using UnityEngine;

namespace Royal.Scenes.Home.Context
{
    public class HomeContext : IContextBehaviour, IContextUnit
    {
        // Fields
        private static readonly Royal.Infrastructure.Contexts.ContextContainer<Royal.Infrastructure.Contexts.IContextUnit> Container;
        private static Royal.Scenes.Home.Context.HomeContextController <Controller>k__BackingField;
        public static bool ShouldDelayAutoActionsToWaitFinishedEventResponse;
        private bool isActive;
        private System.Action OnActivate;
        
        // Properties
        public static Royal.Scenes.Home.Context.HomeContextController Controller { get; set; }
        public int Id { get; }
        
        // Methods
        public static Royal.Scenes.Home.Context.HomeContextController get_Controller()
        {
            null = null;
            return (Royal.Scenes.Home.Context.HomeContextController)Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField;
        }
        private static void set_Controller(Royal.Scenes.Home.Context.HomeContextController value)
        {
            null = null;
            Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField = value;
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
            while(this.OnActivate != 1152921519548577704);
            
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
            while(this.OnActivate != 1152921519548714280);
            
            return;
            label_2:
        }
        public int get_Id()
        {
            return 10;
        }
        public HomeContext()
        {
            Royal.Scenes.Home.Context.HomeContext.Add<Royal.Scenes.Home.Context.Units.Area.AreaManager>(unit:  new Royal.Scenes.Home.Context.Units.Area.AreaManager());
            Royal.Scenes.Home.Context.HomeContext.Add<Royal.Infrastructure.Services.Helpshift.HelpshiftManager>(unit:  new Royal.Infrastructure.Services.Helpshift.HelpshiftManager());
            Royal.Scenes.Home.Context.HomeContext.Add<Royal.Scenes.Home.Context.Units.HomeSceneFlow>(unit:  new Royal.Scenes.Home.Context.Units.HomeSceneFlow());
            Royal.Scenes.Home.Context.HomeContext.Add<Royal.Scenes.Home.Context.Units.Tutorial.HomeTutorialManager>(unit:  new Royal.Scenes.Home.Context.Units.Tutorial.HomeTutorialManager());
            Royal.Scenes.Home.Context.HomeContext.Add<Royal.Infrastructure.Services.Backend.Tcp.BackendTcpService>(unit:  new Royal.Infrastructure.Services.Backend.Tcp.BackendTcpService());
        }
        public void Bind()
        {
            null = null;
            Royal.Scenes.Home.Context.HomeContext.Container.BindAll();
        }
        public void Activate(Royal.Scenes.Home.Context.HomeContextController controller)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField = controller;
            this.isActive = true;
            UnityEngine.Input.multiTouchEnabled = true;
            if(this.OnActivate != null)
            {
                    this.OnActivate.Invoke();
            }
            
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsLowEnd != false)
            {
                    UnityEngine.AsyncOperation val_2 = UnityEngine.Resources.UnloadUnusedAssets();
            }
            
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  1, log:  "HomeContext activated", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public void Deactivate()
        {
            var val_4;
            var val_5;
            this.isActive = false;
            UnityEngine.Input.multiTouchEnabled = false;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  1, log:  "HomeContext de-activated", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            Royal.Scenes.Home.Episodes.Scripts.EpisodeAssetsLibrary.Instance.Clear();
            Royal.Scenes.Home.Context.Units.Area.AreaManager val_2 = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0);
            val_2 = 0;
            val_2 = 0;
            int val_3 = DG.Tweening.DOTween.KillAll(complete:  false);
            val_5 = null;
            val_5 = null;
            Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField = 0;
        }
        public void ManualUpdate()
        {
            var val_1;
            if(this.isActive == false)
            {
                    return;
            }
            
            val_1 = null;
            val_1 = null;
            Royal.Scenes.Home.Context.HomeContext.Container.ManualUpdate();
        }
        public static T Get<T>(Royal.Scenes.Home.Context.HomeContextId id)
        {
            null = null;
            goto __RuntimeMethodHiddenParam + 48;
        }
        private static void Add<T>(T unit)
        {
            null = null;
            Royal.Scenes.Home.Context.HomeContext.Container.Add(unit:  unit);
        }
        private static void Remove(Royal.Scenes.Home.Context.HomeContextId id)
        {
            null = null;
            Royal.Scenes.Home.Context.HomeContext.Container.Remove(id:  id);
        }
        public static void Clear()
        {
            null = null;
            Royal.Scenes.Home.Context.HomeContext.Container.Clear();
        }
        public static UnityEngine.Coroutine ManualStartCoroutine(System.Collections.IEnumerator iEnumerator)
        {
            null = null;
            return Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField.StartCoroutine(routine:  iEnumerator);
        }
        public static void ManualStopCoroutine(UnityEngine.Coroutine resetButtonRoutine)
        {
            null = null;
            Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField.StopCoroutine(routine:  resetButtonRoutine);
        }
        public static bool ShouldDelayAutoActions()
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            if(Royal.Scenes.Home.Context.HomeContext.ShouldDelayAutoActionsToWaitFinishedEventResponse != false)
            {
                    val_4 = 1;
            }
            else
            {
                    val_5 = null;
                val_5 = null;
                if((Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField) == null)
            {
                    throw new NullReferenceException();
            }
            
                if(null == 0)
            {
                    throw new NullReferenceException();
            }
            
                bool val_1 = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.AtSection(type:  0);
                val_4 = val_1 ^ 1;
            }
            
            val_1 = val_4;
            return (bool)val_1;
        }
        private static HomeContext()
        {
            System.String[] val_2 = System.Enum.GetNames(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            Royal.Scenes.Home.Context.HomeContext.Container = new Royal.Infrastructure.Contexts.ContextContainer<Royal.Infrastructure.Contexts.IContextUnit>(contextUnitCount:  val_2.Length);
        }
    
    }

}
