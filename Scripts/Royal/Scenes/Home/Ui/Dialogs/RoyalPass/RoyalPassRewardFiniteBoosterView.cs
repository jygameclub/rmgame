using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassRewardFiniteBoosterView : RoyalPassRewardView
    {
        // Fields
        public UnityEngine.SpriteRenderer booster;
        public UnityEngine.SpriteRenderer boosterShadow;
        public TMPro.TextMeshPro amountText;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassFiniteBoosterConfig[] boosterConfig;
        
        // Methods
        public override void Init(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassReward royalPassReward, bool isLocked)
        {
            var val_14;
            this.Init(royalPassReward:  royalPassReward, isLocked:  false);
            if((royalPassReward.GetRewardType() - 6) <= 7)
            {
                    val_14 = mem[36596000 + ((val_1 - 6)) << 2];
                val_14 = 36596000 + ((val_1 - 6)) << 2;
            }
            else
            {
                    val_14 = 6;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassFiniteBoosterConfig val_14 = this.boosterConfig[val_14];
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.boosterConfig[0x6][0].localPosition, y = V8.16B});
            this.booster.transform.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            this.SetBoosterFromResourceOrSpriteReference(spriteIndex:  6);
            this.SetBoosterShadowFromResourceOrSpriteReference(spriteIndex:  6);
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassFiniteBoosterConfig val_15 = this.boosterConfig[val_14];
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.boosterConfig[0x6][0].boosterScale, y = val_4.y});
            this.booster.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassFiniteBoosterConfig val_16 = this.boosterConfig[val_14];
            UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.boosterConfig[0x6][0].boosterShadowScale, y = val_6.y});
            this.boosterShadow.transform.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassFiniteBoosterConfig val_17 = this.boosterConfig[val_14];
            UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.boosterConfig[0x6][0].boosterShadowPosition, y = val_8.y});
            this.boosterShadow.transform.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            this.amountText.text = royalPassReward.GetAmountOrDurationText();
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassFiniteBoosterConfig val_18 = this.boosterConfig[val_14];
            UnityEngine.Vector3 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.boosterConfig[0x6][0].amountPosition, y = val_10.y});
            this.amountText.transform.localPosition = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        }
        public override void OnRecycle()
        {
            this.OnRecycle();
            this.booster.sprite = 0;
            this.boosterShadow.sprite = 0;
        }
        private void SetBoosterFromResourceOrSpriteReference(int spriteIndex)
        {
            UnityEngine.SpriteRenderer val_4;
            UnityEngine.Sprite val_5;
            val_4 = this;
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassFiniteBoosterConfig val_4 = this.boosterConfig[spriteIndex];
            if(this.boosterConfig[spriteIndex][0].boosterSprite != 0)
            {
                    val_5 = this.boosterConfig[spriteIndex][0].boosterSprite;
            }
            else
            {
                    if((System.String.IsNullOrEmpty(value:  this.boosterConfig[spriteIndex][0].boosterSpriteName)) != false)
            {
                    return;
            }
            
                val_4 = this.booster;
                val_5 = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  this.boosterConfig[spriteIndex][0].boosterSpriteName);
            }
            
            val_4.sprite = val_5;
        }
        private void SetBoosterShadowFromResourceOrSpriteReference(int spriteIndex)
        {
            UnityEngine.SpriteRenderer val_4;
            UnityEngine.Sprite val_5;
            val_4 = this;
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassFiniteBoosterConfig val_4 = this.boosterConfig[spriteIndex];
            if(this.boosterConfig[spriteIndex][0].boosterShadowSprite != 0)
            {
                    val_5 = this.boosterConfig[spriteIndex][0].boosterShadowSprite;
            }
            else
            {
                    if((System.String.IsNullOrEmpty(value:  this.boosterConfig[spriteIndex][0].boosterShadowSpriteName)) != false)
            {
                    return;
            }
            
                val_4 = this.boosterShadow;
                val_5 = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  this.boosterConfig[spriteIndex][0].boosterShadowSpriteName);
            }
            
            val_4.sprite = val_5;
        }
        public override int GetPoolId()
        {
            return 3;
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
        public RoyalPassRewardFiniteBoosterView()
        {
            val_1 = new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassView();
        }
    
    }

}
