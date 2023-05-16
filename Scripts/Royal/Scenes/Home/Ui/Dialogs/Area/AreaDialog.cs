using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Area
{
    public class AreaDialog : UiDialog
    {
        // Fields
        public Royal.Infrastructure.UiComponents.Scroll.Content.UiExpandableScrollContent content;
        public Royal.Scenes.Home.Ui.Dialogs.Area.AreaProgressBar progressBar;
        public Royal.Infrastructure.UiComponents.Scroll.UiScroll uiScroll;
        public Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialogTitle title;
        public UnityEngine.GameObject episodeCompleteContainer;
        public UnityEngine.SpriteMask defaultSpriteMask;
        public UnityEngine.SpriteMask claimSpriteMask;
        public UnityEngine.SpriteRenderer chestImage;
        public UnityEngine.GameObject closeButton;
        private Royal.Scenes.Home.Context.Units.Area.Config.AreaConfig areaConfig;
        private int totalTasks;
        private int nonCompletedItemCount;
        private int tasksCompleted;
        private bool episodeChestClaimed;
        private bool willClaimChest;
        private bool buildStarted;
        private bool shouldShowTutorial;
        private Royal.Scenes.Home.Ui.Dialogs.EpisodeChest.EpisodeChestPanel chestPanel;
        private bool <LastCompletedTaskAnimationStarted>k__BackingField;
        
        // Properties
        public bool LastCompletedTaskAnimationStarted { get; set; }
        public bool BuildStarted { get; set; }
        
        // Methods
        public bool get_LastCompletedTaskAnimationStarted()
        {
            return (bool)this.<LastCompletedTaskAnimationStarted>k__BackingField;
        }
        private void set_LastCompletedTaskAnimationStarted(bool value)
        {
            this.<LastCompletedTaskAnimationStarted>k__BackingField = value;
        }
        public bool get_BuildStarted()
        {
            return (bool)this.buildStarted;
        }
        public void set_BuildStarted(bool value)
        {
            this.buildStarted = value;
            if(value == false)
            {
                    return;
            }
            
            this.uiScroll = 0;
            if(this.shouldShowTutorial == false)
            {
                    return;
            }
            
            Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Tutorial.HomeTutorialManager>(id:  3).DestroyArrow();
        }
        public void Init(int areaId)
        {
            int val_13;
            int val_14;
            bool val_15;
            val_13 = areaId;
            this.areaConfig = val_1.configContainer.LoadAreaConfig(id:  val_13);
            this.TryOpenClaimUi();
            int val_3 = this.GetLastCompletedTaskId();
            val_14 = val_13;
            this.title.SetText(areaName:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  this.areaConfig.areaName), areaId:  val_14);
            this.tasksCompleted = 0;
            this.totalTasks = this.areaConfig.tasks.Length;
            if(this.areaConfig.areaId == 1)
            {
                    val_14 = 0;
                Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData val_5 = GetTaskData(taskId:  1);
                var val_7 = (((val_5.taskId >> 32) & 255) != 0) ? 1 : 0;
            }
            else
            {
                    val_15 = false;
            }
            
            this.shouldShowTutorial = val_15;
            System.Collections.Generic.List<Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialogTaskRowData> val_8 = new System.Collections.Generic.List<Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialogTaskRowData>();
            int val_17 = this.totalTasks;
            if(val_17 < 1)
            {
                goto label_14;
            }
            
            var val_16 = 0;
            label_33:
            Royal.Scenes.Home.Context.Units.Area.Config.AreaTaskConfig val_13 = this.areaConfig.tasks[val_16];
            Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData val_9 = GetTaskData(taskId:  this.areaConfig.tasks[0x0][0].id);
            val_14 = 0;
            if(this.shouldShowTutorial != false)
            {
                    val_13 = 1;
            }
            else
            {
                    bool val_11 = (this.areaConfig.tasks[0x0][0].dependency == val_3) ? 1 : 0;
            }
            
            .config = val_13;
            .taskData = val_9;
            .isHidden = val_11;
            .areaDialog = this;
            .lastCompletedTaskId = val_3;
            if((PreRequisitesPass(config:  val_13)) == false)
            {
                goto label_26;
            }
            
            if((val_9.taskId & 0) != 0)
            {
                goto label_23;
            }
            
            if(val_3 == val_9.taskId)
            {
                goto label_25;
            }
            
            int val_14 = this.tasksCompleted;
            val_14 = val_14 + 1;
            this.tasksCompleted = val_14;
            goto label_26;
            label_23:
            label_25:
            if(val_11 != 0)
            {
                    val_14 = public System.Void System.Collections.Generic.List<Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialogTaskRowData>::Add(Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialogTaskRowData item);
                val_8.Add(item:  new Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialogTaskRowData());
            }
            
            int val_15 = this.nonCompletedItemCount;
            val_15 = val_15 + 1;
            this.nonCompletedItemCount = val_15;
            label_26:
            val_16 = val_16 + 1;
            if(val_16 < this.totalTasks)
            {
                goto label_33;
            }
            
            if(val_8 != null)
            {
                goto label_34;
            }
            
            label_14:
            label_34:
            if(val_17 >= 1)
            {
                    var val_18 = 0;
                if(val_18 >= val_17)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_17 = val_17 + 0;
                val_18 = val_18 + 1;
            }
            
            this.PrepareProgressBar();
            if(val_3 >= 1)
            {
                    Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0).SetLastCompletedTaskId(taskId:  0);
                this.AnimateLastCompletedTask(index:  0);
                return;
            }
            
            this.TryPrepareTutorial();
            this.Invoke(methodName:  "StartClaimAnimation", time:  0.5f);
        }
        public override void Close()
        {
            if(this.buildStarted != false)
            {
                    return;
            }
            
            if(this.shouldShowTutorial != false)
            {
                    Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Tutorial.HomeTutorialManager>(id:  3).DestroyArrow();
            }
            
            this.Close();
        }
        public override void OnShow(UnityEngine.Vector3 position)
        {
            if(this.willClaimChest != true)
            {
                    Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialog.ShowStarInfoPanel(show:  true);
            }
            
            this.OnShow(position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
        }
        public override void OnClose(System.Action dialogClosed)
        {
            if(this.willClaimChest != true)
            {
                    Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialog.ShowStarInfoPanel(show:  false);
            }
            
            if((this.<LastCompletedTaskAnimationStarted>k__BackingField) != false)
            {
                    dialogClosed.Invoke();
                this.gameObject.SetActive(value:  false);
                this.Invoke(methodName:  "DestroyLater", time:  1f);
                return;
            }
            
            this.OnClose(dialogClosed:  dialogClosed);
        }
        private void DestroyLater()
        {
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        private static void ShowStarInfoPanel(bool show)
        {
            var val_1;
            var val_2;
            var val_3;
            int val_4;
            var val_5;
            val_1 = null;
            val_1 = null;
            val_2 = null;
            if(show != false)
            {
                    val_3 = null;
                val_4 = 1152921505085657112;
            }
            
            val_5 = null;
            val_4 = 1152921505085657108;
            Royal.Scenes.Home.Ui.__il2cppRuntimeField_40.ChangeSortingLayer(sortingLayer:  val_4);
        }
        private void AnimateLastCompletedTask(int index)
        {
            this.uiScroll = 0;
            this.<LastCompletedTaskAnimationStarted>k__BackingField = true;
            if(null == null)
            {
                    this.content.GetItemFromIndex(index:  index).AnimateLastBuild(toIndex:  this.nonCompletedItemCount - 1, onComplete:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialog::<AnimateLastCompletedTask>b__31_0()));
                return;
            }
        
        }
        private void PrepareProgressBar()
        {
            if(this.tasksCompleted != 0)
            {
                    float val_1 = (float)this.tasksCompleted / (float)this.totalTasks;
                this.progressBar.UpdateBarSize(ratio:  val_1);
                this.progressBar.UpdateBarText(ratio:  val_1);
                return;
            }
            
            this.progressBar.DisableBarSprites();
        }
        private void StartClaimAnimation()
        {
            if(this.willClaimChest == false)
            {
                    return;
            }
            
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.2f);
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialog::ShowChestPanel()));
        }
        private void LoadChestPanel()
        {
            Royal.Scenes.Home.Ui.Dialogs.EpisodeChest.EpisodeChestPanel val_2 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.EpisodeChest.EpisodeChestPanel>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.EpisodeChest.EpisodeChestPanel>(path:  "EpisodeChestPanel"));
            this.chestPanel = val_2;
            val_2.Init();
            this.chestPanel.gameObject.SetActive(value:  false);
        }
        private void ShowChestPanel()
        {
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetDialogBackgroundSorting();
            val_2.sortEverything = val_2.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything}, offset:  0);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.GetComponent<UnityEngine.Rendering.SortingGroup>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything & 4294967295});
            this.chestImage.enabled = false;
            this.chestPanel.ShowChestAppear(onComplete:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialog::OnEpisodeChestClaimCompleted()));
            this.gameObject.SetActive(value:  false);
        }
        private void OnEpisodeChestClaimCompleted()
        {
            this.episodeChestClaimed = true;
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            val_1.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.EpisodeComplete.ShowEpisodeCompleteDialogAction());
            val_1.Push(action:  new Royal.Scenes.Start.Context.Units.Flow.IntervalAction(duration:  2.5f, disableUiTouch:  true, flowType:  1));
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialog).__il2cppRuntimeField_250;
        }
        private void TryOpenClaimUi()
        {
            if(AreAllTasksCompleted() == false)
            {
                    return;
            }
            
            this.willClaimChest = true;
            this.closeButton.SetActive(value:  false);
            this.episodeCompleteContainer.SetActive(value:  true);
            this.defaultSpriteMask.gameObject.SetActive(value:  false);
            this.claimSpriteMask.gameObject.SetActive(value:  true);
            this.content = -1080872141;
            this.LoadChestPanel();
        }
        private void TryPrepareTutorial()
        {
            DG.Tweening.TweenCallback val_8;
            var val_9;
            DG.Tweening.TweenCallback val_11;
            if(this.shouldShowTutorial == false)
            {
                    return;
            }
            
            this.closeButton.SetActive(value:  false);
            this.uiScroll = 0;
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.25f);
            DG.Tweening.TweenCallback val_3 = null;
            val_8 = val_3;
            val_3 = new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialog::<TryPrepareTutorial>b__38_0());
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  val_3);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.25f);
            val_9 = null;
            val_9 = null;
            val_11 = AreaDialog.<>c.<>9__38_1;
            if(val_11 == null)
            {
                    DG.Tweening.TweenCallback val_6 = null;
                val_11 = val_6;
                val_6 = new DG.Tweening.TweenCallback(object:  AreaDialog.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AreaDialog.<>c::<TryPrepareTutorial>b__38_1());
                AreaDialog.<>c.<>9__38_1 = val_11;
            }
            
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  val_6);
        }
        public void IncrementProgress()
        {
            int val_3 = this.tasksCompleted;
            if(val_3 == 0)
            {
                    this.progressBar.EnableBarSprites();
                val_3 = this.tasksCompleted;
            }
            
            int val_1 = val_3 + 1;
            this.tasksCompleted = val_1;
            float val_3 = (float)val_1;
            float val_4 = (float)this.totalTasks;
            val_3 = val_3 / val_4;
            val_4 = (float)val_3 / val_4;
            this.progressBar.PlayProgressBarAnimation(oldPercentage:  val_4, newPercentage:  val_3, onComplete:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialog::StartClaimAnimation()));
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            float val_3;
            bool val_4;
            var val_5;
            var val_6;
            var val_7;
            float val_8;
            bool val_12;
            bool val_13;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_12 = val_5;
            val_13 = val_6;
            val_0.shouldHideBackground = val_4;
            val_0.shouldCloseOnTouch = (this.shouldShowTutorial == true) ? (val_13) : (0 + 1);
            val_0.shouldCloseOnEscape = (this.shouldShowTutorial == true) ? (val_12) : (0 + 1);
            val_0.backgroundFadeInDelay = val_3;
            val_0.shouldCloseOnSwipe = val_3;
            val_0.backgroundFadeOutDuration = (this.episodeChestClaimed == false) ? (val_7) : 0.3f;
            val_0.backgroundFadeOutDelay = val_8;
            return val_0;
        }
        public AreaDialog()
        {
        
        }
        private void <AnimateLastCompletedTask>b__31_0()
        {
            if(this.uiScroll != null)
            {
                    this.uiScroll = 1;
                this.<LastCompletedTaskAnimationStarted>k__BackingField = false;
                return;
            }
            
            throw new NullReferenceException();
        }
        private void <TryPrepareTutorial>b__38_0()
        {
            if(this.content != null)
            {
                    this.content.ShowHiddenItem(index:  0, duration:  0.2f);
                return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
