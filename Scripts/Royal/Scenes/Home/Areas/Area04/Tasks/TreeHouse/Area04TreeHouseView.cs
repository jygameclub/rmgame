using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area04.Tasks.TreeHouse
{
    public class Area04TreeHouseView : AreaTaskView
    {
        // Fields
        public Spine.Unity.AnimationReferenceAsset appearAnimation;
        public Spine.Unity.AnimationReferenceAsset flyAnimation;
        public Spine.Unity.SkeletonAnimation flagAnimation;
        private UnityEngine.Animator treeHouseAnimator;
        private UnityEngine.ParticleSystem treeHouseRevealParticles;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
            this.treeHouseAnimator = val_1;
            val_1.enabled = false;
            this.flagAnimation.state.SetAnimation(trackIndex:  1, animation:  Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  this.flyAnimation), loop:  true) = 0;
            this.flagAnimation.state.Update(delta:  0.05f);
            bool val_5 = this.flagAnimation.state.Apply(skeleton:  this.flagAnimation.Skeleton);
        }
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.treeHouseAnimator.gameObject.SetActive(value:  false);
            this.flagAnimation.gameObject.SetActive(value:  false);
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_3 = this.AreaTaskAssets;
            this.treeHouseRevealParticles = UnityEngine.Object.Instantiate<UnityEngine.ParticleSystem>(original:  val_3.particles[0], parent:  this.transform);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area04.Tasks.TreeHouse.Area04TreeHouseView::<PlayAnimation>b__7_0()));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.5f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  1.2f);
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area04.Tasks.TreeHouse.Area04TreeHouseView::<PlayAnimation>b__7_1()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.EndAnimation();
            this.treeHouseAnimator.enabled = false;
        }
        private void RevealFlag(Spine.Unity.SkeletonAnimation flag)
        {
            flag.gameObject.SetActive(value:  true);
            flag.state.SetAnimation(trackIndex:  1, animation:  Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  this.appearAnimation), loop:  false) = 0;
            flag.Update(deltaTime:  UnityEngine.Time.deltaTime);
            Spine.TrackEntry val_6 = flag.state.AddAnimation(trackIndex:  1, animation:  Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  this.flyAnimation), loop:  true, delay:  0f);
        }
        public Area04TreeHouseView()
        {
        
        }
        private void <PlayAnimation>b__7_0()
        {
            this.treeHouseAnimator.gameObject.SetActive(value:  true);
            this.treeHouseAnimator.enabled = true;
            this.treeHouseAnimator.Play(stateName:  "Area04TreeHouseRevealAnimation", layer:  0, normalizedTime:  0f);
            this.treeHouseRevealParticles.Play();
            Royal.Scenes.Home.Areas.Area04.Tasks.Tree.Area04TreeView val_4 = this.treeHouseAnimator.transform.parent.GetComponentInChildren<Royal.Scenes.Home.Areas.Area04.Tasks.Tree.Area04TreeView>();
            if(val_4 == 0)
            {
                    return;
            }
            
            val_4.PlayEffectAnimation();
        }
        private void <PlayAnimation>b__7_1()
        {
            this.RevealFlag(flag:  this.flagAnimation);
        }
    
    }

}
