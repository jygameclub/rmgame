using UnityEngine;

namespace Royal.Infrastructure.Utils.Text
{
    public class CurvedSingleText : TextProOnAnAnimationCurve
    {
        // Fields
        private UnityEngine.Vector3[] scaleArray;
        private bool isAnimating;
        private int <CharCount>k__BackingField;
        
        // Properties
        public int CharCount { get; set; }
        
        // Methods
        public int get_CharCount()
        {
            return (int)this.<CharCount>k__BackingField;
        }
        private void set_CharCount(int value)
        {
            this.<CharCount>k__BackingField = value;
        }
        public void Init()
        {
            TMPro.TextMeshPro val_1 = this.GetComponent<TMPro.TextMeshPro>();
            this.<CharCount>k__BackingField = TMPro.TextMeshPro.__il2cppRuntimeField_namespaze;
            this.scaleArray = new UnityEngine.Vector3[-874234096];
            this.isAnimating = true;
            this.ResetAllScales();
        }
        private void ResetAllScales()
        {
            if((this.<CharCount>k__BackingField) < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
                this.SetScaleForCharIndex(index:  0, scale:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
                val_2 = val_2 + 1;
            }
            while(val_2 < (this.<CharCount>k__BackingField));
        
        }
        public void SetScaleForCharIndex(int index, UnityEngine.Vector3 scale)
        {
            UnityEngine.Vector3[] val_1 = this.scaleArray;
            val_1 = val_1 + ((long)index * 12);
            val_1 = scale.x;
            val_1 = scale.y;
            val_1 = scale.z;
            this.ForceUpdate();
        }
        public void AnimationCompleted()
        {
            this.isAnimating = false;
        }
        private UnityEngine.Vector3 GetScaleForIndex(int index)
        {
            UnityEngine.Vector3[] val_2 = this.scaleArray;
            if((val_2 != null) && (this.scaleArray.Length > index))
            {
                    val_2 = val_2 + ((long)index * 12);
                return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            }
            
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        protected override bool ParametersHaveChanged()
        {
            if(this.isAnimating == false)
            {
                    return this.ParametersHaveChanged();
            }
            
            return true;
        }
        protected override UnityEngine.Vector3 GetCharScale(int index)
        {
            return this.GetScaleForIndex(index:  index);
        }
        public CurvedSingleText()
        {
            mem[1152921527445131216] = 1065353216;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
