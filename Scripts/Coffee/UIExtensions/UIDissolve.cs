using UnityEngine;

namespace Coffee.UIExtensions
{
    public class UIDissolve : UIEffectBase
    {
        // Fields
        public const string shaderName = "UI/Hidden/UI-Effect-Dissolve";
        private static readonly Coffee.UIExtensions.ParameterTexture _ptex;
        private float m_EffectFactor;
        private float m_Width;
        private float m_Softness;
        private UnityEngine.Color m_Color;
        private Coffee.UIExtensions.ColorMode m_ColorMode;
        private UnityEngine.Texture m_NoiseTexture;
        protected Coffee.UIExtensions.EffectArea m_EffectArea;
        private bool m_KeepAspectRatio;
        private Coffee.UIExtensions.EffectPlayer m_Player;
        private float m_Duration;
        private UnityEngine.AnimatorUpdateMode m_UpdateMode;
        private Coffee.UIExtensions.MaterialCache _materialCache;
        
        // Properties
        public override UnityEngine.AdditionalCanvasShaderChannels requiredChannels { get; }
        public float location { get; set; }
        public float effectFactor { get; set; }
        public float width { get; set; }
        public float softness { get; set; }
        public UnityEngine.Color color { get; set; }
        public UnityEngine.Texture noiseTexture { get; set; }
        public Coffee.UIExtensions.EffectArea effectArea { get; set; }
        public bool keepAspectRatio { get; set; }
        public Coffee.UIExtensions.ColorMode colorMode { get; }
        public bool play { get; set; }
        public bool loop { get; set; }
        public float duration { get; set; }
        public float loopDelay { get; set; }
        public UnityEngine.AnimatorUpdateMode updateMode { get; set; }
        public override Coffee.UIExtensions.ParameterTexture ptex { get; }
        private Coffee.UIExtensions.EffectPlayer _player { get; }
        
        // Methods
        public override UnityEngine.AdditionalCanvasShaderChannels get_requiredChannels()
        {
            return (UnityEngine.AdditionalCanvasShaderChannels)(this.isTMPro != true) ? 3 : (0 + 1);
        }
        public float get_location()
        {
            return (float)this.m_EffectFactor;
        }
        public void set_location(float value)
        {
            float val_1 = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  1f);
            if((UnityEngine.Mathf.Approximately(a:  this.m_EffectFactor, b:  val_1)) != false)
            {
                    return;
            }
            
            this.m_EffectFactor = val_1;
            goto typeof(Coffee.UIExtensions.UIDissolve).__il2cppRuntimeField_350;
        }
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
            goto typeof(Coffee.UIExtensions.UIDissolve).__il2cppRuntimeField_350;
        }
        public float get_width()
        {
            return (float)this.m_Width;
        }
        public void set_width(float value)
        {
            float val_1 = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  1f);
            if((UnityEngine.Mathf.Approximately(a:  this.m_Width, b:  val_1)) != false)
            {
                    return;
            }
            
            this.m_Width = val_1;
            goto typeof(Coffee.UIExtensions.UIDissolve).__il2cppRuntimeField_350;
        }
        public float get_softness()
        {
            return (float)this.m_Softness;
        }
        public void set_softness(float value)
        {
            float val_1 = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  1f);
            if((UnityEngine.Mathf.Approximately(a:  this.m_Softness, b:  val_1)) != false)
            {
                    return;
            }
            
            this.m_Softness = val_1;
            goto typeof(Coffee.UIExtensions.UIDissolve).__il2cppRuntimeField_350;
        }
        public UnityEngine.Color get_color()
        {
            return new UnityEngine.Color() {r = this.m_Color};
        }
        public void set_color(UnityEngine.Color value)
        {
            float val_9;
            float val_10;
            val_9 = value.g;
            val_10 = value.a;
            if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = this.m_Color, g = value.g, b = value.b, a = value.a}, rhs:  new UnityEngine.Color() {r = value.r, g = val_9, b = value.b, a = val_10})) == false)
            {
                    return;
            }
            
            this.m_Color = value;
            mem[1152921528881499164] = val_9;
            mem[1152921528881499168] = value.b;
            mem[1152921528881499172] = val_10;
            val_10 = ???;
            val_9 = ???;
            goto typeof(Coffee.UIExtensions.UIDissolve).__il2cppRuntimeField_350;
        }
        public UnityEngine.Texture get_noiseTexture()
        {
            if(this.m_NoiseTexture == null)
            {
                    return this.material.GetTexture(name:  "_NoiseTex");
            }
            
            return (UnityEngine.Texture)this.m_NoiseTexture;
        }
        public void set_noiseTexture(UnityEngine.Texture value)
        {
            var val_9;
            UnityEngine.Texture val_10;
            val_9 = this;
            val_10 = this.m_NoiseTexture;
            if(val_10 == value)
            {
                    return;
            }
            
            this.m_NoiseTexture = value;
            this.Initialize();
            if((UnityEngine.Object.op_Implicit(exists:  value)) == false)
            {
                    return;
            }
            
            val_9 = ???;
            val_10 = ???;
            goto typeof(Coffee.UIExtensions.UIDissolve).__il2cppRuntimeField_340;
        }
        public Coffee.UIExtensions.EffectArea get_effectArea()
        {
            return (Coffee.UIExtensions.EffectArea)this.m_EffectArea;
        }
        public void set_effectArea(Coffee.UIExtensions.EffectArea value)
        {
            if(this.m_EffectArea == value)
            {
                    return;
            }
            
            this.m_EffectArea = value;
            this.SetVerticesDirty();
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
            this.SetVerticesDirty();
        }
        public Coffee.UIExtensions.ColorMode get_colorMode()
        {
            return (Coffee.UIExtensions.ColorMode)this.m_ColorMode;
        }
        public bool get_play()
        {
            Coffee.UIExtensions.EffectPlayer val_1 = this._player;
            return (bool)val_1.play;
        }
        public void set_play(bool value)
        {
            this._player = value;
        }
        public bool get_loop()
        {
            Coffee.UIExtensions.EffectPlayer val_1 = this._player;
            return (bool)val_1.loop;
        }
        public void set_loop(bool value)
        {
            this._player = value;
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
        public float get_loopDelay()
        {
            Coffee.UIExtensions.EffectPlayer val_1 = this._player;
            return (float)val_1.loopDelay;
        }
        public void set_loopDelay(float value)
        {
            this._player = UnityEngine.Mathf.Max(a:  value, b:  0f);
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
        public override Coffee.UIExtensions.ParameterTexture get_ptex()
        {
            null = null;
            return (Coffee.UIExtensions.ParameterTexture)Coffee.UIExtensions.UIDissolve._ptex;
        }
        public override void ModifyMaterial()
        {
            UnityEngine.Texture val_11;
            Coffee.UIExtensions.MaterialCache val_12;
            UnityEngine.Material val_13;
            var val_14;
            if(this.isTMPro != false)
            {
                    return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.m_NoiseTexture)) != false)
            {
                    val_11 = this.m_NoiseTexture;
                int val_3 = val_11.GetInstanceID();
            }
            else
            {
                    val_11 = 0;
            }
            
            if(this._materialCache != null)
            {
                    if((this._materialCache.<hash>k__BackingField) == 4294967296)
            {
                    if(this.isActiveAndEnabled != false)
            {
                    if((UnityEngine.Object.op_Implicit(exists:  X21)) == true)
            {
                goto label_12;
            }
            
            }
            
            }
            
                val_12 = this._materialCache;
                Coffee.UIExtensions.MaterialCache.Unregister(cache:  val_12);
                this._materialCache = 0;
            }
            
            label_12:
            if((this.isActiveAndEnabled == false) || ((UnityEngine.Object.op_Implicit(exists:  val_12)) == false))
            {
                goto label_18;
            }
            
            val_12 = this.m_NoiseTexture;
            if((UnityEngine.Object.op_Implicit(exists:  val_12)) == false)
            {
                goto label_26;
            }
            
            if((this._materialCache == null) || ((this._materialCache.<hash>k__BackingField) != 4294967296))
            {
                goto label_23;
            }
            
            val_13 = this._materialCache.<material>k__BackingField;
            val_14 = public System.Void Coffee.UIExtensions.BaseMeshEffect::set_material(UnityEngine.Material value);
            goto label_24;
            label_18:
            val_13 = 0;
            val_14 = public System.Void Coffee.UIExtensions.BaseMeshEffect::set_material(UnityEngine.Material value);
            goto label_25;
            label_23:
            System.Func<UnityEngine.Material> val_9 = null;
            val_12 = val_9;
            val_9 = new System.Func<UnityEngine.Material>(object:  this, method:  UnityEngine.Material Coffee.UIExtensions.UIDissolve::<ModifyMaterial>b__58_0());
            this._materialCache = Coffee.UIExtensions.MaterialCache.Register(hash:  4294967296, texture:  this, onCreateMaterial:  val_9);
            val_13 = val_10.<material>k__BackingField;
            label_26:
            val_14 = public System.Void Coffee.UIExtensions.BaseMeshEffect::set_material(UnityEngine.Material value);
            label_24:
            label_25:
            this.material = val_13;
        }
        public override void ModifyMesh(UnityEngine.UI.VertexHelper vh)
        {
            float val_10;
            float val_11;
            float val_12;
            float val_21;
            float val_22;
            var val_27;
            float val_28;
            var val_29;
            if(this.isActiveAndEnabled == false)
            {
                    return;
            }
            
            if(this.isTMPro != false)
            {
                    val_27 = 1;
            }
            else
            {
                    this.Initialize();
                val_27 = 0;
            }
            
            float val_4 = this.GetNormalizedIndex(target:  this);
            UnityEngine.Texture val_5 = this.noiseTexture;
            val_28 = -1f;
            if(this.m_KeepAspectRatio != false)
            {
                    if((UnityEngine.Object.op_Implicit(exists:  val_5)) != false)
            {
                    val_29 = val_5;
                val_28 = (float)val_29 / (float)val_5;
            }
            
            }
            
            this.Initialize();
            UnityEngine.Rect val_7 = this.rect;
            UnityEngine.Rect val_8 = Coffee.UIExtensions.EffectAreaExtensions.GetEffectArea(area:  this.m_EffectArea, vh:  vh, rectangle:  new UnityEngine.Rect() {m_XMin = val_7.m_XMin, m_YMin = val_7.m_YMin, m_Width = val_7.m_Width, m_Height = val_7.m_Height}, aspectRatio:  val_28);
            int val_9 = vh.currentVertCount;
            if(val_9 < 1)
            {
                    return;
            }
            
            do
            {
                vh.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()}, i:  0);
                UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_12});
                Coffee.UIExtensions.EffectAreaExtensions.GetPositionFactor(area:  this.m_EffectArea, index:  0, rect:  new UnityEngine.Rect() {m_XMin = val_8.m_XMin, m_YMin = val_8.m_YMin, m_Width = val_8.m_Width, m_Height = val_8.m_Height}, position:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y}, isText:  null, isTMPro:  this.isTMPro, x: out  float val_16 = -1.886628E-15f, y: out  float val_17 = -1.886627E-15f);
                if(this.isTMPro != false)
            {
                    UnityEngine.Vector2 val_20 = new UnityEngine.Vector2(x:  Packer.ToFloat(x:  0f, y:  0f, z:  val_4), y:  0f);
            }
            else
            {
                    UnityEngine.Vector2 val_25 = new UnityEngine.Vector2(x:  Packer.ToFloat(x:  val_21, y:  val_22), y:  Packer.ToFloat(x:  0f, y:  0f, z:  val_4));
                val_21 = val_25.x;
            }
            
                vh.SetUIVertex(vertex:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()}, i:  0);
                val_29 = 0 + 1;
            }
            while(val_9 != val_29);
        
        }
        protected override void SetDirty()
        {
            int val_2 = val_1.Length;
            if(val_2 >= 1)
            {
                    var val_3 = 0;
                val_2 = val_2 & 4294967295;
                do
            {
                this.RegisterMaterial(mat:  1152921506438889632);
                val_3 = val_3 + 1;
            }
            while(val_3 < (val_1.Length << ));
            
            }
            
            this.SetData(target:  this, channelId:  0, value:  this.m_EffectFactor);
            this.SetData(target:  this, channelId:  1, value:  this.m_Width);
            this.SetData(target:  this, channelId:  2, value:  this.m_Softness);
            this.SetData(target:  this, channelId:  4, value:  this.m_Color);
            this.SetData(target:  this, channelId:  5, value:  this.m_Color);
            this.SetData(target:  this, channelId:  6, value:  this.m_Color);
        }
        public void Play()
        {
            Coffee.UIExtensions.EffectPlayer val_1 = this._player;
            val_1 = 0;
            val_1 = 1;
        }
        public void Stop()
        {
            this._player = 0;
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this._player.OnEnable(callback:  new System.Action<System.Single>(object:  this, method:  System.Void Coffee.UIExtensions.UIDissolve::<OnEnable>b__63_0(float f)));
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            Coffee.UIExtensions.MaterialCache.Unregister(cache:  this._materialCache);
            this._materialCache = 0;
            this._player.OnDisable();
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
        public UIDissolve()
        {
            this.m_EffectFactor = 0.5f;
            this.m_Width = 0f;
            this.m_Softness = 0.5f;
            this.m_ColorMode = 2;
            this.m_Duration = 1f;
            this.m_Color = 0;
        }
        private static UIDissolve()
        {
            Coffee.UIExtensions.UIDissolve._ptex = new Coffee.UIExtensions.ParameterTexture(channels:  8, instanceLimit:  128, propertyName:  "_ParamTex");
        }
        private UnityEngine.Material <ModifyMaterial>b__58_0()
        {
            UnityEngine.Material val_1 = new UnityEngine.Material(source:  X21);
            val_1.name = val_1.name + "_" + this.m_NoiseTexture.name;
            val_1.SetTexture(name:  "_NoiseTex", value:  this.m_NoiseTexture);
            return val_1;
        }
        private void <OnEnable>b__63_0(float f)
        {
            this.effectFactor = f;
        }
    
    }

}
