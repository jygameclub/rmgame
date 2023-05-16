using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area04.Tasks.Lamps
{
    public class Area04SingleLampWithShadowView : Area04SingleLampView
    {
        // Fields
        public UnityEngine.SpriteRenderer shadow;
        
        // Methods
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = this.PlayAnimation();
            this.shadow.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.15f, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.shadow, endValue:  1f, duration:  0.15f));
            return val_1;
        }
        public Area04SingleLampWithShadowView()
        {
            mem[1152921519740530432] = 1056964608;
            mem[1152921519740530416] = ;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
