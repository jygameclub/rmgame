using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.EpisodeChest
{
    public class EpisodeChestPanel : UiPanel
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.EpisodeChest.EpisodeChestView chestView;
        public TMPro.TextMeshPro tapText;
        private Royal.Scenes.Home.Ui.Dialogs.EpisodeChest.TapState tapState;
        private bool isTapEnabled;
        private System.Action onComplete;
        
        // Methods
        public void Init()
        {
            this.chestView.Init();
            this.tapText.text = "";
        }
        public void ShowChestAppear(System.Action onComplete)
        {
            this.gameObject.SetActive(value:  true);
            this.onComplete = onComplete;
            this.chestView.PlayChestAppearAnimation();
            this.Invoke(methodName:  "AnimateTextToOpen", time:  1f);
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
            this.isTapEnabled = false;
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.15f), ease:  1));
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.15f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.EpisodeChest.EpisodeChestPanel::<ContinueClicked>b__8_0()));
            this.chestView.HideChestWithAnimation(mainSeq:  val_1);
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_1, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.EpisodeChest.EpisodeChestPanel::<ContinueClicked>b__8_1()));
        }
        private void OpenClicked()
        {
            var val_5;
            Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0).ClaimChest();
            val_5 = null;
            val_5 = null;
            Royal.Scenes.Home.Ui.__il2cppRuntimeField_30.PrepareCoinTextForAnimation(previousCoin:  130671888);
            this.isTapEnabled = false;
            this.chestView = 1;
            UnityEngine.Coroutine val_4 = this.chestView.StartCoroutine(routine:  this.chestView.PlayOpenAnimationRoutine(isArea1:  (Royal.Player.Context.Data.Persistent.UserAreaData.__il2cppRuntimeField_name == 1) ? 1 : 0));
            this.AnimateTextToContinue();
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
            EpisodeChestPanel.<>c__DisplayClass12_0 val_1 = new EpisodeChestPanel.<>c__DisplayClass12_0();
            .<>4__this = this;
            .text = text;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            this.isTapEnabled = false;
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.15f), ease:  1));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void EpisodeChestPanel.<>c__DisplayClass12_0::<AnimateText>b__0()));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.2f), ease:  27));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void EpisodeChestPanel.<>c__DisplayClass12_0::<AnimateText>b__1()));
        }
        public EpisodeChestPanel()
        {
        
        }
        private void <ContinueClicked>b__8_0()
        {
            if(this.onComplete == null)
            {
                    return;
            }
            
            this.onComplete.Invoke();
        }
        private void <ContinueClicked>b__8_1()
        {
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
    
    }

}
