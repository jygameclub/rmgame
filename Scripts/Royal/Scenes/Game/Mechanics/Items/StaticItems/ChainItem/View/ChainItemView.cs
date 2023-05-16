using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View
{
    public class ChainItemView : StaticItemView
    {
        // Fields
        private static readonly int ChainInitialState;
        private static readonly int ChainShake;
        public UnityEngine.Animator animator;
        public UnityEngine.GameObject chainSecondLayer;
        private Royal.Scenes.Game.Levels.Units.CellGridManager cellGridManager;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell;
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.IChainItemViewDelegate itemViewDelegate;
        public UnityEngine.SpriteRenderer[] extraShadows;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.IChainItemViewDelegate itemViewDelegate, UnityEngine.Vector3 position, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, int layer)
        {
            this.cell = cell;
            this.itemViewDelegate = itemViewDelegate;
            Royal.Scenes.Game.Levels.Units.CellGridManager val_1 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.cellGridManager = val_1;
            val_1.add_OnCellGridViewsInitialized(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.ChainItemView::InitExtraShadows()));
            this.chainSecondLayer.SetActive(value:  (layer == 2) ? 1 : 0);
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetChainSorting(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cell, y = cell});
            bool val_5 = val_4.sortEverything & 4294967295;
            this.InitTransform(type:  4, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.animator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.ChainItemView.ChainInitialState, layer:  0, normalizedTime:  0f);
        }
        private void InitExtraShadows()
        {
            var val_4;
            var val_5;
            if(this.cell == null)
            {
                goto label_3;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_1 = this.cell.CurrentItem;
            if((val_1 == null) || (val_1 == null))
            {
                goto label_3;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_2 = val_1 & 1;
            val_4 = 0;
            val_5 = 0;
            goto label_4;
            label_3:
            val_4 = 0;
            val_5 = 0;
            label_4:
            val_4 = val_4 & 255;
            var val_5 = 0;
            do
            {
                if(val_5 >= (this.extraShadows.Length << ))
            {
                    return;
            }
            
                Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ChangeAlpha(sprite:  this.extraShadows[val_5], alpha:  (val_5 != 0) ? 0.4705882f : 0.2f);
                val_5 = val_5 + 1;
            }
            while(this.extraShadows != null);
            
            throw new NullReferenceException();
        }
        public void Damage()
        {
            this.PlayWrongMoveSfxByLayer(layer:  2);
            X20.PlaySfx(type:  X20.SelectRandomClip(from:  50, to:  51), offset:  0.04f);
            this.PlayExplodeParticles(flipParticles:  true);
            this.chainSecondLayer.SetActive(value:  false);
            this.PlayShakeAnimation(playSfx:  false);
        }
        public void Explode()
        {
            this.PlayWrongMoveSfxByLayer(layer:  1);
            X20.PlaySfx(type:  X20.SelectRandomClip(from:  50, to:  51), offset:  0.04f);
            this.PlayExplodeParticles(flipParticles:  false);
            this.RecycleSelf();
        }
        private void PlayExplodeParticles(bool flipParticles)
        {
            Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.ChainItemExplodeParticles val_1 = 7653.Spawn<Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.ChainItemExplodeParticles>(poolId:  127, activate:  true);
            val_1.Play(flipParticles:  flipParticles);
            UnityEngine.Vector3 val_5 = this.transform.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        public void PlayShakeAnimation(bool playSfx = True)
        {
            var val_8;
            UnityEngine.Animator val_9;
            var val_10;
            if(playSfx != false)
            {
                    var val_8 = 0;
                if(mem[1152921505089417216] != null)
            {
                    val_8 = val_8 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.IChainItemViewDelegate val_1 = 1152921505089380352 + ((mem[1152921505089417224]) << 4);
            }
            
                this.PlayWrongMoveSfxByLayer(layer:  this.itemViewDelegate.GetLayerCount());
            }
            
            UnityEngine.AnimatorStateInfo val_3 = this.animator.GetCurrentAnimatorStateInfo(layerIndex:  0);
            this.animator.speed = 1.3f;
            val_8 = null;
            val_8 = null;
            if( != Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.ChainItemView.ChainInitialState)
            {
                goto label_11;
            }
            
            label_19:
            val_9 = this.animator;
            val_9.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.ChainItemView.ChainShake, layer:  0, normalizedTime:  0f);
            return;
            label_11:
            val_10 = null;
            val_10 = null;
            if( != Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.ChainItemView.ChainShake)
            {
                goto label_18;
            }
            
            val_10 = null;
            if(1.3f >= 0.5f)
            {
                goto label_19;
            }
            
            label_18:
            val_9 = this.animator;
            val_10 = null;
            val_9.CrossFade(stateHashName:  Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.ChainItemView.ChainShake, normalizedTransitionDuration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  3f), layer:  0, normalizedTimeOffset:  0f);
        }
        private void PlayWrongMoveSfxByLayer(int layer)
        {
            Royal.Scenes.Start.Context.Units.Audio.AudioClipType val_2;
            if(layer == 2)
            {
                    val_2 = 52;
            }
            else
            {
                    Royal.Scenes.Start.Context.Units.Audio.AudioClipType val_1 = this.SelectRandomClip(from:  53, to:  54);
                val_2 = val_1;
            }
            
            val_1.PlaySfx(type:  val_2, offset:  0.04f);
        }
        public override int GetPoolId()
        {
            return 126;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
            this.cellGridManager.remove_OnCellGridViewsInitialized(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.ChainItemView::InitExtraShadows()));
        }
        public ChainItemView()
        {
        
        }
        private static ChainItemView()
        {
            Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.ChainItemView.ChainInitialState = UnityEngine.Animator.StringToHash(name:  "Base Layer.ChainItemInitialStateAnimation");
            Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.ChainItemView.ChainShake = UnityEngine.Animator.StringToHash(name:  "Base Layer.ChainItemIdleAnimation2");
        }
    
    }

}
