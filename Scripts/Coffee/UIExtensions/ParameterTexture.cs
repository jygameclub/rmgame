using UnityEngine;

namespace Coffee.UIExtensions
{
    [Serializable]
    public class ParameterTexture
    {
        // Fields
        private UnityEngine.Texture2D _texture;
        private bool _needUpload;
        private int _propertyId;
        private readonly string _propertyName;
        private readonly int _channels;
        private readonly int _instanceLimit;
        private readonly byte[] _data;
        private readonly System.Collections.Generic.Stack<int> _stack;
        private static System.Collections.Generic.List<System.Action> updates;
        
        // Methods
        public ParameterTexture(int channels, int instanceLimit, string propertyName)
        {
            int val_10;
            val_1 = new System.Object();
            int val_2 = channels - 1;
            int val_4 = (val_2 < 0) ? (channels + 2) : (val_2);
            int val_5 = instanceLimit - 1;
            int val_6 = (val_5 < 0) ? instanceLimit : (val_5);
            val_4 = val_4 & 4294967292;
            val_6 = val_6 & 4294967294;
            val_4 = val_4 + 4;
            val_6 = val_6 + 2;
            this._propertyName = val_1;
            this._channels = val_4;
            this._instanceLimit = val_6;
            var val_7 = val_6 * val_4;
            this._data = new byte[0];
            val_10 = this._instanceLimit;
            System.Collections.Generic.Stack<System.Int32> val_9 = new System.Collections.Generic.Stack<System.Int32>(capacity:  val_10);
            int val_11 = this._instanceLimit;
            this._stack = val_9;
            val_11 = val_11 + 1;
            if(val_11 < 2)
            {
                    return;
            }
            
            val_10 = 2;
            do
            {
                val_9.Push(item:  val_10 - 1);
                int val_12 = this._instanceLimit;
                val_12 = val_12 + 1;
                if(val_10 >= val_12)
            {
                    return;
            }
            
                val_10 = val_10 + 1;
            }
            while(this._stack != null);
            
            throw new NullReferenceException();
        }
        public void Register(Coffee.UIExtensions.IParameterTexture target)
        {
            var val_4;
            this.Initialize();
            var val_5 = 0;
            if(mem[1152921505157042176] != null)
            {
                    val_5 = val_5 + 1;
                val_4 = 0;
            }
            else
            {
                    Coffee.UIExtensions.IParameterTexture val_1 = 1152921505157005312 + ((mem[1152921505157042184]) << 4);
            }
            
            if(target.parameterIndex > 0)
            {
                    return;
            }
            
            if((public System.Int32 Coffee.UIExtensions.IParameterTexture::get_parameterIndex()) < 1)
            {
                    return;
            }
            
            var val_6 = 0;
            if(mem[1152921505157042176] != null)
            {
                    val_6 = val_6 + 1;
                val_4 = 1;
            }
            else
            {
                    var val_7 = mem[1152921505157042184];
                val_7 = val_7 + 1;
                Coffee.UIExtensions.IParameterTexture val_4 = 1152921505157005312 + val_7;
            }
            
            target.parameterIndex = this._stack.Pop();
        }
        public void Unregister(Coffee.UIExtensions.IParameterTexture target)
        {
            var val_6;
            var val_6 = 0;
            if(mem[1152921505157042176] != null)
            {
                    val_6 = val_6 + 1;
            }
            else
            {
                    Coffee.UIExtensions.IParameterTexture val_1 = 1152921505157005312 + ((mem[1152921505157042184]) << 4);
            }
            
            if(target.parameterIndex < 1)
            {
                    return;
            }
            
            var val_7 = 0;
            if(mem[1152921505157042176] != null)
            {
                    val_7 = val_7 + 1;
            }
            else
            {
                    Coffee.UIExtensions.IParameterTexture val_3 = 1152921505157005312 + ((mem[1152921505157042184]) << 4);
            }
            
            val_6 = public System.Void System.Collections.Generic.Stack<System.Int32>::Push(System.Int32 item);
            this._stack.Push(item:  target.parameterIndex);
            var val_8 = 0;
            if(mem[1152921505157042176] != null)
            {
                    val_8 = val_8 + 1;
                val_6 = 1;
            }
            else
            {
                    var val_9 = mem[1152921505157042184];
                val_9 = val_9 + 1;
                Coffee.UIExtensions.IParameterTexture val_5 = 1152921505157005312 + val_9;
            }
            
            target.parameterIndex = 0;
        }
        public void SetData(Coffee.UIExtensions.IParameterTexture target, int channelId, byte value)
        {
            var val_6 = 0;
            if(mem[1152921505157042176] != null)
            {
                    val_6 = val_6 + 1;
            }
            else
            {
                    Coffee.UIExtensions.IParameterTexture val_1 = 1152921505157005312 + ((mem[1152921505157042184]) << 4);
            }
            
            var val_7 = 0;
            if(mem[1152921505157042176] != null)
            {
                    val_7 = val_7 + 1;
            }
            else
            {
                    Coffee.UIExtensions.IParameterTexture val_3 = 1152921505157005312 + ((mem[1152921505157042184]) << 4);
            }
            
            if(target.parameterIndex < 1)
            {
                    return;
            }
            
            int val_5 = target.parameterIndex - 1;
            val_5 = channelId + (this._channels * val_5);
            if(this._data[val_5] == value)
            {
                    return;
            }
            
            mem2[0] = value;
            this._needUpload = true;
        }
        public void SetData(Coffee.UIExtensions.IParameterTexture target, int channelId, float value)
        {
            float val_1 = UnityEngine.Mathf.Clamp01(value:  value);
            val_1 = val_1 * 255f;
            this.SetData(target:  target, channelId:  channelId, value:  (val_1 < 0) ? ((int)val_1) : ((int)val_1));
        }
        public void RegisterMaterial(UnityEngine.Material mat)
        {
            if(this._propertyId == 0)
            {
                    this._propertyId = UnityEngine.Shader.PropertyToID(name:  this._propertyName);
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  mat)) == false)
            {
                    return;
            }
            
            mat.SetTexture(nameID:  this._propertyId, value:  this._texture);
        }
        public float GetNormalizedIndex(Coffee.UIExtensions.IParameterTexture target)
        {
            var val_3 = 0;
            if(mem[1152921505157042176] != null)
            {
                    val_3 = val_3 + 1;
            }
            else
            {
                    Coffee.UIExtensions.IParameterTexture val_1 = 1152921505157005312 + ((mem[1152921505157042184]) << 4);
            }
            
            float val_4 = (float)target.parameterIndex;
            val_4 = val_4 + (-0.5f);
            float val_5 = (float)this._instanceLimit;
            val_5 = val_4 / val_5;
            return (float)val_5;
        }
        private void Initialize()
        {
            var val_9;
            Canvas.WillRenderCanvases val_11;
            if(Coffee.UIExtensions.ParameterTexture.updates == null)
            {
                    System.Collections.Generic.List<System.Action> val_1 = new System.Collections.Generic.List<System.Action>();
                Coffee.UIExtensions.ParameterTexture.updates = val_1;
                val_9 = null;
                val_9 = null;
                val_11 = ParameterTexture.<>c.<>9__16_0;
                if(val_11 == null)
            {
                    Canvas.WillRenderCanvases val_2 = null;
                val_11 = val_2;
                val_2 = new Canvas.WillRenderCanvases(object:  ParameterTexture.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ParameterTexture.<>c::<Initialize>b__16_0());
                ParameterTexture.<>c.<>9__16_0 = val_11;
            }
            
                UnityEngine.Canvas.add_willRenderCanvases(value:  val_2);
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this._texture)) != false)
            {
                    return;
            }
            
            UnityEngine.Texture2D val_7 = new UnityEngine.Texture2D(width:  ((this._channels < 0) ? (this._channels + 3) : this._channels) >> 2, height:  this._instanceLimit, textureFormat:  4, mipChain:  false, linear:  false);
            this._texture = val_7;
            val_7.filterMode = 0;
            this._texture.wrapMode = 1;
            System.Action val_8 = static_value_02DC1B30;
            val_8 = new System.Action(object:  this, method:  System.Void Coffee.UIExtensions.ParameterTexture::UpdateParameterTexture());
            val_1.Add(item:  val_8);
        }
        private void UpdateParameterTexture()
        {
            if(this._needUpload == false)
            {
                    return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this._texture)) == false)
            {
                    return;
            }
            
            this._needUpload = false;
            this._texture.LoadRawTextureData(data:  this._data);
            this._texture.Apply(updateMipmaps:  false, makeNoLongerReadable:  false);
        }
    
    }

}
