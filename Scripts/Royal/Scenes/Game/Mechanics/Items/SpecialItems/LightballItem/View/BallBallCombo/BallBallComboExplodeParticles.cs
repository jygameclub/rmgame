using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.BallBallCombo
{
    public class BallBallComboExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem circleParticle;
        
        // Methods
        public void Play()
        {
            this.circleParticle.Play();
            this.Invoke(methodName:  "RecycleSelf", time:  2f);
        }
        public override int GetPoolId()
        {
            return 30;
        }
        public BallBallComboExplodeParticles()
        {
        
        }
    
    }

}
