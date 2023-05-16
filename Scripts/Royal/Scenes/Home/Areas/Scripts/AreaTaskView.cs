using UnityEngine;

namespace Royal.Scenes.Home.Areas.Scripts
{
    public class AreaTaskView : MonoBehaviour
    {
        // Fields
        public int id;
        internal bool isReplay;
        internal bool shouldPlayAudio;
        private Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets areaTaskAssets;
        private DG.Tweening.Sequence highlightSequence;
        private UnityEngine.Material defaultMaterial;
        private string replacedMaterialName;
        
        // Properties
        public string AreaTaskAssetPath { get; }
        protected Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets AreaTaskAssets { get; set; }
        
        // Methods
        public string get_AreaTaskAssetPath()
        {
            return this.GetType() + "Assets";
        }
        protected Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets get_AreaTaskAssets()
        {
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_4;
            if(this.areaTaskAssets == 0)
            {
                    this.areaTaskAssets = UnityEngine.Resources.Load<Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets>(path:  this.AreaTaskAssetPath);
                return val_4;
            }
            
            val_4 = this.areaTaskAssets;
            return val_4;
        }
        private void set_AreaTaskAssets(Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets value)
        {
            this.areaTaskAssets = value;
        }
        protected virtual void Awake()
        {
        
        }
        public virtual void PrepareAnimation()
        {
            this.PlayFinalParticles();
        }
        public virtual void PrepareReplay()
        {
        
        }
        public UnityEngine.ResourceRequest GetAreaTaskAssetResourceRequest()
        {
            return UnityEngine.Resources.LoadAsync<Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets>(path:  this.AreaTaskAssetPath);
        }
        public virtual DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            this.gameObject.SetActive(value:  false);
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.2f);
            UnityEngine.Transform val_4 = this.transform;
            UnityEngine.Vector3 val_5 = val_4.localPosition;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  0.2f);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            val_4.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            this.gameObject.SetActive(value:  true);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.5f, snapping:  false), ease:  30);
            this.PlayDefaultAnimationSound();
            return val_1;
        }
        public virtual void EndAnimation()
        {
        
        }
        public virtual void Show()
        {
            this.gameObject.SetActive(value:  true);
        }
        public virtual void Hide()
        {
            this.gameObject.SetActive(value:  false);
        }
        public virtual void HideAll()
        {
            this.gameObject.SetActive(value:  false);
        }
        public void ReleaseTaskAssets()
        {
            this.areaTaskAssets = 0;
        }
        protected virtual void OnDestroy()
        {
            this.areaTaskAssets = 0;
        }
        public void ReleaseTaskAssetsDelayed(float delay)
        {
            this.Invoke(methodName:  "ReleaseTaskAssets", time:  delay);
        }
        private void PlayFinalParticles()
        {
            if(this.isReplay != false)
            {
                    return;
            }
            
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_1 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Scripts.AreaTaskFinalParticles val_2 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Areas.Scripts.AreaTaskFinalParticles>(original:  val_1.finalParticles);
            UnityEngine.Transform val_3 = val_2.transform;
            UnityEngine.Transform val_4 = this.transform;
            UnityEngine.Vector3 val_5 = val_4.position;
            val_3.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Vector3 val_6 = val_4.lossyScale;
            val_3.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            val_2.PlayAndDestroy();
            this.Invoke(methodName:  "PlayParticleSound", time:  val_2.particleStartTime);
        }
        public void PlayFinalParticlesOnReplayEnd()
        {
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_1 = this.AreaTaskAssets;
            Royal.Scenes.Home.Areas.Scripts.AreaTaskFinalParticles val_3 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Areas.Scripts.AreaTaskFinalParticles>(original:  val_1.finalParticles, parent:  this.transform, worldPositionStays:  true);
            UnityEngine.Transform val_4 = val_3.transform;
            UnityEngine.Transform val_5 = this.transform;
            UnityEngine.Vector3 val_6 = val_5.position;
            val_4.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Vector3 val_7 = val_5.localScale;
            val_4.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            val_3.Play(shouldDestroy:  true);
        }
        public virtual float GetAnimationDelay()
        {
            return 0.3f;
        }
        protected void PlayDefaultAnimationSound()
        {
            UnityEngine.AudioClip val_2 = this.GetComponentInParent<Royal.Scenes.Home.Areas.Scripts.AreaView>().GetTaskClip(areaNo:  val_1.<AreaId>k__BackingField, taskId:  this.id);
            if(this.isReplay != false)
            {
                    if(this.shouldPlayAudio == false)
            {
                    return;
            }
            
                if(val_2 == 0)
            {
                    return;
            }
            
                val_1.areaViewBackgroundSounds.PlayReplaySound(clip:  val_2);
                return;
            }
            
            if(val_2 == 0)
            {
                    return;
            }
            
            val_1.areaViewBackgroundSounds.PlayOneShotSound(clip:  val_2);
        }
        private UnityEngine.AudioClip GetTaskClip(int areaNo, int taskId)
        {
            if((Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper.IsAreaBundled(areaId:  areaNo)) == false)
            {
                    return UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "Sfx/"("Sfx/") + Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper.GetTaskSfxName(areaNo:  areaNo, taskId:  taskId)(Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper.GetTaskSfxName(areaNo:  areaNo, taskId:  taskId)));
            }
            
            return Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper>(id:  8).LoadTaskSfx(areaNo:  areaNo, taskId:  taskId);
        }
        private void PlayParticleSound()
        {
            Royal.Scenes.Home.Areas.Scripts.AreaView val_2 = this.GetComponentInParent<Royal.Scenes.Home.Areas.Scripts.AreaView>();
            val_2.areaViewBackgroundSounds.PlayOneShotSound(clipName:  this.GetParticleSoundName());
        }
        public string GetParticleSoundName()
        {
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_1 = this.AreaTaskAssets;
            FinalParticleSoundType val_3 = val_1.finalParticleSoundType;
            val_3 = (val_3 == 1) ? "area_particle1" : ((val_3 == 2) ? "area_particle2" : "area_particle3");
            return (string)val_3;
        }
        public void PlayIdleSound()
        {
            if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16).IsMusicActive()) != false)
            {
                    return;
            }
            
            Royal.Scenes.Home.Areas.Scripts.AreaView val_3 = this.GetComponentInParent<Royal.Scenes.Home.Areas.Scripts.AreaView>();
            val_3.areaViewBackgroundSounds.PlayStoppableSound(clipName:  this, loop:  true, volume:  null);
        }
        protected virtual string GetIdleSoundName()
        {
            return 0;
        }
        protected virtual float GetIdleSoundVolume()
        {
            return 1f;
        }
        protected virtual void PrepareReplayFinalParticles(Royal.Scenes.Home.Areas.Scripts.AreaTaskFinalParticles particles)
        {
        
        }
        public float GetParticleStartTime()
        {
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_1 = this.AreaTaskAssets;
            return (float)val_1.finalParticles.particleStartTime;
        }
        public float GetUiAppearTime()
        {
            Royal.Scenes.Home.Areas.Scripts.AreaTaskAssets val_1 = this.AreaTaskAssets;
            return (float)val_1.finalParticles.uiAppearTime;
        }
        public virtual bool ShouldPauseIdleWhileBuildingAnotherTask()
        {
            return false;
        }
        public virtual void StopIdleAnimationsGently()
        {
        
        }
        public virtual void ResumeIdleAnimationsGently()
        {
        
        }
        public AreaTaskView()
        {
        
        }
    
    }

}
