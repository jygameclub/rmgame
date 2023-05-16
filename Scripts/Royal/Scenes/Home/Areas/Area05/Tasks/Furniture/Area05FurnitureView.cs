using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area05.Tasks.Furniture
{
    public class Area05FurnitureView : AreaTaskView
    {
        // Fields
        public UnityEngine.Transform table;
        public UnityEngine.SpriteRenderer[] tableShadows;
        public UnityEngine.Transform purpleBase;
        public UnityEngine.Transform book;
        public UnityEngine.SpriteRenderer bookShadow;
        public UnityEngine.Transform vellum;
        public UnityEngine.SpriteRenderer vellumShadow;
        public UnityEngine.Transform nameTag;
        public UnityEngine.Transform pencils;
        public UnityEngine.SpriteRenderer pencilsShadow;
        public UnityEngine.Transform lamp;
        public UnityEngine.SpriteRenderer lampShadow;
        public UnityEngine.Transform chair;
        public UnityEngine.SpriteRenderer chairShadow;
        
        // Methods
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.DisableAll();
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            this.PlayDefaultAnimationSound();
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.AnimateTable());
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.AnimatePurple());
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.AnimateNameTag());
            return val_1;
        }
        private DG.Tweening.Sequence AnimateNameTag()
        {
            UnityEngine.Vector3 val_1 = this.book.localPosition;
            UnityEngine.Vector3 val_2 = this.book.localPosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.1f);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Vector3 val_6 = this.book.localPosition;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  0.8f);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            this.book.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            UnityEngine.Vector3 val_10 = this.chair.localPosition;
            this.chair.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            DG.Tweening.Sequence val_11 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Sequence>(t:  val_11, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area05.Tasks.Furniture.Area05FurnitureView::<AnimateNameTag>b__16_0()));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_11, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.nameTag, endValue:  1f, duration:  0.3f), ease:  27, overshoot:  3f));
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_11, atPosition:  0.25f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.vellum, endValue:  1f, duration:  0.2f), ease:  27, overshoot:  2f));
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_11, atPosition:  0.25f, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.vellumShadow, endValue:  1f, duration:  0.2f));
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_11, atPosition:  0.3f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.pencils, endValue:  1f, duration:  0.2f), ease:  27));
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_11, atPosition:  0.3f, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.pencilsShadow, endValue:  1f, duration:  0.2f));
            DG.Tweening.Sequence val_29 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_11, atPosition:  0.4f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.lamp, endValue:  1f, duration:  0.2f), ease:  27, overshoot:  2.5f));
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_11, atPosition:  0.4f, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.lampShadow, endValue:  1f, duration:  0.15f));
            DG.Tweening.Sequence val_33 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_11, atPosition:  0.4f, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.book, endValue:  1f, duration:  0.2f));
            DG.Tweening.Sequence val_34 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_37 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_34, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.book, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  0.15f, snapping:  false), ease:  2));
            DG.Tweening.Sequence val_40 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_34, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.book, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.05f, snapping:  false), ease:  3));
            DG.Tweening.Sequence val_43 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_34, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.book, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  0.05f, snapping:  false), ease:  2));
            DG.Tweening.Sequence val_45 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_34, atPosition:  0.1f, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.bookShadow, endValue:  1f, duration:  0.2f));
            DG.Tweening.Sequence val_46 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_11, atPosition:  0.55f, t:  val_34);
            UnityEngine.Vector3 val_47 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_50 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_11, atPosition:  0.6f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.chair, endValue:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z}, duration:  0.2f), ease:  27, overshoot:  1f));
            DG.Tweening.Sequence val_53 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_11, atPosition:  0.9f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.chair, endValue:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, duration:  0.25f, snapping:  false), ease:  4));
            return val_11;
        }
        private DG.Tweening.Sequence AnimatePurple()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Sequence>(t:  val_1, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area05.Tasks.Furniture.Area05FurnitureView::<AnimatePurple>b__17_0()));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.purpleBase, endValue:  1f, duration:  0.15f), ease:  27));
            return val_1;
        }
        private DG.Tweening.Sequence AnimateTable()
        {
            var val_32;
            UnityEngine.Vector3 val_2 = this.table.transform.localPosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.table.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  0.3f);
            this.table.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            if(this.tableShadows.Length >= 1)
            {
                    do
            {
                this.tableShadows[0].color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
                val_32 = 0 + 1;
            }
            while(val_32 < this.tableShadows.Length);
            
            }
            
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            DG.Tweening.Sequence val_8 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Sequence>(t:  val_8, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area05.Tasks.Furniture.Area05FurnitureView::<AnimateTable>b__18_0()));
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_8, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.table.transform, endValue:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, duration:  0.15f));
            int val_33 = this.tableShadows.Length;
            if(val_33 >= 1)
            {
                    val_33 = val_33 & 4294967295;
                do
            {
                DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_8, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  null, endValue:  1f, duration:  0.15f), delay:  0.1f));
                val_32 = 0 + 1;
            }
            while(val_32 < (this.tableShadows.Length << ));
            
            }
            
            DG.Tweening.Sequence val_18 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_18, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.table.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.15f, snapping:  false), ease:  2));
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_18, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.table.transform, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  0.05f, snapping:  false), ease:  3));
            DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_18, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.table.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.05f, snapping:  false), ease:  2));
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_8, atPosition:  0.15f, t:  val_18);
            return val_8;
        }
        private void DisableAll()
        {
            this.table.gameObject.SetActive(value:  false);
            if(this.tableShadows.Length >= 1)
            {
                    var val_16 = 0;
                do
            {
                this.tableShadows[val_16].gameObject.SetActive(value:  false);
                val_16 = val_16 + 1;
            }
            while(val_16 < this.tableShadows.Length);
            
            }
            
            this.purpleBase.gameObject.SetActive(value:  false);
            this.book.gameObject.SetActive(value:  false);
            this.bookShadow.gameObject.SetActive(value:  false);
            this.vellum.gameObject.SetActive(value:  false);
            this.vellumShadow.gameObject.SetActive(value:  false);
            this.nameTag.gameObject.SetActive(value:  false);
            this.pencils.gameObject.SetActive(value:  false);
            this.pencilsShadow.gameObject.SetActive(value:  false);
            this.lamp.gameObject.SetActive(value:  false);
            this.lampShadow.gameObject.SetActive(value:  false);
            this.chair.gameObject.SetActive(value:  false);
            this.chairShadow.gameObject.SetActive(value:  false);
        }
        public Area05FurnitureView()
        {
        
        }
        private void <AnimateNameTag>b__16_0()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.nameTag.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            this.nameTag.gameObject.SetActive(value:  true);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.vellum.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.vellum.gameObject.SetActive(value:  true);
            this.vellumShadow.gameObject.SetActive(value:  true);
            this.vellumShadow.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.right;
            this.pencils.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            this.pencils.gameObject.SetActive(value:  true);
            this.pencilsShadow.gameObject.SetActive(value:  true);
            this.pencilsShadow.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            this.lamp.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            this.lamp.gameObject.SetActive(value:  true);
            this.lampShadow.gameObject.SetActive(value:  true);
            this.lampShadow.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
            this.book.localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            this.book.gameObject.SetActive(value:  true);
            this.bookShadow.gameObject.SetActive(value:  true);
            this.bookShadow.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
            this.chair.localScale = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
            this.chair.gameObject.SetActive(value:  true);
            this.chairShadow.gameObject.SetActive(value:  true);
        }
        private void <AnimatePurple>b__17_0()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.purpleBase.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            this.purpleBase.gameObject.SetActive(value:  true);
        }
        private void <AnimateTable>b__18_0()
        {
            this.table.gameObject.SetActive(value:  true);
            if(this.tableShadows.Length < 1)
            {
                    return;
            }
            
            var val_4 = 0;
            do
            {
                this.tableShadows[val_4].gameObject.SetActive(value:  true);
                val_4 = val_4 + 1;
            }
            while(val_4 < this.tableShadows.Length);
        
        }
    
    }

}
