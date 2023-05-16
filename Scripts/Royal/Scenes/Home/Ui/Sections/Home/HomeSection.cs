using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home
{
    public class HomeSection : Section
    {
        // Fields
        public Royal.Scenes.Home.Ui.Sections.Home.Pinch.AreaPinch areaPinch;
        public UnityEngine.Transform areaPivot;
        public UnityEngine.Transform actions;
        public UnityEngine.GameObject storyLevelTitle;
        public TMPro.TextMeshPro levelButtonTitle;
        public TMPro.TextMeshPro levelButtonDifficulty;
        public TMPro.TextMeshPro tasksButtonCount;
        public Royal.Infrastructure.UiComponents.Button.UiButton levelButton;
        public UnityEngine.Transform tasksButtonNotification;
        public UnityEngine.Transform tasksButtonTransform;
        public Royal.Scenes.Home.Ui.Sections.Home.Buttons.LeagueInfoButton leagueButton;
        public Royal.Scenes.Home.Ui.Sections.Home.Icons.IconsView iconsView;
        public UnityEngine.Sprite[] levelButtonFrameSprites;
        public UnityEngine.Sprite[] levelButtonBackgroundSprites;
        public UnityEngine.SpriteRenderer levelButtonFrameLeft;
        public UnityEngine.SpriteRenderer levelButtonFrameRight;
        public UnityEngine.SpriteRenderer levelButtonBackgroundLeft;
        public UnityEngine.SpriteRenderer levelButtonBackgroundRight;
        private Royal.Scenes.Home.Context.Units.Area.AreaManager areaManager;
        private Royal.Scenes.Start.Context.Units.Flow.FlowManager flowManager;
        private UnityEngine.Vector3 initialTasksButtonScale;
        private DG.Tweening.Sequence taskButtonAnimationSequence;
        private UnityEngine.Object tasksButtonParticles;
        private byte secondsCounter;
        private System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Home.Buttons.ICounter> counters;
        private static readonly UnityEngine.Vector2 LevelTextHardPosition;
        private static readonly UnityEngine.Vector2 LevelTextDefaultPosition;
        
        // Methods
        private void Awake()
        {
            this.secondsCounter = 0;
            this.counters = new System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Home.Buttons.ICounter>(capacity:  10);
            add_OnStarUpdated(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.HomeSection::ShowTaskOrLeagueButton()));
            this.flowManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            UnityEngine.Vector3 val_4 = this.tasksButtonTransform.localScale;
            this.initialTasksButtonScale = val_4;
            mem[1152921519077527220] = val_4.y;
            mem[1152921519077527224] = val_4.z;
            this.AddCounter(counter:  null, toBeginning:  false);
        }
        private void Start()
        {
            this.PrepareArea();
            this.PrepareButtons();
        }
        private void FixedUpdate()
        {
            var val_3;
            var val_4;
            byte val_2 = this.secondsCounter;
            val_2 = val_2 + 1;
            this.secondsCounter = val_2;
            if((val_2 & 255) < 50)
            {
                    return;
            }
            
            this.secondsCounter = 0;
            val_3 = 0;
            label_10:
            if(val_3 >= val_2)
            {
                    return;
            }
            
            if(val_2 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 0;
            var val_5 = ((this.secondsCounter + 1) + 0) + 32;
            if((((this.secondsCounter + 1) + 0) + 32 + 294) == 0)
            {
                goto label_9;
            }
            
            var val_3 = ((this.secondsCounter + 1) + 0) + 32 + 176;
            var val_4 = 0;
            val_3 = val_3 + 8;
            label_8:
            if(((((this.secondsCounter + 1) + 0) + 32 + 176 + 8) + -8) == null)
            {
                goto label_7;
            }
            
            val_4 = val_4 + 1;
            val_3 = val_3 + 16;
            if(val_4 < (((this.secondsCounter + 1) + 0) + 32 + 294))
            {
                goto label_8;
            }
            
            goto label_9;
            label_7:
            val_5 = val_5 + (((((this.secondsCounter + 1) + 0) + 32 + 176 + 8)) << 4);
            val_4 = val_5 + 304;
            label_9:
            ((this.secondsCounter + 1) + 0) + 32.UpdateSeconds();
            val_3 = val_3 + 1;
            if(this.counters != null)
            {
                goto label_10;
            }
            
            throw new NullReferenceException();
        }
        public override void OnActivate()
        {
            this.OnActivate();
            this.flowManager.PushDelayedAutoActions(executeAfter:  0.5f);
        }
        public void ShowAreaDialog()
        {
            var val_7;
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_8;
            Royal.Scenes.Start.Context.Units.Flow.FlowAction val_9;
            val_7 = this;
            this.StopTasksButtonAnimation();
            if(IsUsingRealArea() == false)
            {
                goto label_4;
            }
            
            if((AreAllTasksCompleted() == false) || (ChestClaimed() == false))
            {
                goto label_8;
            }
            
            val_8 = this.flowManager;
            Royal.Scenes.Home.Ui.Dialogs.AreaUnlocked.ShowAreaUnlockedDialogAction val_4 = null;
            val_9 = val_4;
            val_4 = new Royal.Scenes.Home.Ui.Dialogs.AreaUnlocked.ShowAreaUnlockedDialogAction(isButtonClicked:  true);
            if(val_8 != null)
            {
                goto label_11;
            }
            
            throw new NullReferenceException();
            label_4:
            Royal.Scenes.Home.Ui.Dialogs.AreaDownloadFail.AreaDownloadFailAction val_5 = null;
            val_9 = val_5;
            val_5 = new Royal.Scenes.Home.Ui.Dialogs.AreaDownloadFail.AreaDownloadFailAction(isAtAreaUnlock:  false, isAtAreaLoad:  true);
            label_11:
            val_8.Push(action:  val_5);
            return;
            label_8:
            Royal.Scenes.Home.Ui.Dialogs.Area.ShowAreaDialogAction val_6 = new Royal.Scenes.Home.Ui.Dialogs.Area.ShowAreaDialogAction(isUserAction:  true, disableTouch:  false, isAuto:  false);
            if(this.flowManager != null)
            {
                goto label_11;
            }
        
        }
        public void ShowPrelevelDialog()
        {
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Prelevel.ShowPrelevelDialogAction(clearBoosterSelectionData:  true));
        }
        private void PrepareArea()
        {
            this.areaManager = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0);
            this.PrepareAreaTransform();
            this.areaManager.add_OnTaskUpdate(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.HomeSection::ShowTaskOrLeagueButton()));
            this.areaManager.add_OnAreaUpdate(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.HomeSection::PrepareAreaTransform()));
        }
        private void PrepareAreaTransform()
        {
            UnityEngine.Transform val_1 = this.areaManager.<AreaView>k__BackingField.transform;
            val_1.SetParent(p:  this.areaPivot);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            val_1.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            this.areaPinch = val_1;
        }
        private void PrepareButtons()
        {
            UnityEngine.Vector3 val_1 = this.GetActionButtonsPosition();
            this.actions.position = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            this.PrepareLevelButton();
            this.ShowTaskOrLeagueButton();
            this.ArrangeTasksButtonAnimation();
        }
        public UnityEngine.Vector3 GetActionButtonsPosition()
        {
            UnityEngine.Vector3 val_1 = this.actions.position;
            UnityEngine.Vector3 val_3 = this.actions.transform.position;
            float val_4 = 2.2f;
            val_4 = val_3.y + val_4;
            float val_5 = -1f;
            val_5 = val_4 + val_5;
            return new UnityEngine.Vector3() {x = val_1.x, y = val_5, z = val_1.z};
        }
        public void PrepareLevelButton()
        {
            var val_17;
            var val_18;
            UnityEngine.Sprite[] val_20;
            var val_21;
            this.levelButtonTitle.fontSizeMax = 36f;
            this.levelButtonTitle.enabled = true;
            val_17 = null;
            val_17 = null;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = Royal.Scenes.Home.Ui.Sections.Home.HomeSection.LevelTextDefaultPosition, y = Royal.Scenes.Home.Ui.Sections.Home.HomeSection.LevelTextHardPosition.__il2cppRuntimeField_C});
            this.levelButtonTitle.transform.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            this.levelButtonDifficulty.enabled = false;
            this.storyLevelTitle.gameObject.SetActive(value:  false);
            this.levelButtonFrameLeft.sprite = this.levelButtonFrameSprites[0];
            this.levelButtonFrameRight.sprite = this.levelButtonFrameSprites[0];
            this.levelButtonBackgroundLeft.sprite = this.levelButtonBackgroundSprites[0];
            this.levelButtonBackgroundRight.sprite = this.levelButtonBackgroundSprites[0];
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.IsInLeague()) != false)
            {
                    this.levelButtonTitle.text = Royal.Infrastructure.Services.Localization.LocalizationHelper.AddTextToEnd(value:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Round"), level:  125198928);
                return;
            }
            
            if(IsStory != false)
            {
                    this.levelButtonTitle.enabled = false;
                this.storyLevelTitle.gameObject.SetActive(value:  true);
                return;
            }
            
            this.levelButtonTitle.text = Royal.Infrastructure.Services.Localization.LocalizationHelper.AddTextToEnd(value:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Level"), level:  typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14>>0&0xFFFFFFFF);
            this.levelButtonTitle.fontSizeMax = 34f;
            this.levelButtonDifficulty.enabled = true;
            this.levelButtonDifficulty.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Hard Level");
            val_18 = null;
            val_18 = null;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = Royal.Scenes.Home.Ui.Sections.Home.HomeSection.LevelTextHardPosition, y = Royal.Scenes.Home.Ui.Sections.Home.HomeSection.LevelTextHardPosition.__il2cppRuntimeField_4});
            this.levelButtonTitle.transform.localPosition = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
            this.levelButtonFrameLeft.sprite = this.levelButtonFrameSprites[1];
            val_20 = this.levelButtonFrameSprites;
            if(this.levelButtonFrameRight == null)
            {
                    this.levelButtonTitle.fontSizeMax = 34f;
                this.levelButtonDifficulty.enabled = true;
                this.levelButtonDifficulty.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Super Hard");
                val_21 = null;
                val_21 = null;
                UnityEngine.Vector3 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = Royal.Scenes.Home.Ui.Sections.Home.HomeSection.LevelTextHardPosition, y = Royal.Scenes.Home.Ui.Sections.Home.HomeSection.LevelTextHardPosition.__il2cppRuntimeField_4});
                this.levelButtonTitle.transform.localPosition = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
                this.levelButtonFrameLeft.sprite = this.levelButtonFrameSprites[2];
                this.levelButtonFrameRight.sprite = this.levelButtonFrameSprites[2];
                this.levelButtonBackgroundLeft.sprite = this.levelButtonBackgroundSprites[1];
                val_20 = this.levelButtonBackgroundSprites;
            }
            
            this.levelButtonBackgroundRight.sprite = val_20[1];
        }
        private void ShowTaskOrLeagueButton()
        {
            var val_2;
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.IsInLeague()) != false)
            {
                    this.leagueButton.Activate(enable:  true);
                val_2 = 0;
            }
            else
            {
                    this.leagueButton.Activate(enable:  false);
                val_2 = 1;
            }
            
            this.ActivateTaskButton(activate:  true);
        }
        private void ActivateTaskButton(bool activate)
        {
            UnityEngine.GameObject val_1 = this.tasksButtonTransform.gameObject;
            if(activate != false)
            {
                    val_1.SetActive(value:  true);
                int val_3 = GetAvailableTaskCount(config:  this.areaManager.LoadConfig(id:  129259600), stars:  typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_14>>0&0xFFFFFFFF);
                if(val_3 >= 1)
            {
                    this.tasksButtonNotification.gameObject.SetActive(value:  true);
                this = this.tasksButtonCount;
                this.text = val_3.ToString();
                return;
            }
            
            }
            
            val_1.SetActive(value:  false);
        }
        public void ArrangeTasksButtonAnimation()
        {
            var val_26;
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.IsInLeague()) == true)
            {
                    return;
            }
            
            bool val_2 = AreAllTasksCompleted();
            if(val_2 ^ 1 != true)
            {
                    this.tasksButtonNotification.gameObject.SetActive(value:  true);
                this.tasksButtonCount.text = "!";
            }
            
            if(this.taskButtonAnimationSequence != null)
            {
                    val_26 = DG.Tweening.TweenExtensions.IsPlaying(t:  this.taskButtonAnimationSequence);
            }
            else
            {
                    val_26 = 0;
            }
            
            if((val_26 & val_2) == 0)
            {
                    return;
            }
            
            if(val_2 != false)
            {
                    if(ChestClaimed() != false)
            {
                    if(((Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeagueManager>(id:  5).IsThereActiveLeague()) == false) || ((val_6.<IsActiveLeagueUpdatedOnline>k__BackingField) == false))
            {
                goto label_24;
            }
            
            }
            
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  0.95f);
                this.tasksButtonTransform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
                DG.Tweening.Sequence val_11 = DG.Tweening.DOTween.Sequence();
                this.taskButtonAnimationSequence = val_11;
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.one;
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  1.05f);
                DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_11, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tasksButtonTransform, endValue:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, duration:  0.6f), ease:  2));
                UnityEngine.Vector3 val_17 = UnityEngine.Vector3.one;
                UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, d:  0.95f);
                DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  this.taskButtonAnimationSequence, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tasksButtonTransform, endValue:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, duration:  0.6f)), ease:  3);
                DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Sequence>(t:  this.taskButtonAnimationSequence, loops:  0);
                this.tasksButtonParticles = UnityEngine.Object.Instantiate(original:  UnityEngine.Resources.Load(path:  "TasksButtonParticles"), parent:  this.tasksButtonTransform);
                return;
            }
            
            label_24:
            this.StopTasksButtonAnimation();
        }
        private void StopTasksButtonAnimation()
        {
            if(this.tasksButtonParticles != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.tasksButtonParticles);
            }
            
            if(this.taskButtonAnimationSequence != null)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.taskButtonAnimationSequence, complete:  false);
                this.taskButtonAnimationSequence = 0;
                this.tasksButtonNotification.gameObject.SetActive(value:  false);
            }
            
            this.tasksButtonTransform.localScale = new UnityEngine.Vector3() {x = this.initialTasksButtonScale};
        }
        public void AddCounter(Royal.Scenes.Home.Ui.Sections.Home.Buttons.ICounter counter, bool toBeginning = False)
        {
            if(toBeginning != false)
            {
                    this.counters.Insert(index:  0, item:  counter);
                return;
            }
            
            this.counters.Add(item:  counter);
        }
        public void RemoveCounter(Royal.Scenes.Home.Ui.Sections.Home.Buttons.ICounter counter)
        {
            bool val_1 = this.counters.Remove(item:  counter);
        }
        private void OnDestroy()
        {
            remove_OnStarUpdated(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.HomeSection::ShowTaskOrLeagueButton()));
        }
        public HomeSection()
        {
        
        }
        private static HomeSection()
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  -0.0079f, y:  0.25f);
            UnityEngine.Vector2 val_2;
            Royal.Scenes.Home.Ui.Sections.Home.HomeSection.LevelTextHardPosition = val_1.x;
            val_2 = new UnityEngine.Vector2(x:  -0.0079f, y:  0.0113f);
            Royal.Scenes.Home.Ui.Sections.Home.HomeSection.LevelTextDefaultPosition = val_2.x;
        }
    
    }

}
