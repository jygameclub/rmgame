using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Crack
{
    public class BirdNestCrack : MonoBehaviour
    {
        // Fields
        private static readonly int CrackDefault;
        private static readonly int CrackAppear;
        private static readonly int CrackIdle1;
        private static readonly int CrackIdle2;
        public UnityEngine.Animator birdAnimator;
        private float nextIdleTime;
        
        // Methods
        public void PlayAppearAnimation(int index, UnityEngine.GameObject egg)
        {
            this.birdAnimator.gameObject.SetActive(value:  false);
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.DelayAppear(index:  index, egg:  egg));
        }
        public void ForceShow()
        {
            this.StopAllCoroutines();
            this.birdAnimator.gameObject.SetActive(value:  true);
            this.birdAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Crack.BirdNestCrack.CrackDefault, layer:  0, normalizedTime:  0f);
        }
        private System.Collections.IEnumerator DelayAppear(int index, UnityEngine.GameObject egg)
        {
            .<>1__state = 0;
            .index = index;
            .<>4__this = this;
            .egg = egg;
            return (System.Collections.IEnumerator)new BirdNestCrack.<DelayAppear>d__8();
        }
        private void Update()
        {
            int val_4;
            float val_5;
            int val_6;
            var val_8;
            if(this.birdAnimator.gameObject.activeSelf == false)
            {
                    return;
            }
            
            UnityEngine.AnimatorStateInfo val_3 = this.birdAnimator.GetCurrentAnimatorStateInfo(layerIndex:  0);
            val_8 = null;
            val_8 = null;
            if( == Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Crack.BirdNestCrack.CrackAppear)
            {
                    if(val_5 <= 1f)
            {
                    return;
            }
            
            }
            
            if(val_5 < 1f)
            {
                    return;
            }
            
            this.PickRandomIdleAnimation(state:  new UnityEngine.AnimatorStateInfo() {m_Name = val_6, m_Path = val_6, m_FullPath = val_6, m_NormalizedTime = val_6, m_Length = val_5, m_Speed = val_5, m_SpeedMultiplier = val_5, m_Tag = val_5, m_Loop = val_4});
        }
        private void PickRandomIdleAnimation(UnityEngine.AnimatorStateInfo state)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            int val_10;
            var val_11;
            if(this.nextIdleTime >= 0)
            {
                goto label_7;
            }
            
            val_5 = 1152921523861454208;
            val_6 = null;
            val_6 = null;
            if(val_5 == Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Crack.BirdNestCrack.CrackIdle1)
            {
                goto label_4;
            }
            
            val_7 = null;
            val_7 = null;
            if(1152921523861454208 != Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Crack.BirdNestCrack.CrackIdle2)
            {
                goto label_7;
            }
            
            label_4:
            float val_2 = UnityEngine.Random.value;
            float val_5 = 1.5f;
            val_5 = Royal.Scenes.Game.Levels.LevelContext.Time + val_5;
            val_2 = val_5 + val_2;
            this.nextIdleTime = val_2;
            return;
            label_7:
            if(Royal.Scenes.Game.Levels.LevelContext.Time < 0)
            {
                    return;
            }
            
            this.nextIdleTime = -1f;
            val_8 = null;
            if(UnityEngine.Random.value > 0.6f)
            {
                    val_9 = null;
                val_10 = 1152921505108873224;
            }
            else
            {
                    val_11 = null;
                val_10 = 1152921505108873228;
            }
            
            this.birdAnimator.Play(stateNameHash:  val_10, layer:  0, normalizedTime:  0f);
        }
        public BirdNestCrack()
        {
        
        }
        private static BirdNestCrack()
        {
            Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Crack.BirdNestCrack.CrackDefault = UnityEngine.Animator.StringToHash(name:  "Base Layer.crack_default");
            Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Crack.BirdNestCrack.CrackAppear = UnityEngine.Animator.StringToHash(name:  "Base Layer.crack_appear");
            Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Crack.BirdNestCrack.CrackIdle1 = UnityEngine.Animator.StringToHash(name:  "Base Layer.crack_idle_1");
            Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Crack.BirdNestCrack.CrackIdle2 = UnityEngine.Animator.StringToHash(name:  "Base Layer.crack_idle_2");
        }
    
    }

}
