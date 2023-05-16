using UnityEngine;
private sealed class BirdNestBird.<DelayAppear>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public int index;
    public Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Bird.BirdNestBird <>4__this;
    public Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Crack.BirdNestCrack crack;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BirdNestBird.<DelayAppear>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.SpriteRenderer val_10;
        int val_11;
        var val_12;
        var val_14;
        var val_15;
        val_10 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds val_1 = null;
        float val_10 = 0.05f;
        val_10 = (float)this.index * val_10;
        val_1 = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  val_10);
        val_11 = 1;
        this.<>2__current = val_1;
        this.<>1__state = val_11;
        return (bool)val_11;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.birdAnimator.gameObject.SetActive(value:  true);
        this.crack.gameObject.SetActive(value:  false);
        val_11 = 0;
        if((this.<>4__this.isMoving) == true)
        {
                return (bool)val_11;
        }
        
        float val_5 = UnityEngine.Random.value;
        float val_11 = 1f;
        val_5 = val_5 + val_5;
        val_11 = Royal.Scenes.Game.Levels.LevelContext.Time + val_11;
        val_5 = val_11 + val_5;
        this.<>4__this = val_5;
        this.<>4__this.birdAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Bird.BirdNestBird.BirdAppear, layer:  0, normalizedTime:  0f);
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  0.83f);
        this.<>4__this.root.transform.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        if(this.index != 0)
        {
                this.<>4__this.foreShadow.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            val_12 = null;
            val_12 = null;
        }
        else
        {
                this.<>4__this.foreShadow.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            val_14 = null;
            val_14 = null;
        }
        
        Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.<>4__this.sortingGroup, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false});
        val_10 = this.<>4__this.foreShadow;
        val_15 = null;
        val_15 = null;
        Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  val_10, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false});
        this.<>4__this.shadow.gameObject.SetActive(value:  false);
        label_2:
        val_11 = 0;
        return (bool)val_11;
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
