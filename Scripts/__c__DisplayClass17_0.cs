using UnityEngine;
private sealed class MaterialCache.<>c__DisplayClass17_0
{
    // Fields
    public ulong hash;
    
    // Methods
    public MaterialCache.<>c__DisplayClass17_0()
    {
    
    }
    internal bool <Register>b__0(Coffee.UIExtensions.MaterialCache x)
    {
        if(x != null)
        {
                return (bool)((x.<hash>k__BackingField) == this.hash) ? 1 : 0;
        }
        
        throw new NullReferenceException();
    }

}
