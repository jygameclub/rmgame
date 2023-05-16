using UnityEngine;

namespace Coffee.UIExtensions
{
    public class MaterialCache
    {
        // Fields
        private ulong <hash>k__BackingField;
        private int <referenceCount>k__BackingField;
        private UnityEngine.Texture <texture>k__BackingField;
        private UnityEngine.Material <material>k__BackingField;
        public static System.Collections.Generic.List<Coffee.UIExtensions.MaterialCache> materialCaches;
        
        // Properties
        public ulong hash { get; set; }
        public int referenceCount { get; set; }
        public UnityEngine.Texture texture { get; set; }
        public UnityEngine.Material material { get; set; }
        
        // Methods
        public ulong get_hash()
        {
            return (ulong)this.<hash>k__BackingField;
        }
        private void set_hash(ulong value)
        {
            this.<hash>k__BackingField = value;
        }
        public int get_referenceCount()
        {
            return (int)this.<referenceCount>k__BackingField;
        }
        private void set_referenceCount(int value)
        {
            this.<referenceCount>k__BackingField = value;
        }
        public UnityEngine.Texture get_texture()
        {
            return (UnityEngine.Texture)this.<texture>k__BackingField;
        }
        private void set_texture(UnityEngine.Texture value)
        {
            this.<texture>k__BackingField = value;
        }
        public UnityEngine.Material get_material()
        {
            return (UnityEngine.Material)this.<material>k__BackingField;
        }
        private void set_material(UnityEngine.Material value)
        {
            this.<material>k__BackingField = value;
        }
        public static Coffee.UIExtensions.MaterialCache Register(ulong hash, UnityEngine.Texture texture, System.Func<UnityEngine.Material> onCreateMaterial)
        {
            var val_9;
            Coffee.UIExtensions.MaterialCache val_10;
            var val_11;
            var val_12;
            .hash = hash;
            val_9 = null;
            val_9 = null;
            Coffee.UIExtensions.MaterialCache val_3 = System.Linq.Enumerable.FirstOrDefault<Coffee.UIExtensions.MaterialCache>(source:  Coffee.UIExtensions.MaterialCache.materialCaches, predicate:  new System.Func<Coffee.UIExtensions.MaterialCache, System.Boolean>(object:  new MaterialCache.<>c__DisplayClass17_0(), method:  System.Boolean MaterialCache.<>c__DisplayClass17_0::<Register>b__0(Coffee.UIExtensions.MaterialCache x)));
            if(val_3 != null)
            {
                    val_10 = val_3;
                if((UnityEngine.Object.op_Implicit(exists:  val_3.<material>k__BackingField)) == false)
            {
                    return val_10;
            }
            
                if((UnityEngine.Object.op_Implicit(exists:  val_3.<material>k__BackingField)) != false)
            {
                    int val_9 = val_3.<referenceCount>k__BackingField;
                val_9 = val_9 + 1;
                val_10 = val_9;
                return val_10;
            }
            
                val_11 = null;
                val_11 = null;
                bool val_6 = Coffee.UIExtensions.MaterialCache.materialCaches.Remove(item:  val_10);
            }
            
            Coffee.UIExtensions.MaterialCache val_7 = null;
            val_10 = val_7;
            val_7 = new Coffee.UIExtensions.MaterialCache();
            .<hash>k__BackingField = (MaterialCache.<>c__DisplayClass17_0)[1152921528900345760].hash;
            .<material>k__BackingField = onCreateMaterial.Invoke();
            .<referenceCount>k__BackingField = 1;
            val_12 = null;
            val_12 = null;
            Coffee.UIExtensions.MaterialCache.materialCaches.Add(item:  val_7);
            return val_10;
        }
        public static Coffee.UIExtensions.MaterialCache Register(ulong hash, System.Func<UnityEngine.Material> onCreateMaterial)
        {
            var val_6;
            Coffee.UIExtensions.MaterialCache val_7;
            var val_8;
            .hash = hash;
            val_6 = null;
            val_6 = null;
            Coffee.UIExtensions.MaterialCache val_3 = System.Linq.Enumerable.FirstOrDefault<Coffee.UIExtensions.MaterialCache>(source:  Coffee.UIExtensions.MaterialCache.materialCaches, predicate:  new System.Func<Coffee.UIExtensions.MaterialCache, System.Boolean>(object:  new MaterialCache.<>c__DisplayClass18_0(), method:  System.Boolean MaterialCache.<>c__DisplayClass18_0::<Register>b__0(Coffee.UIExtensions.MaterialCache x)));
            if(val_3 != null)
            {
                    int val_6 = val_3.<referenceCount>k__BackingField;
                val_7 = val_3;
                val_6 = val_6 + 1;
                val_3 = val_6;
                return val_7;
            }
            
            Coffee.UIExtensions.MaterialCache val_4 = null;
            val_7 = val_4;
            val_4 = new Coffee.UIExtensions.MaterialCache();
            .<hash>k__BackingField = (MaterialCache.<>c__DisplayClass18_0)[1152921528900516128].hash;
            .<material>k__BackingField = onCreateMaterial.Invoke();
            .<referenceCount>k__BackingField = 1;
            val_8 = null;
            val_8 = null;
            Coffee.UIExtensions.MaterialCache.materialCaches.Add(item:  val_4);
            return val_7;
        }
        public static void Unregister(Coffee.UIExtensions.MaterialCache cache)
        {
            var val_2;
            if(cache == null)
            {
                    return;
            }
            
            int val_2 = cache.<referenceCount>k__BackingField;
            val_2 = val_2 - 1;
            cache = val_2;
            if(val_2 > 0)
            {
                    return;
            }
            
            val_2 = null;
            val_2 = null;
            bool val_1 = Coffee.UIExtensions.MaterialCache.materialCaches.Remove(item:  cache);
            cache = 0;
        }
        public MaterialCache()
        {
        
        }
        private static MaterialCache()
        {
            Coffee.UIExtensions.MaterialCache.materialCaches = new System.Collections.Generic.List<Coffee.UIExtensions.MaterialCache>();
        }
    
    }

}
