using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassRewardFirstGoldView : RoyalPassRewardView
    {
        // Fields
        public UnityEngine.SpriteRenderer kingPicture;
        public UnityEngine.SpriteRenderer selfPicture;
        public UnityEngine.GameObject personalAvatar;
        
        // Methods
        public override void Init(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassReward royalPassReward, bool isLocked = False)
        {
            this.Init(royalPassReward:  royalPassReward, isLocked:  isLocked);
            this.ArrangePersonalInfo();
        }
        private void ArrangePersonalInfo()
        {
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.IsConnectedFacebook()) != false)
            {
                    0 = Royal.Infrastructure.Services.Login.FacebookConnect.LoadProfilePicture(facebookId:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_byval_arg);
            }
            
            if(0 != 0)
            {
                    this.personalAvatar.SetActive(value:  true);
                this.kingPicture.gameObject.SetActive(value:  false);
                this.selfPicture.sprite = 0;
                return;
            }
            
            this.personalAvatar.SetActive(value:  false);
            this.kingPicture.gameObject.SetActive(value:  true);
        }
        public override int GetPoolId()
        {
            return 7;
        }
        public RoyalPassRewardFirstGoldView()
        {
            val_1 = new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassView();
        }
    
    }

}
