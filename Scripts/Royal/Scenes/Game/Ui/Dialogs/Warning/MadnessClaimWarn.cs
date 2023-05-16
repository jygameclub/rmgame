using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.Warning
{
    public class MadnessClaimWarn : MonoBehaviour
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.Madness.MadnessBar.MadnessBarProgress madnessBarProgress;
        public Royal.Scenes.Home.Ui.Dialogs.Madness.MadnessBar.MadnessBarTargetView madnessBarTargetView;
        public Royal.Scenes.Home.Ui.Dialogs.Madness.MadnessBar.MadnessBarRewardView madnessBarRewardView;
        public TMPro.TextMeshPro warnText;
        public UnityEngine.Vector2 madnessPropellerTargetPosition;
        public UnityEngine.Vector2 madnessBookTargetPosition;
        
        // Methods
        public void Show(Royal.Player.Context.Units.MadnessStep madnessStep, Royal.Infrastructure.Services.Backend.Protocol.MadnessEventType eventType, float totalLeftBarSize)
        {
            var val_8;
            UnityEngine.Vector2 val_9;
            this.madnessBarTargetView.CreateTarget(eventType:  eventType, isInGameBar:  true);
            this.madnessBarRewardView.SetupForSmallDisplay(madnessStep:  madnessStep);
            this.madnessBarProgress.FakeInit(totalLeftBarSize:  totalLeftBarSize);
            if((eventType & 255) == 3)
            {
                    this.warnText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "BookofTreasurebarfullwarning");
                UnityEngine.Transform val_3 = this.madnessBarTargetView.transform;
                val_8 = 1152921504781287424;
                val_9 = this.madnessBookTargetPosition;
            }
            else
            {
                    this.warnText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Propellerbarfullwarning");
                val_8 = 1152921504781287424;
                val_9 = this.madnessPropellerTargetPosition;
            }
            
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_9, y = totalLeftBarSize});
            this.madnessBarTargetView.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
        public MadnessClaimWarn()
        {
        
        }
    
    }

}
