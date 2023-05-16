using UnityEngine;

namespace Royal.Infrastructure.Utils.Text
{
    public class TextProOnAnAnimationCurve : TextProOnACurve
    {
        // Fields
        public UnityEngine.AnimationCurve VertexCurve;
        public float CurveScale;
        public bool MaxThreeCheckDisabled;
        private float oldCurveScale;
        private UnityEngine.AnimationCurve oldCurve;
        
        // Methods
        public override void Start()
        {
            if(UnityEngine.Application.isPlaying != false)
            {
                    if(((((static_value_02D63000 != 0) && ((val_2 + 16) <= 3)) && (Royal.Infrastructure.Services.Localization.LocalizationHelper.isKorean != true)) && (Royal.Infrastructure.Services.Localization.LocalizationHelper.isJapanese != true)) && (this.MaxThreeCheckDisabled != true))
            {
                    this.CurveScale = 0f;
            }
            
            }
            
            this.ForceUpdate();
        }
        protected override bool ParametersHaveChanged()
        {
            float val_3;
            var val_4;
            float val_4 = 0.001f;
            val_4 = this.CurveScale + val_4;
            if(val_4 <= this.oldCurveScale)
            {
                goto label_1;
            }
            
            float val_5 = -0.001f;
            val_5 = this.CurveScale + val_5;
            if(val_5 >= 0)
            {
                goto label_1;
            }
            
            val_3 = this.CurveScale;
            val_4 = this.CurvesAreSame();
            goto label_2;
            label_1:
            val_3 = this.CurveScale;
            val_4 = 1;
            label_2:
            this.oldCurveScale = val_3;
            this.oldCurve = this.CopyAnimationCurve(curve:  this.VertexCurve);
            return (bool)val_4 & 1;
        }
        private bool CurvesAreSame()
        {
            UnityEngine.AnimationCurve val_31;
            float val_32;
            val_31 = this.oldCurve;
            if(val_31 == null)
            {
                    return (bool)val_31;
            }
            
            UnityEngine.Keyframe[] val_1 = val_31.keys;
            UnityEngine.Keyframe[] val_2 = this.VertexCurve.keys;
            if(val_1.Length != val_2.Length)
            {
                goto label_4;
            }
            
            UnityEngine.Keyframe[] val_3 = this.oldCurve.keys;
            if(val_3.Length == 0)
            {
                goto label_13;
            }
            
            UnityEngine.Keyframe[] val_4 = this.VertexCurve.keys;
            if(val_4.Length == 0)
            {
                goto label_13;
            }
            
            var val_31 = 0;
            var val_32 = 32;
            label_62:
            UnityEngine.Keyframe[] val_5 = this.VertexCurve.keys;
            if(val_31 >= val_5.Length)
            {
                goto label_13;
            }
            
            val_32 = V0.16B;
            val_31 = 1;
            if((S0 + 0.001f) <= val_32)
            {
                    return (bool)val_31;
            }
            
            if((S0 + (-0.001f)) >= 0)
            {
                    return (bool)val_31;
            }
            
            val_32 = this.oldCurve.keys[val_32].xPlacement;
            float val_13 = this.VertexCurve.keys[val_32].xPlacement;
            val_31 = 1;
            if((val_13 + 0.001f) <= val_32)
            {
                    return (bool)val_31;
            }
            
            val_13 = val_13 + (-0.001f);
            if(val_13 >= 0)
            {
                    return (bool)val_31;
            }
            
            val_32 = val_13;
            val_31 = 1;
            if((val_13 + 0.001f) <= val_32)
            {
                    return (bool)val_31;
            }
            
            val_13 = val_13 + (-0.001f);
            if(val_13 >= 0)
            {
                    return (bool)val_31;
            }
            
            val_32 = val_13;
            val_31 = 1;
            if((val_13 + 0.001f) <= val_32)
            {
                    return (bool)val_31;
            }
            
            val_13 = val_13 + (-0.001f);
            if(val_13 >= 0)
            {
                    return (bool)val_31;
            }
            
            val_32 = this.oldCurve.keys[val_32].xAdvance;
            float val_24 = this.VertexCurve.keys[val_32].xAdvance;
            val_31 = 1;
            if((val_24 + 0.001f) <= val_32)
            {
                    return (bool)val_31;
            }
            
            val_24 = val_24 + (-0.001f);
            if(val_24 >= 0)
            {
                    return (bool)val_31;
            }
            
            val_32 = this.oldCurve.keys[val_32].yPlacement;
            float val_29 = this.VertexCurve.keys[val_32].yPlacement;
            val_31 = 1;
            if((val_29 + 0.001f) <= val_32)
            {
                    return (bool)val_31;
            }
            
            val_29 = val_29 + (-0.001f);
            if(val_29 >= 0)
            {
                    return (bool)val_31;
            }
            
            val_31 = val_31 + 1;
            val_32 = val_32 + 28;
            if(this.VertexCurve != null)
            {
                goto label_62;
            }
            
            throw new NullReferenceException();
            label_4:
            val_31 = 1;
            return (bool)val_31;
            label_13:
            val_31 = 0;
            return (bool)val_31;
        }
        protected virtual UnityEngine.Vector3 GetCharScale(int index)
        {
            return UnityEngine.Vector3.one;
        }
        protected override UnityEngine.Matrix4x4 ComputeTransformationMatrix(UnityEngine.Vector3 charMidBaselinePos, float zeroToOnePos, TMPro.TMP_TextInfo textInfo, int charIdx)
        {
            float val_4;
            float val_8;
            UnityEngine.Matrix4x4 val_0;
            TMPro.TMP_MeshInfo[] val_22 = textInfo.meshInfo;
            var val_1 = (-4294967296) + ((textInfo.meshInfo.Length) << 32);
            val_1 = val_1 >> 32;
            val_22 = val_22 + (val_1 * 80);
            UnityEngine.Bounds val_2 = (((-4294967296 + (textInfo.meshInfo.Length) << 32) >> 32) * 80) + textInfo.meshInfo + 32.bounds;
            TMPro.TMP_MeshInfo[] val_23 = textInfo.meshInfo;
            var val_5 = (-4294967296) + ((textInfo.meshInfo.Length) << 32);
            val_5 = val_5 >> 32;
            val_23 = val_23 + (val_5 * 80);
            UnityEngine.Bounds val_6 = (((-4294967296 + (textInfo.meshInfo.Length) << 32) >> 32) * 80) + textInfo.meshInfo + 32.bounds;
            float val_10 = val_8 - val_4;
            float val_11 = (charMidBaselinePos.x - val_4) / val_10;
            float val_13 = val_11 + 0.0001f;
            val_11 = (this.VertexCurve.Evaluate(time:  val_11)) * this.CurveScale;
            float val_15 = (this.VertexCurve.Evaluate(time:  val_13)) * this.CurveScale;
            float val_16 = val_10 * val_13;
            val_16 = val_4 + val_16;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            float val_26 = 0f;
            float val_24 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_26, y = 0f, z = 0f}, rhs:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            val_24 = val_24 * 57.29578f;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_26, y = 0f, z = 0f}, rhs:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            float val_25 = 360f;
            val_25 = val_25 - val_24;
            val_26 = (val_19.z > 0f) ? (val_24) : (val_25);
            val_4 = 0;
            UnityEngine.Quaternion val_20 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  val_26);
            UnityEngine.Matrix4x4 val_21 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, q:  new UnityEngine.Quaternion() {x = val_20.x, y = val_20.y, z = val_20.z, w = val_20.w}, s:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.z, z = 0f});
            return val_0;
        }
        protected override void UpdateVertices(UnityEngine.Vector3 charMidBaselinePos, TMPro.TMP_TextInfo textInfo, int i)
        {
            TMPro.TMP_CharacterInfo[] val_10 = textInfo.characterInfo;
            TMPro.TMP_MeshInfo[] val_11 = textInfo.meshInfo;
            val_10 = val_10 + (i * 376);
            val_11 = val_11 + (((i * 376) + textInfo.characterInfo + 88) * 80);
            var val_13 = ((i * 376) + textInfo.characterInfo + 88 * 80) + textInfo.meshInfo + 48;
            var val_1 = val_13 + (((i * 376) + textInfo.characterInfo + 108) * 12);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((i * 376) + textInfo.characterInfo + 108 * 12) + ((i * 376) + textInfo.characterInfo + 88 * 80) + textInfo.meshInfo + 48 + 32, y = ((i * 376) + textInfo.characterInfo + 108 * 12) + ((i * 376) + textInfo.characterInfo + 88 * 80) + textInfo.meshInfo + 48 + 32 + 4, z = ((i * 376) + textInfo.characterInfo + 108 * 12) + ((i * 376) + textInfo.characterInfo + 88 * 80) + textInfo.meshInfo + 48 + 32 + 8}, b:  new UnityEngine.Vector3() {x = charMidBaselinePos.x, y = charMidBaselinePos.y, z = charMidBaselinePos.z});
            mem2[0] = val_2.x;
            mem2[0] = val_2.y;
            mem2[0] = val_2.z;
            var val_12 = 12;
            var val_4 = val_13 + ((((i * 376) + textInfo.characterInfo + 108) + 1) * val_12);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (((i * 376) + textInfo.characterInfo + 108 + 1) * 12) + ((i * 376) + textInfo.characterInfo + 88 * 80) + textInfo.meshInfo + 48 + 32, y = (((i * 376) + textInfo.characterInfo + 108 + 1) * 12) + ((i * 376) + textInfo.characterInfo + 88 * 80) + textInfo.meshInfo + 48 + 32 + 4, z = (((i * 376) + textInfo.characterInfo + 108 + 1) * 12) + ((i * 376) + textInfo.characterInfo + 88 * 80) + textInfo.meshInfo + 48 + 40}, b:  new UnityEngine.Vector3() {x = charMidBaselinePos.x, y = charMidBaselinePos.y, z = charMidBaselinePos.z});
            val_4 = val_5.x;
            val_4 = val_5.y;
            val_4 = val_5.z;
            val_12 = val_13 + ((((i * 376) + textInfo.characterInfo + 108) + 2) * val_12);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (((i * 376) + textInfo.characterInfo + 108 + 2) * 12) + ((i * 376) + textInfo.characterInfo + 88 * 80) + textInfo.meshInfo + 48 + 32, y = (((i * 376) + textInfo.characterInfo + 108 + 2) * 12) + ((i * 376) + textInfo.characterInfo + 88 * 80) + textInfo.meshInfo + 48 + 32 + 4, z = (((i * 376) + textInfo.characterInfo + 108 + 2) * 12) + ((i * 376) + textInfo.characterInfo + 88 * 80) + textInfo.meshInfo + 48 + 40}, b:  new UnityEngine.Vector3() {x = charMidBaselinePos.x, y = charMidBaselinePos.y, z = charMidBaselinePos.z});
            val_12 = val_7.x;
            val_12 = val_7.y;
            val_12 = val_7.z;
            val_13 = val_13 + ((((i * 376) + textInfo.characterInfo + 108) + 3) * 12);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (((i * 376) + textInfo.characterInfo + 108 + 3) * 12) + ((i * 376) + textInfo.characterInfo + 88 * 80) + textInfo.meshInfo + 48 + 32, y = (((i * 376) + textInfo.characterInfo + 108 + 3) * 12) + ((i * 376) + textInfo.characterInfo + 88 * 80) + textInfo.meshInfo + 48 + 32 + 4, z = (((i * 376) + textInfo.characterInfo + 108 + 3) * 12) + ((i * 376) + textInfo.characterInfo + 88 * 80) + textInfo.meshInfo + 48 + 40}, b:  new UnityEngine.Vector3() {x = charMidBaselinePos.x, y = charMidBaselinePos.y, z = charMidBaselinePos.z});
            val_13 = val_9.x;
            val_13 = val_9.y;
            val_13 = val_9.z;
        }
        private UnityEngine.AnimationCurve CopyAnimationCurve(UnityEngine.AnimationCurve curve)
        {
            UnityEngine.AnimationCurve val_1 = new UnityEngine.AnimationCurve();
            val_1.keys = curve.keys;
            return val_1;
        }
        public TextProOnAnAnimationCurve()
        {
            this.CurveScale = 1f;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
