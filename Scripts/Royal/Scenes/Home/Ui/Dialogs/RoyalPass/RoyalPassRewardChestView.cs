using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassRewardChestView : RoyalPassRewardView
    {
        // Fields
        public UnityEngine.SpriteRenderer chest;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.ChestConfig[] chestConfig;
        
        // Methods
        public void InitForChest(Royal.Player.Context.Units.RewardName rewardName)
        {
            var val_6;
            if((rewardName - 5) <= 6)
            {
                    val_6 = mem[36595936 + ((rewardName - 5)) << 3];
                val_6 = 36595936 + ((rewardName - 5)) << 3;
            }
            else
            {
                    val_6 = 6;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.ChestConfig val_6 = this.chestConfig[val_6];
            this.chest.sprite = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  this.chestConfig[0x6][0].chestSpriteName);
            UnityEngine.Transform val_3 = this.chest.transform;
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.ChestConfig val_7 = this.chestConfig[val_6];
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.chestConfig[0x6][0].position, y = V8.16B});
            val_3.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.ChestConfig val_8 = this.chestConfig[val_6];
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.chestConfig[0x6][0].scale, y = val_4.y});
            val_3.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        public override void OnRecycle()
        {
            this.OnRecycle();
            this.chest.sprite = 0;
        }
        public override int GetPoolId()
        {
            return 6;
        }
        public RoyalPassRewardChestView()
        {
            val_1 = new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassView();
        }
    
    }

}
