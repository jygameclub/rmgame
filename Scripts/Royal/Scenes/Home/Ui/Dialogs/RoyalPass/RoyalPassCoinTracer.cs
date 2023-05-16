using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassCoinTracer : MonoBehaviour
    {
        // Fields
        public Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesCoinTracer tracer;
        public UnityEngine.ParticleSystem hitParticle;
        public static float StartSpeed;
        public static float MaxSpeed;
        public static float LocalFinalSpeed;
        
        // Methods
        public void Animate(UnityEngine.Vector3 startPosition, UnityEngine.Vector3 endPosition, System.Action onComplete)
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.CurveFromTopBarEndToBank(startPosition:  new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z}, endPosition:  new UnityEngine.Vector3() {x = endPosition.x, y = endPosition.y, z = endPosition.z}, onComplete:  onComplete));
        }
        private void DrawRectAtPoint(float x, float y, UnityEngine.Color color)
        {
            float val_16 = y;
            float val_1 = x + 0.25f;
            float val_2 = val_16 + 0.25f;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_1, y:  val_2);
            val_16 = val_16 + (-0.25f);
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_1, y:  val_16);
            float val_5 = x + (-0.25f);
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_5, y:  val_2);
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_5, y:  val_16);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            UnityEngine.Vector3 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, end:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, color:  new UnityEngine.Color() {r = color.r, g = color.b, b = 5f, a = color.r}, duration:  color.a);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
            UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, end:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, color:  new UnityEngine.Color() {r = color.r, g = color.b, b = 5f, a = color.r}, duration:  color.a);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
            UnityEngine.Vector3 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, end:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, color:  new UnityEngine.Color() {r = color.r, g = color.b, b = 5f, a = color.r}, duration:  color.a);
            UnityEngine.Vector3 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            UnityEngine.Vector3 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, end:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, color:  new UnityEngine.Color() {r = color.r, g = color.b, b = 5f, a = color.r}, duration:  color.a);
        }
        private System.Collections.IEnumerator CurveFromTopBarEndToBank(UnityEngine.Vector3 startPosition, UnityEngine.Vector3 endPosition, System.Action onComplete)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .startPosition = startPosition;
            mem[1152921519195169372] = startPosition.y;
            mem[1152921519195169376] = startPosition.z;
            .endPosition = endPosition;
            mem[1152921519195169384] = endPosition.y;
            mem[1152921519195169388] = endPosition.z;
            .onComplete = onComplete;
            return (System.Collections.IEnumerator)new RoyalPassCoinTracer.<CurveFromTopBarEndToBank>d__7();
        }
        private void PlayHitParticlesAndRecycleDelayed()
        {
            this.hitParticle.Play();
            this.Invoke(methodName:  "DestroyDelayed", time:  3f);
        }
        private void DestroyDelayed()
        {
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        public RoyalPassCoinTracer()
        {
        
        }
        private static RoyalPassCoinTracer()
        {
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassCoinTracer.StartSpeed = 0.85f;
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassCoinTracer.MaxSpeed = 0.95f;
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassCoinTracer.LocalFinalSpeed = 1f;
        }
    
    }

}
