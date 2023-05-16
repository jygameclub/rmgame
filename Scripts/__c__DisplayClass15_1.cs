using UnityEngine;
private sealed class ChatCoinCollectAnimation.<>c__DisplayClass15_1
{
    // Fields
    public Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView itemView;
    public bool isLast;
    public Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatCoinCollectAnimation.<>c__DisplayClass15_0 CS$<>8__locals1;
    public System.Action <>9__2;
    
    // Methods
    public ChatCoinCollectAnimation.<>c__DisplayClass15_1()
    {
    
    }
    internal void <PlayCollectAnimation>b__0()
    {
        this.itemView.animator.speed = 0.5f;
    }
    internal void <PlayCollectAnimation>b__1()
    {
        System.Action val_4 = this.<>9__2;
        if(val_4 == null)
        {
                System.Action val_1 = null;
            val_4 = val_1;
            val_1 = new System.Action(object:  this, method:  System.Void ChatCoinCollectAnimation.<>c__DisplayClass15_1::<PlayCollectAnimation>b__2());
            this.<>9__2 = val_4;
        }
        
        UnityEngine.Coroutine val_3 = Royal.Scenes.Home.Context.HomeContext.ManualStartCoroutine(iEnumerator:  Royal.Scenes.Game.Mechanics.Items.CoinItem.Collect.CoinBezierCollect.CollectToUserInfo(itemView:  this.itemView, goalPosition:  new UnityEngine.Vector3() {x = this.CS$<>8__locals1.collectPosition, y = V9.16B, z = V10.16B}, onComplete:  val_1));
    }
    internal void <PlayCollectAnimation>b__2()
    {
        this.CS$<>8__locals1.<>4__this.OnItemReached(itemView:  this.itemView, isLast:  this.isLast);
    }

}
