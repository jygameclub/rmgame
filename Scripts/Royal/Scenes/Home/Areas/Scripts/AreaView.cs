using UnityEngine;

namespace Royal.Scenes.Home.Areas.Scripts
{
    public class AreaView : MonoBehaviour
    {
        // Fields
        private int <AreaId>k__BackingField;
        protected Royal.Scenes.Home.Areas.Scripts.AreaBackgroundView backgroundView;
        private Royal.Scenes.Home.Areas.Scripts.AreaTaskView[] taskViews;
        private Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        protected internal Royal.Scenes.Home.Areas.Scripts.AreaViewBackgroundSounds areaViewBackgroundSounds;
        private UnityEngine.Coroutine playAreaBackgroundSoundsEnumerator;
        
        // Properties
        public int AreaId { get; set; }
        
        // Methods
        public int get_AreaId()
        {
            return (int)this.<AreaId>k__BackingField;
        }
        private void set_AreaId(int value)
        {
            this.<AreaId>k__BackingField = value;
        }
        protected virtual void Awake()
        {
            UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.areaViewBackgroundSounds = new Royal.Scenes.Home.Areas.Scripts.AreaViewBackgroundSounds();
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Game.Context.GameContext>(id:  11).add_OnActivate(value:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Home.Areas.Scripts.AreaView::StopBackgroundSounds()));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.HomeContext>(id:  10).add_OnActivate(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaView::HomeSceneReady()));
        }
        private void HomeSceneReady()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.remove_OnSectionChange(value:  new System.Action<Royal.Scenes.Home.Ui.Sections.Section>(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaView::SectionChanged(Royal.Scenes.Home.Ui.Sections.Section section)));
            val_4 = null;
            val_4 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.add_OnSectionChange(value:  new System.Action<Royal.Scenes.Home.Ui.Sections.Section>(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaView::SectionChanged(Royal.Scenes.Home.Ui.Sections.Section section)));
        }
        protected virtual void OnDestroy()
        {
            var val_7;
            var val_8;
            System.Action val_9;
            var val_10;
            val_7 = null;
            val_7 = null;
            if((Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField) != 0)
            {
                    val_8 = null;
                val_8 = null;
                Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.remove_OnSectionChange(value:  new System.Action<Royal.Scenes.Home.Ui.Sections.Section>(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaView::SectionChanged(Royal.Scenes.Home.Ui.Sections.Section section)));
            }
            
            val_10 = null;
            val_10 = null;
            if((Royal.Scenes.Start.Context.ApplicationContext.<IsActive>k__BackingField) != false)
            {
                    Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Game.Context.GameContext>(id:  11).remove_OnActivate(value:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Home.Areas.Scripts.AreaView::StopBackgroundSounds()));
                System.Action val_6 = null;
                val_9 = val_6;
                val_6 = new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaView::HomeSceneReady());
                Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.HomeContext>(id:  10).remove_OnActivate(value:  val_6);
            }
            
            this.StopBackgroundSounds();
        }
        public void InitSectionArea(Royal.Player.Context.Data.Persistent.UserAreaData userAreaData)
        {
            var val_5;
            Royal.Scenes.Home.Context.HomeContextController val_6;
            var val_7;
            var val_8;
            var val_9;
            val_5 = null;
            val_5 = null;
            val_6 = Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField;
            if(val_6 != 0)
            {
                    val_7 = null;
                val_7 = null;
                if((Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField.isActiveAndEnabled) != false)
            {
                    val_8 = null;
                val_8 = null;
                Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.remove_OnSectionChange(value:  new System.Action<Royal.Scenes.Home.Ui.Sections.Section>(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaView::SectionChanged(Royal.Scenes.Home.Ui.Sections.Section section)));
                val_9 = null;
                val_9 = null;
                Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.add_OnSectionChange(value:  new System.Action<Royal.Scenes.Home.Ui.Sections.Section>(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaView::SectionChanged(Royal.Scenes.Home.Ui.Sections.Section section)));
            }
            
            }
            
            this.PlayBackgroundSounds();
            this.Init(areaId:  userAreaData.<AreaId>k__BackingField);
            goto typeof(Royal.Scenes.Home.Areas.Scripts.AreaView).__il2cppRuntimeField_1A0;
        }
        public virtual void InitPreviousArea(int areaId)
        {
            this.Init(areaId:  areaId);
        }
        public Royal.Scenes.Home.Areas.Scripts.AreaView.OnReplayKilled InitPreviousAreaReplaySequence(System.Action onReplayComplete)
        {
            return this.ReplayAnimations(isForPreviousArea:  true, onComplete:  onReplayComplete);
        }
        private void Init(int areaId)
        {
            Royal.Scenes.Home.Areas.Scripts.AreaBackgroundView val_1 = this.GetComponentInChildren<Royal.Scenes.Home.Areas.Scripts.AreaBackgroundView>();
            this.backgroundView = val_1;
            val_1.Init(areaId:  areaId);
            T[] val_2 = this.GetComponentsInChildren<Royal.Scenes.Home.Areas.Scripts.AreaTaskView>(includeInactive:  true);
            this.taskViews = val_2;
            this.areaViewBackgroundSounds = val_2;
            this.ArrangeSize();
            this.<AreaId>k__BackingField = areaId;
        }
        public Royal.Scenes.Home.Areas.Scripts.AreaView.OnReplayKilled ReplayAnimations(bool isForPreviousArea, System.Action onComplete)
        {
            DG.Tweening.Sequence val_20;
            float val_21;
            float val_22;
            AreaView.<>c__DisplayClass17_0 val_1 = new AreaView.<>c__DisplayClass17_0();
            .<>4__this = this;
            .onComplete = onComplete;
            if(isForPreviousArea != false)
            {
                    this.HideAllTasks();
            }
            
            Royal.Scenes.Home.Context.Units.Area.Config.AreaConfig val_3 = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0).LoadConfig(id:  this.<AreaId>k__BackingField);
            val_20 = val_3;
            val_21 = 0f;
            .areaPlayAnimations = new System.Collections.Generic.List<DG.Tweening.Sequence>();
            if(isForPreviousArea != false)
            {
                    if(this.cameraManager.IsDeviceTall() != false)
            {
                    val_21 = val_3.tallDeviceReplayDelay;
            }
            else
            {
                    val_21 = 0.5f;
            }
            
            }
            
            .areaSeq = DG.Tweening.DOTween.Sequence();
            if(val_4.Length >= 1)
            {
                    var val_24 = 0;
                float val_23 = 0f;
                do
            {
                .CS$<>8__locals1 = val_1;
                int val_21 = val_4.Length;
                Royal.Scenes.Home.Context.Units.Area.Config.AreaTaskConfig val_20 = val_3.GetReplayOrderedTasks()[val_24];
                val_21 = val_21 - 1;
                .isLast = (val_24 == val_21) ? 1 : 0;
                Royal.Scenes.Home.Areas.Scripts.AreaTaskView val_10 = this.FindView(id:  val_4[0x0][0].id);
                .areaTaskView = val_10;
                val_10 = 1;
                (AreaView.<>c__DisplayClass17_1)[1152921519601685712].areaTaskView = val_4[0x0][0].replayConfig.hasAudio;
                val_20 = DG.Tweening.DOTween.Sequence();
                DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Sequence>(t:  val_20, action:  new DG.Tweening.TweenCallback(object:  new AreaView.<>c__DisplayClass17_1(), method:  System.Void AreaView.<>c__DisplayClass17_1::<ReplayAnimations>b__2()));
                float val_22 = val_4[0x0][0].replayConfig.blending;
                val_22 = 1f - val_22;
                val_22 = 0f * val_22;
                val_23 = val_23 + val_22;
                val_22 = val_21 + val_23;
                DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Insert(s:  (AreaView.<>c__DisplayClass17_1)[1152921519601685712].CS$<>8__locals1.areaSeq, atPosition:  val_22, t:  val_20);
                val_24 = val_24 + 1;
                val_22 = (AreaView.<>c__DisplayClass17_1)[1152921519601685712].areaTaskView.GetUiAppearTime();
            }
            while(val_24 < val_4.Length);
            
            }
            else
            {
                    val_22 = 0f;
            }
            
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  (AreaView.<>c__DisplayClass17_0)[1152921519601624272].areaSeq, interval:  val_22);
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  (AreaView.<>c__DisplayClass17_0)[1152921519601624272].areaSeq, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void AreaView.<>c__DisplayClass17_0::<ReplayAnimations>b__0()));
            return (OnReplayKilled)new AreaView.OnReplayKilled(object:  val_1, method:  System.Void AreaView.<>c__DisplayClass17_0::<ReplayAnimations>b__1());
        }
        private void PlayAllFinalParticles()
        {
            if(this.taskViews.Length >= 1)
            {
                    var val_4 = 0;
                do
            {
                this.taskViews[val_4].PlayFinalParticlesOnReplayEnd();
                val_4 = val_4 + 1;
            }
            while(val_4 < this.taskViews.Length);
            
            }
            
            this.areaViewBackgroundSounds.PlayReplaySound(clipName:  System.Linq.Enumerable.Last<Royal.Scenes.Home.Areas.Scripts.AreaTaskView>(source:  this.taskViews).GetParticleSoundName());
            this.ReleaseAllTaskAssetsDelayed();
        }
        private void ReleaseAllTaskAssetsDelayed()
        {
            if(this.taskViews.Length < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                this.taskViews[val_2].ReleaseTaskAssetsDelayed(delay:  3f);
                val_2 = val_2 + 1;
            }
            while(val_2 < this.taskViews.Length);
        
        }
        private void UpdateAreaTask(Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData areaTaskData)
        {
            Royal.Scenes.Home.Areas.Scripts.AreaTaskView val_1 = this.FindView(id:  areaTaskData.taskId);
            if((areaTaskData.taskId & 0) == 0)
            {
                
            }
        
        }
        public void ShowTask(int taskId, System.Action onComplete)
        {
            .<>4__this = this;
            .onComplete = onComplete;
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            val_2.disabler.DisableTouch();
            this.StopTaskIdlesGently();
            .taskView = this.FindView(id:  taskId);
            DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_4, interval:  null);
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_4, callback:  new DG.Tweening.TweenCallback(object:  new AreaView.<>c__DisplayClass21_0(), method:  System.Void AreaView.<>c__DisplayClass21_0::<ShowTask>b__0()));
        }
        private void CompleteTaskAnimation()
        {
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            val_1.disabler.EnableTouch();
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            if(AreAllTasksCompleted() != false)
            {
                    val_2.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Area.ShowAreaDialogAction(isUserAction:  false, disableTouch:  false, isAuto:  true));
            }
            
            val_2.Push(action:  new Royal.Scenes.Home.Ui.PlayHomeUiAnimationAction(appear:  true));
        }
        private void ArrangeSize()
        {
            float val_4;
            float val_5;
            if(this.cameraManager.IsDeviceWide() != false)
            {
                    val_4 = this.cameraManager.cameraWidth;
                val_5 = 12.4f;
            }
            else
            {
                    val_4 = this.cameraManager.cameraHeight;
                val_5 = 20.67143f;
            }
            
            val_4 = val_4 / val_5;
            UnityEngine.Transform val_2 = this.transform;
            val_2.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            val_2.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        public Royal.Scenes.Home.Areas.Scripts.AreaTaskView FindView(int id)
        {
            Royal.Scenes.Home.Areas.Scripts.AreaTaskView val_1;
            if(this.taskViews.Length >= 1)
            {
                    var val_1 = 0;
                do
            {
                val_1 = this.taskViews[val_1];
                if(this.taskViews[0x0][0].id == id)
            {
                    return (Royal.Scenes.Home.Areas.Scripts.AreaTaskView)val_1;
            }
            
                val_1 = val_1 + 1;
            }
            while(val_1 < this.taskViews.Length);
            
            }
            
            val_1 = 0;
            return (Royal.Scenes.Home.Areas.Scripts.AreaTaskView)val_1;
        }
        public void StopTaskIdlesGently()
        {
            if(this.taskViews == null)
            {
                    return;
            }
            
            var val_5 = 4;
            do
            {
                if((0 & 0) != 0)
            {
                    return;
            }
            
                if((val_5 - 4) >= 0)
            {
                    return;
            }
            
                if((this.taskViews[0] & 1) != 0)
            {
                    Royal.Scenes.Home.Areas.Scripts.AreaTaskView val_4 = this.taskViews[0];
            }
            
                val_5 = val_5 + 1;
                var val_2 = (this.taskViews == null) ? this.taskViews : this.taskViews;
            }
            while(this.taskViews != null);
        
        }
        public void ResumeTaskIdlesGently()
        {
            null = null;
            if((Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField) == 0)
            {
                    return;
            }
            
            if(this.taskViews == null)
            {
                    return;
            }
            
            var val_10 = 4;
            do
            {
                if((0 & 0) != 0)
            {
                    return;
            }
            
                if((val_10 - 4) >= 0)
            {
                    return;
            }
            
                Royal.Scenes.Home.Areas.Scripts.AreaTaskView val_7 = this.taskViews[0];
                if((val_7 != 0) && (val_7.gameObject.activeSelf != false))
            {
                    if((this.taskViews[0] & 1) != 0)
            {
                    Royal.Scenes.Home.Areas.Scripts.AreaTaskView val_9 = this.taskViews[0];
            }
            
            }
            
                val_10 = val_10 + 1;
                var val_6 = (this.taskViews == null) ? this.taskViews : this.taskViews;
            }
            while(this.taskViews != null);
        
        }
        public void HideAllTasks()
        {
            var val_2 = 0;
            do
            {
                if(val_2 >= this.taskViews.Length)
            {
                    return;
            }
            
                Royal.Scenes.Home.Areas.Scripts.AreaTaskView val_1 = this.taskViews[val_2];
                val_2 = val_2 + 1;
            }
            while(this.taskViews != null);
            
            throw new NullReferenceException();
        }
        public virtual void ShowCompletedTasks()
        {
            this.backgroundView.ResetView();
            this.UpdateData(areaViewData:  Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<AreaData>k__BackingField);
        }
        public virtual void ShowOnlyBackground()
        {
            this.DetachFromParent();
            this.HideAllTasks();
            this.backgroundView.ShowGame();
            this.backgroundView.UpdateColor();
        }
        public virtual void BringBackgroundFront()
        {
            this.backgroundView.UpdateSorting(sortingLayer:  Royal.Scenes.Game.Mechanics.Sortings.Sorting.DialogLayerId);
        }
        public virtual void SendBackgroundBack()
        {
            this.backgroundView.UpdateSorting(sortingLayer:  Royal.Scenes.Game.Mechanics.Sortings.Sorting.DefaultLayerId);
        }
        private void UpdateData(Royal.Player.Context.Data.Persistent.UserAreaData areaViewData)
        {
            var val_3;
            var val_4;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  10, log:  "Updating task views.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            if(<0)
            {
                    return;
            }
            
            val_4 = (long)(areaViewData.<Tasks>k__BackingField.Length) - 1;
            int val_2 = (areaViewData.<Tasks>k__BackingField.Length) - 2;
            do
            {
                this.UpdateAreaTask(areaTaskData:  new Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData() {taskId = areaViewData.<Tasks>k__BackingField[((long)(int)((areaViewData.<Tasks>k__BackingField.Length - 1))) << 3], isCompleted = areaViewData.<Tasks>k__BackingField[((long)(int)((areaViewData.<Tasks>k__BackingField.Length - 1))) << 3]});
                if((val_2 & 2147483648) != 0)
            {
                    return;
            }
            
                val_4 = val_4 - 1;
                val_2 = val_2 - 1;
            }
            while((areaViewData.<Tasks>k__BackingField) != null);
            
            throw new NullReferenceException();
        }
        public void DetachFromParent()
        {
            this.transform.SetParent(p:  0);
            UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        }
        private void SectionChanged(Royal.Scenes.Home.Ui.Sections.Section section)
        {
            if(section != null)
            {
                    if(section.sectionType != 0)
            {
                    this.StopBackgroundSounds();
                return;
            }
            
                this.PlayBackgroundSounds();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void PlayBackgroundSounds()
        {
            if(this.areaViewBackgroundSounds.CanPlayBackgroundSound() == false)
            {
                    return;
            }
            
            this.playAreaBackgroundSoundsEnumerator = this.StartCoroutine(routine:  this);
            this.areaViewBackgroundSounds.PlayIdleSounds();
        }
        protected virtual System.Collections.IEnumerator PlayAreaSpecificBackgroundSounds()
        {
            return (System.Collections.IEnumerator)new AreaView.<PlayAreaSpecificBackgroundSounds>d__36(<>1__state:  0);
        }
        public void StopBackgroundSounds()
        {
            if(this.playAreaBackgroundSoundsEnumerator != null)
            {
                    this.StopCoroutine(routine:  this.playAreaBackgroundSoundsEnumerator);
                this.playAreaBackgroundSoundsEnumerator = 0;
            }
            
            this.areaViewBackgroundSounds.StopIdleSounds();
        }
        public void LoadAreaTaskAssetsAsync(System.Action onAllCompleted)
        {
            System.Action val_5 = onAllCompleted;
            .onAllCompleted = val_5;
            .remainingAreaTaskAssetCount = this.taskViews.Length;
            if(this.taskViews.Length < 1)
            {
                    return;
            }
            
            var val_6 = 0;
            do
            {
                val_5 = (AreaView.<>c__DisplayClass38_0)[1152921519605863616].<>9__0;
                if(val_5 == null)
            {
                    System.Action<UnityEngine.AsyncOperation> val_3 = null;
                val_5 = val_3;
                val_3 = new System.Action<UnityEngine.AsyncOperation>(object:  new AreaView.<>c__DisplayClass38_0(), method:  System.Void AreaView.<>c__DisplayClass38_0::<LoadAreaTaskAssetsAsync>b__0(UnityEngine.AsyncOperation operation));
                .<>9__0 = val_5;
            }
            
                this.taskViews[val_6].GetAreaTaskAssetResourceRequest().add_completed(value:  val_3);
                val_6 = val_6 + 1;
            }
            while(val_6 < this.taskViews.Length);
        
        }
        public AreaView()
        {
        
        }
    
    }

}
