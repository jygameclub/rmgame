using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.Loading.View
{
    public abstract class LoadingView : MonoBehaviour
    {
        // Methods
        public abstract void Init(Royal.Scenes.Start.Context.Units.Loading.LoadingAssets assets); // 0
        public abstract void FadeIn(System.Action onComplete, int level); // 0
        public abstract void FadeOut(float delay = 0, System.Action onComplete); // 0
        protected LoadingView()
        {
        
        }
    
    }

}
