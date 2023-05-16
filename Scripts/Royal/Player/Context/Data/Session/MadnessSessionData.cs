using UnityEngine;

namespace Royal.Player.Context.Data.Session
{
    public class MadnessSessionData : BeforeAfterData
    {
        // Fields
        private int eventId;
        private System.Collections.Generic.Dictionary<int, int> exploderIdMatchItemCount;
        
        // Properties
        private Royal.Player.Context.Units.MadnessManager MadnessManager { get; }
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory ItemFactory { get; }
        public Royal.Scenes.Game.Mechanics.Matches.MatchType MatchTypeToCollect { get; }
        
        // Methods
        private Royal.Player.Context.Units.MadnessManager get_MadnessManager()
        {
            return Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10);
        }
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory get_ItemFactory()
        {
            return Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
        }
        public Royal.Scenes.Game.Mechanics.Matches.MatchType get_MatchTypeToCollect()
        {
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_3;
            bool val_1 = this.IsEventValid();
            if(val_1 != false)
            {
                    Royal.Player.Context.Units.MadnessManager val_2 = val_1.MadnessManager;
                val_3 = val_2.<CollectMatchType>k__BackingField;
                return (Royal.Scenes.Game.Mechanics.Matches.MatchType)val_3;
            }
            
            val_3 = 0;
            return (Royal.Scenes.Game.Mechanics.Matches.MatchType)val_3;
        }
        public void Init(bool isStory, bool isRestart)
        {
            bool val_11 = isStory;
            if(val_11 == true)
            {
                goto label_3;
            }
            
            bool val_2 = this.MadnessManager.ShouldShowIcon;
            if(val_2 == false)
            {
                goto label_3;
            }
            
            val_11 = this.eventId;
            if((val_11 == val_3.eventId) || (isRestart == false))
            {
                goto label_6;
            }
            
            label_3:
            this.eventId = 0;
            this.exploderIdMatchItemCount = 0;
            label_13:
            mem[1152921524213809472] = 0;
            mem[1152921524213809476] = 0;
            mem[1152921524213809480] = 0;
            return;
            label_6:
            this.eventId = val_6.eventId;
            Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory val_7 = val_2.MadnessManager.MadnessManager.GetCount().MadnessManager.ItemFactory;
            Royal.Player.Context.Units.MadnessManager val_8 = val_7.MadnessManager;
            val_7.CreateMadnessPools(itemType:  val_8.<CollectItemType>k__BackingField);
            Royal.Player.Context.Units.MadnessManager val_9 = val_7.MadnessManager;
            if((val_9.<CollectItemType>k__BackingField) != 1)
            {
                goto label_13;
            }
            
            this.exploderIdMatchItemCount = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
            goto label_13;
        }
        public void TryAddMadnessSpecial(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel itemModel, UnityEngine.Vector3 position, int difficulty, int animationDelayInFrames)
        {
            bool val_1 = this.IsEventValid();
            if(val_1 == false)
            {
                    return;
            }
            
            Royal.Player.Context.Units.MadnessManager val_2 = val_1.MadnessManager;
            if((val_2.<CollectItemType>k__BackingField) != itemModel)
            {
                    return;
            }
            
            mem[1152921524213983944] = null;
            mem[1152921524213983936] = 1;
            difficulty = itemModel.ItemFactory.Spawn<Royal.Scenes.Game.Ui.Madness.MadnessAnimationView>(poolId:  96, activate:  true);
            if(difficulty == 0)
            {
                    return;
            }
            
            difficulty.StartAnimation(itemModel:  itemModel, targetPos:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, animationDelayInFrames:  animationDelayInFrames);
        }
        public void TryAddMadnessMatch(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType, UnityEngine.Vector3 originPosition, int count, int difficulty, int animationDelayInFrames, Royal.Scenes.Game.Mechanics.Items.Config.ItemModel createdItem)
        {
            bool val_6 = true;
            if(matchType == 0)
            {
                    return;
            }
            
            if(count == 0)
            {
                    return;
            }
            
            if(this.IsEventValid() == false)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_2 = this.MatchTypeToCollect;
            if(val_2 != matchType)
            {
                    return;
            }
            
            val_6 = val_6 + (1 * count);
            mem[1152921524214137928] = val_6;
            mem[1152921524214137920] = 1;
            Royal.Scenes.Game.Ui.Madness.MadnessMatchItemAnimationView val_4 = val_2.ItemFactory.Spawn<Royal.Scenes.Game.Ui.Madness.MadnessMatchItemAnimationView>(poolId:  97, activate:  true);
            if(val_4 == 0)
            {
                    return;
            }
            
            val_4.StartAnimation(originPosition:  new UnityEngine.Vector3() {x = originPosition.x, y = originPosition.y, z = originPosition.z}, count:  count, animationDelayInFrames:  animationDelayInFrames, itemModel:  createdItem);
        }
        public void TryAddMadnessForRemainingMoves(int notReplacedMoves, int difficulty)
        {
            if(notReplacedMoves < 1)
            {
                    return;
            }
            
            if(this.IsEventValid() == false)
            {
                    return;
            }
            
            var val_4 = 1;
            int val_3 = (this.MatchTypeToCollect != 0) ? 5 : (0 + 1);
            val_4 = val_4 * notReplacedMoves;
            val_3 = W11 + (val_4 * val_3);
            mem[1152921524214274504] = val_3;
            mem[1152921524214274496] = 1;
        }
        public void TryIncrementMadnessForExploderId(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType, int exploderId)
        {
            if(this.IsEventValid() == false)
            {
                    return;
            }
            
            if(this.MatchTypeToCollect != matchType)
            {
                    return;
            }
            
            if(this.exploderIdMatchItemCount == null)
            {
                    return;
            }
            
            bool val_4 = this.exploderIdMatchItemCount.TryGetValue(key:  exploderId, value: out  0);
            this.exploderIdMatchItemCount.set_Item(key:  exploderId, value:  1);
        }
        public int GetMadnessForExploderId(int exploderId)
        {
            System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_4;
            int val_1 = 0;
            val_4 = this.exploderIdMatchItemCount;
            if(val_4 == null)
            {
                    return (int)((val_4.TryGetValue(key:  exploderId, value: out  val_1)) != true) ? (val_1) : 0;
            }
            
            return (int)((val_4.TryGetValue(key:  exploderId, value: out  val_1)) != true) ? (val_1) : 0;
        }
        public bool CanClaimDuringLevel()
        {
            var val_9;
            var val_10;
            val_9 = this;
            bool val_1 = this.IsEventValid();
            if(val_1 != false)
            {
                    int val_3 = val_1.MadnessManager.GetCount();
                val_9 = val_3;
                var val_8 = (((W21 - W20) + val_9) >= val_3.MadnessManager.GetCurrentTarget()) ? 1 : 0;
                return (bool)val_10;
            }
            
            val_10 = 0;
            return (bool)val_10;
        }
        public bool IsEventValid()
        {
            if(W8 == 1)
            {
                    return false;
            }
            
            if(this.eventId != val_1.eventId)
            {
                    return false;
            }
            
            return this.MadnessManager.MadnessManager.ShouldShowIcon;
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemType GetRemainingMoveReplaceItem()
        {
            Royal.Scenes.Game.Mechanics.Items.Config.ItemType val_4;
            bool val_1 = this.IsEventValid();
            if(val_1 != false)
            {
                    if((val_2.<CollectItemType>k__BackingField) != 1)
            {
                goto label_2;
            }
            
            }
            
            val_4 = 0;
            return val_4;
            label_2:
            Royal.Player.Context.Units.MadnessManager val_3 = val_1.MadnessManager.MadnessManager;
            val_4 = val_3.<CollectItemType>k__BackingField;
            return val_4;
        }
        public MadnessSessionData()
        {
            this.eventId = 0;
            val_1 = new System.Object();
        }
    
    }

}
