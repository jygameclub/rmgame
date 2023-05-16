using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area09.Tasks.Tables
{
    public class Area09TablesView : AreaTaskViewAnimation
    {
        // Methods
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            if(true == 0)
            {
                    return;
            }
            
            Royal.Scenes.Home.Areas.Scripts.AreaTaskFinalParticles val_3 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Areas.Scripts.AreaTaskFinalParticles>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Areas.Scripts.AreaTaskFinalParticles>(path:  "Area09TablesReplayFinalParticles"), parent:  this.transform, worldPositionStays:  true);
            UnityEngine.Transform val_4 = val_3.transform;
            UnityEngine.Transform val_5 = this.transform;
            UnityEngine.Vector3 val_6 = val_5.position;
            val_4.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Vector3 val_7 = val_5.localScale;
            val_4.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            val_3.PlayAndDestroy();
        }
        protected override void PrepareReplayFinalParticles(Royal.Scenes.Home.Areas.Scripts.AreaTaskFinalParticles particles)
        {
            if(val_1.Length < 1)
            {
                    return;
            }
            
            var val_9 = 0;
            do
            {
                T val_8 = particles.GetComponentsInChildren<UnityEngine.ParticleSystem>()[val_9];
                MainModule val_2 = val_8.main;
                MinMaxCurve val_3 = ParticleSystem.MinMaxCurve.op_Implicit(constant:  0f);
                bool val_7 = System.String.op_Equality(a:  val_8.name, b:  "notes");
                val_9 = val_9 + 1;
            }
            while(val_9 < val_1.Length);
        
        }
        public Area09TablesView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
