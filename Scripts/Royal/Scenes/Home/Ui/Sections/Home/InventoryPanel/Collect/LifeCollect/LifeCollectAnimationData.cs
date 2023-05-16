using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect
{
    public struct LifeCollectAnimationData : IEquatable<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData>
    {
        // Fields
        private readonly int lifeCount;
        private readonly int unlimitedMinutes;
        
        // Methods
        public LifeCollectAnimationData(int minutes, int count = 0)
        {
            mem[1152921519124588560] = count;
            mem[1152921519124588564] = minutes;
        }
        public static int TotalLifeCount(System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData> list)
        {
            var val_1;
            if(true >= 1)
            {
                    var val_2 = 0;
                do
            {
                if(val_2 >= true)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_1 = true + 0;
                val_2 = val_2 + 1;
                val_1 = 0 + ((true + 0) + 32);
            }
            while(val_2 < true);
            
                return (int)val_1;
            }
            
            val_1 = 0;
            return (int)val_1;
        }
        public static int TotalUnlimitedMinutes(System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData> list)
        {
            var val_3;
            if(true >= 1)
            {
                    var val_4 = 0;
                do
            {
                if(val_4 >= true)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_1 = true + 0;
                val_4 = val_4 + 1;
                val_3 = 0 + ((true + 0) + 36);
            }
            while(val_4 < true);
            
                return (int)val_3;
            }
            
            val_3 = 0;
            return (int)val_3;
        }
        public bool Equals(Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData other)
        {
            if(W8 != other.lifeCount)
            {
                    return false;
            }
            
            return (bool)(W8 == (other.lifeCount >> 32)) ? 1 : 0;
        }
        public override bool Equals(object obj)
        {
        
        }
        public override int GetHashCode()
        {
            return (int)(W8 * 397) ^ W9;
        }
    
    }

}
