using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassRewardUnlimitedPreLevelBoosterView : RoyalPassRewardView
    {
        // Fields
        public UnityEngine.SpriteRenderer booster;
        public UnityEngine.SpriteRenderer boosterShadow;
        public TMPro.TextMeshPro durationText;
        public UnityEngine.Transform clock;
        public UnityEngine.Transform[] infinite;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnlimitedPreLevelBoosterConfig[] boosterConfig;
        
        // Methods
        public override void Init(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassReward royalPassReward, bool isLocked)
        {
            float val_40;
            UnityEngine.Vector2 val_41;
            float val_42;
            float val_43;
            this.Init(royalPassReward:  royalPassReward, isLocked:  false);
            Royal.Player.Context.Units.RewardType val_1 = royalPassReward.GetRewardType();
            var val_3 = (val_1 == 5) ? 0 : ((val_1 != 4) ? (1 + 1) : 1);
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnlimitedPreLevelBoosterConfig val_40 = this.boosterConfig[val_3];
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.boosterConfig[val_1 == 0x5 ? 0 : val_1 != 0x4 ? (1 + 1) : 1][0].localPosition, y = V8.16B});
            this.booster.transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnlimitedPreLevelBoosterConfig val_41 = this.boosterConfig[val_3];
            this.booster.sprite = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  this.boosterConfig[val_1 == 0x5 ? 0 : val_1 != 0x4 ? (1 + 1) : 1][0].boosterPrefabName);
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnlimitedPreLevelBoosterConfig val_42 = this.boosterConfig[val_3];
            this.boosterShadow.sprite = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  this.boosterConfig[val_1 == 0x5 ? 0 : val_1 != 0x4 ? (1 + 1) : 1][0].boosterShadowPrefabName);
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnlimitedPreLevelBoosterConfig val_43 = this.boosterConfig[val_3];
            UnityEngine.Vector3 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.boosterConfig[val_1 == 0x5 ? 0 : val_1 != 0x4 ? (1 + 1) : 1][0].boosterScale, y = val_5.y});
            this.booster.transform.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnlimitedPreLevelBoosterConfig val_44 = this.boosterConfig[val_3];
            UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.boosterConfig[val_1 == 0x5 ? 0 : val_1 != 0x4 ? (1 + 1) : 1][0].boosterShadowScale, y = val_9.y});
            this.boosterShadow.transform.localScale = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnlimitedPreLevelBoosterConfig val_45 = this.boosterConfig[val_3];
            UnityEngine.Vector3 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.boosterConfig[val_1 == 0x5 ? 0 : val_1 != 0x4 ? (1 + 1) : 1][0].boosterShadowPosition, y = val_11.y});
            this.boosterShadow.transform.localPosition = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnlimitedPreLevelBoosterConfig val_46 = this.boosterConfig[val_3];
            UnityEngine.Vector3 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.boosterConfig[val_1 == 0x5 ? 0 : val_1 != 0x4 ? (1 + 1) : 1][0].clockPosition, y = val_13.y});
            this.clock.localPosition = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
            var val_49 = 0;
            label_45:
            if(val_49 >= this.infinite.Length)
            {
                goto label_37;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnlimitedPreLevelBoosterConfig val_47 = this.boosterConfig[val_3];
            UnityEngine.Vector3 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.boosterConfig[val_1 == 0x5 ? 0 : val_1 != 0x4 ? (1 + 1) : 1][0].infinitePosition, y = V8.16B});
            this.infinite[val_49].localPosition = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
            val_49 = val_49 + 1;
            if(this.infinite != null)
            {
                goto label_45;
            }
            
            label_37:
            this.durationText.text = royalPassReward.GetAmountOrDurationText();
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnlimitedPreLevelBoosterConfig val_50 = this.boosterConfig[val_3];
            UnityEngine.Vector3 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.boosterConfig[val_1 == 0x5 ? 0 : val_1 != 0x4 ? (1 + 1) : 1][0].durationTextPosition, y = V8.16B});
            this.durationText.transform.localPosition = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnlimitedPreLevelBoosterConfig val_51 = this.boosterConfig[val_3];
            val_41 = this.boosterConfig[val_1 == 0x5 ? 0 : val_1 != 0x4 ? (1 + 1) : 1][0].durationTextRect;
            this.durationText.rectTransform.sizeDelta = new UnityEngine.Vector2() {x = val_41, y = val_18.y};
            if((this.durationText.text.Contains(value:  "15")) != false)
            {
                    UnityEngine.Vector3 val_22 = this.clock.localPosition;
                UnityEngine.Vector3 val_23 = UnityEngine.Vector3.right;
                val_40 = 0.06f;
                UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, d:  val_40);
                UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
                this.clock.localPosition = new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z};
                UnityEngine.Transform val_26 = this.durationText.transform;
                UnityEngine.Vector3 val_27 = val_26.localPosition;
                val_43 = val_27.y;
                UnityEngine.Vector3 val_28 = UnityEngine.Vector3.right;
                UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, d:  val_40);
                val_41 = val_27.x;
                val_42 = val_43;
                UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_41, y = val_42, z = val_27.z}, b:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
                val_26.localPosition = new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z};
            }
            
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isTurkish != true)
            {
                    if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic == false)
            {
                goto label_69;
            }
            
            }
            
            UnityEngine.Vector3 val_31 = this.clock.localPosition;
            UnityEngine.Vector3 val_32 = UnityEngine.Vector3.right;
            val_40 = 0.06f;
            UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z}, d:  val_40);
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, b:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z});
            this.clock.localPosition = new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z};
            UnityEngine.Transform val_35 = this.durationText.transform;
            UnityEngine.Vector3 val_36 = val_35.localPosition;
            val_43 = val_36.y;
            UnityEngine.Vector3 val_37 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z}, d:  val_40);
            UnityEngine.Vector3 val_39 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_36.x, y = val_43, z = val_36.z}, b:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z});
            val_35.localPosition = new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z};
            label_69:
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.__il2cppRuntimeField_static_fields == false)
            {
                    return;
            }
            
            this.durationText.enableAutoSizing = true;
        }
        public override void OnRecycle()
        {
            this.OnRecycle();
            this.booster.sprite = 0;
            this.boosterShadow.sprite = 0;
        }
        public override int GetPoolId()
        {
            return 5;
        }
        public override void IncreaseSorting(int multiplier)
        {
            this.IncreaseSorting(multiplier:  multiplier);
            if(this.durationText == 0)
            {
                    return;
            }
            
            this.durationText.sortingOrder = this.durationText.sortingOrder * multiplier;
        }
        public RoyalPassRewardUnlimitedPreLevelBoosterView()
        {
            val_1 = new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassView();
        }
    
    }

}
