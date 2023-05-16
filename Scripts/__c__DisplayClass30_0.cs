using UnityEngine;
private sealed class SwapAction.<>c__DisplayClass30_0
{
    // Fields
    public UnityEngine.Vector3 toPosition;
    public UnityEngine.Vector3 fromPosition;
    public UnityEngine.Vector3 toVector;
    public Royal.Scenes.Game.Mechanics.Items.Config.ItemView fromItemView;
    public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel fromItem;
    public Royal.Scenes.Game.Levels.Units.Touch.SwapAction <>4__this;
    public UnityEngine.Vector2 toScale2;
    public UnityEngine.Vector3 fromScale;
    public System.Action <>9__3;
    public System.Action <>9__2;
    public System.Action <>9__4;
    
    // Methods
    public SwapAction.<>c__DisplayClass30_0()
    {
    
    }
    internal void <StartImpossibleSwapAnimation>b__0()
    {
        System.Action val_8;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.toVector, y = V13.16B, z = V11.16B}, d:  -0.07f);
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.fromPosition, y = V9.16B, z = V8.16B}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        this.toPosition = val_2;
        mem[1152921523984476164] = val_2.y;
        mem[1152921523984476168] = val_2.z;
        val_8 = this.<>9__2;
        if(val_8 == null)
        {
                System.Action val_6 = null;
            val_8 = val_6;
            val_6 = new System.Action(object:  this, method:  System.Void SwapAction.<>c__DisplayClass30_0::<StartImpossibleSwapAnimation>b__2());
            this.<>9__2 = val_8;
        }
        
        Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.SetOnComplete<UnityEngine.Vector3>(tween:  Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.SetEase<UnityEngine.Vector3>(tween:  Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.MtLocalMove(transform:  this.fromItemView.transform, endPosition:  new UnityEngine.Vector3() {x = this.toPosition, y = val_2.y, z = val_2.z}, duration:  0.075f), easeType:  4), onComplete:  val_6).Start();
    }
    internal void <StartImpossibleSwapAnimation>b__2()
    {
        System.Action val_6 = this.<>9__3;
        if(val_6 == null)
        {
                System.Action val_4 = null;
            val_6 = val_4;
            val_4 = new System.Action(object:  this, method:  System.Void SwapAction.<>c__DisplayClass30_0::<StartImpossibleSwapAnimation>b__3());
            this.<>9__3 = val_6;
        }
        
        Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.SetOnComplete<UnityEngine.Vector3>(tween:  Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.SetEase<UnityEngine.Vector3>(tween:  Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.MtLocalMove(transform:  this.fromItemView.transform, endPosition:  new UnityEngine.Vector3() {x = this.fromPosition}, duration:  0.075f), easeType:  4), onComplete:  val_4).Start();
    }
    internal void <StartImpossibleSwapAnimation>b__3()
    {
        Royal.Scenes.Game.Mechanics.Items.Config.ItemView val_6;
        if(this.fromItem.itemMediator.HasCurrentCell() != false)
        {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.fromItem.CurrentCell;
            val_6 = this;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  47599616, isReverseSort:  this.fromItemView & 1);
            bool val_5 = val_4.sortEverything & 4294967295;
        }
        else
        {
                val_6 = this.fromItemView;
        }
        
        this.<>4__this = 0;
    }
    internal void <StartImpossibleSwapAnimation>b__1()
    {
        System.Action val_7;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.toScale2, y = V8.16B});
        val_7 = this.<>9__4;
        if(val_7 == null)
        {
                System.Action val_5 = null;
            val_7 = val_5;
            val_5 = new System.Action(object:  this, method:  System.Void SwapAction.<>c__DisplayClass30_0::<StartImpossibleSwapAnimation>b__4());
            this.<>9__4 = val_7;
        }
        
        Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.SetOnComplete<UnityEngine.Vector3>(tween:  Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.SetEase<UnityEngine.Vector3>(tween:  Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.MtLocalScale(transform:  this.fromItemView.transform, endScale:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.075f), easeType:  4), onComplete:  val_5).Start();
    }
    internal void <StartImpossibleSwapAnimation>b__4()
    {
        Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.SetEase<UnityEngine.Vector3>(tween:  Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.MtLocalScale(transform:  this.fromItemView.transform, endScale:  new UnityEngine.Vector3() {x = this.fromScale}, duration:  0.075f), easeType:  3).Start();
    }

}
