using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections
{
    public class SectionElement : MonoBehaviour
    {
        // Fields
        public float duration;
        public Royal.Infrastructure.Utils.Animation.ManualEasingType easing;
        private UnityEngine.Vector3 <TargetPosition>k__BackingField;
        private UnityEngine.Vector3 <StartPosition>k__BackingField;
        private float progress;
        private Royal.Infrastructure.Utils.Animation.ManualEasing.Easer easer;
        
        // Properties
        public UnityEngine.Vector3 TargetPosition { get; set; }
        public UnityEngine.Vector3 StartPosition { get; set; }
        
        // Methods
        public UnityEngine.Vector3 get_TargetPosition()
        {
            return new UnityEngine.Vector3() {x = this.<TargetPosition>k__BackingField};
        }
        private void set_TargetPosition(UnityEngine.Vector3 value)
        {
            this.<TargetPosition>k__BackingField = value;
            mem[1152921518949370100] = value.y;
            mem[1152921518949370104] = value.z;
        }
        public UnityEngine.Vector3 get_StartPosition()
        {
            return new UnityEngine.Vector3() {x = this.<StartPosition>k__BackingField};
        }
        private void set_StartPosition(UnityEngine.Vector3 value)
        {
            this.<StartPosition>k__BackingField = value;
            mem[1152921518949594112] = value.y;
            mem[1152921518949594116] = value.z;
        }
        protected virtual void Awake()
        {
            this.easer = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  this.easing);
        }
        protected virtual void Update()
        {
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.progress + val_1;
            float val_2 = UnityEngine.Mathf.Clamp(value:  val_1, min:  0f, max:  this.duration);
            this.progress = val_2;
            val_2 = val_2 / this.duration;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<StartPosition>k__BackingField, y = V13.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = this.<TargetPosition>k__BackingField, y = this.progress, z = val_1}, t:  this.easer.Invoke(t:  val_2));
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        public virtual void ChooseTarget(UnityEngine.Vector3 target)
        {
            this.ResetProgress();
            this.<TargetPosition>k__BackingField = target;
            mem[1152921518949962868] = target.y;
            mem[1152921518949962872] = target.z;
        }
        public void ResetProgress()
        {
            this.progress = 0f;
            UnityEngine.Vector3 val_2 = this.transform.localPosition;
            this.<StartPosition>k__BackingField = val_2;
            mem[1152921518950078976] = val_2.y;
            mem[1152921518950078980] = val_2.z;
        }
        public SectionElement()
        {
            this.duration = 0.8f;
            this.easing = 15;
        }
    
    }

}
