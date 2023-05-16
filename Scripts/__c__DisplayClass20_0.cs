using UnityEngine;
private sealed class AreaDownloader.<>c__DisplayClass20_0
{
    // Fields
    public string extraFileName;
    
    // Methods
    public AreaDownloader.<>c__DisplayClass20_0()
    {
    
    }
    internal bool <HasExtraBundleOfAreaFile>b__0(string t)
    {
        if(t != null)
        {
                return t.StartsWith(value:  this.extraFileName);
        }
        
        throw new NullReferenceException();
    }

}
