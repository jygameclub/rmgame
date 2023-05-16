using UnityEngine;

namespace Coffee.UIExtensions
{
    public class UIGradient : BaseMeshEffect
    {
        // Fields
        private Coffee.UIExtensions.UIGradient.Direction m_Direction;
        private UnityEngine.Color m_Color1;
        private UnityEngine.Color m_Color2;
        private UnityEngine.Color m_Color3;
        private UnityEngine.Color m_Color4;
        private float m_Rotation;
        private float m_Offset1;
        private float m_Offset2;
        private Coffee.UIExtensions.UIGradient.GradientStyle m_GradientStyle;
        private UnityEngine.ColorSpace m_ColorSpace;
        private bool m_IgnoreAspectRatio;
        private static readonly UnityEngine.Vector2[] s_SplitedCharacterPosition;
        
        // Properties
        public UnityEngine.UI.Graphic targetGraphic { get; }
        public Coffee.UIExtensions.UIGradient.Direction direction { get; set; }
        public UnityEngine.Color color1 { get; set; }
        public UnityEngine.Color color2 { get; set; }
        public UnityEngine.Color color3 { get; set; }
        public UnityEngine.Color color4 { get; set; }
        public float rotation { get; set; }
        public float offset { get; set; }
        public UnityEngine.Vector2 offset2 { get; set; }
        public Coffee.UIExtensions.UIGradient.GradientStyle gradientStyle { get; set; }
        public UnityEngine.ColorSpace colorSpace { get; set; }
        public bool ignoreAspectRatio { get; set; }
        
        // Methods
        public UnityEngine.UI.Graphic get_targetGraphic()
        {
            this.Initialize();
            return (UnityEngine.UI.Graphic)this;
        }
        public Coffee.UIExtensions.UIGradient.Direction get_direction()
        {
            return (Direction)this.m_Direction;
        }
        public void set_direction(Coffee.UIExtensions.UIGradient.Direction value)
        {
            if(this.m_Direction == value)
            {
                    return;
            }
            
            this.m_Direction = value;
            this.SetVerticesDirty();
        }
        public UnityEngine.Color get_color1()
        {
            return new UnityEngine.Color() {r = this.m_Color1};
        }
        public void set_color1(UnityEngine.Color value)
        {
            if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = this.m_Color1, g = value.g, b = value.b, a = value.a}, rhs:  new UnityEngine.Color() {r = value.r, g = value.g, b = value.b, a = value.a})) == false)
            {
                    return;
            }
            
            this.m_Color1 = value;
            mem[1152921528886618688] = value.g;
            mem[1152921528886618692] = value.b;
            mem[1152921528886618696] = value.a;
            this.SetVerticesDirty();
        }
        public UnityEngine.Color get_color2()
        {
            return new UnityEngine.Color() {r = this.m_Color2};
        }
        public void set_color2(UnityEngine.Color value)
        {
            if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = this.m_Color2, g = value.g, b = value.b, a = value.a}, rhs:  new UnityEngine.Color() {r = value.r, g = value.g, b = value.b, a = value.a})) == false)
            {
                    return;
            }
            
            this.m_Color2 = value;
            mem[1152921528886842704] = value.g;
            mem[1152921528886842708] = value.b;
            mem[1152921528886842712] = value.a;
            this.SetVerticesDirty();
        }
        public UnityEngine.Color get_color3()
        {
            return new UnityEngine.Color() {r = this.m_Color3};
        }
        public void set_color3(UnityEngine.Color value)
        {
            if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = this.m_Color3, g = value.g, b = value.b, a = value.a}, rhs:  new UnityEngine.Color() {r = value.r, g = value.g, b = value.b, a = value.a})) == false)
            {
                    return;
            }
            
            this.m_Color3 = value;
            mem[1152921528887066720] = value.g;
            mem[1152921528887066724] = value.b;
            mem[1152921528887066728] = value.a;
            this.SetVerticesDirty();
        }
        public UnityEngine.Color get_color4()
        {
            return new UnityEngine.Color() {r = this.m_Color4};
        }
        public void set_color4(UnityEngine.Color value)
        {
            if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = this.m_Color4, g = value.g, b = value.b, a = value.a}, rhs:  new UnityEngine.Color() {r = value.r, g = value.g, b = value.b, a = value.a})) == false)
            {
                    return;
            }
            
            this.m_Color4 = value;
            mem[1152921528887290736] = value.g;
            mem[1152921528887290740] = value.b;
            mem[1152921528887290744] = value.a;
            this.SetVerticesDirty();
        }
        public float get_rotation()
        {
            if(this.m_Direction == 0)
            {
                    return -90f;
            }
            
            if(this.m_Direction != 1)
            {
                    return (float)this.m_Rotation;
            }
            
            return 0f;
        }
        public void set_rotation(float value)
        {
            if((UnityEngine.Mathf.Approximately(a:  this.m_Rotation, b:  value)) != false)
            {
                    return;
            }
            
            this.m_Rotation = value;
            this.SetVerticesDirty();
        }
        public float get_offset()
        {
            return (float)this.m_Offset1;
        }
        public void set_offset(float value)
        {
            if(this.m_Offset1 == value)
            {
                    return;
            }
            
            this.m_Offset1 = value;
            this.SetVerticesDirty();
        }
        public UnityEngine.Vector2 get_offset2()
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  this.m_Offset2, y:  this.m_Offset1);
            return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        public void set_offset2(UnityEngine.Vector2 value)
        {
            if(this.m_Offset1 == value.y)
            {
                    if(this.m_Offset2 == value.x)
            {
                    return;
            }
            
            }
            
            this.m_Offset1 = value.y;
            this.m_Offset2 = value.x;
            this.SetVerticesDirty();
        }
        public Coffee.UIExtensions.UIGradient.GradientStyle get_gradientStyle()
        {
            return (GradientStyle)this.m_GradientStyle;
        }
        public void set_gradientStyle(Coffee.UIExtensions.UIGradient.GradientStyle value)
        {
            if(this.m_GradientStyle == value)
            {
                    return;
            }
            
            this.m_GradientStyle = value;
            this.SetVerticesDirty();
        }
        public UnityEngine.ColorSpace get_colorSpace()
        {
            return (UnityEngine.ColorSpace)this.m_ColorSpace;
        }
        public void set_colorSpace(UnityEngine.ColorSpace value)
        {
            if(this.m_ColorSpace == value)
            {
                    return;
            }
            
            this.m_ColorSpace = value;
            this.SetVerticesDirty();
        }
        public bool get_ignoreAspectRatio()
        {
            return (bool)this.m_IgnoreAspectRatio;
        }
        public void set_ignoreAspectRatio(bool value)
        {
            var val_1 = (this.m_IgnoreAspectRatio == true) ? 1 : 0;
            val_1 = val_1 ^ value;
            if(val_1 == false)
            {
                    return;
            }
            
            this.m_IgnoreAspectRatio = value;
            this.SetVerticesDirty();
        }
        public override void ModifyMesh(UnityEngine.UI.VertexHelper vh)
        {
            float val_6;
            float val_8;
            float val_19;
            byte val_27;
            var val_40;
            float val_45;
            float val_46;
            var val_47;
            float val_50;
            float val_51;
            float val_52;
            float val_53;
            var val_56;
            UnityEngine.Color val_57;
            var val_58;
            var val_59;
            var val_60;
            var val_61;
            if(this.IsActive() == false)
            {
                    return;
            }
            
            if(this.m_GradientStyle == 2)
            {
                goto label_2;
            }
            
            if(this.m_GradientStyle == 1)
            {
                goto label_3;
            }
            
            if(this.m_GradientStyle != 0)
            {
                goto label_13;
            }
            
            this.Initialize();
            UnityEngine.Rect val_3 = this.rectTransform.rect;
            goto label_13;
            label_3:
            if(vh.currentVertCount < 1)
            {
                goto label_13;
            }
            
            do
            {
                vh.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()}, i:  0);
                float val_11 = UnityEngine.Mathf.Max(a:  UnityEngine.Mathf.Max(a:  UnityEngine.Mathf.Min(a:  UnityEngine.Mathf.Min(a:  val_3.m_XMin.System.IConvertible.ToSingle(provider:  0), b:  val_6), b:  val_8), b:  val_6), b:  val_8);
                val_40 = 0 + 1;
            }
            while(val_40 < vh.currentVertCount);
            
            goto label_13;
            label_2:
            label_13:
            if(this.m_Direction == 0)
            {
                goto label_14;
            }
            
            if(this.m_Direction != 1)
            {
                goto label_15;
            }
            
            val_45 = 0f;
            goto label_17;
            label_14:
            val_45 = -1.570796f;
            goto label_17;
            label_15:
            val_45 = this.m_Rotation * 0.01745329f;
            label_17:
            val_46 = val_45;
            float val_39 = val_46;
            UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  val_39, y:  val_45);
            if((this.m_IgnoreAspectRatio != true) && (this.m_Direction >= 2))
            {
                    val_46 = val_13.x;
                val_45 = val_39;
                val_39 = val_45 / val_39;
                val_39 = val_46 * val_39;
                UnityEngine.Vector2 val_14 = val_39.normalized;
            }
            
            if(vh.currentVertCount < 1)
            {
                    return;
            }
            
            do
            {
                vh.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()}, i:  0);
                if(this.m_GradientStyle == 2)
            {
                    val_47 = null;
                val_47 = null;
                UnityEngine.Vector2[] val_40 = Coffee.UIExtensions.UIGradient.s_SplitedCharacterPosition;
                var val_16 = 0 & 3;
                val_40 = val_40 + (((0 & 3)) << 3);
                UnityEngine.Vector2 val_17 = UIGradient.Matrix2x3.op_Multiply(m:  new UIGradient.Matrix2x3() {m00 = 0f, m01 = 0f, m02 = 0f, m10 = 0f, m11 = 0f, m12 = 0f}, v:  new UnityEngine.Vector2() {x = (Coffee.UIExtensions.UIGradient.s_SplitedCharacterPosition + ((0 & 3)) << 3) + 32, y = (Coffee.UIExtensions.UIGradient.s_SplitedCharacterPosition + ((0 & 3)) << 3) + 32 + 4});
                UnityEngine.Vector2 val_18 = new UnityEngine.Vector2(x:  this.m_Offset2, y:  this.m_Offset1);
                val_50 = val_18.x;
                val_51 = val_17.x;
                val_52 = val_17.y;
                val_53 = val_18.y;
            }
            else
            {
                    val_50 = val_19;
                UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_6, y = val_8, z = val_50});
                UnityEngine.Vector2 val_21 = UIGradient.Matrix2x3.op_Multiply(m:  new UIGradient.Matrix2x3() {m00 = 0f, m01 = 0f, m02 = 0f, m10 = 0f, m11 = 0f, m12 = 0f}, v:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
                UnityEngine.Vector2 val_22 = new UnityEngine.Vector2(x:  this.m_Offset2, y:  this.m_Offset1);
                val_53 = val_22.y;
                val_51 = val_21.x;
                val_52 = val_21.y;
            }
            
                UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_51, y = val_52}, b:  new UnityEngine.Vector2() {x = val_22.x, y = val_53});
                if(this.m_Direction == 3)
            {
                    UnityEngine.Color val_24 = UnityEngine.Color.LerpUnclamped(a:  new UnityEngine.Color() {r = this.m_Color1, g = val_23.y, b = val_22.x, a = val_53}, b:  new UnityEngine.Color() {r = this.m_Color2, g = val_14.y}, t:  val_23.x);
                val_56 = val_24.b;
                val_57 = val_24.r;
                val_58 = val_24.g;
                val_59 = val_24.a;
                UnityEngine.Color val_25 = UnityEngine.Color.LerpUnclamped(a:  new UnityEngine.Color() {r = this.m_Color3, g = val_24.g, b = val_24.b, a = V16.16B}, b:  new UnityEngine.Color() {r = this.m_Color4, g = val_14.y}, t:  val_23.x);
                val_60 = val_25.g;
                val_61 = val_25.a;
            }
            else
            {
                    val_57 = this.m_Color2;
            }
            
                UnityEngine.Color val_26 = UnityEngine.Color.LerpUnclamped(a:  new UnityEngine.Color() {r = val_57, g = val_50, b = V11.16B, a = V13.16B}, b:  new UnityEngine.Color() {r = this.m_Color1, g = val_14.y}, t:  val_23.y);
                UnityEngine.Color val_28 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = val_27, g = val_27, b = val_27, a = val_27});
                val_45 = val_28.r;
                if(this.m_ColorSpace != 0)
            {
                    if(this.m_ColorSpace == 1)
            {
                
            }
            
            }
            
                UnityEngine.Color val_29 = UnityEngine.Color.op_Multiply(a:  new UnityEngine.Color() {r = val_45, g = val_28.g, b = val_28.b, a = val_28.a}, b:  new UnityEngine.Color() {r = val_26.r, g = val_26.g, b = val_26.b, a = val_26.a});
                UnityEngine.Color32 val_30 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_29.r, g = val_29.g, b = val_29.b, a = val_29.a});
                val_27 = val_30.r;
                vh.SetUIVertex(vertex:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()}, i:  0);
                val_40 = 0 + 1;
            }
            while(val_40 < vh.currentVertCount);
        
        }
        public UIGradient()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.m_Color1 = val_1;
            mem[1152921528888981568] = val_1.g;
            mem[1152921528888981572] = val_1.b;
            mem[1152921528888981576] = val_1.a;
            UnityEngine.Color val_2 = UnityEngine.Color.white;
            this.m_Color2 = val_2;
            mem[1152921528888981584] = val_2.g;
            mem[1152921528888981588] = val_2.b;
            mem[1152921528888981592] = val_2.a;
            UnityEngine.Color val_3 = UnityEngine.Color.white;
            this.m_Color3 = val_3;
            mem[1152921528888981600] = val_3.g;
            mem[1152921528888981604] = val_3.b;
            mem[1152921528888981608] = val_3.a;
            UnityEngine.Color val_4 = UnityEngine.Color.white;
            this.m_Color4 = val_4;
            mem[1152921528888981616] = val_4.g;
            mem[1152921528888981620] = val_4.b;
            mem[1152921528888981624] = val_4.a;
            this.m_ColorSpace = 0;
            this.m_IgnoreAspectRatio = true;
        }
        private static UIGradient()
        {
            UnityEngine.Vector2[] val_1 = new UnityEngine.Vector2[4];
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.up;
            val_1[0] = val_2;
            val_1[0] = val_2.y;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.one;
            val_1[1] = val_3;
            val_1[1] = val_3.y;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.right;
            val_1[2] = val_4;
            val_1[2] = val_4.y;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
            val_1[3] = val_5;
            val_1[3] = val_5.y;
            Coffee.UIExtensions.UIGradient.s_SplitedCharacterPosition = val_1;
        }
    
    }

}
