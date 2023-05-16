using UnityEngine;

namespace Coffee.UIExtensions
{
    public class UIHsvModifier : UIEffectBase
    {
        // Fields
        public const string shaderName = "UI/Hidden/UI-Effect-HSV";
        private static readonly Coffee.UIExtensions.ParameterTexture _ptex;
        private UnityEngine.Color m_TargetColor;
        private float m_Range;
        private float m_Hue;
        private float m_Saturation;
        private float m_Value;
        
        // Properties
        public UnityEngine.Color targetColor { get; set; }
        public float range { get; set; }
        public float saturation { get; set; }
        public float value { get; set; }
        public float hue { get; set; }
        public override Coffee.UIExtensions.ParameterTexture ptex { get; }
        
        // Methods
        public UnityEngine.Color get_targetColor()
        {
            return new UnityEngine.Color() {r = this.m_TargetColor};
        }
        public void set_targetColor(UnityEngine.Color value)
        {
            float val_9;
            float val_10;
            val_9 = value.g;
            val_10 = value.a;
            if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = this.m_TargetColor, g = value.g, b = value.b, a = value.a}, rhs:  new UnityEngine.Color() {r = value.r, g = val_9, b = value.b, a = val_10})) == false)
            {
                    return;
            }
            
            this.m_TargetColor = value;
            mem[1152921528914538752] = val_9;
            mem[1152921528914538756] = value.b;
            mem[1152921528914538760] = val_10;
            val_10 = ???;
            val_9 = ???;
            goto typeof(Coffee.UIExtensions.UIHsvModifier).__il2cppRuntimeField_350;
        }
        public float get_range()
        {
            return (float)this.m_Range;
        }
        public void set_range(float value)
        {
            float val_1 = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  1f);
            if((UnityEngine.Mathf.Approximately(a:  this.m_Range, b:  val_1)) != false)
            {
                    return;
            }
            
            this.m_Range = val_1;
            goto typeof(Coffee.UIExtensions.UIHsvModifier).__il2cppRuntimeField_350;
        }
        public float get_saturation()
        {
            return (float)this.m_Saturation;
        }
        public void set_saturation(float value)
        {
            float val_1 = UnityEngine.Mathf.Clamp(value:  value, min:  -0.5f, max:  0.5f);
            if((UnityEngine.Mathf.Approximately(a:  this.m_Saturation, b:  val_1)) != false)
            {
                    return;
            }
            
            this.m_Saturation = val_1;
            goto typeof(Coffee.UIExtensions.UIHsvModifier).__il2cppRuntimeField_350;
        }
        public float get_value()
        {
            return (float)this.m_Value;
        }
        public void set_value(float value)
        {
            float val_1 = UnityEngine.Mathf.Clamp(value:  value, min:  -0.5f, max:  0.5f);
            if((UnityEngine.Mathf.Approximately(a:  this.m_Value, b:  val_1)) != false)
            {
                    return;
            }
            
            this.m_Value = val_1;
            goto typeof(Coffee.UIExtensions.UIHsvModifier).__il2cppRuntimeField_350;
        }
        public float get_hue()
        {
            return (float)this.m_Hue;
        }
        public void set_hue(float value)
        {
            float val_1 = UnityEngine.Mathf.Clamp(value:  value, min:  -0.5f, max:  0.5f);
            if((UnityEngine.Mathf.Approximately(a:  this.m_Hue, b:  val_1)) != false)
            {
                    return;
            }
            
            this.m_Hue = val_1;
            goto typeof(Coffee.UIExtensions.UIHsvModifier).__il2cppRuntimeField_350;
        }
        public override Coffee.UIExtensions.ParameterTexture get_ptex()
        {
            null = null;
            return (Coffee.UIExtensions.ParameterTexture)Coffee.UIExtensions.UIHsvModifier._ptex;
        }
        public override void ModifyMesh(UnityEngine.UI.VertexHelper vh)
        {
            float val_4;
            float val_5;
            if(this.isActiveAndEnabled == false)
            {
                    return;
            }
            
            int val_3 = vh.currentVertCount;
            if(val_3 < 1)
            {
                    return;
            }
            
            var val_8 = 0;
            do
            {
                vh.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()}, i:  0);
                UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  Packer.ToFloat(x:  val_4, y:  val_5), y:  this.GetNormalizedIndex(target:  this));
                val_4 = val_7.x;
                vh.SetUIVertex(vertex:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()}, i:  0);
                val_8 = val_8 + 1;
            }
            while(val_3 != val_8);
        
        }
        protected override void SetDirty()
        {
            UnityEngine.Color.RGBToHSV(rgbColor:  new UnityEngine.Color() {r = this.m_TargetColor}, H: out  float val_1 = -2.627674E-14f, S: out  float val_2 = -2.627674E-14f, V: out  float val_3 = -2.627672E-14f);
            this.Initialize();
            this.RegisterMaterial(mat:  this);
            this.SetData(target:  this, channelId:  0, value:  0f);
            this.SetData(target:  this, channelId:  1, value:  0f);
            this.SetData(target:  this, channelId:  2, value:  0f);
            this.SetData(target:  this, channelId:  3, value:  this.m_Range);
            float val_4 = this.m_Hue;
            val_4 = val_4 + 0.5f;
            this.SetData(target:  this, channelId:  4, value:  val_4);
            float val_5 = this.m_Saturation;
            val_5 = val_5 + 0.5f;
            this.SetData(target:  this, channelId:  5, value:  val_5);
            float val_6 = this.m_Value;
            val_6 = val_6 + 0.5f;
            this.SetData(target:  this, channelId:  6, value:  val_6);
        }
        public UIHsvModifier()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.red;
            this.m_TargetColor = val_1;
            mem[1152921528915890944] = val_1.g;
            mem[1152921528915890948] = val_1.b;
            mem[1152921528915890952] = val_1.a;
            this.m_Range = 0.1f;
        }
        private static UIHsvModifier()
        {
            Coffee.UIExtensions.UIHsvModifier._ptex = new Coffee.UIExtensions.ParameterTexture(channels:  7, instanceLimit:  128, propertyName:  "_ParamTex");
        }
    
    }

}
