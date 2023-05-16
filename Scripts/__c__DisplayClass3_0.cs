using UnityEngine;
private sealed class DOTweenModuleSprite.<>c__DisplayClass3_0
{
    // Fields
    public UnityEngine.Color to;
    public UnityEngine.SpriteRenderer target;
    
    // Methods
    public DOTweenModuleSprite.<>c__DisplayClass3_0()
    {
    
    }
    internal UnityEngine.Color <DOBlendableColor>b__0()
    {
        return new UnityEngine.Color() {r = this.to};
    }
    internal void <DOBlendableColor>b__1(UnityEngine.Color x)
    {
        UnityEngine.Color val_1 = UnityEngine.Color.op_Subtraction(a:  new UnityEngine.Color() {r = x.r, g = x.g, b = x.b, a = x.a}, b:  new UnityEngine.Color() {r = this.to});
        this.to = x;
        mem[1152921528860012052] = x.g;
        mem[1152921528860012056] = x.b;
        mem[1152921528860012060] = x.a;
        UnityEngine.Color val_2 = this.target.color;
        UnityEngine.Color val_3 = UnityEngine.Color.op_Addition(a:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a}, b:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
        this.target.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
    }

}
