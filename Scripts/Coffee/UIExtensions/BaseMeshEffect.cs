using UnityEngine;

namespace Coffee.UIExtensions
{
    public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier
    {
        // Fields
        private static readonly System.Collections.Generic.List<UnityEngine.Vector2> s_Uv0;
        private static readonly System.Collections.Generic.List<UnityEngine.Vector2> s_Uv1;
        private static readonly System.Collections.Generic.List<UnityEngine.Vector3> s_Vertices;
        private static readonly System.Collections.Generic.List<int> s_Indices;
        private static readonly System.Collections.Generic.List<UnityEngine.Vector3> s_Normals;
        private static readonly System.Collections.Generic.List<UnityEngine.Vector4> s_Tangents;
        private static readonly System.Collections.Generic.List<UnityEngine.Color32> s_Colors;
        private static readonly UnityEngine.UI.VertexHelper s_VertexHelper;
        private static readonly System.Collections.Generic.List<TMPro.TMP_SubMeshUI> s_SubMeshUIs;
        private static readonly System.Collections.Generic.List<UnityEngine.Mesh> s_Meshes;
        private static readonly UnityEngine.Material[] s_EmptyMaterials;
        private bool _initialized;
        private UnityEngine.CanvasRenderer _canvasRenderer;
        private UnityEngine.RectTransform _rectTransform;
        private UnityEngine.UI.Graphic _graphic;
        private UnityEngine.Material[] _materials;
        private bool _isTextMeshProActive;
        private TMPro.TMP_Text _textMeshPro;
        private Royal.Infrastructure.Utils.Text.TextProOnACurve _textOnACurve;
        
        // Properties
        public UnityEngine.UI.Graphic graphic { get; }
        public UnityEngine.CanvasRenderer canvasRenderer { get; }
        public TMPro.TMP_Text textMeshPro { get; }
        public UnityEngine.RectTransform rectTransform { get; }
        public Royal.Infrastructure.Utils.Text.TextProOnACurve textOnACurve { get; }
        public virtual UnityEngine.AdditionalCanvasShaderChannels requiredChannels { get; }
        public bool isTMPro { get; }
        public virtual UnityEngine.Material material { get; set; }
        public virtual UnityEngine.Material[] materials { get; }
        protected virtual bool isLegacyMeshModifier { get; }
        
        // Methods
        public UnityEngine.UI.Graphic get_graphic()
        {
            return (UnityEngine.UI.Graphic)this._graphic;
        }
        public UnityEngine.CanvasRenderer get_canvasRenderer()
        {
            return (UnityEngine.CanvasRenderer)this._canvasRenderer;
        }
        public TMPro.TMP_Text get_textMeshPro()
        {
            return (TMPro.TMP_Text)this._textMeshPro;
        }
        public UnityEngine.RectTransform get_rectTransform()
        {
            return (UnityEngine.RectTransform)this._rectTransform;
        }
        public Royal.Infrastructure.Utils.Text.TextProOnACurve get_textOnACurve()
        {
            return (Royal.Infrastructure.Utils.Text.TextProOnACurve)this._textOnACurve;
        }
        public virtual UnityEngine.AdditionalCanvasShaderChannels get_requiredChannels()
        {
            return 1;
        }
        public bool get_isTMPro()
        {
            return UnityEngine.Object.op_Inequality(x:  this._textMeshPro, y:  0);
        }
        public virtual UnityEngine.Material get_material()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this._textMeshPro)) != false)
            {
                
            }
            else
            {
                    if((UnityEngine.Object.op_Implicit(exists:  this._graphic)) == false)
            {
                    return 0;
            }
            
            }
            
            this = ???;
            goto typeof(UnityEngine.UI.Graphic).__il2cppRuntimeField_330;
        }
        public virtual void set_material(UnityEngine.Material value)
        {
            var val_9;
            var val_10;
            UnityEngine.UI.Graphic val_12;
            var val_13;
            val_9 = value;
            val_10 = UnityEngine.Object.op_Implicit(exists:  this._textMeshPro);
            if(val_10 != false)
            {
                
            }
            else
            {
                    val_12 = this._graphic;
                if((UnityEngine.Object.op_Implicit(exists:  val_12)) == false)
            {
                    return;
            }
            
            }
            
            val_9 = ???;
            val_13 = ???;
            goto typeof(UnityEngine.UI.Graphic).__il2cppRuntimeField_340;
        }
        public virtual UnityEngine.Material[] get_materials()
        {
            UnityEngine.Material[] val_3;
            TMPro.TMP_Text val_4;
            var val_5;
            var val_7;
            val_3 = this;
            if((UnityEngine.Object.op_Implicit(exists:  this._textMeshPro)) != false)
            {
                    val_4 = this._textMeshPro;
                if(val_4 != null)
            {
                    return (UnityEngine.Material[])val_5;
            }
            
            }
            else
            {
                    if((UnityEngine.Object.op_Implicit(exists:  this._graphic)) != false)
            {
                    val_5 = val_3;
                if(this._graphic == null)
            {
                    throw new NullReferenceException();
            }
            
                if(this._materials == null)
            {
                    throw new NullReferenceException();
            }
            
                val_3 = this._graphic;
                this._materials = val_3;
                return (UnityEngine.Material[])val_5;
            }
            
            }
            
            val_3 = 1152921505155780608;
            val_7 = null;
            val_7 = null;
            val_5 = 1152921505155784784;
            return (UnityEngine.Material[])val_5;
        }
        public virtual void ModifyMesh(UnityEngine.Mesh mesh)
        {
        
        }
        public virtual void ModifyMesh(UnityEngine.UI.VertexHelper vh)
        {
        
        }
        public virtual void SetVerticesDirty()
        {
            var val_5;
            var val_6;
            var val_13;
            Coffee.UIExtensions.BaseMeshEffect val_14;
            UnityEngine.Object val_15;
            var val_16;
            var val_17;
            var val_18;
            val_14 = this;
            if((UnityEngine.Object.op_Implicit(exists:  this._textMeshPro)) == false)
            {
                goto label_5;
            }
            
            val_15 = val_14;
            if(this._textMeshPro == null)
            {
                    throw new NullReferenceException();
            }
            
            if(this._textMeshPro.m_textInfo == null)
            {
                goto label_5;
            }
            
            val_15 = val_14;
            if(this._textMeshPro == null)
            {
                    throw new NullReferenceException();
            }
            
            if(this._textMeshPro.m_textInfo == null)
            {
                    throw new NullReferenceException();
            }
            
            val_14 = this._textMeshPro.m_textInfo.meshInfo;
            if(val_14 == null)
            {
                    throw new NullReferenceException();
            }
            
            int val_12 = this._textMeshPro.m_textInfo.meshInfo.Length;
            if(val_12 >= 1)
            {
                    val_12 = val_12 & 4294967295;
                do
            {
                val_15 = 1152921508019469840;
                val_16 = 0;
                if((UnityEngine.Object.op_Implicit(exists:  val_15)) != false)
            {
                    if(null == null)
            {
                    throw new NullReferenceException();
            }
            
                1152921508019469840.Clear();
                1152921508019469840.vertices = 1152921508019469840;
                1152921508019469840.uv = 1152921508019469840;
                1152921508019469840.uv2 = 1152921508019469840;
                1152921508019469840.colors32 = 1152921508019469840;
                1152921508019469840.normals = 1152921508019469840;
                1152921508019469840.tangents = 1152921508019469840;
                1152921508019469840.triangles = null;
            }
            
                val_13 = 0 + 1;
            }
            while(val_13 < (this._textMeshPro.m_textInfo.meshInfo.Length << ));
            
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  mem[1152921528877931264])) == false)
            {
                goto label_18;
            }
            
            val_15 = this._textMeshPro;
            if(val_15 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(mem[1152921528877931264] == 0)
            {
                    throw new NullReferenceException();
            }
            
            mem[1152921528877931264].SetMesh(mesh:  val_15);
            val_17 = null;
            val_17 = null;
            val_16 = 0;
            this.GetComponentsInChildren<TMPro.TMP_SubMeshUI>(includeInactive:  false, result:  Coffee.UIExtensions.BaseMeshEffect.s_SubMeshUIs);
            val_15 = Coffee.UIExtensions.BaseMeshEffect.s_SubMeshUIs;
            if(val_15 == null)
            {
                    throw new NullReferenceException();
            }
            
            List.Enumerator<T> val_4 = val_15.GetEnumerator();
            val_13 = 1152921528877887776;
            label_27:
            val_16 = public System.Boolean List.Enumerator<TMPro.TMP_SubMeshUI>::MoveNext();
            if(((-1498731648) & 1) == 0)
            {
                goto label_24;
            }
            
            if(val_5 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_5.canvasRenderer.SetMesh(mesh:  val_5.mesh);
            goto label_27;
            label_5:
            if((UnityEngine.Object.op_Implicit(exists:  this._graphic)) == false)
            {
                    return;
            }
            
            val_15 = this._graphic;
            if(val_15 == null)
            {
                    throw new NullReferenceException();
            }
            
            return;
            label_24:
            val_16 = public System.Void List.Enumerator<TMPro.TMP_SubMeshUI>::Dispose();
            val_6.Dispose();
            val_18 = null;
            val_18 = null;
            val_15 = Coffee.UIExtensions.BaseMeshEffect.s_SubMeshUIs;
            if(val_15 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_15.Clear();
            label_18:
            val_15 = this._textMeshPro;
            if(val_15 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_15.havePropertiesChanged = true;
            if(mem[1152921528877931312] == 0)
            {
                    return;
            }
            
            val_15 = mem[1152921528877931312];
            if(val_15 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_15.ForceUpdate();
        }
        public void ShowTMProWarning(UnityEngine.Shader shader, UnityEngine.Shader mobileShader, UnityEngine.Shader spriteShader, System.Action<UnityEngine.Material> onCreatedMaterial)
        {
        
        }
        protected virtual bool get_isLegacyMeshModifier()
        {
            return false;
        }
        protected virtual void Initialize()
        {
            UnityEngine.UI.Graphic val_6;
            UnityEngine.CanvasRenderer val_7;
            UnityEngine.RectTransform val_8;
            Royal.Infrastructure.Utils.Text.TextProOnACurve val_9;
            TMPro.TMP_Text val_10;
            if(this._initialized == true)
            {
                    return;
            }
            
            val_6 = this._graphic;
            this._initialized = true;
            val_7 = this._canvasRenderer;
            this._graphic = this.GetComponent<UnityEngine.UI.Graphic>();
            if(val_7 == null)
            {
                    val_7 = this.GetComponent<UnityEngine.CanvasRenderer>();
            }
            
            val_8 = this._rectTransform;
            this._canvasRenderer = val_7;
            val_9 = this._textOnACurve;
            this._rectTransform = this.GetComponent<UnityEngine.RectTransform>();
            if(val_9 == null)
            {
                    val_9 = this.GetComponent<Royal.Infrastructure.Utils.Text.TextProOnACurve>();
            }
            
            val_10 = this._textMeshPro;
            this._textOnACurve = val_9;
            this._textMeshPro = this.GetComponent<TMPro.TMP_Text>();
        }
        protected override void OnEnable()
        {
            var val_9;
            System.Action<A> val_10;
            this._initialized = false;
            if((UnityEngine.Object.op_Implicit(exists:  this._textMeshPro)) != false)
            {
                    val_9 = null;
                val_9 = null;
                System.Action<UnityEngine.Object> val_2 = null;
                val_10 = val_2;
                val_2 = new System.Action<UnityEngine.Object>(object:  this, method:  System.Void Coffee.UIExtensions.BaseMeshEffect::OnTextChanged(UnityEngine.Object obj));
                TMPro.TMPro_EventManager.TEXT_CHANGED_EVENT.Add(rhs:  val_2);
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this._graphic)) == false)
            {
                    return;
            }
            
            val_10 = this._graphic.canvas;
            if((UnityEngine.Object.op_Implicit(exists:  val_10)) == false)
            {
                    return;
            }
            
            UnityEngine.AdditionalCanvasShaderChannels val_6 = val_10.additionalShaderChannels;
            if()
            {
                    return;
            }
            
            object[] val_7 = new object[2];
            val_10 = val_7;
            val_10[0] = this.GetType();
            val_10[1] = this;
            UnityEngine.Debug.LogWarningFormat(context:  this, format:  "Enable {1} of Canvas.additionalShaderChannels to use {0}.", args:  val_7);
        }
        protected override void OnDisable()
        {
            null = null;
            TMPro.TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(rhs:  new System.Action<UnityEngine.Object>(object:  this, method:  System.Void Coffee.UIExtensions.BaseMeshEffect::OnTextChanged(UnityEngine.Object obj)));
            goto typeof(Coffee.UIExtensions.BaseMeshEffect).__il2cppRuntimeField_2C0;
        }
        protected virtual void LateUpdate()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this._textMeshPro)) == false)
            {
                    return;
            }
            
            if(this._textMeshPro.m_havePropertiesChanged != true)
            {
                    if((((this._isTextMeshProActive == true) ? 1 : 0) ^ this._textMeshPro.isActiveAndEnabled) == false)
            {
                goto label_7;
            }
            
            }
            
            label_7:
            this._isTextMeshProActive = this._textMeshPro.isActiveAndEnabled;
        }
        protected override void OnDidApplyAnimationProperties()
        {
            goto typeof(Coffee.UIExtensions.BaseMeshEffect).__il2cppRuntimeField_2C0;
        }
        private void OnTextChanged(UnityEngine.Object obj)
        {
            UnityEngine.Object val_3;
            var val_4;
            UnityEngine.Object val_13;
            UnityEngine.Object val_14;
            var val_15;
            TMPro.TMP_Text val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            val_13 = this;
            if(this._textMeshPro == null)
            {
                    throw new NullReferenceException();
            }
            
            val_15 = 1152921504784535552;
            val_16 = this._textMeshPro;
            val_13 = val_16;
            val_14 = obj;
            if(val_13 != val_14)
            {
                    return;
            }
            
            if(this._textMeshPro.m_textInfo == null)
            {
                    throw new NullReferenceException();
            }
            
            int val_12 = this._textMeshPro.m_textInfo.characterCount;
            val_12 = val_12 - this._textMeshPro.m_textInfo.spaceCount;
            if(val_12 < 1)
            {
                    return;
            }
            
            val_16 = 1152921505155780608;
            val_17 = null;
            val_17 = null;
            val_13 = Coffee.UIExtensions.BaseMeshEffect.s_Meshes;
            if(val_13 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_14 = public System.Void System.Collections.Generic.List<UnityEngine.Mesh>::Clear();
            val_13.Clear();
            if(this._textMeshPro.m_textInfo.meshInfo == null)
            {
                    throw new NullReferenceException();
            }
            
            int val_13 = this._textMeshPro.m_textInfo.meshInfo.Length;
            if(val_13 >= 1)
            {
                    var val_14 = 0;
                val_13 = val_13 & 4294967295;
                do
            {
                val_18 = null;
                val_18 = null;
                val_13 = Coffee.UIExtensions.BaseMeshEffect.s_Meshes;
                if(val_13 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_13.Add(item:  1152921508019469840);
                val_14 = val_14 + 1;
            }
            while(val_14 < (this._textMeshPro.m_textInfo.meshInfo.Length << ));
            
            }
            
            if((this & 1) == 0)
            {
                goto label_17;
            }
            
            val_19 = null;
            val_19 = null;
            val_13 = Coffee.UIExtensions.BaseMeshEffect.s_Meshes;
            if(val_13 == null)
            {
                    throw new NullReferenceException();
            }
            
            List.Enumerator<T> val_2 = val_13.GetEnumerator();
            label_25:
            if(((-1497445280) & 1) == 0)
            {
                goto label_34;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  val_3)) == false)
            {
                goto label_25;
            }
            
            goto label_25;
            label_17:
            val_21 = null;
            val_21 = null;
            val_13 = Coffee.UIExtensions.BaseMeshEffect.s_Meshes;
            if(val_13 == null)
            {
                    throw new NullReferenceException();
            }
            
            List.Enumerator<T> val_6 = val_13.GetEnumerator();
            label_41:
            if(((-1497445280) & 1) == 0)
            {
                goto label_34;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  val_3)) == false)
            {
                goto label_41;
            }
            
            val_22 = null;
            val_22 = null;
            FillVertexHelper(vh:  Coffee.UIExtensions.BaseMeshEffect.s_VertexHelper, mesh:  val_3);
            Coffee.UIExtensions.BaseMeshEffect.s_VertexHelper.FillMesh(mesh:  val_3);
            goto label_41;
            label_34:
            val_4.Dispose();
            val_14 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  this._canvasRenderer)) == false)
            {
                goto label_44;
            }
            
            val_13 = this._textMeshPro;
            if(val_13 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(this._canvasRenderer == null)
            {
                    throw new NullReferenceException();
            }
            
            this._canvasRenderer.SetMesh(mesh:  val_13);
            val_23 = null;
            val_23 = null;
            val_14 = 0;
            this.GetComponentsInChildren<TMPro.TMP_SubMeshUI>(includeInactive:  false, result:  Coffee.UIExtensions.BaseMeshEffect.s_SubMeshUIs);
            val_13 = Coffee.UIExtensions.BaseMeshEffect.s_SubMeshUIs;
            if(val_13 == null)
            {
                    throw new NullReferenceException();
            }
            
            List.Enumerator<T> val_9 = val_13.GetEnumerator();
            val_15 = 1152921528877887776;
            label_53:
            val_14 = public System.Boolean List.Enumerator<TMPro.TMP_SubMeshUI>::MoveNext();
            if(((-1497445312) & 1) == 0)
            {
                goto label_50;
            }
            
            if(val_3 == 0)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.CanvasRenderer val_10 = val_3.canvasRenderer;
            val_14 = val_3.mesh;
            if(val_10 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_10.SetMesh(mesh:  val_14);
            goto label_53;
            label_50:
            val_14 = public System.Void List.Enumerator<TMPro.TMP_SubMeshUI>::Dispose();
            val_4.Dispose();
            val_24 = null;
            val_24 = null;
            val_13 = Coffee.UIExtensions.BaseMeshEffect.s_SubMeshUIs;
            if(val_13 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_14 = public System.Void System.Collections.Generic.List<TMPro.TMP_SubMeshUI>::Clear();
            val_13.Clear();
            label_44:
            val_25 = null;
            val_25 = null;
            val_13 = Coffee.UIExtensions.BaseMeshEffect.s_Meshes;
            if(val_13 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_13.Clear();
        }
        private void FillVertexHelper(UnityEngine.UI.VertexHelper vh, UnityEngine.Mesh mesh)
        {
            var val_3;
            var val_4;
            var val_6;
            System.Collections.Generic.List<UnityEngine.Vector3> val_7;
            var val_8;
            System.Collections.Generic.List<System.Int32> val_9;
            int val_10;
            int val_11;
            vh.Clear();
            mesh.GetVertices(vertices:  Coffee.UIExtensions.BaseMeshEffect.s_Vertices);
            mesh.GetColors(colors:  Coffee.UIExtensions.BaseMeshEffect.s_Colors);
            mesh.GetUVs(channel:  0, uvs:  Coffee.UIExtensions.BaseMeshEffect.s_Uv0);
            mesh.GetUVs(channel:  1, uvs:  Coffee.UIExtensions.BaseMeshEffect.s_Uv1);
            mesh.GetNormals(normals:  Coffee.UIExtensions.BaseMeshEffect.s_Normals);
            mesh.GetTangents(tangents:  Coffee.UIExtensions.BaseMeshEffect.s_Tangents);
            mesh.GetIndices(indices:  Coffee.UIExtensions.BaseMeshEffect.s_Indices, submesh:  0);
            val_3 = 0;
            val_4 = 32;
            goto label_5;
            label_24:
            if(val_3 >= (Coffee.UIExtensions.BaseMeshEffect.s_Vertices + 24))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_1 = Coffee.UIExtensions.BaseMeshEffect.s_Vertices + 16;
            val_1 = val_1 + 32;
            if(val_3 >= (Coffee.UIExtensions.BaseMeshEffect.s_Colors + 24))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_2 = Coffee.UIExtensions.BaseMeshEffect.s_Colors + 16;
            val_2 = val_2 + 0;
            if(val_3 >= (Coffee.UIExtensions.BaseMeshEffect.s_Uv0 + 24))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = Coffee.UIExtensions.BaseMeshEffect.s_Uv0 + 16;
            val_3 = val_3 + 0;
            if(val_3 >= (Coffee.UIExtensions.BaseMeshEffect.s_Uv1 + 24))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = Coffee.UIExtensions.BaseMeshEffect.s_Uv1 + 16;
            val_4 = val_4 + 0;
            if(val_3 >= (Coffee.UIExtensions.BaseMeshEffect.s_Normals + 24))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_5 = Coffee.UIExtensions.BaseMeshEffect.s_Normals + 16;
            val_5 = val_5 + 32;
            if(val_3 >= (Coffee.UIExtensions.BaseMeshEffect.s_Tangents + 24))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_6 = Coffee.UIExtensions.BaseMeshEffect.s_Tangents + 16;
            val_6 = val_6 + val_4;
            Coffee.UIExtensions.BaseMeshEffect.s_VertexHelper.AddVert(position:  new UnityEngine.Vector3() {x = val_1, y = (Coffee.UIExtensions.BaseMeshEffect.s_Vertices + 16 + 32) + 4, z = (Coffee.UIExtensions.BaseMeshEffect.s_Vertices + 16 + 32) + 8}, color:  new UnityEngine.Color32() {r = (Coffee.UIExtensions.BaseMeshEffect.s_Colors + 16 + 0) + 32, g = (Coffee.UIExtensions.BaseMeshEffect.s_Colors + 16 + 0) + 32, b = (Coffee.UIExtensions.BaseMeshEffect.s_Colors + 16 + 0) + 32, a = (Coffee.UIExtensions.BaseMeshEffect.s_Colors + 16 + 0) + 32}, uv0:  new UnityEngine.Vector2() {x = (Coffee.UIExtensions.BaseMeshEffect.s_Uv0 + 16 + 0) + 32, y = (Coffee.UIExtensions.BaseMeshEffect.s_Uv0 + 16 + 0) + 32 + 4}, uv1:  new UnityEngine.Vector2() {x = (Coffee.UIExtensions.BaseMeshEffect.s_Uv1 + 16 + 0) + 32, y = (Coffee.UIExtensions.BaseMeshEffect.s_Uv1 + 16 + 0) + 36}, normal:  new UnityEngine.Vector3() {x = val_5, y = (Coffee.UIExtensions.BaseMeshEffect.s_Normals + 16 + 32) + 8, z = val_6}, tangent:  new UnityEngine.Vector4() {x = (Coffee.UIExtensions.BaseMeshEffect.s_Tangents + 16 + val_4) + 4, z = (Coffee.UIExtensions.BaseMeshEffect.s_Uv1 + 16 + 0) + 32, w = ???});
            val_3 = 1;
            val_4 = 48;
            label_5:
            val_6 = null;
            val_6 = null;
            val_7 = Coffee.UIExtensions.BaseMeshEffect.s_Vertices;
            if(val_3 < (Coffee.UIExtensions.BaseMeshEffect.s_Vertices + 24))
            {
                goto label_24;
            }
            
            val_8 = 0;
            goto label_25;
            label_39:
            val_9 = Coffee.UIExtensions.BaseMeshEffect.s_Indices;
            if((Coffee.UIExtensions.BaseMeshEffect.s_Indices + 24) > val_8)
            {
                    val_10 = (Coffee.UIExtensions.BaseMeshEffect.s_Indices + 16) + 0;
            }
            else
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_9 = Coffee.UIExtensions.BaseMeshEffect.s_Indices;
                val_10 = (Coffee.UIExtensions.BaseMeshEffect.s_Indices + 16) + 0;
            }
            
            val_10 = val_10 + 32;
            if((Coffee.UIExtensions.BaseMeshEffect.s_Indices + 24) > 1)
            {
                    val_11 = (Coffee.UIExtensions.BaseMeshEffect.s_Indices + 16) + 4;
            }
            else
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_9 = Coffee.UIExtensions.BaseMeshEffect.s_Indices;
                val_11 = (Coffee.UIExtensions.BaseMeshEffect.s_Indices + 16) + 4;
            }
            
            val_11 = val_11 + 32;
            val_7 = mem[((Coffee.UIExtensions.BaseMeshEffect.s_Indices + 16 + 4) + 32)];
            val_7 = val_11;
            val_4 = 1 + 1;
            if((Coffee.UIExtensions.BaseMeshEffect.s_Indices + 24) <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_7 = Coffee.UIExtensions.BaseMeshEffect.s_Indices + 16;
            val_7 = val_7 + 8;
            vh.AddTriangle(idx0:  val_10, idx1:  val_7, idx2:  (Coffee.UIExtensions.BaseMeshEffect.s_Indices + 16 + 8) + 32);
            val_6 = null;
            val_8 = val_4 + 1;
            label_25:
            val_6 = null;
            if(val_8 < (Coffee.UIExtensions.BaseMeshEffect.s_Indices + 24))
            {
                goto label_39;
            }
        
        }
        protected BaseMeshEffect()
        {
            this._materials = new UnityEngine.Material[1];
        }
        private static BaseMeshEffect()
        {
            Coffee.UIExtensions.BaseMeshEffect.s_Uv0 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            Coffee.UIExtensions.BaseMeshEffect.s_Uv1 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            Coffee.UIExtensions.BaseMeshEffect.s_Vertices = new System.Collections.Generic.List<UnityEngine.Vector3>();
            Coffee.UIExtensions.BaseMeshEffect.s_Indices = new System.Collections.Generic.List<System.Int32>();
            Coffee.UIExtensions.BaseMeshEffect.s_Normals = new System.Collections.Generic.List<UnityEngine.Vector3>();
            Coffee.UIExtensions.BaseMeshEffect.s_Tangents = new System.Collections.Generic.List<UnityEngine.Vector4>();
            Coffee.UIExtensions.BaseMeshEffect.s_Colors = new System.Collections.Generic.List<UnityEngine.Color32>();
            Coffee.UIExtensions.BaseMeshEffect.s_VertexHelper = new UnityEngine.UI.VertexHelper();
            Coffee.UIExtensions.BaseMeshEffect.s_SubMeshUIs = new System.Collections.Generic.List<TMPro.TMP_SubMeshUI>();
            Coffee.UIExtensions.BaseMeshEffect.s_Meshes = new System.Collections.Generic.List<UnityEngine.Mesh>();
            Coffee.UIExtensions.BaseMeshEffect.s_EmptyMaterials = new UnityEngine.Material[0];
        }
    
    }

}
