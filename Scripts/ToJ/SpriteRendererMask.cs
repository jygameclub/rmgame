using UnityEngine;

namespace ToJ
{
    public class SpriteRendererMask : MonoBehaviour
    {
        // Fields
        private bool _isMaskingEnabled;
        private bool _clampAlphaHorizontally;
        private bool _clampAlphaVertically;
        private float _clampingBorder;
        private bool _useMaskAlphaChannel;
        private UnityEngine.Texture mainTex;
        private UnityEngine.Vector2 mainTexTiling;
        private UnityEngine.Vector2 mainTexOffset;
        private bool fullMaskRefresh;
        private UnityEngine.Matrix4x4 oldWorldToMask;
        private UnityEngine.Shader defaultMaskedSpriteShader;
        private UnityEngine.Shader defaultMaskedUnlitShader;
        private UnityEngine.MeshRenderer meshRenderer;
        private UnityEngine.Material spritesAlphaMaskWorldCoords;
        private const string SPRITES_RESOURCE_ADDRESS = "Materials/Sprites-Alpha-Mask-WorldCoords";
        public const string MASKED_SPRITE_SHADER = "Alpha Masked/Sprites Alpha Masked - World Coords";
        public const string MASKED_UNLIT_SHADER = "Alpha Masked/Unlit Alpha Masked - World Coords";
        private UnityEngine.Material maskMaterial;
        private const string MASK_RESOURCE_ADDRESS = "Materials/Mask-Material";
        private UnityEngine.MaterialPropertyBlock maskeePropertyBlock;
        private UnityEngine.MaterialPropertyBlock maskPropertyBlock;
        public System.Collections.Generic.List<UnityEngine.Material> createdMatsStorage;
        public UnityEngine.SpriteRenderer maskedRenderer;
        
        // Properties
        public bool IsMaskingEnabled { get; set; }
        public bool ClampAlphaHorizontally { get; set; }
        public bool ClampAlphaVertically { get; set; }
        public float ClampingBorder { get; set; }
        public bool UseMaskAlphaChannel { get; set; }
        public UnityEngine.Texture MainTex { get; set; }
        public UnityEngine.Vector2 MainTexTiling { get; set; }
        public UnityEngine.Vector2 MainTexOffset { get; set; }
        private UnityEngine.Matrix4x4 OldWorldToMask { get; set; }
        private UnityEngine.Shader DefaultMaskedSpriteShader { get; set; }
        private UnityEngine.Shader DefaultMaskedUnlitShader { get; set; }
        private UnityEngine.MeshRenderer MeshRenderer { get; }
        public UnityEngine.Material SpritesAlphaMaskWorldCoords { get; set; }
        public UnityEngine.Material MaskMaterial { get; set; }
        public UnityEngine.MaterialPropertyBlock MaskeePropertyBlock { get; set; }
        public UnityEngine.MaterialPropertyBlock MaskPropertyBlock { get; set; }
        
        // Methods
        public bool get_IsMaskingEnabled()
        {
            return (bool)this._isMaskingEnabled;
        }
        public void set_IsMaskingEnabled(bool value)
        {
            var val_1 = (this._isMaskingEnabled == true) ? 1 : 0;
            val_1 = val_1 ^ value;
            if(val_1 == false)
            {
                    return;
            }
            
            this.fullMaskRefresh = true;
            this._isMaskingEnabled = value;
        }
        public bool get_ClampAlphaHorizontally()
        {
            return (bool)this._clampAlphaHorizontally;
        }
        public void set_ClampAlphaHorizontally(bool value)
        {
            var val_1 = (this._clampAlphaHorizontally == true) ? 1 : 0;
            val_1 = val_1 ^ value;
            if(val_1 == false)
            {
                    return;
            }
            
            this.fullMaskRefresh = true;
            this._clampAlphaHorizontally = value;
        }
        public bool get_ClampAlphaVertically()
        {
            return (bool)this._clampAlphaVertically;
        }
        public void set_ClampAlphaVertically(bool value)
        {
            var val_1 = (this._clampAlphaVertically == true) ? 1 : 0;
            val_1 = val_1 ^ value;
            if(val_1 == false)
            {
                    return;
            }
            
            this.fullMaskRefresh = true;
            this._clampAlphaVertically = value;
        }
        public float get_ClampingBorder()
        {
            return (float)this._clampingBorder;
        }
        public void set_ClampingBorder(float value)
        {
            if(this._clampingBorder == value)
            {
                    return;
            }
            
            this.fullMaskRefresh = true;
            this._clampingBorder = value;
        }
        public bool get_UseMaskAlphaChannel()
        {
            return (bool)this._useMaskAlphaChannel;
        }
        public void set_UseMaskAlphaChannel(bool value)
        {
            var val_1 = (this._useMaskAlphaChannel == true) ? 1 : 0;
            val_1 = val_1 ^ value;
            if(val_1 == false)
            {
                    return;
            }
            
            this.fullMaskRefresh = true;
            this._useMaskAlphaChannel = value;
        }
        public UnityEngine.Texture get_MainTex()
        {
            return (UnityEngine.Texture)this.mainTex;
        }
        public void set_MainTex(UnityEngine.Texture value)
        {
            if(value == this.mainTex)
            {
                    return;
            }
            
            this.fullMaskRefresh = true;
            this.mainTex = value;
        }
        public UnityEngine.Vector2 get_MainTexTiling()
        {
            return new UnityEngine.Vector2() {x = this.mainTexTiling};
        }
        public void set_MainTexTiling(UnityEngine.Vector2 value)
        {
            if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = value.x, y = value.y}, rhs:  new UnityEngine.Vector2() {x = this.mainTexTiling, y = V10.16B})) == false)
            {
                    return;
            }
            
            this.fullMaskRefresh = true;
            this.mainTexTiling = value;
            mem[1152921528929662852] = value.y;
        }
        public UnityEngine.Vector2 get_MainTexOffset()
        {
            return new UnityEngine.Vector2() {x = this.mainTexOffset};
        }
        public void set_MainTexOffset(UnityEngine.Vector2 value)
        {
            if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = value.x, y = value.y}, rhs:  new UnityEngine.Vector2() {x = this.mainTexOffset, y = V10.16B})) == false)
            {
                    return;
            }
            
            this.fullMaskRefresh = true;
            this.mainTexOffset = value;
            mem[1152921528929886860] = value.y;
        }
        public void ScheduleFullMaskRefresh()
        {
            this.fullMaskRefresh = true;
        }
        private UnityEngine.Matrix4x4 get_OldWorldToMask()
        {
            UnityEngine.Matrix4x4 val_0;
            val_0.m02 = ;
            val_0.m03 = ;
            val_0.m00 = this.oldWorldToMask;
            val_0.m01 = ;
            return val_0;
        }
        private void set_OldWorldToMask(UnityEngine.Matrix4x4 value)
        {
            mem[1152921528930235060] = value.m03;
            mem[1152921528930235044] = value.m02;
            mem[1152921528930235028] = value.m01;
            this.oldWorldToMask = value.m00;
        }
        private UnityEngine.Shader get_DefaultMaskedSpriteShader()
        {
            UnityEngine.Shader val_3;
            if(this.defaultMaskedSpriteShader == 0)
            {
                    this.defaultMaskedSpriteShader = UnityEngine.Shader.Find(name:  "Alpha Masked/Sprites Alpha Masked - World Coords");
                return val_3;
            }
            
            val_3 = this.defaultMaskedSpriteShader;
            return val_3;
        }
        private void set_DefaultMaskedSpriteShader(UnityEngine.Shader value)
        {
            this.defaultMaskedSpriteShader = value;
        }
        private UnityEngine.Shader get_DefaultMaskedUnlitShader()
        {
            UnityEngine.Shader val_3;
            if(this.defaultMaskedUnlitShader == 0)
            {
                    this.defaultMaskedUnlitShader = UnityEngine.Shader.Find(name:  "Alpha Masked/Unlit Alpha Masked - World Coords");
                return val_3;
            }
            
            val_3 = this.defaultMaskedUnlitShader;
            return val_3;
        }
        private void set_DefaultMaskedUnlitShader(UnityEngine.Shader value)
        {
            this.defaultMaskedUnlitShader = value;
        }
        private UnityEngine.MeshRenderer get_MeshRenderer()
        {
            UnityEngine.MeshRenderer val_3;
            if(this.meshRenderer == 0)
            {
                    this.meshRenderer = this.GetComponent<UnityEngine.MeshRenderer>();
                return val_3;
            }
            
            val_3 = this.meshRenderer;
            return val_3;
        }
        public UnityEngine.Material get_SpritesAlphaMaskWorldCoords()
        {
            if(this.spritesAlphaMaskWorldCoords != 0)
            {
                    return (UnityEngine.Material)this.spritesAlphaMaskWorldCoords;
            }
            
            object val_2 = UnityEngine.Resources.Load<System.Object>(path:  "Materials/Sprites-Alpha-Mask-WorldCoords");
            this.spritesAlphaMaskWorldCoords = val_2;
            if(val_2 != 0)
            {
                    return (UnityEngine.Material)this.spritesAlphaMaskWorldCoords;
            }
            
            UnityEngine.Debug.LogError(message:  "Materials/Sprites-Alpha-Mask-WorldCoords not found!");
            return (UnityEngine.Material)this.spritesAlphaMaskWorldCoords;
        }
        public void set_SpritesAlphaMaskWorldCoords(UnityEngine.Material value)
        {
            this.spritesAlphaMaskWorldCoords = value;
        }
        public UnityEngine.Material get_MaskMaterial()
        {
            if(this.maskMaterial != 0)
            {
                    return (UnityEngine.Material)this.maskMaterial;
            }
            
            object val_2 = UnityEngine.Resources.Load<System.Object>(path:  "Materials/Mask-Material");
            this.maskMaterial = val_2;
            if(val_2 != 0)
            {
                    return (UnityEngine.Material)this.maskMaterial;
            }
            
            UnityEngine.Debug.LogError(message:  "Materials/Mask-Material not found!");
            return (UnityEngine.Material)this.maskMaterial;
        }
        public void set_MaskMaterial(UnityEngine.Material value)
        {
            this.maskMaterial = value;
        }
        public UnityEngine.MaterialPropertyBlock get_MaskeePropertyBlock()
        {
            UnityEngine.MaterialPropertyBlock val_2 = this.maskeePropertyBlock;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            UnityEngine.MaterialPropertyBlock val_1 = null;
            val_2 = val_1;
            val_1 = new UnityEngine.MaterialPropertyBlock();
            this.maskeePropertyBlock = val_2;
            return val_2;
        }
        public void set_MaskeePropertyBlock(UnityEngine.MaterialPropertyBlock value)
        {
            this.maskeePropertyBlock = value;
        }
        public UnityEngine.MaterialPropertyBlock get_MaskPropertyBlock()
        {
            UnityEngine.MaterialPropertyBlock val_2 = this.maskPropertyBlock;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            UnityEngine.MaterialPropertyBlock val_1 = null;
            val_2 = val_1;
            val_1 = new UnityEngine.MaterialPropertyBlock();
            this.maskPropertyBlock = val_2;
            return val_2;
        }
        public void set_MaskPropertyBlock(UnityEngine.MaterialPropertyBlock value)
        {
            this.maskPropertyBlock = value;
        }
        private void Start()
        {
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            this.MeshRenderer.enabled = false;
        }
        public bool IsMaskeeMaterial(UnityEngine.Material material)
        {
            return material.GetTag(tag:  "ToJMasked", searchFallbacks:  false, defaultValue:  "false").ToLowerInvariant().Equals(value:  "true");
        }
        private void ClearShaders()
        {
            this.defaultMaskedSpriteShader = 0;
            this.defaultMaskedUnlitShader = 0;
        }
        private void InitializeMeshRenderer(UnityEngine.MeshRenderer target)
        {
            target.shadowCastingMode = 0;
            target.receiveShadows = false;
        }
        private void LateUpdate()
        {
            this.RefreshMaskPropertyBlock();
            this.UpdateMasking();
        }
        private void UpdateSpriteMaterials(UnityEngine.SpriteRenderer spriteRenderer, UnityEngine.Matrix4x4 worldToMask, UnityEngine.Vector4 tilingAndOffset)
        {
            spriteRenderer.GetPropertyBlock(properties:  this.MaskeePropertyBlock);
            if(this.mainTex != 0)
            {
                    this.MaskeePropertyBlock.SetTexture(name:  "_AlphaTex", value:  this.mainTex);
            }
            
            this.MaskeePropertyBlock.SetFloat(name:  "_ClampHoriz", value:  (this._clampAlphaHorizontally == false) ? 0f : 1f);
            this.MaskeePropertyBlock.SetFloat(name:  "_ClampVert", value:  (this._clampAlphaVertically == false) ? 0f : 1f);
            this.MaskeePropertyBlock.SetFloat(name:  "_UseAlphaChannel", value:  (this._useMaskAlphaChannel == false) ? 0f : 1f);
            this.MaskeePropertyBlock.SetFloat(name:  "_Enabled", value:  (this._isMaskingEnabled == false) ? 0f : 1f);
            this.MaskeePropertyBlock.SetFloat(name:  "_ClampingBorder", value:  this._clampingBorder);
            this.MaskeePropertyBlock.SetFloat(name:  "_IsThisText", value:  0f);
            this.MaskeePropertyBlock.SetVector(name:  "_AlphaTex_ST", value:  new UnityEngine.Vector4() {x = tilingAndOffset.x, y = tilingAndOffset.y, z = tilingAndOffset.z, w = tilingAndOffset.w});
            this.MaskeePropertyBlock.SetMatrix(name:  "_WorldToMask", value:  new UnityEngine.Matrix4x4() {m00 = worldToMask.m00, m01 = worldToMask.m01, m02 = worldToMask.m02, m03 = worldToMask.m03});
            spriteRenderer.SetPropertyBlock(properties:  this.MaskeePropertyBlock);
        }
        public void UpdateMasking()
        {
            float val_11;
            float val_12;
            float val_13;
            float val_14;
            float val_27;
            float val_28;
            float val_29;
            float val_30;
            UnityEngine.Vector2 val_32;
            float val_33;
            float val_34;
            float val_35;
            float val_36;
            if(this.DefaultMaskedSpriteShader != 0)
            {
                    if(this.DefaultMaskedUnlitShader != 0)
            {
                goto label_6;
            }
            
            }
            
            UnityEngine.Debug.Log(message:  "Shaders necessary for masking don\'t seem to be present in the project.");
            return;
            label_6:
            if(this.transform.parent == 0)
            {
                    return;
            }
            
            val_32 = this.mainTexTiling;
            UnityEngine.RectTransform val_8 = this.GetComponent<UnityEngine.RectTransform>();
            UnityEngine.Matrix4x4 val_10 = this.transform.worldToLocalMatrix;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.one;
            val_34 = val_15.x;
            val_35 = val_15.y;
            val_36 = val_15.z;
            if((UnityEngine.Object.op_Implicit(exists:  val_8)) != false)
            {
                    UnityEngine.Rect val_17 = val_8.rect;
                val_32 = val_17.m_XMin;
                val_33 = val_17.m_YMin;
                UnityEngine.Vector3 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_32, y = val_33});
                val_34 = val_18.x;
                val_35 = val_18.y;
                val_36 = 1f;
            }
            
            UnityEngine.Vector3 val_20 = this.transform.lossyScale;
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.Scale(a:  new UnityEngine.Vector3() {x = val_34, y = val_35, z = val_36}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
            UnityEngine.Vector3 val_23 = this.transform.position;
            UnityEngine.Quaternion val_25 = this.transform.rotation;
            val_11 = val_11;
            val_12 = val_12;
            val_13 = val_13;
            val_14 = val_14;
            UnityEngine.Matrix4x4 val_26 = UnityEngine.Matrix4x4.Inverse(m:  new UnityEngine.Matrix4x4() {m00 = val_13, m10 = val_13, m20 = val_13, m30 = val_13, m01 = val_14, m11 = val_14, m21 = val_14, m31 = val_14, m02 = val_11, m12 = val_11, m22 = val_11, m32 = val_11, m03 = val_12, m13 = val_12, m23 = val_12, m33 = val_12});
            if((UnityEngine.Matrix4x4.op_Inequality(lhs:  new UnityEngine.Matrix4x4() {m00 = val_29, m10 = val_29, m20 = val_29, m30 = val_29, m01 = val_30, m11 = val_30, m21 = val_30, m31 = val_30, m02 = val_27, m12 = val_27, m22 = val_27, m32 = val_27, m03 = val_28, m13 = val_28, m23 = val_28, m33 = val_28}, rhs:  new UnityEngine.Matrix4x4() {m00 = this.oldWorldToMask, m10 = this.oldWorldToMask, m20 = this.oldWorldToMask, m30 = this.oldWorldToMask, m01 = val_29, m11 = val_29, m21 = val_29, m31 = val_29, m02 = val_27, m12 = val_27, m22 = val_27, m32 = val_27, m03 = val_28, m13 = val_28, m23 = val_28, m33 = val_28})) != false)
            {
                    this.fullMaskRefresh = true;
                this.oldWorldToMask = val_27;
                this.oldWorldToMask = val_28;
                this.oldWorldToMask = val_29;
                this.oldWorldToMask = val_30;
            }
            else
            {
                    this.oldWorldToMask = val_27;
                this.oldWorldToMask = val_28;
                this.oldWorldToMask = val_29;
                this.oldWorldToMask = val_30;
                if(this.fullMaskRefresh == false)
            {
                    return;
            }
            
            }
            
            this.UpdateSpriteMaterials(spriteRenderer:  this.maskedRenderer, worldToMask:  new UnityEngine.Matrix4x4() {m00 = val_29, m10 = val_29, m20 = val_29, m30 = val_29, m01 = val_30, m11 = val_30, m21 = val_30, m31 = val_30, m02 = val_27, m12 = val_27, m22 = val_27, m32 = val_27, m03 = val_28, m13 = val_28, m23 = val_28, m33 = val_28}, tilingAndOffset:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            this.fullMaskRefresh = false;
        }
        private void ValidateShader(UnityEngine.Material material)
        {
            if((System.String.op_Equality(a:  material.shader, b:  this.DefaultMaskedSpriteShader)) != false)
            {
                    if(material.shader.GetInstanceID() != this.DefaultMaskedSpriteShader.GetInstanceID())
            {
                    UnityEngine.Debug.Log(message:  "There seems to be more than one masked shader in the project with the same display name, and it\'s preventing the mask from being properly applied.");
                this.defaultMaskedSpriteShader = 0;
            }
            
            }
            
            if((System.String.op_Equality(a:  material.shader, b:  this.DefaultMaskedUnlitShader)) == false)
            {
                    return;
            }
            
            if(material.shader.GetInstanceID() == this.DefaultMaskedUnlitShader.GetInstanceID())
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  "There seems to be more than one masked shader in the project with the same display name, and it\'s preventing the mask from being properly applied.");
            this.defaultMaskedUnlitShader = 0;
        }
        private void RefreshMaskPropertyBlock()
        {
            if(this.MaskPropertyBlock == null)
            {
                    this.maskPropertyBlock = new UnityEngine.MaterialPropertyBlock();
            }
            
            this.MeshRenderer.GetPropertyBlock(properties:  this.MaskPropertyBlock);
            if(this.mainTex != 0)
            {
                    this.MaskPropertyBlock.SetTexture(name:  "_MainTex", value:  this.mainTex);
            }
            
            this.MaskPropertyBlock.SetVector(name:  "_MainTex_ST", value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            this.MeshRenderer.SetPropertyBlock(properties:  this.MaskPropertyBlock);
        }
        private void GetMaskQuad(UnityEngine.Mesh mesh, UnityEngine.Rect r)
        {
            UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[4];
            float val_2 = r.m_XMin.System.IConvertible.ToSingle(provider:  0);
            val_1[0] = 0;
            val_1[1] = 0;
            val_1[1] = 0;
            val_1[2] = 0;
            float val_3 = r.m_XMin.System.IConvertible.ToSingle(provider:  0);
            val_1[3] = 0;
            val_1[4] = 0;
            val_1[4] = 0;
            val_1[5] = 0;
            int[] val_4 = new int[6];
            val_4[0] = 0;
            val_4[0] = 2;
            val_4[1] = 1;
            val_4[1] = 2;
            val_4[2] = 3;
            val_4[2] = 1;
            UnityEngine.Vector3[] val_5 = new UnityEngine.Vector3[4];
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            val_5[0] = val_7;
            val_5[0] = val_7.y;
            val_5[1] = val_7.z;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            val_5[1] = val_9;
            val_5[2] = val_9.y;
            val_5[2] = val_9.z;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            val_5[3] = val_11;
            val_5[3] = val_11.y;
            val_5[4] = val_11.z;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            val_5[4] = val_13;
            val_5[5] = val_13.y;
            val_5[5] = val_13.z;
            UnityEngine.Vector2[] val_14 = new UnityEngine.Vector2[4];
            UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  0f, y:  0f);
            val_14[0] = val_15.x;
            UnityEngine.Vector2 val_16 = new UnityEngine.Vector2(x:  1f, y:  0f);
            val_14[1] = val_16.x;
            UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  0f, y:  1f);
            UnityEngine.Vector2 val_18;
            val_14[2] = val_17.x;
            val_18 = new UnityEngine.Vector2(x:  1f, y:  1f);
            val_14[3] = val_18.x;
            if((this.BasicArrayCompare<UnityEngine.Vector3>(one:  mesh.vertices, two:  val_1)) != true)
            {
                    mesh.vertices = val_1;
            }
            
            if((this.BasicArrayCompare<System.Int32>(one:  mesh.triangles, two:  val_4)) != true)
            {
                    mesh.triangles = val_4;
            }
            
            if((this.BasicArrayCompare<UnityEngine.Vector3>(one:  mesh.normals, two:  val_5)) != true)
            {
                    mesh.normals = val_5;
            }
            
            if((this.BasicArrayCompare<UnityEngine.Vector2>(one:  mesh.uv, two:  val_14)) == true)
            {
                    return;
            }
            
            mesh.uv = val_14;
        }
        private bool BasicArrayCompare<T>(T[] one, T[] two)
        {
            var val_1;
            int val_1 = two.Length;
            if(one.Length != val_1)
            {
                goto label_7;
            }
            
            if(one.Length < 1)
            {
                goto label_8;
            }
            
            val_1 = val_1 & 4294967295;
            var val_3 = 0;
            label_9:
            if((one[32] & 1) == 0)
            {
                goto label_7;
            }
            
            val_3 = val_3 + 1;
            if(val_3 >= one.Length)
            {
                goto label_8;
            }
            
            if(val_3 < two.Length)
            {
                goto label_9;
            }
            
            throw new IndexOutOfRangeException();
            label_7:
            val_1 = 0;
            return (bool)val_1;
            label_8:
            val_1 = 1;
            return (bool)val_1;
        }
        private System.Collections.Generic.List<UnityEngine.Material> CollectDifferentMaterials()
        {
            var val_15;
            var val_16;
            UnityEngine.Object val_26;
            UnityEngine.Object val_27;
            var val_28;
            System.Collections.Generic.List<UnityEngine.Material> val_1 = new System.Collections.Generic.List<UnityEngine.Material>();
            val_26 = this.transform.parent;
            if(val_26 == 0)
            {
                    return val_1;
            }
            
            System.Collections.Generic.List<UnityEngine.Renderer> val_5 = null;
            val_26 = val_5;
            val_5 = new System.Collections.Generic.List<UnityEngine.Renderer>();
            this.transform.parent.gameObject.GetComponentsInChildren<UnityEngine.Renderer>(includeInactive:  true, results:  val_5);
            UnityEngine.Renderer val_11 = this.transform.parent.GetComponent<UnityEngine.Renderer>();
            if(val_11 != 0)
            {
                    bool val_13 = val_5.Remove(item:  val_11);
            }
            
            List.Enumerator<T> val_14 = val_5.GetEnumerator();
            goto label_22;
            label_31:
            val_26 = val_15;
            if(val_26 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_27 = this.gameObject;
            if(val_26.gameObject != val_27)
            {
                    val_28 = 0;
                UnityEngine.Material[] val_20 = val_26.sharedMaterials;
                if(val_20 == null)
            {
                    throw new NullReferenceException();
            }
            
                int val_25 = val_20.Length;
                if(val_25 >= 1)
            {
                    var val_26 = 0;
                val_25 = val_25 & 4294967295;
                do
            {
                if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
                if((val_1.Contains(item:  1152921506438889632)) != true)
            {
                    val_1.Add(item:  1152921506438889632);
                val_28 = 0;
                UnityEngine.GameObject val_22 = val_26.gameObject;
                if(val_22 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_28 = public UnityEngine.Renderer UnityEngine.GameObject::GetComponent<UnityEngine.Renderer>();
                UnityEngine.Renderer val_23 = val_22.GetComponent<UnityEngine.Renderer>();
                if(val_23 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_27 = val_23.gameObject;
                UnityEngine.Debug.Log(message:  val_27);
            }
            
                val_26 = val_26 + 1;
            }
            while(val_26 < (val_20.Length << ));
            
            }
            
            }
            
            label_22:
            if(((-1442415856) & 1) != 0)
            {
                goto label_31;
            }
            
            val_16.Dispose();
            return val_1;
        }
        public void ChangeMaskTexture(UnityEngine.Texture texture)
        {
            this.MainTex = texture;
        }
        public void SetMaskRendererActive(bool value)
        {
            value = value;
            this.MeshRenderer.enabled = value;
        }
        public void DuplicateMaskedMaterials()
        {
            UnityEngine.Material val_5;
            int val_6;
            System.Collections.Generic.List<T> val_56;
            UnityEngine.Object val_57;
            UnityEngine.Material val_58;
            var val_59;
            var val_60;
            UnityEngine.Material val_61;
            UnityEngine.Object val_62;
            UnityEngine.Material val_63;
            int val_64;
            var val_65;
            val_56 = this.CollectDifferentMaterials();
            System.Collections.Generic.Dictionary<UnityEngine.Material, UnityEngine.Material> val_2 = null;
            val_58 = public System.Void System.Collections.Generic.Dictionary<UnityEngine.Material, UnityEngine.Material>::.ctor();
            val_2 = new System.Collections.Generic.Dictionary<UnityEngine.Material, UnityEngine.Material>();
            if(val_56 == null)
            {
                    throw new NullReferenceException();
            }
            
            if((public System.Void System.Collections.Generic.Dictionary<UnityEngine.Material, UnityEngine.Material>::.ctor()) == 0)
            {
                    return;
            }
            
            val_59 = 1152921504619413504;
            UnityEngine.Debug.Log(message:  "Different Materials: "("Different Materials: ") + 1152921518449727136);
            List.Enumerator<T> val_4 = val_56.GetEnumerator();
            val_60 = 1152921528927337776;
            label_8:
            if(((-1441670256) & 1) == 0)
            {
                goto label_5;
            }
            
            val_61 = val_5;
            if((val_6.IsMaskeeMaterial(material:  val_61)) == false)
            {
                goto label_8;
            }
            
            UnityEngine.Material val_8 = null;
            val_58 = val_61;
            val_8 = new UnityEngine.Material(source:  val_58);
            if(val_2 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_2.Add(key:  val_61, value:  val_8);
            goto label_8;
            label_5:
            val_58 = public System.Void List.Enumerator<UnityEngine.Material>::Dispose();
            val_6.Dispose();
            if(val_2 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_61 = "Duplicate different Materials: "("Duplicate different Materials: ") + val_2.Count;
            UnityEngine.Debug.Log(message:  val_61);
            val_58 = public Dictionary.ValueCollection<TKey, TValue> System.Collections.Generic.Dictionary<UnityEngine.Material, UnityEngine.Material>::get_Values();
            Dictionary.ValueCollection<TKey, TValue> val_11 = val_2.Values;
            if(val_11 == null)
            {
                    throw new NullReferenceException();
            }
            
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_12 = val_11.GetEnumerator();
            label_17:
            val_58 = public System.Boolean Dictionary.ValueCollection.Enumerator<UnityEngine.Material, UnityEngine.Material>::MoveNext();
            if(((-1441670288) & 1) == 0)
            {
                goto label_13;
            }
            
            val_61 = val_5;
            if(val_61 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_6 = val_61.GetInstanceID();
            UnityEngine.Debug.Log(message:  "Material ID: "("Material ID: ") + val_6, context:  val_61);
            goto label_17;
            label_13:
            val_6.Dispose();
            val_58 = 0;
            UnityEngine.Transform val_15 = this.transform;
            if(val_15 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_62 = val_15.parent;
            if(val_62 == 0)
            {
                    UnityEngine.Debug.Log(message:  "Proper mask hierarchy not found.");
                return;
            }
            
            System.Collections.Generic.List<UnityEngine.Renderer> val_18 = null;
            val_61 = val_18;
            val_18 = new System.Collections.Generic.List<UnityEngine.Renderer>();
            val_58 = 0;
            UnityEngine.Transform val_19 = this.transform;
            if(val_19 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_58 = 0;
            UnityEngine.Transform val_20 = val_19.parent;
            if(val_20 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_58 = 0;
            UnityEngine.GameObject val_21 = val_20.gameObject;
            if(val_21 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_21.GetComponentsInChildren<UnityEngine.Renderer>(includeInactive:  true, results:  val_18);
            val_58 = 0;
            UnityEngine.Transform val_22 = this.transform;
            if(val_22 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_58 = 0;
            UnityEngine.Transform val_23 = val_22.parent;
            if(val_23 == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Renderer val_24 = val_23.GetComponent<UnityEngine.Renderer>();
            val_57 = val_24;
            val_58 = 0;
            if(val_57 != val_58)
            {
                    if(val_61 == null)
            {
                    throw new NullReferenceException();
            }
            
                bool val_26 = val_18.Remove(item:  val_24);
            }
            else
            {
                    if(val_61 == null)
            {
                    throw new NullReferenceException();
            }
            
            }
            
            List.Enumerator<T> val_27 = val_18.GetEnumerator();
            val_60 = 1152921528927404720;
            label_59:
            val_58 = public System.Boolean List.Enumerator<UnityEngine.Renderer>::MoveNext();
            if(((-1441670320) & 1) == 0)
            {
                goto label_36;
            }
            
            val_61 = val_5;
            if(val_61 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if(val_61.gameObject == this.gameObject)
            {
                goto label_59;
            }
            
            val_58 = 0;
            if(val_61.sharedMaterials == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Material[] val_32 = new UnityEngine.Material[0];
            if(val_32.Length < 1)
            {
                goto label_43;
            }
            
            var val_59 = 4;
            label_58:
            UnityEngine.Material[] val_33 = val_61.sharedMaterials;
            if(val_33 == null)
            {
                    throw new NullReferenceException();
            }
            
            var val_34 = val_59 - 4;
            if(val_34 >= val_33.Length)
            {
                    throw new IndexOutOfRangeException();
            }
            
            if((val_2.ContainsKey(key:  val_33[0])) == false)
            {
                goto label_46;
            }
            
            UnityEngine.Material[] val_36 = val_61.sharedMaterials;
            if(val_36 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_34 >= val_36.Length)
            {
                    throw new IndexOutOfRangeException();
            }
            
            UnityEngine.Material val_37 = val_2.Item[val_36[0]];
            val_63 = val_37;
            if(val_37 != null)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            }
            
            val_64 = val_32.Length;
            if(val_34 < val_64)
            {
                goto label_51;
            }
            
            throw new IndexOutOfRangeException();
            label_46:
            UnityEngine.Material[] val_38 = val_61.sharedMaterials;
            if(val_38 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_34 >= val_38.Length)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_63 = val_38[0];
            val_64 = val_32.Length;
            label_51:
            val_32[0] = val_63;
            val_59 = val_59 + 1;
            if((val_59 - 3) < (val_64 << ))
            {
                goto label_58;
            }
            
            label_43:
            val_61.sharedMaterials = val_32;
            goto label_59;
            label_36:
            mem[225] = 488;
            val_6.Dispose();
            var val_60 = 0;
            if(val_60 != 1)
            {
                    val_59 = 225;
                var val_40 = (mem[225] == 488) ? 1 : 0;
                val_40 = ((val_60 >= 0) ? 1 : 0) & val_40;
                val_60 = val_60 - val_40;
                val_60 = val_60 + 1;
                val_65 = (long)val_60;
            }
            else
            {
                    val_59 = 225;
                val_65 = 0;
            }
            
            System.Collections.Generic.List<UnityEngine.UI.Graphic> val_42 = null;
            val_56 = val_42;
            val_42 = new System.Collections.Generic.List<UnityEngine.UI.Graphic>();
            val_58 = 0;
            UnityEngine.Transform val_43 = this.transform;
            if(val_43 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_58 = 0;
            UnityEngine.Transform val_44 = val_43.parent;
            if(val_44 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_58 = 0;
            UnityEngine.GameObject val_45 = val_44.gameObject;
            if(val_45 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_45.GetComponentsInChildren<UnityEngine.UI.Graphic>(includeInactive:  true, results:  val_42);
            val_58 = 0;
            UnityEngine.Transform val_46 = this.transform;
            if(val_46 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_58 = 0;
            UnityEngine.Transform val_47 = val_46.parent;
            if(val_47 == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.UI.Graphic val_48 = val_47.GetComponent<UnityEngine.UI.Graphic>();
            val_57 = val_48;
            val_58 = 0;
            if(val_57 != val_58)
            {
                    if(val_56 == null)
            {
                    throw new NullReferenceException();
            }
            
                bool val_50 = val_42.Remove(item:  val_48);
            }
            else
            {
                    if(val_56 == null)
            {
                    throw new NullReferenceException();
            }
            
            }
            
            List.Enumerator<T> val_51 = val_42.GetEnumerator();
            label_79:
            val_58 = public System.Boolean List.Enumerator<UnityEngine.UI.Graphic>::MoveNext();
            if(((-1441670352) & 1) == 0)
            {
                goto label_73;
            }
            
            val_61 = val_5;
            if(val_61 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((val_61.gameObject == this.gameObject) || ((val_2.ContainsKey(key:  val_61)) == false))
            {
                goto label_79;
            }
            
            UnityEngine.Material val_56 = val_2.Item[val_61];
            goto label_79;
            label_73:
            mem[225] = 657;
            val_6.Dispose();
        }
        public SpriteRendererMask()
        {
            var val_4;
            var val_5;
            UnityEngine.Matrix4x4 val_6;
            var val_7;
            this._isMaskingEnabled = true;
            this._clampingBorder = 0.01f;
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  1f, y:  1f);
            this.mainTexTiling = val_1.x;
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  0f, y:  0f);
            this.fullMaskRefresh = true;
            this.mainTexOffset = val_2.x;
            UnityEngine.Matrix4x4 val_3 = UnityEngine.Matrix4x4.identity;
            mem[1152921528935407892] = val_5;
            mem[1152921528935407876] = val_4;
            mem[1152921528935407860] = val_7;
            this.oldWorldToMask = val_6;
            this.createdMatsStorage = new System.Collections.Generic.List<UnityEngine.Material>();
        }
    
    }

}
