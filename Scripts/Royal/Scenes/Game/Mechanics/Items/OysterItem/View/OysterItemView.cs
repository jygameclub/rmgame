using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.OysterItem.View
{
    public class OysterItemView : ItemView
    {
        // Fields
        private static readonly int Oyster_1;
        private static readonly int Oyster_1_to_2;
        private static readonly int Oyster_2_to_3;
        public UnityEngine.Animator oysterAnimator;
        private Royal.Scenes.Game.Mechanics.Items.OysterItem.View.OysterItemAssets itemAssets;
        private Royal.Scenes.Game.Mechanics.Items.OysterItem.View.IOysterItemViewDelegate viewDelegate;
        private Royal.Infrastructure.Utils.Randoming.RandomManager randomManager;
        private bool isReverseSorted;
        private bool isFalling;
        
        // Methods
        public override int GetPoolId()
        {
            return 80;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
        
        }
        public void Init(Royal.Scenes.Game.Mechanics.Items.OysterItem.View.IOysterItemViewDelegate viewDelegate, UnityEngine.Vector3 position, int layer)
        {
            this.itemAssets = 185636.Load<Royal.Scenes.Game.Mechanics.Items.OysterItem.View.OysterItemAssets>();
            this.viewDelegate = viewDelegate;
            this.isReverseSorted = true;
            this.isFalling = false;
            this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.oysterAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.OysterItem.View.OysterItemView.Oyster_1, layer:  0, normalizedTime:  0f);
            this.randomManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5);
        }
        public void CollectToGoal()
        {
            true.PlaySfx(type:  ((this.randomManager.NextBool() & true) != 0) ? (201 + 1) : 201, offset:  0.04f);
            this.SpawnParticle(particleLayer:  0);
            this.Recycle<Royal.Scenes.Game.Mechanics.Items.OysterItem.View.OysterItemView>(go:  this);
            Royal.Scenes.Game.Mechanics.Items.OysterItem.View.PearlGoalView val_3 = this.Spawn<Royal.Scenes.Game.Mechanics.Items.OysterItem.View.PearlGoalView>(poolId:  82, activate:  true);
            UnityEngine.Vector3 val_6 = this.transform.position;
            val_3.transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            val_3.Play(viewDelegate:  this.viewDelegate);
        }
        public void Damage(int damagedLayer)
        {
            UnityEngine.Animator val_5;
            int val_6;
            bool val_1 = this.randomManager.NextBool();
            true.PlaySfx(type:  (damagedLayer == 2) ? (((val_1 & true) != 0) ? (197 + 1) : 197) : (((val_1 & true) != 0) ? (199 + 1) : 199), offset:  0.04f);
            this.SpawnParticle(particleLayer:  damagedLayer);
            if(damagedLayer == 2)
            {
                    val_5 = this.oysterAnimator;
                val_6 = Royal.Scenes.Game.Mechanics.Items.OysterItem.View.OysterItemView.Oyster_1_to_2;
            }
            else
            {
                    if(damagedLayer != 1)
            {
                    return;
            }
            
                val_5 = this.oysterAnimator;
                val_6 = Royal.Scenes.Game.Mechanics.Items.OysterItem.View.OysterItemView.Oyster_2_to_3;
            }
            
            val_5.Play(stateNameHash:  val_6, layer:  0, normalizedTime:  0f);
        }
        private void SpawnParticle(int particleLayer)
        {
            Royal.Scenes.Game.Mechanics.Items.OysterItem.View.OysterExplodeParticles val_1 = 26402.Spawn<Royal.Scenes.Game.Mechanics.Items.OysterItem.View.OysterExplodeParticles>(poolId:  81, activate:  true);
            val_1.Play(particleLayer:  particleLayer);
            UnityEngine.Vector3 val_4 = this.transform.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        public override bool IsReverseSorted()
        {
            if(this.isReverseSorted == false)
            {
                    return false;
            }
            
            return (bool)(this.isReverseSorted == false) ? 1 : 0;
        }
        public override void FallStarted()
        {
            this.isFalling = true;
        }
        public override void FallEnded()
        {
            this.isFalling = false;
            this.ArrangeSortingForHoney();
        }
        private void Update()
        {
            if(this.isFalling == false)
            {
                    return;
            }
            
            this.CheckIfInsideHoney();
        }
        public void ArrangeSortingForHoney()
        {
            var val_8 = 0;
            if(mem[1152921505096286208] != null)
            {
                    val_8 = val_8 + 1;
            }
            else
            {
                    var val_9 = mem[1152921505096286216];
                val_9 = val_9 + 4;
                Royal.Scenes.Game.Mechanics.Items.OysterItem.View.IOysterItemViewDelegate val_1 = 1152921505096249344 + val_9;
            }
            
            bool val_2 = this.viewDelegate.IsUnderHoney();
            var val_3 = (this.isReverseSorted == false) ? 1 : 0;
            val_3 = val_2 ^ val_3;
            if(val_3 == false)
            {
                    return;
            }
            
            bool val_10 = ~val_2;
            val_10 = val_10 & 1;
            this.isReverseSorted = val_10;
            var val_11 = 0;
            if(mem[1152921505096286208] != null)
            {
                    val_11 = val_11 + 1;
            }
            else
            {
                    var val_12 = mem[1152921505096286216];
                val_12 = val_12 + 3;
                Royal.Scenes.Game.Mechanics.Items.OysterItem.View.IOysterItemViewDelegate val_4 = 1152921505096249344 + val_12;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_5 = this.viewDelegate.CurrentCell;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_6 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  this.viewDelegate, isReverseSort:  false);
            bool val_7 = val_6.sortEverything & 4294967295;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.OysterItem.View.OysterItemView).__il2cppRuntimeField_1F0;
        }
        private void CheckIfInsideHoney()
        {
            var val_7 = 0;
            if(mem[1152921505096286208] != null)
            {
                    val_7 = val_7 + 1;
            }
            else
            {
                    var val_8 = mem[1152921505096286216];
                val_8 = val_8 + 4;
                Royal.Scenes.Game.Mechanics.Items.OysterItem.View.IOysterItemViewDelegate val_1 = 1152921505096249344 + val_8;
            }
            
            if(this.viewDelegate.IsUnderHoney() == false)
            {
                    return;
            }
            
            if(this.isReverseSorted == false)
            {
                    return;
            }
            
            this.isReverseSorted = false;
            var val_9 = 0;
            if(mem[1152921505096286208] != null)
            {
                    val_9 = val_9 + 1;
            }
            else
            {
                    var val_10 = mem[1152921505096286216];
                val_10 = val_10 + 3;
                Royal.Scenes.Game.Mechanics.Items.OysterItem.View.IOysterItemViewDelegate val_3 = 1152921505096249344 + val_10;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_4 = this.viewDelegate.CurrentCell;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_5 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  this.viewDelegate, isReverseSort:  false);
            bool val_6 = val_5.sortEverything & 4294967295;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.OysterItem.View.OysterItemView).__il2cppRuntimeField_1F0;
        }
        public OysterItemView()
        {
        
        }
        private static OysterItemView()
        {
            Royal.Scenes.Game.Mechanics.Items.OysterItem.View.OysterItemView.Oyster_1 = UnityEngine.Animator.StringToHash(name:  "Base Layer.oyster_1");
            Royal.Scenes.Game.Mechanics.Items.OysterItem.View.OysterItemView.Oyster_1_to_2 = UnityEngine.Animator.StringToHash(name:  "Base Layer.oyster_1_to_2");
            Royal.Scenes.Game.Mechanics.Items.OysterItem.View.OysterItemView.Oyster_2_to_3 = UnityEngine.Animator.StringToHash(name:  "Base Layer.oyster_2_to_3");
        }
    
    }

}
