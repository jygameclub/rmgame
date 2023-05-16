using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions
{
    public class PlayRoyalPassRewardItemAnimationAction : PlayShopRewardItemAnimationAction
    {
        // Fields
        private readonly float delay;
        
        // Methods
        public PlayRoyalPassRewardItemAnimationAction(float delay)
        {
            float val_1 = this.delay;
            mem[1152921519308251516] = 1;
            val_1 = val_1 + delay;
            this.delay = val_1;
            mem[1152921519308251520] = 1073741824;
        }
        protected override float GetDurationForNextAction()
        {
            return (float)S0 + this.delay;
        }
        protected override Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem.ShopRewardItemView CreateItem(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType, UnityEngine.Vector2 offset, int boosterCount, int count, int delayCount)
        {
            val_1.xHolder.SetActive(value:  false);
            val_1.countText.text = "x" + val_1.countText.text;
            UnityEngine.Transform val_4 = val_1.countText.transform;
            UnityEngine.Vector3 val_5 = val_4.localPosition;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  0.296f);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            val_4.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            return (Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem.ShopRewardItemView)this.CreateItem(boosterType:  boosterType, offset:  new UnityEngine.Vector2() {x = offset.x, y = offset.y}, boosterCount:  boosterCount, count:  count, delayCount:  delayCount);
        }
    
    }

}
