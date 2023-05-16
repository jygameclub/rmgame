using UnityEngine;
public static class ManualEasing.Sine
{
    // Methods
    public static float In(float t)
    {
        float val_1 = 3.141593f;
        val_1 = t * val_1;
        val_1 = val_1 * 0.5f;
        val_1 = 1f - val_1;
        return (float)val_1;
    }
    public static float Out(float t)
    {
        float val_1 = 3.141593f;
        val_1 = t * val_1;
        val_1 = val_1 * 0.5f;
    }
    public static float InOut(float t)
    {
        float val_1 = 3.141593f;
        val_1 = t * val_1;
        val_1 = 1f - val_1;
        val_1 = val_1 * 0.5f;
        return (float)val_1;
    }

}
