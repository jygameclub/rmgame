using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.RoyalPassCollect
{
    public class RoyalPassCollectAnimation : MonoBehaviour
    {
        // Fields
        public UnityEngine.AnimationCurve throwCurve;
        public UnityEngine.ParticleSystem hitParticles;
        public UnityEngine.SpriteRenderer trophyRenderer;
        public TMPro.TextMeshPro amountText;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private UnityEngine.Transform trophy;
        private UnityEngine.Transform iconTrophyTransform;
        private static UnityEngine.Vector3 OriginalTrophyScale;
        private bool playAmountAnimation;
        private bool shouldPlayParticles;
        private UnityEngine.Vector3 collectKeyScale;
        
        // Methods
        private void Awake()
        {
            null = null;
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            UnityEngine.Transform val_2 = this.trophyRenderer.transform;
            this.trophy = val_2;
            UnityEngine.Vector3 val_3 = val_2.localScale;
            this.collectKeyScale = val_3;
            mem[1152921519118340056] = val_3.y;
            mem[1152921519118340060] = val_3.z;
            this.iconTrophyTransform = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_byval_arg + 80 + 24.transform;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.RoyalPassCollect.RoyalPassCollectAnimation.OriginalTrophyScale, y = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.RoyalPassCollect.RoyalPassCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_4, z = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.RoyalPassCollect.RoyalPassCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_8}, rhs:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z})) == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_7 = this.iconTrophyTransform.localScale;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.RoyalPassCollect.RoyalPassCollectAnimation.OriginalTrophyScale = val_7.x;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.RoyalPassCollect.RoyalPassCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_4 = val_7.y;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.RoyalPassCollect.RoyalPassCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_8 = val_7.z;
        }
        public DG.Tweening.Sequence Play(int amount = 0, float xOffset = 0, float yOffset = 0, bool shouldPlayParticles = False)
        {
            this.shouldPlayParticles = shouldPlayParticles;
            this.BeforeAnimation(amount:  amount, offset:  xOffset);
            DG.Tweening.TweenCallback val_8 = new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.RoyalPassCollect.RoyalPassCollectAnimation::OnItemReached());
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.DOTween.Sequence(), t:  this.AnimateStart(offset:  yOffset)), interval:  0.2f), t:  this.AnimateToIcon()), callback:  val_8), t:  this.AnimateEnd());
            System.Delegate val_13 = System.Delegate.Combine(a:  val_8, b:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.RoyalPassCollect.RoyalPassCollectAnimation::OnAnimationEnd()));
            if(val_13 != null)
            {
                    if(null != null)
            {
                goto label_5;
            }
            
            }
            
            val_14 = val_13;
            return (DG.Tweening.Sequence)val_14;
            label_5:
        }
        private void BeforeAnimation(int amount, float offset)
        {
            UnityEngine.Vector3 val_1 = this.iconTrophyTransform.position;
            this.transform.position = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.left;
            float val_11 = 1.64f;
            val_11 = offset + val_11;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  val_11);
            this.trophy.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            this.trophy.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  -8.160001f);
            this.trophy.localRotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w};
            UnityEngine.Color val_7 = this.trophyRenderer.color;
            this.trophyRenderer.color = new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = 0f};
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            this.amountText.transform.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
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
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.trophy, endValue:  new UnityEngine.Vector3() {x = this.collectKeyScale}, duration:  0.1f), ease:  3));
            float val_15 = -0.18f;
            val_15 = offset + val_15;
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.trophy, endValue:  val_15, duration:  0.1f, snapping:  false), ease:  3));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.05f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.trophyRenderer, endValue:  1f, duration:  0.2f), ease:  1));
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.1f, t:  this.SquashSequence());
            if(this.playAmountAnimation == false)
            {
                    return val_1;
            }
            
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.05f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.RoyalPassCollect.RoyalPassCollectAnimation::PlayAmountAnimation()));
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
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(d:  this.collectKeyScale, a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.trophy, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f)));
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(d:  this.collectKeyScale, a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.trophy, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  6f)));
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.trophy, endValue:  new UnityEngine.Vector3() {x = this.collectKeyScale, y = val_6.y, z = val_6.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f)));
            return val_1;
        }
        private DG.Tweening.Sequence AnimateToIcon()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(d:  this.collectKeyScale, a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.trophy, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f)));
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(d:  this.collectKeyScale, a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.trophy, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f)));
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.RoyalPassCollect.RoyalPassCollectAnimation::OnItemThrowStart()));
            float val_12 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  6f);
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  val_12, t:  DG.Tweening.ShortcutExtensions.DOLocalMoveX(target:  this.trophy, endValue:  0f, duration:  0.3f, snapping:  false));
            float val_15 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  6f);
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  val_15, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.trophy, endValue:  1f, duration:  0.3f, snapping:  false), animCurve:  this.throwCurve));
            DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  10f), t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.trophy, endValue:  new UnityEngine.Vector3() {x = this.collectKeyScale, y = val_15, z = val_12}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  5f)));
            return val_1;
        }
        private DG.Tweening.Sequence AnimateEnd()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.RoyalPassCollect.RoyalPassCollectAnimation.OriginalTrophyScale, y = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.RoyalPassCollect.RoyalPassCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_4, z = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.RoyalPassCollect.RoyalPassCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_8}, d:  1.1f);
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.iconTrophyTransform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.1f));
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.RoyalPassCollect.RoyalPassCollectAnimation.OriginalTrophyScale, y = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.RoyalPassCollect.RoyalPassCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_4, z = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.RoyalPassCollect.RoyalPassCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_8}, d:  0.9f);
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.iconTrophyTransform, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.1f));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.iconTrophyTransform, endValue:  new UnityEngine.Vector3() {x = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.RoyalPassCollect.RoyalPassCollectAnimation.OriginalTrophyScale, y = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.RoyalPassCollect.RoyalPassCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_4, z = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.RoyalPassCollect.RoyalPassCollectAnimation.OriginalTrophyScale.__il2cppRuntimeField_8}, duration:  0.1f));
            return val_1;
        }
        private void OnItemThrowStart()
        {
            if(this.audioManager != null)
            {
                    this.audioManager.PlaySound(type:  94, offset:  0.04f);
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
        public RoyalPassCollectAnimation()
        {
        
        }
    
    }

}
