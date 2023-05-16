using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems
{
    public abstract class SpecialItemView : ItemView
    {
        // Fields
        public UnityEngine.SpriteRenderer baseView;
        public UnityEngine.Animator animator;
        public UnityEngine.SpriteRenderer shadow;
        private float initialShadowAlpha;
        
        // Methods
        public abstract void PlayCreationAnimation(float normalizedStartTime = 0, bool playSound = True); // 0
        public abstract void PlayBoosterAnimation(); // 0
        public abstract void StopCreationAnimation(); // 0
        public abstract Royal.Scenes.Game.Mechanics.Sortings.SortingData GetCreationSorting(); // 0
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.Color val_1 = this.shadow.color;
            this.initialShadowAlpha = val_1.a;
        }
        public virtual void ChangeAlpha(float alpha)
        {
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ChangeAlpha(sprite:  this.baseView, alpha:  alpha);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ChangeAlpha(sprite:  this.shadow, alpha:  alpha);
        }
        public virtual void ResetAlpha()
        {
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ChangeAlpha(sprite:  this.baseView, alpha:  1f);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ChangeAlpha(sprite:  this.shadow, alpha:  this.initialShadowAlpha);
        }
        protected SpecialItemView()
        {
        
        }
    
    }

}
