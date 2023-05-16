using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.View
{
    public class TutorialBlackView : MonoBehaviour
    {
        // Fields
        public UnityEngine.SpriteRenderer background;
        public UnityEngine.Camera renderCam;
        public UnityEngine.GameObject renderParent;
        public UnityEngine.Transform maskTransform;
        public ToJ.Mask tutorialMask;
        private UnityEngine.RenderTexture renderTexture;
        private Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        
        // Methods
        public void Awake()
        {
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_1.cameraWidth, y:  val_1.cameraHeight);
            this.background.size = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTutorialBlackSorting();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.background, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything & 4294967295});
            this.gameObject.SetActive(value:  false);
            UnityEngine.RenderTexture val_8 = new UnityEngine.RenderTexture(width:  UnityEngine.Screen.width, height:  UnityEngine.Screen.height, depth:  16, format:  0);
            val_8.antiAliasing = 1;
            val_8.useMipMap = false;
            val_8.format = 16;
            val_8.depth = 0;
            this.renderTexture = val_8;
            bool val_9 = val_8.Create();
            this.renderCam.orthographicSize = this.camManager.GetOrtographicSize();
            this.renderCam.targetTexture = this.renderTexture;
            this.tutorialMask.MainTex = this.renderTexture;
            UnityEngine.Vector2 val_11 = this.camManager.GetScreenSize();
            UnityEngine.Vector3 val_12 = this.maskTransform.localScale;
            this.maskTransform.localScale = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_12.z};
        }
        public void Show()
        {
            if(this.gameObject.activeSelf != false)
            {
                    return;
            }
            
            UnityEngine.Color val_3 = UnityEngine.Color.black;
            UnityEngine.Color val_4 = UnityEngine.Color.clear;
            this.background.color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
            this.SetPositionAndActivate();
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_5 = DG.Tweening.DOTweenModuleSprite.DOColor(target:  this.background, endValue:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = 0.7f}, duration:  0.2f);
        }
        private void SetPositionAndActivate()
        {
            UnityEngine.Vector2 val_2 = this.camManager.GetCenterPosition();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            this.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.gameObject.SetActive(value:  true);
        }
        public void Hide()
        {
            this.gameObject.SetActive(value:  false);
        }
        public TutorialBlackView()
        {
        
        }
    
    }

}
