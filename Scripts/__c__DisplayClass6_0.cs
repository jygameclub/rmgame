using UnityEngine;
private sealed class ShortcutExtensionsTMPText.<>c__DisplayClass6_0
{
    // Fields
    public UnityEngine.Transform trans;
    
    // Methods
    public ShortcutExtensionsTMPText.<>c__DisplayClass6_0()
    {
    
    }
    internal UnityEngine.Vector3 <DOScale>b__0()
    {
        if(this.trans != null)
        {
                return this.trans.localScale;
        }
        
        throw new NullReferenceException();
    }
    internal void <DOScale>b__1(UnityEngine.Vector3 x)
    {
        if(this.trans != null)
        {
                this.trans.localScale = new UnityEngine.Vector3() {x = x.x, y = x.y, z = x.z};
            return;
        }
        
        throw new NullReferenceException();
    }

}
