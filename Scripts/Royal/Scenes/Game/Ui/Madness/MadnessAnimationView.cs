using UnityEngine;

namespace Royal.Scenes.Game.Ui.Madness
{
    public class MadnessAnimationView : ItemParticles
    {
        // Fields
        private const float MoveLimit = 0.1;
        public UnityEngine.SpriteRenderer propellerCollect;
        private Royal.Scenes.Game.Mechanics.Items.Config.ItemModel itemModel;
        private float delaySeconds;
        private UnityEngine.Vector3 initialPosition;
        private float delayElapsed;
        private bool didStartAnimation;
        private bool isItemMoving;
        
        // Methods
        public void StartAnimation(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel itemModel, UnityEngine.Vector3 targetPos, int animationDelayInFrames)
        {
            this.itemModel = itemModel;
            this.delaySeconds = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  (float)animationDelayInFrames);
            this.initialPosition = targetPos;
            mem[1152921519895669344] = targetPos.y;
            mem[1152921519895669348] = targetPos.z;
        }
        private void Update()
        {
            float val_3;
            if(this.didStartAnimation == true)
            {
                    return;
            }
            
            if((this.itemModel & 1) != 0)
            {
                    val_3 = V0.16B;
                UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = this.initialPosition, y = V11.16B, z = V10.16B});
                if(val_1.x <= 0.1f)
            {
                    val_3 = this.delayElapsed;
                if(val_3 < 0)
            {
                    float val_2 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
                val_2 = val_3 + val_2;
                this.delayElapsed = val_2;
                return;
            }
            
            }
            
                if(val_1.x > 0.1f)
            {
                    this.isItemMoving = true;
            }
            
            }
            
            this.didStartAnimation = true;
            this.PlayAnimation();
        }
        private void PlayAnimation()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
            var val_2 = (this.isItemMoving == false) ? 1 : 0;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  36532584 + this.isItemMoving == false ? 1 : 0);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.initialPosition, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            this.propellerCollect.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_6, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.propellerCollect.transform, endValue:  1f, duration:  0.7f), ease:  27, overshoot:  1f));
            UnityEngine.Vector3 val_13 = this.propellerCollect.transform.localPosition;
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_6, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.propellerCollect.transform, endValue:  val_13.y + 2f, duration:  1f, snapping:  false), ease:  5));
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_6, atPosition:  0.6f, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.propellerCollect, endValue:  0f, duration:  0.4f));
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_6, atPosition:  2f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Madness.MadnessAnimationView::Clear()));
        }
        private void Clear()
        {
            goto typeof(Royal.Scenes.Game.Ui.Madness.MadnessAnimationView).__il2cppRuntimeField_1B0;
        }
        public override int GetPoolId()
        {
            return 96;
        }
        public override void OnRecycle()
        {
            this.OnRecycle();
            UnityEngine.Color val_1 = this.propellerCollect.color;
            this.propellerCollect.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = 1f};
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.propellerCollect.transform.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            this.propellerCollect.transform.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            this.delayElapsed = 0f;
            this.didStartAnimation = false;
            this.isItemMoving = false;
        }
        public MadnessAnimationView()
        {
        
        }
    
    }

}
