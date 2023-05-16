using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.LevelWin
{
    public class LevelWinDialog : AbstractLevelDialog
    {
        // Fields
        public UnityEngine.SpriteRenderer starImage;
        public UnityEngine.Transform winPanel;
        public UnityEngine.GameObject pillowAnimation;
        public Royal.Infrastructure.Utils.Text.CurvedTextAnimator curvedTextAnimator;
        public Royal.Scenes.Game.Ui.Dialogs.LevelWin.LevelEndBottomPanel levelEndBottomPanel;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private bool objectDestroyed;
        private DG.Tweening.Sequence showStarSequence;
        private bool continueClicked;
        
        // Methods
        private void Awake()
        {
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.PrepareTitle(levelData:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_namespaze);
        }
        public void OnContinueButton()
        {
            if(this.continueClicked != false)
            {
                    return;
            }
            
            this.continueClicked = true;
            Royal.Scenes.Game.Context.GameContext.Get<Royal.Scenes.Game.Context.Units.GameManager>(id:  1).ExitGameWhenPossible();
        }
        public override void OnShow(UnityEngine.Vector3 position)
        {
            if(IsLeague != false)
            {
                    this.ShowBottomPanel(show:  true);
                this.ShowCrownImage();
                return;
            }
            
            this.ShowBottomPanel(show:  (Royal.Player.Context.Data.Session.__il2cppRuntimeField_14 > 31) ? 1 : 0);
            this.ShowStarImage();
        }
        private void ShowBottomPanel(bool show)
        {
            if(show != false)
            {
                    this.levelEndBottomPanel.Prepare(topPanel:  this.winPanel);
                this.levelEndBottomPanel.Show(delay:  0.45f);
                return;
            }
            
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.transform.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            this.levelEndBottomPanel.gameObject.SetActive(value:  false);
        }
        private void ShowStarImage()
        {
            UnityEngine.Transform val_1 = this.starImage.transform;
            UnityEngine.Vector3 val_2 = val_1.localPosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  1.66f);
            val_1.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_1.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  120f);
            val_1.localRotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
            DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
            this.showStarSequence = val_6;
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.starImage.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.25f, snapping:  false));
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  1f);
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.showStarSequence, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.starImage.transform, endValue:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, duration:  0.25f));
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.showStarSequence, t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  this.starImage.transform, endValue:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, duration:  0.25f, mode:  0));
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  this.showStarSequence, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Dialogs.LevelWin.LevelWinDialog::<ShowStarImage>b__13_0()));
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  this.showStarSequence, atPosition:  0.1f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Dialogs.LevelWin.LevelWinDialog::<ShowStarImage>b__13_1()));
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  this.showStarSequence, atPosition:  0.2f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Dialogs.LevelWin.LevelWinDialog::<ShowStarImage>b__13_2()));
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  0.7f);
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.showStarSequence, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.starImage.transform, endValue:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, duration:  0.0155f));
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  1.15f);
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.showStarSequence, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.starImage.transform, endValue:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, duration:  0.1f));
            UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  1f);
            DG.Tweening.Sequence val_35 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.showStarSequence, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.starImage.transform, endValue:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z}, duration:  0.17f));
            DG.Tweening.Sequence val_37 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  this.showStarSequence, action:  new DG.Tweening.TweenCallback(object:  this, method:  typeof(Royal.Scenes.Game.Ui.Dialogs.LevelWin.LevelWinDialog).__il2cppRuntimeField_288));
        }
        private void ShowCrownImage()
        {
            this.audioManager.PlaySound(type:  8, offset:  0.04f);
            this.pillowAnimation.GetComponent<UnityEngine.Animator>().Play(stateName:  "LevelWinCrownAnimation", layer:  0, normalizedTime:  0f);
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            this.showStarSequence = val_2;
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_2, atPosition:  0.3f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Dialogs.LevelWin.LevelWinDialog::<ShowCrownImage>b__14_0()));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  this.showStarSequence, action:  new DG.Tweening.TweenCallback(object:  this, method:  typeof(Royal.Scenes.Game.Ui.Dialogs.LevelWin.LevelWinDialog).__il2cppRuntimeField_288));
        }
        protected override void AfterShowAnimation()
        {
            if(this.objectDestroyed != false)
            {
                    return;
            }
            
            if(this.audioManager != null)
            {
                    this.audioManager.PlaySoundInLoop(type:  7);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void OnDestroy()
        {
            this.objectDestroyed = true;
            DG.Tweening.TweenExtensions.Kill(t:  this.showStarSequence, complete:  false);
            this.audioManager.StopSoundInLoop(type:  7);
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            float val_3;
            bool val_4;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldCloseOnEscape = true;
            val_0.shouldHideBackground = val_2;
            val_0.backgroundFadeInDuration = val_3;
            val_0.shouldCloseOnTouch = val_4;
            return val_0;
        }
        public override void CloseOnEscape()
        {
            this.OnContinueButton();
        }
        public LevelWinDialog()
        {
        
        }
        private void <ShowStarImage>b__13_0()
        {
            if(this.audioManager != null)
            {
                    this.audioManager.PlaySound(type:  8, offset:  0.04f);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void <ShowStarImage>b__13_1()
        {
            this.pillowAnimation.GetComponent<UnityEngine.Animator>().Play(stateName:  "LevelWinPillowAnimation", layer:  0, normalizedTime:  0f);
        }
        private void <ShowStarImage>b__13_2()
        {
            if(this.curvedTextAnimator != null)
            {
                    this.curvedTextAnimator.StartAnimation(isReversed:  false);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void <ShowCrownImage>b__14_0()
        {
            if(this.curvedTextAnimator != null)
            {
                    this.curvedTextAnimator.StartAnimation(isReversed:  false);
                return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
