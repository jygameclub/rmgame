using UnityEngine;

namespace Coffee.UIExtensions
{
    public class UIEffectCapturedImage : RawImage
    {
        // Fields
        public const string shaderName = "UI/Hidden/UI-EffectCapture";
        private float m_EffectFactor;
        private float m_ColorFactor;
        private float m_BlurFactor;
        private Coffee.UIExtensions.EffectMode m_EffectMode;
        private Coffee.UIExtensions.ColorMode m_ColorMode;
        private Coffee.UIExtensions.BlurMode m_BlurMode;
        private UnityEngine.Color m_EffectColor;
        private Coffee.UIExtensions.UIEffectCapturedImage.DesamplingRate m_DesamplingRate;
        private Coffee.UIExtensions.UIEffectCapturedImage.DesamplingRate m_ReductionRate;
        private UnityEngine.FilterMode m_FilterMode;
        private UnityEngine.Material m_EffectMaterial;
        private int m_BlurIterations;
        private bool m_FitToScreen;
        private bool m_CaptureOnEnable;
        private bool m_ImmediateCapturing;
        private UnityEngine.RenderTexture _rt;
        private static int s_CopyId;
        private static int s_EffectId1;
        private static int s_EffectId2;
        private static int s_EffectFactorId;
        private static int s_ColorFactorId;
        private static UnityEngine.Rendering.CommandBuffer s_CommandBuffer;
        
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
        public virtual UnityEngine.Material effectMaterial { get; }
        public Coffee.UIExtensions.UIEffectCapturedImage.DesamplingRate desamplingRate { get; set; }
        public Coffee.UIExtensions.UIEffectCapturedImage.DesamplingRate reductionRate { get; set; }
        public UnityEngine.FilterMode filterMode { get; set; }
        public UnityEngine.RenderTexture capturedTexture { get; }
        public int iterations { get; set; }
        public int blurIterations { get; set; }
        public bool keepCanvasSize { get; set; }
        public bool fitToScreen { get; set; }
        public UnityEngine.RenderTexture targetTexture { get; set; }
        public bool captureOnEnable { get; set; }
        public bool immediateCapturing { get; set; }
        
        // Methods
        public float get_toneLevel()
        {
            return (float)this.m_EffectFactor;
        }
        public void set_toneLevel(float value)
        {
            this.m_EffectFactor = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  1f);
        }
        public float get_effectFactor()
        {
            return (float)this.m_EffectFactor;
        }
        public void set_effectFactor(float value)
        {
            this.m_EffectFactor = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  1f);
        }
        public float get_colorFactor()
        {
            return (float)this.m_ColorFactor;
        }
        public void set_colorFactor(float value)
        {
            this.m_ColorFactor = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  1f);
        }
        public float get_blur()
        {
            return (float)this.m_BlurFactor;
        }
        public void set_blur(float value)
        {
            this.m_BlurFactor = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  4f);
        }
        public float get_blurFactor()
        {
            return (float)this.m_BlurFactor;
        }
        public void set_blurFactor(float value)
        {
            this.m_BlurFactor = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  4f);
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
            return new UnityEngine.Color() {r = this.m_EffectColor};
        }
        public void set_effectColor(UnityEngine.Color value)
        {
            this.m_EffectColor = value;
            mem[1152921528909002996] = value.g;
            mem[1152921528909003000] = value.b;
            mem[1152921528909003004] = value.a;
        }
        public virtual UnityEngine.Material get_effectMaterial()
        {
            return (UnityEngine.Material)this.m_EffectMaterial;
        }
        public Coffee.UIExtensions.UIEffectCapturedImage.DesamplingRate get_desamplingRate()
        {
            return (DesamplingRate)this.m_DesamplingRate;
        }
        public void set_desamplingRate(Coffee.UIExtensions.UIEffectCapturedImage.DesamplingRate value)
        {
            this.m_DesamplingRate = value;
        }
        public Coffee.UIExtensions.UIEffectCapturedImage.DesamplingRate get_reductionRate()
        {
            return (DesamplingRate)this.m_ReductionRate;
        }
        public void set_reductionRate(Coffee.UIExtensions.UIEffectCapturedImage.DesamplingRate value)
        {
            this.m_ReductionRate = value;
        }
        public UnityEngine.FilterMode get_filterMode()
        {
            return (UnityEngine.FilterMode)this.m_FilterMode;
        }
        public void set_filterMode(UnityEngine.FilterMode value)
        {
            this.m_FilterMode = value;
        }
        public UnityEngine.RenderTexture get_capturedTexture()
        {
            return (UnityEngine.RenderTexture)this._rt;
        }
        public int get_iterations()
        {
            return (int)this.m_BlurIterations;
        }
        public void set_iterations(int value)
        {
            this.m_BlurIterations = value;
        }
        public int get_blurIterations()
        {
            return (int)this.m_BlurIterations;
        }
        public void set_blurIterations(int value)
        {
            this.m_BlurIterations = value;
        }
        public bool get_keepCanvasSize()
        {
            return (bool)this.m_FitToScreen;
        }
        public void set_keepCanvasSize(bool value)
        {
            this.m_FitToScreen = value;
        }
        public bool get_fitToScreen()
        {
            return (bool)this.m_FitToScreen;
        }
        public void set_fitToScreen(bool value)
        {
            this.m_FitToScreen = value;
        }
        public UnityEngine.RenderTexture get_targetTexture()
        {
            return 0;
        }
        public void set_targetTexture(UnityEngine.RenderTexture value)
        {
        
        }
        public bool get_captureOnEnable()
        {
            return (bool)this.m_CaptureOnEnable;
        }
        public void set_captureOnEnable(bool value)
        {
            this.m_CaptureOnEnable = value;
        }
        public bool get_immediateCapturing()
        {
            return (bool)this.m_ImmediateCapturing;
        }
        public void set_immediateCapturing(bool value)
        {
            this.m_ImmediateCapturing = value;
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            if(this.m_CaptureOnEnable == false)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            this.Capture();
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            if(this.m_CaptureOnEnable == false)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            this._Release(releaseRT:  false);
            this.texture = 0;
        }
        protected override void OnDestroy()
        {
            this._Release(releaseRT:  true);
            this.texture = 0;
            this.OnDestroy();
        }
        protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
        {
            if(static_value_02D63000 != 0)
            {
                    UnityEngine.Color val_2 = this.color;
                if(val_2.a >= 0)
            {
                    if(this.canvasRenderer.GetAlpha() >= 0)
            {
                goto label_6;
            }
            
            }
            
            }
            
            vh.Clear();
            return;
            label_6:
            this.OnPopulateMesh(vh:  vh);
            int val_5 = vh.currentVertCount;
            UnityEngine.Color val_6 = this.color;
            if(val_5 < 1)
            {
                    return;
            }
            
            var val_8 = 0;
            do
            {
                vh.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()}, i:  0);
                UnityEngine.Color32 val_7 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
                vh.SetUIVertex(vertex:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()}, i:  0);
                val_8 = val_8 + 1;
            }
            while(val_5 != val_8);
        
        }
        public void GetDesamplingSize(Coffee.UIExtensions.UIEffectCapturedImage.DesamplingRate rate, out int w, out int h)
        {
            w = UnityEngine.Screen.width;
            int val_2 = UnityEngine.Screen.height;
            h = val_2;
            if(rate == 0)
            {
                    return;
            }
            
            float val_3 = (float)w / (float)val_2;
            if(w < val_2)
            {
                    int val_5 = UnityEngine.Mathf.ClosestPowerOfTwo(value:  val_2 / rate);
                float val_9 = (float)val_5;
                h = val_5;
                val_9 = val_3 * val_9;
            }
            else
            {
                    int val_7 = UnityEngine.Mathf.ClosestPowerOfTwo(value:  w / rate);
                float val_10 = (float)val_7;
                w = val_7;
                val_10 = val_10 / val_3;
                1152921528912165120 = 1152921528912169152;
            }
            
            h = UnityEngine.Mathf.CeilToInt(f:  val_10);
        }
        public void Capture()
        {
            UnityEngine.Object val_21;
            int val_15 = 0;
            int val_16 = 0;
            if(this.m_FitToScreen != false)
            {
                    UnityEngine.Transform val_3 = this.canvas.rootCanvas.transform;
                UnityEngine.Rect val_4 = val_3.rect;
                this.rectTransform.SetSizeWithCurrentAnchors(axis:  0, size:  val_4.m_XMin);
                this.rectTransform.SetSizeWithCurrentAnchors(axis:  1, size:  val_4.m_YMin);
                UnityEngine.Vector3 val_8 = val_3.position;
                this.rectTransform.position = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            }
            
            if(Coffee.UIExtensions.UIEffectCapturedImage.s_CopyId == 0)
            {
                    Coffee.UIExtensions.UIEffectCapturedImage.s_CopyId = UnityEngine.Shader.PropertyToID(name:  "_UIEffectCapturedImage_ScreenCopyId");
                Coffee.UIExtensions.UIEffectCapturedImage.s_EffectId1 = UnityEngine.Shader.PropertyToID(name:  "_UIEffectCapturedImage_EffectId1");
                Coffee.UIExtensions.UIEffectCapturedImage.s_EffectId2 = UnityEngine.Shader.PropertyToID(name:  "_UIEffectCapturedImage_EffectId2");
                Coffee.UIExtensions.UIEffectCapturedImage.s_EffectFactorId = UnityEngine.Shader.PropertyToID(name:  "_EffectFactor");
                Coffee.UIExtensions.UIEffectCapturedImage.s_ColorFactorId = UnityEngine.Shader.PropertyToID(name:  "_ColorFactor");
                UnityEngine.Rendering.CommandBuffer val_14 = new UnityEngine.Rendering.CommandBuffer();
                Coffee.UIExtensions.UIEffectCapturedImage.s_CommandBuffer = val_14;
            }
            
            val_14.GetDesamplingSize(rate:  this.m_DesamplingRate, w: out  val_15, h: out  val_16);
            if((UnityEngine.Object.op_Implicit(exists:  this._rt)) != false)
            {
                    if(mem[this._rt] == val_15)
            {
                    if(mem[this._rt] == val_16)
            {
                goto label_16;
            }
            
            }
            
                mem[this._rt]._Release(obj: ref  this._rt);
            }
            
            label_16:
            val_21 = mem[this._rt];
            if(val_21 == 0)
            {
                    UnityEngine.RenderTexture val_20 = null;
                val_21 = val_20;
                val_20 = new UnityEngine.RenderTexture(width:  0, height:  0, depth:  0, format:  0, readWrite:  0);
                this._rt = val_21;
                val_20.filterMode = this.m_FilterMode;
                this._rt.useMipMap = false;
                mem[this._rt].wrapMode = 1;
                mem[this._rt].hideFlags = 61;
            }
            
            this.SetupCommandBuffer();
        }
        private void SetupCommandBuffer()
        {
            UnityEngine.CubemapFace val_5;
            UnityEngine.Rendering.BuiltinRenderTextureType val_6;
            IntPtr val_7;
            UnityEngine.CubemapFace val_8;
            UnityEngine.Rendering.BuiltinRenderTextureType val_9;
            IntPtr val_10;
            UnityEngine.CubemapFace val_13;
            UnityEngine.Rendering.BuiltinRenderTextureType val_14;
            IntPtr val_15;
            UnityEngine.CubemapFace val_16;
            UnityEngine.Rendering.BuiltinRenderTextureType val_17;
            IntPtr val_18;
            UnityEngine.Rendering.CommandBuffer val_30;
            UnityEngine.Rendering.CommandBuffer val_31;
            int val_2 = 0;
            if(Coffee.UIExtensions.UIEffectCapturedImage.s_CommandBuffer == null)
            {
                    UnityEngine.Rendering.CommandBuffer val_1 = new UnityEngine.Rendering.CommandBuffer();
                Coffee.UIExtensions.UIEffectCapturedImage.s_CommandBuffer = val_1;
            }
            
            val_1.GetDesamplingSize(rate:  0, w: out  val_2, h: out  val_2);
            val_1.GetTemporaryRT(nameID:  Coffee.UIExtensions.UIEffectCapturedImage.s_CopyId, width:  0, height:  0, depthBuffer:  0, filter:  this.m_FilterMode);
            UnityEngine.Rendering.RenderTargetIdentifier val_3 = UnityEngine.Rendering.RenderTargetIdentifier.op_Implicit(type:  0);
            UnityEngine.Rendering.RenderTargetIdentifier val_4 = UnityEngine.Rendering.RenderTargetIdentifier.op_Implicit(nameID:  Coffee.UIExtensions.UIEffectCapturedImage.s_CopyId);
            val_1.Blit(source:  new UnityEngine.Rendering.RenderTargetIdentifier() {m_Type = val_6, m_NameID = val_6, m_InstanceID = val_6, m_BufferPointer = val_7, m_MipLevel = val_7, m_CubeFace = val_5}, dest:  new UnityEngine.Rendering.RenderTargetIdentifier() {m_Type = val_9, m_NameID = val_9, m_InstanceID = val_9, m_BufferPointer = val_10, m_MipLevel = val_10, m_CubeFace = val_8});
            val_1.SetGlobalVector(nameID:  Coffee.UIExtensions.UIEffectCapturedImage.s_EffectFactorId, value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_1.SetGlobalVector(nameID:  Coffee.UIExtensions.UIEffectCapturedImage.s_ColorFactorId, value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_1.GetDesamplingSize(rate:  this.m_ReductionRate, w: out  val_2, h: out  val_2);
            val_30 = 0;
            val_1.GetTemporaryRT(nameID:  Coffee.UIExtensions.UIEffectCapturedImage.s_EffectId1, width:  0, height:  0, depthBuffer:  0, filter:  this.m_FilterMode);
            val_31 = Coffee.UIExtensions.UIEffectCapturedImage.s_CommandBuffer;
            UnityEngine.Rendering.RenderTargetIdentifier val_11 = UnityEngine.Rendering.RenderTargetIdentifier.op_Implicit(nameID:  Coffee.UIExtensions.UIEffectCapturedImage.s_CopyId);
            UnityEngine.Rendering.RenderTargetIdentifier val_12 = UnityEngine.Rendering.RenderTargetIdentifier.op_Implicit(nameID:  Coffee.UIExtensions.UIEffectCapturedImage.s_EffectId1);
            val_1.Blit(source:  new UnityEngine.Rendering.RenderTargetIdentifier() {m_Type = val_14, m_NameID = val_14, m_InstanceID = val_14, m_BufferPointer = val_15, m_MipLevel = val_15, m_CubeFace = val_13}, dest:  new UnityEngine.Rendering.RenderTargetIdentifier() {m_Type = val_17, m_NameID = val_17, m_InstanceID = val_17, m_BufferPointer = val_18, m_MipLevel = val_18, m_CubeFace = val_16}, mat:  this.m_EffectMaterial, pass:  0);
            val_1.ReleaseTemporaryRT(nameID:  Coffee.UIExtensions.UIEffectCapturedImage.s_CopyId);
            if(this.m_BlurMode != 0)
            {
                    val_1.GetTemporaryRT(nameID:  Coffee.UIExtensions.UIEffectCapturedImage.s_EffectId2, width:  0, height:  0, depthBuffer:  0, filter:  this.m_FilterMode);
                val_30 = Coffee.UIExtensions.UIEffectCapturedImage.s_CommandBuffer;
                if(this.m_BlurIterations >= 1)
            {
                    do
            {
                val_1.SetGlobalVector(nameID:  Coffee.UIExtensions.UIEffectCapturedImage.s_EffectFactorId, value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
                UnityEngine.Rendering.RenderTargetIdentifier val_19 = UnityEngine.Rendering.RenderTargetIdentifier.op_Implicit(nameID:  Coffee.UIExtensions.UIEffectCapturedImage.s_EffectId1);
                UnityEngine.Rendering.RenderTargetIdentifier val_20 = UnityEngine.Rendering.RenderTargetIdentifier.op_Implicit(nameID:  Coffee.UIExtensions.UIEffectCapturedImage.s_EffectId2);
                val_1.Blit(source:  new UnityEngine.Rendering.RenderTargetIdentifier() {m_Type = val_6, m_NameID = val_6, m_InstanceID = val_6, m_BufferPointer = val_7, m_MipLevel = val_7, m_CubeFace = val_5}, dest:  new UnityEngine.Rendering.RenderTargetIdentifier() {m_Type = val_9, m_NameID = val_9, m_InstanceID = val_9, m_BufferPointer = val_10, m_MipLevel = val_10, m_CubeFace = val_8}, mat:  this.m_EffectMaterial, pass:  1);
                val_1.SetGlobalVector(nameID:  Coffee.UIExtensions.UIEffectCapturedImage.s_EffectFactorId, value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
                UnityEngine.Rendering.RenderTargetIdentifier val_21 = UnityEngine.Rendering.RenderTargetIdentifier.op_Implicit(nameID:  Coffee.UIExtensions.UIEffectCapturedImage.s_EffectId2);
                UnityEngine.Rendering.RenderTargetIdentifier val_22 = UnityEngine.Rendering.RenderTargetIdentifier.op_Implicit(nameID:  Coffee.UIExtensions.UIEffectCapturedImage.s_EffectId1);
                val_1.Blit(source:  new UnityEngine.Rendering.RenderTargetIdentifier() {m_Type = val_14, m_NameID = val_14, m_InstanceID = val_14, m_BufferPointer = val_15, m_MipLevel = val_15, m_CubeFace = val_13}, dest:  new UnityEngine.Rendering.RenderTargetIdentifier() {m_Type = val_17, m_NameID = val_17, m_InstanceID = val_17, m_BufferPointer = val_18, m_MipLevel = val_18, m_CubeFace = val_16}, mat:  this.m_EffectMaterial, pass:  1);
                val_31 = 0 + 1;
                val_30 = Coffee.UIExtensions.UIEffectCapturedImage.s_CommandBuffer;
            }
            while(val_31 < this.m_BlurIterations);
            
            }
            
                val_1.ReleaseTemporaryRT(nameID:  Coffee.UIExtensions.UIEffectCapturedImage.s_EffectId2);
            }
            
            UnityEngine.Rendering.RenderTargetIdentifier val_23 = UnityEngine.Rendering.RenderTargetIdentifier.op_Implicit(nameID:  Coffee.UIExtensions.UIEffectCapturedImage.s_EffectId1);
            val_8 = 0;
            val_9 = 0;
            val_10 = 0;
            val_1.Blit(source:  new UnityEngine.Rendering.RenderTargetIdentifier() {m_Type = val_6, m_NameID = val_6, m_InstanceID = val_6, m_BufferPointer = val_7, m_MipLevel = val_7, m_CubeFace = val_5}, dest:  new UnityEngine.Rendering.RenderTargetIdentifier() {m_CubeFace = val_8});
            val_1.ReleaseTemporaryRT(nameID:  Coffee.UIExtensions.UIEffectCapturedImage.s_EffectId1);
            if(this.m_ImmediateCapturing != false)
            {
                    this.UpdateTexture();
                return;
            }
            
            UnityEngine.Coroutine val_28 = this.canvas.rootCanvas.GetComponent<UnityEngine.UI.CanvasScaler>().StartCoroutine(routine:  this._CoUpdateTextureOnNextFrame());
        }
        public void Release()
        {
            this._Release(releaseRT:  true);
            this.texture = 0;
        }
        private void _Release(bool releaseRT)
        {
            if(releaseRT != false)
            {
                    this.texture = 0;
                this._Release(obj: ref  this._rt);
            }
            
            if(Coffee.UIExtensions.UIEffectCapturedImage.s_CommandBuffer == null)
            {
                    return;
            }
            
            Coffee.UIExtensions.UIEffectCapturedImage.s_CommandBuffer.Clear();
            if(releaseRT == false)
            {
                    return;
            }
            
            Coffee.UIExtensions.UIEffectCapturedImage.s_CommandBuffer.Release();
            Coffee.UIExtensions.UIEffectCapturedImage.s_CommandBuffer = 0;
        }
        private void _SetDirty()
        {
        
        }
        private void _Release(ref UnityEngine.RenderTexture obj)
        {
            if((UnityEngine.Object.op_Implicit(exists:  obj)) == false)
            {
                    return;
            }
            
            obj.Release();
            UnityEngine.Object.Destroy(obj:  obj);
            obj = 0;
        }
        private System.Collections.IEnumerator _CoUpdateTextureOnNextFrame()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new UIEffectCapturedImage.<_CoUpdateTextureOnNextFrame>d__95();
        }
        private void UpdateTexture()
        {
            UnityEngine.Graphics.ExecuteCommandBuffer(buffer:  Coffee.UIExtensions.UIEffectCapturedImage.s_CommandBuffer);
            this._Release(releaseRT:  false);
            this.texture = this._rt;
        }
        public UIEffectCapturedImage()
        {
            this.m_EffectFactor = 1;
            this.m_BlurFactor = 1f;
            this.m_BlurMode = 3;
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.m_EffectColor = val_1;
            mem[1152921528913600900] = val_1.g;
            mem[1152921528913600904] = val_1.b;
            mem[1152921528913600908] = val_1.a;
            this.m_BlurIterations = 3;
            this.m_DesamplingRate = 1;
            this.m_FilterMode = 1;
            this.m_FitToScreen = 1;
            this.m_ImmediateCapturing = 1;
        }
    
    }

}
