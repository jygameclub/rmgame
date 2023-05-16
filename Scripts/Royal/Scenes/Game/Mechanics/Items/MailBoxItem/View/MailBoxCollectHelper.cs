using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View
{
    public class MailBoxCollectHelper : IGameContextUnit, IContextUnit, ILateContextUnit
    {
        // Fields
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private UnityEngine.Vector3 goalPosition;
        private Royal.Scenes.Game.Levels.Units.GoalManager goalManager;
        private readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailCollectData> collectList;
        private readonly Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailCollectSorter sorter;
        private const int RunInterval = 2;
        private const float MaxCollectDelay = 0.15;
        private int collectAccumulationStartFrame;
        
        // Properties
        public int Id { get; }
        private UnityEngine.Vector3 GoalPosition { get; }
        
        // Methods
        public int get_Id()
        {
            return 19;
        }
        private UnityEngine.Vector3 get_GoalPosition()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = this.goalPosition, y = V8.16B, z = V9.16B}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) == false)
            {
                    return new UnityEngine.Vector3() {x = this.goalPosition, y = V8.16B, z = V9.16B};
            }
            
            UnityEngine.Vector3 val_3 = this.goalManager.GetGoalPosition(goalType:  18);
            this.goalPosition = val_3;
            mem[1152921520253066812] = val_3.y;
            mem[1152921520253066816] = val_3.z;
            return new UnityEngine.Vector3() {x = this.goalPosition, y = V8.16B, z = V9.16B};
        }
        public void Bind()
        {
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.goalManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.GoalManager>(contextId:  11);
            Royal.Scenes.Game.Context.GameContext.RegisterToLateUpdate(lateUpdate:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailBoxCollectHelper::ManualLateUpdate()));
        }
        private void ManualLateUpdate()
        {
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailCollectData> val_4;
            if(this.collectList == null)
            {
                    return;
            }
            
            int val_4 = this.collectAccumulationStartFrame;
            val_4 = Royal.Scenes.Game.Levels.LevelContext.FrameCount - val_4;
            if(val_4 < 2)
            {
                    return;
            }
            
            if(val_4 == 2)
            {
                    this.collectList.Sort(comparer:  this.sorter);
                val_4 = this.collectList;
                if(1152921520253308768 >= 1)
            {
                    var val_6 = 0;
                if(1152921520253308768 <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                float val_5 = 0f;
                val_5 = (0.15f / (4.795146E+07f)) * val_5;
                mem2[0] = val_5;
                val_4 = this.collectList;
                val_6 = val_6 + 1;
            }
            
                val_4.Clear();
                return;
            }
            
            this.collectAccumulationStartFrame = Royal.Scenes.Game.Levels.LevelContext.FrameCount;
        }
        public void Clear(bool gameExit)
        {
            this.collectAccumulationStartFrame = 0;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.goalPosition = val_1;
            mem[1152921520253480636] = val_1.y;
            mem[1152921520253480640] = val_1.z;
            this.collectList.Clear();
        }
        public void Collect(Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailCollectData mailCollectData)
        {
            this.goalManager.FlyingToBeCollected(goalType:  18);
            Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailGoalView val_1 = this.itemFactory.Spawn<Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailGoalView>(poolId:  49, activate:  true);
            UnityEngine.Vector3 val_3 = this.GoalPosition;
            val_1.InitAndMove(parent:  mailCollectData.itemView.transform, targetPosition:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, onComplete:  new System.Action(object:  mailCollectData.itemView, method:  public System.Void Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailBoxItemView::CollectAnimationCompleted()));
            mailCollectData = val_1;
            this.collectList.Add(item:  mailCollectData);
        }
        public MailBoxCollectHelper()
        {
            this.collectList = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailCollectData>(capacity:  20);
            this.sorter = new Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailCollectSorter();
        }
    
    }

}
