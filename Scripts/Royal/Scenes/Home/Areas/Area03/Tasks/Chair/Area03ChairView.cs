using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area03.Tasks.Chair
{
    public class Area03ChairView : AreaTaskView
    {
        // Fields
        public UnityEngine.GameObject topChair;
        public UnityEngine.GameObject[] leftChairs;
        public UnityEngine.GameObject[] rightChairs;
        public UnityEngine.GameObject bottomChair;
        public float distance;
        public float scaleDuration;
        public float duration;
        public float delay;
        public DG.Tweening.Ease easing;
        
        // Methods
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.DisableChairs();
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.2f);
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.22f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            this.ScaleChairs(seq:  val_1);
            this.MoveChairs(seq:  val_1);
            return val_1;
        }
        private void ScaleChairs(DG.Tweening.Sequence seq)
        {
            var val_22 = 0;
            label_10:
            if(val_22 >= this.leftChairs.Length)
            {
                goto label_2;
            }
            
            .<>4__this = this;
            UnityEngine.GameObject val_21 = this.leftChairs[val_22];
            .leftChair = val_21;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            val_21.transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  seq, callback:  new DG.Tweening.TweenCallback(object:  new Area03ChairView.<>c__DisplayClass11_0(), method:  System.Void Area03ChairView.<>c__DisplayClass11_0::<ScaleChairs>b__1()));
            val_22 = val_22 + 1;
            if(this.leftChairs != null)
            {
                goto label_10;
            }
            
            label_2:
            var val_24 = 0;
            label_21:
            if(val_24 >= this.rightChairs.Length)
            {
                goto label_13;
            }
            
            .<>4__this = this;
            UnityEngine.GameObject val_23 = this.rightChairs[val_24];
            .rightChair = val_23;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            val_23.transform.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  seq, callback:  new DG.Tweening.TweenCallback(object:  new Area03ChairView.<>c__DisplayClass11_1(), method:  System.Void Area03ChairView.<>c__DisplayClass11_1::<ScaleChairs>b__2()));
            val_24 = val_24 + 1;
            if(this.rightChairs != null)
            {
                goto label_21;
            }
            
            label_13:
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  seq, interval:  this.scaleDuration);
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  seq, interval:  this.delay);
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.zero;
            this.bottomChair.transform.localScale = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
            this.topChair.transform.localScale = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  seq, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area03.Tasks.Chair.Area03ChairView::<ScaleChairs>b__11_0()));
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  seq, interval:  this.scaleDuration);
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  seq, interval:  this.delay);
        }
        private void MoveChairs(DG.Tweening.Sequence seq)
        {
            float val_42;
            float val_43;
            float val_44;
            float val_45;
            Area03ChairView.<>c__DisplayClass12_0 val_1 = new Area03ChairView.<>c__DisplayClass12_0();
            .<>4__this = this;
            UnityEngine.Vector3 val_3 = this.bottomChair.transform.localPosition;
            .bottomInitialPos = val_3;
            mem[1152921519781340540] = val_3.y;
            mem[1152921519781340544] = val_3.z;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  this.distance);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (Area03ChairView.<>c__DisplayClass12_0)[1152921519781340512].bottomInitialPos, y = V9.16B, z = V8.16B}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            val_42 = val_7.y;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  this.distance);
            val_43 = val_42;
            val_44 = val_7.z;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_43, z = val_44}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            this.bottomChair.transform.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  seq, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03ChairView.<>c__DisplayClass12_0::<MoveChairs>b__0()));
            val_45 = this.delay;
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  seq, interval:  val_45);
            int val_14 = this.rightChairs.Length - 1;
            if(>=0)
            {
                    do
            {
                .CS$<>8__locals1 = val_1;
                UnityEngine.GameObject val_42 = this.rightChairs[(long)val_14];
                .rightChair = val_42;
                .leftChair = this.leftChairs[(long)val_14];
                UnityEngine.Vector3 val_17 = val_42.transform.localPosition;
                .rightInitialPosition = val_17;
                mem[1152921519781410172] = val_17.y;
                mem[1152921519781410176] = val_17.z;
                UnityEngine.Vector3 val_19 = UnityEngine.Vector3.left;
                UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, d:  this.distance);
                UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (Area03ChairView.<>c__DisplayClass12_1)[1152921519781410144].rightInitialPosition, y = val_42, z = val_7.x}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
                (Area03ChairView.<>c__DisplayClass12_1)[1152921519781410144].rightChair.transform.localPosition = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z};
                UnityEngine.Vector3 val_23 = (Area03ChairView.<>c__DisplayClass12_1)[1152921519781410144].leftChair.transform.localPosition;
                .leftInitialPosition = val_23;
                mem[1152921519781410196] = val_23.y;
                mem[1152921519781410200] = val_23.z;
                UnityEngine.Vector3 val_25 = UnityEngine.Vector3.right;
                UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, d:  this.distance);
                val_43 = val_42;
                val_44 = (Area03ChairView.<>c__DisplayClass12_1)[1152921519781410144].rightInitialPosition;
                UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (Area03ChairView.<>c__DisplayClass12_1)[1152921519781410144].leftInitialPosition, y = val_43, z = val_44}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
                (Area03ChairView.<>c__DisplayClass12_1)[1152921519781410144].leftChair.transform.localPosition = new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z};
                DG.Tweening.Sequence val_29 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  seq, callback:  new DG.Tweening.TweenCallback(object:  new Area03ChairView.<>c__DisplayClass12_1(), method:  System.Void Area03ChairView.<>c__DisplayClass12_1::<MoveChairs>b__2()));
                val_45 = this.delay;
                DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  seq, interval:  val_45);
                val_14 = val_14 - 1;
            }
            while(val_14 >= 0);
            
            }
            
            UnityEngine.Vector3 val_32 = this.topChair.transform.localPosition;
            .topInitialPos = val_32;
            mem[1152921519781340552] = val_32.y;
            mem[1152921519781340556] = val_32.z;
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, d:  this.distance);
            UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (Area03ChairView.<>c__DisplayClass12_0)[1152921519781340512].topInitialPos, y = val_42, z = (Area03ChairView.<>c__DisplayClass12_1)[1152921519781410144].leftInitialPosition}, b:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z});
            UnityEngine.Vector3 val_37 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z}, d:  this.distance);
            UnityEngine.Vector3 val_39 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z}, b:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z});
            this.topChair.transform.localPosition = new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z};
            DG.Tweening.Sequence val_41 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  seq, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03ChairView.<>c__DisplayClass12_0::<MoveChairs>b__1()));
        }
        private void DisableChairs()
        {
            this.topChair.SetActive(value:  false);
            this.bottomChair.SetActive(value:  false);
            var val_4 = 0;
            label_7:
            if(val_4 >= this.leftChairs.Length)
            {
                goto label_3;
            }
            
            this.leftChairs[val_4].gameObject.SetActive(value:  false);
            val_4 = val_4 + 1;
            if(this.leftChairs != null)
            {
                goto label_7;
            }
            
            label_3:
            var val_6 = 0;
            do
            {
                if(val_6 >= this.rightChairs.Length)
            {
                    return;
            }
            
                this.rightChairs[val_6].gameObject.SetActive(value:  false);
                val_6 = val_6 + 1;
            }
            while(this.rightChairs != null);
            
            throw new NullReferenceException();
        }
        public Area03ChairView()
        {
            this.easing = 27;
            this.distance = ;
            this.scaleDuration = ;
            this.duration = 0.3f;
            this.delay = 0.1f;
        }
        private void <ScaleChairs>b__11_0()
        {
            this.bottomChair.SetActive(value:  true);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.bottomChair.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  this.scaleDuration), ease:  this.easing);
            this.topChair.SetActive(value:  true);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.topChair.transform, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  this.scaleDuration), ease:  this.easing);
        }
    
    }

}
