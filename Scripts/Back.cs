using UnityEngine;
public static class ManualEasing.Back
{
    // Fields
    private const float S = 1.70158;
    private const float S2 = 2.594909;
    
    // Methods
    public static float In(float t)
    {
        t = t * 2.70158f;
        t = t + (-1.70158f);
        t = (t * t) * t;
        return (float)t;
    }
    public static float In(float t, float overshootAmplitude)
    {
        overshootAmplitude = overshootAmplitude * 1.70158f;
        float val_2 = 1f;
        val_2 = overshootAmplitude + val_2;
        t = val_2 * t;
        t = t - overshootAmplitude;
        t = (t * t) * t;
        return (float)t;
    }
    public static float Out(float t, float overshootAmplitude)
    {
        float val_2 = -1f;
        t = t + val_2;
        val_2 = t * t;
        overshootAmplitude = overshootAmplitude * 1.70158f;
        t = t * (overshootAmplitude + 1f);
        t = overshootAmplitude + t;
        t = val_2 * t;
        t = t + 1f;
        return (float)t;
    }
    public static float Out(float t)
    {
        float val_1 = -1f;
        t = t + val_1;
        val_1 = t * t;
        t = t * 2.70158f;
        t = t + 1.70158f;
        t = val_1 * t;
        t = t + 1f;
        return (float)t;
    }
    public static float InOut(float t)
    {
        float val_2;
        t = t + t;
        if(t < 0)
        {
                t = t * 3.594909f;
            t = t + (-2.594909f);
            val_2 = (t * t) * t;
        }
        else
        {
                float val_2 = -2f;
            t = t + val_2;
            val_2 = t * t;
            t = t * 3.594909f;
            t = t + 2.594909f;
            t = val_2 * t;
            val_2 = t + 2f;
        }
        
        val_2 = val_2 * 0.5f;
        return (float)val_2;
    }
    public static float InOut(float t, float overshootAmplitude)
    {
        float val_4;
        float val_1 = t + t;
        float val_4 = 1f;
        float val_2 = overshootAmplitude * 2.594909f;
        if(val_1 < 0)
        {
                val_4 = val_2 + val_4;
            val_1 = val_1 * val_4;
            val_2 = val_1 - val_2;
            val_4 = (val_1 * val_1) * val_2;
        }
        else
        {
                float val_5 = -2f;
            val_4 = val_2 + val_4;
            val_5 = val_1 + val_5;
            val_1 = val_5 * val_5;
            val_5 = val_5 * val_4;
            val_2 = val_2 + val_5;
            val_2 = val_1 * val_2;
            val_4 = val_2 + 2f;
        }
        
        val_4 = val_4 * 0.5f;
        return (float)val_4;
    }

}
