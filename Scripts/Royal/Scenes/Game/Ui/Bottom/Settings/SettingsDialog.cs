using UnityEngine;

namespace Royal.Scenes.Game.Ui.Bottom.Settings
{
    public class SettingsDialog : UiDialog
    {
        // Fields
        private const float Interval = 0.07;
        private const float OutInterval = 0.025;
        public Royal.Scenes.Game.Ui.Bottom.Settings.UiSettingsButton settingsButton;
        public Royal.Scenes.Game.Ui.Bottom.Settings.UiSettingsMenuButton exitButton;
        public Royal.Scenes.Game.Ui.Bottom.Settings.UiSettingsMenuButton soundButton;
        public Royal.Scenes.Game.Ui.Bottom.Settings.UiSettingsMenuButton musicButton;
        private Royal.Scenes.Start.Context.Units.Flow.FlowManager flowManager;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager gameState;
        private bool isQuitting;
        private DG.Tweening.Sequence inSequence;
        private DG.Tweening.Sequence outSequence;
        private Royal.Scenes.Game.Levels.Units.LevelTutorials.LevelTutorialManager tutorialManager;
        
        // Methods
        private void Start()
        {
            this.gameState = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.flowManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            this.tutorialManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelTutorials.LevelTutorialManager>(contextId:  21);
            this.GetComponent<UnityEngine.BoxCollider2D>().enabled = false;
        }
        public void SetAction(Royal.Scenes.Start.Context.Units.Flow.DialogAction action)
        {
            mem[1152921519944575456] = action;
        }
        public override void OnShow(UnityEngine.Vector3 position)
        {
            var val_7;
            this.GetComponent<UnityEngine.BoxCollider2D>().enabled = true;
            this.settingsButton.RotateIn();
            val_7 = null;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetDialogSorting();
            this.settingsButton.SetSorting(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything & 4294967295});
            mem[1152921519944741720] = 10;
            DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
            this.inSequence = val_4;
            this.musicButton.Show(interval:  0f, seq:  val_4);
            this.soundButton.Show(interval:  0.07f, seq:  this.inSequence);
            this.exitButton.Show(interval:  0.14f, seq:  this.inSequence);
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  this.inSequence, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Bottom.Settings.SettingsDialog::<OnShow>b__14_0()));
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            float val_3;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            bool val_4 = (this.outSequence == 0) ? 1 : 0;
            bool val_6 = ~this.ShouldContinueShowingBackground();
            val_6 = val_6 & 1;
            val_0.shouldCloseOnEscape = val_4;
            val_0.shouldCloseOnTouch = val_4;
            val_0.shouldSkipFastOnTouch = val_2;
            val_0.shouldCloseOnSwipe = true;
            val_0.shouldHideBackground = val_6;
            val_0.backgroundFadeInDuration = 0.45f;
            val_0.backgroundFadeOutDuration = 0.3f;
            val_0.backgroundFadeOutDelay = val_3;
            return val_0;
        }
        private bool ShouldContinueShowingBackground()
        {
            if(this.isQuitting != false)
            {
                    return true;
            }
            
            if(this.gameState != null)
            {
                    return this.gameState.IsWin();
            }
            
            throw new NullReferenceException();
        }
        public override void OnClose(System.Action dialogClosed)
        {
            SettingsDialog.<>c__DisplayClass17_0 val_1 = new SettingsDialog.<>c__DisplayClass17_0();
            .<>4__this = this;
            .dialogClosed = dialogClosed;
            if(this.outSequence != null)
            {
                    return;
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16).PlaySound(type:  40, offset:  0.04f);
            if(this.inSequence != null)
            {
                    DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  this.inSequence, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void SettingsDialog.<>c__DisplayClass17_0::<OnClose>b__0()));
                DG.Tweening.TweenExtensions.Kill(t:  this.inSequence, complete:  true);
                return;
            }
            
            this.settingsButton.RotateOut();
            mem[1152921519945235224] = 1;
            DG.Tweening.Sequence val_5 = DG.Tweening.DOTween.Sequence();
            this.outSequence = val_5;
            this.musicButton.Hide(interval:  0.05f, seq:  val_5);
            this.soundButton.Hide(interval:  0.025f, seq:  this.outSequence);
            this.exitButton.Hide(interval:  0f, seq:  this.outSequence);
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  this.outSequence, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void SettingsDialog.<>c__DisplayClass17_0::<OnClose>b__1()));
        }
        public void Open()
        {
            if(this.gameState.IsPlaying() == false)
            {
                    return;
            }
            
            if(this.tutorialManager.IsRunningTutorial() != false)
            {
                    return;
            }
            
            .settingsDialog = this;
            this.flowManager.Push(action:  new Royal.Scenes.Game.Ui.Bottom.Settings.ShowSettingDialogAction());
        }
        public void TriggerQuit()
        {
            this.isQuitting = true;
            this.flowManager.Push(action:  new Royal.Scenes.Game.Ui.Dialogs.LevelQuit.ShowLevelQuitDialogAction());
            goto typeof(Royal.Scenes.Game.Ui.Bottom.Settings.SettingsDialog).__il2cppRuntimeField_250;
        }
        public override void PressEscape()
        {
            this.TriggerQuit();
        }
        public SettingsDialog()
        {
        
        }
        private void <OnShow>b__14_0()
        {
            this.inSequence = 0;
        }
    
    }

}
