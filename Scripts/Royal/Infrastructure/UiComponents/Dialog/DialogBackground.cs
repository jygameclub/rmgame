using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Dialog
{
    public class DialogBackground : UiPanel
    {
        // Fields
        private const DG.Tweening.Ease Easing = 9;
        public UnityEngine.SpriteRenderer background;
        public UnityEngine.BoxCollider2D boxCollider2D;
        private Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        private UnityEngine.Vector2 touchDownPosition;
        private Royal.Infrastructure.UiComponents.Dialog.DialogManager dialogManager;
        private Royal.Scenes.Game.Context.Units.GameTouchListener touchListener;
        private DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> backgroundTween;
        
        // Methods
        public void Awake()
        {
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            UnityEngine.Vector2 val_3 = this.camManager.GetCenterPosition();
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            this.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  this.camManager.cameraHeight);
            this.background.size = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  this.camManager.cameraHeight);
            this.boxCollider2D.size = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_7 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetDialogBackgroundSorting();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.background, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_7.layer, order = val_7.order, sortEverything = val_7.sortEverything & 4294967295});
            this.gameObject.SetActive(value:  false);
        }
        public void Init(Royal.Infrastructure.UiComponents.Dialog.DialogManager manager)
        {
            this.dialogManager = manager;
            if(manager.managerType != 1)
            {
                    return;
            }
            
            this.touchListener = Royal.Scenes.Game.Context.GameContext.Get<Royal.Scenes.Game.Context.Units.GameTouchListener>(id:  0);
        }
        public void Show()
        {
            var val_2;
            float val_3;
            float val_4;
            float val_5;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.dialogManager.GetActiveDialogConfig();
            if(this.touchListener != null)
            {
                    this.touchListener.DisableTouch();
            }
            
            if(((ulong)(val_2 >> 40) & 255) == 0)
            {
                    if(this.gameObject.activeSelf == true)
            {
                    return;
            }
            
            }
            
            UnityEngine.Color val_8 = UnityEngine.Color.black;
            if(val_4 > 0f)
            {
                    if(((ulong)(val_2 >> 40) & 255) == 0)
            {
                    UnityEngine.Color val_9 = UnityEngine.Color.clear;
                this.background.color = new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a};
            }
            
                this.SetPositionAndActivate();
                this.backgroundTween = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOColor(target:  this.background, endValue:  new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_5}, duration:  val_4), ease:  9), delay:  val_3);
                return;
            }
            
            if(this.backgroundTween != null)
            {
                    if((DG.Tweening.TweenExtensions.IsActive(t:  this.backgroundTween)) != false)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.backgroundTween, complete:  false);
                this.backgroundTween = 0;
            }
            
            }
            
            this.background.color = new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_5};
            this.SetPositionAndActivate();
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
            var val_2;
            float val_3;
            float val_4;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.dialogManager.GetActiveDialogConfig();
            if(val_2 != false)
            {
                    if(val_3 > 0f)
            {
                    DG.Tweening.Sequence val_5 = DG.Tweening.DOTween.Sequence();
                DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Sequence>(t:  val_5, delay:  val_4);
                UnityEngine.Color val_7 = UnityEngine.Color.clear;
                DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_5, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOColor(target:  this.background, endValue:  new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a}, duration:  val_3), ease:  9));
                DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_5, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Infrastructure.UiComponents.Dialog.DialogBackground::<Hide>b__12_0()));
                return;
            }
            
                this.gameObject.SetActive(value:  false);
            }
            
            if(this.touchListener == null)
            {
                    return;
            }
            
            this.touchListener.EnableTouch();
        }
        public override void TouchDown(UnityEngine.Vector2 position)
        {
            this.touchDownPosition = position;
            mem[1152921527523906636] = position.y;
        }
        public override void TouchUp(UnityEngine.Vector2 position)
        {
            var val_2;
            var val_3;
            var val_4;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.dialogManager.GetActiveDialogConfig();
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this.touchDownPosition, y = V10.16B}, b:  new UnityEngine.Vector2() {x = position.x, y = position.y});
            if(val_5.x <= 0.5f)
            {
                goto label_4;
            }
            
            if(val_3 == true)
            {
                goto label_5;
            }
            
            return;
            label_4:
            if(val_4 != false)
            {
                    this.dialogManager.CloseDialog(uiDialog:  0, fast:  true);
            }
            
            if(val_2 == false)
            {
                    return;
            }
            
            label_5:
            this.dialogManager.CloseDialog(uiDialog:  0, fast:  false);
        }
        public DialogBackground()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <Hide>b__12_0()
        {
            this.gameObject.SetActive(value:  false);
            if(this.touchListener == null)
            {
                    return;
            }
            
            this.touchListener.EnableTouch();
        }
    
    }

}
