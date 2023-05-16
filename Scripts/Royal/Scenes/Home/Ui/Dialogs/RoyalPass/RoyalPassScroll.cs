using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassScroll : MonoBehaviour
    {
        // Fields
        public const float DefaultScrollPosition = -1;
        public UnityEngine.BoxCollider2D boxCollider;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassScrollContent content;
        public Royal.Infrastructure.UiComponents.Scroll.UiVerticalScroll verticalScroll;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        
        // Methods
        public void PrepareContent(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPopup royalPassPopup, System.Nullable<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassClaimData> claimData, bool isAfterPurchase, float scrollPosition)
        {
            float val_13;
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassScrollContent val_14;
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassScrollContent val_16;
            float val_18;
            float val_19;
            val_13 = scrollPosition;
            val_14 = this;
            Royal.Player.Context.Units.RoyalPassManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            System.Collections.Generic.List<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStepRowData> val_3 = val_1.GetRoyalPassRowsFromConfig();
            this.content = royalPassPopup;
            val_16 = this.content;
            if(null >= 1)
            {
                    var val_13 = 0;
                var val_14 = 32;
                do
            {
                if(val_13 >= null)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_16 = this.content;
                val_13 = val_13 + 1;
                val_14 = val_14 + 40;
            }
            while(val_13 < null);
            
            }
            
            if(isAfterPurchase == false)
            {
                goto label_16;
            }
            
            val_16 = 1152921519268687408;
            if((val_1.GetStep() - 1) <= )
            {
                goto label_16;
            }
            
            val_18 = 1.6f;
            val_19 = 1.152922E+18f;
            goto label_18;
            label_16:
            float val_15 = val_13;
            if((UnityEngine.Mathf.Approximately(a:  val_15, b:  -1f)) == false)
            {
                goto label_29;
            }
            
            if(val_1.GetStep() != 1)
            {
                goto label_22;
            }
            
            goto label_29;
            label_22:
            if((val_1.GetStep() != (val_1.GetSafeStepIndex() - 1)) || (val_1.WillStepUp() == false))
            {
                goto label_26;
            }
            
            val_13 = val_15 - (-1f);
            goto label_29;
            label_26:
            val_18 = 1.6f;
            val_19 = (float)val_1.GetStep();
            label_18:
            val_15 = val_15 * val_19;
            val_13 = val_15 + val_18;
            label_29:
            this.content.SetCurrentStepHighlightTransform();
            if((W4 & 1) != 0)
            {
                    this.content.AnimateGoldUnlocks();
            }
            
            if(isAfterPurchase == false)
            {
                    return;
            }
            
            val_14 = this.content;
            val_14.AnimateJustClaimed(justClaimedStep:  new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassClaimData() {step = 1776988320, isFree = true});
        }
        public void AnimateAllItemsFromBottomForTutorial(System.Action callback)
        {
            this.uiTouchListener.disabler.DisableTouch();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.AnimateAllItemsFromBottomForTutorialCoroutine(callback:  callback));
        }
        private System.Collections.IEnumerator AnimateAllItemsFromBottomForTutorialCoroutine(System.Action callback)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .callback = callback;
            return (System.Collections.IEnumerator)new RoyalPassScroll.<AnimateAllItemsFromBottomForTutorialCoroutine>d__7();
        }
        private void PlayTutorialScrollSfx()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16).PlaySound(type:  237, offset:  0.04f);
        }
        public RoyalPassScroll()
        {
        
        }
    
    }

}
