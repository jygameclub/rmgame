using UnityEngine;

namespace Coffee.UIExtensions
{
    public static class EffectAreaExtensions
    {
        // Fields
        private static readonly UnityEngine.Rect rectForCharacter;
        private static readonly UnityEngine.Vector2[] splitedCharacterPosition;
        
        // Methods
        public static UnityEngine.Rect GetEffectArea(Coffee.UIExtensions.EffectArea area, UnityEngine.UI.VertexHelper vh, UnityEngine.Rect rectangle, float aspectRatio = -1)
        {
            float val_2;
            float val_3;
            float val_11;
            float val_12;
            var val_13;
            float val_14;
            float val_15;
            var val_16;
            val_11 = rectangle.m_Width;
            val_12 = rectangle.m_XMin;
            val_13 = vh;
            if(area == 2)
            {
                goto label_1;
            }
            
            if(area == 1)
            {
                goto label_2;
            }
            
            goto label_12;
            label_2:
            if(val_13.currentVertCount < 1)
            {
                goto label_5;
            }
            
            var val_11 = 0;
            do
            {
                val_13.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), tangent = new UnityEngine.Vector4(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2()}, i:  0);
                val_11 = UnityEngine.Mathf.Min(a:  3.402823E+38f, b:  val_2);
                val_14 = UnityEngine.Mathf.Min(a:  3.402823E+38f, b:  val_3);
                val_12 = UnityEngine.Mathf.Max(a:  -3.402823E+38f, b:  val_2);
                val_15 = UnityEngine.Mathf.Max(a:  -3.402823E+38f, b:  val_3);
                val_11 = val_11 + 1;
            }
            while(val_11 < val_13.currentVertCount);
            
            goto label_9;
            label_1:
            val_13 = 1152921505155887104;
            val_16 = null;
            val_16 = null;
            goto label_12;
            label_5:
            val_12 = -3.402823E+38f;
            val_11 = 3.402823E+38f;
            val_15 = val_12;
            val_14 = val_11;
            label_9:
            float val_9 = val_12 - val_11;
            float val_10 = val_15 - val_14;
            float val_12 = val_11;
            label_12:
            if(aspectRatio <= 0f)
            {
                    return new UnityEngine.Rect() {m_XMin = Coffee.UIExtensions.EffectAreaExtensions.rectForCharacter, m_YMin = Coffee.UIExtensions.EffectAreaExtensions.rectForCharacter, m_Width = Coffee.UIExtensions.EffectAreaExtensions.rectForCharacter, m_Height = Coffee.UIExtensions.EffectAreaExtensions.rectForCharacter};
            }
            
            if(val_12 < 0)
            {
                    val_12 = val_12 * aspectRatio;
                return new UnityEngine.Rect() {m_XMin = Coffee.UIExtensions.EffectAreaExtensions.rectForCharacter, m_YMin = Coffee.UIExtensions.EffectAreaExtensions.rectForCharacter, m_Width = Coffee.UIExtensions.EffectAreaExtensions.rectForCharacter, m_Height = Coffee.UIExtensions.EffectAreaExtensions.rectForCharacter};
            }
            
            val_12 = val_12 / aspectRatio;
            return new UnityEngine.Rect() {m_XMin = Coffee.UIExtensions.EffectAreaExtensions.rectForCharacter, m_YMin = Coffee.UIExtensions.EffectAreaExtensions.rectForCharacter, m_Width = Coffee.UIExtensions.EffectAreaExtensions.rectForCharacter, m_Height = Coffee.UIExtensions.EffectAreaExtensions.rectForCharacter};
        }
        public static void GetPositionFactor(Coffee.UIExtensions.EffectArea area, int index, UnityEngine.Rect rect, UnityEngine.Vector2 position, bool isText, bool isTMPro, out float x, out float y)
        {
            var val_10;
            var val_11;
            var val_12;
            float val_13;
            float val_15;
            val_10 = isTMPro;
            val_11 = isText;
            int val_10 = index;
            if((area == 2) && (val_11 != false))
            {
                    val_11 = 1152921505155887104;
                int val_1 = val_10 + 3;
                var val_2 = (val_10 != true) ? (val_1) : (val_10);
                val_12 = null;
                val_1 = val_2 + 3;
                val_10 = (val_2 < 0) ? (val_1) : (val_2);
                val_12 = null;
                UnityEngine.Vector2[] val_11 = Coffee.UIExtensions.EffectAreaExtensions.splitedCharacterPosition;
                var val_3 = val_10 & 4294967292;
                val_3 = val_2 - val_3;
                val_11 = val_11 + (((long)(int)((val_10 != true ? (index + 3) : index - (val_2 < 0x0 ? (val_10 != true ? (index + 3) : index + 3) : val_10 != true ? (index + 3) : index & 4294967292)))) << 3);
                x = (Coffee.UIExtensions.EffectAreaExtensions.splitedCharacterPosition + ((long)(int)((val_10 != true ? (index + 3) : index - (val_2 < 0x0 ? (val_10 != true ? (index + 3) : index + 3) : val_10 != true ? ( + 32;
                UnityEngine.Vector2[] val_4 = Coffee.UIExtensions.EffectAreaExtensions.splitedCharacterPosition + (((long)(int)((val_10 != true ? (index + 3) : index - (val_2 < 0x0 ? (val_10 != true ? (index + 3) : index + 3) : val_10 != true ? (index + 3) : index & 4294967292)))) << 3);
                y = (Coffee.UIExtensions.EffectAreaExtensions.splitedCharacterPosition + ((long)(int)((val_10 != true ? (index + 3) : index - (val_2 < 0x0 ? (val_10 != true ? (index + 3) : index + 3) : val_10 != true ? ( + 36;
                return;
            }
            
            if(area == 1)
            {
                    float val_5 = rect.m_XMin.System.IConvertible.ToSingle(provider:  0);
                val_13 = val_5;
                val_5 = position.x - val_13;
                val_5 = val_5 / val_5;
                float val_6 = UnityEngine.Mathf.Clamp01(value:  val_5);
                x = val_6;
                val_15 = (position.y - val_6) / val_6;
            }
            else
            {
                    val_13 = rect.m_XMin;
                rect.m_XMin = position.x / val_13;
                rect.m_XMin = rect.m_XMin + 0.5f;
                float val_8 = UnityEngine.Mathf.Clamp01(value:  rect.m_XMin);
                x = val_8;
                val_8 = position.y / val_8;
                val_15 = val_8 + 0.5f;
            }
            
            y = UnityEngine.Mathf.Clamp01(value:  val_15);
        }
        public static void GetNormalizedFactor(Coffee.UIExtensions.EffectArea area, int index, Coffee.UIExtensions.Matrix2x3 matrix, UnityEngine.Vector2 position, bool isText, out UnityEngine.Vector2 nomalizedPos)
        {
            var val_6;
            var val_7;
            float val_8;
            float val_9;
            Coffee.UIExtensions.Matrix2x3 val_10;
            if((area == 2) && (isText != false))
            {
                    val_6 = 1152921505155887104;
                val_7 = null;
                val_7 = null;
                UnityEngine.Vector2[] val_5 = Coffee.UIExtensions.EffectAreaExtensions.splitedCharacterPosition;
                int val_1 = index + 3;
                var val_3 = (val_1 < 0) ? (index + 6) : (val_1);
                val_3 = val_3 & 4294967292;
                val_1 = val_1 - val_3;
                val_5 = val_5 + (((long)(int)(((index + 3) - (val_1 < 0 ? (index + 6) : (index + 3) & 4294967292)))) << 3);
                val_8 = mem[(Coffee.UIExtensions.EffectAreaExtensions.splitedCharacterPosition + ((long)(int)(((index + 3) - (val_1 < 0 ? (index + 6) : (index + 3) & 4294967292)))) << 3) + 32];
                val_8 = (Coffee.UIExtensions.EffectAreaExtensions.splitedCharacterPosition + ((long)(int)(((index + 3) - (val_1 < 0 ? (index + 6) : (index + 3) & 4294967292)))) << 3) + 32;
                val_9 = mem[(Coffee.UIExtensions.EffectAreaExtensions.splitedCharacterPosition + ((long)(int)(((index + 3) - (val_1 < 0 ? (index + 6) : (index + 3) & 4294967292)))) << 3) + 32 + 4];
                val_9 = (Coffee.UIExtensions.EffectAreaExtensions.splitedCharacterPosition + ((long)(int)(((index + 3) - (val_1 < 0 ? (index + 6) : (index + 3) & 4294967292)))) << 3) + 32 + 4;
            }
            else
            {
                    val_10;
                val_9 = position.y;
                val_8 = position.x;
            }
            
            UnityEngine.Vector2 val_4 = Coffee.UIExtensions.Matrix2x3.op_Multiply(m:  new Coffee.UIExtensions.Matrix2x3() {m00 = matrix.m00, m11 = matrix.m11}, v:  new UnityEngine.Vector2() {x = val_8, y = val_9});
            nomalizedPos.x = val_4.x;
            nomalizedPos.y = val_4.y;
        }
        private static EffectAreaExtensions()
        {
            Coffee.UIExtensions.EffectAreaExtensions.rectForCharacter = 0;
            UnityEngine.Vector2[] val_1 = new UnityEngine.Vector2[4];
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.up;
            val_1[0] = val_2;
            val_1[0] = val_2.y;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.one;
            val_1[1] = val_3;
            val_1[1] = val_3.y;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.right;
            val_1[2] = val_4;
            val_1[2] = val_4.y;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
            val_1[3] = val_5;
            val_1[3] = val_5.y;
            Coffee.UIExtensions.EffectAreaExtensions.splitedCharacterPosition = val_1;
        }
    
    }

}
