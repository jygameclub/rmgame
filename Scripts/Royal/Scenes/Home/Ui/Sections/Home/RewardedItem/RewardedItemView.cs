using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.RewardedItem
{
    public class RewardedItemView : MonoBehaviour
    {
        // Fields
        private const float Scale1 = 1.188;
        private const float Scale2 = 0.891;
        private const float Scale3 = 1.0395;
        private const float Scale4 = 0.99;
        private const float Scale5 = 0.9;
        public static UnityEngine.Vector3 TargetShadowPosition;
        public static float Duration;
        public UnityEngine.GameObject rewardedItemObject;
        public UnityEngine.SpriteRenderer image;
        public UnityEngine.SpriteRenderer shadow;
        public UnityEngine.ParticleSystem appearParticles;
        public UnityEngine.ParticleSystem hitParticles;
        private UnityEngine.Transform levelButtonFrame;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        
        // Methods
        private void Awake()
        {
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
        }
        public void Play(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType, UnityEngine.Vector2 offset, int count)
        {
            var val_12;
            var val_13;
            this.image.sprite = this.GetSpriteForBooster(boosterType:  boosterType);
            this.shadow.sprite = this.image.GetShadowForBooster(boosterType:  boosterType);
            val_12 = null;
            val_12 = null;
            this.shadow.transform.localPosition = new UnityEngine.Vector3() {x = Royal.Scenes.Home.Ui.Sections.Home.RewardedItem.RewardedItemView.TargetShadowPosition, y = Royal.Scenes.Home.Ui.Sections.Home.RewardedItem.RewardedItemView.TargetShadowPosition.__il2cppRuntimeField_4, z = Royal.Scenes.Home.Ui.Sections.Home.RewardedItem.RewardedItemView.TargetShadowPosition.__il2cppRuntimeField_8};
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetRewardedItemSorting(count:  count);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.image, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_4.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_6 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetRewardedItemShadowSorting(count:  count);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.shadow, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_6.layer, order = val_6.order, sortEverything = val_6.sortEverything & 4294967295});
            val_13 = null;
            val_13 = null;
            this.levelButtonFrame = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg + 136.transform.parent;
            this.PrepareItemToAnimation(offset:  new UnityEngine.Vector2() {x = offset.x, y = offset.y});
            this.audioManager.PlaySound(type:  22, offset:  0.04f);
            UnityEngine.Coroutine val_11 = this.StartCoroutine(routine:  this.PlayAnimation());
        }
        private System.Collections.IEnumerator PlayAnimation()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new RewardedItemView.<PlayAnimation>d__16();
        }
        private void PrepareItemToAnimation(UnityEngine.Vector2 offset)
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = offset.x, y = offset.y});
            this.rewardedItemObject.transform.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            this.rewardedItemObject.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        private void PlayItemHitAnimation()
        {
            this.audioManager.PlaySound(type:  23, offset:  0.04f);
            UnityEngine.Vector3 val_3 = this.levelButtonFrame.transform.position;
            this.hitParticles.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.hitParticles.Play();
            DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  1.04f, y:  0.97f);
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, b:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
            UnityEngine.Vector3 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.levelButtonFrame, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  0.05f));
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  0.98f, y:  1.02f);
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, b:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
            UnityEngine.Vector3 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.levelButtonFrame, endValue:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, duration:  0.075f));
            UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  1.01f, y:  0.99f);
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y}, b:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
            UnityEngine.Vector3 val_21 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.levelButtonFrame, endValue:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, duration:  0.06f));
            DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.levelButtonFrame, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.05f));
        }
        private UnityEngine.Sprite GetSpriteForBooster(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            var val_3;
            if((boosterType - 1) <= 6)
            {
                    UnityEngine.Sprite val_2 = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  45230560 + ((boosterType - 1)) << 3);
                return (UnityEngine.Sprite)val_3;
            }
            
            val_3 = 0;
            return (UnityEngine.Sprite)val_3;
        }
        private UnityEngine.Sprite GetShadowForBooster(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            var val_3;
            if((boosterType - 1) <= 6)
            {
                    UnityEngine.Sprite val_2 = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  45230624 + ((boosterType - 1)) << 3);
                return (UnityEngine.Sprite)val_3;
            }
            
            val_3 = 0;
            return (UnityEngine.Sprite)val_3;
        }
        public RewardedItemView()
        {
        
        }
        private static RewardedItemView()
        {
            Royal.Scenes.Home.Ui.Sections.Home.RewardedItem.RewardedItemView.TargetShadowPosition = 0;
            Royal.Scenes.Home.Ui.Sections.Home.RewardedItem.RewardedItemView.TargetShadowPosition.__il2cppRuntimeField_8 = 0;
            Royal.Scenes.Home.Ui.Sections.Home.RewardedItem.RewardedItemView.Duration = 0.5f;
        }
    
    }

}
