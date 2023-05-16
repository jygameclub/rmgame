using UnityEngine;

namespace Royal.Scenes.Home.Areas.Scripts
{
    public class AreaTaskViewAnimation : AreaTaskView
    {
        // Fields
        protected UnityEngine.Animator animator;
        protected bool pauseIdleGently;
        protected Royal.Infrastructure.UiComponents.Dialog.DialogManager dialogManager;
        
        // Methods
        protected override void Awake()
        {
            UnityEngine.Animator val_1 = this.GetComponent<UnityEngine.Animator>();
            this.animator = val_1;
            val_1.enabled = false;
            this.dialogManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Dialog.DialogManager>(id:  13);
        }
        protected virtual bool HasIdle()
        {
            return false;
        }
        protected virtual int GetCreationStateHash()
        {
            return 0;
        }
        public override void PrepareAnimation()
        {
            this.PlayFinalParticles();
            this.animator.gameObject.SetActive(value:  false);
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskViewAnimation::<PlayAnimation>b__7_0()));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  public System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayIdleSound()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.animator.enabled = false;
        }
        private void Update()
        {
            if((this & 1) == 0)
            {
                    return;
            }
            
            if(this.pauseIdleGently == false)
            {
                goto label_1;
            }
            
            if((this.animator.speed <= 0f) || ((this & 1) == 0))
            {
                goto label_4;
            }
            
            goto label_6;
            label_4:
            if(this.pauseIdleGently == true)
            {
                    return;
            }
            
            label_1:
            float val_2 = this.animator.speed;
            if((2107613788 & 1) == 0)
            {
                    return;
            }
            
            label_6:
            this.animator.speed = 1f;
        }
        public override void StopIdleAnimationsGently()
        {
            this.pauseIdleGently = true;
        }
        public override void ResumeIdleAnimationsGently()
        {
            var val_4;
            var val_5;
            if(this.dialogManager.hasActiveDialog != false)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            if((Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField) != 0)
            {
                    val_5 = null;
                val_5 = null;
                if((Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.AtSection(type:  0)) == false)
            {
                    return;
            }
            
            }
            
            if(this.isActiveAndEnabled == false)
            {
                    return;
            }
            
            this.pauseIdleGently = false;
        }
        protected virtual bool CanPauseIdle()
        {
            return false;
        }
        public AreaTaskViewAnimation()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <PlayAnimation>b__7_0()
        {
            this.PlayDefaultAnimationSound();
            this.animator.gameObject.SetActive(value:  true);
            this.animator.enabled = true;
            this.animator.speed = 1f;
            this.animator.Play(stateNameHash:  2108268752, layer:  0, normalizedTime:  0f);
            if(val_2.Length < 1)
            {
                    return;
            }
            
            var val_4 = 0;
            do
            {
                this.GetComponentsInChildren<Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation>()[val_4].PlayDistortion();
                val_4 = val_4 + 1;
            }
            while(val_4 < val_2.Length);
        
        }
    
    }

}
