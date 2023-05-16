using UnityEngine;

namespace Royal.Scenes.Game.Ui.Bottom.Boosters
{
    public class BoosterUseBackground : MonoBehaviour
    {
        // Fields
        public UnityEngine.SpriteRenderer background;
        public UnityEngine.BoxCollider2D boxCollider2D;
        private Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        private UnityEngine.Vector2 touchDownPosition;
        private System.Action OnTouched;
        
        // Methods
        public void add_OnTouched(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnTouched, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnTouched != 1152921519950408504);
            
            return;
            label_2:
        }
        public void remove_OnTouched(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnTouched, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnTouched != 1152921519950545080);
            
            return;
            label_2:
        }
        public void Awake()
        {
            Royal.Infrastructure.Contexts.Units.CameraManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.camManager = val_1;
            UnityEngine.Vector2 val_2 = val_1.GetCenterPosition();
            UnityEngine.Vector2 val_3 = this.camManager.GetCenterPosition();
            this.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  this.camManager.cameraHeight);
            this.background.size = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  this.camManager.cameraHeight);
            this.boxCollider2D.size = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
        }
        public Royal.Scenes.Game.Ui.Bottom.Boosters.BoosterUseBackground Init(bool isAboveBoard = True)
        {
            isAboveBoard = isAboveBoard;
            this.SetPositionAndActivate(isAboveBoard:  isAboveBoard);
            UnityEngine.Color val_1 = UnityEngine.Color.clear;
            this.background.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
            UnityEngine.Color val_2 = UnityEngine.Color.black;
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOColor(target:  this.background, endValue:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = 0.85f}, duration:  0.3f), ease:  9);
            this.boxCollider2D.enabled = true;
            return (Royal.Scenes.Game.Ui.Bottom.Boosters.BoosterUseBackground)this;
        }
        private void SetPositionAndActivate(bool isAboveBoard)
        {
            UnityEngine.Vector2 val_1 = this.camManager.GetCenterPosition();
            UnityEngine.Vector2 val_2 = this.camManager.GetCenterPosition();
            var val_3 = (isAboveBoard != true) ? -1f : 1f;
            this.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.gameObject.SetActive(value:  true);
            if(isAboveBoard != false)
            {
                    Royal.Scenes.Game.Mechanics.Sortings.SortingData val_7 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetJesterHatBoosterUseSorting();
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Sortings.SortingData val_8 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetDefaultBoosterUseSorting();
            }
            
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.GetComponent<UnityEngine.Rendering.SortingGroup>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_8.layer, order = val_8.order, sortEverything = val_8.sortEverything & 4294967295});
        }
        public void Hide()
        {
            this.gameObject.SetActive(value:  false);
            this.boxCollider2D.enabled = false;
        }
        public void Touch()
        {
            if(this.OnTouched == null)
            {
                    return;
            }
            
            this.OnTouched.Invoke();
        }
        public BoosterUseBackground()
        {
        
        }
    
    }

}
