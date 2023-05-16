using UnityEngine;

namespace Coffee.UIExtensions
{
    public class UIEffect : UIEffectBase
    {
        // Fields
        public const string shaderName = "UI/Hidden/UI-Effect";
        private static readonly Coffee.UIExtensions.ParameterTexture _ptex;
        private float m_EffectFactor;
        private float m_ColorFactor;
        private float m_BlurFactor;
        private Coffee.UIExtensions.EffectMode m_EffectMode;
        private Coffee.UIExtensions.ColorMode m_ColorMode;
        private Coffee.UIExtensions.BlurMode m_BlurMode;
        private bool m_AdvancedBlur;
        private float m_ShadowBlur;
        private Coffee.UIExtensions.ShadowStyle m_ShadowStyle;
        private UnityEngine.Color m_ShadowColor;
        private UnityEngine.Vector2 m_EffectDistance;
        private bool m_UseGraphicAlpha;
        private UnityEngine.Color m_EffectColor;
        private System.Collections.Generic.List<Coffee.UIExtensions.UIShadow.AdditionalShadow> m_AdditionalShadows;
        
        // Properties
        public float toneLevel { get; set; }
        public float effectFactor { get; set; }
        public float colorFactor { get; set; }
        public float blur { get; set; }
        public float blurFactor { get; set; }
        public Coffee.UIExtensions.EffectMode toneMode { get; }
        public Coffee.UIExtensions.EffectMode effectMode { get; }
        public Coffee.UIExtensions.ColorMode colorMode { get; }
        public Coffee.UIExtensions.BlurMode blurMode { get; }
        public UnityEngine.Color effectColor { get; set; }
        public override Coffee.UIExtensions.ParameterTexture ptex { get; }
        
        // Methods
        public float get_toneLevel()
        {
            return (float)this.m_EffectFactor;
        }
        public void set_toneLevel(float value)
        {
            this.m_EffectFactor = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  1f);
            goto typeof(Coffee.UIExtensions.UIEffect).__il2cppRuntimeField_350;
        }
        public float get_effectFactor()
        {
            return (float)this.m_EffectFactor;
        }
        public void set_effectFactor(float value)
        {
            this.m_EffectFactor = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  1f);
            goto typeof(Coffee.UIExtensions.UIEffect).__il2cppRuntimeField_350;
        }
        public float get_colorFactor()
        {
            return (float)this.m_ColorFactor;
        }
        public void set_colorFactor(float value)
        {
            this.m_ColorFactor = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  1f);
            goto typeof(Coffee.UIExtensions.UIEffect).__il2cppRuntimeField_350;
        }
        public float get_blur()
        {
            return (float)this.m_BlurFactor;
        }
        public void set_blur(float value)
        {
            this.m_BlurFactor = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  1f);
            goto typeof(Coffee.UIExtensions.UIEffect).__il2cppRuntimeField_350;
        }
        public float get_blurFactor()
        {
            return (float)this.m_BlurFactor;
        }
        public void set_blurFactor(float value)
        {
            this.m_BlurFactor = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  1f);
            goto typeof(Coffee.UIExtensions.UIEffect).__il2cppRuntimeField_350;
        }
        public Coffee.UIExtensions.EffectMode get_toneMode()
        {
            return (Coffee.UIExtensions.EffectMode)this.m_EffectMode;
        }
        public Coffee.UIExtensions.EffectMode get_effectMode()
        {
            return (Coffee.UIExtensions.EffectMode)this.m_EffectMode;
        }
        public Coffee.UIExtensions.ColorMode get_colorMode()
        {
            return (Coffee.UIExtensions.ColorMode)this.m_ColorMode;
        }
        public Coffee.UIExtensions.BlurMode get_blurMode()
        {
            return (Coffee.UIExtensions.BlurMode)this.m_BlurMode;
        }
        public UnityEngine.Color get_effectColor()
        {
            this.Initialize();
            return this.materials;
        }
        public void set_effectColor(UnityEngine.Color value)
        {
            this.Initialize();
            this.ModifyMesh(mesh:  public System.Void Coffee.UIExtensions.BaseMeshEffect::ModifyMesh(UnityEngine.Mesh mesh));
            goto typeof(Coffee.UIExtensions.UIEffect).__il2cppRuntimeField_350;
        }
        public override Coffee.UIExtensions.ParameterTexture get_ptex()
        {
            null = null;
            return (Coffee.UIExtensions.ParameterTexture)Coffee.UIExtensions.UIEffect._ptex;
        }
        public override void ModifyMesh(UnityEngine.UI.VertexHelper vh)
        {
            float val_6;
            float val_7;
            UnityEngine.UI.VertexHelper val_38;
            UnityEngine.UI.VertexHelper val_39;
            float val_40;
            var val_41;
            var val_42;
            float val_44;
            float val_45;
            float val_46;
            var val_47;
            var val_49;
            System.Collections.Generic.List<UnityEngine.UIVertex> val_50;
            float val_51;
            float val_52;
            float val_53;
            var val_54;
            var val_55;
            var val_56;
            float val_57;
            float val_58;
            float val_59;
            float val_60;
            var val_61;
            var val_62;
            val_39 = vh;
            if(this.isActiveAndEnabled == false)
            {
                    return;
            }
            
            val_40 = this.GetNormalizedIndex(target:  this);
            if((this.m_BlurMode == 0) || (this.m_AdvancedBlur == false))
            {
                goto label_4;
            }
            
            val_39.GetUIVertexStream(stream:  Coffee.UIExtensions.UIEffectBase.tempVerts);
            val_39.Clear();
            this.Initialize();
            if((System.Void Coffee.UIExtensions.BaseMeshEffect::Initialize()) == 0)
            {
                goto label_9;
            }
            
            var val_4 = (((System.Void Coffee.UIExtensions.BaseMeshEffect::Initialize().__il2cppRuntimeField_C8 + (UnityEngine.UI.Text.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 6 : (Coffee.UIExtensions.UIEffectBase.tempVerts + 24);
            goto label_11;
            label_4:
            int val_5 = val_39.currentVertCount;
            if(val_5 < 1)
            {
                    return;
            }
            
            do
            {
                val_39.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()}, i:  0);
                float val_39 = val_6;
                float val_40 = val_7;
                val_39 = val_39 + 0.5f;
                val_40 = val_40 + 0.5f;
                val_39 = val_39 * 0.5f;
                val_40 = val_40 * 0.5f;
                UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  Packer.ToFloat(x:  val_39, y:  val_40), y:  val_40);
                val_6 = val_9.x;
                val_39.SetUIVertex(vertex:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()}, i:  0);
                val_41 = 0 + 1;
            }
            while(val_5 != val_41);
            
            return;
            label_9:
            label_11:
            val_42 = null;
            var val_10 = ((Coffee.UIExtensions.UIEffectBase.__il2cppRuntimeField_12F & 2) != 0) ? 1 : 0;
            if((Coffee.UIExtensions.UIEffectBase.tempVerts + 24) < 1)
            {
                goto label_16;
            }
            
            float val_41 = (float)this.m_BlurMode;
            val_41 = val_41 * 6f;
            val_41 = val_41 + val_41;
            var val_52 = 0;
            val_44 = 0f;
            val_45 = 0f;
            val_46 = 0f;
            label_58:
            val_47 = null;
            Coffee.UIExtensions.UIEffect.GetBounds(verts:  Coffee.UIExtensions.UIEffectBase.tempVerts, start:  0, count:  Coffee.UIExtensions.UIEffectBase.tempVerts + 24, posBounds: ref  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, uvBounds: ref  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, global:  false);
            float val_11 = 0f.System.IConvertible.ToSingle(provider:  0);
            float val_12 = Packer.ToFloat(x:  val_11, y:  val_11);
            UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  val_12, y:  Packer.ToFloat(x:  val_12, y:  val_12));
            if((Coffee.UIExtensions.UIEffectBase.tempVerts + 24) < 1)
            {
                goto label_21;
            }
            
            var val_42 = 0;
            label_57:
            val_49 = null;
            val_49 = null;
            val_50 = Coffee.UIExtensions.UIEffectBase.tempVerts;
            val_42 = val_42 + 0;
            var val_15 = val_42 + 1;
            if((Coffee.UIExtensions.UIEffectBase.tempVerts + 24) <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_50 = Coffee.UIExtensions.UIEffectBase.tempVerts;
            }
            
            var val_43 = Coffee.UIExtensions.UIEffectBase.tempVerts + 16;
            val_42 = val_42 + 4;
            val_43 = val_43 + (val_15 * 76);
            if((Coffee.UIExtensions.UIEffectBase.tempVerts + 24) <= val_42)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_44 = Coffee.UIExtensions.UIEffectBase.tempVerts + 16;
            val_44 = val_44 + (val_42 * 76);
            val_51 = mem[(((0 + 0) + 4) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 32];
            val_51 = (((0 + 0) + 4) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 32;
            val_52 = mem[(((0 + 0) + 4) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 40];
            val_52 = (((0 + 0) + 4) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 40;
            if((Coffee.UIExtensions.UIEffectBase.tempVerts + 24) == 6)
            {
                goto label_30;
            }
            
            val_46 = (((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 40;
            if(((-1469986352) & 1) == 0)
            {
                goto label_30;
            }
            
            val_53 = val_51;
            val_46 = val_52;
            if(((-1469986352) & 1) == 0)
            {
                goto label_30;
            }
            
            val_54 = 0;
            goto label_31;
            label_30:
            val_55 = null;
            val_55 = null;
            if((Coffee.UIExtensions.UIEffectBase.tempVerts + 24) <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_45 = Coffee.UIExtensions.UIEffectBase.tempVerts + 16;
            val_45 = val_45 + ((long)val_15 * 76);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = ((long)(int)(((0 + 0) + 1)) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 76, y = ((long)(int)(((0 + 0) + 1)) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 76 + 4});
            if((Coffee.UIExtensions.UIEffectBase.tempVerts + 24) <= val_42)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_46 = Coffee.UIExtensions.UIEffectBase.tempVerts + 16;
            val_46 = val_46 + ((long)val_42 * 76);
            UnityEngine.Vector3 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = ((long)(int)(((0 + 0) + 4)) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 76, y = ((long)(int)(((0 + 0) + 4)) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 76 + 4});
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 32, y = (((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 32 + 4, z = (((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 40}, b:  new UnityEngine.Vector3() {x = val_51, y = (((0 + 0) + 4) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 32 + 4, z = val_52});
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, d:  2f);
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, d:  2f);
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = (((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 32, y = (((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 32 + 4, z = (((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 40}, b:  new UnityEngine.Vector3() {x = val_51, y = (((0 + 0) + 4) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 32 + 4, z = val_52});
            val_52 = val_19.y;
            float val_47 = System.Math.Abs(val_22.x);
            float val_48 = System.Math.Abs(val_22.y);
            float val_49 = System.Math.Abs(val_22.z);
            val_47 = val_41 / val_47;
            val_48 = val_41 / val_48;
            val_49 = val_41 / val_49;
            val_45 = val_47 + 1f;
            val_44 = val_48 + 1f;
            float val_23 = val_49 + 1f;
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.Scale(a:  new UnityEngine.Vector3() {x = val_45, y = val_44, z = val_23}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_52, z = val_19.z});
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_52, z = val_19.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
            val_51 = val_21.z;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.Scale(a:  new UnityEngine.Vector3() {x = val_45, y = val_44, z = val_23}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_51});
            val_53 = val_21.x;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_53, y = val_21.y, z = val_51}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
            val_40 = val_40;
            val_54 = 1;
            label_31:
            var val_51 = 0;
            label_56:
            val_56 = null;
            val_56 = null;
            int val_29 = (val_52 + val_51) + 1;
            if((Coffee.UIExtensions.UIEffectBase.tempVerts + 24) <= val_29)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_50 = Coffee.UIExtensions.UIEffectBase.tempVerts + 16;
            val_50 = val_50 + (val_29 * 76);
            val_57 = mem[(((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 32];
            val_57 = (((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 32;
            val_58 = mem[(((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 32 + 4];
            val_58 = (((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 32 + 4;
            val_59 = mem[(((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 76];
            val_59 = (((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 76;
            val_60 = mem[(((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 76 + 4];
            val_60 = (((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 76 + 4;
            if(val_54 == 0)
            {
                goto label_52;
            }
            
            if(val_57 >= 0)
            {
                    if((0f.System.IConvertible.ToSingle(provider:  0)) >= 0)
            {
                goto label_50;
            }
            
            }
            
            val_57 = val_25.x + (val_45 * val_57);
            val_53 = val_27.x;
            val_59 = val_53 + (val_45 * val_59);
            label_50:
            if(val_58 >= 0)
            {
                    if(val_53 >= 0)
            {
                goto label_52;
            }
            
            }
            
            float val_34 = val_44 * val_60;
            val_58 = val_25.y + (val_44 * val_58);
            val_60 = val_27.y + val_34;
            label_52:
            float val_35 = val_59 + 0.5f;
            val_34 = val_60 + 0.5f;
            val_35 = val_35 * 0.5f;
            val_34 = val_34 * 0.5f;
            UnityEngine.Vector2 val_37 = new UnityEngine.Vector2(x:  Packer.ToFloat(x:  val_35, y:  val_34), y:  val_40);
            val_61 = null;
            val_39 = val_14.x;
            val_61 = null;
            Coffee.UIExtensions.UIEffectBase.tempVerts.set_Item(index:  val_29, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = val_57, y = val_58, z = (((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 40}, normal = new UnityEngine.Vector3() {x = (((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 44, y = (((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 44, z = (((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 44}, tangent = new UnityEngine.Vector4() {x = (((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 44, y = (((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 60, z = (((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 60, w = (((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 60}, color = new UnityEngine.Color32() {r = (((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 60, g = (((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 60, b = (((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 60, a = (((0 + 0) + 1) * 76) + Coffee.UIExtensions.UIEffectBase.tempVerts + 16 + 60}});
            val_51 = val_51 + 1;
            if(val_51 < 5)
            {
                goto label_56;
            }
            
            val_52 = val_52 + 6;
            if(6 < (Coffee.UIExtensions.UIEffectBase.tempVerts + 24))
            {
                goto label_57;
            }
            
            label_21:
            val_62 = null;
            var val_53 = 0;
            val_53 = val_53 + (Coffee.UIExtensions.UIEffectBase.tempVerts + 24);
            var val_38 = ((Coffee.UIExtensions.UIEffectBase.__il2cppRuntimeField_12F & 2) != 0) ? 1 : 0;
            val_41 = val_52 + (Coffee.UIExtensions.UIEffectBase.tempVerts + 24);
            if(val_53 < (Coffee.UIExtensions.UIEffectBase.tempVerts + 24))
            {
                goto label_58;
            }
            
            label_16:
            val_38 = val_39;
            AddUIVertexTriangleStream(verts:  Coffee.UIExtensions.UIEffectBase.tempVerts);
            Coffee.UIExtensions.UIEffectBase.tempVerts.Clear();
        }
        protected override void SetDirty()
        {
            this.RegisterMaterial(mat:  typeof(Coffee.UIExtensions.UIEffect).__il2cppRuntimeField_338);
            this.SetData(target:  this, channelId:  0, value:  this.m_EffectFactor);
            this.SetData(target:  this, channelId:  1, value:  this.m_ColorFactor);
            this.SetData(target:  this, channelId:  2, value:  this.m_BlurFactor);
        }
        private static void GetBounds(System.Collections.Generic.List<UnityEngine.UIVertex> verts, int start, int count, ref UnityEngine.Rect posBounds, ref UnityEngine.Rect uvBounds, bool global)
        {
            var val_9;
            var val_10;
            float val_11;
            float val_13;
            val_9 = count;
            val_10 = start;
            val_11 = 3.402823E+38f;
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  val_11, y:  val_11);
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  -3.402823E+38f, y:  -3.402823E+38f);
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_11, y:  val_11);
            val_13 = -3.402823E+38f;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  -3.402823E+38f, y:  -3.402823E+38f);
            int val_5 = val_9 + val_10;
            if(val_5 <= val_10)
            {
                goto label_1;
            }
            
            var val_8 = (long)val_5;
            var val_6 = val_8 - (val_10 << );
            label_21:
            if(val_8 <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_8 + 1152921528906913128;
            val_11 = mem[((long)(int)((count + start)) + 1152921528906913128) + 32];
            val_11 = ((long)(int)((count + start)) + 1152921528906913128) + 32;
            if((val_1.x < val_11) || (val_1.y < (((long)(int)((count + start)) + 1152921528906913128) + 32 + 4)))
            {
                goto label_8;
            }
            
            val_9;
            goto label_11;
            label_8:
            if((val_2.x > val_11) || (val_2.y > (((long)(int)((count + start)) + 1152921528906913128) + 32 + 4)))
            {
                goto label_13;
            }
            
            val_9;
            label_11:
            val_13 = ((long)(int)((count + start)) + 1152921528906913128) + 32 + 4;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_11, y = val_13, z = ((long)(int)((count + start)) + 1152921528906913128) + 40});
            label_13:
            if((val_3.x < (((long)(int)((count + start)) + 1152921528906913128) + 76)) || (val_3.y < (((long)(int)((count + start)) + 1152921528906913128) + 76 + 4)))
            {
                goto label_17;
            }
            
            goto label_18;
            label_17:
            if((val_4.x > (((long)(int)((count + start)) + 1152921528906913128) + 76)) || (val_4.y > (((long)(int)((count + start)) + 1152921528906913128) + 76 + 4)))
            {
                goto label_20;
            }
            
            label_18:
            label_20:
            val_10 = val_10 + 1;
            val_6 = val_6 - 1;
            if(val_4.y != (((long)(int)((count + start)) + 1152921528906913128) + 76 + 4))
            {
                goto label_21;
            }
            
            label_1:
            float val_11 = val_1.x;
            float val_12 = val_1.y;
            float val_9 = val_7.x;
            float val_10 = val_7.y;
            val_9 = val_9 - val_11;
            val_10 = val_10 - val_12;
            val_11 = val_11 + 0.001f;
            val_12 = val_12 + 0.001f;
            val_9 = val_9 + (-0.002f);
            val_10 = val_10 + (-0.002f);
            float val_13 = ((long)(int)((count + start)) + 1152921528906913128) + 76;
            float val_14 = ((long)(int)((count + start)) + 1152921528906913128) + 76 + 4;
            val_13 = val_13 - val_3.x;
            val_14 = val_14 - val_3.y;
        }
        public UIEffect()
        {
            this.m_EffectFactor = 1;
            this.m_BlurFactor = 1f;
            this.m_ShadowBlur = 1f;
            UnityEngine.Color val_1 = UnityEngine.Color.black;
            this.m_ShadowColor = val_1;
            mem[1152921528907053844] = val_1.g;
            mem[1152921528907053848] = val_1.b;
            mem[1152921528907053852] = val_1.a;
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  1f, y:  -1f);
            this.m_UseGraphicAlpha = true;
            this.m_EffectDistance = val_2.x;
            UnityEngine.Color val_3 = UnityEngine.Color.white;
            this.m_EffectColor = val_3;
            mem[1152921528907053872] = val_3.g;
            mem[1152921528907053876] = val_3.b;
            mem[1152921528907053880] = val_3.a;
            this.m_AdditionalShadows = new System.Collections.Generic.List<AdditionalShadow>();
        }
        private static UIEffect()
        {
            Coffee.UIExtensions.UIEffect._ptex = new Coffee.UIExtensions.ParameterTexture(channels:  4, instanceLimit:  1024, propertyName:  "_ParamTex");
        }
    
    }

}
