using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect
{
    public class LifeItemAnimation : MonoBehaviour
    {
        // Fields
        private const float Scale1 = 1.188;
        private const float Scale2 = 0.891;
        private const float Scale3 = 1.0395;
        private const float Scale4 = 0.99;
        private const float Scale5 = 0.6;
        private static readonly UnityEngine.Vector3 TargetShadowPosition;
        public UnityEngine.Transform shadow;
        public UnityEngine.ParticleSystem hitParticles;
        public UnityEngine.ParticleSystem appearParticles;
        public TMPro.TextMeshPro lifeCount;
        public UnityEngine.GameObject unlimitedSign;
        public bool useDefaultPosition;
        private UnityEngine.Transform hitTransform;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private int unlimitedMinutes;
        
        // Methods
        private void Awake()
        {
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
        }
        public void Play(int minutes)
        {
            var val_12;
            var val_13;
            this.unlimitedMinutes = minutes;
            val_12 = null;
            val_12 = null;
            this.shadow.transform.localPosition = new UnityEngine.Vector3() {x = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeItemAnimation.TargetShadowPosition, y = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeItemAnimation.TargetShadowPosition.__il2cppRuntimeField_4, z = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeItemAnimation.TargetShadowPosition.__il2cppRuntimeField_8};
            val_13 = null;
            val_13 = null;
            this.hitTransform = Royal.Scenes.Home.Ui.__il2cppRuntimeField_38 + 64.transform;
            if(this.useDefaultPosition != true)
            {
                    UnityEngine.Vector2 val_3 = UnityEngine.Vector2.down;
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Multiply(d:  3.65f, a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
                this.PrepareItemToAnimation(offset:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            }
            
            this.unlimitedSign.SetActive(value:  (this.unlimitedMinutes > 0) ? 1 : 0);
            this.lifeCount.gameObject.SetActive(value:  (this.unlimitedMinutes < 1) ? 1 : 0);
            this.lifeCount.text = Royal.Player.Context.Units.LifeHelper.MaxPossibleLivesToHave.ToString();
            if(this.unlimitedMinutes >= 1)
            {
                    this.audioManager.PlaySound(type:  22, offset:  0.04f);
            }
            
            UnityEngine.Coroutine val_11 = this.StartCoroutine(routine:  this.PlayAnimation());
        }
        private System.Collections.IEnumerator PlayAnimation()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new LifeItemAnimation.<PlayAnimation>d__17();
        }
        private void PrepareItemToAnimation(UnityEngine.Vector2 offset)
        {
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = offset.x, y = offset.y});
            val_1.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            val_1.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        private void PlayItemHitAnimation()
        {
            var val_5;
            this.audioManager.PlaySound(type:  23, offset:  0.04f);
            UnityEngine.Vector3 val_3 = this.hitTransform.transform.position;
            this.hitParticles.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.hitParticles.Play();
            val_5 = null;
            val_5 = null;
            Royal.Scenes.Home.Ui.__il2cppRuntimeField_38.PlayHitAnimation(animationData:  new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData() {lifeCount = this.unlimitedMinutes << 32, unlimitedMinutes = this.unlimitedMinutes << 32});
        }
        public LifeItemAnimation()
        {
        
        }
        private static LifeItemAnimation()
        {
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeItemAnimation.TargetShadowPosition = 0;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeItemAnimation.TargetShadowPosition.__il2cppRuntimeField_8 = 0;
        }
    
    }

}
