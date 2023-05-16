using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.RemainingMoves
{
    public class RemainingMovesHitParticles : ItemParticles
    {
        // Methods
        public override int GetPoolId()
        {
            return 71;
        }
        public void Play()
        {
            this.GetComponent<UnityEngine.ParticleSystem>().Play();
            this.Invoke(methodName:  "RecycleSelf", time:  3f);
        }
        public RemainingMovesHitParticles()
        {
        
        }
    
    }

}
