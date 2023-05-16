using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.PotionItem
{
    public class PotionItemHelper : IGameContextUnit, IContextUnit, ILateContextUnit
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Matches.MatchType missingMatchType;
        private bool missingMatchTypeCalculated;
        private System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchType> defaultMatchTypes;
        private int potionCount;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 24;
        }
        public void Bind()
        {
            this.missingMatchTypeCalculated = false;
            this.defaultMatchTypes = 0;
        }
        public void Clear(bool gameExit)
        {
            this.potionCount = 0;
        }
        public System.ValueTuple<bool, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchType>> GetMatchList(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings itemSettings, Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory)
        {
            var val_3;
            var val_4;
            val_3 = 1152921520190283088;
            Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType val_3 = itemSettings.staticItemType;
            if((itemSettings.staticItemType == 0) || (this.potionCount >= W10))
            {
                goto label_2;
            }
            
            val_3 = val_3 + ((this.potionCount) << 3);
            if((-1596424864) != (-1476395008))
            {
                goto label_5;
            }
            
            System.Collections.Generic.List<TSource> val_1 = System.Linq.Enumerable.ToList<Royal.Scenes.Game.Mechanics.Matches.MatchType>(source:  27813);
            val_4 = 1;
            goto label_6;
            label_2:
            label_7:
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchType> val_2 = this.GetDefaultMatchTypes(itemSettings:  new Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings() {tiledId = itemSettings.tiledId, itemType = itemSettings.tiledId, layerCount = itemSettings.layerCount, goalType = itemSettings.goalType, staticItemType = itemSettings.goalType, isExtraPropeller = itemSettings.isExtraPropeller, isCreatedByLightball = false, isDrillMaster = false}, itemFactory:  itemFactory);
            val_4 = 0;
            label_6:
            int val_4 = this.potionCount;
            val_4 = val_4 + 1;
            this.potionCount = val_4;
            return 0;
            label_5:
            goto label_7;
        }
        private System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchType> GetDefaultMatchTypes(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings itemSettings, Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory)
        {
            var val_4;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchType> val_5;
            val_4 = itemFactory;
            val_5 = this.defaultMatchTypes;
            if(val_5 != null)
            {
                    return System.Linq.Enumerable.ToList<Royal.Scenes.Game.Mechanics.Matches.MatchType>(source:  System.Collections.Generic.List<T> val_3 = val_4.GetRange(index:  0, count:  UnityEngine.Mathf.Min(a:  47603712, b:  -1596147968)));
            }
            
            val_4 = itemFactory.itemCreator.GetColors();
            this.defaultMatchTypes = val_3;
            return System.Linq.Enumerable.ToList<Royal.Scenes.Game.Mechanics.Matches.MatchType>(source:  val_3);
        }
        public Royal.Scenes.Game.Mechanics.Matches.MatchType GetMissingMatchType(System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchType> potionMatchTypes)
        {
            if(this.missingMatchTypeCalculated == true)
            {
                    return (Royal.Scenes.Game.Mechanics.Matches.MatchType)this.missingMatchType;
            }
            
            this.missingMatchTypeCalculated = true;
            this.FindMissingMatchType(potionMatchTypes:  potionMatchTypes);
            return (Royal.Scenes.Game.Mechanics.Matches.MatchType)this.missingMatchType;
        }
        private void FindMissingMatchType(System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchType> potionMatchTypes)
        {
            var val_8;
            var val_9;
            var val_12;
            val_8 = potionMatchTypes;
            System.Array val_2 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            if(val_2 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_9 = val_2.GetEnumerator();
            label_21:
            var val_9 = 0;
            if(mem[1152921504680579072] != null)
            {
                    val_9 = val_9 + 1;
            }
            else
            {
                    System.Collections.IEnumerator val_4 = 1152921504680542208 + ((mem[1152921504680579080]) << 4);
            }
            
            if(val_9.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_10 = 0;
            if(mem[1152921504680579072] != null)
            {
                    val_10 = val_10 + 1;
            }
            else
            {
                    var val_11 = mem[1152921504680579080];
                val_11 = val_11 + 1;
                System.Collections.IEnumerator val_6 = 1152921504680542208 + val_11;
            }
            
            object val_7 = val_9.Current;
            if(val_7 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_7.System.IDisposable.Dispose();
            if((null == null) || (null == 6))
            {
                goto label_21;
            }
            
            if(val_8 == null)
            {
                    throw new NullReferenceException();
            }
            
            if((val_8.Contains(item:  1152921504626016256)) == true)
            {
                goto label_21;
            }
            
            val_8 = 0;
            this.missingMatchType = null;
            goto label_35;
            label_11:
            val_8 = 0;
            label_35:
            if(X0 == false)
            {
                goto label_23;
            }
            
            var val_14 = X0;
            val_9 = X0;
            if((X0 + 294) == 0)
            {
                goto label_27;
            }
            
            var val_12 = X0 + 176;
            var val_13 = 0;
            val_12 = val_12 + 8;
            label_26:
            if(((X0 + 176 + 8) + -8) == null)
            {
                goto label_25;
            }
            
            val_13 = val_13 + 1;
            val_12 = val_12 + 16;
            if(val_13 < (X0 + 294))
            {
                goto label_26;
            }
            
            goto label_27;
            label_25:
            val_14 = val_14 + (((X0 + 176 + 8)) << 4);
            val_12 = val_14 + 304;
            label_27:
            val_9.Dispose();
            label_23:
            if(val_8 != 0)
            {
                    throw val_8;
            }
        
        }
        public PotionItemHelper()
        {
        
        }
    
    }

}
