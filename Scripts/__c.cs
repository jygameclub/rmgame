using UnityEngine;
[Serializable]
private sealed class ParameterTexture.<>c
{
    // Fields
    public static readonly Coffee.UIExtensions.ParameterTexture.<>c <>9;
    public static UnityEngine.Canvas.WillRenderCanvases <>9__16_0;
    
    // Methods
    private static ParameterTexture.<>c()
    {
        ParameterTexture.<>c.<>9 = new ParameterTexture.<>c();
    }
    public ParameterTexture.<>c()
    {
    
    }
    internal void <Initialize>b__16_0()
    {
        if((Coffee.UIExtensions.ParameterTexture.updates + 24) < 1)
        {
                return;
        }
        
        var val_2 = 0;
        do
        {
            if((Coffee.UIExtensions.ParameterTexture.updates + 24) <= val_2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_1 = Coffee.UIExtensions.ParameterTexture.updates + 16;
            val_1 = val_1 + 0;
            (Coffee.UIExtensions.ParameterTexture.updates + 16 + 0) + 32.Invoke();
            val_2 = val_2 + 1;
            if(val_2 >= (Coffee.UIExtensions.ParameterTexture.updates + 24))
        {
                return;
        }
        
        }
        while(Coffee.UIExtensions.ParameterTexture.updates != null);
        
        throw new NullReferenceException();
    }

}
