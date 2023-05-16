using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections
{
    public class SectionAnimation : MonoBehaviour
    {
        // Fields
        public const float Duration = 0.8;
        public const Royal.Infrastructure.Utils.Animation.ManualEasingType Easing = 15;
        public Royal.Scenes.Home.Ui.Sections.SectionManager sectionManager;
        private Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        private UnityEngine.Vector3 targetPosition;
        private UnityEngine.Vector3 startPosition;
        private float progress;
        private Royal.Scenes.Home.Ui.Sections.Section targetSection;
        private Royal.Infrastructure.Utils.Animation.ManualEasing.Easer easer;
        
        // Methods
        private void Awake()
        {
            this.easer = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  15);
            this.Init();
        }
        public void Init()
        {
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.sectionManager.add_OnSectionChange(value:  new System.Action<Royal.Scenes.Home.Ui.Sections.Section>(object:  this, method:  public System.Void Royal.Scenes.Home.Ui.Sections.SectionAnimation::FocusToSection(Royal.Scenes.Home.Ui.Sections.Section section)));
        }
        public void Enter()
        {
            this.progress = 0f;
            UnityEngine.Vector3 val_1 = this.cameraManager.GetPosition();
            this.startPosition = val_1;
            mem[1152921518945600632] = val_1.y;
            mem[1152921518945600636] = val_1.z;
            UnityEngine.Vector3 val_3 = this.targetSection.transform.localPosition;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  10f);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            this.targetPosition = val_6;
            mem[1152921518945600620] = val_6.y;
            mem[1152921518945600624] = val_6.z;
        }
        public void ManualUpdate()
        {
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.progress + val_1;
            float val_2 = UnityEngine.Mathf.Clamp(value:  val_1, min:  0f, max:  0.8f);
            this.progress = val_2;
            val_2 = val_2 / 0.8f;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.startPosition, y = V13.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = this.targetPosition, y = V10.16B, z = 0.8f}, t:  this.easer.Invoke(t:  val_2));
            this.cameraManager.SetPosition(position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        }
        public void FocusToSection(Royal.Scenes.Home.Ui.Sections.Section section)
        {
            if(this.targetSection == section)
            {
                    return;
            }
            
            this.targetSection = section;
            this.progress = 0f;
            UnityEngine.Vector3 val_2 = this.cameraManager.GetPosition();
            this.startPosition = val_2;
            mem[1152921518945869688] = val_2.y;
            mem[1152921518945869692] = val_2.z;
            UnityEngine.Vector3 val_4 = section.transform.localPosition;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  10f);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            this.targetPosition = val_7;
            mem[1152921518945869676] = val_7.y;
            mem[1152921518945869680] = val_7.z;
        }
        public SectionAnimation()
        {
        
        }
    
    }

}
