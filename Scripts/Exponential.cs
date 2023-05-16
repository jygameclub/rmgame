using UnityEngine;
public static class ManualEasing.Exponential
{
    // Methods
    public static float In(float t)
    {
        if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  t, b:  0f, precision:  0.001f)) != false)
        {
                return 0f;
        }
        
        float val_2 = -1f;
        val_2 = t + val_2;
    }
    public static float Out(float t)
    {
        float val_3 = 1f;
        if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  t, b:  val_3 = 1f, precision:  0.001f)) == true)
        {
                return (float)val_3;
        }
        
        float val_2 = -10f;
        val_2 = t * val_2;
        val_3 = 1f - val_2;
        return (float)val_3;
    }
    public static float InOut(float t)
    {
        float val_5;
        float val_6;
        float val_7;
        val_5 = t;
        val_6 = 0f;
        if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_5, b:  0f, precision:  0.001f)) == true)
        {
                return (float)val_6;
        }
        
        val_6 = 1f;
        if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_5, b:  val_6, precision:  0.001f)) == true)
        {
                return (float)val_6;
        }
        
        val_5 = val_5 + val_5;
        if(val_5 < 0)
        {
                float val_3 = val_5 + (-1f);
            val_7 = 1024f;
        }
        else
        {
                float val_4 = -1f;
            val_4 = val_5 + val_4;
            val_4 = val_4 * (-10f);
            val_7 = 2f - val_4;
        }
        
        val_6 = val_7 * 0.5f;
        return (float)val_6;
    }

}
