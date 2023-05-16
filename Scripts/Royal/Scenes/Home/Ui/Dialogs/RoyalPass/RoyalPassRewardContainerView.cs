using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassRewardContainerView : MonoBehaviour
    {
        // Fields
        private static readonly int UnlockAnimation;
        public UnityEngine.GameObject rewardParent;
        public Royal.Infrastructure.UiComponents.Button.UiScrollButton rootButton;
        public UnityEngine.Transform lockParent;
        public UnityEngine.Animator lockAnimator;
        public UnityEngine.Transform tickParticleParent;
        public UnityEngine.Transform tickImage;
        public UnityEngine.GameObject tooltipPrefab;
        public UnityEngine.GameObject chestTooltipPrefab;
        public UnityEngine.GameObject leftFrame;
        private bool isChestReward;
        private Royal.Player.Context.Units.RoyalPassManager royalPassManager;
        private Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        private Royal.Scenes.Start.Context.Units.Flow.FlowManager flowManager;
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPopup royalPassPopup;
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep stepConfig;
        private int step;
        private bool isFree;
        private UnityEngine.Bounds claimButtonMaskBounds;
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardClaimButtonView claimButtonView;
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassGoldRewardParticleView goldRewardParticleView;
        
        // Methods
        public void Awake()
        {
            this.royalPassManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.flowManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
        }
        public void UpdateView(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPopup royalPassPopup, Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassReward royalPassReward, Royal.Player.Context.Units.RewardName rewardName, int step, bool isFree, UnityEngine.Bounds maskBounds)
        {
            int val_29;
            Royal.Player.Context.Units.RewardName val_30;
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassReward val_31;
            bool val_32;
            var val_33;
            var val_34;
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardClaimButtonView val_36;
            val_29 = step;
            val_30 = rewardName;
            val_31 = royalPassReward;
            this.royalPassPopup = royalPassPopup;
            this.step = val_29;
            this.isFree = isFree;
            this.stepConfig = this.royalPassManager.GetStepInfo(step:  val_29);
            float val_27 = this.cameraManager.cameraWidth;
            val_27 = ((isFree != true) ? -1f : 1f) * (val_27 * 0.25f);
            val_27 = ((isFree != true) ? 0.845f : 0.926f) + val_27;
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_27, y:  0.04f);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            if(isFree != false)
            {
                    val_32 = 0;
                val_33 = 0;
            }
            else
            {
                    val_32 = (Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasRoyalPass) ^ 1;
                val_33 = val_32;
                this.lockParent.gameObject.SetActive(value:  val_32);
            }
            
            val_34 = 0;
            mem[1152921519237362040] = maskBounds.m_Extents.y;
            this.claimButtonMaskBounds = maskBounds.m_Center.x;
            if((val_32 != true) && (0 > val_29))
            {
                    bool val_12 = isFree;
                val_34 = 0;
            }
            
            this.rootButton = maskBounds.m_Extents.y;
            this.rootButton = maskBounds.m_Center.x;
            Royal.Infrastructure.UiComponents.Button.UiScrollButton val_28 = ~this.IsFirstGoldReward();
            val_28 = val_28 & 1;
            this.rootButton = val_28;
            val_36 = this.claimButtonView;
            if(1179403647 == 0)
            {
                goto label_18;
            }
            
            if(val_36 != 0)
            {
                goto label_21;
            }
            
            val_36 = this.royalPassManager.Spawn(poolId:  8, parent:  this.rootButton.transform, setParent:  true);
            this.claimButtonView = val_36;
            goto label_27;
            label_18:
            if(val_36 == 0)
            {
                goto label_32;
            }
            
            this.royalPassManager.Recycle(item:  this.claimButtonView);
            this.claimButtonView = 0;
            goto label_32;
            label_21:
            val_36 = this.claimButtonView;
            label_27:
            val_32 = this.stepConfig.r.IsChestReward();
            val_36.Init(maskBounds:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = this.claimButtonMaskBounds.m_Center, y = this.claimButtonMaskBounds.m_Center, z = this.claimButtonMaskBounds.m_Center}, m_Extents = new UnityEngine.Vector3() {x = this.claimButtonMaskBounds.m_Center, y = mem[this.claimButtonMaskBounds + 16], z = mem[this.claimButtonMaskBounds + 16]}}, buttonText:  royalPassPopup.claimButtonText, claimAction:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardContainerView::Claim()), isChestReward:  val_32, containerTransform:  this.transform, rootTransform:  this.rootButton.transform);
            val_30 = val_30;
            val_31 = val_31;
            val_33 = val_33;
            val_29 = val_29;
            label_32:
            bool val_23 = isFree;
            this.tickImage.gameObject.SetActive(value:  ((val_33 == false) ? 1 : 0) &);
            this.RecycleOldRewardIfPresent();
            this.AddNewReward(royalPassReward:  val_31, rewardName:  val_30);
            if(isFree == true)
            {
                    return;
            }
            
            this.AddGoldParticleViewIfNotPresent();
        }
        private void AddGoldParticleViewIfNotPresent()
        {
            if(this.goldRewardParticleView != 0)
            {
                    return;
            }
            
            this.goldRewardParticleView = this.royalPassManager.Spawn(poolId:  11, parent:  this.rootButton.transform, setParent:  true);
        }
        public void EnableClaimButtonAnimated(float delay)
        {
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardClaimButtonView val_23;
            if(this.claimButtonView == 0)
            {
                    val_23 = this.royalPassManager.Spawn(poolId:  8, parent:  this.rootButton.transform, setParent:  true);
                this.claimButtonView = val_23;
            }
            else
            {
                    val_23 = this.claimButtonView;
            }
            
            val_23.Init(maskBounds:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = this.claimButtonMaskBounds, y = this.claimButtonMaskBounds, z = this.claimButtonMaskBounds}, m_Extents = new UnityEngine.Vector3() {x = this.claimButtonMaskBounds, y = UnityEngine.Object.__il2cppRuntimeField_cctor_finished, z = UnityEngine.Object.__il2cppRuntimeField_cctor_finished}}, buttonText:  this.royalPassPopup.claimButtonText, claimAction:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardContainerView::Claim()), isChestReward:  this.stepConfig.r.IsChestReward(), containerTransform:  this.transform, rootTransform:  this.rootButton.transform);
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.one;
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.zero;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
            this.claimButtonView.transform.localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            UnityEngine.Vector3 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
            DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.DOTween.Sequence(), t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.claimButtonView.transform, endValue:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  35f)), ease:  27, overshoot:  1.2f), delay:  delay)), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardContainerView::<EnableClaimButtonAnimated>b__24_0()));
        }
        public void EnableTickAnimated(float delay)
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.one;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            this.tickImage.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.DOTween.Sequence(), t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tickImage.transform, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  35f)), ease:  27, overshoot:  1.2f)), atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardContainerView::<EnableTickAnimated>b__25_0())), delay:  delay);
            this.tickImage.gameObject.SetActive(value:  true);
        }
        private System.Collections.IEnumerator PlayOpenLockAnimation(float yThreshold)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .yThreshold = yThreshold;
            return (System.Collections.IEnumerator)new RoyalPassRewardContainerView.<PlayOpenLockAnimation>d__26();
        }
        public void PlayOpenLockParticles()
        {
            UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassGoldRewardOpenLockParticles>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassGoldRewardOpenLockParticles>(path:  "RoyalPassGoldRewardOpenLockParticles"), parent:  this.rootButton.transform).PlayAndDestroy();
        }
        private void PlayLockedAnimation(bool isSilent)
        {
            .isSilent = isSilent;
            if(this.lockParent == 0)
            {
                    return;
            }
            
            this = this.lockParent;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(d:  0.9f, a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            float val_5 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f);
            DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(d:  -1f, a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.ShortcutExtensions.DORotate(target:  this, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  val_5, mode:  0));
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_6, atPosition:  0f, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  val_5));
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_6, callback:  new DG.Tweening.TweenCallback(object:  new RoyalPassRewardContainerView.<>c__DisplayClass28_0(), method:  System.Void RoyalPassRewardContainerView.<>c__DisplayClass28_0::<PlayLockedAnimation>b__0()));
            float val_14 = val_5 + val_5;
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.ShortcutExtensions.DORotate(target:  this, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  val_14, mode:  0));
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_6, atPosition:  val_5, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  val_5));
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_6, atPosition:  val_14, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  val_5));
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(d:  -1f, a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.ShortcutExtensions.DORotate(target:  this, endValue:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, duration:  val_14, mode:  0));
            float val_38 = 3f;
            val_38 = val_5 * val_38;
            DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_6, atPosition:  val_38, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  val_5));
            float val_39 = 4f;
            val_39 = val_5 * val_39;
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_6, atPosition:  val_39, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  val_5));
            DG.Tweening.Sequence val_29 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.ShortcutExtensions.DORotate(target:  this, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  val_14, mode:  0));
            float val_40 = 5f;
            val_40 = val_5 * val_40;
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_6, atPosition:  val_40, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  val_5));
            float val_41 = 6f;
            val_41 = val_5 * val_41;
            DG.Tweening.Sequence val_33 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_6, atPosition:  val_41, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  val_5));
            DG.Tweening.Sequence val_35 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.ShortcutExtensions.DORotate(target:  this, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  val_5, mode:  0));
            float val_42 = 7f;
            val_42 = val_5 * val_42;
            DG.Tweening.Sequence val_37 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_6, atPosition:  val_42, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  val_5));
        }
        public void AnimateGoldUnlocks(float yThreshold)
        {
            if(this.step != 0)
            {
                    UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.PlayOpenLockAnimation(yThreshold:  yThreshold));
            }
            else
            {
                    this.EnableTickAnimated(delay:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  20f));
            }
            
            if(0 <= this.step)
            {
                    return;
            }
            
            if(( & 1) != 0)
            {
                    return;
            }
            
            this.EnableClaimButtonAnimated(delay:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  80f));
        }
        public void Claim()
        {
            if(this.isFree == false)
            {
                goto label_4;
            }
            
            if((0 & 1) == 0)
            {
                goto label_5;
            }
            
            goto label_9;
            label_4:
            if(((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasRoyalPass) ^ 1) == true)
            {
                goto label_9;
            }
            
            label_5:
            if(0 > this.step)
            {
                    if((1747328400 & 1) == 0)
            {
                goto label_10;
            }
            
            }
            
            label_9:
            if(this.IsFirstGoldReward() != false)
            {
                    this.royalPassPopup.ShowRoyalPassPurchase();
                return;
            }
            
            this.ShowTooltip();
            return;
            label_10:
            this.flowManager.StartNextActionMode();
            this.PlayCollectAnimation(progress:  new Royal.Player.Context.Data.Persistent.RoyalPassProgress() {<GoldProgress>k__BackingField = Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_generic_class, isGold = Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_generic_class, eventId = Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_generic_class});
            if(this.royalPassManager.currentTutorialStep == 3)
            {
                    this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.ShowRoyalPassPopupAction(claimData:  new System.Nullable<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassClaimData>() {HasValue = false}, isAfterPurchase:  false));
            }
            
            this.flowManager.FinishNextActionMode();
            this.royalPassPopup.Close(isClaimAction:  true);
            this.royalPassPopup.KeepScrollPosition(reset:  true);
        }
        public void CardClicked()
        {
            if(this.isFree != true)
            {
                    if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasRoyalPass) != true)
            {
                    this.PlayLockedAnimation(isSilent:  this.IsFirstGoldReward());
            }
            
            }
            
            if(this.stepConfig.r.IsChestReward() == false)
            {
                goto label_7;
            }
            
            if(( & 1) == 0)
            {
                goto label_11;
            }
            
            this.ShowTooltip();
            return;
            label_7:
            this.Claim();
            return;
            label_11:
            Royal.Infrastructure.UiComponents.Dialog.DialogManager val_5 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Dialog.DialogManager>(id:  13);
            UnityEngine.Vector3 val_8 = this.rootButton.transform.position;
            UnityEngine.GameObject val_9 = val_5.toolTipManager.ToggleTooltip(parent:  this.transform, touchable:  this.rootButton, pos:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, toolTip:  this.chestTooltipPrefab);
            var val_10 = (this.isFree == false) ? 40 : 24;
            if(val_9 == 0)
            {
                    return;
            }
            
            val_9.GetComponent<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardChestTooltip>().Prepare(isFree:  (this.isFree == true) ? 1 : 0, rewards:  1152921505036238848, step:  this.stepConfig.s);
        }
        public void ShowTooltip()
        {
            Royal.Infrastructure.UiComponents.Dialog.DialogManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Dialog.DialogManager>(id:  13);
            UnityEngine.Vector3 val_4 = this.rootButton.transform.position;
            UnityEngine.GameObject val_5 = val_1.toolTipManager.ToggleTooltip(parent:  this.transform, touchable:  this.rootButton, pos:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, toolTip:  this.tooltipPrefab);
            if(val_5 == 0)
            {
                    return;
            }
            
            this = val_5.GetComponent<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardTooltip>();
            this.Prepare(isClaimed:  false, isCompletedStep:  (0 > this.step) ? 1 : 0, isFree:  (this.isFree == true) ? 1 : 0, hasRoyalPass:  Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasRoyalPass);
        }
        private bool IsFirstGoldReward()
        {
            if(this.step == 0)
            {
                    if(this.isFree == false)
            {
                goto label_1;
            }
            
            }
            
            return (bool)0 & 1;
            label_1:
            bool val_3 = (Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasRoyalPass) ^ 1;
            return (bool)0 & 1;
        }
        private void PlayCollectAnimation(Royal.Player.Context.Data.Persistent.RoyalPassProgress progress)
        {
            bool val_10;
            var val_11;
            var val_12;
            Royal.Player.Context.Data.InventoryPackage val_3 = Royal.Player.Context.Data.InventoryPackage.GetRoyalPassPackage(step:  this.stepConfig, isFree:  this.isFree);
            Royal.Player.Context.Units.UserManager.AddInventoryPackage(package:  val_3);
            val_10 = 1152921505124790272;
            if(this.GetRewardName() != 0)
            {
                    Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg.AddCoin(coins:  val_3.coins);
                if(val_3.coins >= 1)
            {
                    Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg.AddCoin(coins:  val_3.coins);
                val_11 = null;
                val_11 = null;
                Royal.Scenes.Home.Ui.__il2cppRuntimeField_30.PrepareCoinTextForAnimation();
            }
            
                if(val_3.unlimitedLifetimeMin >= 1)
            {
                    val_12 = null;
                val_12 = null;
                Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData val_4 = new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData(minutes:  val_3.unlimitedLifetimeMin, count:  0);
                Royal.Scenes.Home.Ui.__il2cppRuntimeField_38.PrepareTextForAnimation(animationData:  new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData() {lifeCount = val_4.lifeCount, unlimitedMinutes = val_4.lifeCount});
            }
            
                val_10 = this.isFree;
                this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.PlayRoyalPassClaimAction(stepConfig:  this.stepConfig, isFreeRewardAction:  val_10));
            }
            else
            {
                    Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg.AddPackage(package:  val_3);
                this.PlaySingleRewardCollectAnimation(rewardType:  this.GetRewardType(), inventoryPackage:  val_3);
            }
            
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).SendDataToBackend(forceToSend:  false, forceScoreData:  false);
            Royal.Player.Context.Units.RoyalPassManager val_7 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).PassClaim(eventId:  val_7.<EventId>k__BackingField, stage:  progress.step, claimStage:  this.step, safeStage:  this.royalPassManager.GetSafeStepIndex(), isFree:  this.isFree, package:  val_3);
        }
        private void PlaySingleRewardCollectAnimation(Royal.Player.Context.Units.RewardType rewardType, Royal.Player.Context.Data.InventoryPackage inventoryPackage)
        {
            if(rewardType == 2)
            {
                goto label_1;
            }
            
            if(rewardType != 1)
            {
                goto label_2;
            }
            
            .before = Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 40 + 20;
            .shouldConsume = true;
            .after = Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 40 + 24;
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.PlayRoyalPassCoinCollectAnimationAction(delay:  0f, beforeAfterData:  new Royal.Player.Context.Data.Session.BeforeAfterData()));
            Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 40 = 0;
            return;
            label_1:
            label_12:
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.PlayRoyalPassLifeCollectAnimationAction(delay:  1.5f, minutes:  inventoryPackage.unlimitedLifetimeMin, lifeCount:  0));
            return;
            label_2:
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.PlayRoyalPassRewardItemAnimationAction val_4 = new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.PlayRoyalPassRewardItemAnimationAction(delay:  0.5f);
            if(this.flowManager != null)
            {
                goto label_12;
            }
            
            throw new NullReferenceException();
        }
        private Royal.Player.Context.Units.RewardType GetRewardType()
        {
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassReward[] val_1;
            if(this.isFree != false)
            {
                    val_1 = this.stepConfig.r.f;
                if(val_1 != null)
            {
                    return val_1[0].GetRewardType();
            }
            
            }
            
            val_1 = this.stepConfig.r.g;
            return val_1[0].GetRewardType();
        }
        private Royal.Player.Context.Units.RewardName GetRewardName()
        {
            if(this.isFree == false)
            {
                    return this.stepConfig.r.GetGoldChestName();
            }
            
            return this.stepConfig.r.GetFreeChestName();
        }
        private void RecycleOldRewardIfPresent()
        {
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardView val_1 = this.rewardParent.GetComponentInChildren<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardView>();
            if(val_1 == 0)
            {
                    return;
            }
            
            this.royalPassManager.Recycle(item:  val_1);
        }
        private void AddNewReward(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassReward royalPassReward, Royal.Player.Context.Units.RewardName rewardName)
        {
            UnityEngine.Object val_18;
            var val_19;
            var val_20;
            if(this.step == 0)
            {
                    if(this.isFree == false)
            {
                goto label_2;
            }
            
            }
            
            label_29:
            if(rewardName == 0)
            {
                goto label_3;
            }
            
            val_18 = this.royalPassManager.Spawn(poolId:  6, parent:  this.rewardParent.transform, setParent:  true);
            val_18.InitForChest(rewardName:  rewardName);
            label_43:
            if(val_18 == 0)
            {
                    return;
            }
            
            if(this.isFree == false)
            {
                goto label_12;
            }
            
            val_19 = 0;
            if(val_18 != null)
            {
                goto label_13;
            }
            
            label_3:
            if(royalPassReward == null)
            {
                goto label_43;
            }
            
            Royal.Player.Context.Units.RewardType val_4 = royalPassReward.GetRewardType();
            if(((0 & 0) != 0) || ((-1) > 12))
            {
                goto label_43;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassView val_6 = this.royalPassManager.Spawn(poolId:  3, parent:  this.rewardParent.transform, setParent:  true);
            val_18 = val_6;
            if(val_6 == null)
            {
                goto label_43;
            }
            
            val_20 = 1152921505038475264;
            throw new NullReferenceException();
            label_12:
            val_19 = (Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasRoyalPass) ^ 1;
            label_13:
            bool val_8 = val_19;
            return;
            label_2:
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassView val_10 = this.royalPassManager.Spawn(poolId:  7, parent:  this.rewardParent.transform, setParent:  true);
            val_18 = val_10;
            if(val_10 == null)
            {
                goto label_29;
            }
            
            throw new NullReferenceException();
        }
        public RoyalPassRewardContainerView()
        {
        
        }
        private static RoyalPassRewardContainerView()
        {
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardContainerView.UnlockAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.RoyalPassUnlockAnimation");
        }
        private void <EnableClaimButtonAnimated>b__24_0()
        {
            this.enabled = true;
        }
        private void <EnableTickAnimated>b__25_0()
        {
            if(this.royalPassManager.currentTutorialStep == 4)
            {
                    return;
            }
            
            UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassClaimCheckParticleView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassClaimCheckParticleView>(path:  "RoyalPassClaimCheckParticleView"), parent:  this.tickParticleParent).PlayAndDestroy();
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16).PlaySound(type:  241, offset:  0.04f);
        }
    
    }

}
