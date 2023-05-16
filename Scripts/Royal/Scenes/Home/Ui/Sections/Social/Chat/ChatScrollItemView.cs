using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.Chat
{
    public abstract class ChatScrollItemView : MonoBehaviour, IPoolable
    {
        // Methods
        public abstract int GetPoolId(); // 0
        public void OnSpawn()
        {
        
        }
        public void OnRecycle()
        {
        
        }
        protected ChatScrollItemView()
        {
        
        }
    
    }

}
