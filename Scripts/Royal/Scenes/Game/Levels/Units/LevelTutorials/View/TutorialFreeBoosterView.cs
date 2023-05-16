using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.View
{
    public class TutorialFreeBoosterView : MonoBehaviour
    {
        // Fields
        public UnityEngine.SpriteRenderer shadowPart1;
        public UnityEngine.SpriteRenderer shadowPart2;
        public UnityEngine.SpriteRenderer badgePart1;
        public UnityEngine.SpriteRenderer badgePart2;
        public UnityEngine.SpriteRenderer badgeShadowPart1;
        public UnityEngine.SpriteRenderer badgeShadowPart2;
        public TMPro.TextMeshPro text;
        
        // Methods
        public void Hide()
        {
            this.gameObject.SetActive(value:  false);
        }
        public void Show()
        {
            this.shadowPart1.enabled = true;
            this.shadowPart2.enabled = true;
            this.gameObject.SetActive(value:  true);
            UnityEngine.Color val_2 = UnityEngine.Color.white;
            this.badgeShadowPart1.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
            UnityEngine.Color val_3 = UnityEngine.Color.white;
            this.badgeShadowPart2.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
        }
        public void ShowWithoutBlack()
        {
            this.shadowPart1.enabled = false;
            this.shadowPart2.enabled = false;
            this.gameObject.SetActive(value:  true);
            this.badgeShadowPart1.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            this.badgeShadowPart2.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        public TutorialFreeBoosterView()
        {
        
        }
    
    }

}
