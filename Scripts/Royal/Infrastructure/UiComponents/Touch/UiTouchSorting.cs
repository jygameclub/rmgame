using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Touch
{
    public class UiTouchSorting
    {
        // Methods
        private static int CompareZIndex(Royal.Infrastructure.UiComponents.Touch.ITouchable t1, Royal.Infrastructure.UiComponents.Touch.ITouchable t2)
        {
            var val_5;
            if(t1 == null)
            {
                goto label_1;
            }
            
            if(t2 == null)
            {
                goto label_2;
            }
            
            var val_6 = 0;
            if(mem[1152921505130418176] == null)
            {
                goto label_4;
            }
            
            val_6 = val_6 + 1;
            goto label_6;
            label_1:
            var val_1 = (t2 != 0) ? 1 : 0;
            return 1424675532;
            label_2:
            val_5 = 0;
            return 1424675532;
            label_4:
            Royal.Infrastructure.UiComponents.Touch.ITouchable val_2 = 1152921505130381312 + ((mem[1152921505130418184]) << 4);
            label_6:
            Royal.Infrastructure.UiComponents.Touch.ZIndex val_3 = t1.ZIndex;
            var val_7 = 0;
            if(mem[1152921505130418176] != null)
            {
                    val_7 = val_7 + 1;
            }
            else
            {
                    Royal.Infrastructure.UiComponents.Touch.ITouchable val_4 = 1152921505130381312 + ((mem[1152921505130418184]) << 4);
            }
            
            Royal.Infrastructure.UiComponents.Touch.ZIndex val_5 = t2.ZIndex;
            return 1424675532;
        }
        public static void Sort(Royal.Infrastructure.UiComponents.Touch.ITouchable[] array, int arrayLength)
        {
            Royal.Infrastructure.UiComponents.Touch.UiTouchSorting.InsertionSort(array:  array, arrayLength:  arrayLength);
        }
        private static void InsertionSort(Royal.Infrastructure.UiComponents.Touch.ITouchable[] array, int arrayLength)
        {
            int val_4;
            int val_1 = arrayLength - 1;
            if(val_1 < 1)
            {
                    return;
            }
            
            var val_5 = 0;
            var val_9 = 2;
            do
            {
                val_5 = val_5 + 1;
                var val_6 = array[40];
                var val_7 = val_9;
                do
            {
                int val_8 = array.Length;
                var val_2 = val_7 - 2;
                val_7 = val_7 - 1;
                val_8 = val_8 & 4294967295;
                if((Royal.Infrastructure.UiComponents.Touch.UiTouchSorting.CompareZIndex(t1:  null, t2:  null)) >= 1)
            {
                    val_4 = array.Length;
                int val_4 = val_4 & 4294967295;
                if(null != null)
            {
                    val_4 = array.Length;
            }
            
                val_6 = null;
                val_6 = null;
            }
            
                val_6 = val_6 - 8;
            }
            while(val_7 > 1);
            
                val_9 = val_9 + 1;
            }
            while(val_5 < val_1);
        
        }
        public UiTouchSorting()
        {
        
        }
    
    }

}
