using UnityEngine;
public class UIMaterialModifier : MonoBehaviour, IMaterialModifier
{
    // Fields
    private UnityEngine.Matrix4x4 maskMatrix;
    private UnityEngine.Vector4 tilingAndOffset;
    private bool screenSpaceEnabled;
    private UnityEngine.Texture alphaTexture;
    private bool maskingEnabled;
    private bool isTextMaterial;
    private bool clampHorizontal;
    private bool clampVertical;
    private float clampingBorder;
    private bool useAlphaChannel;
    private UnityEngine.Material modifiedMaterial;
    private UnityEngine.Material lastBaseMaterial;
    private int instanceID;
    private UnityEngine.UI.Image image;
    private UnityEngine.UI.Text text;
    
    // Methods
    private void Awake()
    {
        if(this.instanceID != this.GetInstanceID())
        {
                int val_2 = this.GetInstanceID();
            this.instanceID = val_2;
            if((this.instanceID != 0) && ((val_2 & 2147483648) != 0))
        {
                this.modifiedMaterial = 0;
        }
        
        }
        
        this.image = this.GetComponent<UnityEngine.UI.Image>();
        this.text = this.GetComponent<UnityEngine.UI.Text>();
    }
    private void OnDestroy()
    {
        UnityEngine.Object.DestroyImmediate(obj:  this.modifiedMaterial);
    }
    public void ApplyMaterialProperties(UnityEngine.Material target)
    {
        UnityEngine.UI.Text val_14;
        UnityEngine.Material val_15 = target;
        if(val_15 == 0)
        {
                val_15 = this.modifiedMaterial;
        }
        
        if(val_15 == 0)
        {
                return;
        }
        
        val_15.SetMatrix(name:  "_WorldToMask", value:  new UnityEngine.Matrix4x4() {m00 = this.maskMatrix, m10 = this.maskMatrix, m20 = this.maskMatrix, m30 = this.maskMatrix, m01 = ???, m11 = ???, m21 = ???, m31 = ???, m02 = ???, m12 = ???, m22 = ???, m32 = ???, m03 = ???, m13 = ???, m23 = ???, m33 = ???});
        val_15.SetTexture(name:  "_AlphaTex", value:  this.alphaTexture);
        val_15.SetVector(name:  "_AlphaTex_ST", value:  new UnityEngine.Vector4() {x = this.tilingAndOffset, y = ???, z = ???, w = this.maskMatrix});
        val_15.SetFloat(name:  "_IsThisText", value:  (this.isTextMaterial == false) ? 0f : 1f);
        val_15.SetFloat(name:  "_ClampHoriz", value:  (this.clampHorizontal == false) ? 0f : 1f);
        val_15.SetFloat(name:  "_ClampVert", value:  (this.clampVertical == false) ? 0f : 1f);
        val_15.SetFloat(name:  "_UseAlphaChannel", value:  (this.useAlphaChannel == false) ? 0f : 1f);
        val_15.SetFloat(name:  "_Enabled", value:  (this.maskingEnabled == false) ? 0f : 1f);
        val_15.SetFloat(name:  "_ClampingBorder", value:  this.clampingBorder);
        val_15.SetFloat(name:  "_ScreenSpaceUI", value:  (this.screenSpaceEnabled == false) ? 0f : 1f);
        if((UnityEngine.Object.op_Implicit(exists:  this.image)) != false)
        {
                UnityEngine.Color val_10 = this.image.color;
            val_15.SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = val_10.r, g = val_10.g, b = val_10.b, a = val_10.a});
        }
        
        val_14 = this.text;
        if((UnityEngine.Object.op_Implicit(exists:  val_14)) == false)
        {
                return;
        }
        
        UnityEngine.Color val_12 = this.text.color;
        val_15.SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.a});
    }
    public UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial)
    {
        UnityEngine.Material val_6 = this.lastBaseMaterial;
        if(baseMaterial != val_6)
        {
                this.lastBaseMaterial = baseMaterial;
            val_6 = this.modifiedMaterial;
            if(val_6 == 0)
        {
                UnityEngine.Material val_3 = null;
            val_6 = val_3;
            val_3 = new UnityEngine.Material(source:  baseMaterial);
            this.modifiedMaterial = val_6;
            val_3.name = baseMaterial.name + " modified";
        }
        else
        {
                this.modifiedMaterial.CopyPropertiesFromMaterial(mat:  baseMaterial);
        }
        
        }
        
        this.ApplyMaterialProperties(target:  this.modifiedMaterial);
        return (UnityEngine.Material)this.modifiedMaterial;
    }
    public void UpdateAlphaTex(UnityEngine.Texture alphaTexture)
    {
        if(this.alphaTexture == alphaTexture)
        {
                return;
        }
        
        this.alphaTexture = alphaTexture;
    }
    public void SetMaskToMaskee(UnityEngine.Matrix4x4 maskMatrix, UnityEngine.Vector4 tilingAndOffset, float clampingBorder, bool maskingEnabled, bool screenSpaceEnabled, bool clampHor, bool clampVert, bool useAlphaChannel, bool isTextMaterial)
    {
        this.tilingAndOffset = tilingAndOffset;
        mem[1152921518850798892] = tilingAndOffset.y;
        mem[1152921518850798896] = tilingAndOffset.z;
        mem[1152921518850798900] = tilingAndOffset.w;
        this.screenSpaceEnabled = screenSpaceEnabled;
        this.clampHorizontal = clampHor;
        this.clampVertical = clampVert;
        this.useAlphaChannel = useAlphaChannel;
        this.isTextMaterial = isTextMaterial;
        this.maskingEnabled = maskingEnabled;
        mem[1152921518850798872] = maskMatrix.m03;
        mem[1152921518850798856] = maskMatrix.m02;
        mem[1152921518850798840] = maskMatrix.m01;
        this.maskMatrix = maskMatrix.m00;
        this.clampingBorder = clampingBorder;
    }
    public UIMaterialModifier()
    {
        this.maskingEnabled = true;
        this.clampHorizontal = true;
        this.clampVertical = true;
        this.clampingBorder = 0.1f;
    }

}
