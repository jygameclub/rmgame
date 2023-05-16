using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassPopupActivateView : MonoBehaviour
    {
        // Fields
        public UnityEngine.Sprite yellowTopAsset;
        public UnityEngine.Sprite yellowBottomAsset;
        public UnityEngine.SpriteRenderer topLeft;
        public UnityEngine.SpriteRenderer topRight;
        public UnityEngine.SpriteRenderer bottomLeft;
        public UnityEngine.SpriteRenderer bottomRight;
        public UnityEngine.GameObject activatedView;
        public UnityEngine.GameObject activeText;
        public UnityEngine.BoxCollider2D activateCollider;
        
        // Methods
        private void Awake()
        {
            this.activateCollider.enabled = (~(Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasRoyalPass)) & 1;
            if(((~(Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasRoyalPass)) & 1) != 0)
            {
                    return;
            }
            
            this.SetActivatedView();
        }
        private void SetActivatedView()
        {
            this.topLeft.sprite = this.yellowTopAsset;
            this.topRight.sprite = this.yellowTopAsset;
            this.bottomLeft.sprite = this.yellowBottomAsset;
            this.bottomRight.sprite = this.yellowBottomAsset;
            this.activeText.SetActive(value:  false);
            this.activatedView.SetActive(value:  true);
        }
        public RoyalPassPopupActivateView()
        {
        
        }
    
    }

}
