using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area06.Tasks.Table
{
    public class Area06TableView : AreaTaskView
    {
        // Fields
        public UnityEngine.Transform table;
        public UnityEngine.SpriteRenderer tableShadow;
        public UnityEngine.Animator tableAnimator;
        public UnityEngine.SpriteRenderer tableCover;
        public UnityEngine.GameObject tableCoverMask;
        public UnityEngine.Transform[] plates;
        public UnityEngine.GameObject[] glasses;
        
        // Methods
        protected override void Awake()
        {
            this.tableAnimator.enabled = false;
            this.tableCoverMask.SetActive(value:  false);
        }
        public override void PrepareAnimation()
        {
            this.PlayFinalParticles();
            this.table.gameObject.SetActive(value:  false);
            this.tableShadow.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            this.tableCoverMask.SetActive(value:  true);
            this.tableCoverMask.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.tableCover.maskInteraction = 1;
            var val_5 = 0;
            label_14:
            if(val_5 >= this.plates.Length)
            {
                goto label_9;
            }
            
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.plates[val_5].localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            val_5 = val_5 + 1;
            if(this.plates != null)
            {
                goto label_14;
            }
            
            label_9:
            var val_7 = 0;
            do
            {
                if(val_7 >= this.glasses.Length)
            {
                    return;
            }
            
                this.glasses[val_7].SetActive(value:  false);
                val_7 = val_7 + 1;
            }
            while(this.glasses != null);
            
            throw new NullReferenceException();
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = this.AnimateTable();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.2f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.3f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area06.Tasks.Table.Area06TableView::<PlayAnimation>b__9_0()));
            this.AnimatePlates(seq:  val_1, time:  1f);
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area06.Tasks.Table.Area06TableView::<PlayAnimation>b__9_1()));
            return val_1;
        }
        private DG.Tweening.Sequence AnimateTable()
        {
            UnityEngine.Transform val_1 = this.table.transform;
            UnityEngine.Vector3 val_2 = val_1.localPosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.table.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  0.5f);
            val_1.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            this.tableShadow.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.table.gameObject.SetActive(value:  true);
            DG.Tweening.Sequence val_8 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_8, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.table.transform, endValue:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, duration:  0.1f));
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_8, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.tableShadow, endValue:  1f, duration:  0.15f), delay:  0.2f));
            DG.Tweening.Sequence val_16 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_16, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.table.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.15f, snapping:  false), ease:  1));
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_16, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.table.transform, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  0.05f, snapping:  false), ease:  1));
            DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_16, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.table.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.05f, snapping:  false), ease:  1));
            DG.Tweening.Sequence val_29 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_8, atPosition:  0.1f, t:  val_16);
            return val_8;
        }
        private void AnimatePlates(DG.Tweening.Sequence seq, float time)
        {
            object val_8;
            var val_9 = 0;
            do
            {
                if(val_9 >= this.plates.Length)
            {
                    return;
            }
            
                Area06TableView.<>c__DisplayClass11_0 val_1 = null;
                val_8 = val_1;
                val_1 = new Area06TableView.<>c__DisplayClass11_0();
                UnityEngine.Transform val_8 = this.plates[val_9];
                .plate = val_8;
                UnityEngine.Vector3 val_2 = val_8.localPosition;
                .initialPosition = val_2;
                mem[1152921519703683708] = val_2.y;
                mem[1152921519703683712] = val_2.z;
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.2f);
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
                (Area06TableView.<>c__DisplayClass11_0)[1152921519703683680].plate.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
                float val_9 = 0f;
                val_9 = val_9 * 0.1f;
                val_9 = val_9 + time;
                DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  seq, atPosition:  val_9, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area06TableView.<>c__DisplayClass11_0::<AnimatePlates>b__0()));
                val_9 = val_9 + 1;
            }
            while(this.plates != null);
            
            throw new NullReferenceException();
        }
        private void OnDisable()
        {
            if(this.tableAnimator != null)
            {
                    this.tableAnimator.enabled = false;
                return;
            }
            
            throw new NullReferenceException();
        }
        public Area06TableView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <PlayAnimation>b__9_0()
        {
            this.tableAnimator.enabled = true;
            this.tableAnimator.Play(stateName:  "Area06TableRevealAnimation", layer:  0, normalizedTime:  0f);
        }
        private void <PlayAnimation>b__9_1()
        {
            if(this.tableCover != null)
            {
                    this.tableCover.maskInteraction = 0;
                return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
