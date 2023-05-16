using UnityEngine;

namespace Development.ScreenCapture
{
    public static class ZzTransparencyCapture
    {
        // Methods
        public static UnityEngine.Texture2D Capture(UnityEngine.Rect pRect)
        {
            float val_17;
            float val_18;
            float val_23;
            float val_24;
            var val_25;
            var val_26;
            val_17 = pRect.m_Height;
            val_18 = pRect.m_YMin;
            UnityEngine.Camera val_1 = UnityEngine.Camera.main;
            UnityEngine.Color val_3 = val_1.backgroundColor;
            val_1.clearFlags = 2;
            UnityEngine.Color val_4 = UnityEngine.Color.black;
            val_1.backgroundColor = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
            val_1.Render();
            UnityEngine.Texture2D val_5 = Development.ScreenCapture.ZzTransparencyCapture.CaptureView(pRect:  new UnityEngine.Rect() {m_XMin = pRect.m_XMin, m_YMin = val_18, m_Width = pRect.m_Width, m_Height = val_17});
            UnityEngine.Color val_6 = UnityEngine.Color.white;
            val_1.backgroundColor = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
            val_1.Render();
            val_23 = pRect.m_XMin;
            val_24 = pRect.m_Width;
            UnityEngine.Texture2D val_7 = Development.ScreenCapture.ZzTransparencyCapture.CaptureView(pRect:  new UnityEngine.Rect() {m_XMin = val_23, m_YMin = val_18, m_Width = val_24, m_Height = val_17});
            if(val_7.width >= 1)
            {
                    var val_18 = 0;
                do
            {
                val_25 = public System.Int32 UnityEngine.Texture::get_height();
                if(val_7.height >= 1)
            {
                    var val_17 = 0;
                do
            {
                UnityEngine.Color val_10 = val_5.GetPixel(x:  0, y:  0);
                val_26 = val_18;
                val_17 = val_10.r;
                val_18 = val_10.b;
                UnityEngine.Color val_11 = val_7.GetPixel(x:  0, y:  0);
                UnityEngine.Color val_12 = UnityEngine.Color.clear;
                val_23 = val_17;
                val_24 = val_18;
                if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = val_23, g = val_10.g, b = val_24, a = val_10.a}, rhs:  new UnityEngine.Color() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.a})) != false)
            {
                    val_23 = val_17;
                val_24 = val_18;
                UnityEngine.Color val_14 = Development.ScreenCapture.ZzTransparencyCapture.GetColor(pColorWhenBlack:  new UnityEngine.Color() {r = val_23, g = val_10.g, b = val_24, a = val_10.a}, pColorWhenWhite:  new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a});
                val_26 = val_18;
                val_7.SetPixel(x:  0, y:  0, color:  new UnityEngine.Color() {r = val_14.r, g = val_14.g, b = val_14.b, a = val_14.a});
            }
            
                val_17 = val_17 + 1;
                val_25 = public System.Int32 UnityEngine.Texture::get_height();
            }
            while(val_17 < val_7.height);
            
            }
            
                val_18 = val_18 + 1;
            }
            while(val_18 < val_7.width);
            
            }
            
            val_7.Apply();
            UnityEngine.Object.DestroyImmediate(obj:  val_5);
            val_1.backgroundColor = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
            val_1.clearFlags = val_1.clearFlags;
            return val_7;
        }
        public static UnityEngine.Texture2D CaptureScreenshot()
        {
            int val_1 = UnityEngine.Screen.width;
            int val_2 = UnityEngine.Screen.height;
            return (UnityEngine.Texture2D)Development.ScreenCapture.ZzTransparencyCapture.Capture(pRect:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        }
        public static void CaptureScreenshot(string pFileName)
        {
            UnityEngine.Texture2D val_1 = Development.ScreenCapture.ZzTransparencyCapture.CaptureScreenshot();
            System.IO.FileStream val_2 = new System.IO.FileStream(path:  pFileName, mode:  2);
            System.IO.BinaryWriter val_3 = new System.IO.BinaryWriter(output:  val_2);
            System.Byte[] val_4 = UnityEngine.ImageConversion.EncodeToPNG(tex:  val_1);
            if(val_2 != null)
            {
                    var val_6 = 0;
                if(mem[1152921504641335296] != null)
            {
                    val_6 = val_6 + 1;
            }
            else
            {
                    System.IO.FileStream val_5 = 1152921504641298432 + ((mem[1152921504641335304]) << 4);
            }
            
                val_2.Dispose();
            }
            
            if(0 != 0)
            {
                    throw 0;
            }
            
            UnityEngine.Object.DestroyImmediate(obj:  val_1);
            if(0 != 0)
            {
                    throw 0;
            }
        
        }
        private static UnityEngine.Color GetColor(UnityEngine.Color pColorWhenBlack, UnityEngine.Color pColorWhenWhite)
        {
            float val_1 = 1f;
            val_1 = pColorWhenBlack.r + val_1;
            val_1 = val_1 - pColorWhenWhite.r;
            pColorWhenBlack.r = pColorWhenBlack.r / val_1;
            pColorWhenBlack.g = pColorWhenBlack.g / val_1;
            pColorWhenBlack.b = pColorWhenBlack.b / val_1;
            return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        private static float GetAlpha(float pColorWhenZero, float pColorWhenOne)
        {
            pColorWhenZero = pColorWhenZero + 1f;
            pColorWhenZero = pColorWhenZero - pColorWhenOne;
            return (float)pColorWhenZero;
        }
        private static UnityEngine.Texture2D CaptureView(UnityEngine.Rect pRect)
        {
            UnityEngine.Texture2D val_1 = new UnityEngine.Texture2D(width:  (int)pRect.m_XMin, height:  (int)pRect.m_XMin, textureFormat:  5, mipChain:  false);
            val_1.ReadPixels(source:  new UnityEngine.Rect() {m_XMin = pRect.m_XMin, m_YMin = pRect.m_YMin, m_Width = pRect.m_Width, m_Height = pRect.m_Height}, destX:  0, destY:  0, recalculateMipMaps:  false);
            return val_1;
        }
    
    }

}
