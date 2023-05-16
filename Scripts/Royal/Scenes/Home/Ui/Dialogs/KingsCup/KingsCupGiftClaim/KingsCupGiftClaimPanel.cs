using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim
{
    public class KingsCupGiftClaimPanel : UiPanel
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftView giftView;
        public TMPro.TextMeshPro tapText;
        public UnityEngine.SpriteRenderer background;
        private Royal.Scenes.Home.Ui.Dialogs.EpisodeChest.TapState tapState;
        public Royal.Infrastructure.Utils.Text.CurvedTextAnimator rewardText;
        public float textDelay;
        private bool isTapEnabled;
        private System.Action onComplete;
        private Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        
        // Methods
        public void Show(System.Action onComplete, Royal.Player.Context.Data.InventoryPackage inventoryPackage)
        {
            null = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.ChangeSection(type:  0);
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  this.camManager.cameraHeight);
            this.background.size = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            this.onComplete = onComplete;
            this.Invoke(methodName:  "AnimateTextToOpen", time:  1f);
            this.Invoke(methodName:  "PlayRewardAnimation", time:  this.textDelay);
        }
        private void PlayRewardAnimation()
        {
            if(this.rewardText == 0)
            {
                    return;
            }
            
            this.rewardText.StartAnimation(isReversed:  false);
        }
        public override void TouchUp(UnityEngine.Vector2 position)
        {
            if(this.isTapEnabled == false)
            {
                    return;
            }
            
            if(this.tapState != 1)
            {
                    if(this.tapState != 0)
            {
                    return;
            }
            
                this.OpenClicked();
                return;
            }
            
            this.ContinueClicked();
        }
        private void ContinueClicked()
        {
            var val_18;
            this.isTapEnabled = false;
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.15f), ease:  1));
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0f, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.background, endValue:  0f, duration:  0.2f));
            val_18 = 0;
            if(this.rewardText == 0)
            {
                goto label_8;
            }
            
            this.rewardText.EnableUpdateForCurvedTexts();
            var val_19 = 0;
            label_15:
            if(val_19 >= this.rewardText.texts.Length)
            {
                goto label_12;
            }
            
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0f, t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  this.rewardText.texts[val_19].GetComponent<TMPro.TextMeshPro>(), endValue:  0f, duration:  0.15f));
            val_19 = val_19 + 1;
            if(this.rewardText != null)
            {
                goto label_15;
            }
            
            throw new NullReferenceException();
            label_12:
            val_18 = 0;
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0f, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.rewardText.transform, endValue:  1.1f, duration:  0.15f));
            label_8:
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_1, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftClaimPanel::<ContinueClicked>b__13_0()));
        }
        private void OpenClicked()
        {
            this.isTapEnabled = false;
            System.Action val_1 = new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftClaimPanel::AnimateTextToContinue());
            this.HideText();
        }
        private void AnimateTextToContinue()
        {
            this.tapState = 1;
            this.AnimateText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Tap to Continue"));
        }
        private void AnimateTextToOpen()
        {
            this.tapState = 0;
            this.AnimateText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Tap to Open"));
        }
        private void AnimateText(string text)
        {
            KingsCupGiftClaimPanel.<>c__DisplayClass17_0 val_1 = new KingsCupGiftClaimPanel.<>c__DisplayClass17_0();
            .<>4__this = this;
            .text = text;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            this.isTapEnabled = false;
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.15f), ease:  1));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void KingsCupGiftClaimPanel.<>c__DisplayClass17_0::<AnimateText>b__0()));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.2f), ease:  27));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void KingsCupGiftClaimPanel.<>c__DisplayClass17_0::<AnimateText>b__1()));
        }
        private void HideText()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.15f), ease:  1));
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftClaimPanel::<HideText>b__18_0()));
        }
        public KingsCupGiftClaimPanel()
        {
        
        }
        private void <ContinueClicked>b__13_0()
        {
            this.onComplete.Invoke();
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        private void <HideText>b__18_0()
        {
            this.tapText.text = "";
        }
    
    }

}
