using UnityEngine;
private sealed class ShortcutExtensionsTMPText.<>c__DisplayClass8_0
{
    // Fields
    public TMPro.TMP_Text target;
    
    // Methods
    public ShortcutExtensionsTMPText.<>c__DisplayClass8_0()
    {
    
    }
    internal int <DOMaxVisibleCharacters>b__0()
    {
        if(this.target != null)
        {
                return (int)this.target.m_maxVisibleCharacters;
        }
        
        throw new NullReferenceException();
    }
    internal void <DOMaxVisibleCharacters>b__1(int x)
    {
        if(this.target != null)
        {
                this.target.maxVisibleCharacters = x;
            return;
        }
        
        throw new NullReferenceException();
    }

}
