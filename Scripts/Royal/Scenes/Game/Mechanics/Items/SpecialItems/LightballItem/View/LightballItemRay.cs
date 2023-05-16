using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View
{
    public class LightballItemRay : ItemParticles
    {
        // Fields
        public UnityEngine.LineRenderer colorLine;
        public UnityEngine.LineRenderer whiteLine;
        public UnityEngine.Color[] colors;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.LightballStrategy lightballStrategy;
        private Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel targetModel;
        private UnityEngine.Coroutine shakeRoutine;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemBg lightballBg;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel frozenCell;
        private bool rayEnded;
        private bool rayWillRecycle;
        private bool isCollectCalled;
        private UnityEngine.Coroutine rayCoroutine;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.LightballStrategy lightballStrategy, Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel targetModel)
        {
            this.lightballStrategy = lightballStrategy;
            this.targetModel = targetModel;
            UnityEngine.Color val_1 = this.GetColorFromMatchType(type:  lightballStrategy);
            this.whiteLine.positionCount = 2;
            UnityEngine.Color val_2 = this.GetColorFromMatchType(type:  0);
            this.whiteLine.startColor = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
            UnityEngine.Color val_3 = this.GetColorFromMatchType(type:  0);
            this.whiteLine.endColor = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
            this.colorLine.positionCount = 2;
            this.colorLine.startColor = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
            this.colorLine.endColor = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
            this.SetWidthForType();
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = lightballStrategy.GetLightballSorting();
            bool val_13 = val_4.sortEverything;
            val_13 = val_13 & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_5 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_13}, offset:  -2);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.colorLine, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_5.layer, order = val_5.order, sortEverything = val_5.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_7 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_13}, offset:  0);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.whiteLine, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_7.layer, order = val_7.order, sortEverything = val_7.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_9 = this.whiteLine.CurrentCell;
            this.frozenCell = val_9;
            if(val_9 != null)
            {
                    val_9.FreezeFall();
            }
            else
            {
                    UnityEngine.Debug.Log(message:  "Frozen bug");
            }
            
            targetModel.add_OnExplodeEvent(value:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemRay::EndRay()));
            this.rayCoroutine = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.MoveAndDestroy());
        }
        private void SetWidthForType()
        {
            if(this.targetModel > 6)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
            var val_6 = 36610300 + (this.targetModel) << 2;
            val_6 = val_6 + 36610300;
            goto (36610300 + (this.targetModel) << 2 + 36610300);
        }
        public override int GetPoolId()
        {
            return 24;
        }
        public override void OnRecycle()
        {
            this.EndRay();
            this.colorLine.enabled = true;
            this.whiteLine.enabled = true;
            this.isCollectCalled = false;
            this.lightballBg = 0;
            this.frozenCell = 0;
            this.targetModel = 0;
            this.shakeRoutine = 0;
            this.lightballStrategy = 0;
            this.rayEnded = false;
            this.OnRecycle();
        }
        public void CreateItemBg(Royal.Scenes.Game.Mechanics.Items.Config.ItemType itemType, UnityEngine.Vector3 position, Royal.Scenes.Game.Mechanics.Items.Config.RootTransform parent)
        {
            this.lightballBg = this.lightballStrategy.CreateBg(itemType:  itemType, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, parent:  parent);
            val_1.rayTipParticle.Play();
        }
        public void ShakeItem(Royal.Scenes.Game.Mechanics.Items.Config.RootTransform trans)
        {
            this.shakeRoutine = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.lightballStrategy.ShakeItem(trans:  trans));
        }
        private System.Collections.IEnumerator MoveAndDestroy()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new LightballItemRay.<MoveAndDestroy>d__18();
        }
        public void EndRay()
        {
            if(this.rayEnded != false)
            {
                    return;
            }
            
            this.targetModel.remove_OnExplodeEvent(value:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemRay::EndRay()));
            this.rayEnded = true;
            if(this.isCollectCalled != true)
            {
                    int val_4 = this.lightballStrategy.unCollectedRays;
                val_4 = val_4 - 1;
                this.lightballStrategy = val_4;
                this.lightballStrategy = Royal.Scenes.Game.Levels.LevelContext.Time;
            }
            
            if(this.rayCoroutine != null)
            {
                    Royal.Scenes.Game.Context.GameContext.ManualStopCoroutine(coroutine:  this.rayCoroutine);
                int val_5 = this.lightballStrategy.incompleteRays;
                val_5 = val_5 - 1;
                this.lightballStrategy = val_5;
            }
            
            if(this.shakeRoutine != null)
            {
                    Royal.Scenes.Game.Context.GameContext.ManualStopCoroutine(coroutine:  this.shakeRoutine);
                this.shakeRoutine = 0;
            }
            
            if(this.lightballBg != 0)
            {
                    this.lightballBg.RecycleSelf();
                this.lightballBg = 0;
            }
            
            if(this.frozenCell != null)
            {
                    this.frozenCell.UnFreezeFall();
            }
            
            this.RecycleSelf();
        }
        private UnityEngine.Color GetColorFromMatchType(Royal.Scenes.Game.Mechanics.Matches.MatchType type)
        {
            if(type <= 6)
            {
                    var val_1 = 36610272 + (type) << 2;
                val_1 = val_1 + 36610272;
            }
            else
            {
                    return new UnityEngine.Color() {r = -2.631914E+07f, g = -2.631914E+07f, b = -2.631914E+07f, a = -2.631914E+07f};
            }
        
        }
        public LightballItemRay()
        {
        
        }
    
    }

}
