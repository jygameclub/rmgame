using UnityEngine;
private sealed class BirdNestBird.<>c__DisplayClass29_0
{
    // Fields
    public Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Bird.BirdNestBird <>4__this;
    public Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemModel birdItemModel;
    public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell;
    
    // Methods
    public BirdNestBird.<>c__DisplayClass29_0()
    {
    
    }
    internal void <SquashStretch>b__0()
    {
        if((this.<>4__this) != null)
        {
                this.<>4__this.FinishOperation(itemModel:  this.birdItemModel, cell:  this.cell);
            return;
        }
        
        throw new NullReferenceException();
    }

}
