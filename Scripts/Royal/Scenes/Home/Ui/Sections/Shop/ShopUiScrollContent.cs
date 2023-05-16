using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Shop
{
    public class ShopUiScrollContent : UiScrollContent
    {
        // Fields
        public readonly System.Collections.Generic.List<Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollCustomContentItem> items;
        
        // Methods
        public void AddData(Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollCustomContentItem item, Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data)
        {
            this.PopulateData(item:  item, position:  null, data:  data);
            float val_1 = item.size;
            val_1 = item.spacing + val_1;
            val_1 = S2 + val_1;
            this.Size = val_1;
            this.items.Add(item:  item);
        }
        public void AddItemWithoutData(Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollCustomContentItem item)
        {
            this.PopulateData(item:  item, position:  null, data:  0);
            float val_1 = item.size;
            val_1 = item.spacing + val_1;
            val_1 = S2 + val_1;
            this.Size = val_1;
            this.items.Add(item:  item);
        }
        public void PutItemNextPosition(Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollCustomContentItem item)
        {
            UnityEngine.Vector3 val_2 = this.LocalPosition(trans:  item.transform, position:  null);
            float val_6 = item.size;
            float val_7 = -0.5f;
            val_6 = val_6 * val_7;
            val_7 = val_2.y + val_6;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_2.x, y:  val_7);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            item.transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            float val_8 = item.size;
            val_8 = item.spacing + val_8;
            val_8 = val_5.z + val_8;
            this.Size = val_8;
        }
        public void RemoveFirstItem()
        {
            this.RemoveItemAtIndex(index:  0);
        }
        public void RemoveLastItem()
        {
            this.RemoveItemAtIndex(index:  this.items - 1);
        }
        public void RemoveItemAtIndex(int index)
        {
            System.Collections.Generic.List<Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollCustomContentItem> val_4;
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
        public void PopulateData(Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollCustomContentItem item, float position, Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data)
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
        public override void Clear()
        {
            System.Collections.Generic.List<Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollCustomContentItem> val_2;
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
            this.Size = 0f;
        }
        public void ClearSpecificPrefabs(System.Collections.Generic.List<System.Type> types)
        {
            System.Collections.Generic.List<Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollCustomContentItem> val_9;
            .<>4__this = this;
            .removedIndexes = new System.Collections.Generic.List<System.Int32>();
            val_9 = this.items;
            var val_9 = 0;
            label_11:
            if(val_9 >= 1152921518469134512)
            {
                goto label_3;
            }
            
            if(1152921518469134512 <= val_9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((types.Contains(item:  GetType())) != false)
            {
                    (ShopUiScrollContent.<>c__DisplayClass11_0)[1152921519032990704].removedIndexes.Add(item:  0);
                float val_5 = "java.lang.Short".__il2cppRuntimeField_20 + "java.lang.Short".__il2cppRuntimeField_1C;
                val_5 = S2 - val_5;
                this.Size = val_5;
                UnityEngine.Object.Destroy(obj:  gameObject);
            }
            
            val_9 = this.items;
            val_9 = val_9 + 1;
            if(val_9 != null)
            {
                goto label_11;
            }
            
            throw new NullReferenceException();
            label_3:
            int val_8 = val_9.RemoveAll(match:  new System.Predicate<Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollCustomContentItem>(object:  new ShopUiScrollContent.<>c__DisplayClass11_0(), method:  System.Boolean ShopUiScrollContent.<>c__DisplayClass11_0::<ClearSpecificPrefabs>b__0(Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollCustomContentItem x)));
        }
        public void ResetSize()
        {
            this.Size = 0f;
        }
        public void AddSpaceToEnd(float delta)
        {
            delta = S1 + delta;
            this.Size = delta;
        }
        public ShopUiScrollContent()
        {
            this.items = new System.Collections.Generic.List<Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollCustomContentItem>();
        }
    
    }

}
