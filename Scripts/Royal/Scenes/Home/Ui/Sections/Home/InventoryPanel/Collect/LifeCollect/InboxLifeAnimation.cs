using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect
{
    public class InboxLifeAnimation : MonoBehaviour
    {
        // Fields
        private const float Scale1 = 1.5;
        private static readonly UnityEngine.Vector3 TargetShadowPosition;
        public UnityEngine.Transform shadow;
        public UnityEngine.ParticleSystem hitParticles;
        public UnityEngine.ParticleSystem appearParticles;
        private UnityEngine.Transform hitTransform;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private System.Action onComplete;
        private System.Action onLifeDestroy;
        
        // Methods
        private void Awake()
        {
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
        }
        public void Play(UnityEngine.Vector3 startPosition, System.Action onComplete, System.Action onLifeDestroy)
        {
            var val_5;
            var val_6;
            this.onComplete = onComplete;
            this.onLifeDestroy = onLifeDestroy;
            val_5 = null;
            val_5 = null;
            this.shadow.transform.localPosition = new UnityEngine.Vector3() {x = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.InboxLifeAnimation.TargetShadowPosition, y = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.InboxLifeAnimation.TargetShadowPosition.__il2cppRuntimeField_4, z = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.InboxLifeAnimation.TargetShadowPosition.__il2cppRuntimeField_8};
            val_6 = null;
            val_6 = null;
            this.hitTransform = Royal.Scenes.Home.Ui.__il2cppRuntimeField_38 + 64.transform;
            this.PrepareItemToAnimation(offset:  new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z});
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.PlayAnimation());
        }
        private System.Collections.IEnumerator PlayAnimation()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new InboxLifeAnimation.<PlayAnimation>d__11();
        }
        private void PrepareItemToAnimation(UnityEngine.Vector3 offset)
        {
            UnityEngine.Transform val_1 = this.transform;
            val_1.position = new UnityEngine.Vector3() {x = offset.x, y = offset.y, z = offset.z};
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            val_1.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        private void PlayItemHitAnimation()
        {
            this.audioManager.PlaySound(type:  23, offset:  0.04f);
            UnityEngine.Vector3 val_3 = this.hitTransform.transform.position;
            this.hitParticles.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.hitParticles.Play();
        }
        public InboxLifeAnimation()
        {
        
        }
        private static InboxLifeAnimation()
        {
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.InboxLifeAnimation.TargetShadowPosition = 0;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.InboxLifeAnimation.TargetShadowPosition.__il2cppRuntimeField_8 = 0;
        }
    
    }

}
