using UnityEngine;

namespace Coffee.UIExtensions
{
    public class UIShadow : BaseMeshEffect
    {
        // Fields
        private float m_BlurFactor;
        private Coffee.UIExtensions.ShadowStyle m_Style;
        private System.Collections.Generic.List<Coffee.UIExtensions.UIShadow.AdditionalShadow> m_AdditionalShadows;
        private UnityEngine.Color m_EffectColor;
        private UnityEngine.Vector2 m_EffectDistance;
        private bool m_UseGraphicAlpha;
        private const float kMaxEffectDistance = 600;
        private int _graphicVertexCount;
        private static readonly System.Collections.Generic.List<Coffee.UIExtensions.UIShadow> tmpShadows;
        private static readonly System.Collections.Generic.List<UnityEngine.UIVertex> s_Verts;
        
        // Properties
        public UnityEngine.Color effectColor { get; set; }
        public UnityEngine.Vector2 effectDistance { get; set; }
        public bool useGraphicAlpha { get; set; }
        public float blur { get; set; }
        public float blurFactor { get; set; }
        public Coffee.UIExtensions.ShadowStyle style { get; set; }
        
        // Methods
        public UnityEngine.Color get_effectColor()
        {
            return new UnityEngine.Color() {r = this.m_EffectColor};
        }
        public void set_effectColor(UnityEngine.Color value)
        {
            this.m_EffectColor = value;
            mem[1152921528889557996] = value.g;
            mem[1152921528889558000] = value.b;
            mem[1152921528889558004] = value.a;
            this.Initialize();
            if(static_value_02D63000 == 0)
            {
                    return;
            }
            
            this.Initialize();
            this.LateUpdate();
        }
        public UnityEngine.Vector2 get_effectDistance()
        {
            return new UnityEngine.Vector2() {x = this.m_EffectDistance};
        }
        public void set_effectDistance(UnityEngine.Vector2 value)
        {
            float val_1 = (value.x > 600f) ? 600f : (S2);
            float val_2 = (value.y > 600f) ? 600f : -600f;
            if((UnityEngine.Vector2.op_Equality(lhs:  new UnityEngine.Vector2() {x = this.m_EffectDistance, y = V10.16B}, rhs:  new UnityEngine.Vector2() {x = val_1, y = val_2})) == true)
            {
                    return;
            }
            
            this.m_EffectDistance = val_1;
            mem[1152921528889782012] = val_2;
            this.Initialize();
            if(static_value_02D63000 == 0)
            {
                    return;
            }
            
            this.Initialize();
            this.LateUpdate();
        }
        public bool get_useGraphicAlpha()
        {
            return (bool)this.m_UseGraphicAlpha;
        }
        public void set_useGraphicAlpha(bool value)
        {
            this.m_UseGraphicAlpha = value;
            this.Initialize();
            if(value == 0)
            {
                    return;
            }
            
            this.Initialize();
            this.LateUpdate();
        }
        public float get_blur()
        {
            return (float)this.m_BlurFactor;
        }
        public void set_blur(float value)
        {
            this.m_BlurFactor = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  2f);
            this._SetDirty();
        }
        public float get_blurFactor()
        {
            return (float)this.m_BlurFactor;
        }
        public void set_blurFactor(float value)
        {
            this.m_BlurFactor = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  2f);
            this._SetDirty();
        }
        public Coffee.UIExtensions.ShadowStyle get_style()
        {
            return (Coffee.UIExtensions.ShadowStyle)this.m_Style;
        }
        public void set_style(Coffee.UIExtensions.ShadowStyle value)
        {
            this.m_Style = value;
            this._SetDirty();
        }
        protected override void OnEnable()
        {
            this.OnEnable();
        }
        protected override void OnDisable()
        {
            this.OnDisable();
        }
        public override void ModifyMesh(UnityEngine.UI.VertexHelper vh)
        {
            UnityEngine.Object val_4;
            var val_5;
            UnityEngine.Object val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            if(this.isActiveAndEnabled == false)
            {
                    return;
            }
            
            if(vh == null)
            {
                    throw new NullReferenceException();
            }
            
            if(vh.currentVertCount < 1)
            {
                    return;
            }
            
            if(this.m_Style == 0)
            {
                    return;
            }
            
            val_13 = null;
            val_13 = null;
            vh.GetUIVertexStream(stream:  Coffee.UIExtensions.UIShadow.s_Verts);
            this.GetComponents<Coffee.UIExtensions.UIShadow>(results:  Coffee.UIExtensions.UIShadow.tmpShadows);
            if(Coffee.UIExtensions.UIShadow.tmpShadows == null)
            {
                    throw new NullReferenceException();
            }
            
            List.Enumerator<T> val_3 = Coffee.UIExtensions.UIShadow.tmpShadows.GetEnumerator();
            var val_12 = 0;
            label_26:
            if(((-1485614176) & 1) == 0)
            {
                goto label_13;
            }
            
            val_12 = val_4;
            if(val_12 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if(val_12.isActiveAndEnabled == false)
            {
                goto label_26;
            }
            
            if(val_12 != this)
            {
                goto label_13;
            }
            
            val_14 = null;
            val_14 = null;
            List.Enumerator<T> val_8 = Coffee.UIExtensions.UIShadow.tmpShadows.GetEnumerator();
            goto label_17;
            label_22:
            val_12 = val_4 + 24;
            label_17:
            if(((-1485614208) & 1) == 0)
            {
                goto label_18;
            }
            
            val_15 = null;
            val_12 = val_4;
            val_15 = null;
            if(Coffee.UIExtensions.UIShadow.s_Verts == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_12 != 0)
            {
                goto label_22;
            }
            
            throw new NullReferenceException();
            label_18:
            val_12 = val_12 + 1;
            val_12 = 0;
            mem2[0] = 171;
            val_5.Dispose();
            if(val_12 != 0)
            {
                    throw val_12;
            }
            
            if((val_12 == 1) || ((1152921528891036496 + ((0 + 1)) << 2) != 171))
            {
                goto label_26;
            }
            
            goto label_39;
            label_13:
            var val_9 = val_12 + 1;
            mem2[0] = 171;
            label_39:
            val_5.Dispose();
            val_16 = null;
            val_16 = null;
            if(Coffee.UIExtensions.UIShadow.tmpShadows == null)
            {
                    throw new NullReferenceException();
            }
            
            Coffee.UIExtensions.UIShadow.tmpShadows.Clear();
            if(Coffee.UIExtensions.UIShadow.s_Verts == null)
            {
                    throw new NullReferenceException();
            }
            
            int val_13 = this._graphicVertexCount;
            val_13 = (Coffee.UIExtensions.UIShadow.s_Verts + 24) - val_13;
            this._ApplyShadow(verts:  public System.Void System.Collections.Generic.List<Coffee.UIExtensions.UIShadow>::Clear(), color:  new UnityEngine.Color() {r = this.m_EffectColor}, start: ref  val_13, end: ref  Coffee.UIExtensions.UIShadow.s_Verts + 24, effectDistance:  new UnityEngine.Vector2() {x = this.m_EffectDistance}, style:  this.m_Style, useGraphicAlpha:  this.m_UseGraphicAlpha);
            vh.Clear();
            vh.AddUIVertexTriangleStream(verts:  Coffee.UIExtensions.UIShadow.s_Verts);
            if(Coffee.UIExtensions.UIShadow.s_Verts == null)
            {
                    throw new NullReferenceException();
            }
            
            Coffee.UIExtensions.UIShadow.s_Verts.Clear();
        }
        private void _ApplyShadow(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color color, ref int start, ref int end, UnityEngine.Vector2 effectDistance, Coffee.UIExtensions.ShadowStyle style, bool useGraphicAlpha)
        {
            var val_25;
            var val_26;
            bool val_28;
            var val_29;
            float val_30;
            int val_31;
            System.Collections.Generic.List<UnityEngine.UIVertex> val_32;
            int val_33;
            var val_34;
            if(color.a <= 0f)
            {
                    return;
            }
            
            if(style == 0)
            {
                    return;
            }
            
            val_25 = null;
            val_25 = null;
            this._ApplyShadowZeroAlloc(verts:  Coffee.UIExtensions.UIShadow.s_Verts, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, start: ref  1152921528891225472, end: ref  1152921528891229568, x:  effectDistance.x, y:  effectDistance.y, useGraphicAlpha:  useGraphicAlpha);
            if(style == 2)
            {
                goto label_5;
            }
            
            if(style == 3)
            {
                goto label_6;
            }
            
            if(style != 4)
            {
                    return;
            }
            
            val_26 = null;
            val_26 = null;
            val_28 = useGraphicAlpha;
            goto label_10;
            label_5:
            val_29 = null;
            val_29 = null;
            val_30 = -effectDistance.y;
            val_28 = useGraphicAlpha;
            this._ApplyShadowZeroAlloc(verts:  Coffee.UIExtensions.UIShadow.s_Verts, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, start: ref  1152921528891225472, end: ref  1152921528891229568, x:  effectDistance.x, y:  val_30, useGraphicAlpha:  val_28);
            this._ApplyShadowZeroAlloc(verts:  Coffee.UIExtensions.UIShadow.s_Verts, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, start: ref  1152921528891225472, end: ref  1152921528891229568, x:  -effectDistance.x, y:  effectDistance.y, useGraphicAlpha:  val_28);
            val_31 = 1152921528891225472;
            val_32 = Coffee.UIExtensions.UIShadow.s_Verts;
            val_33 = 1152921528891229568;
            goto label_13;
            label_6:
            val_34 = null;
            val_34 = null;
            val_30 = -effectDistance.y;
            val_28 = useGraphicAlpha;
            this._ApplyShadowZeroAlloc(verts:  Coffee.UIExtensions.UIShadow.s_Verts, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, start: ref  1152921528891225472, end: ref  1152921528891229568, x:  effectDistance.x, y:  val_30, useGraphicAlpha:  val_28);
            this._ApplyShadowZeroAlloc(verts:  Coffee.UIExtensions.UIShadow.s_Verts, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, start: ref  1152921528891225472, end: ref  1152921528891229568, x:  -effectDistance.x, y:  effectDistance.y, useGraphicAlpha:  val_28);
            this._ApplyShadowZeroAlloc(verts:  Coffee.UIExtensions.UIShadow.s_Verts, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, start: ref  1152921528891225472, end: ref  1152921528891229568, x:  -effectDistance.x, y:  val_30, useGraphicAlpha:  val_28);
            this._ApplyShadowZeroAlloc(verts:  Coffee.UIExtensions.UIShadow.s_Verts, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, start: ref  1152921528891225472, end: ref  1152921528891229568, x:  -effectDistance.x, y:  0f, useGraphicAlpha:  val_28);
            this._ApplyShadowZeroAlloc(verts:  Coffee.UIExtensions.UIShadow.s_Verts, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, start: ref  1152921528891225472, end: ref  1152921528891229568, x:  0f, y:  val_30, useGraphicAlpha:  val_28);
            label_10:
            this._ApplyShadowZeroAlloc(verts:  Coffee.UIExtensions.UIShadow.s_Verts, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, start: ref  1152921528891225472, end: ref  1152921528891229568, x:  effectDistance.x, y:  0f, useGraphicAlpha:  val_28);
            val_32 = Coffee.UIExtensions.UIShadow.s_Verts;
            val_31 = 1152921528891225472;
            val_33 = 1152921528891229568;
            label_13:
            this._ApplyShadowZeroAlloc(verts:  val_32, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, start: ref  val_31, end: ref  val_33, x:  0f, y:  effectDistance.y, useGraphicAlpha:  val_28);
        }
        private void _ApplyShadowZeroAlloc(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color color, ref int start, ref int end, float x, float y, bool useGraphicAlpha)
        {
            float val_7;
            float val_8;
            float val_9;
            byte val_10;
            var val_13;
            int val_14;
            int val_15;
            val_14 = end;
            val_15 = start;
            int val_1 = val_14 - val_15;
            int val_2 = true + val_1;
            if(verts.Capacity < val_2)
            {
                    var val_13 = 1152921528891307040;
                verts.Capacity = val_2;
            }
            
            if(val_1 >= 1)
            {
                    val_13 = 1152921528891308064;
                var val_12 = val_1;
                do
            {
                verts.Add(item:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()});
                val_12 = val_12 - 1;
            }
            while(val_1 != 1);
            
            }
            
            if(47817783 < val_1)
            {
                goto label_5;
            }
            
            val_13 = 1152921528891309088;
            val_15 = val_15 - val_14;
            goto label_6;
            label_8:
            label_6:
            val_14 = val_15 + 47817783;
            if(val_13 <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_13 = val_13 + (val_14 * 76);
            int val_4 = val_13 + 32;
            val_14 = public System.Void System.Collections.Generic.List<UnityEngine.UIVertex>::set_Item(int index, UnityEngine.UIVertex value);
            verts.set_Item(index:  47817783, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()});
            if(47817782 >= val_1)
            {
                goto label_8;
            }
            
            label_5:
            if(val_1 >= 1)
            {
                    var val_18 = 0;
                val_15 = 76;
                do
            {
                int val_14 = start;
                val_13 = (val_1 + val_18) + val_14;
                if(1152921528891306016 <= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_14 = val_14 + (val_13 * 76);
                int val_6 = val_14 + 32;
                float val_15 = val_7;
                float val_16 = val_8;
                val_15 = val_15 + x;
                val_16 = val_16 + y;
                if(useGraphicAlpha != false)
            {
                    float val_17 = (float)val_10;
                val_17 = color.a * val_17;
                val_17 = val_17 / 255f;
            }
            
                UnityEngine.Color32 val_11 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = this.m_EffectColor, g = val_16, b = val_9, a = val_17});
                val_14 = public System.Void System.Collections.Generic.List<UnityEngine.UIVertex>::set_Item(int index, UnityEngine.UIVertex value);
                val_10 = val_11.a;
                verts.set_Item(index:  0, value:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()});
                val_18 = val_18 + 1;
            }
            while(val_1 != val_18);
            
            }
            
            start = end;
            end = end;
        }
        private void _SetDirty()
        {
            this.Initialize();
            if((UnityEngine.Object.op_Implicit(exists:  static_value_02D63000)) == false)
            {
                    return;
            }
            
            this.Initialize();
            this.LateUpdate();
        }
        public UIShadow()
        {
            this.m_BlurFactor = 1f;
            this.m_Style = 1;
            this.m_AdditionalShadows = new System.Collections.Generic.List<AdditionalShadow>();
            this.m_EffectColor = 0;
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  1f, y:  -1f);
            this.m_UseGraphicAlpha = true;
            this.m_EffectDistance = val_2.x;
            mem[1152921528891574588] = val_2.y;
        }
        private static UIShadow()
        {
            Coffee.UIExtensions.UIShadow.tmpShadows = new System.Collections.Generic.List<Coffee.UIExtensions.UIShadow>();
            Coffee.UIExtensions.UIShadow.s_Verts = new System.Collections.Generic.List<UnityEngine.UIVertex>();
        }
    
    }

}
