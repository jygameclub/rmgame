using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Cell.View
{
    public class CellView : MonoBehaviour, ITouchableCell, IPoolable
    {
        // Fields
        public static readonly UnityEngine.Color MainColor;
        public static readonly UnityEngine.Color AltColor;
        public Royal.Scenes.Game.Mechanics.Board.Cell.View.CellMask mask;
        public Royal.Scenes.Game.Mechanics.Board.Cell.View.CellBorder border;
        public UnityEngine.SpriteRenderer background;
        public UnityEngine.SpriteRenderer front;
        public float freezeDuration;
        private bool shouldCountdownForFreeze;
        private Royal.Scenes.Game.Levels.Units.Booster.BoosterManager boosterManager;
        private Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate <ViewDelegate>k__BackingField;
        
        // Properties
        public Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate ViewDelegate { get; set; }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint CellPoint { get; }
        public UnityEngine.Vector2 Position { get; }
        
        // Methods
        public Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate get_ViewDelegate()
        {
            return (Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate)this.<ViewDelegate>k__BackingField;
        }
        private void set_ViewDelegate(Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate value)
        {
            this.<ViewDelegate>k__BackingField = value;
        }
        private void Update()
        {
            if(this.shouldCountdownForFreeze == false)
            {
                    return;
            }
            
            float val_1 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
            val_1 = this.freezeDuration - val_1;
            this.freezeDuration = val_1;
            if(val_1 > 0f)
            {
                    return;
            }
            
            this.freezeDuration = 0f;
            var val_3 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_3 = val_3 + 1;
            }
            else
            {
                    var val_4 = mem[1152921505113751560];
                val_4 = val_4 + 10;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_2 = 1152921505113714688 + val_4;
            }
            
            this.<ViewDelegate>k__BackingField.UnFreezeFall();
            this.shouldCountdownForFreeze = false;
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint get_CellPoint()
        {
            var val_2 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_2 = val_2 + 1;
                return this.<ViewDelegate>k__BackingField.Point;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_1 = 1152921505113714688 + ((mem[1152921505113751560]) << 4);
            return this.<ViewDelegate>k__BackingField.Point;
        }
        public UnityEngine.Vector2 get_Position()
        {
            UnityEngine.Vector3 val_2 = this.transform.position;
            return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView HighlightMatchItem(bool enable)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_10;
            Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_11;
            var val_14;
            val_11 = this;
            if(this.IsTouchEnabled() != false)
            {
                    val_10 = this.<ViewDelegate>k__BackingField;
                var val_13 = 0;
                if(mem[1152921505113751552] != null)
            {
                    val_13 = val_13 + 1;
            }
            else
            {
                    var val_14 = mem[1152921505113751560];
                val_14 = val_14 + 7;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_2 = 1152921505113714688 + val_14;
            }
            
                if(val_10.StaticMediator.HasTouchBlockingItem() != true)
            {
                    val_10 = this.<ViewDelegate>k__BackingField;
                var val_15 = 0;
                if(mem[1152921505113751552] != null)
            {
                    val_15 = val_15 + 1;
            }
            else
            {
                    var val_16 = mem[1152921505113751560];
                val_16 = val_16 + 4;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_5 = 1152921505113714688 + val_16;
            }
            
                Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_6 = val_10.CurrentItem;
                if(val_6 != null)
            {
                    val_10 = val_6;
            }
            
            }
            
            }
            
            if(this.IsTouchEnabled() != false)
            {
                    val_14 = 0;
                if(this.boosterManager.IsBoosterSelected() == true)
            {
                    return (Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView)val_14;
            }
            
                val_11 = this.<ViewDelegate>k__BackingField;
                var val_17 = 0;
                if(mem[1152921505113751552] != null)
            {
                    val_17 = val_17 + 1;
            }
            else
            {
                    var val_18 = mem[1152921505113751560];
                val_18 = val_18 + 7;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_9 = 1152921505113714688 + val_18;
            }
            
                if(val_11.StaticMediator.GetTopMostAboveItem() == null)
            {
                    return (Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView)val_14;
            }
            
            }
            
            val_14 = 0;
            return (Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView)val_14;
        }
        public bool IsTouchEnabled()
        {
            var val_2 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_2 = val_2 + 1;
                return this.<ViewDelegate>k__BackingField.IsTouchEnabled();
            }
            
            var val_3 = mem[1152921505113751560];
            val_3 = val_3 + 11;
            Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_1 = 1152921505113714688 + val_3;
            return this.<ViewDelegate>k__BackingField.IsTouchEnabled();
        }
        public void InitializeView(Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate model, Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory)
        {
            this.boosterManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Booster.BoosterManager>(contextId:  17);
            this.<ViewDelegate>k__BackingField = model;
            UnityEngine.Transform val_2 = this.transform;
            val_2.SetParent(p:  itemFactory.<CellParent>k__BackingField);
            UnityEngine.Vector3 val_3 = val_2.localPosition;
            var val_14 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_14 = val_14 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_4 = 1152921505113714688 + ((mem[1152921505113751560]) << 4);
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_5 = this.<ViewDelegate>k__BackingField.Point;
            var val_15 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_15 = val_15 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_6 = 1152921505113714688 + ((mem[1152921505113751560]) << 4);
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_7 = this.<ViewDelegate>k__BackingField.Point;
            val_2.localPosition = new UnityEngine.Vector3() {x = (float)val_5.x, y = (float)val_7.x >> 32, z = val_3.z};
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            val_2.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            this.SetCellColor();
            var val_16 = 0;
            if(mem[1152921505113751552] != null)
            {
                    val_16 = val_16 + 1;
            }
            else
            {
                    var val_17 = mem[1152921505113751560];
                val_17 = val_17 + 9;
                Royal.Scenes.Game.Mechanics.Board.Cell.View.ICellViewDelegate val_11 = 1152921505113714688 + val_17;
            }
            
            this.mask.Enable(isEnabled:  this.<ViewDelegate>k__BackingField.IsFillingCell());
            this.border = itemFactory.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Board.Cell.View.CellAssets>();
        }
        private void SetCellColor()
        {
            var val_1;
            var val_2;
            this.front.enabled = true;
            val_1 = null;
            val_1 = null;
            this.front.color = new UnityEngine.Color() {r = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView.AltColor, g = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView.MainColor.__il2cppRuntimeField_14, b = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView.MainColor.__il2cppRuntimeField_18, a = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView.MainColor.__il2cppRuntimeField_1C};
            this.background.enabled = true;
            val_2 = null;
            val_2 = null;
            this.background.color = new UnityEngine.Color() {r = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView.MainColor, g = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView.MainColor.__il2cppRuntimeField_4, b = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView.MainColor.__il2cppRuntimeField_8, a = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView.MainColor.__il2cppRuntimeField_C};
        }
        public void ShowView(bool show)
        {
            UnityEngine.GameObject val_1 = this.front.gameObject;
            if(show != false)
            {
                    val_1.SetActive(value:  true);
                this.background.gameObject.SetActive(value:  true);
                this.border.ShowParts();
                return;
            }
            
            val_1.SetActive(value:  false);
            this.background.gameObject.SetActive(value:  false);
            this.border.HideParts();
        }
        public void StartCountdownForFreeze(float duration)
        {
            this.freezeDuration = duration;
            this.shouldCountdownForFreeze = true;
        }
        public int GetPoolId()
        {
            return 0;
        }
        public void OnSpawn()
        {
        
        }
        public void OnRecycle()
        {
            this.freezeDuration = 0f;
            this.shouldCountdownForFreeze = false;
            if(this.border != null)
            {
                    this.border = 0;
                return;
            }
            
            throw new NullReferenceException();
        }
        public static UnityEngine.Color GetMainColor()
        {
            null = null;
            return new UnityEngine.Color() {r = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView.MainColor, g = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView.MainColor.__il2cppRuntimeField_4, b = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView.MainColor.__il2cppRuntimeField_8, a = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView.MainColor.__il2cppRuntimeField_C};
        }
        public static UnityEngine.Color GetAltColor()
        {
            null = null;
            return new UnityEngine.Color() {r = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView.AltColor, g = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView.MainColor.__il2cppRuntimeField_14, b = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView.MainColor.__il2cppRuntimeField_18, a = Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView.MainColor.__il2cppRuntimeField_1C};
        }
        public CellView()
        {
        
        }
        private static CellView()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView.MainColor = 0;
            Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView.AltColor = 0;
        }
    
    }

}
