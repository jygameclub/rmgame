using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View
{
    public class ChainItemExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem particles;
        public UnityEngine.ParticleSystem[] particlesToFlip;
        public UnityEngine.ParticleSystemRenderer[] particleSystemRenderersToFlip;
        
        // Methods
        public void Play(bool flipParticles)
        {
            UnityEngine.ParticleSystemCurveMode val_3;
            UnityEngine.AnimationCurve val_4;
            var val_13;
            if(flipParticles == false)
            {
                goto label_1;
            }
            
            var val_17 = 0;
            label_8:
            if(val_17 >= this.particlesToFlip.Length)
            {
                goto label_3;
            }
            
            UnityEngine.ParticleSystem val_13 = this.particlesToFlip[val_17];
            ShapeModule val_1 = val_13.shape;
            float val_14 = System.Math.Abs(V2.16B);
            VelocityOverLifetimeModule val_2 = val_13.velocityOverLifetime;
            val_3.yAdvance = System.Math.Abs(val_3.yAdvance);
            val_3.yAdvance = System.Math.Abs(val_3.yAdvance);
            ParticleSystem.VelocityOverLifetimeModule.set_x_Injected(_unity_self: ref  new ParticleSystem.VelocityOverLifetimeModule() {m_ParticleSystem = val_2.m_ParticleSystem}, value: ref  new MinMaxCurve() {m_Mode = val_3, m_CurveMultiplier = val_3, m_CurveMin = val_4, m_CurveMax = val_4});
            val_17 = val_17 + 1;
            if(this.particlesToFlip != null)
            {
                goto label_8;
            }
            
            label_1:
            var val_22 = 0;
            label_16:
            if(val_22 >= this.particlesToFlip.Length)
            {
                goto label_11;
            }
            
            UnityEngine.ParticleSystem val_18 = this.particlesToFlip[val_22];
            ShapeModule val_7 = val_18.shape;
            float val_19 = System.Math.Abs(V2.16B);
            VelocityOverLifetimeModule val_8 = val_18.velocityOverLifetime;
            val_3.yAdvance = -System.Math.Abs(val_3.yAdvance);
            val_3.yAdvance = -System.Math.Abs(val_3.yAdvance);
            ParticleSystem.VelocityOverLifetimeModule.set_x_Injected(_unity_self: ref  new ParticleSystem.VelocityOverLifetimeModule() {m_ParticleSystem = val_8.m_ParticleSystem}, value: ref  new MinMaxCurve() {m_Mode = val_3, m_CurveMultiplier = val_3, m_CurveMin = val_4, m_CurveMax = val_4, m_ConstantMin = val_3, m_ConstantMax = val_3});
            val_22 = val_22 + 1;
            if(this.particlesToFlip != null)
            {
                goto label_16;
            }
            
            label_3:
            val_13 = 0;
            label_22:
            if(val_13 >= this.particleSystemRenderersToFlip.Length)
            {
                goto label_25;
            }
            
            UnityEngine.ParticleSystemRenderer val_23 = this.particleSystemRenderersToFlip[val_13];
            UnityEngine.Vector3 val_11 = val_23.flip;
            val_23.flip = new UnityEngine.Vector3() {x = 1f, y = val_11.y, z = val_11.z};
            val_13 = val_13 + 1;
            if(this.particleSystemRenderersToFlip != null)
            {
                goto label_22;
            }
            
            label_11:
            val_13 = 0;
            label_28:
            if(val_13 >= this.particleSystemRenderersToFlip.Length)
            {
                goto label_25;
            }
            
            UnityEngine.ParticleSystemRenderer val_24 = this.particleSystemRenderersToFlip[val_13];
            UnityEngine.Vector3 val_12 = val_24.flip;
            val_24.flip = new UnityEngine.Vector3() {x = 0f, y = val_12.y, z = val_12.z};
            val_13 = val_13 + 1;
            if(this.particleSystemRenderersToFlip != null)
            {
                goto label_28;
            }
            
            label_25:
            this.particles.Play();
            this.Invoke(methodName:  "RecycleSelf", time:  3f);
        }
        public override int GetPoolId()
        {
            return 127;
        }
        public ChainItemExplodeParticles()
        {
        
        }
    
    }

}
