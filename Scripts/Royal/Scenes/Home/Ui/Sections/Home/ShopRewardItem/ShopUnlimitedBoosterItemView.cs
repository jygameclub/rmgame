using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem
{
    public class ShopUnlimitedBoosterItemView : MonoBehaviour
    {
        // Fields
        private const float Scale1 = 1.188;
        private const float Scale2 = 0.891;
        private const float Scale3 = 1.0395;
        private const float Scale4 = 0.99;
        private const float Scale5 = 0.9;
        public static UnityEngine.Vector3 TargetShadowPosition;
        public static float Duration;
        public UnityEngine.Rendering.SortingGroup image;
        public UnityEngine.Rendering.SortingGroup shadow;
        public TMPro.TextMeshPro countText;
        public UnityEngine.ParticleSystem appearParticles;
        public UnityEngine.ParticleSystem hitParticles;
        private UnityEngine.Transform levelButtonFrame;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        
        // Methods
        public void Play(UnityEngine.Vector2 offset, int minutes, int count, int delayCount)
        {
            var val_12;
            var val_13;
            Royal.Scenes.Start.Context.Units.Audio.AudioManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.audioManager = val_1;
            val_1.PlaySound(type:  22, offset:  0.04f);
            val_12 = null;
            val_12 = null;
            this.shadow.transform.localPosition = new UnityEngine.Vector3() {x = Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem.ShopUnlimitedBoosterItemView.TargetShadowPosition, y = Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem.ShopUnlimitedBoosterItemView.TargetShadowPosition.__il2cppRuntimeField_4, z = Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem.ShopUnlimitedBoosterItemView.TargetShadowPosition.__il2cppRuntimeField_8};
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetShopRewardedItemSorting(count:  count);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.image, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_5 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetShopRewardedItemShadowSorting(count:  count);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.shadow, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_5.layer, order = val_5.order, sortEverything = val_5.sortEverything & 4294967295});
            this.SetRewardText(text:  Royal.Infrastructure.Utils.Time.TimeUtil.GetDurationInMinutesOrHours(totalMinutes:  (long)minutes));
            val_13 = null;
            val_13 = null;
            this.levelButtonFrame = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg + 136.transform.parent;
            this.PrepareItemToAnimation(offset:  new UnityEngine.Vector2() {x = offset.x, y = offset.y});
            UnityEngine.Coroutine val_11 = this.StartCoroutine(routine:  this.PlayAnimation(delayCount:  delayCount));
        }
        private System.Collections.IEnumerator PlayAnimation(int delayCount)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .delayCount = delayCount;
            return (System.Collections.IEnumerator)new ShopUnlimitedBoosterItemView.<PlayAnimation>d__15();
        }
        private void PrepareItemToAnimation(UnityEngine.Vector2 offset)
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = offset.x, y = offset.y});
            this.transform.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            this.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
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
        public void SetRewardText(string text)
        {
            var val_3;
            this.countText.text = text;
            T[] val_1 = this.GetComponentsInChildren<Royal.Infrastructure.Utils.Text.TextPositioner>();
            if(val_1 == null)
            {
                    return;
            }
            
            this = val_1;
            if(val_1.Length < 1)
            {
                    return;
            }
            
            do
            {
                1152921506482711552.ArrangeTransformByCharCount(charCount:  (Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic == false) ? 2 : text.m_stringLength);
                val_3 = 0 + 1;
            }
            while(val_3 < val_1.Length);
        
        }
        public ShopUnlimitedBoosterItemView()
        {
        
        }
        private static ShopUnlimitedBoosterItemView()
        {
            Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem.ShopUnlimitedBoosterItemView.TargetShadowPosition = 0;
            Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem.ShopUnlimitedBoosterItemView.TargetShadowPosition.__il2cppRuntimeField_8 = 0;
            Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem.ShopUnlimitedBoosterItemView.Duration = 0.5f;
        }
    
    }

}
