using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area07.Tasks.Aquarium
{
    public class Area07AquariumView : AreaTaskView
    {
        // Fields
        public UnityEngine.GameObject particleParent;
        public UnityEngine.ParticleSystem idleWaterParticles;
        private UnityEngine.Animator aquariumAnimator;
        private UnityEngine.ParticleSystem waterParticles;
        
        // Methods
        protected override void Awake()
        {
            UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
            this.aquariumAnimator = val_1;
            val_1.enabled = true;
        }
        public override void PrepareAnimation()
        {
            this.PlayFinalParticles();
            this.aquariumAnimator.gameObject.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area07.Tasks.Aquarium.Area07AquariumView::<PlayAnimation>b__6_0()));
            return val_1;
        }
        public override void EndAnimation()
        {
            UnityEngine.Object.Destroy(obj:  this.waterParticles.gameObject);
        }
        public void PlayIdleWaterParticles()
        {
            if(this.idleWaterParticles != null)
            {
                    this.idleWaterParticles.Play();
                return;
            }
            
            throw new NullReferenceException();
        }
        public Area07AquariumView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <PlayAnimation>b__6_0()
        {
            this.PlayDefaultAnimationSound();
            this.aquariumAnimator.gameObject.SetActive(value:  true);
            this.aquariumAnimator.enabled = true;
            this.aquariumAnimator.Play(stateName:  "Area07AquariumRevealAnimation", layer:  0, normalizedTime:  0f);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_2 = this.AreaTaskAssets;
            UnityEngine.ParticleSystem val_4 = UnityEngine.Object.Instantiate<UnityEngine.ParticleSystem>(original:  val_2.particles[0], parent:  this.particleParent.transform);
            this.waterParticles = val_4;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            val_4.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            this.waterParticles.name = "Area07AquariumWaterParticles";
            this.waterParticles.Play();
        }
    
    }

}
