using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem
{
    public class ShopRewardItemView : MonoBehaviour
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
        public UnityEngine.SpriteRenderer leftX;
        public UnityEngine.SpriteRenderer rightX;
        public TMPro.TextMeshPro countText;
        public UnityEngine.ParticleSystem appearParticles;
        public UnityEngine.ParticleSystem hitParticles;
        public UnityEngine.GameObject xHolder;
        private UnityEngine.Transform levelButtonFrame;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        
        // Methods
        public void Play(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType, UnityEngine.Vector2 offset, int boosterCount, int count, int delayCount)
        {
            var val_23;
            var val_24;
            var val_25;
            Royal.Scenes.Start.Context.Units.Audio.AudioManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.audioManager = val_1;
            val_1.PlaySound(type:  22, offset:  0.04f);
            this.image.sprite = val_1.GetSpriteForBooster(boosterType:  boosterType);
            this.shadow.sprite = this.image.GetShadowForBooster(boosterType:  boosterType);
            val_23 = null;
            val_23 = null;
            this.shadow.transform.localPosition = new UnityEngine.Vector3() {x = Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem.ShopRewardItemView.TargetShadowPosition, y = Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem.ShopRewardItemView.TargetShadowPosition.__il2cppRuntimeField_4, z = Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem.ShopRewardItemView.TargetShadowPosition.__il2cppRuntimeField_8};
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_5 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetShopRewardedItemSorting(count:  count);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.image, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_5.layer, order = val_5.order, sortEverything = val_5.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_7 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetShopRewardedItemShadowSorting(count:  count);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.shadow, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_7.layer, order = val_7.order, sortEverything = val_7.sortEverything & 4294967295});
            if(boosterCount >= 2)
            {
                    Royal.Scenes.Game.Mechanics.Sortings.SortingData val_9 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetShopRewardedItemTextSorting(count:  count);
                Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.leftX, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_9.layer, order = val_9.order, sortEverything = val_9.sortEverything & 4294967295});
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_11 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetShopRewardedItemTextSorting(count:  count);
                Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.rightX, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_11.layer, order = val_11.order, sortEverything = val_11.sortEverything & 4294967295});
                val_24 = this;
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_13 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetShopRewardedItemTextSorting(count:  count);
                Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(textMeshPro:  this.countText, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_13.layer, order = val_13.order, sortEverything = val_13.sortEverything & 4294967295});
            }
            else
            {
                    this.leftX.gameObject.SetActive(value:  false);
                this.rightX.gameObject.SetActive(value:  false);
                val_24 = this;
                this.countText.gameObject.SetActive(value:  false);
            }
            
            this.countText.text = boosterCount.ToString();
            val_25 = null;
            val_25 = null;
            this.levelButtonFrame = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg + 136.transform.parent;
            this.PrepareItemToAnimation(offset:  new UnityEngine.Vector2() {x = offset.x, y = offset.y});
            UnityEngine.Coroutine val_22 = this.StartCoroutine(routine:  this.PlayAnimation(delayCount:  delayCount));
        }
        private System.Collections.IEnumerator PlayAnimation(int delayCount)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .delayCount = delayCount;
            return (System.Collections.IEnumerator)new ShopRewardItemView.<PlayAnimation>d__19();
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
        public ShopRewardItemView()
        {
        
        }
        private static ShopRewardItemView()
        {
            Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem.ShopRewardItemView.TargetShadowPosition = 0;
            Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem.ShopRewardItemView.TargetShadowPosition.__il2cppRuntimeField_8 = 0;
            Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem.ShopRewardItemView.Duration = 0.5f;
        }
    
    }

}
