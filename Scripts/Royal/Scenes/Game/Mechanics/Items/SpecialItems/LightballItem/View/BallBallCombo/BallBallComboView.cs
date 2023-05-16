using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.BallBallCombo
{
    public class BallBallComboView : MonoBehaviour, IPoolable
    {
        // Fields
        public UnityEngine.Animator animator;
        public UnityEngine.Rendering.SortingGroup sortingGroup;
        public UnityEngine.SpriteRenderer black;
        public UnityEngine.Transform maskTransform;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private System.Action onAnimationCompleted;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.BallBallCombo.BallBallComboUseParticles useParticles;
        private bool isReady;
        
        // Methods
        public void Init(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory factory, UnityEngine.Vector3 position, Royal.Scenes.Game.Levels.Units.Combo.SwipeType swipeType, System.Action onComplete)
        {
            this.transform.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
            this.itemFactory = factory;
            this.onAnimationCompleted = onComplete;
            this.sortingGroup.gameObject.SetActive(value:  true);
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetBallBallComboSorting();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.sortingGroup, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_5 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetBallBallComboBackgroundSorting();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.black, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_5.layer, order = val_5.order, sortEverything = val_5.sortEverything & 4294967295});
            this.animator.speed = 1.2f;
            UnityEngine.Transform val_7 = this.animator.transform;
            if(swipeType != 2)
            {
                goto label_8;
            }
            
            if(val_7 != null)
            {
                goto label_9;
            }
            
            label_8:
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            label_9:
            val_7.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            this.isReady = true;
            this.StartUseParticles();
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  0.0001f);
            this.maskTransform.transform.localScale = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            UnityEngine.Color val_12 = UnityEngine.Color.clear;
            this.black.color = new UnityEngine.Color() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.a};
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_14 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.black, endValue:  0.6f, duration:  0.35f), ease:  3);
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager>(contextId:  22).PlaySfx(type:  153, offset:  0.04f);
        }
        private void StartUseParticles()
        {
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.BallBallCombo.BallBallComboUseParticles val_1 = this.itemFactory.Spawn<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.BallBallCombo.BallBallComboUseParticles>(poolId:  29, activate:  true);
            this.useParticles = val_1;
            UnityEngine.Transform val_2 = val_1.transform;
            val_2.SetParent(p:  this.transform);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            val_2.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            this.useParticles.Play();
        }
        private void Update()
        {
            if(this.isReady == false)
            {
                    return;
            }
            
            if((double)this.GetAnimationNormalizedTime() < 0)
            {
                    return;
            }
            
            this.PlayParticles();
            this.onAnimationCompleted.Invoke();
            this.sortingGroup.gameObject.SetActive(value:  false);
            this.itemFactory.Recycle<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.BallBallCombo.BallBallComboUseParticles>(go:  this.useParticles);
        }
        private float GetAnimationNormalizedTime()
        {
            var val_3;
            UnityEngine.AnimatorStateInfo val_1 = this.animator.GetCurrentAnimatorStateInfo(layerIndex:  0);
            return (float)val_3;
        }
        private void PlayParticles()
        {
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.BallBallCombo.BallBallComboExplodeParticles val_1 = this.itemFactory.Spawn<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.BallBallCombo.BallBallComboExplodeParticles>(poolId:  30, activate:  true);
            UnityEngine.Vector3 val_4 = this.transform.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            val_1.Play();
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  4f);
            this.maskTransform.transform.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  40f);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_12 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.maskTransform, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  1f), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.BallBallCombo.BallBallComboView::<PlayParticles>b__12_0()));
        }
        public int GetPoolId()
        {
            return 28;
        }
        public void OnSpawn()
        {
        
        }
        public void OnRecycle()
        {
            this.isReady = false;
        }
        public BallBallComboView()
        {
        
        }
        private void <PlayParticles>b__12_0()
        {
            this.itemFactory.Recycle<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.BallBallCombo.BallBallComboView>(go:  this);
        }
    
    }

}
