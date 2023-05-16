using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public abstract class RoyalPassRewardView : RoyalPassView
    {
        // Fields
        private bool isLocked;
        
        // Methods
        public virtual void Init(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassReward royalPassReward, bool isLocked = False)
        {
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.isLocked = isLocked;
        }
        public virtual void IncreaseSorting(int multiplier)
        {
            T val_4;
            if(val_1.Length < 1)
            {
                    return;
            }
            
            var val_4 = 0;
            do
            {
                val_4 = this.GetComponentsInChildren<UnityEngine.SpriteRenderer>()[val_4];
                val_4.sortingOrder = val_4.sortingOrder * multiplier;
                val_4 = val_4 + 1;
            }
            while(val_4 < val_1.Length);
        
        }
        protected RoyalPassRewardView()
        {
        
        }
    
    }

}
