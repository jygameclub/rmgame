using UnityEngine;
public static class ManualEasing.Quartic
{
    // Methods
    public static float In(float t)
    {
        float val_1 = t * t;
        val_1 = val_1 * t;
        t = val_1 * t;
        return (float)t;
    }
    public static float Out(float t)
    {
        float val_1 = -1f;
        t = t + val_1;
        val_1 = t * t;
        val_1 = t * val_1;
        t = t * val_1;
        t = 1f - t;
        return (float)t;
    }
    public static float InOut(float t)
    {
        float val_2;
        float val_3;
        val_2 = t + t;
        if(val_2 < 0)
        {
                float val_2 = 0.5f;
            val_2 = val_2 * val_2;
            val_2 = val_2 * val_2;
            val_3 = val_2 * val_2;
        }
        else
        {
                val_2 = val_2 + (-2f);
            float val_1 = val_2 * val_2;
            val_1 = val_2 * val_1;
            val_2 = val_2 * val_1;
            val_2 = val_2 + (-2f);
            val_3 = -0.5f;
        }
        
        val_2 = val_2 * val_3;
        return (float)val_2;
    }

}
