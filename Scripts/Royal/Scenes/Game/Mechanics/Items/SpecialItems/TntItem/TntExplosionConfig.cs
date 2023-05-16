using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem
{
    public struct TntExplosionConfig
    {
        // Fields
        public int explodeRadius;
        public Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig shakeConfig;
        public float ringExplodeInterval;
        public float tntExplodeDelay;
        public int impactRadius;
        public float impactForceFactor;
        public float impactFirstSpeedFactor;
        public float impactLastSpeedFactorForFirstRing;
        public float impactLastSpeedFactorForSecondRing;
        public float extraFreezeTimeForTopImpactedItems;
        
        // Properties
        public int TotalRadius { get; }
        
        // Methods
        public int get_TotalRadius()
        {
            return (int)this.impactLastSpeedFactorForSecondRing + W8;
        }
    
    }

}
