using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MatchItem.View
{
    public class MatchItemSwapParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem TopParticles;
        public UnityEngine.ParticleSystem BottomParticles;
        public UnityEngine.ParticleSystem LeftParticles;
        public UnityEngine.ParticleSystem RightParticles;
        private UnityEngine.Renderer[] renderers;
        
        // Methods
        public override int GetPoolId()
        {
            return 3;
        }
        protected override void Awake()
        {
            this.Awake();
            this.renderers = this.GetComponentsInChildren<UnityEngine.Renderer>();
        }
        public void Init(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory factory, UnityEngine.Transform parent)
        {
            parent.transform.SetParent(p:  parent);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            this.transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.identity;
            this.transform.localRotation = new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w};
        }
        public void Play(int neighborType)
        {
            int val_1 = neighborType - 1;
            var val_2 = 36605984 + ((neighborType - 1)) << 2;
            val_2 = val_2 + 36605984;
            goto (36605984 + ((neighborType - 1)) << 2 + 36605984);
        }
        private UnityEngine.ParticleSystem GetParticleForDirection(int neighborType)
        {
            var val_2 = 0;
            if((neighborType - 1) > 6)
            {
                    return (UnityEngine.ParticleSystem);
            }
            
            var val_2 = 36606012 + ((neighborType - 1)) << 2;
            val_2 = val_2 + 36606012;
            goto (36606012 + ((neighborType - 1)) << 2 + 36606012);
        }
        public void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            var val_5 = 0;
            do
            {
                if(val_5 >= (this.renderers.Length << ))
            {
                    return;
            }
            
                Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.renderers[val_5], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = (X21 & (-4294967296)) | (sortingData.sortEverything & 4294967295)});
                val_5 = val_5 + 1;
            }
            while(this.renderers != null);
            
            throw new NullReferenceException();
        }
        public MatchItemSwapParticles()
        {
        
        }
    
    }

}
