using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area03.Tasks.Table
{
    public class Area03TableView : AreaTaskView
    {
        // Fields
        private static readonly int AtlasUv;
        private static readonly int DissolveValue;
        public UnityEngine.Material defaultSpriteMat;
        public UnityEngine.Material area03TableMat;
        public UnityEngine.Transform table;
        public UnityEngine.SpriteRenderer tableShadow;
        public UnityEngine.SpriteRenderer tableCover;
        public float elapsed;
        private UnityEngine.MaterialPropertyBlock propBlock;
        private UnityEngine.MaterialPropertyBlock defaultPropBlock;
        private UnityEngine.Coroutine routine;
        private UnityEngine.Animator coverAnimator;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
            this.coverAnimator = val_1;
            val_1.enabled = false;
        }
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.propBlock = new UnityEngine.MaterialPropertyBlock();
            UnityEngine.MaterialPropertyBlock val_2 = new UnityEngine.MaterialPropertyBlock();
            this.defaultPropBlock = val_2;
            this.tableCover.GetPropertyBlock(properties:  val_2);
            UnityEngine.Vector4 val_4 = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.GetAtlasUvFromUvs(sprite:  this.tableCover.sprite);
            this.SetAtlasUv(atlasUv:  new UnityEngine.Vector4() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w});
            this.SetDissolveValue(dissolveValue:  this.elapsed);
            this.tableCover.enabled = false;
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.AnimateTable());
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.2f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area03.Tasks.Table.Area03TableView::<PlayAnimation>b__14_0()));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.OnUpdate<DG.Tweening.Sequence>(t:  val_1, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area03.Tasks.Table.Area03TableView::<PlayAnimation>b__14_1()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.EndAnimation();
            this.coverAnimator.enabled = false;
            this.tableCover.SetPropertyBlock(properties:  this.defaultPropBlock);
            this.tableCover.sharedMaterial = this.defaultSpriteMat;
        }
        private void UpdateDissolveValue()
        {
            this.SetDissolveValue(dissolveValue:  this.elapsed);
        }
        private void SetAtlasUv(UnityEngine.Vector4 atlasUv)
        {
            this.tableCover.GetPropertyBlock(properties:  this.propBlock);
            this.propBlock.SetVector(nameID:  Royal.Scenes.Home.Areas.Area03.Tasks.Table.Area03TableView.AtlasUv, value:  new UnityEngine.Vector4() {x = atlasUv.x, y = atlasUv.y, z = atlasUv.z, w = atlasUv.w});
            this.tableCover.SetPropertyBlock(properties:  this.propBlock);
        }
        private void SetDissolveValue(float dissolveValue)
        {
            this.tableCover.GetPropertyBlock(properties:  this.propBlock);
            this.propBlock.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area03.Tasks.Table.Area03TableView.DissolveValue, value:  dissolveValue);
            this.tableCover.SetPropertyBlock(properties:  this.propBlock);
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
            DG.Tweening.Sequence val_7 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_7, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.table.transform, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  0.1f));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_7, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.tableShadow, endValue:  1f, duration:  0.15f), delay:  0.2f));
            DG.Tweening.Sequence val_15 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_15, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.table.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.15f, snapping:  false), ease:  1));
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_15, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.table.transform, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  0.05f, snapping:  false), ease:  1));
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_15, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.table.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.05f, snapping:  false), ease:  1));
            DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_7, atPosition:  0.1f, t:  val_15);
            return val_7;
        }
        public Area03TableView()
        {
        
        }
        private static Area03TableView()
        {
            Royal.Scenes.Home.Areas.Area03.Tasks.Table.Area03TableView.AtlasUv = UnityEngine.Shader.PropertyToID(name:  "_AtlasUV");
            Royal.Scenes.Home.Areas.Area03.Tasks.Table.Area03TableView.DissolveValue = UnityEngine.Shader.PropertyToID(name:  "_DissolveValue");
        }
        private void <PlayAnimation>b__14_0()
        {
            this.elapsed = 0f;
            this.tableCover.material = this.area03TableMat;
            this.tableCover.enabled = true;
            this.coverAnimator.enabled = true;
            this.coverAnimator.Play(stateName:  "Area03TableCoverReveal", layer:  0, normalizedTime:  0f);
        }
        private void <PlayAnimation>b__14_1()
        {
            if(this.coverAnimator.enabled == false)
            {
                    return;
            }
            
            this.SetDissolveValue(dissolveValue:  this.elapsed);
        }
    
    }

}
