using UnityEngine;
public static class ManualEasing.Circular
{
    // Methods
    public static float In(float t)
    {
        float val_2;
        t = t * t;
        if(t >= _TYPE_MAX_)
        {
                val_2 = 1f - t;
        }
        
        val_2 = 1f - val_2;
        return (float)val_2;
    }
    public static float Out(float t)
    {
        float val_1 = t;
        float val_2 = -1f;
        val_1 = val_1 + val_2;
        val_2 = val_1 * val_1;
        val_2 = 1f - val_2;
        if(1f <= _TYPE_MAX_)
        {
                return 1f;
        }
    
    }
    public static float InOut(float t)
    {
        float val_3;
        float val_4;
        float val_5;
        float val_6;
        float val_1 = t + t;
        if(val_1 < 0)
        {
                val_3 = val_1 * val_1;
            val_4 = -0.5f;
            val_5 = -1f;
        }
        else
        {
                val_1 = val_1 + (-2f);
            val_3 = val_1 * val_1;
            val_4 = 0.5f;
            val_5 = 1f;
        }
        
        if(val_3 >= _TYPE_MAX_)
        {
                val_6 = 1f - val_3;
        }
        
        val_6 = val_6 + val_5;
        val_6 = val_6 * val_4;
        return (float)val_6;
    }

}
