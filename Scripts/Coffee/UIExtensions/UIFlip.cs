using UnityEngine;

namespace Coffee.UIExtensions
{
    public class UIFlip : BaseMeshEffect
    {
        // Fields
        private bool m_Horizontal;
        private bool m_Veritical;
        
        // Properties
        public bool horizontal { get; set; }
        public bool vertical { get; set; }
        
        // Methods
        public bool get_horizontal()
        {
            return (bool)this.m_Horizontal;
        }
        public void set_horizontal(bool value)
        {
            this.m_Horizontal = value;
            this.SetVerticesDirty();
        }
        public bool get_vertical()
        {
            return (bool)this.m_Veritical;
        }
        public void set_vertical(bool value)
        {
            this.m_Veritical = value;
            this.SetVerticesDirty();
        }
        public override void ModifyMesh(UnityEngine.UI.VertexHelper vh)
        {
            var val_4;
            var val_5;
            this.Initialize();
            UnityEngine.Rect val_2 = this.rectTransform.rect;
            if(vh.currentVertCount < 1)
            {
                    return;
            }
            
            var val_9 = 0;
            do
            {
                vh.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()}, i:  0);
                var val_7 = val_4;
                var val_8 = val_5;
                val_7 = (this.m_Horizontal == false) ? (val_7) : (-val_7);
                val_8 = (this.m_Veritical == false) ? (val_8) : (-val_8);
                val_4 = 0;
                vh.SetUIVertex(vertex:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()}, i:  0);
                val_9 = val_9 + 1;
            }
            while(val_9 < vh.currentVertCount);
        
        }
        public UIFlip()
        {
        
        }
    
    }

}
