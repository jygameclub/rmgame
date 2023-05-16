using UnityEngine;

namespace Royal.Scenes.Home.Context.Units.Tutorial.View
{
    public class HomePrelevelTutorial : IBackable
    {
        // Fields
        private readonly Royal.Scenes.Home.Context.Units.Tutorial.HomeTutorialHighlightHelper homeTutorialHighlightHelper;
        private readonly Royal.Scenes.Home.Context.Units.Tutorial.HomeTutorialDialogHelper homeTutorialDialogHelper;
        private readonly Royal.Scenes.Home.Ui.Dialogs.Prelevel.PrelevelDialog prelevelDialog;
        
        // Methods
        public HomePrelevelTutorial(Royal.Scenes.Home.Ui.Dialogs.Prelevel.PrelevelDialog dialog, Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialViewAssets homeTutorialViewAssets)
        {
            this.prelevelDialog = dialog;
            dialog.add_OnBoosterClicked(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Context.Units.Tutorial.View.HomePrelevelTutorial::ContinueButtonClicked()));
            FillBoosters(boosterType:  1);
            FillBoosters(boosterType:  2);
            FillBoosters(boosterType:  3);
            dialog.UpdateBoostersCountText();
            .assets = homeTutorialViewAssets;
            this.homeTutorialHighlightHelper = new Royal.Scenes.Home.Context.Units.Tutorial.HomeTutorialHighlightHelper();
            .assets = homeTutorialViewAssets;
            .continueAction = new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Context.Units.Tutorial.View.HomePrelevelTutorial::ContinueButtonClicked());
            this.homeTutorialDialogHelper = new Royal.Scenes.Home.Context.Units.Tutorial.HomeTutorialDialogHelper();
            this.homeTutorialHighlightHelper.add_OnBackgroundClicked(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Context.Units.Tutorial.View.HomePrelevelTutorial::ContinueButtonClicked()));
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_6 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            goto typeof(Royal.Infrastructure.UiComponents.Touch.Inputs.InputHelper).__il2cppRuntimeField_1E0;
        }
        public void StartTutorial()
        {
            UnityEngine.Vector3 val_1 = this.prelevelDialog.GetBoostersCenterPosition();
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.25f);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            this.homeTutorialHighlightHelper.HighlightArea(centerPos:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, width:  6.28f, height:  2.7f);
            val_6.tutorialText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "PrelevelTutorial");
            UnityEngine.Vector3 val_8 = this.prelevelDialog.GetPlayButtonPosition();
            Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialDialogView val_9 = this.homeTutorialDialogHelper.ShowDialog(animation:  new System.Action<UnityEngine.Transform>(object:  this, method:  System.Void Royal.Scenes.Home.Context.Units.Tutorial.View.HomePrelevelTutorial::AnimateDialog(UnityEngine.Transform transform))).SetPosition(position:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, anchor:  0);
        }
        private void AnimateDialog(UnityEngine.Transform transform)
        {
            .transform = transform;
            UnityEngine.Vector3 val_2 = transform.localScale;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            (HomePrelevelTutorial.<>c__DisplayClass5_0)[1152921519569153088].transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Sequence>(t:  val_4, delay:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  20f));
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_4, callback:  new DG.Tweening.TweenCallback(object:  new HomePrelevelTutorial.<>c__DisplayClass5_0(), method:  System.Void HomePrelevelTutorial.<>c__DisplayClass5_0::<AnimateDialog>b__0()));
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (HomePrelevelTutorial.<>c__DisplayClass5_0)[1152921519569153088].transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  26f)), ease:  27));
            UnityEngine.Coroutine val_14 = Royal.Scenes.Home.Context.HomeContext.ManualStartCoroutine(iEnumerator:  this.MoveBoosterButtonToTopZIndex());
        }
        private System.Collections.IEnumerator MoveBoosterButtonToTopZIndex()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new HomePrelevelTutorial.<MoveBoosterButtonToTopZIndex>d__6();
        }
        private void ContinueButtonClicked()
        {
            this.homeTutorialHighlightHelper.remove_OnBackgroundClicked(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Context.Units.Tutorial.View.HomePrelevelTutorial::ContinueButtonClicked()));
            this.prelevelDialog.remove_OnBoosterClicked(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Context.Units.Tutorial.View.HomePrelevelTutorial::ContinueButtonClicked()));
            this.homeTutorialDialogHelper.HideDialog();
            this.homeTutorialHighlightHelper.DisableHighlight();
            this.prelevelDialog.ResetBoosterButtonsZIndex();
            bool val_3 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetBool(key:  "PrelevelBoosterTutorialShowed", value:  true);
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_4 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            goto typeof(Royal.Infrastructure.UiComponents.Touch.Inputs.InputHelper).__il2cppRuntimeField_1F0;
        }
        public void PressBack()
        {
            this.ContinueButtonClicked();
        }
    
    }

}
