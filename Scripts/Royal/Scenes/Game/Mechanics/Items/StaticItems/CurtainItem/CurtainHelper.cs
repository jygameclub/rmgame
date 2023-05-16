using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem
{
    public class CurtainHelper : IGameContextUnit, IContextUnit
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Matches.MatchType, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager>> curtainMap;
        private Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private System.Action OnCurtainReveal;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 26;
        }
        public void add_OnCurtainReveal(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnCurtainReveal, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnCurtainReveal != 1152921520043182960);
            
            return;
            label_2:
        }
        public void remove_OnCurtainReveal(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnCurtainReveal, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnCurtainReveal != 1152921520043319536);
            
            return;
            label_2:
        }
        public void Bind()
        {
            Royal.Scenes.Game.Levels.Units.CellGridManager val_1 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.gridManager = val_1;
            val_1.add_OnCellGridViewsInitialized(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainHelper::OnCellGridViewInitialized()));
        }
        private void OnCellGridViewInitialized()
        {
            var val_3;
            var val_4;
            var val_6;
            var val_8;
            var val_9;
            val_6 = this;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.curtainMap.GetEnumerator();
            label_10:
            val_8 = public System.Boolean Dictionary.Enumerator<Royal.Scenes.Game.Mechanics.Matches.MatchType, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager>>::MoveNext();
            if(((-1743144864) & 1) == 0)
            {
                goto label_2;
            }
            
            val_9 = val_3;
            if(val_9 == 0)
            {
                    throw new NullReferenceException();
            }
            
            List.Enumerator<T> val_5 = val_9.GetEnumerator();
            label_6:
            if(((-1743144896) & 1) == 0)
            {
                goto label_4;
            }
            
            if(val_3 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_3.Init();
            goto label_6;
            label_4:
            var val_6 = 0 + 1;
            val_6 = 0;
            mem2[0] = 74;
            val_4.Dispose();
            if(val_6 != 0)
            {
                goto label_11;
            }
            
            if((val_6 == 1) || ((1152921520043571200 + ((0 + 1)) << 2) != 74))
            {
                goto label_10;
            }
            
            var val_8 = val_6 + (0 ^ (val_6 >> 31));
            goto label_10;
            label_2:
            var val_9 = 0 + 1;
            mem2[0] = 99;
            val_4.Dispose();
            return;
            label_11:
            val_9 = val_6;
            val_8 = 0;
            throw val_9;
        }
        public void AddCurtain(int id, Royal.Scenes.Game.Utils.LevelParser.TiledId curtainId, int order, int target, int width, int height, int minX, int minY)
        {
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager> val_3 = 0;
            Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager val_1 = new Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager(id:  id, tiledId:  curtainId, order:  order, initialTarget:  target, width:  width, height:  height, minX:  minX, minY:  minY);
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_2 = Royal.Scenes.Game.Utils.LevelParser.TiledToTypeConverter.GetColorForTiledId(tileId:  curtainId);
            bool val_4 = this.curtainMap.TryGetValue(key:  val_2, value: out  val_3);
            if(val_4 != false)
            {
                    val_4.AddCurtainByOrder(curtains:  val_3, curtain:  val_1);
                return;
            }
            
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager> val_5 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager>();
            val_5.Add(item:  val_1);
            this.curtainMap.Add(key:  val_2, value:  val_5);
        }
        private void AddCurtainByOrder(System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager> curtains, Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager curtain)
        {
            bool val_1 = true;
            if(val_1 < 1)
            {
                goto label_2;
            }
            
            var val_2 = 0;
            label_7:
            if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            if(curtain.order < ((true + 0) + 32 + 28))
            {
                goto label_6;
            }
            
            val_2 = val_2 + 1;
            if(val_2 < ((true + 0) + 32 + 28))
            {
                goto label_7;
            }
            
            label_2:
            curtains.Add(item:  curtain);
            return;
            label_6:
            curtains.Insert(index:  0, item:  curtain);
        }
        public void Clear(bool gameExit)
        {
            var val_4;
            var val_5;
            Royal.Scenes.Game.Levels.Units.CellGridManager val_7;
            var val_9;
            var val_10;
            val_7 = gameExit;
            this.OnCurtainReveal = 0;
            if(val_7 != false)
            {
                    val_7 = this.gridManager;
                val_7.remove_OnCellGridViewsInitialized(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainHelper::OnCellGridViewInitialized()));
            }
            
            Dictionary.Enumerator<TKey, TValue> val_2 = this.curtainMap.GetEnumerator();
            label_12:
            val_9 = public System.Boolean Dictionary.Enumerator<Royal.Scenes.Game.Mechanics.Matches.MatchType, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager>>::MoveNext();
            if(((-1742720800) & 1) == 0)
            {
                goto label_4;
            }
            
            val_10 = val_4;
            if(val_10 == 0)
            {
                    throw new NullReferenceException();
            }
            
            List.Enumerator<T> val_6 = val_10.GetEnumerator();
            label_8:
            if(((-1742720832) & 1) == 0)
            {
                goto label_6;
            }
            
            if(val_4 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_4.RecycleTokenView();
            goto label_8;
            label_6:
            var val_7 = 0 + 1;
            val_7 = 0;
            mem2[0] = 107;
            val_5.Dispose();
            if(val_7 != 0)
            {
                goto label_13;
            }
            
            if((val_7 == 1) || ((1152921520043995264 + ((0 + 1)) << 2) != 107))
            {
                goto label_12;
            }
            
            var val_9 = val_7 + (0 ^ (val_7 >> 31));
            goto label_12;
            label_4:
            var val_10 = 0 + 1;
            mem2[0] = 132;
            val_5.Dispose();
            this.curtainMap.Clear();
            return;
            label_13:
            val_10 = val_7;
            val_9 = 0;
            throw val_10;
        }
        public void TriggerCurtainReveal()
        {
            if(this.OnCurtainReveal == null)
            {
                    return;
            }
            
            this.OnCurtainReveal.Invoke();
        }
        public Royal.Scenes.Game.Utils.LevelParser.TiledId GetCurtainTiledIdById(int curtainGroupId)
        {
            var val_3;
            var val_4;
            var val_7;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            val_7 = this;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.curtainMap.GetEnumerator();
            val_9 = 0;
            label_13:
            val_10 = public System.Boolean Dictionary.Enumerator<Royal.Scenes.Game.Mechanics.Matches.MatchType, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager>>::MoveNext();
            if(((-1742472224) & 1) == 0)
            {
                goto label_2;
            }
            
            val_11 = val_3;
            if(val_11 == 0)
            {
                    throw new NullReferenceException();
            }
            
            List.Enumerator<T> val_5 = val_11.GetEnumerator();
            label_6:
            if(((-1742472256) & 1) == 0)
            {
                goto label_4;
            }
            
            if(val_3 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((val_3 + 16) != curtainGroupId)
            {
                goto label_6;
            }
            
            val_9 = mem[val_3 + 20];
            val_9 = val_3 + 20;
            val_12 = 0 + 1;
            val_13 = 117;
            goto label_7;
            label_4:
            val_12 = 0 + 1;
            val_13 = 89;
            label_7:
            val_7 = 0;
            mem2[0] = 89;
            val_4.Dispose();
            if(val_7 != 0)
            {
                goto label_14;
            }
            
            if(val_12 == 1)
            {
                goto label_13;
            }
            
            if((1152921520044243840 + ((0 + 1)) << 2) == 89)
            {
                goto label_10;
            }
            
            if((1152921520044243840 + ((0 + 1)) << 2) != 117)
            {
                goto label_13;
            }
            
            goto label_12;
            label_10:
            var val_8 = 0;
            val_8 = val_8 ^ (val_12 >> 31);
            var val_6 = val_12 + val_8;
            goto label_13;
            label_2:
            val_12 = 0 + 1;
            mem2[0] = 114;
            label_12:
            val_4.Dispose();
            val_14 = 111;
            if(val_12 == 1)
            {
                    return (Royal.Scenes.Game.Utils.LevelParser.TiledId)((1152921520044243840 + ((0 + 1)) << 2) == 117) ? (val_9) : 111;
            }
            
            return (Royal.Scenes.Game.Utils.LevelParser.TiledId)((1152921520044243840 + ((0 + 1)) << 2) == 117) ? (val_9) : 111;
            label_14:
            val_11 = val_7;
            val_10 = 0;
            throw val_11;
        }
        public Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager GetCurtainForMatchType(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_3;
            var val_4;
            var val_5;
            val_3 = matchType;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager> val_1 = 0;
            if((this.curtainMap.TryGetValue(key:  val_3, value: out  val_1)) == false)
            {
                goto label_4;
            }
            
            val_3 = val_1;
            var val_6 = 0;
            label_13:
            if(val_6 >= 10360992)
            {
                goto label_4;
            }
            
            if(10360992 <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = 11993091;
            val_3 = val_3 + 0;
            val_3 = val_1;
            val_4 = 10360992;
            if(((11993091 + 0) + 32 + 44) >= 1)
            {
                goto label_8;
            }
            
            if(val_6 < 10360991)
            {
                goto label_9;
            }
            
            if(val_4 <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = 11993091;
            val_4 = val_4 + 0;
            var val_5 = (11993091 + 0) + 32 + 44 + 4;
            val_3 = val_1;
            val_5 = val_5 + ((11993091 + 0) + 32 + 44);
            if(val_5 >= 1)
            {
                goto label_12;
            }
            
            label_9:
            val_6 = val_6 + 1;
            if(val_3 != 0)
            {
                goto label_13;
            }
            
            label_4:
            val_5 = 0;
            return (Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager)val_5;
            label_12:
            val_4 = 10360992;
            label_8:
            if(val_4 <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_7 = 11993091;
            val_7 = val_7 + 0;
            val_5 = mem[(11993091 + 0) + 32];
            val_5 = (11993091 + 0) + 32;
            return (Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager)val_5;
        }
        public Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager GetCurtainManagerById(int curtainGroupId)
        {
            var val_3;
            var val_4;
            var val_7;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            val_7 = this;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.curtainMap.GetEnumerator();
            val_9 = 0;
            label_13:
            val_10 = public System.Boolean Dictionary.Enumerator<Royal.Scenes.Game.Mechanics.Matches.MatchType, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager>>::MoveNext();
            if(((-1742223648) & 1) == 0)
            {
                goto label_2;
            }
            
            val_11 = val_3;
            if(val_11 == 0)
            {
                    throw new NullReferenceException();
            }
            
            List.Enumerator<T> val_5 = val_11.GetEnumerator();
            label_6:
            if(((-1742223680) & 1) == 0)
            {
                goto label_4;
            }
            
            if(val_3 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((val_3 + 16) != curtainGroupId)
            {
                goto label_6;
            }
            
            val_12 = 0 + 1;
            val_7 = 0;
            mem2[0] = 111;
            val_9 = val_3;
            goto label_17;
            label_4:
            val_12 = 0 + 1;
            val_7 = 0;
            mem2[0] = 84;
            label_17:
            val_4.Dispose();
            if(val_7 != 0)
            {
                goto label_14;
            }
            
            if(val_12 == 1)
            {
                goto label_13;
            }
            
            if((1152921520044492416 + ((0 + 1)) << 2) == 84)
            {
                goto label_10;
            }
            
            if((1152921520044492416 + ((0 + 1)) << 2) != 111)
            {
                goto label_13;
            }
            
            goto label_12;
            label_10:
            var val_8 = 0;
            val_8 = val_8 ^ (val_12 >> 31);
            var val_6 = val_12 + val_8;
            goto label_13;
            label_2:
            val_12 = 0 + 1;
            mem2[0] = 109;
            label_12:
            val_4.Dispose();
            if(val_12 != 1)
            {
                    var val_7 = ((1152921520044492416 + ((0 + 1)) << 2) == 111) ? (val_9) : 0;
                return (Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager)val_13;
            }
            
            val_13 = 0;
            return (Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager)val_13;
            label_14:
            val_11 = val_7;
            val_10 = 0;
            throw val_11;
        }
        public void ArrangeCurtainsSortingForTutorial()
        {
            var val_3;
            var val_4;
            var val_6;
            var val_8;
            var val_9;
            val_6 = this;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.curtainMap.GetEnumerator();
            label_10:
            val_8 = public System.Boolean Dictionary.Enumerator<Royal.Scenes.Game.Mechanics.Matches.MatchType, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager>>::MoveNext();
            if(((-1742103456) & 1) == 0)
            {
                goto label_2;
            }
            
            val_9 = val_3;
            if(val_9 == 0)
            {
                    throw new NullReferenceException();
            }
            
            List.Enumerator<T> val_5 = val_9.GetEnumerator();
            label_6:
            if(((-1742103488) & 1) == 0)
            {
                goto label_4;
            }
            
            if(val_3 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_3.ArrangeSortingForTutorial();
            goto label_6;
            label_4:
            var val_6 = 0 + 1;
            val_6 = 0;
            mem2[0] = 74;
            val_4.Dispose();
            if(val_6 != 0)
            {
                goto label_11;
            }
            
            if((val_6 == 1) || ((1152921520044612608 + ((0 + 1)) << 2) != 74))
            {
                goto label_10;
            }
            
            var val_8 = val_6 + (0 ^ (val_6 >> 31));
            goto label_10;
            label_2:
            var val_9 = 0 + 1;
            mem2[0] = 99;
            val_4.Dispose();
            return;
            label_11:
            val_9 = val_6;
            val_8 = 0;
            throw val_9;
        }
        public void ResetCurtainsSortingAfterTutorial()
        {
            var val_3;
            var val_4;
            var val_6;
            var val_8;
            var val_9;
            val_6 = this;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.curtainMap.GetEnumerator();
            label_10:
            val_8 = public System.Boolean Dictionary.Enumerator<Royal.Scenes.Game.Mechanics.Matches.MatchType, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager>>::MoveNext();
            if(((-1741983264) & 1) == 0)
            {
                goto label_2;
            }
            
            val_9 = val_3;
            if(val_9 == 0)
            {
                    throw new NullReferenceException();
            }
            
            List.Enumerator<T> val_5 = val_9.GetEnumerator();
            label_6:
            if(((-1741983296) & 1) == 0)
            {
                goto label_4;
            }
            
            if(val_3 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_3.ResetSortingAfterTutorial();
            goto label_6;
            label_4:
            var val_6 = 0 + 1;
            val_6 = 0;
            mem2[0] = 74;
            val_4.Dispose();
            if(val_6 != 0)
            {
                goto label_11;
            }
            
            if((val_6 == 1) || ((1152921520044732800 + ((0 + 1)) << 2) != 74))
            {
                goto label_10;
            }
            
            var val_8 = val_6 + (0 ^ (val_6 >> 31));
            goto label_10;
            label_2:
            var val_9 = 0 + 1;
            mem2[0] = 99;
            val_4.Dispose();
            return;
            label_11:
            val_9 = val_6;
            val_8 = 0;
            throw val_9;
        }
        public CurtainHelper()
        {
            this.curtainMap = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Matches.MatchType, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager>>();
        }
    
    }

}
