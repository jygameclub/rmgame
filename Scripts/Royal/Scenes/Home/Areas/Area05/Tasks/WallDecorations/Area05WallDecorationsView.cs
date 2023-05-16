using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area05.Tasks.WallDecorations
{
    public class Area05WallDecorationsView : AreaTaskView
    {
        // Fields
        public UnityEngine.GameObject kingPainting;
        public UnityEngine.Animator kingPaintingAnimator;
        public UnityEngine.SpriteRenderer hammerShadow;
        public UnityEngine.Transform hammerFrame;
        public UnityEngine.Transform hammer;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            this.kingPaintingAnimator.enabled = false;
        }
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.kingPainting.gameObject.SetActive(value:  false);
            this.hammerShadow.gameObject.SetActive(value:  false);
            this.hammerFrame.gameObject.SetActive(value:  false);
            this.hammer.gameObject.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            Area05WallDecorationsView.<>c__DisplayClass7_0 val_1 = new Area05WallDecorationsView.<>c__DisplayClass7_0();
            .<>4__this = this;
            this.PlayDefaultAnimationSound();
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            .finalScale = val_3;
            mem[1152921519715314588] = val_3.y;
            mem[1152921519715314592] = val_3.z;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  1.2f);
            this.hammerFrame.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area05WallDecorationsView.<>c__DisplayClass7_0::<PlayAnimation>b__0()));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.3f);
            UnityEngine.Vector3 val_8 = this.hammer.localPosition;
            .finalPosition2 = val_8;
            mem[1152921519715314600] = val_8.y;
            mem[1152921519715314604] = val_8.z;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  0.5f);
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            this.hammer.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = (Area05WallDecorationsView.<>c__DisplayClass7_0)[1152921519715314560].finalScale, y = val_11.y, z = val_11.z}, d:  1.2f);
            this.hammer.localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            this.hammerShadow.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area05WallDecorationsView.<>c__DisplayClass7_0::<PlayAnimation>b__1()));
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.3f);
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area05WallDecorationsView.<>c__DisplayClass7_0::<PlayAnimation>b__2()));
            return val_2;
        }
        public override void EndAnimation()
        {
            this.EndAnimation();
            this.kingPaintingAnimator.enabled = false;
        }
        public Area05WallDecorationsView()
        {
        
        }
    
    }

}
