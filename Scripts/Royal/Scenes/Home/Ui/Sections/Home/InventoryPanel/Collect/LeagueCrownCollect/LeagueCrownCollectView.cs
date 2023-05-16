using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect
{
    public class LeagueCrownCollectView : MonoBehaviour
    {
        // Fields
        private const float Scale1 = 1.4256;
        private const float Scale2 = 1.0692;
        private const float Scale3 = 1.2474;
        private const float Scale4 = 1.188;
        public UnityEngine.SpriteRenderer crownItem;
        public UnityEngine.SpriteRenderer crownShadow;
        public UnityEngine.ParticleSystem hitParticles;
        public UnityEngine.ParticleSystem appearParticles;
        public UnityEngine.Animator crownAnimator;
        public TMPro.TextMeshPro amountText;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private Royal.Scenes.Home.Ui.Sections.Home.Buttons.LeagueInfoButton leagueButtonFrame;
        private bool playFinalParticle;
        private bool playAmountAnimation;
        public static float Duration;
        public static float P1YOffset;
        public static float P1XOffset;
        public static float P2YOffset;
        public static float P2XOffset;
        public static float ScaleUpRatio;
        public static float ScaleDownRatio;
        
        // Methods
        public float Play(int index = 0, int amount = 0, float xOffset = 0, float yOffset = 0, bool playInitialParticle = False, bool playFinalParticle = False)
        {
            var val_57;
            var val_59;
            LeagueCrownCollectView.<>c__DisplayClass14_0 val_1 = new LeagueCrownCollectView.<>c__DisplayClass14_0();
            .<>4__this = this;
            .playInitialParticle = playInitialParticle;
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            val_57 = null;
            val_57 = null;
            this.playFinalParticle = playFinalParticle;
            this.leagueButtonFrame = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg + 160;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            this.amountText.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            if(amount >= 2)
            {
                    this.playAmountAnimation = true;
                this.amountText.text = "<b>+</b>"("<b>+</b>") + amount;
                this.amountText.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
                UnityEngine.Vector2 val_9 = UnityEngine.Vector2.down;
                UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y}, d:  2f);
                UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  -1f, y:  0f);
                UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, b:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
                UnityEngine.Vector3 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
                this.amountText.transform.position = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
            }
            
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_15 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetHomeCoinCollectSorting(index:  20 - index);
            bool val_16 = val_15.sortEverything & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.crownShadow, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_15.layer, order = val_15.order, sortEverything = val_16});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_17 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_15.layer, order = val_15.order, sortEverything = val_16}, offset:  1);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.crownItem, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_17.layer, order = val_17.order, sortEverything = val_17.sortEverything & 4294967295});
            DG.Tweening.Sequence val_19 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector2 val_21 = UnityEngine.Vector2.down;
            UnityEngine.Vector2 val_22 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y}, d:  2f);
            UnityEngine.Vector2 val_23 = new UnityEngine.Vector2(x:  xOffset, y:  yOffset);
            UnityEngine.Vector2 val_24 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y}, b:  new UnityEngine.Vector2() {x = val_23.x, y = val_23.y});
            UnityEngine.Vector3 val_25 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_24.x, y = val_24.y});
            this.crownItem.transform.position = new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z};
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.zero;
            this.crownItem.transform.localScale = new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z};
            UnityEngine.Vector3 val_30 = this.crownItem.transform.position;
            this.appearParticles.transform.position = new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z};
            this.crownAnimator.enabled = true;
            this.crownAnimator.Play(stateName:  "CrownCollectAnim", layer:  0, normalizedTime:  0f);
            this.crownAnimator.speed = 0.5f;
            this.crownItem.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            this.crownShadow.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            UnityEngine.Vector3 val_32 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z}, d:  1.188f);
            DG.Tweening.Sequence val_36 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_19, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.crownItem.transform, endValue:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z}, duration:  0.35f), ease:  9));
            UnityEngine.Color val_37 = UnityEngine.Color.white;
            DG.Tweening.Sequence val_40 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_19, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOColor(target:  this.crownItem, endValue:  new UnityEngine.Color() {r = val_37.r, g = val_37.g, b = val_37.b, a = val_37.a}, duration:  0.35f), ease:  9));
            DG.Tweening.Sequence val_44 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_19, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.crownShadow.transform, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.35f, snapping:  false), ease:  9));
            DG.Tweening.Sequence val_47 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_19, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOColor(target:  this.crownShadow, endValue:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f}, duration:  0.35f), ease:  9));
            DG.Tweening.Sequence val_50 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_19, t:  DG.Tweening.DOTween.To(setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  val_1, method:  System.Void LeagueCrownCollectView.<>c__DisplayClass14_0::<Play>b__0(float x)), startValue:  0.5f, endValue:  1f, duration:  0.35f));
            DG.Tweening.Sequence val_52 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_19, atPosition:  0.1f, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void LeagueCrownCollectView.<>c__DisplayClass14_0::<Play>b__1()));
            if(this.playAmountAnimation != false)
            {
                    DG.Tweening.Sequence val_54 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_19, atPosition:  0.05f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect.LeagueCrownCollectView::PlayAmountAnimation()));
            }
            
            UnityEngine.Coroutine val_56 = Royal.Scenes.Home.Context.HomeContext.ManualStartCoroutine(iEnumerator:  this.PlayCollect());
            val_59 = null;
            val_59 = null;
            float val_57 = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect.LeagueCrownCollectView.Duration;
            val_57 = val_57 + (-0.1f);
            return (float)val_57;
        }
        private System.Collections.IEnumerator PlayCollect()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new LeagueCrownCollectView.<PlayCollect>d__22();
        }
        private void PlayItemHitAnimation()
        {
            float val_34;
            Royal.Scenes.Home.Ui.Sections.Home.Buttons.LeagueInfoButton val_35;
            this.crownItem.gameObject.SetActive(value:  false);
            val_34 = 0.04f;
            this.audioManager.PlaySound(type:  23, offset:  val_34);
            if(this.playFinalParticle != false)
            {
                    val_35 = this;
                UnityEngine.Vector3 val_4 = this.leagueButtonFrame.transform.position;
                val_34 = val_4.x;
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_34, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                this.hitParticles.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
                this.hitParticles.Play();
            }
            else
            {
                    val_35 = this.leagueButtonFrame;
            }
            
            mem[this.leagueButtonFrame].PlayCrownAnimation();
            DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  1.04f, y:  0.97f);
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y}, b:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
            UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  mem[this.leagueButtonFrame].transform, endValue:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, duration:  0.05f));
            UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  0.98f, y:  1.02f);
            UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y}, b:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
            UnityEngine.Vector3 val_19 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y});
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  mem[this.leagueButtonFrame].transform, endValue:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, duration:  0.075f));
            UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Vector2 val_24 = new UnityEngine.Vector2(x:  1.01f, y:  0.99f);
            UnityEngine.Vector2 val_25 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_23.x, y = val_23.y}, b:  new UnityEngine.Vector2() {x = val_24.x, y = val_24.y});
            UnityEngine.Vector3 val_26 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_25.x, y = val_25.y});
            DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  mem[this.leagueButtonFrame].transform, endValue:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, duration:  0.06f));
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  mem[this.leagueButtonFrame].transform, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  0.05f));
            DG.Tweening.Sequence val_33 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_6, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect.LeagueCrownCollectView::<PlayItemHitAnimation>b__23_0()));
        }
        private void PlayAmountAnimation()
        {
            UnityEngine.Vector3 val_2 = this.amountText.transform.localPosition;
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_3, atPosition:  0f, t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  this.amountText, endValue:  1f, duration:  0.3f));
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_3, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensionsTMPText.DOScale(target:  this.amountText, endValue:  1f, duration:  0.4f), ease:  27));
            float val_15 = 2f;
            val_15 = val_2.y + val_15;
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_3, atPosition:  0.5f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.amountText.transform, endValue:  val_15, duration:  1.3f, snapping:  false), ease:  5));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_3, atPosition:  0.6f, t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  this.amountText, endValue:  0f, duration:  0.4f));
        }
        private void DestroyDelayed()
        {
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        public LeagueCrownCollectView()
        {
        
        }
        private static LeagueCrownCollectView()
        {
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect.LeagueCrownCollectView.Duration = 0.7f;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect.LeagueCrownCollectView.P1YOffset = 1.2f;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect.LeagueCrownCollectView.P1XOffset = 0f;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect.LeagueCrownCollectView.P2YOffset = 1.2f;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect.LeagueCrownCollectView.P2XOffset = 0f;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect.LeagueCrownCollectView.ScaleUpRatio = 0.3f;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect.LeagueCrownCollectView.ScaleDownRatio = 0.7f;
        }
        private void <PlayItemHitAnimation>b__23_0()
        {
            this.Invoke(methodName:  "DestroyDelayed", time:  1f);
        }
    
    }

}
