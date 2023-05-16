using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View
{
    public class IceCrusherParticles : ItemParticles
    {
        // Fields
        public UnityEngine.Transform positioner;
        private UnityEngine.ParticleSystem[] particles;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            this.particles = this.GetComponentsInChildren<UnityEngine.ParticleSystem>(includeInactive:  true);
        }
        public void Play()
        {
            var val_5 = 4;
            label_7:
            if((val_5 - 4) >= this.particles.Length)
            {
                goto label_1;
            }
            
            EmissionModule val_2 = this.particles[0].emission;
            this.particles[0].Play();
            val_5 = val_5 + 1;
            if(this.particles != null)
            {
                goto label_7;
            }
            
            throw new NullReferenceException();
            label_1:
            this.RecycleInSeconds(seconds:  2f);
        }
        public void Pause()
        {
            var val_3 = 0;
            do
            {
                if(val_3 >= this.particles.Length)
            {
                    return;
            }
            
                EmissionModule val_1 = this.particles[val_3].emission;
                val_3 = val_3 + 1;
            }
            while(this.particles != null);
            
            throw new NullReferenceException();
        }
        public void RecycleInSeconds(float seconds)
        {
            this.Invoke(methodName:  "RecycleSelf", time:  seconds);
        }
        public override int GetPoolId()
        {
            return 73;
        }
        public void SetSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData getSortingWithOffset)
        {
            getSortingWithOffset.sortEverything = getSortingWithOffset.sortEverything & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.GetComponent<UnityEngine.Rendering.SortingGroup>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = getSortingWithOffset.layer, order = getSortingWithOffset.order, sortEverything = getSortingWithOffset.sortEverything});
        }
        public IceCrusherParticles()
        {
        
        }
    
    }

}
