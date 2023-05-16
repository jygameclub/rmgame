using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassRewardClaimButtonView : RoyalPassView
    {
        // Fields
        public TMPro.TextMeshPro claimButtonText;
        public Royal.Infrastructure.UiComponents.Button.UiScrollButton claimButtonCollider;
        private System.Action onClaimClicked;
        
        // Methods
        public void Init(UnityEngine.Bounds maskBounds, string buttonText, System.Action claimAction, bool isChestReward, UnityEngine.Transform containerTransform, UnityEngine.Transform rootTransform)
        {
            var val_6;
            UnityEngine.Transform val_1 = containerTransform.transform;
            if(isChestReward != false)
            {
                    val_1.SetParent(p:  containerTransform);
                val_6 = containerTransform.transform;
            }
            else
            {
                    val_1.SetParent(p:  rootTransform);
                val_6 = containerTransform.transform;
                UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  -0.028f, y:  -1.056f);
                UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            }
            
            val_6.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            this.onClaimClicked = claimAction;
            this.claimButtonCollider = maskBounds.m_Extents.y;
            this.claimButtonCollider = maskBounds.m_Center.x;
            this.claimButtonText.text = buttonText;
        }
        public void ClaimClicked()
        {
            if(this.onClaimClicked == null)
            {
                    return;
            }
            
            this.onClaimClicked.Invoke();
        }
        public override void OnRecycle()
        {
            this.OnRecycle();
            this.onClaimClicked = 0;
        }
        public override int GetPoolId()
        {
            return 8;
        }
        public RoyalPassRewardClaimButtonView()
        {
        
        }
    
    }

}
