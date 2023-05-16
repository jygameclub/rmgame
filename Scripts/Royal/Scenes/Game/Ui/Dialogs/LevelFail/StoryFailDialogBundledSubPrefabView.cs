using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.LevelFail
{
    public class StoryFailDialogBundledSubPrefabView : MonoBehaviour
    {
        // Fields
        public UnityEngine.SpriteRenderer roomBackground;
        public UnityEngine.TextAsset roomBackgroundTextAsset;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  0f, y:  0f);
            this.roomBackground.sprite = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ToSprite(textAsset:  this.roomBackgroundTextAsset, width:  244, height:  96, format:  3, pivot:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
        }
        public StoryFailDialogBundledSubPrefabView()
        {
        
        }
    
    }

}
