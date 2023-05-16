using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassRewardUnlimitedLivesView : RoyalPassRewardView
    {
        // Fields
        public TMPro.TextMeshPro durationText;
        public UnityEngine.Transform clock;
        
        // Methods
        public override void Init(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassReward royalPassReward, bool isLocked)
        {
            var val_6;
            this.Init(royalPassReward:  royalPassReward, isLocked:  false);
            this.durationText.text = royalPassReward.GetAmountOrDurationText();
            string val_2 = this.durationText.text;
            if(val_2.m_stringLength != 2)
            {
                goto label_5;
            }
            
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isTurkish != true)
            {
                    if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic == false)
            {
                goto label_27;
            }
            
            }
            
            label_27:
            this.clock.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_6 = this.durationText.transform;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isTurkish == true)
            {
                goto label_12;
            }
            
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic == false)
            {
                goto label_30;
            }
            
            goto label_12;
            label_5:
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isTurkish != true)
            {
                    if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic == false)
            {
                goto label_29;
            }
            
            }
            
            label_29:
            this.clock.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_6 = this.durationText.transform;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isTurkish != true)
            {
                    if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic == false)
            {
                goto label_30;
            }
            
            }
            
            label_30:
            label_12:
            val_6.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            if((val_2.m_stringLength == 3) && (Royal.Infrastructure.Services.Localization.LocalizationHelper.isRussian != false))
            {
                    this.clock.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                this.durationText.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            }
            
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.__il2cppRuntimeField_static_fields == false)
            {
                    return;
            }
            
            this.durationText.enableAutoSizing = true;
        }
        public override int GetPoolId()
        {
            return 4;
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
        public RoyalPassRewardUnlimitedLivesView()
        {
            val_1 = new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassView();
        }
    
    }

}
