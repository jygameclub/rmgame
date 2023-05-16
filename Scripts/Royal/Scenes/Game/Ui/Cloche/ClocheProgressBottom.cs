using UnityEngine;

namespace Royal.Scenes.Game.Ui.Cloche
{
    public class ClocheProgressBottom : ClocheProgress
    {
        // Fields
        public UnityEngine.ParticleSystem failParticles;
        public UnityEngine.SpriteRenderer reflectionSprite;
        public UnityEngine.ParticleSystem winParticles;
        
        // Methods
        public override void PlayAnimation()
        {
            string val_7;
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.ProgressBarCoroutine(startProgress:  V0.16B, endProgress:  V0.16B, duration:  0.5f, onComplete:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Cloche.ClocheProgress::UpdateProgressValue())));
            mem[1152921519937286472] = Royal.Player.Context.Data.Session.__il2cppRuntimeField_60 + 24;
            if(IsWin != false)
            {
                    val_7 = "PlayClocheWinAnimation";
            }
            else
            {
                    val_7 = "PlayClocheFailAnimation";
            }
            
            this.Invoke(methodName:  val_7, time:  0.5f);
            Royal.Player.Context.Data.Session.__il2cppRuntimeField_60.Consume();
        }
        protected override void PrepareClocheSpritePosition()
        {
            this.reflectionSprite.sprite = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  "reflection_" + true);
            UnityEngine.Transform val_3 = this.reflectionSprite.transform;
            UnityEngine.Vector3 val_4 = val_3.position;
            val_3.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = 0f, z = val_4.z};
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            val_3.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            this.reflectionSprite.transform.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            goto (36596648 + (UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished) << 2 + 36596648);
        }
        protected override float GetRatioForCloche(int cloche)
        {
            if(cloche > 2)
            {
                    return 1f;
            }
            
            return (float)36596832 + (cloche) << 2;
        }
        private void PlayClocheWinAnimation()
        {
            this.winParticles.Play();
            this.winParticles.PlaySound(type:  67, offset:  0.04f);
            this.UpdateCloche();
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Vector3 val_2 = val_1.localScale;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  1.2f);
            val_1.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_7 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_1, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.5f), ease:  3), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Cloche.ClocheProgressBottom::<PlayClocheWinAnimation>b__6_0()));
        }
        private void PlayClocheFailAnimation()
        {
            .<>4__this = this;
            this.failParticles.Play();
            this.failParticles.PlaySound(type:  68, offset:  0.04f);
            UnityEngine.Transform val_2 = this.failParticles.transform;
            .transform1 = val_2;
            UnityEngine.Vector3 val_3 = val_2.localScale;
            .localScale = val_3;
            mem[1152921519937948796] = val_3.y;
            mem[1152921519937948800] = val_3.z;
            DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  0.8f);
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (ClocheProgressBottom.<>c__DisplayClass7_0)[1152921519937948768].transform1, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  0.1f), ease:  2));
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_4, callback:  new DG.Tweening.TweenCallback(object:  new ClocheProgressBottom.<>c__DisplayClass7_0(), method:  System.Void ClocheProgressBottom.<>c__DisplayClass7_0::<PlayClocheFailAnimation>b__0()));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (ClocheProgressBottom.<>c__DisplayClass7_0)[1152921519937948768].transform1, endValue:  new UnityEngine.Vector3() {x = (ClocheProgressBottom.<>c__DisplayClass7_0)[1152921519937948768].localScale, y = val_6.y, z = val_6.z}, duration:  0.1f), ease:  27));
        }
        public ClocheProgressBottom()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <PlayClocheWinAnimation>b__6_0()
        {
            this.gameObject.SetActive(value:  true);
        }
    
    }

}
