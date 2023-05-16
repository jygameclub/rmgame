using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MatchItem.View
{
    public class SpecialItemCreationParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem glowParticle;
        private UnityEngine.Transform targetTransform;
        
        // Methods
        public void Init(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory factory, UnityEngine.Transform target)
        {
            this.targetTransform = target;
        }
        private void Update()
        {
            if(this.targetTransform == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = this.targetTransform.position;
            this.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        public void Play()
        {
            this.glowParticle.Play();
            this.Invoke(methodName:  "RecycleSelf", time:  1f);
        }
        public override void RecycleSelf()
        {
            this.targetTransform = 0;
            this.RecycleSelf();
        }
        private void PlayAll()
        {
            if(this.glowParticle != null)
            {
                    this.glowParticle.Play();
                return;
            }
            
            throw new NullReferenceException();
        }
        public override int GetPoolId()
        {
            return 5;
        }
        public SpecialItemCreationParticles()
        {
        
        }
    
    }

}
