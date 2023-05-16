using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units
{
    public class ParticlesManager : IGameContextUnit, IContextUnit
    {
        // Fields
        private System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.Config.ItemParticles> activeParticles;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 18;
        }
        public void Bind()
        {
            this.activeParticles = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.Config.ItemParticles>();
        }
        public void ParticlesSpawned(Royal.Scenes.Game.Mechanics.Items.Config.ItemParticles particles)
        {
            this.activeParticles.Add(item:  particles);
        }
        public void ParticlesRecycled(Royal.Scenes.Game.Mechanics.Items.Config.ItemParticles particles)
        {
            bool val_1 = this.activeParticles.Remove(item:  particles);
        }
        public void Clear(bool gameExit)
        {
            var val_3 = 0;
            if(<0)
            {
                    return;
            }
            
            var val_3 = 33;
            do
            {
                if(true <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(0.gameObject.activeSelf != false)
            {
                    0.CancelInvoke();
            }
            
                val_3 = val_3 - 1;
                if((val_3 & 2147483648) != 0)
            {
                    return;
            }
            
                val_3 = val_3 - 8;
            }
            while(this.activeParticles != null);
            
            throw new NullReferenceException();
        }
        public ParticlesManager()
        {
        
        }
    
    }

}
