using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Goal
{
    [Serializable]
    public class GoalAsset
    {
        // Fields
        public Royal.Scenes.Game.Mechanics.Goal.GoalType goalType;
        public UnityEngine.Sprite iconSprite;
        public UnityEngine.Sprite shadowSprite;
        public UnityEngine.Vector2 shadowPosition;
        public UnityEngine.Vector2 shadowScale;
        public float shadowAlpha;
        public float iconScale;
        public UnityEngine.Vector2 iconOffset;
        
        // Methods
        public GoalAsset()
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            this.shadowPosition = val_1;
            mem[1152921523877738556] = val_1.y;
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  0.95f, y:  1f);
            this.shadowScale = val_2.x;
            this.shadowAlpha = 0.33f;
            this.iconScale = 1f;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
            this.iconOffset = val_3;
            mem[1152921523877738580] = val_3.y;
        }
    
    }

}
