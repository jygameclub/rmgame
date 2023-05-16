using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness
{
    public class MadnessButtonRewardView : MadnessRewardView
    {
        // Fields
        private UnityEngine.Transform levelButtonFrame;
        
        // Methods
        protected override void Awake()
        {
            var val_3;
            this.Awake();
            val_3 = null;
            val_3 = null;
            this.levelButtonFrame = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg + 136.transform.parent;
        }
        public override DG.Tweening.Sequence PlayCollectAnimation(Royal.Player.Context.Units.MadnessStep stepConfig)
        {
            return this.SendGiftToButton(duration:  0.65f);
        }
        private DG.Tweening.Sequence SendGiftToButton(float duration)
        {
            UnityEngine.Vector3 val_2 = this.transform.localScale;
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_6 = this.levelButtonFrame.transform.position;
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_3, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  duration, snapping:  false), ease:  26));
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.65f);
            float val_17 = 0.7f;
            val_17 = duration * val_17;
            float val_18 = 0.3f;
            val_18 = duration * val_18;
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_3, atPosition:  val_18, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.levelButtonFrame.transform, endValue:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, duration:  val_17), ease:  2));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_3, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Madness.MadnessButtonRewardView::<SendGiftToButton>b__3_0()));
            return val_3;
        }
        private void PlayButtonHitAnimation()
        {
            MadnessButtonRewardView.<>c__DisplayClass4_0 val_1 = new MadnessButtonRewardView.<>c__DisplayClass4_0();
            .<>4__this = this;
            UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "EpisodeRewardHitParticles"));
            .hitParticles = val_3;
            UnityEngine.Vector3 val_6 = this.levelButtonFrame.transform.position;
            val_3.transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            if(val_7.Length >= 1)
            {
                    var val_36 = 0;
                do
            {
                (MadnessButtonRewardView.<>c__DisplayClass4_0)[1152921519348073696].hitParticles.GetComponentsInChildren<UnityEngine.ParticleSystem>()[val_36].Play();
                val_36 = val_36 + 1;
            }
            while(val_36 < val_7.Length);
            
            }
            
            DG.Tweening.Sequence val_8 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  1.04f, y:  0.97f);
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, b:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
            UnityEngine.Vector3 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_8, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.levelButtonFrame, endValue:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, duration:  0.05f));
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_8, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void MadnessButtonRewardView.<>c__DisplayClass4_0::<PlayButtonHitAnimation>b__0()));
            UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  0.98f, y:  1.02f);
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y}, b:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
            UnityEngine.Vector3 val_21 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_8, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.levelButtonFrame, endValue:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, duration:  0.075f));
            UnityEngine.Vector2 val_24 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            UnityEngine.Vector2 val_25 = new UnityEngine.Vector2(x:  1.01f, y:  0.99f);
            UnityEngine.Vector2 val_26 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_24.x, y = val_24.y}, b:  new UnityEngine.Vector2() {x = val_25.x, y = val_25.y});
            UnityEngine.Vector3 val_27 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_26.x, y = val_26.y});
            DG.Tweening.Sequence val_29 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_8, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.levelButtonFrame, endValue:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, duration:  0.06f));
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_8, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.levelButtonFrame, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  0.05f));
            DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_8, interval:  2f);
            DG.Tweening.Sequence val_34 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_8, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void MadnessButtonRewardView.<>c__DisplayClass4_0::<PlayButtonHitAnimation>b__1()));
        }
        public MadnessButtonRewardView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <SendGiftToButton>b__3_0()
        {
            this.PlayButtonHitAnimation();
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
    
    }

}
