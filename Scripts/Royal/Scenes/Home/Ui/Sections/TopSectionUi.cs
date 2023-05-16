using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections
{
    public class TopSectionUi : UiPanel
    {
        // Fields
        public const float Padding = 0.2;
        public UnityEngine.SpriteRenderer background;
        public float yOffset;
        
        // Methods
        public virtual void Init(float cameraWidth)
        {
            if(this.background != 0)
            {
                    UnityEngine.Vector2 val_2 = this.background.size;
                float val_4 = 0.4f;
                val_4 = cameraWidth + val_4;
                UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_4, y:  val_2.y);
                this.background.size = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            }
            
            this.SetPosition();
        }
        public UnityEngine.Vector3 GetTargetPosition()
        {
            UnityEngine.Vector3 val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1).GetSafeTopCenterOfCamera();
            val_2.y = val_2.y - this.yOffset;
            return new UnityEngine.Vector3() {x = 0f, y = val_2.y, z = 0f};
        }
        private void SetPosition()
        {
            UnityEngine.Vector3 val_2 = this.GetTargetPosition();
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        public float BottomYPositionOfTopUi()
        {
            UnityEngine.Vector3 val_2 = this.transform.position;
            UnityEngine.Bounds val_3 = this.background.bounds;
            float val_6 = val_2.y - val_2.y;
            val_6 = val_6 + 0.5f;
            return (float)val_6;
        }
        public TopSectionUi()
        {
            this.yOffset = 0.8f;
        }
    
    }

}
