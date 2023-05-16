using UnityEngine;

namespace Royal.Infrastructure.Utils.Text
{
    public abstract class TextProOnACurve : MonoBehaviour
    {
        // Fields
        protected TMPro.TMP_Text m_TextComponent;
        protected bool isUpdateEnabled;
        
        // Methods
        private void Awake()
        {
            this.m_TextComponent = this.gameObject.GetComponent<TMPro.TMP_Text>();
        }
        public virtual void Start()
        {
            this.ForceUpdate();
        }
        private void OnEnable()
        {
            this.ForceUpdate();
        }
        public void ForceUpdate()
        {
            if(this.m_TextComponent == 0)
            {
                    this.m_TextComponent = this.gameObject.GetComponent<TMPro.TMP_Text>();
            }
            
            this.UpdateText();
        }
        protected void LateUpdate()
        {
            if(UnityEngine.Application.isPlaying != false)
            {
                    if(this.isUpdateEnabled == false)
            {
                    return;
            }
            
            }
            
            if(this.m_TextComponent.m_havePropertiesChanged != true)
            {
                    if((this & 1) == 0)
            {
                    return;
            }
            
            }
            
            this.UpdateText();
        }
        public void EnableUpdate(bool enable)
        {
            this.isUpdateEnabled = enable;
        }
        private void UpdateText()
        {
            float val_3;
            float val_6;
            Royal.Infrastructure.Utils.Text.TextProOnACurve val_28;
            TMPro.TMP_TextInfo val_29;
            var val_30;
            var val_31;
            val_28 = this;
            val_29 = this.m_TextComponent.m_textInfo;
            if(this.m_TextComponent.m_textInfo.characterCount == 0)
            {
                    return;
            }
            
            UnityEngine.Bounds val_1 = this.m_TextComponent.bounds;
            UnityEngine.Bounds val_4 = this.m_TextComponent.bounds;
            if(this.m_TextComponent.m_textInfo.characterCount < 1)
            {
                    return;
            }
            
            val_30 = 0;
            val_31 = 404;
            do
            {
                if(this.m_TextComponent.m_textInfo.characterInfo[1] != 0)
            {
                    TMPro.TMP_CharacterInfo[] val_8 = this.m_TextComponent.m_textInfo.characterInfo[404] - 316;
                this.m_TextComponent.m_textInfo.characterInfo[404] = this.m_TextComponent.m_textInfo.characterInfo[404] - 296;
                TMPro.TMP_CharacterInfo[] val_9 = mem[273008190768] + (1152921508019449360 * 12);
                var val_10 = mem[273008190768] + ((long)this.m_TextComponent.m_textInfo.characterInfo[404] * 12);
                float val_30 = X27;
                val_30 = val_30 + (((long)(int)((this.m_TextComponent.m_textInfo.characterInfo[0x194] - 296)) * 12) + mem[273008190768] + 32);
                val_30 = val_30 * 0.5f;
                val_6 = 0;
                UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  val_30, y:  -1.521614E+07f);
                UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
                TMPro.TMP_CharacterInfo[] val_13 = mem[273008190768] + (1152921508019449360 * 12);
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = X27, y = (1152921508019449360 * 12) + mem[273008190768] + 40 + -4, z = mem[(1152921508019449360 * 12) + mem[273008190768] + 40]}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
                mem2[0] = val_15.x;
                mem2[0] = val_15.y;
                mem2[0] = val_15.z;
                UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
                UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((long)(int)(UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished) * 12) + mem[273008190768] + 32, y = ((long)(int)(UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished) * 12) + mem[273008190768] + 32 + 4, z = ((long)(int)(UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished) * 12) + mem[273008190768] + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
                mem2[0] = val_18.x;
                mem2[0] = val_18.y;
                mem2[0] = val_18.z;
                float val_31 = ((long)(int)((this.m_TextComponent.m_textInfo.characterInfo[0x194] - 296)) * 12) + mem[273008190768] + 32;
                var val_19 = mem[273008190768] + ((long)this.m_TextComponent.m_textInfo.characterInfo[404] * 12);
                UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
                UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_31, y = ((long)(int)((this.m_TextComponent.m_textInfo.characterInfo[0x194] - 296)) * 12) + mem[273008190768] + 40 + -4, z = ((long)(int)((this.m_TextComponent.m_textInfo.characterInfo[0x194] - 296)) * 12) + mem[273008190768] + 40}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
                val_31 = val_21.x;
                mem2[0] = val_21.y;
                mem2[0] = val_21.z;
                var val_22 = mem[273008190768] + (((long)mem[273008190768] + 24) * 12);
                UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
                UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((long)(int)(mem[273008190768] + 24) * 12) + mem[273008190768] + 32, y = ((long)(int)(mem[273008190768] + 24) * 12) + mem[273008190768] + 32 + 4, z = ((long)(int)(mem[273008190768] + 24) * 12) + mem[273008190768] + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
                mem2[0] = val_24.x;
                mem2[0] = val_24.y;
                mem2[0] = val_24.z;
                float val_26 = (val_12.x - val_3) / (val_6 - val_3);
                ??? = ???;
                (1152921508019449360 * 12) + mem[273008190768] + 40 + -4 = (1152921508019449360 * 12) + mem[273008190768] + 40 + -4;
                (1152921508019449360 * 12) + mem[273008190768] + 40 = (1152921508019449360 * 12) + mem[273008190768] + 40;
                mem2[0] = ((long)(int)(UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished) * 12) + mem[273008190768] + 32;
                ((long)(int)(UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished) * 12) + mem[273008190768] + 32 + 4 = ((long)(int)(UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished) * 12) + mem[273008190768] + 32 + 4;
                ((long)(int)(UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished) * 12) + mem[273008190768] + 32 + 8 = ((long)(int)(UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished) * 12) + mem[273008190768] + 32 + 8;
                ((long)(int)((this.m_TextComponent.m_textInfo.characterInfo[0x194] - 296)) * 12) + mem[273008190768] + 32 = ((long)(int)((this.m_TextComponent.m_textInfo.characterInfo[0x194] - 296)) * 12) + mem[273008190768] + 32;
                ((long)(int)((this.m_TextComponent.m_textInfo.characterInfo[0x194] - 296)) * 12) + mem[273008190768] + 40 + -4 = ((long)(int)((this.m_TextComponent.m_textInfo.characterInfo[0x194] - 296)) * 12) + mem[273008190768] + 40 + -4;
                mem2[0] = ((long)(int)((this.m_TextComponent.m_textInfo.characterInfo[0x194] - 296)) * 12) + mem[273008190768] + 40;
                mem2[0] = ((long)(int)(mem[273008190768] + 24) * 12) + mem[273008190768] + 32;
                ((long)(int)(mem[273008190768] + 24) * 12) + mem[273008190768] + 32 + 4 = ((long)(int)(mem[273008190768] + 24) * 12) + mem[273008190768] + 32 + 4;
                mem2[0] = ((long)(int)(mem[273008190768] + 24) * 12) + mem[273008190768] + 32 + 8;
                val_29 = val_29;
                val_28 = val_28;
                val_30 = val_30;
                val_31 = 404;
            }
            
                val_30 = val_30 + 1;
                val_31 = val_31 + 376;
            }
            while(val_30 < this.m_TextComponent.m_textInfo.characterCount);
        
        }
        protected abstract void UpdateVertices(UnityEngine.Vector3 charMidBaselinePos, TMPro.TMP_TextInfo textInfo, int i); // 0
        protected abstract bool ParametersHaveChanged(); // 0
        protected abstract UnityEngine.Matrix4x4 ComputeTransformationMatrix(UnityEngine.Vector3 charMidBaselinePos, float zeroToOnePos, TMPro.TMP_TextInfo textInfo, int charIdx); // 0
        protected TextProOnACurve()
        {
        
        }
    
    }

}
