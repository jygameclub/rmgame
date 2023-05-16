using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.LevelFail
{
    public class RoyalPassEgoRewardBundleView : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject personalAvatar;
        public UnityEngine.SpriteRenderer kingPicture;
        public UnityEngine.SpriteRenderer selfPicture;
        
        // Methods
        private void Awake()
        {
            this.ArrangePersonalInfo();
        }
        private void ArrangePersonalInfo()
        {
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.IsConnectedFacebook()) != false)
            {
                    0 = Royal.Infrastructure.Services.Login.FacebookConnect.LoadProfilePicture(facebookId:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_byval_arg);
            }
            
            UnityEngine.GameObject val_4 = this.kingPicture.gameObject;
            if(0 != 0)
            {
                    val_4.SetActive(value:  false);
                this.personalAvatar.SetActive(value:  true);
                this.selfPicture.sprite = 0;
                return;
            }
            
            val_4.SetActive(value:  true);
            this.personalAvatar.SetActive(value:  false);
        }
        public RoyalPassEgoRewardBundleView()
        {
        
        }
    
    }

}
