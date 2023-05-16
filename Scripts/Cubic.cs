using UnityEngine;
public static class ManualEasing.Cubic
{
    // Methods
    public static float In(float t)
    {
        t = (t * t) * t;
        return (float)t;
    }
    public static float Out(float t)
    {
        float val_1 = -1f;
        t = t + val_1;
        val_1 = t * t;
        t = t * val_1;
        t = t + 1f;
        return (float)t;
    }
    public static float InOut(float t)
    {
        float val_1;
        float val_2;
        val_1 = t + t;
        if(val_1 < 0)
        {
                float val_1 = 0.5f;
            val_1 = val_1 * val_1;
            val_2 = val_1 * val_1;
        }
        else
        {
                float val_2 = -2f;
            val_1 = val_1 + val_2;
            val_2 = val_1 * val_1;
            val_1 = val_1 * val_2;
            val_1 = val_1 + 2f;
            val_2 = 0.5f;
        }
        
        val_1 = val_1 * val_2;
        return (float)val_1;
    }

}
