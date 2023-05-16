using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.PiggyBank
{
    public class PiggyBankIcon : AIconView
    {
        // Fields
        public UnityEngine.SpriteRenderer piggy;
        public UnityEngine.GameObject icon;
        public TMPro.TextMeshPro amountText;
        public UnityEngine.SpriteRenderer coinIcon;
        private bool isPiggyEnabled;
        private Royal.Player.Context.Units.PiggyBankManager piggyBankManager;
        
        // Methods
        public override void Init()
        {
            this.piggyBankManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.PiggyBankManager>(id:  8);
            add_OnChestUpdated(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyBankIcon::UpdateAmount()));
            this.UpdateIcon();
            this.UpdateCoinText(amount:  Royal.Player.Context.Units.PiggyBankManager.GetPiggy());
        }
        public override bool IsVisible()
        {
            if(this.icon != null)
            {
                    return this.icon.activeInHierarchy;
            }
            
            throw new NullReferenceException();
        }
        public void OnClick()
        {
            this.ShowPiggyBankDialog();
        }
        private void UpdateIcon()
        {
            this.icon.SetActive(value:  this.piggyBankManager.ShouldShowIcon);
        }
        private void UpdateAmount()
        {
            this.UpdateCoinText(amount:  Royal.Player.Context.Units.PiggyBankManager.GetPiggy());
        }
        private void UpdateCoinText(int amount)
        {
            var val_12;
            TMPro.TextMeshPro val_15;
            string val_16;
            if(amount == 0)
            {
                goto label_1;
            }
            
            if(amount >= 5000)
            {
                goto label_3;
            }
            
            this.coinIcon.enabled = true;
            var val_2 = (amount < 100) ? 1 : 0;
            this.coinIcon.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.amountText.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.amountText.alignment = 2;
            this.amountText.text = Royal.Player.Context.Units.PiggyBankManager.GetTextFromAmount(amount:  amount);
            UnityEngine.RectTransform val_5 = this.amountText.rectTransform;
            val_12 = val_5;
            UnityEngine.Vector2 val_6 = val_5.sizeDelta;
            goto label_12;
            label_1:
            this.coinIcon.enabled = false;
            this.amountText.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.amountText.alignment = 2;
            val_15 = this.amountText;
            val_16 = "Empty";
            goto label_17;
            label_3:
            this.coinIcon.enabled = false;
            this.amountText.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.amountText.alignment = 2;
            val_15 = this.amountText;
            val_16 = "Full";
            label_17:
            val_15.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  val_16);
            UnityEngine.RectTransform val_10 = this.amountText.rectTransform;
            val_12 = val_10;
            UnityEngine.Vector2 val_11 = val_10.sizeDelta;
            label_12:
            val_12.sizeDelta = new UnityEngine.Vector2() {x = 1.25f, y = val_11.y};
        }
        private void ShowPiggyBankDialog()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.PiggyBank.ShowPiggyBankStatusDialogAction(disableTouch:  false, newPiggy:  false, fromAnotherDialog:  true));
        }
        public void PrepareIconForAnimation(int initialAmount)
        {
            this.UpdateCoinText(amount:  initialAmount);
        }
        public void PlayHitAnimation(int amount)
        {
            this.UpdateCoinText(amount:  amount);
            UnityEngine.Vector3 val_2 = this.piggy.transform.localScale;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  1.1f);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.95f);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  1.05f);
            DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.9f);
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.piggy.transform, endValue:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  1f)));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.piggy.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f)), ease:  3));
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.piggy.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  7f)), ease:  3));
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.piggy.transform, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  6f)), ease:  3));
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.piggy.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f)), ease:  3));
        }
        private void OnDestroy()
        {
            remove_OnChestUpdated(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyBankIcon::UpdateAmount()));
        }
        public PiggyBankIcon()
        {
        
        }
    
    }

}
