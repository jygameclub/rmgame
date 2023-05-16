using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.Config
{
    public abstract class ItemParticles : MonoBehaviour, IPoolable
    {
        // Fields
        protected Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory factory;
        private Royal.Scenes.Game.Levels.Units.ParticlesManager particlesManager;
        
        // Methods
        protected virtual void Awake()
        {
            this.particlesManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ParticlesManager>(contextId:  18);
            this.factory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
        }
        public virtual void RecycleSelf()
        {
            this.factory.Recycle<Royal.Scenes.Game.Mechanics.Items.Config.ItemParticles>(go:  this);
        }
        public abstract int GetPoolId(); // 0
        public virtual void OnSpawn()
        {
            if(this.particlesManager != null)
            {
                    this.particlesManager.ParticlesSpawned(particles:  this);
                return;
            }
            
            throw new NullReferenceException();
        }
        public virtual void OnRecycle()
        {
            if(this.particlesManager != null)
            {
                    this.particlesManager.ParticlesRecycled(particles:  this);
                return;
            }
            
            throw new NullReferenceException();
        }
        protected ItemParticles()
        {
        
        }
    
    }

}
