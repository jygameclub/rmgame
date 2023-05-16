using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CupItem
{
    public class CupItemHelper : IGameContextBehaviour, IGameContextUnit, IContextUnit, IContextBehaviour, ILateContextUnit
    {
        // Fields
        private readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.CupItem.CupItemModel[]> cupShelves;
        private Royal.Scenes.Game.Mechanics.Items.CupItem.CupShakeData[] shakeData;
        private Royal.Player.Context.Units.LevelManager levelManager;
        private Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private Royal.Infrastructure.Utils.Randoming.RandomManager randomManager;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 28;
        }
        public void Bind()
        {
            this.levelManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2);
            this.gridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.randomManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5);
        }
        public void ManualUpdate()
        {
            var val_11;
            var val_12;
            var val_13;
            float val_14;
            var val_15;
            val_11 = this;
            if(this.shakeData == null)
            {
                    return;
            }
            
            val_12 = 0;
            label_28:
            if(val_12 >= this.shakeData.Length)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Items.CupItem.CupShakeData val_10 = this.shakeData[0];
            if(this.shakeData.Length <= val_12)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(this.shakeData[0x0][0].isShaking == false)
            {
                goto label_19;
            }
            
            int val_11 = this.shakeData[0x0][0].pointStep;
            if(val_11 > 5)
            {
                goto label_19;
            }
            
            val_13 = val_10;
            val_11 = val_11 + 0;
            val_14 = this.shakeData[0x0][0].moveElapsed;
            if(val_14 > (this.shakeData[0x0][0] + 24 + -8))
            {
                goto label_9;
            }
            
            val_14 = 0f;
            if(((this.shakeData[0x0][0] + 24) & 1) == 0)
            {
                goto label_10;
            }
            
            label_9:
            UnityEngine.Vector3 val_2 = (this.shakeData[0x0][0].pointStep + 0) + 32 + 32 + 32.transform.localPosition;
            if((val_10.StartMove(startPosition:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z})) == false)
            {
                goto label_17;
            }
            
            label_10:
            float val_4 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
            val_4 = (this.shakeData[0x0][0] + 24) + val_4;
            mem2[0] = val_4;
            if(((this.shakeData[0x0][0].pointStep + 0) + 32 + 24) >= 1)
            {
                    var val_12 = 0;
                do
            {
                var val_5 = ((this.shakeData[0x0][0].pointStep + 0) + 32) + 0;
                if((((this.shakeData[0x0][0].pointStep + 0) + 32 + 0) + 32 + 32 + 16) != 0)
            {
                    UnityEngine.Vector3 val_7 = val_10.GetMovePosition();
                ((this.shakeData[0x0][0].pointStep + 0) + 32 + 0) + 32 + 32.transform.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            }
            
                val_12 = val_12 + 1;
            }
            while(val_12 < ((this.shakeData[0x0][0].pointStep + 0) + 32 + 24));
            
            }
            
            label_19:
            val_12 = val_12 + 1;
            if(this.shakeData != null)
            {
                goto label_28;
            }
            
            label_17:
            val_10 = 0;
            val_10 = 0;
            val_10 = 0;
            val_15 = mem[(this.shakeData[0x0][0].pointStep + 0) + 32 + 24];
            val_15 = (this.shakeData[0x0][0].pointStep + 0) + 32 + 24;
            if(val_15 < 1)
            {
                    return;
            }
            
            val_12 = 1152921504781127680;
            var val_13 = 0;
            val_13 = ((this.shakeData[0x0][0].pointStep + 0) + 32) + 32;
            do
            {
                if((((this.shakeData[0x0][0].pointStep + 0) + 32 + 32) + 0 + 32 + 16) != 0)
            {
                    val_11 = ((this.shakeData[0x0][0].pointStep + 0) + 32 + 32) + 0 + 32.transform;
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
                val_11.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
                val_15 = mem[(this.shakeData[0x0][0].pointStep + 0) + 32 + 24];
                val_15 = (this.shakeData[0x0][0].pointStep + 0) + 32 + 24;
            }
            
                val_13 = val_13 + 1;
            }
            while(val_13 < val_15);
        
        }
        public void Clear(bool gameExit)
        {
            this.cupShelves.Clear();
            System.Array.Clear(array:  this.shakeData, index:  0, length:  this.shakeData.Length);
        }
        public void InitCups()
        {
            var val_14;
            var val_15;
            object val_16;
            if(this.cupShelves > 0)
            {
                    return;
            }
            
            int val_1 = this.levelManager.parser.GetCupShelvesLength();
            if(val_1 >= 1)
            {
                    do
            {
                System.Nullable<Royal.Scenes.Game.Utils.FlatLevel.FCellGroupData> val_2 = this.levelManager.parser.GetCupShelfData(i:  0);
                Royal.Scenes.Game.Mechanics.Items.CupItem.CupItemModel[] val_5 = new Royal.Scenes.Game.Mechanics.Items.CupItem.CupItemModel[218693024];
                if(val_5.Length >= 1)
            {
                    var val_13 = 0;
                do
            {
                Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_6 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  218693008, y:  218693008);
                if((this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_6.x, y = val_6.x}].CurrentItem) != null)
            {
                    val_14 = null;
                val_14 = null;
            }
            
                val_15 = 0;
                mem2[0] = ;
                 = 0;
                val_13 = val_13 + 1;
            }
            while(val_13 < val_5.Length);
            
            }
            
                this.cupShelves.Add(item:  val_5);
                val_16 = 0 + 1;
            }
            while(val_16 < val_1);
            
            }
            
            Royal.Scenes.Game.Mechanics.Items.CupItem.CupShakeData[] val_10 = new Royal.Scenes.Game.Mechanics.Items.CupItem.CupShakeData[0];
            this.shakeData = val_10;
            var val_14 = 0;
            do
            {
                if(val_14 >= val_10.Length)
            {
                    return;
            }
            
                val_16 = new Royal.Scenes.Game.Mechanics.Items.CupItem.CupShakeData();
                .easing = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  4);
                val_16 = new System.Object();
                val_10[val_14] = val_16;
                val_14 = val_14 + 1;
            }
            while(this.shakeData != null);
            
            throw new NullReferenceException();
        }
        public int GetTotalRemainingExplodeCount(int cupShelfId)
        {
            var val_2;
            bool val_2 = true;
            if(val_2 <= cupShelfId)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + (cupShelfId << 3);
            if(((true + (cupShelfId) << 3) + 32 + 24) >= 1)
            {
                    var val_3 = 0;
                do
            {
                var val_1 = ((true + (cupShelfId) << 3) + 32) + 0;
                val_3 = val_3 + 1;
                val_2 = (((true + (cupShelfId) << 3) + 32 + 0) + 32) + 0;
            }
            while(val_3 < ((true + (cupShelfId) << 3) + 32 + 24));
            
                return (int)val_2;
            }
            
            val_2 = 0;
            return (int)val_2;
        }
        public void DamageCup(int cupShelfId)
        {
            var val_7;
            Royal.Scenes.Game.Mechanics.Items.CupItem.CupShakeData val_8;
            bool val_7 = true;
            if(val_7 <= cupShelfId)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + (cupShelfId << 3);
            Royal.Scenes.Game.Mechanics.Items.CupItem.CupShakeData val_8 = this.shakeData[(long)cupShelfId];
            float val_9 = this.shakeData[(long)(int)(cupShelfId)][0].lastCupShakeTime;
            if(((true + (cupShelfId) << 3) + 32 + 24) >= 1)
            {
                    var val_10 = 0;
                val_9 = UnityEngine.Time.time - val_9;
                do
            {
                var val_3 = ((true + (cupShelfId) << 3) + 32) + 0;
                val_7 = 1 & (((((true + (cupShelfId) << 3) + 32 + 0) + 32 + 80) == 0) ? 1 : 0);
                if((val_9 > 0.4f) && ((((true + (cupShelfId) << 3) + 32 + 0) + 32 + 80) != 0))
            {
                    ((true + (cupShelfId) << 3) + 32 + 0) + 32.RandomShake(randomOffset:  this.randomManager.Next(min:  0, max:  3), j:  0);
                val_7 = 0;
            }
            
                val_10 = val_10 + 1;
            }
            while(val_10 < ((true + (cupShelfId) << 3) + 32 + 24));
            
            }
            else
            {
                    val_7 = 1;
            }
            
            val_8 = this.shakeData[(long)cupShelfId];
            val_8 = 1;
            val_8 = UnityEngine.Time.time;
            if(this.shakeData[(long)(int)(cupShelfId)][0].pointStep >= 3)
            {
                    val_8 = 0;
                val_8 = 0;
            }
            
            if(val_7 == 0)
            {
                    return;
            }
            
            if(((true + (cupShelfId) << 3) + 32 + 24) < 1)
            {
                    return;
            }
            
            var val_6 = ((true + (cupShelfId) << 3) + 32) + 32;
            do
            {
                ((true + (cupShelfId) << 3) + 32 + 32) + 0.Destroy();
                val_8 = 0 + 1;
            }
            while(val_8 < ((true + (cupShelfId) << 3) + 32 + 24));
        
        }
        public CupItemHelper()
        {
            this.cupShelves = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.CupItem.CupItemModel[]>();
        }
    
    }

}
