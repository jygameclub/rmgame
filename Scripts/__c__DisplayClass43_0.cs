using UnityEngine;
private sealed class LocalizationManager.<>c__DisplayClass43_0
{
    // Fields
    public System.Collections.Generic.Dictionary<string, object> parameters;
    
    // Methods
    public LocalizationManager.<>c__DisplayClass43_0()
    {
    
    }
    internal object <ApplyLocalizationParams>b__0(string p)
    {
        object val_1 = 0;
        return (object)((this.parameters.TryGetValue(key:  p, value: out  val_1)) != true) ? (val_1) : 0;
    }

}
