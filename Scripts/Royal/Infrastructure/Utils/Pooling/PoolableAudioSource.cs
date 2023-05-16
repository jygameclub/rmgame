using UnityEngine;

namespace Royal.Infrastructure.Utils.Pooling
{
    public class PoolableAudioSource : MonoBehaviour, IPoolable
    {
        // Fields
        public UnityEngine.AudioSource audioSource;
        
        // Methods
        public int GetPoolId()
        {
            return 0;
        }
        public void OnSpawn()
        {
        
        }
        public void OnRecycle()
        {
            this.audioSource.Stop();
            this.audioSource.volume = 1f;
            this.audioSource.clip = 0;
            this.UnMute();
        }
        public void Mute()
        {
            if(this.audioSource != null)
            {
                    this.audioSource.mute = true;
                return;
            }
            
            throw new NullReferenceException();
        }
        public void UnMute()
        {
            if(this.audioSource != null)
            {
                    this.audioSource.mute = false;
                return;
            }
            
            throw new NullReferenceException();
        }
        public PoolableAudioSource()
        {
        
        }
    
    }

}
