using UnityEngine;
[Serializable]
public class UIShadow.AdditionalShadow
{
    // Fields
    public float blur;
    public Coffee.UIExtensions.ShadowStyle style;
    public UnityEngine.Color effectColor;
    public UnityEngine.Vector2 effectDistance;
    public bool useGraphicAlpha;
    
    // Methods
    public UIShadow.AdditionalShadow()
    {
        this.blur = 0.25f;
        this.style = 1;
        UnityEngine.Color val_1 = UnityEngine.Color.black;
        this.effectColor = val_1;
        mem[1152921528891821020] = val_1.g;
        mem[1152921528891821024] = val_1.b;
        mem[1152921528891821028] = val_1.a;
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  1f, y:  -1f);
        this.effectDistance = val_2.x;
        this.useGraphicAlpha = true;
    }

}
