using UnityEngine;

namespace Royal.Scenes.Game.Ui.Madness
{
    public class MadnessMatchItemAnimationView : ItemParticles
    {
        // Fields
        private const float MoveLimit = 0.1;
        public UnityEngine.Transform root;
        public UnityEngine.SpriteRenderer matchItem;
        public TMPro.TextMeshPro countText;
        public TMPro.TextMeshPro countBgText;
        private float delaySeconds;
        private UnityEngine.Vector3 initialPosition;
        private Royal.Scenes.Game.Mechanics.Items.Config.ItemModel itemModel;
        private bool didStartAnimation;
        private float delayElapsed;
        private bool isItemMoving;
        private DG.Tweening.Sequence animationSeq;
        
        // Methods
        public void StartAnimation(UnityEngine.Vector3 originPosition, int count, int animationDelayInFrames, Royal.Scenes.Game.Mechanics.Items.Config.ItemModel itemModel)
        {
            this.itemModel = itemModel;
            this.delaySeconds = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  (float)animationDelayInFrames);
            this.initialPosition = originPosition;
            mem[1152921519896741104] = originPosition.y;
            mem[1152921519896741108] = originPosition.z;
            this.countText.text = count.ToString();
            this.countBgText.text = count.ToString();
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            this.root.transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            this.root.transform.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory val_8 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.transform.SetParent(p:  val_8.<ItemParent>k__BackingField);
            this.transform.position = new UnityEngine.Vector3() {x = this.initialPosition, y = val_7.y, z = val_7.z};
        }
        private void Update()
        {
            float val_3;
            float val_4;
            if(this.didStartAnimation == true)
            {
                    return;
            }
            
            if(this.itemModel == null)
            {
                goto label_2;
            }
            
            if((this.itemModel & 1) == 0)
            {
                goto label_11;
            }
            
            val_3 = V0.16B;
            val_4 = val_3;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = this.initialPosition, y = V11.16B, z = V10.16B});
            if(val_1.x > 0.1f)
            {
                goto label_7;
            }
            
            val_3 = this.delayElapsed;
            if(val_3 < 0)
            {
                goto label_8;
            }
            
            label_7:
            if(val_1.x <= 0.1f)
            {
                goto label_11;
            }
            
            this.isItemMoving = true;
            goto label_11;
            label_2:
            val_3 = this.delayElapsed;
            val_4 = this.delaySeconds;
            if(val_3 >= 0)
            {
                goto label_11;
            }
            
            label_8:
            float val_2 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
            val_2 = val_3 + val_2;
            this.delayElapsed = val_2;
            return;
            label_11:
            this.didStartAnimation = true;
            this.PlayAnimation();
        }
        private void PlayAnimation()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
            var val_2 = (this.isItemMoving == false) ? 1 : 0;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  36532592 + this.isItemMoving == false ? 1 : 0);
            UnityEngine.Transform val_4 = this.transform;
            UnityEngine.Vector3 val_5 = val_4.position;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            val_4.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_7 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetMadnessAnimationSorting();
            bool val_8 = val_7.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_9 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_7.layer, order = val_7.order, sortEverything = val_8}, offset:  0);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(textMeshPro:  this.countBgText, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_9.layer, order = val_9.order, sortEverything = val_9.sortEverything & 4294967295});
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.matchItem, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_7.layer, order = val_7.order, sortEverything = val_8});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_11 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_7.layer, order = val_7.order, sortEverything = val_8}, offset:  1);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(textMeshPro:  this.countText, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_11.layer, order = val_11.order, sortEverything = val_11.sortEverything & 4294967295});
            DG.Tweening.Sequence val_13 = DG.Tweening.DOTween.Sequence();
            this.animationSeq = val_13;
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_13, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.root.transform, endValue:  1f, duration:  0.7f), ease:  27, overshoot:  1f));
            UnityEngine.Vector3 val_20 = this.root.transform.localPosition;
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.animationSeq, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.root.transform, endValue:  val_20.y + 2f, duration:  1f, snapping:  false), ease:  5));
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.animationSeq, atPosition:  0.6f, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.matchItem, endValue:  0f, duration:  0.4f));
            DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.animationSeq, atPosition:  0.6f, t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  this.countText, endValue:  0f, duration:  0.4f));
            DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.animationSeq, atPosition:  0.6f, t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  this.countBgText, endValue:  0f, duration:  0.4f));
            this.Invoke(methodName:  "Clear", time:  2f);
        }
        private void Clear()
        {
            goto typeof(Royal.Scenes.Game.Ui.Madness.MadnessMatchItemAnimationView).__il2cppRuntimeField_1B0;
        }
        public override int GetPoolId()
        {
            return 97;
        }
        public override void OnRecycle()
        {
            this.OnRecycle();
            this.CancelInvoke(methodName:  "Clear");
            if(this.animationSeq != null)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.animationSeq, complete:  false);
                this.animationSeq = 0;
            }
            
            UnityEngine.Color val_1 = this.matchItem.color;
            this.matchItem.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = 1f};
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.matchItem.transform.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Color val_4 = this.countText.color;
            this.countText.color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = 1f};
            UnityEngine.Color val_5 = this.countBgText.color;
            this.countBgText.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = 1f};
            this.delayElapsed = 0f;
            this.didStartAnimation = false;
            this.isItemMoving = false;
        }
        public MadnessMatchItemAnimationView()
        {
        
        }
    
    }

}
