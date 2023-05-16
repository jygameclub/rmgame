using UnityEngine;
private sealed class TeamListScroll.<CreateContentSlowly>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Collections.Generic.IEnumerable<Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListRowData> sortedTeams;
    public Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListScroll <>4__this;
    private System.Collections.Generic.IEnumerator<Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListRowData> <>7__wrap1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TeamListScroll.<CreateContentSlowly>d__4(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
        int val_1 = this.<>1__state;
        val_1 = val_1 + 3;
        if(val_1 > 5)
        {
                return;
        }
        
        val_1 = 1 << val_1;
        if((val_1 & 49) != 0)
        {
                return;
        }
        
        this.<>m__Finally1();
    }
    private bool MoveNext()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListScroll val_10;
        var val_11;
        System.Collections.Generic.IEnumerator<Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListRowData> val_12;
        int val_13;
        UnityEngine.Object val_15;
        var val_17;
        val_9 = 39109;
        val_10 = this.<>4__this;
        if((this.<>1__state) == 0)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 2)
        {
            goto label_3;
        }
        
        val_11 = this;
        val_12 = this.<>7__wrap1;
        goto label_4;
        label_2:
        val_13 = 1;
        this.<>2__current = 0;
        this.<>1__state = 2;
        return (bool)val_13;
        label_1:
        val_12 = this.sortedTeams;
        this.<>1__state = 0;
        if(val_12 == null)
        {
                throw new NullReferenceException();
        }
        
        var val_10 = 0;
        if(mem[1152921504684679168] != null)
        {
                val_10 = val_10 + 1;
        }
        else
        {
                System.Collections.Generic.IEnumerable<Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListRowData> val_1 = 1152921504684642304 + ((mem[1152921504684679176]) << 4);
        }
        
        val_15 = public System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>::GetEnumerator();
        val_9 = val_12;
        System.Collections.Generic.IEnumerator<T> val_2 = val_9.GetEnumerator();
        val_11 = this;
        val_12 = val_2;
        this.<>7__wrap1 = val_2;
        label_4:
        this.<>1__state = -3;
        if(val_12 == null)
        {
                throw new NullReferenceException();
        }
        
        var val_11 = 0;
        if(mem[1152921504684732416] != null)
        {
                val_11 = val_11 + 1;
        }
        else
        {
                System.Collections.Generic.IEnumerator<T> val_3 = 1152921504684695552 + ((mem[1152921504684732424]) << 4);
        }
        
        val_15 = public System.Boolean System.Collections.IEnumerator::MoveNext();
        val_9 = val_12;
        if(val_9.MoveNext() == false)
        {
            goto label_16;
        }
        
        val_12 = this.<>7__wrap1;
        if(val_12 == null)
        {
                throw new NullReferenceException();
        }
        
        var val_14 = mem[val_2];
        if((mem[val_2] + 294) == 0)
        {
            goto label_21;
        }
        
        var val_12 = mem[val_2] + 176;
        var val_13 = 0;
        val_12 = val_12 + 8;
        label_20:
        if(((mem[val_2] + 176 + 8) + -8) == null)
        {
            goto label_19;
        }
        
        val_13 = val_13 + 1;
        val_12 = val_12 + 16;
        if(val_13 < (mem[val_2] + 294))
        {
            goto label_20;
        }
        
        goto label_21;
        label_19:
        val_14 = val_14 + (((mem[val_2] + 176 + 8)) << 4);
        val_17 = val_14 + 304;
        label_21:
        T val_5 = val_12.Current;
        val_15 = 0;
        if(val_10 != val_15)
        {
            goto label_24;
        }
        
        label_16:
        val_9 = this;
        this.<>m__Finally1();
        this.<>7__wrap1 = 0;
        if(val_10 == null)
        {
                throw new NullReferenceException();
        }
        
        val_13 = 0;
        val_10 = 0;
        return (bool)val_13;
        label_24:
        if(val_10 == null)
        {
                throw new NullReferenceException();
        }
        
        val_6 = val_6;
        val_7 = val_7;
        val_8 = val_8;
        val_13 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_13;
        return (bool)val_13;
        label_3:
        val_13 = 0;
        return (bool)val_13;
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        if((this.<>7__wrap1) == null)
        {
                return;
        }
        
        var val_2 = 0;
        if(mem[1152921504684732416] != null)
        {
                val_2 = val_2 + 1;
        }
        else
        {
                System.Collections.Generic.IEnumerator<Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListRowData> val_1 = 1152921504684695552 + ((mem[1152921504684732424]) << 4);
        }
        
        this.<>7__wrap1.Dispose();
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
