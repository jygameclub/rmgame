using UnityEngine;

namespace Royal.Infrastructure.Utils.Animation.Tween
{
    public class MTweenPlayer : MonoBehaviour
    {
        // Fields
        public static readonly Royal.Infrastructure.Utils.Animation.Tween.MTweenPlayer Instance;
        
        // Methods
        private static MTweenPlayer()
        {
            if(Royal.Infrastructure.Utils.Animation.Tween.MTweenPlayer.Instance != 0)
            {
                    return;
            }
            
            Royal.Infrastructure.Utils.Animation.Tween.MTweenPlayer.Instance = new UnityEngine.GameObject().AddComponent<Royal.Infrastructure.Utils.Animation.Tween.MTweenPlayer>();
            UnityEngine.Object.DontDestroyOnLoad(target:  Royal.Infrastructure.Utils.Animation.Tween.MTweenPlayer.Instance);
        }
        public MTweenPlayer()
        {
        
        }
    
    }

}
