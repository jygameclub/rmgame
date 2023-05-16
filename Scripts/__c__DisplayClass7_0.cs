using UnityEngine;
private sealed class ShortcutExtensionsTMPText.<>c__DisplayClass7_0
{
    // Fields
    public TMPro.TMP_Text target;
    
    // Methods
    public ShortcutExtensionsTMPText.<>c__DisplayClass7_0()
    {
    
    }
    internal float <DOFontSize>b__0()
    {
        if(this.target != null)
        {
                return (float)this.target.m_fontSize;
        }
        
        throw new NullReferenceException();
    }
    internal void <DOFontSize>b__1(float x)
    {
        if(this.target != null)
        {
                this.target.fontSize = x;
            return;
        }
        
        throw new NullReferenceException();
    }

}
