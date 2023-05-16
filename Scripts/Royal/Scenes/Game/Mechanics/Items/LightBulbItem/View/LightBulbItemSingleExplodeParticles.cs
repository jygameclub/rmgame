using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View
{
    public class LightBulbItemSingleExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem bulbParticles;
        public UnityEngine.ParticleSystem glareBlast;
        public UnityEngine.ParticleSystem background;
        public UnityEngine.ParticleSystem smoke;
        public UnityEngine.ParticleSystem dust;
        public UnityEngine.ParticleSystem cable;
        
        // Methods
        public void Play(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType, int index)
        {
            float val_38;
            float val_39;
            float val_40;
            var val_41;
            float val_42;
            float val_43;
            if((matchType - 1) <= 3)
            {
                    var val_38 = 36605920 + ((matchType - 1)) << 2;
                val_38 = val_38 + 36605920;
            }
            else
            {
                    val_38 = 0.6588235f;
                val_39 = 0.2f;
                val_40 = 0.5215687f;
                val_41 = val_39;
                MainModule val_2 = this.glareBlast.main;
                MinMaxGradient val_3 = ParticleSystem.MinMaxGradient.op_Implicit(color:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
                MainModule val_8 = this.background.main;
                MinMaxGradient val_9 = ParticleSystem.MinMaxGradient.op_Implicit(color:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
                MainModule val_14 = this.smoke.main;
                MinMaxGradient val_15 = ParticleSystem.MinMaxGradient.op_Implicit(color:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
                MainModule val_20 = this.dust.main;
                MinMaxGradient val_21 = ParticleSystem.MinMaxGradient.op_Implicit(color:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
                EmissionModule val_26 = this.cable.emission;
                if(index <= 8)
            {
                
            }
            
                MinMaxCurve val_31 = ParticleSystem.MinMaxCurve.op_Implicit(constant:  2f);
                EmissionModule val_34 = this.cable.emission;
                val_42 = 0f;
                if(index <= 8)
            {
                    val_42 = mem[36606384 + (index) << 2];
                val_42 = 36606384 + (index) << 2;
            }
            
                ShapeModule val_35 = this.cable.shape;
                float val_39 = -0.08f;
                val_39 = val_42 + val_39;
                if((index - 1) <= 7)
            {
                    val_43 = mem[36606432 + ((index - 1)) << 2];
                val_43 = 36606432 + ((index - 1)) << 2;
            }
            else
            {
                    val_43 = 0.35f;
            }
            
                float val_40 = 0.08f;
                val_43 = val_42 + val_43;
                val_40 = val_43 + val_40;
                this.cable.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                this.bulbParticles.Play();
                this.Invoke(methodName:  "RecycleSelf", time:  2f);
            }
        
        }
        private int GetCableParticleCountByIndex(int index)
        {
            if(index > 8)
            {
                    return 2;
            }
            
            return (int)36606336 + (index) << 2;
        }
        private float GetCableShapeRadiusByIndex(int index)
        {
            if(index > 8)
            {
                    return 0f;
            }
            
            return (float)36606384 + (index) << 2;
        }
        private float GetYOffsetByIndex(int index)
        {
            if((index - 1) > 7)
            {
                    return 0.35f;
            }
            
            return (float)36606432 + ((index - 1)) << 2;
        }
        public override int GetPoolId()
        {
            return 109;
        }
        public LightBulbItemSingleExplodeParticles()
        {
        
        }
    
    }

}
