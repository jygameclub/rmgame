using UnityEngine;

namespace Royal.Scenes.Home.Context.Units.Area
{
    public class AreaManager : IContextUnit
    {
        // Fields
        private readonly Royal.Scenes.Home.Context.Units.Area.Config.AreaConfigContainer configContainer;
        private Royal.Scenes.Home.Areas.Scripts.AreaView <AreaView>k__BackingField;
        private Royal.Player.Context.Units.UserManager userManager;
        private Royal.Infrastructure.Services.Analytics.AnalyticsManager analyticsManager;
        private System.Action OnTaskUpdate;
        private System.Action OnAreaUpdate;
        
        // Properties
        public int Id { get; }
        public Royal.Scenes.Home.Areas.Scripts.AreaView AreaView { get; set; }
        
        // Methods
        public int get_Id()
        {
            return 0;
        }
        public Royal.Scenes.Home.Areas.Scripts.AreaView get_AreaView()
        {
            return (Royal.Scenes.Home.Areas.Scripts.AreaView)this.<AreaView>k__BackingField;
        }
        private void set_AreaView(Royal.Scenes.Home.Areas.Scripts.AreaView value)
        {
            this.<AreaView>k__BackingField = value;
        }
        public void add_OnTaskUpdate(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnTaskUpdate, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnTaskUpdate != 1152921519581913760);
            
            return;
            label_2:
        }
        public void remove_OnTaskUpdate(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnTaskUpdate, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnTaskUpdate != 1152921519582050336);
            
            return;
            label_2:
        }
        public void add_OnAreaUpdate(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnAreaUpdate, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnAreaUpdate != 1152921519582186920);
            
            return;
            label_2:
        }
        public void remove_OnAreaUpdate(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnAreaUpdate, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnAreaUpdate != 1152921519582323496);
            
            return;
            label_2:
        }
        public AreaManager()
        {
            this.configContainer = new Royal.Scenes.Home.Context.Units.Area.Config.AreaConfigContainer();
        }
        public void Bind()
        {
            this.analyticsManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17);
            this.userManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Game.Context.GameContext>(id:  11).add_OnActivate(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Context.Units.Area.AreaManager::<Bind>b__16_0()));
        }
        public void ClearEvents()
        {
            this.OnTaskUpdate = 0;
            this.OnAreaUpdate = 0;
        }
        public Royal.Scenes.Home.Context.Units.Area.Config.AreaConfig LoadConfig(int id)
        {
            if(this.configContainer != null)
            {
                    return this.configContainer.LoadAreaConfig(id:  id);
            }
            
            throw new NullReferenceException();
        }
        public Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig LoadRowConfig(int id)
        {
            null = null;
            Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig[] val_2 = Royal.Scenes.Home.Context.Units.Area.Config.AreaConfigContainer.RowConfigs;
            val_2 = val_2 + ((id - 1) << 3);
            return (Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig)(Royal.Scenes.Home.Context.Units.Area.Config.AreaConfigContainer.RowConfigs + ((id - 1)) << 3) + 32;
        }
        public void CreateAreaView()
        {
            var val_10;
            .<>4__this = this;
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.IsInLeague()) != false)
            {
                    Royal.Scenes.Home.Context.Units.Area.Config.AreaConfig val_3 = this.configContainer.LoadAreaConfig(id:  0);
                .<AreaId>k__BackingField = val_3.areaId;
                .<Tasks>k__BackingField = new Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData[0];
                .areaData = new Royal.Player.Context.Data.Persistent.UserAreaData();
            }
            else
            {
                    .areaData = Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<AreaData>k__BackingField;
                val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  10, log:  Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<AreaData>k__BackingField, values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            }
            
            if((this.<AreaView>k__BackingField) != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.<AreaView>k__BackingField.gameObject);
                if((((this.<AreaView>k__BackingField.<AreaId>k__BackingField) & 2147483648) == 0) && ((this.<AreaView>k__BackingField.<AreaId>k__BackingField) != ((AreaManager.<>c__DisplayClass20_0)[1152921519583144176].areaData.<AreaId>k__BackingField)))
            {
                    Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper>(id:  8).UnloadAreaBundle(areaNo:  this.<AreaView>k__BackingField.<AreaId>k__BackingField);
            }
            
            }
            
            Royal.Scenes.Home.Context.Units.Area.AreaManager.InstantiateAreaView(areaId:  (AreaManager.<>c__DisplayClass20_0)[1152921519583144176].areaData.<AreaId>k__BackingField, async:  false, onComplete:  new System.Action<Royal.Scenes.Home.Areas.Scripts.AreaView>(object:  new AreaManager.<>c__DisplayClass20_0(), method:  System.Void AreaManager.<>c__DisplayClass20_0::<CreateAreaView>b__0(Royal.Scenes.Home.Areas.Scripts.AreaView areaView)));
        }
        public void Build(int taskId, int price, System.Action onComplete)
        {
            if((HasEnoughStars(delta:  price)) != false)
            {
                    bool val_2 = SpendStars(delta:  price);
                UpdateAreaTask(taskData:  new Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData() {taskId = taskId | 4294967296, isCompleted = taskId | 4294967296});
                this.userManager.SendDataToBackend(forceToSend:  false, forceScoreData:  false);
                Royal.Scenes.Home.Context.Units.Area.Config.AreaConfig val_4 = this.configContainer.LoadAreaConfig(id:  129259600);
                this.analyticsManager.Tasks(areaId:  129259600, config:  val_4, taskConfig:  val_4.GetConfigForTaskId(taskId:  taskId), starCost:  price);
                this.SetLastCompletedTaskId(taskId:  taskId);
                this.<AreaView>k__BackingField.ShowTask(taskId:  taskId, onComplete:  onComplete);
                return;
            }
            
            onComplete.Invoke();
        }
        public int GetLastCompletedTaskId()
        {
            return Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "LastCompletedTaskId", defaultValue:  0);
        }
        public void SetLastCompletedTaskId(int taskId)
        {
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "LastCompletedTaskId", value:  taskId);
            if(this.OnTaskUpdate == null)
            {
                    return;
            }
            
            this.OnTaskUpdate.Invoke();
        }
        public static void InstantiateAreaView(int areaId, bool async, System.Action<Royal.Scenes.Home.Areas.Scripts.AreaView> onComplete)
        {
            AreaManager.<>c__DisplayClass24_0 val_12;
            string val_13;
            AreaManager.<>c__DisplayClass24_0 val_1 = null;
            val_12 = val_1;
            val_1 = new AreaManager.<>c__DisplayClass24_0();
            .onComplete = onComplete;
            val_13 = "area_" + areaId.ToString(format:  "D2")(areaId.ToString(format:  "D2"));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper>(id:  8).LoadAreaBundle(areaNo:  areaId);
            if(async != false)
            {
                    .CS$<>8__locals1 = val_12;
                UnityEngine.ResourceRequest val_6 = UnityEngine.Resources.LoadAsync<Royal.Scenes.Home.Areas.Scripts.AreaView>(path:  val_13);
                .resourceRequest = val_6;
                val_12 = val_6;
                System.Action<UnityEngine.AsyncOperation> val_7 = null;
                val_13 = val_7;
                val_7 = new System.Action<UnityEngine.AsyncOperation>(object:  new AreaManager.<>c__DisplayClass24_1(), method:  System.Void AreaManager.<>c__DisplayClass24_1::<InstantiateAreaView>b__0(UnityEngine.AsyncOperation operation));
                val_12.add_completed(value:  val_7);
                return;
            }
            
            if(areaId != 0)
            {
                    Royal.Scenes.Home.Areas.Scripts.AreaView val_8 = UnityEngine.Resources.Load<Royal.Scenes.Home.Areas.Scripts.AreaView>(path:  val_13);
            }
            
            (AreaManager.<>c__DisplayClass24_0)[1152921519583778736].onComplete.Invoke(obj:  UnityEngine.Object.Instantiate<Royal.Scenes.Home.Areas.Scripts.AreaView>(original:  val_4.royalLeagueBundle.LeagueAreaBundledPrefab.GetComponent<Royal.Scenes.Home.Areas.Scripts.AreaView>()));
        }
        public void RefreshArea()
        {
            this.RefreshAreaImmediately();
        }
        private void RefreshAreaImmediately()
        {
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "LastCompletedTaskId", value:  0);
            this.CreateAreaView();
            if(this.OnTaskUpdate != null)
            {
                    this.OnTaskUpdate.Invoke();
            }
            
            if(this.OnAreaUpdate == null)
            {
                    return;
            }
            
            this.OnAreaUpdate.Invoke();
        }
        public void UnlockNextArea()
        {
            Royal.Scenes.Home.Context.Units.Area.Config.AreaConfig val_1 = this.configContainer.LoadAreaConfig(id:  129259601);
            Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData[] val_2 = new Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData[0];
            if((val_2.Length << 32) >= 1)
            {
                    do
            {
                var val_4 = 0 + 1;
                mem2[0] = val_4;
            }
            while(val_4 < (long)val_2.Length);
            
            }
            
            UpdateAreaData(areaId:  val_1.areaId, status:  0, taskData:  val_2, realAreaId:  0);
            this.userManager.SendDataToBackend(forceToSend:  false, forceScoreData:  false);
            this.RefreshAreaImmediately();
        }
        public void ClaimChest()
        {
            Royal.Player.Context.Data.InventoryPackage val_1 = Royal.Player.Context.Data.InventoryPackage.GetAreaChestPackage(areaId:  129259600);
            Royal.Player.Context.Units.UserManager.AddInventoryPackage(package:  val_1);
            UpdateAreaData(areaId:  129259600, status:  1, taskData:  Royal.Player.Context.Data.Persistent.UserAreaData.__il2cppRuntimeField_byval_arg, realAreaId:  0);
            this.userManager.SendDataToBackend(forceToSend:  false, forceScoreData:  false);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).EpisodeChestClaim(package:  val_1);
        }
        private void <Bind>b__16_0()
        {
            if((this.<AreaView>k__BackingField) != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
    
    }

}
