using UnityEngine;

namespace Royal.Scenes.Home.Areas.Scripts
{
    public class AreaTaskAssetsLibrary
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.Type, Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets> assets;
        
        // Methods
        public AreaTaskAssetsLibrary()
        {
            this.assets = new System.Collections.Generic.Dictionary<System.Type, Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets>(capacity:  50);
        }
        public T Load<T>()
        {
            var val_4;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48});
            if((this.assets.TryGetValue(key:  val_1, value: out  0)) != true)
            {
                    this.assets.set_Item(key:  val_1, value:  val_1);
            }
            
            if(val_1 != 0)
            {
                    if(X0 == true)
            {
                    return (object)val_4;
            }
            
            }
            
            val_4 = 0;
            return (object)val_4;
        }
    
    }

}
