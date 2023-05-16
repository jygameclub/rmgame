using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect
{
    public class KingsCupCollectAnimation : MonoBehaviour
    {
        // Fields
        public UnityEngine.AnimationCurve throwCurve;
        public UnityEngine.ParticleSystem hitParticles;
        public UnityEngine.SpriteRenderer trophyRenderer;
        public TMPro.TextMeshPro amountText;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private UnityEngine.Transform trophy;
        private UnityEngine.Transform iconTrophyTransform;
        private UnityEngine.Transform iconTrophyShineTransform;
        private static UnityEngine.Vector3 OriginalTrophyScale;
        private static UnityEngine.Vector3 OriginalTrophyShineScale;
        private bool playAmountAnimation;
        private bool shouldPlayParticles;
        
        // Methods
        private void Awake()
        {
            null = null;
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.trophy = this.trophyRenderer.transform;
            this.iconTrophyTransform = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_byval_arg + 48 + 48.transform;
            this.iconTrophyShineTransform = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_byval_arg + 48 + 56.transform;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyScale, y = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_4, z = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_8}, rhs:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z})) == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_7 = this.iconTrophyTransform.localScale;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyScale = val_7.x;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_4 = val_7.y;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_8 = val_7.z;
            UnityEngine.Vector3 val_8 = this.iconTrophyShineTransform.localScale;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyShineScale = val_8.x;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_10 = val_8.y;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_14 = val_8.z;
        }
        public void Play(int amount = 0, float xOffset = 0, float yOffset = 0, bool shouldPlayParticles = False)
        {
            this.shouldPlayParticles = shouldPlayParticles;
            this.BeforeAnimation(amount:  amount, offset:  xOffset);
            DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.DOTween.Sequence(), t:  this.AnimateStart(offset:  yOffset)), interval:  0.2f), t:  this.AnimateToIcon()), callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation::OnItemReached())), t:  this.AnimateEnd()) = new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation::OnAnimationEnd());
        }
        private void BeforeAnimation(int amount, float offset)
        {
            UnityEngine.Vector3 val_1 = this.iconTrophyTransform.position;
            this.transform.position = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.right;
            float val_10 = 1.64f;
            val_10 = offset + val_10;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  val_10);
            this.trophy.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            this.trophy.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Color val_6 = this.trophyRenderer.color;
            this.trophyRenderer.color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = 0f};
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            this.amountText.transform.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            if(amount < 2)
            {
                    return;
            }
            
            this.playAmountAnimation = true;
            this.amountText.text = "<b>+</b>"("<b>+</b>") + amount;
            this = this.amountText;
            this.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        private DG.Tweening.Sequence AnimateStart(float offset)
        {
            this.audioManager.PlaySound(type:  90, offset:  0.04f);
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.trophy, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.1f), ease:  3));
            float val_16 = -0.18f;
            val_16 = offset + val_16;
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.trophy, endValue:  val_16, duration:  0.1f, snapping:  false), ease:  3));
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.05f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.trophyRenderer, endValue:  1f, duration:  0.2f), ease:  1));
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.1f, t:  this.SquashSequence());
            if(this.playAmountAnimation == false)
            {
                    return val_1;
            }
            
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.05f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation::PlayAmountAnimation()));
            return val_1;
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
        private DG.Tweening.Sequence SquashSequence()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.trophy, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f)));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.trophy, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  6f)));
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.trophy, endValue:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f)));
            return val_1;
        }
        private DG.Tweening.Sequence AnimateToIcon()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.trophy, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f)));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.trophy, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f)));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation::OnItemThrowStart()));
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  6f), t:  DG.Tweening.ShortcutExtensions.DOLocalMoveX(target:  this.trophy, endValue:  0f, duration:  0.3f, snapping:  false));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  6f), t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.trophy, endValue:  1f, duration:  0.3f, snapping:  false), animCurve:  this.throwCurve));
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  10f), t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.trophy, endValue:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  5f)));
            return val_1;
        }
        private DG.Tweening.Sequence AnimateEnd()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyScale, y = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_4, z = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_8}, d:  1.1f);
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.iconTrophyTransform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.1f));
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyShineScale, y = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_10, z = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_14}, d:  1.1f);
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.iconTrophyShineTransform, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.1f));
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyScale, y = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_4, z = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_8}, d:  0.9f);
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.iconTrophyTransform, endValue:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, duration:  0.1f));
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyShineScale, y = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_10, z = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_14}, d:  0.9f);
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.iconTrophyShineTransform, endValue:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, duration:  0.1f));
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.iconTrophyTransform, endValue:  new UnityEngine.Vector3() {x = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyScale, y = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_4, z = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_8}, duration:  0.1f));
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.iconTrophyShineTransform, endValue:  new UnityEngine.Vector3() {x = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyShineScale, y = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_10, z = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.KingsCupCollect.KingsCupCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_14}, duration:  0.1f));
            return val_1;
        }
        private void OnItemThrowStart()
        {
            if(this.audioManager != null)
            {
                    this.audioManager.PlaySound(type:  93, offset:  0.04f);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void OnItemReached()
        {
            this.trophy.gameObject.SetActive(value:  false);
            if(this.shouldPlayParticles == false)
            {
                    return;
            }
            
            this.hitParticles.Play();
        }
        private void OnAnimationEnd()
        {
            this.Invoke(methodName:  "Clear", time:  1f);
        }
        private void Clear()
        {
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        public KingsCupCollectAnimation()
        {
        
        }
    
    }

}
