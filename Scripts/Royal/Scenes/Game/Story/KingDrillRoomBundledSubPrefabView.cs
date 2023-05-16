using UnityEngine;

namespace Royal.Scenes.Game.Story
{
    public class KingDrillRoomBundledSubPrefabView : MonoBehaviour
    {
        // Fields
        public UnityEngine.Transform room;
        public UnityEngine.Transform roomBottomCenter;
        public UnityEngine.Transform wall;
        public UnityEngine.Transform kingHead;
        public UnityEngine.Transform ui;
        public UnityEngine.Transform progressUi;
        public UnityEngine.Transform timeUi;
        public UnityEngine.Transform boardBackground;
        public UnityEngine.SpriteRenderer roomBackground;
        public UnityEngine.SpriteRenderer timeUiBackground;
        public UnityEngine.TextAsset roomBackgroundTextAsset;
        public Royal.Infrastructure.Utils.Text.CurvedTextAnimator kingsSpeech;
        public UnityEngine.Animator kingAnimator;
        public Royal.Scenes.Game.Story.KingDrillTimer timer;
        public Royal.Scenes.Game.Story.KingDrillProgress progress;
        public Royal.Scenes.Game.Story.KingDrillRedFrame kingDrillRedFrame;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  0f, y:  0f);
            this.roomBackground.sprite = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ToSprite(textAsset:  this.roomBackgroundTextAsset, width:  244, height:  96, format:  3, pivot:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
        }
        public void UpdateLightningMaterials(UnityEngine.Material lightningMat)
        {
            var val_8 = 1;
            if(val_1.Length < 1)
            {
                    return;
            }
            
            var val_9 = 0;
            do
            {
                T val_8 = this.GetComponentsInChildren<UnityEngine.LineRenderer>(includeInactive:  true)[val_9];
                if(val_8 == 0)
            {
                    throw new NullReferenceException();
            }
            
                val_8.material = lightningMat;
                val_9 = val_9 + 1;
            }
            while(val_9 < val_1.Length);
        
        }
        public KingDrillRoomBundledSubPrefabView()
        {
        
        }
    
    }

}
