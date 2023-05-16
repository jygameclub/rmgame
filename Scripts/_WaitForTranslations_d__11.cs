using UnityEngine;
private sealed class GoogleTranslation.<WaitForTranslations>d__11 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GoogleTranslation.<WaitForTranslations>d__11(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        System.Collections.Generic.List<I2.Loc.TranslationJob> val_4;
        var val_5;
        int val_6;
        if((this.<>1__state) < 2)
        {
                this.<>1__state = 0;
            val_3 = null;
            val_3 = null;
            val_4 = I2.Loc.GoogleTranslation.mTranslationJobs;
            if((I2.Loc.GoogleTranslation.mTranslationJobs + 24) > 0)
        {
                val_4 = I2.Loc.GoogleTranslation.mTranslationJobs;
            if(val_1.Length >= 1)
        {
                var val_4 = 0;
            do
        {
            T val_3 = val_4.ToArray()[val_4];
            if(val_3 != 0)
        {
                val_5 = null;
            val_5 = null;
            bool val_2 = I2.Loc.GoogleTranslation.mTranslationJobs.Remove(item:  val_3);
        }
        
            val_4 = val_4 + 1;
        }
        while(val_4 < val_1.Length);
        
        }
        
            val_6 = 1;
            this.<>2__current = 0;
            this.<>1__state = val_6;
            return (bool)val_6;
        }
        
        }
        
        val_6 = 0;
        return (bool)val_6;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        throw new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
