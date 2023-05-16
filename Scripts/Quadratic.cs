using UnityEngine;
public static class ManualEasing.Quadratic
{
    // Methods
    public static float In(float t)
    {
        t = t * t;
        return (float)t;
    }
    public static float Out(float t)
    {
        float val_1 = 2f;
        val_1 = val_1 - t;
        t = val_1 * t;
        return (float)t;
    }
    public static float InOut(float t)
    {
        float val_1;
        float val_2;
        val_1 = t + t;
        if(val_1 < 0)
        {
                val_2 = val_1 * 0.5f;
        }
        else
        {
                float val_1 = -2f;
            val_1 = val_1 + (-1f);
            val_1 = val_1 + val_1;
            val_1 = val_1 * val_1;
            val_1 = val_1 + (-1f);
            val_2 = -0.5f;
        }
        
        val_1 = val_1 * val_2;
        return (float)val_1;
    }

}
