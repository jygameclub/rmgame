using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel
{
    public class CoinInfoView : MonoBehaviour
    {
        // Fields
        public UnityEngine.Transform coin;
        public TMPro.TextMeshPro coinsText;
        
        // Methods
        private void Awake()
        {
            add_OnCoinUpdated(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.CoinInfoView::UpdateCoinsText()));
            this.coinsText.text = (Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 40 + 20).ToString();
        }
        public void UnregisterFromCoinUpdates()
        {
            remove_OnCoinUpdated(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.CoinInfoView::UpdateCoinsText()));
        }
        public void PrepareCoinTextForAnimation()
        {
            this.coinsText.text = (Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 40 + 20).ToString();
        }
        public void PrepareCoinTextForAnimation(Royal.Player.Context.Data.Session.BeforeAfterData beforeAfterData)
        {
            this.coinsText.text = beforeAfterData.before.ToString();
        }
        public void PrepareCoinTextForAnimation(int previousCoin)
        {
            Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 40 = 0;
            Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 40.Init(start:  previousCoin);
            Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg.AddCoin(coins:  (Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_name - previousCoin)>>0&0xFFFFFFFF);
            this.coinsText.text = (Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 40 + 20).ToString();
        }
        private void UpdateCoinsText()
        {
            this.coinsText.text = Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_name.ToString();
        }
        public void OnButtonClick()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Sections.Shop.ShowShopPopupViewAction(purchaseStrategy:  new Royal.Scenes.Home.Ui.Sections.Shop.AddCoinsPurchaseStrategy()));
        }
        public void PlayHitAnimation(int amount)
        {
            this.coinsText.text = amount.ToString();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.95f);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_7 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.05f), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.CoinInfoView::<PlayHitAnimation>b__9_0()));
        }
        private void OnDestroy()
        {
            this.UnregisterFromCoinUpdates();
        }
        public void ShowAnimated(UnityEngine.Vector3 finalPosition, float delaySeconds)
        {
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = finalPosition.x, y = finalPosition.y, z = finalPosition.z}, duration:  0.3f, snapping:  false), ease:  27, overshoot:  1.2f), delay:  delaySeconds);
        }
        public void HideAnimated(UnityEngine.Vector3 finalPosition)
        {
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = finalPosition.x, y = finalPosition.y, z = finalPosition.z}, duration:  0.3f, snapping:  false), ease:  26, overshoot:  1.2f);
        }
        public CoinInfoView()
        {
        
        }
        private void <PlayHitAnimation>b__9_0()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_3 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.05f);
        }
    
    }

}
