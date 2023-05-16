using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassBonusBankProgress : MonoBehaviour
    {
        // Fields
        private const float BarFullFrames = 60;
        private const float ProgressBarMaxThreshold = 0.96;
        private const float ProgressBarMinThreshold = 0.03;
        private float totalLeftBarSize;
        public UnityEngine.SpriteRenderer leftProgressBar;
        public UnityEngine.SpriteRenderer rightProgressBar;
        public TMPro.TextMeshPro barText;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassLastRowView royalPassLastRowView;
        private bool isRightProgressBarActive;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private Royal.Player.Context.Units.RoyalPassManager royalPassManager;
        private int barCurrent;
        private int barTarget;
        
        // Methods
        public void Init()
        {
            Royal.Player.Context.Units.RoyalPassManager val_9;
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.royalPassManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
            int val_3 = this.royalPassManager.GetSafeFullCoins();
            if((this.royalPassManager.GetSafeKeyStage(key:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 64 + 24)) > (this.royalPassManager.GetSafeKeyStage(key:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 64 + 20)))
            {
                    Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 64.Consume();
                val_9 = this.royalPassManager;
                int val_6 = val_9.GetSafeEarnedCoinsBefore(before:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 64 + 20);
            }
            else
            {
                    val_9 = this.royalPassManager;
            }
            
            this.SetBarValues(current:  UnityEngine.Mathf.Min(a:  val_9.GetSafeEarnedCoins(), b:  val_3), target:  val_3);
        }
        public void AnimateSafeCoinIncrement(UnityEngine.Vector3 initialPosition, UnityEngine.Vector3 finalPosition)
        {
            this.audioManager.PlaySound(type:  242, offset:  0.04f);
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassCoinTracer val_2 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassCoinTracer>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassCoinTracer>(path:  "RoyalPassCoinTracer"));
            val_2.transform.position = new UnityEngine.Vector3() {x = initialPosition.x, y = initialPosition.y, z = initialPosition.z};
            UnityEngine.Coroutine val_6 = val_2.StartCoroutine(routine:  val_2.CurveFromTopBarEndToBank(startPosition:  new UnityEngine.Vector3() {x = initialPosition.x, y = initialPosition.y, z = initialPosition.z}, endPosition:  new UnityEngine.Vector3() {x = finalPosition.x, y = finalPosition.y, z = finalPosition.z}, onComplete:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassBonusBankProgress::<AnimateSafeCoinIncrement>b__14_0())));
        }
        private void AnimateBar(int start, int end, int target, System.Action onComplete)
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.ProgressBarCoroutine(start:  start, end:  end, target:  target, onComplete:  onComplete));
        }
        private void SetBarValues(int current, int target)
        {
            this.SetBarText(current:  current, target:  target);
            if(current == target)
            {
                
            }
            else
            {
                    float val_2 = (float)current;
                val_2 = val_2 / (float)target;
                val_2 = val_2 * 0.93f;
                val_2 = val_2 + 0.03f;
            }
            
            this.UpdateBarSize(ratio:  (val_2 == 0f) ? 0f : (val_2));
        }
        private void UpdateBarSize(float ratio)
        {
            float val_13 = ratio;
            if(val_13 > 0f)
            {
                    this.EnableBarSprites();
                val_13 = this.totalLeftBarSize * val_13;
                UnityEngine.Vector2 val_1 = this.leftProgressBar.size;
                UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_13, y:  val_1.y);
                this.leftProgressBar.size = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
                float val_4 = UnityEngine.Mathf.Lerp(a:  0f, b:  0.2f, t:  val_13 / 0.2f);
                UnityEngine.Vector2 val_5 = this.rightProgressBar.size;
                UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_4, y:  val_5.y);
                this.rightProgressBar.size = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
                UnityEngine.Vector3 val_9 = this.rightProgressBar.transform.localPosition;
                UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  val_13 + val_4, y:  val_9.y);
                UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
                this.rightProgressBar.transform.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
                return;
            }
            
            this.DisableBarSprites();
        }
        private void EnableBarSprites()
        {
            this.leftProgressBar.gameObject.SetActive(value:  true);
            this.rightProgressBar.gameObject.SetActive(value:  true);
        }
        private void DisableBarSprites()
        {
            this.leftProgressBar.gameObject.SetActive(value:  false);
            this.rightProgressBar.gameObject.SetActive(value:  false);
        }
        private float GetThresholdedRatio(float ratio)
        {
            ratio = ratio * 0.93f;
            ratio = ratio + 0.03f;
            return (float)(ratio == 0f) ? 0f : (ratio);
        }
        private System.Collections.IEnumerator ProgressBarCoroutine(int start, int end, int target, System.Action onComplete)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .target = target;
            .end = end;
            .start = start;
            .onComplete = onComplete;
            return (System.Collections.IEnumerator)new RoyalPassBonusBankProgress.<ProgressBarCoroutine>d__21();
        }
        private void SetBarText(int current, int target)
        {
            int val_2 = current;
            if(this.barCurrent == val_2)
            {
                    if(this.barTarget == target)
            {
                    return;
            }
            
            }
            
            this.barCurrent = val_2;
            this.barTarget = target;
            val_2 = val_2;
            this.barText.text = System.String.Format(format:  "{0}/{1}", arg0:  val_2 = current, arg1:  target);
        }
        public RoyalPassBonusBankProgress()
        {
            this.totalLeftBarSize = 5.465581f;
        }
        private void <AnimateSafeCoinIncrement>b__14_0()
        {
            var val_6;
            System.Action val_8;
            this.royalPassLastRowView.AnimateBankHit();
            val_6 = null;
            val_6 = null;
            val_8 = RoyalPassBonusBankProgress.<>c.<>9__14_1;
            if(val_8 == null)
            {
                    System.Action val_3 = null;
                val_8 = val_3;
                val_3 = new System.Action(object:  RoyalPassBonusBankProgress.<>c.__il2cppRuntimeField_static_fields, method:  System.Void RoyalPassBonusBankProgress.<>c::<AnimateSafeCoinIncrement>b__14_1());
                RoyalPassBonusBankProgress.<>c.<>9__14_1 = val_8;
            }
            
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.ProgressBarCoroutine(start:  this.barCurrent, end:  this.barCurrent + 100, target:  this.royalPassManager.GetSafeFullCoins(), onComplete:  val_3));
        }
    
    }

}
