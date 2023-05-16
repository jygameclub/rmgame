using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim
{
    public abstract class KingsCupGiftRewards : MonoBehaviour
    {
        // Properties
        protected virtual int BoosterRevealSoundAmount { get; }
        
        // Methods
        protected virtual int get_BoosterRevealSoundAmount()
        {
            return 0;
        }
        public abstract void ShowRewards(); // 0
        public abstract DG.Tweening.Sequence SendRewardsToButton(); // 0
        public abstract void SetPackage(Royal.Player.Context.Data.InventoryPackage inventoryPackage); // 0
        public void PlayBoosterRevealSounds()
        {
            if(this < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            float val_1 = 0f;
            do
            {
                this.Invoke(methodName:  "PlayBoosterRevealSound", time:  val_1);
                val_1 = val_1 + 0.05f;
                val_2 = val_2 + 1;
            }
            while(val_2 < this);
        
        }
        private void PlayBoosterRevealSound()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16).PlaySound(type:  24, offset:  0.04f);
        }
        protected KingsCupGiftRewards()
        {
        
        }
    
    }

}
