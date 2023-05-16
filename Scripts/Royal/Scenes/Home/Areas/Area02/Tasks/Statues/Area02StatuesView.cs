using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area02.Tasks.Statues
{
    public class Area02StatuesView : AreaTaskView
    {
        // Fields
        public UnityEngine.GameObject[] statues;
        public UnityEngine.GameObject[] statueGameItems;
        public UnityEngine.GameObject[] shadows;
        public UnityEngine.GameObject[] reflections;
        public UnityEngine.SpriteRenderer rightStatueCandleShadow;
        
        // Methods
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            var val_10 = 4;
            label_17:
            if((val_10 - 4) >= this.statues.Length)
            {
                goto label_1;
            }
            
            this.statues[0].gameObject.SetActive(value:  false);
            this.statueGameItems[0].gameObject.SetActive(value:  false);
            this.shadows[0].gameObject.SetActive(value:  false);
            this.reflections[0].gameObject.SetActive(value:  false);
            val_10 = val_10 + 1;
            if(this.statues != null)
            {
                goto label_17;
            }
            
            label_1:
            this.rightStatueCandleShadow.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.55f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.2f);
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area02.Tasks.Statues.Area02StatuesView::<PlayAnimation>b__6_0()));
            this.PlayStatueAnimations(seq:  val_1);
            this.PlayStatueItemAnimations(seq:  val_1);
            this.PlayShadowAndReflectionAnimations(seq:  val_1);
            return val_1;
        }
        private void PlayStatueAnimations(DG.Tweening.Sequence seq)
        {
            object val_4;
            var val_5;
            float val_6;
            val_5 = 0;
            do
            {
                if(val_5 >= this.statues.Length)
            {
                    return;
            }
            
                Area02StatuesView.<>c__DisplayClass7_0 val_1 = null;
                val_4 = val_1;
                val_1 = new Area02StatuesView.<>c__DisplayClass7_0();
                .<>4__this = this;
                val_6 = 0.3f;
                .statue = this.statues[val_5];
                if(val_5 <= 4)
            {
                    val_6 = 0.9f;
            }
            
                DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  seq, atPosition:  val_6, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area02StatuesView.<>c__DisplayClass7_0::<PlayStatueAnimations>b__0()));
                val_5 = val_5 + 1;
            }
            while(this.statues != null);
            
            throw new NullReferenceException();
        }
        private void PlayStatueItemAnimations(DG.Tweening.Sequence seq)
        {
            object val_4;
            var val_5;
            float val_6;
            val_5 = 0;
            do
            {
                if(val_5 >= this.statueGameItems.Length)
            {
                    return;
            }
            
                Area02StatuesView.<>c__DisplayClass8_0 val_1 = null;
                val_4 = val_1;
                val_1 = new Area02StatuesView.<>c__DisplayClass8_0();
                .<>4__this = this;
                val_6 = 2.1f;
                .statueGameItem = this.statueGameItems[val_5];
                if(val_5 <= 4)
            {
                    val_6 = 1.7f;
            }
            
                DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  seq, atPosition:  val_6, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area02StatuesView.<>c__DisplayClass8_0::<PlayStatueItemAnimations>b__0()));
                val_5 = val_5 + 1;
            }
            while(this.statueGameItems != null);
            
            throw new NullReferenceException();
        }
        private void PlayShadowAndReflectionAnimations(DG.Tweening.Sequence seq)
        {
            object val_6;
            var val_7;
            float val_8;
            val_7 = 0;
            do
            {
                if(val_7 >= this.shadows.Length)
            {
                    return;
            }
            
                Area02StatuesView.<>c__DisplayClass9_0 val_1 = null;
                val_6 = val_1;
                val_1 = new Area02StatuesView.<>c__DisplayClass9_0();
                .<>4__this = this;
                .shadow = this.shadows[val_7];
                val_8 = 0.5f;
                .reflection = this.reflections[val_7];
                if(val_7 <= 4)
            {
                    val_8 = 1.1f;
            }
            
                DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  seq, atPosition:  val_8, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area02StatuesView.<>c__DisplayClass9_0::<PlayShadowAndReflectionAnimations>b__0()));
                DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  seq, atPosition:  val_8, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area02StatuesView.<>c__DisplayClass9_0::<PlayShadowAndReflectionAnimations>b__1()));
                val_7 = val_7 + 1;
            }
            while(this.shadows != null);
            
            throw new NullReferenceException();
        }
        private void PlayStatueAnimation(UnityEngine.GameObject statue)
        {
            .<>4__this = this;
            .statue = statue;
            UnityEngine.Vector3 val_3 = statue.transform.localPosition;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  2f);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            (Area02StatuesView.<>c__DisplayClass10_0)[1152921519790388848].statue.transform.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_12 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  (Area02StatuesView.<>c__DisplayClass10_0)[1152921519790388848].statue.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.3f, snapping:  false), ease:  14), action:  new DG.Tweening.TweenCallback(object:  new Area02StatuesView.<>c__DisplayClass10_0(), method:  System.Void Area02StatuesView.<>c__DisplayClass10_0::<PlayStatueAnimation>b__0()));
            UnityEngine.Vector3 val_14 = (Area02StatuesView.<>c__DisplayClass10_0)[1152921519790388848].statue.transform.localScale;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
            (Area02StatuesView.<>c__DisplayClass10_0)[1152921519790388848].statue.transform.localScale = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            (Area02StatuesView.<>c__DisplayClass10_0)[1152921519790388848].statue.SetActive(value:  true);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_19 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (Area02StatuesView.<>c__DisplayClass10_0)[1152921519790388848].statue.transform, endValue:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, duration:  0.1f), ease:  2);
        }
        private void PlayStatueItemAnimation(UnityEngine.GameObject statueItem)
        {
            .statueItem = statueItem;
            statueItem.SetActive(value:  true);
            UnityEngine.Vector3 val_3 = (Area02StatuesView.<>c__DisplayClass11_0)[1152921519790632944].statueItem.transform.localScale;
            .initialScale = val_3;
            mem[1152921519790632972] = val_3.y;
            mem[1152921519790632976] = val_3.z;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            (Area02StatuesView.<>c__DisplayClass11_0)[1152921519790632944].statueItem.transform.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_10 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (Area02StatuesView.<>c__DisplayClass11_0)[1152921519790632944].statueItem.transform, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.2f), ease:  4), action:  new DG.Tweening.TweenCallback(object:  new Area02StatuesView.<>c__DisplayClass11_0(), method:  System.Void Area02StatuesView.<>c__DisplayClass11_0::<PlayStatueItemAnimation>b__0()));
        }
        private void PlayShadowAndReflectionAnimations(UnityEngine.GameObject statue)
        {
            UnityEngine.Vector3 val_2 = statue.transform.localScale;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            statue.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            statue.SetActive(value:  true);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  statue.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.1f), ease:  2);
        }
        private void SquashStretch(UnityEngine.SpriteRenderer spriteRenderer, float xScale = 1.1, float yScale = 0.9, float duration = 0.1)
        {
            UnityEngine.Vector3 val_2 = spriteRenderer.transform.localScale;
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  spriteRenderer.transform, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  duration));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  spriteRenderer.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  duration));
        }
        public Area02StatuesView()
        {
        
        }
        private void <PlayAnimation>b__6_0()
        {
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_1 = DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.rightStatueCandleShadow, endValue:  1f, duration:  0.5f);
        }
    
    }

}
