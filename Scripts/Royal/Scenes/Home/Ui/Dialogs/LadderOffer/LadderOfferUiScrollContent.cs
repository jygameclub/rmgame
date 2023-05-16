using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.LadderOffer
{
    public class LadderOfferUiScrollContent : UiScrollContent
    {
        // Fields
        private readonly System.Collections.Generic.List<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPackageView> items;
        private readonly System.Collections.Generic.List<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep> steps;
        private const float DeltaXForSlideAnimation = 5;
        
        // Methods
        public void AddData(Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPackageView item, Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferRowData data)
        {
            this.PopulateData(item:  item, position:  null, data:  data);
            float val_1 = S1 + S0;
            val_1 = S2 + val_1;
            this.Size = val_1;
            this.items.Add(item:  item);
            this.steps.Add(item:  data.ladderOfferStep);
        }
        private void RemoveFirstItem()
        {
            this.RemoveItemAtIndex(index:  0);
            this.steps.RemoveAt(index:  0);
        }
        private void RemoveItemAtIndex(int index)
        {
            System.Collections.Generic.List<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPackageView> val_4;
            var val_5;
            var val_6;
            if((index & 2147483648) != 0)
            {
                    return;
            }
            
            val_4 = this.items;
            if(true <= index)
            {
                    return;
            }
            
            if(true > index)
            {
                    val_5 = true + (index << 3);
            }
            else
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_6 = this.items;
                val_5 = X9 + (index << 3);
            }
            
            val_5 = val_5 + 32;
            val_6.RemoveAt(index:  index);
            UnityEngine.Object.Destroy(obj:  val_5.gameObject);
            this.ArrangeItemsPositions();
        }
        private void ArrangeItemsPositions()
        {
            bool val_6 = true;
            this.Size = 0f;
            var val_9 = 0;
            do
            {
                if(val_9 >= val_6)
            {
                    return;
            }
            
                if(val_6 <= val_9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_6 = val_6 + 0;
                UnityEngine.Vector3 val_2 = this.LocalPosition(trans:  (true + 0) + 32.transform, position:  0f);
                float val_7 = (true + 0) + 32 + 28;
                val_7 = val_7 * (-0.5f);
                val_2.y = val_2.y + val_7;
                UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_2.x, y:  val_2.y);
                UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
                (true + 0) + 32.transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
                float val_8 = (true + 0) + 32 + 28;
                val_8 = ((true + 0) + 32 + 28 + 4) + val_8;
                val_8 = val_5.z + val_8;
                this.Size = val_8;
                val_9 = val_9 + 1;
            }
            while(this.items != null);
            
            throw new NullReferenceException();
        }
        private void PopulateData(Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollCustomContentItem item, float position, Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data)
        {
            UnityEngine.Vector3 val_2 = this.LocalPosition(trans:  item.transform, position:  position);
            float val_6 = item.size;
            float val_7 = -0.5f;
            val_6 = val_6 * val_7;
            val_7 = val_2.y + val_6;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_2.x, y:  val_7);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            item.transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        private UnityEngine.Vector3 LocalPosition(UnityEngine.Transform trans, float position)
        {
            UnityEngine.Vector3 val_1 = trans.localPosition;
            return new UnityEngine.Vector3() {x = (W8 == 0) ? position : val_1.x, y = (W8 == 0) ? val_1.y : (-position), z = val_1.z};
        }
        public System.Collections.Generic.List<Royal.Infrastructure.Utils.Time.CountdownAnimation> GetCountDownAnimations()
        {
            System.Collections.Generic.IEnumerable<T> val_4;
            var val_5;
            System.Collections.Generic.List<Royal.Infrastructure.Utils.Time.CountdownAnimation> val_1 = new System.Collections.Generic.List<Royal.Infrastructure.Utils.Time.CountdownAnimation>();
            List.Enumerator<T> val_2 = this.items.GetEnumerator();
            label_5:
            val_4 = public System.Boolean List.Enumerator<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPackageView>::MoveNext();
            if((1936378472 & 1) == 0)
            {
                goto label_2;
            }
            
            val_5 = 0;
            if(val_5 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_4 = val_5.GetComponentsInChildren<Royal.Infrastructure.Utils.Time.CountdownAnimation>();
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_1.AddRange(collection:  val_4);
            goto label_5;
            label_2:
            0.Dispose();
            return val_1;
        }
        public override void Clear()
        {
            bool val_2 = true;
            var val_3 = 0;
            label_7:
            if(val_3 >= val_2)
            {
                goto label_2;
            }
            
            if(val_2 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 0;
            UnityEngine.Object.Destroy(obj:  (true + 0) + 32.gameObject);
            val_3 = val_3 + 1;
            if(this.items != null)
            {
                goto label_7;
            }
            
            label_2:
            this.items.Clear();
            this.steps.Clear();
            this.Size = 0f;
        }
        private void ArrangeItems(int index, bool hideLockParent)
        {
            var val_6;
            var val_7;
            bool val_6 = true;
            if(val_6 <= index)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + (index << 3);
            (true + (index) << 3) + 32.Unlock(hideLockParent:  hideLockParent);
            System.Collections.Generic.List<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPackageView> val_7 = this.items;
            val_6 = 0;
            var val_2 = X9 + 32;
            label_23:
            int val_3 = index + val_6;
            if(val_3 >= val_7)
            {
                    return;
            }
            
            if(val_7 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + val_2;
            if(val_6 == 0)
            {
                goto label_8;
            }
            
            if(val_7 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + val_2;
            val_7 = 0;
            int val_5 = System.Math.Max(val1:  0, val2:  (typeof(System.Collections.Generic.List<T>).__il2cppRuntimeField_3C - 1)>>0&0xFFFFFFFF);
            if(null != null)
            {
                goto label_14;
            }
            
            label_8:
            val_7 = 0;
            label_14:
            typeof(System.Collections.Generic.List<T>).__il2cppRuntimeField_3C = val_7;
            if(val_7 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + val_2;
            if(W9 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + val_2;
            1152921504685068288.PrepareBackground(backgroundColorIndex:  0);
            val_6 = val_6 + 1;
            if(this.items != null)
            {
                goto label_23;
            }
            
            throw new NullReferenceException();
        }
        private int GetStepIndex(int step)
        {
            var val_1;
            bool val_1 = true;
            val_1 = 0;
            label_6:
            if(val_1 >= val_1)
            {
                goto label_2;
            }
            
            if(val_1 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            if(((true + 0) + 32 + 16) == step)
            {
                    return (int)val_1;
            }
            
            val_1 = val_1 + 1;
            if(this.steps != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_2:
            val_1 = 0;
            return (int)val_1;
        }
        public void PlayItemPopupAnimation(Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem item, int order)
        {
            UnityEngine.Transform val_1 = item.transform;
            float val_9 = 0.07f;
            val_9 = ((float)order + 1) * val_9;
            UnityEngine.Vector3 val_4 = val_1.localPosition;
            float val_10 = 5f;
            val_10 = val_4.x + val_10;
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_10, y:  val_4.y);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            val_1.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMoveX(target:  val_1, endValue:  val_4.x, duration:  val_9 + 0.3f, snapping:  false), ease:  27);
        }
        public void PlayHideAnimation()
        {
            if(true == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_2 = 0;
            var val_3 = 0;
            label_9:
            if(val_3 >= val_2)
            {
                goto label_5;
            }
            
            if(val_2 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 0;
            (0 + 0) + 32.gameObject.SetActive(value:  false);
            val_3 = val_3 + 1;
            if(this.items != null)
            {
                goto label_9;
            }
            
            label_5:
            mem[-6917529027641081728].Hide();
        }
        public void PlayBuyAnimations()
        {
            int val_84;
            int val_85;
            Royal.Player.Context.Units.LadderOfferManager val_86;
            float val_87;
            DG.Tweening.TweenCallback val_88;
            DG.Tweening.Sequence val_89;
            DG.Tweening.TweenCallback val_90;
            LadderOfferUiScrollContent.<>c__DisplayClass15_0 val_1 = new LadderOfferUiScrollContent.<>c__DisplayClass15_0();
            .<>4__this = this;
            .ladderOfferManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LadderOfferManager>(id:  11);
            Royal.Player.Context.Data.Persistent.LadderOfferProgress val_3 = GetLadderOffer();
            if(((LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].ladderOfferManager.IsStepInLastOffers(step:  val_2.nextAnimationStep)) != false)
            {
                    val_84 = this.GetStepIndex(step:  val_2.nextAnimationStep);
            }
            else
            {
                    val_84 = 0;
            }
            
            .index = val_84;
            val_85 = val_84;
            if(((LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].ladderOfferManager) <= val_84)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_85 = (LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index;
            }
            
            if(W9 <= val_85)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            Royal.Player.Context.Units.LadderOfferManager val_6 = 1152921505123459072 + (val_85 << 3);
            val_86 = (LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].ladderOfferManager;
            if(val_3.step <= ((1152921505123459072 + ((LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index) << 3).endDate + 16))
            {
                goto label_18;
            }
            
            val_86 = val_3.step;
            int val_83 = (LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index;
            if(val_83 >= 1)
            {
                    var val_84 = 0;
                do
            {
                if(val_83 <= val_84)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_83 = val_83 + 0;
                ((LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index + 0) + 32.Check();
                val_84 = val_84 + 1;
            }
            while(val_84 < ((LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index));
            
            }
            
            UnityEngine.Transform val_7 = Royal.Player.Context.Units.LadderOfferManager.__il2cppRuntimeField_byval_arg + 80.transform;
            val_84 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Sequence>(t:  val_84, delay:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  15f));
            UnityEngine.Vector3 val_11 = val_7.localScale;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  1.15f);
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_84, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_7, endValue:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  10f)), ease:  10));
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_84, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_7, endValue:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  20f)), ease:  11));
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_84, t:  Royal.Player.Context.Units.LadderOfferManager.__il2cppRuntimeField_byval_arg.PlayAvailabilityTextDisappearAnimation());
            DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_84, callback:  new DG.Tweening.TweenCallback(object:  Royal.Player.Context.Units.LadderOfferManager.__il2cppRuntimeField_byval_arg, method:  public System.Void Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPackageView::PlayCheckAnimation()));
            System.Collections.Generic.List<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPackageView> val_85 = this.items;
            val_85 = val_85 - 1;
            if(((LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index) != val_85)
            {
                goto label_34;
            }
            
            val_86 = (LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].ladderOfferManager;
            label_18:
            val_86 = 0;
            return;
            label_34:
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_84, interval:  0.3f);
            int val_86 = (LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index;
            int val_27 = val_86 + 1;
            if(((LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index) <= val_27)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_86 = val_86 + (val_27 << 3);
            DG.Tweening.Sequence val_29 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_84, callback:  new DG.Tweening.TweenCallback(object:  ((LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index + (((LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index + 1)) << 3) + 32, method:  public System.Void Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPackageView::PlayOpenLockAnimationDelayed()));
            int val_87 = (LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index;
            int val_30 = val_87 + 1;
            if(((LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index) <= val_30)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_87 = val_87 + (val_30 << 3);
            DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_84, t:  ((LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index + (((LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index + 1)) << 3) + 32.PlayBackgroundColorChangeAnimation());
            DG.Tweening.Sequence val_34 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_84, interval:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  15f));
            UnityEngine.Vector3 val_36 = Royal.Player.Context.Units.LadderOfferManager.__il2cppRuntimeField_byval_arg.transform.localPosition;
            int val_88 = (LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index;
            val_87 = val_36.y;
            int val_37 = val_88 + 1;
            if(((LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index) <= val_37)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_88 = val_88 + (val_37 << 3);
            UnityEngine.Vector3 val_39 = ((LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index + (((LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index + 1)) << 3) + 32.transform.localPosition;
            .heightDifferenceBetweenTwoPackages = val_87 - val_39.y;
            val_88 = new DG.Tweening.TweenCallback();
            if(((LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].ladderOfferManager.IsStepInLastOffers(step:  val_2.nextAnimationStep)) != false)
            {
                    val_88 = new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void LadderOfferUiScrollContent.<>c__DisplayClass15_0::<PlayBuyAnimations>b__4());
                val_89 = val_84;
                val_90 = val_88;
            }
            else
            {
                    val_88 = new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void LadderOfferUiScrollContent.<>c__DisplayClass15_0::<PlayBuyAnimations>b__0());
                DG.Tweening.Sequence val_44 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_84, callback:  new DG.Tweening.TweenCallback());
                DG.Tweening.Sequence val_46 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_84, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void LadderOfferUiScrollContent.<>c__DisplayClass15_0::<PlayBuyAnimations>b__1()));
                UnityEngine.Vector3 val_48 = UnityEngine.Vector3.zero;
                float val_89 = (LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].heightDifferenceBetweenTwoPackages;
                val_89 = val_89 * 0.5f;
                DG.Tweening.Sequence val_54 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_84, t:  DG.Tweening.TweenSettingsExtensions.Append(s:  val_84, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  Royal.Player.Context.Units.LadderOfferManager.__il2cppRuntimeField_byval_arg.transform, endValue:  new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_48.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  20f)), ease:  3)).PlayPackagePositionChangeAnimation(item:  Royal.Player.Context.Units.LadderOfferManager.__il2cppRuntimeField_byval_arg, changeAmount:  val_89, delay:  0f));
                int val_90 = (LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_90 = val_90 + ((val_90 + 1) << 3);
                DG.Tweening.Sequence val_58 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_84, t:  this.PlayPackagePositionChangeAnimation(item:  ((LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index + (((LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index + 1)) << 3) + 32, changeAmount:  (LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].heightDifferenceBetweenTwoPackages, delay:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f)));
                int val_91 = (LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_91 = val_91 + ((val_91 + 2) << 3);
                DG.Tweening.Sequence val_62 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_84, t:  this.PlayPackagePositionChangeAnimation(item:  ((LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index + (((LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index + 2)) << 3) + 32, changeAmount:  (LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].heightDifferenceBetweenTwoPackages, delay:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f)));
                int val_92 = (LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_92 = val_92 + ((val_92 + 3) << 3);
                UnityEngine.Vector3 val_65 = UnityEngine.Vector3.one;
                DG.Tweening.Sequence val_71 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_84, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  ((LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index + (((LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index + 3)) << 3) + 32.transform, endValue:  new UnityEngine.Vector3() {x = val_65.x, y = val_65.y, z = val_65.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  20f)), ease:  27, overshoot:  0.5f), delay:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  3f)));
                int val_93 = (LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index;
                val_88 = val_93 + 3;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_87 = (LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].heightDifferenceBetweenTwoPackages;
                val_93 = val_93 + (val_88 << 3);
                DG.Tweening.Sequence val_74 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_84, t:  this.PlayPackagePositionChangeAnimation(item:  ((LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index + (((LadderOfferUiScrollContent.<>c__DisplayClass15_0)[1152921519429350288].index + 3)) << 3) + 32, changeAmount:  val_87, delay:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  6f)));
                DG.Tweening.Sequence val_76 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_84, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferUiScrollContent::RemoveFirstItem()));
                DG.Tweening.Sequence val_78 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_84, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void LadderOfferUiScrollContent.<>c__DisplayClass15_0::<PlayBuyAnimations>b__2()));
                DG.Tweening.TweenCallback val_79 = new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void LadderOfferUiScrollContent.<>c__DisplayClass15_0::<PlayBuyAnimations>b__3());
                val_89 = val_84;
                val_90 = val_79;
            }
            
            DG.Tweening.Sequence val_80 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_89, callback:  val_79);
            DG.Tweening.Sequence val_82 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_84, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void LadderOfferUiScrollContent.<>c__DisplayClass15_0::<PlayBuyAnimations>b__5()));
        }
        private DG.Tweening.Tween PlayPackagePositionChangeAnimation(Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPackageView item, float changeAmount, float delay)
        {
            UnityEngine.Vector3 val_2 = item.transform.localPosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  changeAmount);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  5f);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_13 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  item.transform, endValue:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  60f), snapping:  false), ease:  27), delay:  delay);
            val_13 = 1053609165;
            return (DG.Tweening.Tween)val_13;
        }
        public LadderOfferUiScrollContent()
        {
            this.items = new System.Collections.Generic.List<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPackageView>();
            this.steps = new System.Collections.Generic.List<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep>();
        }
    
    }

}
