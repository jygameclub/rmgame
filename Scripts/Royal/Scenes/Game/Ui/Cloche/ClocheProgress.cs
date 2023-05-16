using UnityEngine;

namespace Royal.Scenes.Game.Ui.Cloche
{
    public class ClocheProgress : MonoBehaviour
    {
        // Fields
        private const float RightWidth = 0.2;
        public float totalLeftBarSize;
        public UnityEngine.SpriteRenderer clocheSprite;
        public UnityEngine.ParticleSystem clocheParticles;
        public TMPro.TextMeshPro progressValue;
        public UnityEngine.SpriteRenderer leftProgressBar;
        public UnityEngine.SpriteRenderer rightProgressBar;
        protected int currentCloche;
        protected Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        
        // Methods
        private void Awake()
        {
            if(IsLoad != true)
            {
                    this.currentCloche = Royal.Player.Context.Data.Session.__il2cppRuntimeField_60 + 20;
            }
            else
            {
                    this.currentCloche = GetCloche();
                this.clocheParticles.gameObject.SetActive(value:  (this.currentCloche != 0) ? 1 : 0);
            }
            
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.UpdateProgressValue();
            this.UpdateBarSize(ratio:  null);
            this.UpdateCloche();
        }
        public virtual void PlayAnimation()
        {
        
        }
        protected void UpdateProgressValue()
        {
            this.progressValue.text = this.currentCloche + "/"("/") + 3;
        }
        protected void UpdateCloche()
        {
            this.clocheSprite.sprite = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  "cloche_" + this.currentCloche);
        }
        protected virtual void PrepareClocheSpritePosition()
        {
            UnityEngine.Transform val_1 = this.clocheSprite.transform;
            if(this.currentCloche > 3)
            {
                    return;
            }
            
            var val_19 = 36596632 + (this.currentCloche) << 2;
            val_19 = val_19 + 36596632;
            goto (36596632 + (this.currentCloche) << 2 + 36596632);
        }
        protected virtual float GetRatioForCloche(int cloche)
        {
            if(cloche > 2)
            {
                    return 1f;
            }
            
            return (float)36596820 + (cloche) << 2;
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
        protected System.Collections.IEnumerator ProgressBarCoroutine(float startProgress, float endProgress, float duration, System.Action onComplete)
        {
            .<>1__state = 0;
            .duration = duration;
            .startProgress = startProgress;
            .endProgress = endProgress;
            .<>4__this = this;
            .onComplete = onComplete;
            return (System.Collections.IEnumerator)new ClocheProgress.<ProgressBarCoroutine>d__18();
        }
        public ClocheProgress()
        {
        
        }
    
    }

}
