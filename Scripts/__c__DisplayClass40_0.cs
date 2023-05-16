using UnityEngine;
private sealed class Area03FireplaceView.<>c__DisplayClass40_0
{
    // Fields
    public Royal.Scenes.Home.Areas.Area03.Tasks.Fireplace.Area03FireplaceView <>4__this;
    public UnityEngine.Vector3 originalPos;
    
    // Methods
    public Area03FireplaceView.<>c__DisplayClass40_0()
    {
    
    }
    internal void <AnimateFireplaceBottom>b__0()
    {
        this.<>4__this.fireplaceBottom.gameObject.SetActive(value:  true);
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.originalPos, y = V8.16B, z = V9.16B}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        this.<>4__this.fireplaceBottom.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  0.5f);
        this.<>4__this.fireplaceBottom.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    internal void <AnimateFireplaceBottom>b__1()
    {
        if((this.<>4__this) != null)
        {
                this.SquashStretch(trans:  this.<>4__this.fireplaceBottom, xScale:  1.03f, yScale:  0.95f, duration:  0.1f);
            return;
        }
        
        throw new NullReferenceException();
    }

}
