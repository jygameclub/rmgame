using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassRow : UiScrollContentItem
    {
        // Fields
        public UnityEngine.GameObject root;
        public TMPro.TextMeshPro step;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassTokenTextPositioner stepPositioner;
        public UnityEngine.Transform separator;
        public UnityEngine.Transform topBound;
        public UnityEngine.Transform bottomBound;
        public UnityEngine.Transform tokenTopBound;
        public UnityEngine.Transform tokenBottomBound;
        public UnityEngine.SpriteRenderer topProgressBar;
        public UnityEngine.SpriteRenderer bottomProgressBar;
        public UnityEngine.GameObject star;
        public UnityEngine.SpriteRenderer token;
        public UnityEngine.SpriteRenderer animationToken;
        public UnityEngine.SpriteRenderer backgroundPatch;
        public UnityEngine.Sprite greenToken;
        public UnityEngine.Material greenMaterial;
        public UnityEngine.Sprite blueToken;
        public UnityEngine.Material blueMaterial;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardContainerView freeRewardContainer;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardContainerView paidRewardContainer;
        public UnityEngine.SpriteRenderer freeHighlightLeft;
        public UnityEngine.SpriteRenderer freeHighlightRight;
        public UnityEngine.SpriteRenderer goldHighlightLeft;
        public UnityEngine.SpriteRenderer goldHighlightRight;
        public UnityEngine.SpriteRenderer fleur;
        public Royal.Infrastructure.UiComponents.Button.UiScrollButton frameButton;
        public UnityEngine.GameObject tooltipPrefab;
        private int stepValue;
        private const float BackgroundPatchLightAlpha = 0.2784314;
        private const float BackgroundPatchDarkAlpha = 0.3921569;
        private const float TotalTopBarSize = 2.249208;
        private const float BottomWidth = 0.2071429;
        private Royal.Player.Context.Units.RoyalPassManager royalPassManager;
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPopup royalPassPopup;
        private bool hasFirstRow;
        private bool hasLastRow;
        
        // Methods
        public void Awake()
        {
            this.royalPassManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
            Royal.Infrastructure.Contexts.Units.CameraManager val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.SetFleur();
            float val_5 = val_2.cameraWidth;
            val_5 = val_5 * 0.25f;
            this.SetXPositionTransformAndXScale(spriteRenderer:  this.freeHighlightLeft, xPosition:  val_5 * (-0.25f), targetSize:  val_5);
            float val_6 = val_2.cameraWidth;
            val_6 = val_6 * 0.25f;
            this.SetXPositionTransformAndXScale(spriteRenderer:  this.freeHighlightRight, xPosition:  val_6 * (-0.25f), targetSize:  val_6);
            float val_7 = val_2.cameraWidth;
            val_7 = val_7 * 0.25f;
            this.SetXPositionTransformAndXScale(spriteRenderer:  this.goldHighlightLeft, xPosition:  val_7, targetSize:  val_7);
            float val_8 = val_2.cameraWidth;
            val_8 = val_8 * 0.25f;
            this.SetXPositionTransformAndXScale(spriteRenderer:  this.goldHighlightRight, xPosition:  val_8, targetSize:  val_8);
            float val_9 = 1.011f;
            val_9 = val_2.cameraWidth * val_9;
            this.SetXPositionTransformAndXSize(spriteRenderer:  this.backgroundPatch, xPosition:  0f, xSize:  val_9);
        }
        private void SetFleur()
        {
            Royal.Infrastructure.Contexts.Units.CameraManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            float val_6 = val_1.cameraWidth;
            val_6 = (val_6 * 0.5f) + (val_6 * 0.5f);
            val_6 = val_6 / 1.257143f;
            int val_3 = UnityEngine.Mathf.CeilToInt(f:  val_6);
            var val_4 = (val_3 < 0) ? (val_3 + 1) : (val_3);
            val_4 = val_4 & 4294967294;
            val_4 = val_3 - val_4;
            var val_5 = (val_4 != 1) ? (2 + 1) : 2;
            val_5 = val_5 + val_3;
            float val_7 = (float)val_5;
            val_7 = val_7 * 1.257143f;
            val_3.SetXPositionTransformAndXSize(spriteRenderer:  this.fleur, xPosition:  -0.9970143f, xSize:  val_7);
        }
        private void IncrementXScale(UnityEngine.Transform transform, float extraScale)
        {
            UnityEngine.Vector3 val_1 = transform.localScale;
            val_1.x = val_1.x + extraScale;
            transform.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        private void SetXPositionTransformAndXScale(UnityEngine.SpriteRenderer spriteRenderer, float xPosition, float targetSize)
        {
            UnityEngine.Vector3 val_2 = spriteRenderer.transform.localPosition;
            spriteRenderer.transform.localPosition = new UnityEngine.Vector3() {x = xPosition, y = val_2.y, z = val_2.z};
            UnityEngine.Vector2 val_4 = spriteRenderer.size;
            UnityEngine.Vector3 val_6 = spriteRenderer.transform.localScale;
            spriteRenderer.transform.localScale = new UnityEngine.Vector3() {x = targetSize / val_4.x, y = val_6.y, z = val_6.z};
        }
        private void SetXPositionTransformAndXSize(UnityEngine.SpriteRenderer spriteRenderer, float xPosition, float xSize)
        {
            UnityEngine.Vector3 val_2 = spriteRenderer.transform.localPosition;
            spriteRenderer.transform.localPosition = new UnityEngine.Vector3() {x = xPosition, y = val_2.y, z = val_2.z};
            UnityEngine.Vector2 val_4 = spriteRenderer.size;
            spriteRenderer.size = new UnityEngine.Vector2() {x = xSize, y = val_4.y};
        }
        public override void Prepare(Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data, UnityEngine.Bounds maskBounds)
        {
            if(data == null)
            {
                    return;
            }
            
            if(null == null)
            {
                goto label_2;
            }
            
            if(null == null)
            {
                goto label_3;
            }
            
            if(null != null)
            {
                    return;
            }
            
            data.System.IDisposable.Dispose();
            this.UpdateView(stepRow:  new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStepRowData() {step = 524918784, freeReward = 1152921505131765760, freeRewardName = ???, goldReward = ???}, maskBounds:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = maskBounds.m_Center.x}, m_Extents = new UnityEngine.Vector3() {y = maskBounds.m_Extents.y}});
            return;
            label_2:
            data.System.IDisposable.Dispose();
            this.UpdateView(firstRowData:  new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassFirstRowData(), maskBounds:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = maskBounds.m_Center.x}, m_Extents = new UnityEngine.Vector3() {y = maskBounds.m_Extents.y}});
            return;
            label_3:
            data.System.IDisposable.Dispose();
            this.UpdateView(lastRowData:  new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassLastRowData());
        }
        public void SetRoyalPassPopup(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPopup royalPassPopup)
        {
            this.royalPassPopup = royalPassPopup;
        }
        private void UpdateView(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassFirstRowData firstRowData, UnityEngine.Bounds maskBounds)
        {
            var val_6;
            if(this.hasFirstRow == true)
            {
                    return;
            }
            
            this.HideLastRowIfPresent();
            this.root.SetActive(value:  false);
            val_6 = this.royalPassManager.Spawn(poolId:  0, parent:  this.transform, setParent:  true);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            val_6.transform.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            val_6.Init(maskBounds:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = maskBounds.m_Center.x}, m_Extents = new UnityEngine.Vector3() {y = maskBounds.m_Extents.y}}, showRoyalPassPurchase:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRow::ShowRoyalPassPurchase()));
            this.hasFirstRow = true;
        }
        private void UpdateView(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassLastRowData lastRowData)
        {
            if(this.hasLastRow == true)
            {
                    return;
            }
            
            this.HideFirstRowIfPresent();
            this.root.SetActive(value:  false);
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassView val_2 = this.royalPassManager.Spawn(poolId:  1, parent:  this.transform, setParent:  true);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            val_2.transform.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            val_2.Init();
            this.hasLastRow = true;
        }
        private void UpdateView(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStepRowData stepRow, UnityEngine.Bounds maskBounds)
        {
            this.HideFirstRowIfPresent();
            this.HideLastRowIfPresent();
            this.root.SetActive(value:  true);
            this.step.text = stepRow.step.ToString();
            this.stepPositioner.UpdateTextPosition(num:  stepRow.step);
            this.freeRewardContainer.UpdateView(royalPassPopup:  this.royalPassPopup, royalPassReward:  stepRow.freeReward, rewardName:  1766850992, step:  stepRow.step, isFree:  true, maskBounds:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = maskBounds.m_Center.x}, m_Extents = new UnityEngine.Vector3() {y = maskBounds.m_Extents.y}});
            this.paidRewardContainer.UpdateView(royalPassPopup:  this.royalPassPopup, royalPassReward:  stepRow.goldReward, rewardName:  1766859184, step:  stepRow.step, isFree:  false, maskBounds:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = maskBounds.m_Center.x}, m_Extents = new UnityEngine.Vector3() {y = maskBounds.m_Extents.y}});
            this.EnableStepProgressedState(isEnabled:  (Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_interopData > stepRow.step) ? 1 : 0);
            this.EnableStarOverStep(hasStar:  (stepRow.step == 0) ? 1 : 0);
            this.TryShowHighlightIfInactive(currentStep:  stepRow.step);
            var val_4 = (Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_interopData < stepRow.step) ? 1 : 0;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ChangeAlpha(sprite:  this.backgroundPatch, alpha:  36595908 + Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_interopData < stepRow.step ? 1 : 0);
            this.frameButton = maskBounds.m_Extents.y;
            this.frameButton = maskBounds.m_Center.x;
            this.stepValue = stepRow.step;
        }
        private void ShowRoyalPassPurchase()
        {
            if(this.royalPassPopup != null)
            {
                    this.royalPassPopup.ShowRoyalPassPurchase();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void FinishStepUpAnimation()
        {
            this.freeRewardContainer.EnableClaimButtonAnimated(delay:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  8f));
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasRoyalPass) != false)
            {
                    this.paidRewardContainer.EnableClaimButtonAnimated(delay:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  8f));
            }
            
            this.animationToken.enabled = false;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  0.8428571f, y:  0.8428571f);
            this.animationToken.size = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
        }
        public float GetSeparatorPositionY()
        {
            UnityEngine.Vector3 val_1 = this.separator.position;
            return (float)val_1.y;
        }
        public void AnimateGoldUnlocks()
        {
            float val_2 = this.royalPassPopup.GetBottomYPositionOfTopUi() + 1f;
            this.paidRewardContainer.AnimateGoldUnlocks(yThreshold:  val_2);
            if(this.hasLastRow == false)
            {
                    return;
            }
            
            this = this.GetComponentInChildren<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassLastRowView>();
            if(this == 0)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.PlayOpenLockAnimation(yThreshold:  val_2));
        }
        public void AnimateJustClaimed(bool isFree)
        {
            if(isFree == false)
            {
                goto label_3;
            }
            
            if(this.freeRewardContainer != null)
            {
                goto label_4;
            }
            
            throw new NullReferenceException();
            label_3:
            label_4:
            this.paidRewardContainer.EnableTickAnimated(delay:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  20f));
        }
        private void EnableStepProgressedState(bool isEnabled)
        {
            this.UpdateBarSize(ratio:  (isEnabled != true) ? 1f : 0f);
            var val_2 = (isEnabled != true) ? 152 : 168;
            this.step.fontMaterial = null;
            var val_3 = (isEnabled != true) ? 144 : 160;
            this.token.sprite = null;
        }
        private void EnableStarOverStep(bool hasStar)
        {
            this.star.SetActive(value:  hasStar);
            this.step.gameObject.SetActive(value:  (~hasStar) & 1);
        }
        private void HideFirstRowIfPresent()
        {
            if(this.hasFirstRow == false)
            {
                    return;
            }
            
            this.royalPassManager.Recycle(item:  this.GetComponentInChildren<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassFirstRowView>());
            this.hasFirstRow = false;
        }
        private void HideLastRowIfPresent()
        {
            if(this.hasLastRow == false)
            {
                    return;
            }
            
            this.royalPassManager.Recycle(item:  this.GetComponentInChildren<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassLastRowView>());
            this.hasLastRow = false;
        }
        private void TryShowHighlightIfInactive(int currentStep)
        {
            if(this.royalPassPopup.royalPassScroll.content.isCurrentStepHighlightSet == true)
            {
                    return;
            }
            
            if(this.royalPassManager.GetStep() != currentStep)
            {
                    return;
            }
            
            this.royalPassPopup.royalPassScroll.content.SetCurrentStepHighlightTransform();
        }
        public void AnimateSafeCoinIncrement(UnityEngine.Vector3 initialPosition)
        {
            if((this.GetComponentInChildren<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassLastRowView>()) == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = val_1.safeLidCenter.position;
            val_1.bonusBankProgress.AnimateSafeCoinIncrement(initialPosition:  new UnityEngine.Vector3() {x = initialPosition.x, y = initialPosition.y, z = initialPosition.z}, finalPosition:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        }
        public void PlayBankStepReachedAnimations()
        {
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassLastRowView val_1 = this.GetComponentInChildren<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassLastRowView>();
            if(val_1 == 0)
            {
                    return;
            }
            
            val_1.PlayBankStepReachedAnimations();
        }
        public void ShowFrameTooltip()
        {
            Royal.Infrastructure.UiComponents.Dialog.DialogManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Dialog.DialogManager>(id:  13);
            UnityEngine.Vector3 val_4 = this.frameButton.transform.position;
            this = val_1.toolTipManager.ToggleTooltip(parent:  this.transform, touchable:  this.frameButton, pos:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, toolTip:  this.tooltipPrefab);
            if(this == 0)
            {
                    return;
            }
            
            this.GetComponent<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardTooltip>().PrepareFromFrame();
        }
        private void EnableBarSprites()
        {
            this.topProgressBar.gameObject.SetActive(value:  true);
            this.bottomProgressBar.gameObject.SetActive(value:  true);
        }
        private void DisableBarSprites()
        {
            this.topProgressBar.gameObject.SetActive(value:  false);
            this.bottomProgressBar.gameObject.SetActive(value:  false);
        }
        public void InitStepUpAnimation()
        {
            this.token.sprite = this.greenToken;
            this.animationToken.enabled = true;
        }
        public bool UpdateRowProgressByTopSeparator(float yPositionOfTopSeparator, bool isLastAnimatingStepWithTwoAnimations)
        {
            UnityEngine.Vector3 val_1 = this.topBound.position;
            UnityEngine.Vector3 val_2 = this.bottomBound.position;
            UnityEngine.Vector3 val_4 = this.topBound.position;
            float val_5 = val_4.y - yPositionOfTopSeparator;
            val_5 = val_5 / (val_1.y - val_2.y);
            float val_6 = UnityEngine.Mathf.Clamp01(value:  val_5);
            this.UpdateBarSize(ratio:  val_6);
            UnityEngine.Vector3 val_7 = this.tokenTopBound.position;
            float val_19 = val_7.y;
            UnityEngine.Vector3 val_8 = this.tokenBottomBound.position;
            val_19 = val_19 - val_8.y;
            UnityEngine.Vector3 val_9 = this.tokenTopBound.position;
            float val_10 = val_9.y - yPositionOfTopSeparator;
            val_10 = val_19 - val_10;
            val_10 = val_10 / val_19;
            float val_20 = UnityEngine.Mathf.Clamp01(value:  val_10);
            UnityEngine.Vector2 val_12 = this.animationToken.size;
            val_20 = val_20 * 0.8428571f;
            UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  0.8428571f, y:  val_20);
            this.animationToken.size = new UnityEngine.Vector2() {x = val_13.x, y = val_13.y};
            UnityEngine.Vector3 val_15 = this.animationToken.transform.localPosition;
            float val_17 = val_20 - val_12.y;
            float val_21 = 0.5f;
            val_17 = val_17 * val_21;
            val_21 = val_17 + val_15.y;
            this.animationToken.transform.localPosition = new UnityEngine.Vector3() {x = val_15.x, y = val_21, z = val_15.z};
            if(isLastAnimatingStepWithTwoAnimations == false)
            {
                    return (bool)(val_6 >= 1f) ? 1 : 0;
            }
            
            this.UpdateRowPatchAlphaByRatio(ratio:  val_6);
            return (bool)(val_6 >= 1f) ? 1 : 0;
        }
        public void UpdateRowPatchAlphaByRatio(float ratio)
        {
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ChangeAlpha(sprite:  this.backgroundPatch, alpha:  UnityEngine.Mathf.Lerp(a:  0.3921569f, b:  0.2784314f, t:  ratio));
        }
        private void UpdateBarSize(float ratio)
        {
            float val_13 = ratio;
            if(val_13 > 0f)
            {
                    this.EnableBarSprites();
                val_13 = val_13 * 2.249208f;
                UnityEngine.Vector2 val_1 = this.topProgressBar.size;
                UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_13, y:  val_1.y);
                this.topProgressBar.size = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
                float val_4 = UnityEngine.Mathf.Lerp(a:  0f, b:  0.2071429f, t:  val_13 / 0.2f);
                UnityEngine.Vector2 val_5 = this.bottomProgressBar.size;
                UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_4, y:  val_5.y);
                this.bottomProgressBar.size = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
                UnityEngine.Vector3 val_9 = this.bottomProgressBar.transform.localPosition;
                UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  val_13 + val_4, y:  val_9.y);
                UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
                this.bottomProgressBar.transform.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
                return;
            }
            
            this.DisableBarSprites();
        }
        private System.Collections.IEnumerator ProgressBarCoroutine(float startProgress, float endProgress, float duration)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .duration = duration;
            .startProgress = startProgress;
            .endProgress = endProgress;
            return (System.Collections.IEnumerator)new RoyalPassRow.<ProgressBarCoroutine>d__65();
        }
        public RoyalPassRow()
        {
        
        }
    
    }

}
