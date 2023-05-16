using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.Loading.View
{
    public class ShopLoadingView : MonoBehaviour
    {
        // Fields
        public UnityEngine.SpriteRenderer background;
        public Spine.Unity.SkeletonAnimation shopLoadingSkeleton;
        public Spine.Unity.AnimationReferenceAsset shopLoadingRef;
        private DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> tween;
        
        // Methods
        public void Show()
        {
            Royal.Infrastructure.Contexts.Units.CameraManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_1.cameraWidth, y:  val_1.cameraHeight);
            this.background.size = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
            this.transform.SetParent(p:  val_1.camera.transform);
            val_1.camera.gameObject.SetActive(value:  true);
            this.shopLoadingSkeleton.state.SetAnimation(trackIndex:  1, animation:  Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  this.shopLoadingRef), loop:  true) = 0;
            this.shopLoadingSkeleton.Update(deltaTime:  UnityEngine.Time.deltaTime);
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_9 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
        }
        public void Hide()
        {
            UnityEngine.Object.Destroy(obj:  this.gameObject);
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            throw new NullReferenceException();
        }
        public ShopLoadingView()
        {
        
        }
    
    }

}
