using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassLastRowView : RoyalPassView
    {
        // Fields
        private static readonly int UnlockAnimation;
        private static readonly int BankAnimation;
        private const float BackgroundPatchLightAlpha = 0.2784314;
        private const float BackgroundPatchDarkAlpha = 0.3921569;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassBonusBankProgress bonusBankProgress;
        public UnityEngine.SpriteRenderer freeHighlightLeft;
        public UnityEngine.SpriteRenderer freeHighlightRight;
        public UnityEngine.SpriteRenderer goldHighlightLeft;
        public UnityEngine.SpriteRenderer goldHighlightRight;
        public UnityEngine.SpriteRenderer backgroundPatch;
        public UnityEngine.Transform containerParticleParent;
        public UnityEngine.Transform safeParticleParent;
        public UnityEngine.Transform safe;
        public UnityEngine.Transform safeShadow;
        public UnityEngine.Transform safeLidCenter;
        public TMPro.TextMeshPro descriptionWithBar;
        public TMPro.TextMeshPro descriptionWithoutBar;
        public UnityEngine.Transform lockParent;
        public UnityEngine.Animator lockAnimator;
        public UnityEngine.Animator safeAnimator;
        public UnityEngine.Transform bonusBankTitle;
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassLastRowContainerParticleView containerParticleView;
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassLastRowSafeParticleView safeParticleView;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        
        // Methods
        public void Init()
        {
            this.InitRoyalBankState();
            this.bonusBankProgress.Init();
            Royal.Infrastructure.Contexts.Units.CameraManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            float val_7 = val_1.cameraWidth;
            val_7 = val_7 * 0.25f;
            this.SetXPositionTransformAndXScale(spriteRenderer:  this.freeHighlightLeft, xPosition:  val_7 * (-0.25f), targetSize:  val_7);
            float val_8 = val_1.cameraWidth;
            val_8 = val_8 * 0.25f;
            this.SetXPositionTransformAndXScale(spriteRenderer:  this.freeHighlightRight, xPosition:  val_8 * (-0.25f), targetSize:  val_8);
            float val_9 = val_1.cameraWidth;
            val_9 = val_9 * 0.25f;
            this.SetXPositionTransformAndXScale(spriteRenderer:  this.goldHighlightLeft, xPosition:  val_9, targetSize:  val_9);
            float val_10 = val_1.cameraWidth;
            val_10 = val_10 * 0.25f;
            this.SetXPositionTransformAndXScale(spriteRenderer:  this.goldHighlightRight, xPosition:  val_10, targetSize:  val_10);
            float val_11 = 1.011f;
            val_11 = val_1.cameraWidth * val_11;
            this.SetXPositionTransformAndXSize(spriteRenderer:  this.backgroundPatch, xPosition:  0f, xSize:  val_11);
            this.SetTitlePosition();
            this.SetSafeParticle();
            this.SetContainerParticle();
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasRoyalPass) == false)
            {
                    return;
            }
            
            this.lockParent.gameObject.SetActive(value:  false);
        }
        private void SetTitlePosition()
        {
            UnityEngine.Transform val_1;
            float val_2;
            val_1 = this;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman != false)
            {
                    this.bonusBankTitle.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                val_1 = this.bonusBankTitle;
                val_2 = 2.18f;
            }
            else
            {
                    if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isSpanish == false)
            {
                    return;
            }
            
                this.bonusBankTitle.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                val_1 = this.bonusBankTitle;
                val_2 = 2.16f;
            }
            
            val_1.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private void SetSafeParticle()
        {
            if(this.safeParticleView != 0)
            {
                    return;
            }
            
            this.safeParticleView = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12).Spawn(poolId:  13, parent:  this.safeParticleParent, setParent:  true);
        }
        public void PlayBankStepReachedAnimations()
        {
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_1 = DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.backgroundPatch, endValue:  0.2784314f, duration:  0.4f);
            UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassBankStepReachedParticleView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassBankStepReachedParticleView>(path:  "RoyalPassBankStepReachedParticleView"), parent:  this.transform).PlayAndDestroy();
            this.audioManager.PlaySound(type:  23, offset:  0.04f);
        }
        public void AnimateBankHit()
        {
            this.safeAnimator.enabled = true;
            this.safeAnimator.Play(stateNameHash:  Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassLastRowView.BankAnimation, layer:  0, normalizedTime:  0f);
        }
        private void SetContainerParticle()
        {
            if(this.containerParticleView != 0)
            {
                    return;
            }
            
            this.containerParticleView = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12).Spawn(poolId:  12, parent:  this.containerParticleParent, setParent:  true);
        }
        private void InitRoyalBankState()
        {
            var val_17;
            Royal.Player.Context.Units.RoyalPassManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
            val_17 = 1;
            if(val_1.IsLastStep() != true)
            {
                    if(val_1.GetStep() == (val_1.GetSafeStepIndex() - 1))
            {
                    val_17 = val_1.WillStepUp();
            }
            else
            {
                    val_17 = 0;
            }
            
            }
            
            bool val_8 = val_1.IsSafeFull();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ChangeAlpha(sprite:  this.backgroundPatch, alpha:  (val_1.IsLastStep() != true) ? 0.2784314f : 0.3921569f);
            if((((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasRoyalPass) != true) ? ((val_17 != 1) ? ((val_8 != true) ? (1 + 1) : 1) : 0) : ((val_17 != 1) ? ((val_8 != true) ? (4 + 1) : 4) : 3)) > 5)
            {
                    return;
            }
            
            var val_17 = 36595680 + (val_2 != true ? val_17 != 0x1 ? val_8 != true ? (1 + 1) : 1 : 0 : val_17 != 0x1 ? val_8 != true ? (4 + 1) : 4 : 3) << 2;
            val_17 = val_17 + 36595680;
            goto (36595680 + (val_2 != true ? val_17 != 0x1 ? val_8 != true ? (1 + 1) : 1 : 0 : val_17 != 0x1 ? val_8 != true ? (4 + 1) : 4 : 3) << 2 + 36595680);
        }
        private void SetBarToDisabledStateAndRepositionSafe()
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  1.893f, y:  -0.024f);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            this.safe.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  1.873f, y:  -0.903f);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            this.safeShadow.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector3 val_5 = this.safe.localPosition;
            this.safeParticleParent.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            this.bonusBankProgress.gameObject.SetActive(value:  false);
            this.descriptionWithoutBar.gameObject.SetActive(value:  true);
            this.descriptionWithBar.gameObject.SetActive(value:  false);
        }
        public void AnimateGoldUnlock(float yThreshold)
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.PlayOpenLockAnimation(yThreshold:  yThreshold));
        }
        private System.Collections.IEnumerator PlayOpenLockAnimation(float yThreshold)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .yThreshold = yThreshold;
            return (System.Collections.IEnumerator)new RoyalPassLastRowView.<PlayOpenLockAnimation>d__33();
        }
        public void PlayOpenLockParticles()
        {
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassGoldRewardOpenLockParticles val_3 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassGoldRewardOpenLockParticles>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassGoldRewardOpenLockParticles>(path:  "RoyalPassGoldRewardOpenLockParticles"), parent:  this.lockParent.transform);
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            val_3.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            val_3.PlayAndDestroy();
        }
        public void PlayLockedAnimation()
        {
            UnityEngine.Transform val_36 = this.lockParent;
            if(val_36 == 0)
            {
                    return;
            }
            
            val_36 = this.lockParent;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(d:  0.9f, a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            float val_3 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f);
            DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(d:  -1f, a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.ShortcutExtensions.DORotate(target:  val_36, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  val_3, mode:  0));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_4, atPosition:  0f, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_36, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  val_3));
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_4, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassLastRowView::<PlayLockedAnimation>b__35_0()));
            float val_12 = val_3 + val_3;
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.ShortcutExtensions.DORotate(target:  val_36, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  val_12, mode:  0));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_4, atPosition:  val_3, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_36, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  val_3));
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_4, atPosition:  val_12, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_36, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  val_3));
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(d:  -1f, a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.ShortcutExtensions.DORotate(target:  val_36, endValue:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, duration:  val_12, mode:  0));
            float val_36 = 3f;
            val_36 = val_3 * val_36;
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_4, atPosition:  val_36, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_36, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  val_3));
            float val_37 = 4f;
            val_37 = val_3 * val_37;
            DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_4, atPosition:  val_37, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_36, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  val_3));
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.ShortcutExtensions.DORotate(target:  val_36, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  val_12, mode:  0));
            float val_38 = 5f;
            val_38 = val_3 * val_38;
            DG.Tweening.Sequence val_29 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_4, atPosition:  val_38, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_36, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  val_3));
            float val_39 = 6f;
            val_39 = val_3 * val_39;
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_4, atPosition:  val_39, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_36, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  val_3));
            DG.Tweening.Sequence val_33 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.ShortcutExtensions.DORotate(target:  val_36, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  val_3, mode:  0));
            float val_40 = 7f;
            val_40 = val_3 * val_40;
            DG.Tweening.Sequence val_35 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_4, atPosition:  val_40, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_36, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  val_3));
        }
        public override int GetPoolId()
        {
            return 1;
        }
        public UnityEngine.Vector3 GetBankPosition()
        {
            if(this.safeLidCenter != null)
            {
                    return this.safeLidCenter.position;
            }
            
            throw new NullReferenceException();
        }
        public RoyalPassLastRowView()
        {
        
        }
        private static RoyalPassLastRowView()
        {
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassLastRowView.BackgroundPatchDarkAlpha = UnityEngine.Animator.StringToHash(name:  "Base Layer.RoyalPassUnlockAnimation");
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassLastRowView.BankAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.RoyalPassLastRowBankAnimation");
        }
        private void <PlayLockedAnimation>b__35_0()
        {
            if(this.audioManager != null)
            {
                    this.audioManager.PlaySound(type:  145, offset:  0.04f);
                return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
