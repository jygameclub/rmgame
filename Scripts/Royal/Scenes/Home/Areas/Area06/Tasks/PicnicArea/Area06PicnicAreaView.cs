using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area06.Tasks.PicnicArea
{
    public class Area06PicnicAreaView : AreaTaskView
    {
        // Fields
        public UnityEngine.Animator woodAnimator;
        public UnityEngine.Animator bushAnimator;
        public UnityEngine.Animator bush2Animator;
        public UnityEngine.SpriteRenderer[] insideMaskSprites;
        public UnityEngine.SpriteMask[] insideMasks;
        public UnityEngine.ParticleSystem[] particles;
        
        // Methods
        protected override void Awake()
        {
            this.DisableAnimatorsAndParticles();
        }
        public override void PrepareAnimation()
        {
            this.PlayFinalParticles();
            this.CreateAllParticles();
            this.DisableObjects();
            this.EnableMasks(enable:  true);
        }
        private void CreateAllParticles()
        {
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_1 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area06.Tasks.PicnicArea.Area06PicnicAreaView.CreateParticles(prefab:  val_1.particles[0], parent:  this.bushAnimator.transform);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_3 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area06.Tasks.PicnicArea.Area06PicnicAreaView.CreateParticles(prefab:  val_3.particles[1], parent:  this.bushAnimator.transform);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_5 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area06.Tasks.PicnicArea.Area06PicnicAreaView.CreateParticles(prefab:  val_5.particles[2], parent:  this.bushAnimator.transform);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_7 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area06.Tasks.PicnicArea.Area06PicnicAreaView.CreateParticles(prefab:  val_7.particles[0], parent:  this.bush2Animator.transform);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_9 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area06.Tasks.PicnicArea.Area06PicnicAreaView.CreateParticles(prefab:  val_9.particles[1], parent:  this.bush2Animator.transform);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_11 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area06.Tasks.PicnicArea.Area06PicnicAreaView.CreateParticles(prefab:  val_11.particles[3], parent:  this.woodAnimator.transform);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_13 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area06.Tasks.PicnicArea.Area06PicnicAreaView.CreateParticles(prefab:  val_13.particles[4], parent:  this.woodAnimator.transform);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_15 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Area06.Tasks.PicnicArea.Area06PicnicAreaView.CreateParticles(prefab:  val_15.particles[5], parent:  this.transform);
        }
        private static void CreateParticles(UnityEngine.Object prefab, UnityEngine.Transform parent)
        {
            UnityEngine.Object val_1 = UnityEngine.Object.Instantiate(original:  prefab, parent:  parent);
            val_1.name = val_1.name.Replace(oldValue:  "(Clone)", newValue:  System.String.alignConst);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            this.PlayDefaultAnimationSound();
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area06.Tasks.PicnicArea.Area06PicnicAreaView::<PlayAnimation>b__10_0()));
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.5f);
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area06.Tasks.PicnicArea.Area06PicnicAreaView::<PlayAnimation>b__10_1()));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.1f);
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area06.Tasks.PicnicArea.Area06PicnicAreaView::<PlayAnimation>b__10_2()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.DisableAnimatorsAndParticles();
        }
        private void DisableObjects()
        {
            this.woodAnimator.gameObject.SetActive(value:  false);
            this.bushAnimator.gameObject.SetActive(value:  false);
            this.bush2Animator.gameObject.SetActive(value:  false);
        }
        private static void PlayAnimator(UnityEngine.Animator animator)
        {
            animator.gameObject.SetActive(value:  true);
            animator.enabled = true;
            animator.Play(stateNameHash:  0, layer:  0, normalizedTime:  0f);
        }
        private void EnableMasks(bool enable)
        {
            var val_4;
            var val_5 = 0;
            label_4:
            if(val_5 >= this.insideMaskSprites.Length)
            {
                goto label_1;
            }
            
            this.insideMaskSprites[val_5].maskInteraction = enable;
            val_5 = val_5 + 1;
            if(this.insideMaskSprites != null)
            {
                goto label_4;
            }
            
            label_1:
            val_4 = 0;
            do
            {
                if(val_4 >= this.insideMasks.Length)
            {
                    return;
            }
            
                this.insideMasks[val_4].gameObject.SetActive(value:  enable);
                val_4 = val_4 + 1;
            }
            while(this.insideMasks != null);
            
            throw new NullReferenceException();
        }
        private void RemoveAllParticles()
        {
            if(val_1.Length < 1)
            {
                    return;
            }
            
            var val_4 = 0;
            do
            {
                UnityEngine.Object.Destroy(obj:  this.GetComponentsInChildren<UnityEngine.ParticleSystem>(includeInactive:  true)[val_4].gameObject);
                val_4 = val_4 + 1;
            }
            while(val_4 < val_1.Length);
        
        }
        private void DisableAnimatorsAndParticles()
        {
            this.EnableMasks(enable:  false);
            this.Invoke(methodName:  "RemoveAllParticles", time:  1f);
            this.woodAnimator.enabled = false;
            this.bushAnimator.enabled = false;
            this.bush2Animator.enabled = false;
        }
        public Area06PicnicAreaView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <PlayAnimation>b__10_0()
        {
            Royal.Scenes.Home.Areas.Area06.Tasks.PicnicArea.Area06PicnicAreaView.PlayAnimator(animator:  this.woodAnimator);
        }
        private void <PlayAnimation>b__10_1()
        {
            Royal.Scenes.Home.Areas.Area06.Tasks.PicnicArea.Area06PicnicAreaView.PlayAnimator(animator:  this.bush2Animator);
        }
        private void <PlayAnimation>b__10_2()
        {
            Royal.Scenes.Home.Areas.Area06.Tasks.PicnicArea.Area06PicnicAreaView.PlayAnimator(animator:  this.bushAnimator);
        }
    
    }

}
