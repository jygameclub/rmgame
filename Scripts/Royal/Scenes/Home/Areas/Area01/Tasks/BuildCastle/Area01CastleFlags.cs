using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area01.Tasks.BuildCastle
{
    public class Area01CastleFlags : MonoBehaviour
    {
        // Fields
        public Spine.Unity.AnimationReferenceAsset appearAnimation;
        public Spine.Unity.AnimationReferenceAsset flyAnimation1;
        public Spine.Unity.AnimationReferenceAsset flyAnimation2;
        public UnityEngine.Material flagMaterial;
        public Spine.Unity.SkeletonAnimation[] flagAnimations;
        
        // Methods
        public void Awake()
        {
            this.ResetMaterial();
            var val_9 = 0;
            do
            {
                if(val_9 >= this.flagAnimations.Length)
            {
                    return;
            }
            
                var val_2 = (UnityEngine.Random.value > 0.5f) ? 40 : 32;
                this.flagAnimations[0x0][0].state.SetAnimation(trackIndex:  1, animation:  Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  null), loop:  true) = 0;
                float val_8 = 0f;
                val_8 = val_8 * 0.1f;
                val_8 = val_8 + 0.05f;
                this.flagAnimations[0x0][0].state.Update(delta:  val_8);
                bool val_6 = this.flagAnimations[0x0][0].state.Apply(skeleton:  this.flagAnimations[val_9].Skeleton);
                val_9 = val_9 + 1;
            }
            while(this.flagAnimations != null);
            
            throw new NullReferenceException();
        }
        public void DisableFlags()
        {
            var val_3 = 0;
            do
            {
                if(val_3 >= this.flagAnimations.Length)
            {
                    return;
            }
            
                this.flagAnimations[val_3].gameObject.SetActive(value:  false);
                val_3 = val_3 + 1;
            }
            while(this.flagAnimations != null);
            
            throw new NullReferenceException();
        }
        public void PlayRevealAnimations()
        {
            var val_5 = 0;
            do
            {
                if(val_5 >= this.flagAnimations.Length)
            {
                    return;
            }
            
                .<>4__this = this;
                .flag = this.flagAnimations[val_5];
                float val_6 = 0f;
                val_6 = val_6 * 0.07f;
                val_6 = val_6 + 0.05f;
                DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  DG.Tweening.DOTween.Sequence(), atPosition:  val_6, callback:  new DG.Tweening.TweenCallback(object:  new Area01CastleFlags.<>c__DisplayClass7_0(), method:  System.Void Area01CastleFlags.<>c__DisplayClass7_0::<PlayRevealAnimations>b__0()));
                val_5 = val_5 + 1;
            }
            while(this.flagAnimations != null);
            
            throw new NullReferenceException();
        }
        private void RevealFlag(Spine.Unity.SkeletonAnimation flag)
        {
            flag.gameObject.SetActive(value:  true);
            flag.state.SetAnimation(trackIndex:  1, animation:  Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  this.appearAnimation), loop:  false) = 0;
            flag.Update(deltaTime:  UnityEngine.Time.deltaTime);
            var val_6 = (UnityEngine.Random.value > 0.5f) ? 40 : 32;
            Spine.TrackEntry val_8 = flag.state.AddAnimation(trackIndex:  1, animation:  Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  null), loop:  true, delay:  0f);
        }
        private Spine.Unity.AnimationReferenceAsset GetRandomFlyAnimation()
        {
            var val_2 = (UnityEngine.Random.value > 0.5f) ? 40 : 32;
            return (Spine.Unity.AnimationReferenceAsset)null;
        }
        public void DarkenMaterial()
        {
            this.flagMaterial.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            var val_3 = 0;
            do
            {
                if(val_3 >= this.flagAnimations.Length)
            {
                    return;
            }
            
                this.flagAnimations[val_3].GetComponent<UnityEngine.Renderer>().material = this.flagMaterial;
                val_3 = val_3 + 1;
            }
            while(this.flagAnimations != null);
            
            throw new NullReferenceException();
        }
        public void ResetMaterial()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.flagMaterial.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
            var val_4 = 0;
            do
            {
                if(val_4 >= this.flagAnimations.Length)
            {
                    return;
            }
            
                this.flagAnimations[val_4].GetComponent<UnityEngine.Renderer>().material = this.flagMaterial;
                val_4 = val_4 + 1;
            }
            while(this.flagAnimations != null);
            
            throw new NullReferenceException();
        }
        public Area01CastleFlags()
        {
        
        }
    
    }

}
