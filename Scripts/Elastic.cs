using UnityEngine;
public static class ManualEasing.Elastic
{
    // Fields
    private const float S = 1.70158;
    
    // Methods
    public static float In(float t)
    {
        return ManualEasing.Elastic.In(t:  t, overshootAmplitude:  1f, period:  0f);
    }
    public static float Out(float t)
    {
        return ManualEasing.Elastic.Out(t:  t, overshootAmplitude:  1f, period:  0f);
    }
    public static float InOut(float t)
    {
        return ManualEasing.Elastic.InOut(t:  t, overshootAmplitude:  1f, period:  0f);
    }
    public static float In(float t, float overshootAmplitude = 1, float period = 0)
    {
        float val_6;
        float val_7;
        float val_8;
        val_6 = overshootAmplitude;
        val_7 = t;
        if(val_7 == 0f)
        {
                return (float)val_7;
        }
        
        if(val_7 == 1f)
        {
                return (float)val_7;
        }
        
        float val_4 = 1.70158f;
        val_6 = val_6 * val_4;
        float val_1 = (period == 0f) ? 0.3f : period;
        if(val_6 < 0)
        {
                val_8 = val_1 * 0.25f;
            val_6 = 1f;
        }
        else
        {
                val_4 = 1f / val_6;
            float val_5 = 6.283185f;
            val_5 = val_1 / val_5;
            val_8 = val_5 * val_4;
        }
        
        float val_2 = val_7 + (-1f);
        float val_6 = 10f;
        val_6 = val_2 * val_6;
        val_7 = val_6;
        float val_7 = 6.283185f;
        val_5 = val_2 - val_8;
        val_7 = val_5 * val_7;
        val_7 = val_7 / val_1;
        val_7 = -((val_7 * val_6) * val_7);
        return (float)val_7;
    }
    public static float Out(float t, float overshootAmplitude = 1, float period = 0)
    {
        float val_6;
        float val_7;
        float val_8;
        val_6 = overshootAmplitude;
        if(t == 0f)
        {
                return (float)val_6;
        }
        
        if(t == 1f)
        {
                return (float)val_6;
        }
        
        float val_3 = 1.70158f;
        val_7 = val_6 * val_3;
        val_6 = 1f;
        float val_1 = (period == 0f) ? 0.3f : period;
        if(val_7 < 0)
        {
                val_8 = val_1 * 0.25f;
            val_7 = val_6;
        }
        else
        {
                val_3 = val_6 / val_7;
            float val_4 = 6.283185f;
            val_4 = val_1 / val_4;
            val_8 = val_4 * val_3;
        }
        
        float val_5 = -10f;
        val_5 = t * val_5;
        float val_6 = 6.283185f;
        val_4 = t - val_8;
        val_6 = val_4 * val_6;
        val_6 = val_6 / val_1;
        val_6 = (val_5 * val_7) * val_6;
        val_6 = val_6 + val_6;
        return (float)val_6;
    }
    public static float InOut(float t, float overshootAmplitude = 1, float period = 0)
    {
        float val_7;
        float val_8;
        float val_9;
        float val_10;
        val_7 = period;
        val_8 = t;
        if(val_8 == 0f)
        {
                return (float)val_10;
        }
        
        float val_1 = val_8 + val_8;
        if(val_1 == 2f)
        {
                return (float)val_10;
        }
        
        float val_5 = 1.70158f;
        val_9 = overshootAmplitude * val_5;
        float val_2 = (val_7 == 0f) ? 0.45f : (val_7);
        if(val_9 < 0)
        {
                val_10 = val_2 * 0.25f;
            val_9 = 1f;
        }
        else
        {
                val_5 = 1f / val_9;
            float val_6 = 6.283185f;
            val_6 = val_2 / val_6;
            val_10 = val_6 * val_5;
        }
        
        val_1 = val_1 + (-1f);
        if(val_1 < 0)
        {
                float val_7 = 10f;
            val_7 = val_1 * val_7;
            val_7 = val_7;
            float val_8 = 6.283185f;
            val_6 = val_1 - val_10;
            val_8 = val_6 * val_8;
            val_8 = val_8 / val_2;
            val_8 = (val_7 * val_9) * val_8;
            val_8 = val_8 * (-0.5f);
            return (float)val_10;
        }
        
        float val_9 = -10f;
        val_9 = val_1 * val_9;
        val_7 = val_9;
        float val_10 = 6.283185f;
        val_6 = val_1 - val_10;
        val_10 = val_6 * val_10;
        val_10 = val_10 / val_2;
        val_10 = (val_7 * val_9) * val_10;
        val_10 = val_10 * 0.5f;
        val_10 = val_10 + 1f;
        return (float)val_10;
    }

}
