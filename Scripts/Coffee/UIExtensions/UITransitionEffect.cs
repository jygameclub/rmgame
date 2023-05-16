using UnityEngine;

namespace Coffee.UIExtensions
{
    public class UITransitionEffect : UIEffectBase
    {
        // Fields
        public const string shaderName = "UI/Hidden/UI-Effect-Transition";
        private static readonly Coffee.UIExtensions.ParameterTexture _ptex;
        private Coffee.UIExtensions.UITransitionEffect.EffectMode m_EffectMode;
        private float m_EffectFactor;
        private UnityEngine.Texture m_TransitionTexture;
        private Coffee.UIExtensions.EffectArea m_EffectArea;
        private bool m_KeepAspectRatio;
        private float m_DissolveWidth;
        private float m_DissolveSoftness;
        private UnityEngine.Color m_DissolveColor;
        private bool m_PassRayOnHidden;
        private Coffee.UIExtensions.EffectPlayer m_Player;
        private Coffee.UIExtensions.MaterialCache _materialCache;
        
        // Properties
        public float effectFactor { get; set; }
        public UnityEngine.Texture transitionTexture { get; set; }
        public Coffee.UIExtensions.UITransitionEffect.EffectMode effectMode { get; }
        public bool keepAspectRatio { get; set; }
        public override Coffee.UIExtensions.ParameterTexture ptex { get; }
        public float dissolveWidth { get; set; }
        public float dissolveSoftness { get; set; }
        public UnityEngine.Color dissolveColor { get; set; }
        public float duration { get; set; }
        public bool passRayOnHidden { get; set; }
        public UnityEngine.AnimatorUpdateMode updateMode { get; set; }
        private Coffee.UIExtensions.EffectPlayer _player { get; }
        
        // Methods
        public float get_effectFactor()
        {
            return (float)this.m_EffectFactor;
        }
        public void set_effectFactor(float value)
        {
            float val_1 = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  1f);
            if((UnityEngine.Mathf.Approximately(a:  this.m_EffectFactor, b:  val_1)) != false)
            {
                    return;
            }
            
            this.m_EffectFactor = val_1;
            goto typeof(Coffee.UIExtensions.UITransitionEffect).__il2cppRuntimeField_350;
        }
        public UnityEngine.Texture get_transitionTexture()
        {
            return (UnityEngine.Texture)this.m_TransitionTexture;
        }
        public void set_transitionTexture(UnityEngine.Texture value)
        {
            var val_9;
            UnityEngine.Texture val_10;
            val_9 = this;
            val_10 = this.m_TransitionTexture;
            if(val_10 == value)
            {
                    return;
            }
            
            this.m_TransitionTexture = value;
            this.Initialize();
            if((UnityEngine.Object.op_Implicit(exists:  value)) == false)
            {
                    return;
            }
            
            val_9 = ???;
            val_10 = ???;
            goto typeof(Coffee.UIExtensions.UITransitionEffect).__il2cppRuntimeField_340;
        }
        public Coffee.UIExtensions.UITransitionEffect.EffectMode get_effectMode()
        {
            return (EffectMode)this.m_EffectMode;
        }
        public bool get_keepAspectRatio()
        {
            return (bool)this.m_KeepAspectRatio;
        }
        public void set_keepAspectRatio(bool value)
        {
            var val_1 = (this.m_KeepAspectRatio == true) ? 1 : 0;
            val_1 = val_1 ^ value;
            if(val_1 == false)
            {
                    return;
            }
            
            this.m_KeepAspectRatio = value;
            this.Initialize();
            this.LateUpdate();
        }
        public override Coffee.UIExtensions.ParameterTexture get_ptex()
        {
            null = null;
            return (Coffee.UIExtensions.ParameterTexture)Coffee.UIExtensions.UITransitionEffect._ptex;
        }
        public float get_dissolveWidth()
        {
            return (float)this.m_DissolveWidth;
        }
        public void set_dissolveWidth(float value)
        {
            float val_1 = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  1f);
            if((UnityEngine.Mathf.Approximately(a:  this.m_DissolveWidth, b:  val_1)) != false)
            {
                    return;
            }
            
            this.m_DissolveWidth = val_1;
            goto typeof(Coffee.UIExtensions.UITransitionEffect).__il2cppRuntimeField_350;
        }
        public float get_dissolveSoftness()
        {
            return (float)this.m_DissolveSoftness;
        }
        public void set_dissolveSoftness(float value)
        {
            float val_1 = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  1f);
            if((UnityEngine.Mathf.Approximately(a:  this.m_DissolveSoftness, b:  val_1)) != false)
            {
                    return;
            }
            
            this.m_DissolveSoftness = val_1;
            goto typeof(Coffee.UIExtensions.UITransitionEffect).__il2cppRuntimeField_350;
        }
        public UnityEngine.Color get_dissolveColor()
        {
            return new UnityEngine.Color() {r = this.m_DissolveColor};
        }
        public void set_dissolveColor(UnityEngine.Color value)
        {
            float val_9;
            float val_10;
            val_9 = value.g;
            val_10 = value.a;
            if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = this.m_DissolveColor, g = value.g, b = value.b, a = value.a}, rhs:  new UnityEngine.Color() {r = value.r, g = val_9, b = value.b, a = val_10})) == false)
            {
                    return;
            }
            
            this.m_DissolveColor = value;
            mem[1152921528917611940] = val_9;
            mem[1152921528917611944] = value.b;
            mem[1152921528917611948] = val_10;
            val_10 = ???;
            val_9 = ???;
            goto typeof(Coffee.UIExtensions.UITransitionEffect).__il2cppRuntimeField_350;
        }
        public float get_duration()
        {
            Coffee.UIExtensions.EffectPlayer val_1 = this._player;
            return (float)val_1.duration;
        }
        public void set_duration(float value)
        {
            this._player = UnityEngine.Mathf.Max(a:  value, b:  0.1f);
        }
        public bool get_passRayOnHidden()
        {
            return (bool)this.m_PassRayOnHidden;
        }
        public void set_passRayOnHidden(bool value)
        {
            this.m_PassRayOnHidden = value;
        }
        public UnityEngine.AnimatorUpdateMode get_updateMode()
        {
            Coffee.UIExtensions.EffectPlayer val_1 = this._player;
            return (UnityEngine.AnimatorUpdateMode)val_1.updateMode;
        }
        public void set_updateMode(UnityEngine.AnimatorUpdateMode value)
        {
            this._player = value;
        }
        public void Show()
        {
            this._player = 0;
            var val_4 = this._player;
            System.Action<System.Single> val_3 = new System.Action<System.Single>(object:  this, method:  System.Void Coffee.UIExtensions.UITransitionEffect::<Show>b__44_0(float f));
            val_4 = 0f;
            val_4 = true;
            if(val_3 == null)
            {
                    return;
            }
            
            val_4 = val_3;
        }
        public void Hide()
        {
            this._player = 0;
            var val_4 = this._player;
            System.Action<System.Single> val_3 = new System.Action<System.Single>(object:  this, method:  System.Void Coffee.UIExtensions.UITransitionEffect::<Hide>b__45_0(float f));
            val_4 = 0f;
            val_4 = true;
            if(val_3 == null)
            {
                    return;
            }
            
            val_4 = val_3;
        }
        public override void ModifyMaterial()
        {
            object val_10;
            UnityEngine.Texture val_11;
            Coffee.UIExtensions.MaterialCache val_12;
            val_10 = this;
            if((UnityEngine.Object.op_Implicit(exists:  this.m_TransitionTexture)) != false)
            {
                    val_11 = this.m_TransitionTexture;
                int val_2 = val_11.GetInstanceID();
            }
            else
            {
                    val_11 = 0;
            }
            
            if(this._materialCache != null)
            {
                    if((this._materialCache.<hash>k__BackingField) == 8589934592)
            {
                    if(this.isActiveAndEnabled != false)
            {
                    if((UnityEngine.Object.op_Implicit(exists:  X21)) == true)
            {
                goto label_11;
            }
            
            }
            
            }
            
                val_12 = this._materialCache;
                Coffee.UIExtensions.MaterialCache.Unregister(cache:  val_12);
                this._materialCache = 0;
            }
            
            label_11:
            if((this.isActiveAndEnabled == false) || ((UnityEngine.Object.op_Implicit(exists:  val_12)) == false))
            {
                goto label_17;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.m_TransitionTexture)) == false)
            {
                goto label_26;
            }
            
            if((this._materialCache == null) || ((this._materialCache.<hash>k__BackingField) != 8589934592))
            {
                goto label_22;
            }
            
            goto label_23;
            label_17:
            this.Initialize();
            label_26:
            label_31:
            val_10 = ???;
            goto typeof(Coffee.UIExtensions.UITransitionEffect).__il2cppRuntimeField_340;
            label_22:
            this._materialCache = Coffee.UIExtensions.MaterialCache.Register(hash:  8589934592, texture:  this, onCreateMaterial:  new System.Func<UnityEngine.Material>(object:  this, method:  UnityEngine.Material Coffee.UIExtensions.UITransitionEffect::<ModifyMaterial>b__46_0()));
            label_23:
            this.Initialize();
            goto label_31;
        }
        public override void ModifyMesh(UnityEngine.UI.VertexHelper vh)
        {
            float val_9;
            float val_10;
            float val_11;
            float val_17;
            float val_18;
            var val_23;
            float val_24;
            var val_25;
            if(this.isActiveAndEnabled == false)
            {
                    return;
            }
            
            if(this.isTMPro != false)
            {
                    val_23 = 1;
            }
            else
            {
                    this.Initialize();
                val_23 = 0;
            }
            
            val_24 = -1f;
            if(this.m_KeepAspectRatio != false)
            {
                    if((UnityEngine.Object.op_Implicit(exists:  this.m_TransitionTexture)) != false)
            {
                    val_25 = this.m_TransitionTexture;
                val_24 = (float)val_25 / (float)this.m_TransitionTexture;
            }
            
            }
            
            this.Initialize();
            UnityEngine.Rect val_5 = this.rect;
            UnityEngine.Rect val_6 = Coffee.UIExtensions.EffectAreaExtensions.GetEffectArea(area:  this.m_EffectArea, vh:  vh, rectangle:  new UnityEngine.Rect() {m_XMin = val_5.m_XMin, m_YMin = val_5.m_YMin, m_Width = val_5.m_Width, m_Height = val_5.m_Height}, aspectRatio:  val_24);
            int val_8 = vh.currentVertCount;
            if(val_8 < 1)
            {
                    return;
            }
            
            do
            {
                vh.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()}, i:  0);
                UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_9, y = val_10, z = val_11});
                Coffee.UIExtensions.EffectAreaExtensions.GetPositionFactor(area:  this.m_EffectArea, index:  0, rect:  new UnityEngine.Rect() {m_XMin = val_6.m_XMin, m_YMin = val_6.m_YMin, m_Width = val_6.m_Width, m_Height = val_6.m_Height}, position:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, isText:  null, isTMPro:  this.isTMPro, x: out  float val_15 = -3.484036E-14f, y: out  float val_16 = -3.484035E-14f);
                UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  Packer.ToFloat(x:  val_17, y:  val_18), y:  Packer.ToFloat(x:  0f, y:  0f, z:  this.GetNormalizedIndex(target:  this)));
                val_17 = val_21.x;
                vh.SetUIVertex(vertex:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()}, i:  0);
                val_25 = 0 + 1;
            }
            while(val_8 != val_25);
        
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this._player.OnEnable(callback:  0);
            this._player = 0;
        }
        protected override void OnDisable()
        {
            Coffee.UIExtensions.MaterialCache.Unregister(cache:  this._materialCache);
            this._materialCache = 0;
            this.OnDisable();
            this._player.OnDisable();
        }
        protected override void SetDirty()
        {
            this.Initialize();
            this.RegisterMaterial(mat:  this);
            this.SetData(target:  this, channelId:  0, value:  this.m_EffectFactor);
            if(this.m_EffectMode == 3)
            {
                    this.SetData(target:  this, channelId:  1, value:  this.m_DissolveWidth);
                this.SetData(target:  this, channelId:  2, value:  this.m_DissolveSoftness);
                this.SetData(target:  this, channelId:  4, value:  this.m_DissolveColor);
                this.SetData(target:  this, channelId:  5, value:  this.m_DissolveColor);
                this.SetData(target:  this, channelId:  6, value:  this.m_DissolveColor);
            }
            
            if(this.m_PassRayOnHidden == false)
            {
                    return;
            }
            
            this.Initialize();
            var val_1 = (this.m_EffectFactor > 0f) ? 1 : 0;
            this.SetVerticesDirty();
        }
        private Coffee.UIExtensions.EffectPlayer get__player()
        {
            Coffee.UIExtensions.EffectPlayer val_2 = this.m_Player;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            Coffee.UIExtensions.EffectPlayer val_1 = null;
            val_2 = val_1;
            .duration = 1f;
            val_1 = new Coffee.UIExtensions.EffectPlayer();
            this.m_Player = val_2;
            return val_2;
        }
        public UITransitionEffect()
        {
            this.m_DissolveWidth = 0.5f;
            this.m_DissolveSoftness = 0f;
            this.m_EffectMode = 2;
            this.m_DissolveColor = 0;
        }
        private static UITransitionEffect()
        {
            Coffee.UIExtensions.UITransitionEffect._ptex = new Coffee.UIExtensions.ParameterTexture(channels:  8, instanceLimit:  128, propertyName:  "_ParamTex");
        }
        private void <Show>b__44_0(float f)
        {
            this.effectFactor = f;
        }
        private void <Hide>b__45_0(float f)
        {
            f = 1f - f;
            this.effectFactor = f;
        }
        private UnityEngine.Material <ModifyMaterial>b__46_0()
        {
            UnityEngine.Material val_1 = new UnityEngine.Material(source:  X21);
            val_1.name = val_1.name + "_" + this.m_TransitionTexture.name;
            val_1.SetTexture(name:  "_TransitionTexture", value:  this.m_TransitionTexture);
            return val_1;
        }
    
    }

}
