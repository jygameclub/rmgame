using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.LadderOffer
{
    public class LadderOfferRewardTooltip : UiPanel
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.LadderOffer.RewardTypeInfo[] rewards;
        
        // Methods
        public void ArrangeRewards(Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep ladderOfferStep)
        {
            TMPro.TextMeshPro val_4;
            var val_5;
            TMPro.TextMeshPro val_6;
            TMPro.TextMeshPro val_7;
            TMPro.TextMeshPro val_8;
            TMPro.TextMeshPro val_9;
            TMPro.TextMeshPro val_10;
            TMPro.TextMeshPro val_11;
            TMPro.TextMeshPro val_12;
            var val_19;
            .ladderOfferStep = ladderOfferStep;
            Royal.Scenes.Home.Ui.Dialogs.LadderOffer.RewardTypeInfo val_3 = System.Linq.Enumerable.FirstOrDefault<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.RewardTypeInfo>(source:  this.rewards, predicate:  new System.Func<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.RewardTypeInfo, System.Boolean>(object:  new LadderOfferRewardTooltip.<>c__DisplayClass1_0(), method:  System.Boolean LadderOfferRewardTooltip.<>c__DisplayClass1_0::<ArrangeRewards>b__0(Royal.Scenes.Home.Ui.Dialogs.LadderOffer.RewardTypeInfo p)));
            UnityEngine.BoxCollider2D val_13 = this.GetComponent<UnityEngine.BoxCollider2D>();
            if((val_5 - 16) < 2)
            {
                    val_5 = 0;
                UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  1.58f, y:  0.84f);
                val_13.offset = new UnityEngine.Vector2() {x = val_15.x, y = val_15.y};
            }
            else
            {
                    if(val_5 == 18)
            {
                    val_5 = 0;
                UnityEngine.Vector2 val_16 = new UnityEngine.Vector2(x:  1.5f, y:  0.84f);
                val_13.offset = new UnityEngine.Vector2() {x = val_16.x, y = val_16.y};
                UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  7.6f, y:  1.557319f);
                val_13.size = new UnityEngine.Vector2() {x = val_17.x, y = val_17.y};
            }
            
            }
            
            System.Collections.Generic.Dictionary<Royal.Player.Context.Units.RewardType, System.String> val_18 = (LadderOfferRewardTooltip.<>c__DisplayClass1_0)[1152921519425519696].ladderOfferStep.GetChestGiftboxRewards();
            val_18.SetAmountText(rewardsAndAmountTexts:  val_18, amountText:  val_6, rewardType:  11);
            val_18.SetAmountText(rewardsAndAmountTexts:  val_18, amountText:  val_7, rewardType:  13);
            val_18.SetAmountText(rewardsAndAmountTexts:  val_18, amountText:  val_8, rewardType:  12);
            val_18.SetAmountText(rewardsAndAmountTexts:  val_18, amountText:  val_9, rewardType:  6);
            val_18.SetAmountText(rewardsAndAmountTexts:  val_18, amountText:  val_11, rewardType:  8);
            val_18.SetAmountText(rewardsAndAmountTexts:  val_18, amountText:  val_12, rewardType:  7);
            val_18.SetAmountText(rewardsAndAmountTexts:  val_18, amountText:  val_4, rewardType:  9);
            val_18.SetAmountText(rewardsAndAmountTexts:  val_18, amountText:  val_10, rewardType:  1);
            int val_19 = this.rewards.Length;
            if(val_19 < 1)
            {
                    return;
            }
            
            var val_20 = 0;
            val_19 = val_19 & 4294967295;
            do
            {
                if(val_5 == null)
            {
                    val_19 = 1;
            }
            else
            {
                    val_19 = 0;
            }
            
                1152921508476713152.SetActive(value:  false);
                val_20 = val_20 + 1;
            }
            while(val_20 < (this.rewards.Length << ));
        
        }
        private void SetAmountText(System.Collections.Generic.Dictionary<Royal.Player.Context.Units.RewardType, string> rewardsAndAmountTexts, TMPro.TextMeshPro amountText, Royal.Player.Context.Units.RewardType rewardType)
        {
            string val_6;
            if(amountText == 0)
            {
                    return;
            }
            
            if((rewardsAndAmountTexts.ContainsKey(key:  rewardType)) == false)
            {
                goto label_5;
            }
            
            val_6 = 0;
            if((System.String.op_Inequality(a:  rewardsAndAmountTexts.Item[rewardType], b:  "x1")) == false)
            {
                goto label_6;
            }
            
            val_6 = rewardsAndAmountTexts.Item[rewardType];
            if(amountText != null)
            {
                goto label_7;
            }
            
            return;
            label_5:
            val_6 = 0;
            label_6:
            label_7:
            amountText.text = val_6;
        }
        public LadderOfferRewardTooltip()
        {
        
        }
    
    }

}
