using UnityEngine;
public static class Packer
{
    // Methods
    public static float ToFloat(float x, float y, float z, float w)
    {
        float val_9;
        float val_10;
        float val_11;
        float val_12;
        val_9 = 0f;
        val_10 = 0f;
        if(x >= 0)
        {
                val_10 = x;
            if(x > 1f)
        {
                val_10 = 1f;
        }
        
        }
        
        if(y >= 0)
        {
                val_9 = y;
            if(y > 1f)
        {
                val_9 = 1f;
        }
        
        }
        
        val_11 = 0f;
        val_12 = 0f;
        if(z >= 0)
        {
                val_12 = z;
            if(z > 1f)
        {
                val_12 = 1f;
        }
        
        }
        
        if(w >= 0)
        {
                float val_9 = 1f;
            val_11 = w;
            if(w > val_9)
        {
                val_11 = val_9;
        }
        
        }
        
        val_9 = val_11 * 63f;
        int val_8 = (UnityEngine.Mathf.FloorToInt(f:  val_12 * 63f)) << 12;
        val_8 = val_8 + ((UnityEngine.Mathf.FloorToInt(f:  val_9)) << 18);
        val_8 = val_8 + ((UnityEngine.Mathf.FloorToInt(f:  val_9 * 63f)) << 6);
        val_8 = val_8 + (UnityEngine.Mathf.FloorToInt(f:  val_10 * 63f));
        return (float)(float)val_8;
    }
    public static float ToFloat(UnityEngine.Vector4 factor)
    {
        return Packer.ToFloat(x:  UnityEngine.Mathf.Clamp01(value:  factor.x), y:  UnityEngine.Mathf.Clamp01(value:  factor.y), z:  UnityEngine.Mathf.Clamp01(value:  factor.z), w:  UnityEngine.Mathf.Clamp01(value:  factor.w));
    }
    public static float ToFloat(float x, float y, float z)
    {
        float val_7;
        float val_8;
        float val_9;
        val_7 = 0f;
        val_8 = 0f;
        if(x >= 0)
        {
                val_8 = x;
            if(x > 1f)
        {
                val_8 = 1f;
        }
        
        }
        
        if(y >= 0)
        {
                val_7 = y;
            if(y > 1f)
        {
                val_7 = 1f;
        }
        
        }
        
        val_9 = 0f;
        if(z >= 0)
        {
                float val_7 = 1f;
            val_9 = z;
            if(z > val_7)
        {
                val_9 = val_7;
        }
        
        }
        
        val_7 = val_9 * 255f;
        int val_6 = (UnityEngine.Mathf.FloorToInt(f:  val_7 * 255f)) << 8;
        val_6 = val_6 + ((UnityEngine.Mathf.FloorToInt(f:  val_7)) << 16);
        val_6 = val_6 + (UnityEngine.Mathf.FloorToInt(f:  val_8 * 255f));
        return (float)(float)val_6;
    }
    public static float ToFloat(float x, float y)
    {
        float val_5;
        float val_6;
        val_5 = 0f;
        val_6 = 0f;
        if(x >= 0)
        {
                val_6 = x;
            if(x > 1f)
        {
                val_6 = 1f;
        }
        
        }
        
        if(y >= 0)
        {
                float val_5 = 1f;
            val_5 = y;
            if(y > val_5)
        {
                val_5 = val_5;
        }
        
        }
        
        val_5 = val_5 * 4095f;
        return (float)(float)(UnityEngine.Mathf.FloorToInt(f:  val_6 * 4095f)) + ((UnityEngine.Mathf.FloorToInt(f:  val_5)) << 12);
    }

}
