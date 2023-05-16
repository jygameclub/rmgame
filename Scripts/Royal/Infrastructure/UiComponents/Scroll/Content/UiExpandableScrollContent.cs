using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Scroll.Content
{
    public class UiExpandableScrollContent : UiScrollContent
    {
        // Fields
        public Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem prefab;
        private System.Collections.Generic.List<Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem> items;
        
        // Methods
        private void Awake()
        {
            this.items = new System.Collections.Generic.List<Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem>();
        }
        public override void AddData(Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data)
        {
            Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem val_2 = UnityEngine.Object.Instantiate<Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem>(original:  this.prefab, parent:  this.transform);
            this.PopulateData(item:  val_2, position:  null, data:  data);
            this.items.Add(item:  val_2);
            float val_3 = S1 + S0;
            val_3 = S2 + val_3;
            mem[1152921527516010140] = val_3;
            if(this.items == null)
            {
                    return;
            }
            
            this.items.Invoke();
        }
        public Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem GetItemFromIndex(int index)
        {
            bool val_1 = true;
            if(val_1 <= index)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (index << 3);
            return (Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem)(true + (index) << 3) + 32;
        }
        public void RemoveItem(Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem item)
        {
            float val_1 = S0 + S1;
            val_1 = S2 - val_1;
            mem[1152921527516292508] = val_1;
            if(40530 != 0)
            {
                    40530.Invoke();
            }
            
            bool val_2 = this.items.Remove(item:  item);
            UnityEngine.Object.Destroy(obj:  item.gameObject);
            var val_7 = 0;
            float val_8 = 0f;
            do
            {
                if(val_7 >= null)
            {
                    return;
            }
            
                if(null <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                UnityEngine.Vector3 val_6 = this.LocalPosition(trans:  UnityEngine.Object.__il2cppRuntimeField_byval_arg.transform, position:  val_8);
                UnityEngine.Object.__il2cppRuntimeField_byval_arg.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
                val_7 = val_7 + 1;
                val_6.x = val_6.y + val_6.x;
                val_8 = val_8 + val_6.x;
            }
            while(this.items != null);
            
            throw new NullReferenceException();
        }
        public void ChangePosition(Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem item, int toIndex, System.Action onComplete)
        {
            float val_30;
            System.Collections.Generic.List<Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem> val_31;
            Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem val_32;
            Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem val_33;
            var val_34;
            UiExpandableScrollContent.<>c__DisplayClass6_0 val_1 = new UiExpandableScrollContent.<>c__DisplayClass6_0();
            .item = item;
            .onComplete = onComplete;
            int val_2 = this.items.IndexOf(item:  item);
            if(val_2 > toIndex)
            {
                    (UiExpandableScrollContent.<>c__DisplayClass6_0)[1152921527516597200].onComplete.Invoke();
                return;
            }
            
            var val_29 = val_2;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetDialogScrollContentSortingOnSwap();
            bool val_4 = val_3.sortEverything & 4294967295;
            DG.Tweening.Sequence val_5 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_5, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (UiExpandableScrollContent.<>c__DisplayClass6_0)[1152921527516597200].item.transform, endValue:  0.9f, duration:  0.2f), ease:  26));
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_5, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void UiExpandableScrollContent.<>c__DisplayClass6_0::<ChangePosition>b__0()));
            if((val_29 + 1) <= toIndex)
            {
                    val_30 = 0.6f;
                do
            {
                val_31 = this.items;
                int val_13 = val_29 + 0;
                int val_14 = val_13 + 1;
                if(36528128 > val_14)
            {
                    val_32 = 36528128 + (val_14 << 3);
            }
            else
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_31 = this.items;
                val_32 = 36528128 + (val_14 << 3);
            }
            
                val_32 = val_32 + 32;
                val_33 = mem[((36528128 + (((val_2 + 0) + 1)) << 3) + 32)];
                val_33 = val_32;
                val_14 = val_14 - 1;
                if(36528128 <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_32 = val_32 + (val_13 << 3);
                UnityEngine.Vector3 val_16 = (((36528128 + (((val_2 + 0) + 1)) << 3) + 32) + ((val_2 + 0)) << 3) + 32.transform.localPosition;
                DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_18 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  val_33.transform, endValue:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, duration:  val_30, snapping:  false);
                val_34 = 0 + 1;
                float val_28 = (float)val_34;
                val_28 = val_28 * 0.05f;
                DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  val_18, ease:  27) = 1056964608;
                val_28 = val_28 + 0.1f;
                DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_5, atPosition:  val_28, t:  val_18);
                this.items.set_Item(index:  val_14, value:  val_33);
                int val_21 = val_14 + 2;
            }
            while(val_21 <= toIndex);
            
            }
            
            if(val_29 < toIndex)
            {
                    val_30 = 0.5f;
                do
            {
                val_33 = this.items;
                if(val_21 <= val_29)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                .upperItem = ((((val_2 + 0) + 1) - 1) + 2) + (((((val_2 + 0) + 1) - 1) + 2) + 32);
                if((((((val_2 + 0) + 1) - 1) + 2) + (((((val_2 + 0) + 1) - 1) + 2) + 32) + 24) != 0)
            {
                    DG.Tweening.TweenCallback val_24 = null;
                val_33 = val_24;
                val_24 = new DG.Tweening.TweenCallback(object:  new UiExpandableScrollContent.<>c__DisplayClass6_1(), method:  System.Void UiExpandableScrollContent.<>c__DisplayClass6_1::<ChangePosition>b__2());
                DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_5, atPosition:  val_30, callback:  val_24);
            }
            
                val_29 = val_29 + 1;
                val_34 = (val_21 + 32) + 8;
            }
            while(val_29 < toIndex);
            
            }
            
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_5, atPosition:  0.7f, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void UiExpandableScrollContent.<>c__DisplayClass6_0::<ChangePosition>b__1()));
            this.items.set_Item(index:  toIndex, value:  .item);
        }
        public void ShowHiddenItem(int index, float duration)
        {
            bool val_1 = true;
            if(val_1 <= index)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (index << 3);
            Royal.Infrastructure.UiComponents.Scroll.Content.UiExpandableScrollContent.ShowHiddenItem(item:  (true + (index) << 3) + 32, duration:  duration);
        }
        private static void ShowHiddenItem(UnityEngine.Component item, float duration)
        {
            var val_14;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.5f);
            item.transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  item.transform, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  duration), ease:  27);
            int val_14 = val_8.Length;
            if(val_14 >= 1)
            {
                    val_14 = val_14 & 4294967295;
                do
            {
                DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_10 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  null, endValue:  1f, duration:  duration), ease:  1);
                val_14 = 0 + 1;
            }
            while(val_14 < (val_8.Length << ));
            
            }
            
            int val_15 = val_11.Length;
            if(val_15 < 1)
            {
                    return;
            }
            
            var val_16 = 0;
            val_15 = val_15 & 4294967295;
            do
            {
                DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_13 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  null, endValue:  1f, duration:  duration), ease:  1);
                val_16 = val_16 + 1;
            }
            while(val_16 < (val_11.Length << ));
        
        }
        protected void PopulateData(Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem item, float position, Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data)
        {
            UnityEngine.Transform val_1 = item.transform;
            UnityEngine.Vector3 val_2 = this.LocalPosition(trans:  val_1, position:  position);
            val_1.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        private UnityEngine.Vector3 LocalPosition(UnityEngine.Transform trans, float position)
        {
            UnityEngine.Vector3 val_1 = trans.localPosition;
            return new UnityEngine.Vector3() {x = (W8 == 0) ? position : val_1.x, y = (W8 == 0) ? val_1.y : (-position), z = val_1.z};
        }
        public override void Clear()
        {
            System.Collections.Generic.List<Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem> val_2;
            var val_3;
            bool val_2 = true;
            val_2 = this.items;
            val_3 = 0;
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
            val_2 = this.items;
            val_3 = val_3 + 1;
            if(val_2 != null)
            {
                goto label_7;
            }
            
            throw new NullReferenceException();
            label_2:
            val_2.Clear();
            mem[1152921527517511324] = 0;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2.Invoke();
        }
        public UiExpandableScrollContent()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
