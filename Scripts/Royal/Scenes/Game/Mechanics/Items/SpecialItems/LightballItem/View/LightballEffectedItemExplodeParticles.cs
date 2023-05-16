using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View
{
    public class LightballEffectedItemExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem circleParticle;
        public UnityEngine.ParticleSystem[] coloredParticles;
        public UnityEngine.Color[] particleColors;
        
        // Methods
        public void Play(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            UnityEngine.Color val_1 = this.GetParticleColorFromMatchType(type:  matchType);
            MainModule val_2 = this.circleParticle.main;
            MinMaxGradient val_3 = ParticleSystem.MinMaxGradient.op_Implicit(color:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
            var val_11 = 0;
            label_6:
            if(val_11 >= this.coloredParticles.Length)
            {
                goto label_3;
            }
            
            MainModule val_8 = this.coloredParticles[val_11].main;
            MinMaxGradient val_9 = ParticleSystem.MinMaxGradient.op_Implicit(color:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
            val_11 = val_11 + 1;
            if(this.coloredParticles != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_3:
            this.circleParticle.Play();
            this.Invoke(methodName:  "RecycleSelf", time:  1f);
        }
        public override int GetPoolId()
        {
            return 26;
        }
        private UnityEngine.Color GetParticleColorFromMatchType(Royal.Scenes.Game.Mechanics.Matches.MatchType type)
        {
            if((type - 1) <= 5)
            {
                    var val_2 = 36610200 + ((type - 1)) << 2;
                val_2 = val_2 + 36610200;
            }
            else
            {
                    return new UnityEngine.Color() {r = -2.631914E+07f, g = -2.631914E+07f, b = -2.631914E+07f, a = -2.631914E+07f};
            }
        
        }
        public LightballEffectedItemExplodeParticles()
        {
        
        }
    
    }

}
