using UnityEngine;
private struct UIGradient.Matrix2x3
{
    // Fields
    public float m00;
    public float m01;
    public float m02;
    public float m10;
    public float m11;
    public float m12;
    
    // Methods
    public UIGradient.Matrix2x3(UnityEngine.Rect rect, float cos, float sin)
    {
        throw 36599768;
    }
    public static UnityEngine.Vector2 op_Multiply(Coffee.UIExtensions.UIGradient.Matrix2x3 m, UnityEngine.Vector2 v)
    {
        float val_3 = m.m00;
        float val_4 = m.m01;
        val_3 = v.x * val_3;
        val_4 = v.y * val_4;
        v.x = v.x * m.m10;
        v.y = v.y * m.m11;
        val_3 = val_3 + val_4;
        v.y = v.x + v.y;
        v.y = m.m12 + v.y;
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  m.m02 + val_3, y:  v.y);
        return new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
    }

}
