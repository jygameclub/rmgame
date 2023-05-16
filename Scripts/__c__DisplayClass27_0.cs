using UnityEngine;
private sealed class SwapAction.<>c__DisplayClass27_0
{
    // Fields
    public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel fromItem;
    public Royal.Scenes.Game.Levels.Units.Touch.SwapAction <>4__this;
    public Royal.Scenes.Game.Mechanics.Items.Config.ItemView fromItemView;
    public Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemSwapParticles fromSwapParticles;
    public UnityEngine.Vector3 fromPosition;
    public Royal.Scenes.Game.Mechanics.Items.Config.ItemView toItemView;
    public Royal.Scenes.Game.Mechanics.Sortings.SortingData toSwapSorting;
    public Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemSwapParticles toSwapParticles;
    public UnityEngine.Vector3 toPosition;
    public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel toItem;
    public System.Action <>9__2;
    public System.Action <>9__3;
    
    // Methods
    public SwapAction.<>c__DisplayClass27_0()
    {
    
    }
    internal void <PlayWrongSwapAnimation>b__0()
    {
        Royal.Scenes.Game.Mechanics.Items.Config.ItemView val_10;
        System.Action val_11;
        if(this.fromItem.itemMediator.HasCurrentCell() != false)
        {
                this.<>4__this.sfxManager.PlaySfx(type:  9, offset:  0.04f);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.fromItem.CurrentCell;
            val_10 = this;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  47599616, isReverseSort:  this.fromItemView & 1);
            this.fromItemView.UpdateSwapParticleSorting(swapParticle:  this.fromSwapParticles, itemSortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_4.sortEverything & 4294967295});
        }
        else
        {
                val_10 = this.fromItemView;
        }
        
        val_11 = this.<>9__2;
        if(val_11 == null)
        {
                System.Action val_8 = null;
            val_11 = val_8;
            val_8 = new System.Action(object:  this, method:  System.Void SwapAction.<>c__DisplayClass27_0::<PlayWrongSwapAnimation>b__2());
            this.<>9__2 = val_11;
        }
        
        Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.SetOnComplete<UnityEngine.Vector3>(tween:  Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.MtLocalMove(transform:  mem[this.fromItemView].transform, endPosition:  new UnityEngine.Vector3() {x = this.fromPosition}, duration:  0.135f), onComplete:  val_8).Start();
    }
    internal void <PlayWrongSwapAnimation>b__2()
    {
        Royal.Scenes.Game.Levels.Units.Touch.SwapAction val_1;
        this.<>4__this.fromCell.UnFreezeFall();
        this.<>4__this.toCell.UnFreezeFall();
        val_1 = this.<>4__this;
        if((this.<>4__this.OnSwapAnimationEnd) != null)
        {
                this.<>4__this.OnSwapAnimationEnd.Invoke(obj:  0);
            val_1 = this.<>4__this;
        }
        
        val_1 = 0;
    }
    internal void <PlayWrongSwapAnimation>b__1()
    {
        System.Action val_5;
        this.toItemView.UpdateSwapParticleSorting(swapParticle:  this.toSwapParticles, itemSortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = this.toSwapSorting, order = this.toSwapSorting, sortEverything = typeof(Royal.Scenes.Game.Mechanics.Items.Config.ItemView).__il2cppRuntimeField_1F8>>0&0xFF});
        val_5 = this.<>9__3;
        if(val_5 == null)
        {
                System.Action val_3 = null;
            val_5 = val_3;
            val_3 = new System.Action(object:  this, method:  System.Void SwapAction.<>c__DisplayClass27_0::<PlayWrongSwapAnimation>b__3());
            this.<>9__3 = val_5;
        }
        
        Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.SetOnComplete<UnityEngine.Vector3>(tween:  Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.MtLocalMove(transform:  this.toItemView.transform, endPosition:  new UnityEngine.Vector3() {x = this.toPosition}, duration:  0.135f), onComplete:  val_3).Start();
    }
    internal void <PlayWrongSwapAnimation>b__3()
    {
        if(this.toItem.itemMediator.HasCurrentCell() != false)
        {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.toItem.CurrentCell;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  47599616, isReverseSort:  this.toItemView & 1);
            bool val_5 = val_4.sortEverything & 4294967295;
        }
        else
        {
                this = this.toItemView;
        }
    
    }

}
