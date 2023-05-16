using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassPopupTutorial : MonoBehaviour
    {
        // Fields
        public Royal.Infrastructure.UiComponents.Button.UiButton progressBar;
        public UnityEngine.SpriteRenderer blackBackground;
        public UnityEngine.BoxCollider2D backgroundBoxCollider2D;
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPopup royalPassPopup;
        private Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialViewAssets tutorialAssets;
        private Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView arrow;
        private Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialBlackView black;
        private Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialDialogView dialog;
        private Royal.Scenes.Home.Context.Units.Tutorial.RoyalPassTutorialStep currentTutorialStep;
        private Royal.Scenes.Game.Mechanics.Sortings.SortingData tutorialArrowSorting;
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRow firstRewardRow;
        private Royal.Player.Context.Units.RoyalPassManager royalPassManager;
        private UnityEngine.Coroutine disableBackgroundTouchCoroutine;
        private UnityEngine.Vector3 firstStepFreeRewardPosition;
        private UnityEngine.Vector3 firstStepGoldRewardPosition;
        private UnityEngine.Vector3 progressBarPosition;
        private const float darknessCoefficient = 0.8;
        
        // Methods
        public void Show()
        {
            Royal.Infrastructure.Contexts.Units.CameraManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.royalPassManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTutorialArrowSorting();
            this.tutorialArrowSorting = val_3;
            mem[1152921519218413556] = val_3.sortEverything;
            this.royalPassPopup = this.gameObject.GetComponent<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPopup>();
            this.MoveNextStep();
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_1.cameraWidth, y:  val_1.cameraHeight);
            this.blackBackground.size = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
            UnityEngine.Vector2 val_7 = this.blackBackground.size;
            this.backgroundBoxCollider2D.size = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
        }
        private void MoveNextStep()
        {
            this.currentTutorialStep = this.royalPassManager.currentTutorialStep;
            if(this.royalPassManager.currentTutorialStep != 4)
            {
                    if(this.royalPassManager.currentTutorialStep != 3)
            {
                    if(this.royalPassManager.currentTutorialStep != 2)
            {
                    return;
            }
            
                this.royalPassPopup.royalPassScroll.AnimateAllItemsFromBottomForTutorial(callback:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPopupTutorial::ShowTutorialStep1()));
                return;
            }
            
                this.ShowTutorialStep2();
                return;
            }
            
            this.ShowTutorialStep3();
        }
        private void ShowTutorialStep1()
        {
            this.TriggerDisableTouch();
            if(this.BringFirstStepFreeRewardFront() == false)
            {
                    return;
            }
            
            .<>4__this = this;
            this.royalPassManager.MoveNextStepInTutorial();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.firstStepFreeRewardPosition, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            .arrowPosition = val_3;
            mem[1152921519218769828] = val_3.y;
            mem[1152921519218769832] = val_3.z;
            this.CreateBlack().Show(delay:  0f, fadeDuration:  0f, onComplete:  new System.Action(object:  new RoyalPassPopupTutorial.<>c__DisplayClass19_0(), method:  System.Void RoyalPassPopupTutorial.<>c__DisplayClass19_0::<ShowTutorialStep1>b__0()), darkness:  0.8f);
            this.black.transform.SetParent(p:  this.transform);
        }
        private void HideTutorialStep1()
        {
            var val_3;
            if(this.firstRewardRow == 0)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            null.UpdateSortingWithChildren(targetObject:  this.firstRewardRow.freeRewardContainer.gameObject, sortingLayerId:  Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId, sortingOrder:  -Royal.Scenes.Game.Mechanics.Sortings.Sorting.__il2cppRuntimeField_cctor_finished);
        }
        private void ShowTutorialStep2()
        {
            .<>4__this = this;
            this.TriggerDisableTouch();
            this.royalPassManager.MoveNextStepInTutorial();
            UnityEngine.Vector3 val_2 = this.BringProgressBarFront();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  1.2f);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            .arrowPosition = val_5;
            mem[1152921519219101356] = val_5.y;
            mem[1152921519219101360] = val_5.z;
            this.CreateBlack().Show(delay:  0f, fadeDuration:  0f, onComplete:  new System.Action(object:  new RoyalPassPopupTutorial.<>c__DisplayClass21_0(), method:  System.Void RoyalPassPopupTutorial.<>c__DisplayClass21_0::<ShowTutorialStep2>b__0()), darkness:  0.8f);
            this.black.transform.SetParent(p:  this.royalPassPopup.header.transform);
        }
        private void HideTutorialStep2()
        {
            var val_2;
            this.progressBar.ZIndex = -3;
            val_2 = null;
            val_2 = null;
            null.UpdateSortingWithChildren(targetObject:  this.progressBar.gameObject, sortingLayerId:  Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId, sortingOrder:  -Royal.Scenes.Game.Mechanics.Sortings.Sorting.__il2cppRuntimeField_cctor_finished);
        }
        private void ShowTutorialStep3()
        {
            if(this.BringFirstStepGoldRewardFront() == false)
            {
                    return;
            }
            
            .<>4__this = this;
            this.royalPassManager.MoveNextStepInTutorial();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.firstStepGoldRewardPosition, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            .arrowPosition = val_3;
            mem[1152921519219416484] = val_3.y;
            mem[1152921519219416488] = val_3.z;
            this.CreateBlack().Show(delay:  0f, fadeDuration:  0f, onComplete:  new System.Action(object:  new RoyalPassPopupTutorial.<>c__DisplayClass23_0(), method:  System.Void RoyalPassPopupTutorial.<>c__DisplayClass23_0::<ShowTutorialStep3>b__0()), darkness:  0.8f);
            this.black.transform.SetParent(p:  this.transform);
        }
        private void HideTutorialStep3()
        {
            var val_3;
            if(this.firstRewardRow == 0)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            null.UpdateSortingWithChildren(targetObject:  this.firstRewardRow.paidRewardContainer.gameObject, sortingLayerId:  Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId, sortingOrder:  -Royal.Scenes.Game.Mechanics.Sortings.Sorting.__il2cppRuntimeField_cctor_finished);
        }
        private bool BringFirstStepFreeRewardFront()
        {
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassScrollContent val_8;
            var val_9;
            val_8 = 30119;
            Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem val_2 = 0;
            if(this.royalPassPopup == null)
            {
                    throw new NullReferenceException();
            }
            
            if(this.royalPassPopup.royalPassScroll == null)
            {
                    throw new NullReferenceException();
            }
            
            val_8 = this.royalPassPopup.royalPassScroll.content;
            if(val_8 == null)
            {
                    throw new NullReferenceException();
            }
            
            int val_1 = val_8.GetStepIndex(step:  0);
            if(val_1 == 1)
            {
                goto label_11;
            }
            
            if(this.royalPassPopup == null)
            {
                    throw new NullReferenceException();
            }
            
            if(this.royalPassPopup.royalPassScroll == null)
            {
                    throw new NullReferenceException();
            }
            
            if(this.royalPassPopup.royalPassScroll.content == null)
            {
                    throw new NullReferenceException();
            }
            
            val_8 = this.royalPassPopup.royalPassScroll.content.pool;
            if(val_8 == null)
            {
                    throw new NullReferenceException();
            }
            
            bool val_3 = val_8.TryGetValue(key:  val_1, value: out  val_2);
            if(val_2 == 0)
            {
                goto label_11;
            }
            
            val_8 = val_2;
            if(val_8 == 0)
            {
                goto label_12;
            }
            
            this.firstRewardRow = val_8;
            if(2 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_8 = mem[25769803810];
            if(val_8 == 0)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.GameObject val_5 = 2.gameObject;
            val_5.UpdateSortingWithChildren(targetObject:  val_5, sortingLayerId:  this.tutorialArrowSorting, sortingOrder:  1682855616);
            UnityEngine.Transform val_6 = 2.transform;
            if(val_6 == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Vector3 val_7 = val_6.position;
            val_9 = 1;
            this.firstStepFreeRewardPosition = val_7;
            mem[1152921519219715092] = val_7.y;
            mem[1152921519219715096] = val_7.z;
            return (bool)val_9;
            label_11:
            val_9 = 0;
            return (bool)val_9;
            label_12:
            this.firstRewardRow = val_8;
            throw new NullReferenceException();
        }
        private bool BringFirstStepGoldRewardFront()
        {
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassScrollContent val_8;
            var val_9;
            val_8 = 30120;
            Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem val_2 = 0;
            if(this.royalPassPopup == null)
            {
                    throw new NullReferenceException();
            }
            
            if(this.royalPassPopup.royalPassScroll == null)
            {
                    throw new NullReferenceException();
            }
            
            val_8 = this.royalPassPopup.royalPassScroll.content;
            if(val_8 == null)
            {
                    throw new NullReferenceException();
            }
            
            int val_1 = val_8.GetStepIndex(step:  0);
            if(val_1 == 1)
            {
                goto label_11;
            }
            
            if(this.royalPassPopup == null)
            {
                    throw new NullReferenceException();
            }
            
            if(this.royalPassPopup.royalPassScroll == null)
            {
                    throw new NullReferenceException();
            }
            
            if(this.royalPassPopup.royalPassScroll.content == null)
            {
                    throw new NullReferenceException();
            }
            
            val_8 = this.royalPassPopup.royalPassScroll.content.pool;
            if(val_8 == null)
            {
                    throw new NullReferenceException();
            }
            
            bool val_3 = val_8.TryGetValue(key:  val_1, value: out  val_2);
            if(val_2 == 0)
            {
                goto label_11;
            }
            
            val_8 = val_2;
            if(val_8 == 0)
            {
                goto label_12;
            }
            
            this.firstRewardRow = val_8;
            if(45209896 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_8 = 45155056;
            if(val_8 == 0)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.GameObject val_5 = 45209896.gameObject;
            val_5.UpdateSortingWithChildren(targetObject:  val_5, sortingLayerId:  this.tutorialArrowSorting, sortingOrder:  1682855616);
            UnityEngine.Transform val_6 = 45209896.transform;
            if(val_6 == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Vector3 val_7 = val_6.position;
            val_9 = 1;
            this.firstStepGoldRewardPosition = val_7;
            mem[1152921519219900832] = val_7.y;
            mem[1152921519219900836] = val_7.z;
            return (bool)val_9;
            label_11:
            val_9 = 0;
            return (bool)val_9;
            label_12:
            this.firstRewardRow = val_8;
            throw new NullReferenceException();
        }
        private UnityEngine.Vector3 BringProgressBarFront()
        {
            this.progressBar.ZIndex = -15;
            UnityEngine.GameObject val_1 = this.progressBar.gameObject;
            val_1.UpdateSortingWithChildren(targetObject:  val_1, sortingLayerId:  this.tutorialArrowSorting, sortingOrder:  0);
            return this.progressBar.transform.position;
        }
        private void UpdateSortingWithChildren(UnityEngine.GameObject targetObject, int sortingLayerId, int sortingOrder)
        {
            T[] val_12 = targetObject.GetComponentsInChildren<UnityEngine.SpriteRenderer>();
            if(val_1.Length >= 1)
            {
                    var val_13 = 0;
                do
            {
                val_12[val_13].sortingLayerID = sortingLayerId;
                val_1[0x0] + 32.sortingOrder = (val_1[0x0] + 32.sortingOrder) + sortingOrder;
                val_13 = val_13 + 1;
            }
            while(val_13 < val_1.Length);
            
            }
            
            if(val_2.Length >= 1)
            {
                    var val_15 = 0;
                do
            {
                targetObject.GetComponentsInChildren<TMPro.TextMeshPro>()[val_15].sortingLayerID = sortingLayerId;
                val_12 = mem[val_2[0x0] + 32];
                val_12 = val_2[0x0] + 32;
                val_12.sortingOrder = val_12.sortingOrder + sortingOrder;
                val_15 = val_15 + 1;
            }
            while(val_15 < val_2.Length);
            
            }
            
            if(val_3.Length < 1)
            {
                    return;
            }
            
            do
            {
                targetObject.GetComponentsInChildren<UnityEngine.SpriteMask>()[0].backSortingLayerID = sortingLayerId;
                val_3[0x0] + 32.frontSortingLayerID = sortingLayerId;
                val_3[0x0] + 32.backSortingOrder = (val_3[0x0] + 32.backSortingOrder) + sortingOrder;
                val_3[0x0] + 32.frontSortingOrder = (val_3[0x0] + 32.frontSortingOrder) + sortingOrder;
                val_12 = 0 + 1;
            }
            while(val_12 < val_3.Length);
        
        }
        private void UpdateAlphaWithChildren(UnityEngine.GameObject targetObject, float alpha)
        {
            UnityEngine.GameObject val_4 = targetObject;
            T[] val_3 = val_4.GetComponentsInChildren<UnityEngine.SpriteMask>();
            int val_4 = val_1.Length;
            if(val_4 >= 1)
            {
                    val_4 = val_4 & 4294967295;
                do
            {
                Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ChangeAlpha(sprite:  null, alpha:  alpha);
                val_4 = 0 + 1;
            }
            while(val_4 < (val_1.Length << ));
            
            }
            
            int val_5 = val_2.Length;
            if(val_5 < 1)
            {
                    return;
            }
            
            var val_6 = 0;
            val_5 = val_5 & 4294967295;
            do
            {
                Royal.Infrastructure.Utils.Text.TextMeshProExtensions.ChangeAlpha(tmp:  null, alpha:  alpha);
                val_6 = val_6 + 1;
            }
            while(val_6 < (val_2.Length << ));
        
        }
        private void LoadTutorialAssets()
        {
            if(this.tutorialAssets != 0)
            {
                    return;
            }
            
            this.tutorialAssets = UnityEngine.Resources.Load<Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialViewAssets>(path:  "HomeTutorialViewAssets");
        }
        private Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView CreateArrow()
        {
            this.LoadTutorialAssets();
            Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView val_1 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView>(original:  this.tutorialAssets.arrowView);
            this.arrow = val_1;
            return val_1;
        }
        private void DestroyArrow()
        {
            if(this.arrow == 0)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  this.arrow.gameObject);
            this.arrow = 0;
        }
        private Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialBlackView CreateBlack()
        {
            Royal.Infrastructure.Contexts.Units.CameraManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.LoadTutorialAssets();
            Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialBlackView val_2 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialBlackView>(original:  this.tutorialAssets.blackView);
            this.black = val_2;
            val_2.tag = "Blocker";
            float val_5 = val_1.cameraHeight;
            float val_4 = val_1.cameraWidth;
            val_4 = val_4 + 1f;
            val_5 = val_5 + 1f;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_4, y:  val_5);
            this.black.SetBackGroundSize(backgroundSize:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            return (Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialBlackView)this.black;
        }
        private void DestroyBlack()
        {
            if(this.black == 0)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  this.black.gameObject);
            this.black = 0;
        }
        private Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialDialogView CreateDialog()
        {
            this.LoadTutorialAssets();
            this.dialog = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialDialogView>(original:  this.tutorialAssets.dialogView);
            this.PlayDialogBounceAnimation();
            return (Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialDialogView)this.dialog;
        }
        private void DestroyDialog()
        {
            if(this.dialog == 0)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  this.dialog.gameObject);
            this.dialog = 0;
        }
        private void PlayDialogBounceAnimation()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            UnityEngine.Transform val_2 = this.dialog.transform;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.0065f);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_2.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  0.012f);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_2, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  0.05f), ease:  6));
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  0.004f);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_2, endValue:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, duration:  0.12f), ease:  6));
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_2, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  0.065f), ease:  6));
        }
        public void OnBackgroundClick()
        {
            this.Close();
            this.MoveNextStep();
        }
        private void TriggerDisableTouch()
        {
            if(this.disableBackgroundTouchCoroutine != null)
            {
                    this.StopCoroutine(routine:  this.disableBackgroundTouchCoroutine);
                this.disableBackgroundTouchCoroutine = 0;
            }
            
            this.disableBackgroundTouchCoroutine = this.StartCoroutine(routine:  this.DisableBackgroundTouch(durationInSeconds:  3f));
        }
        private System.Collections.IEnumerator DisableBackgroundTouch(float durationInSeconds)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .durationInSeconds = durationInSeconds;
            return (System.Collections.IEnumerator)new RoyalPassPopupTutorial.<DisableBackgroundTouch>d__40();
        }
        public void Close()
        {
            this.DestroyDialog();
            this.DestroyArrow();
            this.DestroyBlack();
            this.backgroundBoxCollider2D.enabled = false;
            if(this.currentTutorialStep == 4)
            {
                goto label_1;
            }
            
            if(this.currentTutorialStep == 3)
            {
                goto label_2;
            }
            
            if(this.currentTutorialStep != 2)
            {
                goto label_5;
            }
            
            this.HideTutorialStep1();
            goto label_5;
            label_2:
            this.HideTutorialStep2();
            goto label_5;
            label_1:
            this.HideTutorialStep3();
            label_5:
            this.currentTutorialStep = 5;
        }
        public bool IsInTutorial()
        {
            return (bool)((this.currentTutorialStep != 0) ? 1 : 0) & ((this.currentTutorialStep != 5) ? 1 : 0);
        }
        public RoyalPassPopupTutorial()
        {
        
        }
    
    }

}
