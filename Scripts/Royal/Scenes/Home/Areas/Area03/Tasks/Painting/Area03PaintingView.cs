using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area03.Tasks.Painting
{
    public class Area03PaintingView : AreaTaskView
    {
        // Fields
        private static readonly int AtlasUv;
        private static readonly int DissolveValue;
        public UnityEngine.GameObject[] painting;
        public UnityEngine.Transform shieldInitialPos;
        public UnityEngine.Transform sword1InitialPos;
        public UnityEngine.Transform sword2InitialPos;
        public UnityEngine.Transform tabloInitialPos;
        public UnityEngine.Material defaultSpriteMat;
        public UnityEngine.Material area03BgMat;
        public UnityEngine.AnimationCurve curve;
        private float elapsed;
        private UnityEngine.MaterialPropertyBlock propBlock;
        private UnityEngine.Coroutine routine;
        private UnityEngine.SpriteRenderer paintingBg;
        private float totalSeconds;
        
        // Methods
        public override void PrepareAnimation()
        {
            UnityEngine.GameObject[] val_7;
            this.PrepareAnimation();
            val_7 = this.painting;
            var val_8 = 0;
            label_6:
            if(val_8 >= this.painting.Length)
            {
                goto label_2;
            }
            
            val_7[val_8].gameObject.SetActive(value:  false);
            val_7 = this.painting;
            val_8 = val_8 + 1;
            if(val_7 != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_2:
            UnityEngine.SpriteRenderer val_2 = val_7[0].GetComponent<UnityEngine.SpriteRenderer>();
            this.paintingBg = val_2;
            this.defaultSpriteMat = val_2.material;
            this.paintingBg.material = this.area03BgMat;
            this.propBlock = new UnityEngine.MaterialPropertyBlock();
            UnityEngine.Vector4 val_6 = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.GetAtlasUvFromUvs(sprite:  this.paintingBg.sprite);
            this.SetAtlasUv(atlasUv:  new UnityEngine.Vector4() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w});
            this.elapsed = 0f;
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            Area03PaintingView.<>c__DisplayClass16_0 val_1 = new Area03PaintingView.<>c__DisplayClass16_0();
            .<>4__this = this;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.2f);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_2, atPosition:  0.15f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.OnUpdate<DG.Tweening.Sequence>(t:  val_2, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03PaintingView.<>c__DisplayClass16_0::<PlayAnimation>b__0()));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03PaintingView.<>c__DisplayClass16_0::<PlayAnimation>b__1()));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.5f);
            UnityEngine.GameObject val_58 = this.painting[2];
            .shield = val_58;
            UnityEngine.Vector3 val_12 = val_58.transform.localPosition;
            .initialPosition3 = val_12;
            mem[1152921519768546800] = val_12.y;
            mem[1152921519768546804] = val_12.z;
            UnityEngine.Vector3 val_14 = (Area03PaintingView.<>c__DisplayClass16_0)[1152921519768546752].shield.transform.localScale;
            .initialScale3 = val_14;
            mem[1152921519768546788] = val_14.y;
            mem[1152921519768546792] = val_14.z;
            UnityEngine.Vector3 val_16 = this.shieldInitialPos.localPosition;
            (Area03PaintingView.<>c__DisplayClass16_0)[1152921519768546752].shield.transform.localPosition = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            UnityEngine.Vector3 val_18 = this.shieldInitialPos.localScale;
            (Area03PaintingView.<>c__DisplayClass16_0)[1152921519768546752].shield.transform.localScale = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03PaintingView.<>c__DisplayClass16_0::<PlayAnimation>b__2()));
            DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03PaintingView.<>c__DisplayClass16_0::<PlayAnimation>b__3()));
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.25f);
            UnityEngine.GameObject val_59 = this.painting[3];
            .sword1 = val_59;
            UnityEngine.Vector3 val_25 = val_59.transform.localPosition;
            UnityEngine.Vector3 val_27 = this.sword1InitialPos.localPosition;
            (Area03PaintingView.<>c__DisplayClass16_0)[1152921519768546752].sword1.transform.localPosition = new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z};
            DG.Tweening.Sequence val_29 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03PaintingView.<>c__DisplayClass16_0::<PlayAnimation>b__4()));
            DG.Tweening.Sequence val_33 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  (Area03PaintingView.<>c__DisplayClass16_0)[1152921519768546752].sword1.transform, endValue:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, duration:  0.2f, snapping:  false), ease:  27));
            UnityEngine.GameObject val_60 = this.painting[4];
            .sword2 = val_60;
            UnityEngine.Vector3 val_35 = val_60.transform.localPosition;
            UnityEngine.Vector3 val_37 = this.sword2InitialPos.localPosition;
            (Area03PaintingView.<>c__DisplayClass16_0)[1152921519768546752].sword2.transform.localPosition = new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z};
            DG.Tweening.Sequence val_39 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03PaintingView.<>c__DisplayClass16_0::<PlayAnimation>b__5()));
            DG.Tweening.Sequence val_43 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  (Area03PaintingView.<>c__DisplayClass16_0)[1152921519768546752].sword2.transform, endValue:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z}, duration:  0.2f, snapping:  false), ease:  27));
            DG.Tweening.Sequence val_44 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.25f);
            UnityEngine.GameObject val_61 = this.painting[1];
            .tablo = val_61;
            UnityEngine.Vector3 val_46 = val_61.transform.localPosition;
            .initialPosition2 = val_46;
            mem[1152921519768546836] = val_46.y;
            mem[1152921519768546840] = val_46.z;
            UnityEngine.Vector3 val_48 = (Area03PaintingView.<>c__DisplayClass16_0)[1152921519768546752].tablo.transform.localScale;
            .initialScale = val_48;
            mem[1152921519768546848] = val_48.y;
            mem[1152921519768546852] = val_48.z;
            UnityEngine.Vector3 val_50 = UnityEngine.Vector3.zero;
            (Area03PaintingView.<>c__DisplayClass16_0)[1152921519768546752].tablo.transform.localScale = new UnityEngine.Vector3() {x = val_50.x, y = val_50.y, z = val_50.z};
            UnityEngine.Vector3 val_52 = this.tabloInitialPos.localPosition;
            (Area03PaintingView.<>c__DisplayClass16_0)[1152921519768546752].tablo.transform.localPosition = new UnityEngine.Vector3() {x = val_52.x, y = val_52.y, z = val_52.z};
            DG.Tweening.Sequence val_54 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03PaintingView.<>c__DisplayClass16_0::<PlayAnimation>b__6()));
            DG.Tweening.Sequence val_55 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.2f);
            DG.Tweening.Sequence val_57 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Area03PaintingView.<>c__DisplayClass16_0::<PlayAnimation>b__7()));
            return val_2;
        }
        public override void EndAnimation()
        {
            this.EndAnimation();
            this.paintingBg.material = this.defaultSpriteMat;
        }
        private void SetAtlasUv(UnityEngine.Vector4 atlasUv)
        {
            this.paintingBg.GetPropertyBlock(properties:  this.propBlock);
            this.propBlock.SetVector(nameID:  Royal.Scenes.Home.Areas.Area03.Tasks.Painting.Area03PaintingView.AtlasUv, value:  new UnityEngine.Vector4() {x = atlasUv.x, y = atlasUv.y, z = atlasUv.z, w = atlasUv.w});
            this.paintingBg.SetPropertyBlock(properties:  this.propBlock);
        }
        private void SetDissolveValue(float dissolveValue)
        {
            this.paintingBg.GetPropertyBlock(properties:  this.propBlock);
            this.propBlock.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area03.Tasks.Painting.Area03PaintingView.DissolveValue, value:  dissolveValue);
            this.paintingBg.SetPropertyBlock(properties:  this.propBlock);
        }
        private void UpdateDissolveValue()
        {
            float val_2 = this.totalSeconds;
            val_2 = this.elapsed / val_2;
            this.SetDissolveValue(dissolveValue:  this.curve.Evaluate(time:  val_2));
        }
        public Area03PaintingView()
        {
            this.totalSeconds = 1.5f;
        }
        private static Area03PaintingView()
        {
            Royal.Scenes.Home.Areas.Area03.Tasks.Painting.Area03PaintingView.AtlasUv = UnityEngine.Shader.PropertyToID(name:  "_AtlasUV");
            Royal.Scenes.Home.Areas.Area03.Tasks.Painting.Area03PaintingView.DissolveValue = UnityEngine.Shader.PropertyToID(name:  "_DissolveValue");
        }
    
    }

}
