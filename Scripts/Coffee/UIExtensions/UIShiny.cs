using UnityEngine;

namespace Coffee.UIExtensions
{
    public class UIShiny : UIEffectBase
    {
        // Fields
        public const string shaderName = "UI/Hidden/UI-Effect-Shiny";
        private static readonly Coffee.UIExtensions.ParameterTexture _ptex;
        private float m_EffectFactor;
        private float m_Width;
        private float m_Rotation;
        private float m_Softness;
        private float m_Brightness;
        private float m_Gloss;
        protected Coffee.UIExtensions.EffectArea m_EffectArea;
        private Coffee.UIExtensions.EffectPlayer m_Player;
        private bool m_Play;
        private bool m_Loop;
        private float m_Duration;
        private float m_LoopDelay;
        private UnityEngine.AnimatorUpdateMode m_UpdateMode;
        private float _lastRotation;
        
        // Properties
        public override UnityEngine.AdditionalCanvasShaderChannels requiredChannels { get; }
        public float location { get; set; }
        public float effectFactor { get; set; }
        public float width { get; set; }
        public float softness { get; set; }
        public float alpha { get; set; }
        public float brightness { get; set; }
        public float highlight { get; set; }
        public float gloss { get; set; }
        public float rotation { get; set; }
        public Coffee.UIExtensions.EffectArea effectArea { get; set; }
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
            goto typeof(Coffee.UIExtensions.UIShiny).__il2cppRuntimeField_350;
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
            goto typeof(Coffee.UIExtensions.UIShiny).__il2cppRuntimeField_350;
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
            goto typeof(Coffee.UIExtensions.UIShiny).__il2cppRuntimeField_350;
        }
        public float get_softness()
        {
            return (float)this.m_Softness;
        }
        public void set_softness(float value)
        {
            float val_1 = UnityEngine.Mathf.Clamp(value:  value, min:  0.01f, max:  1f);
            if((UnityEngine.Mathf.Approximately(a:  this.m_Softness, b:  val_1)) != false)
            {
                    return;
            }
            
            this.m_Softness = val_1;
            goto typeof(Coffee.UIExtensions.UIShiny).__il2cppRuntimeField_350;
        }
        public float get_alpha()
        {
            return (float)this.m_Brightness;
        }
        public void set_alpha(float value)
        {
            float val_1 = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  1f);
            if((UnityEngine.Mathf.Approximately(a:  this.m_Brightness, b:  val_1)) != false)
            {
                    return;
            }
            
            this.m_Brightness = val_1;
            goto typeof(Coffee.UIExtensions.UIShiny).__il2cppRuntimeField_350;
        }
        public float get_brightness()
        {
            return (float)this.m_Brightness;
        }
        public void set_brightness(float value)
        {
            float val_1 = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  1f);
            if((UnityEngine.Mathf.Approximately(a:  this.m_Brightness, b:  val_1)) != false)
            {
                    return;
            }
            
            this.m_Brightness = val_1;
            goto typeof(Coffee.UIExtensions.UIShiny).__il2cppRuntimeField_350;
        }
        public float get_highlight()
        {
            return (float)this.m_Gloss;
        }
        public void set_highlight(float value)
        {
            float val_1 = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  1f);
            if((UnityEngine.Mathf.Approximately(a:  this.m_Gloss, b:  val_1)) != false)
            {
                    return;
            }
            
            this.m_Gloss = val_1;
            goto typeof(Coffee.UIExtensions.UIShiny).__il2cppRuntimeField_350;
        }
        public float get_gloss()
        {
            return (float)this.m_Gloss;
        }
        public void set_gloss(float value)
        {
            float val_1 = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  1f);
            if((UnityEngine.Mathf.Approximately(a:  this.m_Gloss, b:  val_1)) != false)
            {
                    return;
            }
            
            this.m_Gloss = val_1;
            goto typeof(Coffee.UIExtensions.UIShiny).__il2cppRuntimeField_350;
        }
        public float get_rotation()
        {
            return (float)this.m_Rotation;
        }
        public void set_rotation(float value)
        {
            if((UnityEngine.Mathf.Approximately(a:  this.m_Rotation, b:  value)) != false)
            {
                    return;
            }
            
            this._lastRotation = value;
            this.m_Rotation = value;
            this.SetVerticesDirty();
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
            return (Coffee.UIExtensions.ParameterTexture)Coffee.UIExtensions.UIShiny._ptex;
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this._player.OnEnable(callback:  new System.Action<System.Single>(object:  this, method:  System.Void Coffee.UIExtensions.UIShiny::<OnEnable>b__64_0(float f)));
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            this._player.OnDisable();
        }
        public override void ModifyMesh(UnityEngine.UI.VertexHelper vh)
        {
            float val_11;
            float val_12;
            float val_13;
            float val_18;
            float val_19;
            var val_25;
            float val_26;
            if(this.isActiveAndEnabled == false)
            {
                    return;
            }
            
            if(this.isTMPro != false)
            {
                    val_25 = 1;
            }
            else
            {
                    this.Initialize();
                val_25 = 0;
            }
            
            float val_4 = this.GetNormalizedIndex(target:  this);
            this.Initialize();
            UnityEngine.Rect val_5 = this.rect;
            UnityEngine.Rect val_6 = Coffee.UIExtensions.EffectAreaExtensions.GetEffectArea(area:  this.m_EffectArea, vh:  vh, rectangle:  new UnityEngine.Rect() {m_XMin = val_5.m_XMin, m_YMin = val_5.m_YMin, m_Width = val_5.m_Width, m_Height = val_5.m_Height}, aspectRatio:  -1f);
            float val_7 = this.m_Rotation * 0.01745329f;
            float val_24 = val_7;
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_24, y:  val_7);
            val_24 = val_24 / val_24;
            val_24 = val_8.x * val_24;
            UnityEngine.Vector2 val_9 = val_24.normalized;
            val_26 = val_9.y;
            if(vh.currentVertCount < 1)
            {
                    return;
            }
            
            var val_25 = 0;
            do
            {
                vh.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()}, i:  0);
                UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_11, y = val_12, z = val_13});
                val_26 = val_14.y;
                Coffee.UIExtensions.EffectAreaExtensions.GetNormalizedFactor(area:  this.m_EffectArea, index:  0, matrix:  new Coffee.UIExtensions.Matrix2x3() {m00 = 0f, m01 = 0f, m02 = 0f, m10 = 0f, m11 = 0f, m12 = 0f}, position:  new UnityEngine.Vector2() {x = val_14.x, y = val_26}, isText:  null, nomalizedPos: out  new UnityEngine.Vector2() {x = 0f, y = 0f});
                if(this.isTMPro != false)
            {
                    UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  Packer.ToFloat(x:  0f, y:  val_4), y:  0f);
            }
            else
            {
                    UnityEngine.Vector2 val_22 = new UnityEngine.Vector2(x:  Packer.ToFloat(x:  val_18, y:  val_19), y:  Packer.ToFloat(x:  0f, y:  val_4));
                val_18 = val_22.x;
            }
            
                vh.SetUIVertex(vertex:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()}, i:  0);
                val_25 = val_25 + 1;
            }
            while(val_25 < vh.currentVertCount);
        
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
        protected override void SetDirty()
        {
            UnityEngine.Material[] val_1 = this.materials;
            int val_4 = val_1.Length;
            if(val_4 >= 1)
            {
                    var val_5 = 0;
                val_4 = val_4 & 4294967295;
                do
            {
                this.RegisterMaterial(mat:  1152921506438889632);
                val_5 = val_5 + 1;
            }
            while(val_5 < (val_1.Length << ));
            
            }
            
            this.SetData(target:  this, channelId:  0, value:  this.m_EffectFactor);
            this.SetData(target:  this, channelId:  1, value:  this.m_Width);
            this.SetData(target:  this, channelId:  2, value:  this.m_Softness);
            this.SetData(target:  this, channelId:  3, value:  this.m_Brightness);
            this.SetData(target:  this, channelId:  4, value:  this.m_Gloss);
            if((UnityEngine.Mathf.Approximately(a:  this._lastRotation, b:  this.m_Rotation)) == true)
            {
                    return;
            }
            
            this.Initialize();
            if((UnityEngine.Object.op_Implicit(exists:  val_1)) == false)
            {
                    return;
            }
            
            this._lastRotation = this.m_Rotation;
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
        public UIShiny()
        {
            this.m_Width = 0.25f;
            this.m_Softness = 1;
            this.m_Gloss = 1f;
            this.m_Duration = 1;
        }
        private static UIShiny()
        {
            Coffee.UIExtensions.UIShiny._ptex = new Coffee.UIExtensions.ParameterTexture(channels:  8, instanceLimit:  128, propertyName:  "_ParamTex");
        }
        private void <OnEnable>b__64_0(float f)
        {
            this.effectFactor = f;
        }
    
    }

}
