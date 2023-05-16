using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.Loading
{
    public class LoadingAssets : ScriptableObject
    {
        // Fields
        private const int RocketTip = 0;
        private const int TntLTip = 1;
        private const int PropellerTip = 2;
        private const int LightballTip = 3;
        private const int TntTTip = 4;
        private const int MegaTntTip = 5;
        private const int PropellerTrioTip = 6;
        public const int LoadingTipCount = 7;
        
        // Methods
        public Royal.Scenes.Start.Context.Units.Loading.View.LoadingTipView GetLoadingTipView()
        {
            return UnityEngine.Resources.Load<Royal.Scenes.Start.Context.Units.Loading.View.LoadingTipView>(path:  "LoadingTipView");
        }
        public Royal.Scenes.Start.Context.Units.Loading.View.ShopLoadingView GetShopLoadingView()
        {
            return UnityEngine.Resources.Load<Royal.Scenes.Start.Context.Units.Loading.View.ShopLoadingView>(path:  "ShopLoadingView");
        }
        public Royal.Scenes.Start.Context.Units.Loading.View.SplashView GetSplashView()
        {
            return UnityEngine.Resources.Load<Royal.Scenes.Start.Context.Units.Loading.View.SplashView>(path:  "SplashView");
        }
        public static UnityEngine.Sprite LoadCharacterSprite(int index)
        {
            return UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  (index == 1) ? "characters_music" : "characters_chess");
        }
        public Royal.Scenes.Start.Context.Units.Loading.View.LoadingTip LoadTipPrefab(int index)
        {
            string val_2;
            if((index - 1) <= 5)
            {
                    val_2 = mem[45126224 + ((index - 1)) << 3];
                val_2 = 45126224 + ((index - 1)) << 3;
                return UnityEngine.Resources.Load<Royal.Scenes.Start.Context.Units.Loading.View.LoadingTip>(path:  val_2 = "RocketTip");
            }
            
            return UnityEngine.Resources.Load<Royal.Scenes.Start.Context.Units.Loading.View.LoadingTip>(path:  val_2);
        }
        public static int GetLoadingTipForLevel(int levelNo)
        {
            if((levelNo - 3) > 17)
            {
                    return 0;
            }
            
            return (int)36532048 + ((levelNo - 3)) << 2;
        }
        public LoadingAssets()
        {
        
        }
    
    }

}
