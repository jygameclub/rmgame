using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area03.Tasks.Servings
{
    public class Area03ServingsView : AreaTaskView
    {
        // Fields
        public UnityEngine.GameObject topPlate;
        public UnityEngine.GameObject bottomPlate;
        public UnityEngine.GameObject[] leftPlatesTop;
        public UnityEngine.GameObject[] rightPlatesTop;
        public UnityEngine.GameObject[] leftPlatesBottom;
        public UnityEngine.GameObject[] rightPlatesBottom;
        public UnityEngine.GameObject leftPlateCenter;
        public UnityEngine.GameObject rightPlateCenter;
        public UnityEngine.GameObject[] topFoods;
        public UnityEngine.GameObject[] bottomFoods;
        public UnityEngine.GameObject fruit;
        public UnityEngine.GameObject cart;
        public UnityEngine.GameObject food;
        public UnityEngine.ParticleSystem[] candleParticles;
        public DG.Tweening.Ease easing;
        public float duration;
        public float delay;
        public float distance;
        public DG.Tweening.Ease foodmover;
        public DG.Tweening.Ease foodScaler;
        public DG.Tweening.Ease cartmover;
        public DG.Tweening.Ease cartScaler;
        public float foodDelay;
        public float foodScaleDuration;
        public float foodInterval;
        public float foodDuration;
        public float cartDelay;
        public float cartScaleDuration;
        public float cartInterval;
        public float cartDuration;
        
        // Methods
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.DisableServings();
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.2f);
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.2f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            this.PlayPlates(seq:  val_1);
            this.PlayFoods(seq:  val_1);
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  (1152921519696123040 == 0) ? 0.2f : 0f);
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area03.Tasks.Servings.Area03ServingsView::PlayCart()));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  1f);
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area03.Tasks.Servings.Area03ServingsView::PlayCandleParticles()));
            return val_1;
        }
        private void PlayServings(DG.Tweening.Sequence seq)
        {
            this.PlayPlates(seq:  seq);
            this.PlayFoods(seq:  seq);
        }
        private void PlayPlates(DG.Tweening.Sequence seq)
        {
            Area03ServingsView.<>c__DisplayClass21_0 val_1 = new Area03ServingsView.<>c__DisplayClass21_0();
            .<>4__this = this;
            UnityEngine.Vector3 val_3 = this.leftPlateCenter.transform.localPosition;
            .leftCenterInitialPos = val_3;
            mem[1152921519760367244] = val_3.y;
            mem[1152921519760367248] = val_3.z;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  this.distance);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (Area03ServingsView.<>c__DisplayClass21_0)[1152921519760367216].leftCenterInitialPos, y = V9.16B, z = V8.16B}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            this.leftPlateCenter.transform.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            UnityEngine.Vector3 val_9 = this.rightPlateCenter.transform.localPosition;
            .rightCenterInitialPos = val_9;
            mem[1152921519760367256] = val_9.y;
            mem[1152921519760367260] = val_9.z;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  this.distance);
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (Area03ServingsView.<>c__DisplayClass21_0)[1152921519760367216].rightCenterInitialPos, y = V9.16B, z = (Area03ServingsView.<>c__DisplayClass21_0)[1152921519760367216].leftCenterInitialPos}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            this.rightPlateCenter.transform.localPosition = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  seq, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03ServingsView.<>c__DisplayClass21_0::<PlayPlates>b__0()));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  seq, interval:  this.delay);
            var val_65 = 4;
            label_41:
            if((val_65 - 4) >= this.leftPlatesBottom.Length)
            {
                goto label_13;
            }
            
            .CS$<>8__locals1 = val_1;
            UnityEngine.GameObject val_61 = this.leftPlatesBottom[0];
            .leftPlateBottom = val_61;
            UnityEngine.Vector3 val_20 = val_61.transform.localPosition;
            .leftInitialPosition = val_20;
            mem[1152921519760453260] = val_20.y;
            mem[1152921519760453264] = val_20.z;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, d:  this.distance);
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (Area03ServingsView.<>c__DisplayClass21_1)[1152921519760453232].leftInitialPosition, y = V9.16B, z = (Area03ServingsView.<>c__DisplayClass21_0)[1152921519760367216].rightCenterInitialPos}, b:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
            (Area03ServingsView.<>c__DisplayClass21_1)[1152921519760453232].leftPlateBottom.transform.localPosition = new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z};
            UnityEngine.GameObject val_62 = this.rightPlatesBottom[0];
            .rightPlateBottom = val_62;
            UnityEngine.Vector3 val_26 = val_62.transform.localPosition;
            .rightInitialPosition = val_26;
            mem[1152921519760453284] = val_26.y;
            mem[1152921519760453288] = val_26.z;
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, d:  this.distance);
            UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (Area03ServingsView.<>c__DisplayClass21_1)[1152921519760453232].rightInitialPosition, y = V9.16B, z = (Area03ServingsView.<>c__DisplayClass21_1)[1152921519760453232].leftInitialPosition}, b:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
            (Area03ServingsView.<>c__DisplayClass21_1)[1152921519760453232].rightPlateBottom.transform.localPosition = new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z};
            UnityEngine.GameObject val_63 = this.leftPlatesTop[0];
            .leftPlateTop = val_63;
            UnityEngine.Vector3 val_32 = val_63.transform.localPosition;
            .leftTopInitialPosition = val_32;
            mem[1152921519760453308] = val_32.y;
            mem[1152921519760453312] = val_32.z;
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, d:  this.distance);
            UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (Area03ServingsView.<>c__DisplayClass21_1)[1152921519760453232].leftTopInitialPosition, y = V9.16B, z = (Area03ServingsView.<>c__DisplayClass21_1)[1152921519760453232].leftInitialPosition}, b:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z});
            (Area03ServingsView.<>c__DisplayClass21_1)[1152921519760453232].leftPlateTop.transform.localPosition = new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z};
            UnityEngine.GameObject val_64 = this.rightPlatesTop[0];
            .rightPlateTop = val_64;
            UnityEngine.Vector3 val_38 = val_64.transform.localPosition;
            .rightTopInitialPosition = val_38;
            mem[1152921519760453332] = val_38.y;
            mem[1152921519760453336] = val_38.z;
            UnityEngine.Vector3 val_40 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_41 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z}, d:  this.distance);
            UnityEngine.Vector3 val_42 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (Area03ServingsView.<>c__DisplayClass21_1)[1152921519760453232].rightTopInitialPosition, y = V9.16B, z = (Area03ServingsView.<>c__DisplayClass21_1)[1152921519760453232].leftInitialPosition}, b:  new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z});
            (Area03ServingsView.<>c__DisplayClass21_1)[1152921519760453232].rightPlateTop.transform.localPosition = new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z};
            DG.Tweening.Sequence val_44 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  seq, callback:  new DG.Tweening.TweenCallback(object:  new Area03ServingsView.<>c__DisplayClass21_1(), method:  System.Void Area03ServingsView.<>c__DisplayClass21_1::<PlayPlates>b__2()));
            DG.Tweening.Sequence val_45 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  seq, interval:  this.delay);
            val_65 = val_65 + 1;
            if(this.leftPlatesBottom != null)
            {
                goto label_41;
            }
            
            label_13:
            UnityEngine.Vector3 val_47 = this.bottomPlate.transform.localPosition;
            .bottomInitialPos = val_47;
            mem[1152921519760367268] = val_47.y;
            mem[1152921519760367272] = val_47.z;
            UnityEngine.Vector3 val_49 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_50 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_49.x, y = val_49.y, z = val_49.z}, d:  this.distance);
            UnityEngine.Vector3 val_51 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (Area03ServingsView.<>c__DisplayClass21_0)[1152921519760367216].bottomInitialPos, y = V9.16B, z = (Area03ServingsView.<>c__DisplayClass21_0)[1152921519760367216].rightCenterInitialPos}, b:  new UnityEngine.Vector3() {x = val_50.x, y = val_50.y, z = val_50.z});
            this.bottomPlate.transform.localPosition = new UnityEngine.Vector3() {x = val_51.x, y = val_51.y, z = val_51.z};
            UnityEngine.Vector3 val_53 = this.topPlate.transform.localPosition;
            .topInitialPos = val_53;
            mem[1152921519760367280] = val_53.y;
            mem[1152921519760367284] = val_53.z;
            UnityEngine.Vector3 val_55 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_56 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_55.x, y = val_55.y, z = val_55.z}, d:  this.distance);
            UnityEngine.Vector3 val_57 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (Area03ServingsView.<>c__DisplayClass21_0)[1152921519760367216].topInitialPos, y = V9.16B, z = (Area03ServingsView.<>c__DisplayClass21_0)[1152921519760367216].bottomInitialPos}, b:  new UnityEngine.Vector3() {x = val_56.x, y = val_56.y, z = val_56.z});
            this.topPlate.transform.localPosition = new UnityEngine.Vector3() {x = val_57.x, y = val_57.y, z = val_57.z};
            DG.Tweening.Sequence val_59 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  seq, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03ServingsView.<>c__DisplayClass21_0::<PlayPlates>b__1()));
            DG.Tweening.Sequence val_60 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  seq, interval:  this.delay);
        }
        private void PlayFoods(DG.Tweening.Sequence seq)
        {
            Area03ServingsView.<>c__DisplayClass22_0 val_1 = new Area03ServingsView.<>c__DisplayClass22_0();
            .<>4__this = this;
            var val_29 = 4;
            label_19:
            if((val_29 - 4) >= this.topFoods.Length)
            {
                goto label_3;
            }
            
            .CS$<>8__locals1 = val_1;
            UnityEngine.GameObject val_27 = this.topFoods[0];
            .topFood = val_27;
            UnityEngine.Vector3 val_5 = val_27.transform.localPosition;
            .topInitialPos = val_5;
            mem[1152921519761153036] = val_5.y;
            mem[1152921519761153040] = val_5.z;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  this.distance);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (Area03ServingsView.<>c__DisplayClass22_1)[1152921519761153008].topInitialPos, y = V9.16B, z = V8.16B}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            (Area03ServingsView.<>c__DisplayClass22_1)[1152921519761153008].topFood.transform.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            UnityEngine.GameObject val_28 = this.bottomFoods[0];
            .bottomFood = val_28;
            UnityEngine.Vector3 val_11 = val_28.transform.localPosition;
            .bottomInitialPos = val_11;
            mem[1152921519761153060] = val_11.y;
            mem[1152921519761153064] = val_11.z;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  this.distance);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (Area03ServingsView.<>c__DisplayClass22_1)[1152921519761153008].bottomInitialPos, y = V9.16B, z = (Area03ServingsView.<>c__DisplayClass22_1)[1152921519761153008].topInitialPos}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            (Area03ServingsView.<>c__DisplayClass22_1)[1152921519761153008].bottomFood.transform.localPosition = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  seq, callback:  new DG.Tweening.TweenCallback(object:  new Area03ServingsView.<>c__DisplayClass22_1(), method:  System.Void Area03ServingsView.<>c__DisplayClass22_1::<PlayFoods>b__1()));
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  seq, interval:  this.delay);
            val_29 = val_29 + 1;
            if(this.topFoods != null)
            {
                goto label_19;
            }
            
            label_3:
            UnityEngine.Vector3 val_20 = this.fruit.transform.localPosition;
            .fruitInitialPos = val_20;
            mem[1152921519761112076] = val_20.y;
            mem[1152921519761112080] = val_20.z;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, d:  this.distance);
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (Area03ServingsView.<>c__DisplayClass22_0)[1152921519761112048].fruitInitialPos, y = V9.16B, z = V8.16B}, b:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
            this.fruit.transform.localPosition = new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z};
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  seq, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03ServingsView.<>c__DisplayClass22_0::<PlayFoods>b__0()));
        }
        private void PlayCart()
        {
            float val_45;
            Area03ServingsView.<>c__DisplayClass35_0 val_1 = new Area03ServingsView.<>c__DisplayClass35_0();
            .<>4__this = this;
            UnityEngine.Vector3 val_3 = this.cart.transform.localPosition;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.cart.transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  0.5f);
            this.cart.transform.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            val_45 = 0f;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            DG.Tweening.Sequence val_10 = DG.Tweening.DOTween.Sequence();
            val_45 = this.cartDelay;
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_10, interval:  val_45);
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_10, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03ServingsView.<>c__DisplayClass35_0::<PlayCart>b__0()));
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_10, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.cart.transform, endValue:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, duration:  0.1f));
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_10, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.cart.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.15f, snapping:  false), ease:  1));
            DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_10, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.cart.transform, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  0.05f, snapping:  false), ease:  1));
            DG.Tweening.Sequence val_29 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_10, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.cart.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.05f, snapping:  false), ease:  1));
            DG.Tweening.Sequence val_30 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_32 = this.food.transform.localPosition;
            .foodInitialPos = val_32;
            mem[1152921519761628556] = val_32.y;
            mem[1152921519761628560] = val_32.z;
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, d:  1f);
            UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (Area03ServingsView.<>c__DisplayClass35_0)[1152921519761628528].foodInitialPos, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z});
            this.food.transform.localPosition = new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z};
            UnityEngine.Vector3 val_38 = UnityEngine.Vector3.zero;
            this.food.transform.localScale = new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z};
            DG.Tweening.Sequence val_39 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_30, interval:  this.foodDelay);
            DG.Tweening.Sequence val_41 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_30, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03ServingsView.<>c__DisplayClass35_0::<PlayCart>b__1()));
            DG.Tweening.Sequence val_42 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_30, interval:  this.foodInterval);
            DG.Tweening.Sequence val_44 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_30, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03ServingsView.<>c__DisplayClass35_0::<PlayCart>b__2()));
        }
        private void PlayCandleParticles()
        {
            var val_6;
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            val_6 = 0;
            do
            {
                if(val_6 >= this.candleParticles.Length)
            {
                    return;
            }
            
                .particle = this.candleParticles[val_6];
                DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  new Area03ServingsView.<>c__DisplayClass36_0(), method:  System.Void Area03ServingsView.<>c__DisplayClass36_0::<PlayCandleParticles>b__0()));
                DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.05f);
                val_6 = val_6 + 1;
            }
            while(this.candleParticles != null);
            
            throw new NullReferenceException();
        }
        private void DisableServings()
        {
            this.topPlate.SetActive(value:  false);
            this.bottomPlate.SetActive(value:  false);
            this.leftPlateCenter.SetActive(value:  false);
            this.rightPlateCenter.SetActive(value:  false);
            var val_3 = 0;
            label_9:
            if(val_3 >= this.candleParticles.Length)
            {
                goto label_5;
            }
            
            this.candleParticles[val_3].gameObject.SetActive(value:  false);
            val_3 = val_3 + 1;
            if(this.candleParticles != null)
            {
                goto label_9;
            }
            
            label_5:
            var val_5 = 0;
            label_15:
            if(val_5 >= this.leftPlatesBottom.Length)
            {
                goto label_12;
            }
            
            this.leftPlatesBottom[val_5].SetActive(value:  false);
            val_5 = val_5 + 1;
            if(this.leftPlatesBottom != null)
            {
                goto label_15;
            }
            
            label_12:
            var val_7 = 0;
            label_21:
            if(val_7 >= this.rightPlatesBottom.Length)
            {
                goto label_18;
            }
            
            this.rightPlatesBottom[val_7].SetActive(value:  false);
            val_7 = val_7 + 1;
            if(this.rightPlatesBottom != null)
            {
                goto label_21;
            }
            
            label_18:
            var val_9 = 0;
            label_27:
            if(val_9 >= this.leftPlatesTop.Length)
            {
                goto label_24;
            }
            
            this.leftPlatesTop[val_9].SetActive(value:  false);
            val_9 = val_9 + 1;
            if(this.leftPlatesTop != null)
            {
                goto label_27;
            }
            
            label_24:
            var val_11 = 0;
            label_33:
            if(val_11 >= this.rightPlatesTop.Length)
            {
                goto label_30;
            }
            
            this.rightPlatesTop[val_11].SetActive(value:  false);
            val_11 = val_11 + 1;
            if(this.rightPlatesTop != null)
            {
                goto label_33;
            }
            
            label_30:
            var val_13 = 0;
            label_39:
            if(val_13 >= this.topFoods.Length)
            {
                goto label_36;
            }
            
            this.topFoods[val_13].SetActive(value:  false);
            val_13 = val_13 + 1;
            if(this.topFoods != null)
            {
                goto label_39;
            }
            
            label_36:
            var val_15 = 0;
            label_45:
            if(val_15 >= this.bottomFoods.Length)
            {
                goto label_42;
            }
            
            this.bottomFoods[val_15].SetActive(value:  false);
            val_15 = val_15 + 1;
            if(this.bottomFoods != null)
            {
                goto label_45;
            }
            
            label_42:
            this.fruit.SetActive(value:  false);
            this.cart.SetActive(value:  false);
            this.food.SetActive(value:  false);
        }
        private void SquashStretch(UnityEngine.GameObject spriteRenderer, float xScale = 1.1, float yScale = 0.9)
        {
            UnityEngine.Vector3 val_2 = spriteRenderer.transform.localScale;
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  spriteRenderer.transform, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.1f));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  spriteRenderer.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.1f));
        }
        public Area03ServingsView()
        {
            this.distance = 0.3f;
            this.cartScaleDuration = 0.25f;
            this.cartInterval = 0.25f;
            this.foodmover = ;
            this.foodScaleDuration = ;
            this.foodInterval = ;
            this.foodDuration = 0.5f;
            this.cartDelay = 0.2f;
            this.cartDuration = 0.2f;
        }
    
    }

}
