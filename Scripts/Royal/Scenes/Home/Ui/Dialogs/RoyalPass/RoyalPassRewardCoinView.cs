using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassRewardCoinView : RoyalPassRewardView
    {
        // Fields
        public UnityEngine.SpriteRenderer coinShadow;
        public TMPro.TextMeshPro amountText;
        
        // Methods
        public override void Init(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassReward royalPassReward, bool isLocked)
        {
            this.Init(royalPassReward:  royalPassReward, isLocked:  false);
            if(this.coinShadow.sprite == 0)
            {
                    this.coinShadow.sprite = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  "shadow_coin");
            }
            
            this.amountText.text = royalPassReward.GetAmountOrDurationText();
        }
        public override void OnRecycle()
        {
            this.OnRecycle();
            this.coinShadow.sprite = 0;
        }
        public override int GetPoolId()
        {
            return 2;
        }
        public override void IncreaseSorting(int multiplier)
        {
            this.IncreaseSorting(multiplier:  multiplier);
            if(this.amountText == 0)
            {
                    return;
            }
            
            this.amountText.sortingOrder = this.amountText.sortingOrder * multiplier;
        }
        public void ChangeTextScaleAndPosition(float multiplier, UnityEngine.Vector3 displacement)
        {
            if(this.amountText == 0)
            {
                    return;
            }
            
            UnityEngine.RectTransform val_2 = this.amountText.rectTransform;
            UnityEngine.Vector3 val_3 = val_2.localScale;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  multiplier);
            val_2.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.RectTransform val_5 = this.amountText.rectTransform;
            UnityEngine.Vector3 val_6 = val_5.localPosition;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = displacement.x, y = displacement.y, z = displacement.z});
            val_5.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        }
        public RoyalPassRewardCoinView()
        {
            val_1 = new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassView();
        }
    
    }

}
