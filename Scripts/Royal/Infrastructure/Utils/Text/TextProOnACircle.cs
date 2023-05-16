using UnityEngine;

namespace Royal.Infrastructure.Utils.Text
{
    public class TextProOnACircle : TextProOnACurve
    {
        // Fields
        private float m_radius;
        private float m_arcDegrees;
        private float m_angularOffset;
        private float m_oldRadius;
        private float m_oldArcDegrees;
        private float m_oldAngularOffset;
        
        // Methods
        protected override bool ParametersHaveChanged()
        {
            float val_2;
            float val_3;
            var val_4;
            if(this.m_radius != this.m_oldRadius)
            {
                goto label_0;
            }
            
            val_2 = this;
            val_3 = this.m_arcDegrees;
            if(this.m_arcDegrees != this.m_oldArcDegrees)
            {
                goto label_1;
            }
            
            var val_1 = (this.m_angularOffset != this.m_oldAngularOffset) ? 1 : 0;
            goto label_2;
            label_0:
            val_3 = this.m_arcDegrees;
            val_2 = this.m_oldArcDegrees;
            label_1:
            val_4 = 1;
            label_2:
            this.m_oldRadius = this.m_radius;
            val_2 = val_3;
            this.m_oldAngularOffset = this.m_angularOffset;
            return (bool)val_4;
        }
        protected override UnityEngine.Matrix4x4 ComputeTransformationMatrix(UnityEngine.Vector3 charMidBaselinePos, float zeroToOnePos, TMPro.TMP_TextInfo textInfo, int charIdx)
        {
            UnityEngine.Matrix4x4 val_0;
            float val_8 = this.m_arcDegrees;
            float val_7 = -0.5f;
            val_7 = zeroToOnePos + val_7;
            val_8 = val_7 * val_8;
            val_8 = val_8 + this.m_angularOffset;
            float val_1 = val_8 * 0.01745329f;
            TMPro.TMP_CharacterInfo[] val_9 = textInfo.characterInfo;
            val_9 = val_9 + (charIdx * 376);
            TMPro.TMP_LineInfo val_10 = textInfo.lineInfo[1];
            float val_11 = (float)(charIdx * 376) + textInfo.characterInfo + 100;
            val_11 = val_10 * val_11;
            val_10 = this.m_radius - val_11;
            val_11 = val_1 * val_10;
            val_10 = -(val_1 * val_10);
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_11, y:  val_10);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.forward;
            float val_12 = -57.29578f;
            val_12 = val_1 * val_12;
            val_12 = val_12 + (-90f);
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.AngleAxis(angle:  val_12, axis:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            UnityEngine.Matrix4x4 val_6 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, q:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, s:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.z});
            return val_0;
        }
        protected override void UpdateVertices(UnityEngine.Vector3 charMidBaselinePos, TMPro.TMP_TextInfo textInfo, int i)
        {
        
        }
        public TextProOnACircle()
        {
            this.m_radius = ;
            this.m_arcDegrees = ;
            this.m_angularOffset = -90f;
            this.m_oldRadius = 3.402823E+38f;
            this.m_oldArcDegrees = -1.175494E-38f;
            this.m_oldAngularOffset = 3.389531E+38f;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
