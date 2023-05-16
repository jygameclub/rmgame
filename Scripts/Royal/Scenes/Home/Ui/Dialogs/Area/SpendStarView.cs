using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Area
{
    public class SpendStarView : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject starObject;
        public UnityEngine.GameObject starImage;
        public UnityEngine.SpriteRenderer starShadow;
        public UnityEngine.ParticleSystem starHitParticles;
        public UnityEngine.ParticleSystem starTrailParticles;
        private int price;
        private UnityEngine.Transform hitTransform;
        private System.Action onAnimationComplete;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        
        // Methods
        public void Play(UnityEngine.Transform hitTrans, int count = 0, System.Action onComplete)
        {
            var val_11;
            .<>4__this = this;
            this.onAnimationComplete = onComplete;
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.price = count;
            this.hitTransform = hitTrans;
            UnityEngine.Vector3 val_3 = hitTrans.position;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            .endPosition = val_4;
            mem[1152921519545339012] = val_4.y;
            mem[1152921519545339016] = val_4.z;
            val_11 = null;
            val_11 = null;
            .starInfoView = null;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  1.1f);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_10 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  Royal.Scenes.Home.Ui.__il2cppRuntimeField_40.transform, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  0.1f), action:  new DG.Tweening.TweenCallback(object:  new SpendStarView.<>c__DisplayClass9_0(), method:  System.Void SpendStarView.<>c__DisplayClass9_0::<Play>b__0()));
        }
        private System.Collections.IEnumerator PlayAnimation(UnityEngine.Vector2 endPosition)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .endPosition = endPosition;
            mem[1152921519545479692] = endPosition.y;
            return (System.Collections.IEnumerator)new SpendStarView.<PlayAnimation>d__10();
        }
        public SpendStarView()
        {
        
        }
        private void <PlayAnimation>b__10_0()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_2 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.hitTransform, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  0.075f);
        }
    
    }

}
