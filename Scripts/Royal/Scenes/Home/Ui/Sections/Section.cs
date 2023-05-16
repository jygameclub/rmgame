using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections
{
    public class Section : MonoBehaviour
    {
        // Fields
        public const float Padding = 0.2;
        public Royal.Scenes.Home.Ui.Sections.SectionType sectionType;
        public UnityEngine.SpriteRenderer background;
        public Royal.Scenes.Home.Ui.Sections.TopSectionUi topUi;
        public Royal.Scenes.Home.Ui.Sections.SectionBar sectionBar;
        public UnityEngine.Transform leftGradient;
        public UnityEngine.Transform rightGradient;
        private bool <IsActive>k__BackingField;
        
        // Properties
        private int SectionIndex { get; }
        public int ArrayIndex { get; }
        public bool IsActive { get; set; }
        
        // Methods
        private int get_SectionIndex()
        {
            return (int)this.sectionType;
        }
        public int get_ArrayIndex()
        {
            return (int)this.sectionType + 2;
        }
        public bool get_IsActive()
        {
            return (bool)this.<IsActive>k__BackingField;
        }
        private void set_IsActive(bool value)
        {
            this.<IsActive>k__BackingField = value;
        }
        public void Init(float cameraWidth, Royal.Scenes.Home.Ui.Sections.SectionType type)
        {
            float val_12;
            float val_13;
            float val_14;
            this.sectionType = type;
            UnityEngine.Vector2 val_1 = this.background.size;
            float val_12 = 0.4f;
            val_12 = cameraWidth + val_12;
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_12, y:  val_1.y);
            val_12 = val_2.x;
            val_13 = val_2.y;
            this.background.size = new UnityEngine.Vector2() {x = val_12, y = val_13};
            if(this.leftGradient != 0)
            {
                    UnityEngine.Vector3 val_4 = UnityEngine.Vector3.left;
                float val_13 = 0.5f;
                val_13 = cameraWidth * val_13;
                val_12 = val_13 + 0.2f;
                val_13 = val_4.x;
                val_14 = val_4.y;
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(d:  val_12, a:  new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_4.z});
                this.leftGradient.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            }
            
            if(this.rightGradient != 0)
            {
                    UnityEngine.Vector3 val_7 = UnityEngine.Vector3.right;
                float val_14 = 0.5f;
                val_14 = cameraWidth * val_14;
                val_12 = val_14 + 0.2f;
                val_13 = val_7.x;
                val_14 = val_7.y;
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(d:  val_12, a:  new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_7.z});
                this.rightGradient.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            }
            
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.right;
            float val_15 = 0.2f;
            val_15 = cameraWidth + val_15;
            val_15 = val_15 * (float)this.sectionType;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(d:  val_15, a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        }
        protected virtual void OnInitCompleted()
        {
        
        }
        public float BottomYPositionOfTopUi()
        {
            if(this.topUi != null)
            {
                    return this.topUi.BottomYPositionOfTopUi();
            }
            
            throw new NullReferenceException();
        }
        public float TopYPositionOfBottomUi()
        {
            UnityEngine.Vector3 val_1 = this.sectionBar.GetTargetPosition();
            float val_2 = 0.602541f;
            val_2 = val_1.y + val_2;
            return (float)val_2;
        }
        public virtual void OnActivate()
        {
            object[] val_1 = new object[1];
            val_1[0] = this.GetType();
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  "Show: {0}", values:  val_1);
            this.<IsActive>k__BackingField = true;
        }
        public virtual void OnDeactivate()
        {
            this.<IsActive>k__BackingField = false;
            object[] val_1 = new object[1];
            val_1[0] = this.GetType();
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  "Close: {0}", values:  val_1);
        }
        public Section()
        {
        
        }
    
    }

}
