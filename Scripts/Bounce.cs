using UnityEngine;
public static class ManualEasing.Bounce
{
    // Methods
    public static float In(float t)
    {
        t = 1f - t;
        float val_1 = ManualEasing.Bounce.Out(t:  t);
        val_1 = 1f - val_1;
        return (float)val_1;
    }
    public static float Out(float t)
    {
        if(t < 0)
        {
                float val_1 = 7.5625f;
            val_1 = t * val_1;
            t = val_1 * t;
            return (float)t;
        }
        
        if(t < 0)
        {
                float val_2 = -0.5454546f;
            t = t + val_2;
            val_2 = t * 7.5625f;
            t = t * val_2;
            t = t + 0.75f;
            return (float)t;
        }
        
        if(t < 0)
        {
                float val_3 = -0.8181818f;
            t = t + val_3;
            val_3 = t * 7.5625f;
            t = t * val_3;
            t = t + 0.9375f;
            return (float)t;
        }
        
        float val_4 = -0.9545454f;
        t = t + val_4;
        val_4 = t * 7.5625f;
        t = t * val_4;
        t = t + 0.984375f;
        return (float)t;
    }
    public static float InOut(float t)
    {
        t = t + t;
        if(t < 0)
        {
                t = 1f - t;
            float val_1 = ManualEasing.Bounce.Out(t:  t);
            val_1 = 1f - val_1;
            val_1 = val_1 * 0.5f;
            return (float)val_2;
        }
        
        t = t + (-1f);
        float val_2 = ManualEasing.Bounce.Out(t:  t);
        val_2 = val_2 * 0.5f;
        val_2 = val_2 + 0.5f;
        return (float)val_2;
    }

}
