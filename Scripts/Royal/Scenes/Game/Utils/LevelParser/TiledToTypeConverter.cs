using UnityEngine;

namespace Royal.Scenes.Game.Utils.LevelParser
{
    public static class TiledToTypeConverter
    {
        // Methods
        public static Royal.Scenes.Game.Utils.LevelParser.TiledId GetTiledIdFromInt(int id)
        {
            return (Royal.Scenes.Game.Utils.LevelParser.TiledId)id;
        }
        public static Royal.Scenes.Game.Mechanics.Board.Cell.CellType AsCellType(Royal.Scenes.Game.Utils.LevelParser.TiledId id)
        {
            if(id == 0)
            {
                    return (Royal.Scenes.Game.Mechanics.Board.Cell.CellType)((id - 11) > 1) ? 1 : 0;
            }
            
            return (Royal.Scenes.Game.Mechanics.Board.Cell.CellType)((id - 11) > 1) ? 1 : 0;
        }
        public static Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType AsStaticItemType(Royal.Scenes.Game.Utils.LevelParser.TiledId id)
        {
            Royal.Scenes.Game.Utils.LevelParser.TiledId val_6;
            var val_7;
            val_6 = id;
            if(val_6 > 32)
            {
                goto label_1;
            }
            
            if(val_6 != 19)
            {
                goto label_2;
            }
            
            val_7 = 0;
            return (Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType)val_7;
            label_1:
            if(val_6 != 33)
            {
                goto label_4;
            }
            
            val_7 = 2;
            return (Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType)val_7;
            label_2:
            if((val_6 - 31) > 1)
            {
                goto label_6;
            }
            
            val_7 = 1;
            return (Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType)val_7;
            label_4:
            if((val_6 - 111) < 4)
            {
                goto label_8;
            }
            
            if((val_6 - 149) < 2)
            {
                goto label_9;
            }
            
            label_6:
            object[] val_5 = new object[1];
            val_6 = val_6;
            val_5[0] = val_6;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClassType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), logTag:  5, log:  "Can\'t convert tileId to staticItemType: {0}", values:  val_5);
            val_7 = 0;
            return (Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType)val_7;
            label_8:
            val_7 = 3;
            return (Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType)val_7;
            label_9:
            val_7 = 4;
            return (Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType)val_7;
        }
        public static Royal.Scenes.Game.Mechanics.Items.Config.ItemType AsItemType(Royal.Scenes.Game.Utils.LevelParser.TiledId id)
        {
            Royal.Scenes.Game.Utils.LevelParser.TiledId val_4;
            var val_5;
            val_4 = id;
            if((val_4 - 1) <= 147)
            {
                    var val_4 = 36624760 + ((id - 1)) << 2;
                val_4 = val_4 + 36624760;
            }
            else
            {
                    object[] val_3 = new object[1];
                val_4 = val_4;
                val_3[0] = val_4;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClassType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), logTag:  5, log:  "Can\'t convert tileId to itemType: {0}", values:  val_3);
                val_5 = 0;
                return (Royal.Scenes.Game.Mechanics.Items.Config.ItemType)val_5;
            }
        
        }
        public static int AsLayerCount(Royal.Scenes.Game.Utils.LevelParser.TiledId id)
        {
            if(id <= 110)
            {
                    if((id - 22) >= 89)
            {
                    return 1;
            }
            
                return (int)36626560 + ((id - 22)) << 2;
            }
            
            if(id <= 131)
            {
                    if((id & 4294967294) == 126)
            {
                    return 9;
            }
            
                return (int)(id == 131) ? 5 : (0 + 1);
            }
            
            if((id - 136) < 3)
            {
                    return 9;
            }
            
            return (int)(id == 150) ? (1 + 1) : 1;
        }
        public static bool IsASet(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId)
        {
            return (bool)((tiledId - 14) < 3) ? 1 : 0;
        }
        public static bool IsMatchItem(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId)
        {
            return (bool)((tiledId - 1) < 6) ? 1 : 0;
        }
        public static bool IsSpecialItem(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId)
        {
            Royal.Scenes.Game.Utils.LevelParser.TiledId val_1 = tiledId;
            if(tiledId <= 20)
            {
                    if(val_1 == 10)
            {
                    return true;
            }
            
                if(val_1 != 20)
            {
                    return false;
            }
            
                return true;
            }
            
            val_1 = val_1 - 30;
            if(val_1 >= 21)
            {
                    return false;
            }
            
            val_1 = 1049601 >> val_1;
            tiledId = val_1 & 1;
            return (bool)tiledId;
        }
        public static bool IsNotGoal(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId)
        {
            if((tiledId - 36) > 109)
            {
                    return false;
            }
            
            var val_2 = 36625352 + ((tiledId - 36)) << 2;
            val_2 = val_2 + 36625352;
            goto (36625352 + ((tiledId - 36)) << 2 + 36625352);
        }
        public static int GetSetIndex(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId)
        {
            Royal.Scenes.Game.Utils.LevelParser.TiledId val_1 = tiledId - 14;
            tiledId = (val_1 < 3) ? (val_1) : (!0);
            return (int)tiledId;
        }
        public static Royal.Scenes.Game.Mechanics.Goal.GoalType GetGoalTypeFromGoalString(string goalString)
        {
            var val_38;
            string val_1 = goalString.ToLower();
            uint val_2 = _PrivateImplementationDetails_.ComputeStringHash(s:  val_1);
            if(val_2 > 1746811083)
            {
                goto label_2;
            }
            
            if(val_2 > 698390418)
            {
                goto label_3;
            }
            
            if(val_2 > 102389280)
            {
                goto label_4;
            }
            
            if(val_2 > 60540468)
            {
                goto label_5;
            }
            
            if(val_2 == 44772347)
            {
                goto label_6;
            }
            
            if((val_2 != 60540468) || ((System.String.op_Equality(a:  val_1, b:  "bowtiegoal")) == false))
            {
                goto label_120;
            }
            
            val_38 = 40;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_2:
            if(val_2 > (-1209072190))
            {
                goto label_10;
            }
            
            if(val_2 > (-2020957316))
            {
                goto label_11;
            }
            
            if(val_2 > (-2114836449))
            {
                goto label_12;
            }
            
            if(val_2 == (-2114836449))
            {
                goto label_13;
            }
            
            if((val_2 != 1847422823) || ((System.String.op_Equality(a:  val_1, b:  "propellergoal")) == false))
            {
                goto label_120;
            }
            
            val_38 = 8;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_3:
            if(val_2 > 854174119)
            {
                goto label_17;
            }
            
            if(val_2 > 792993406)
            {
                goto label_18;
            }
            
            if(val_2 == 718953849)
            {
                goto label_19;
            }
            
            if((val_2 != 792993406) || ((System.String.op_Equality(a:  val_1, b:  "bluegoal")) == false))
            {
                goto label_120;
            }
            
            val_38 = 1;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_10:
            if(val_2 > (-1111925390))
            {
                goto label_23;
            }
            
            if(val_2 > (-1161807586))
            {
                goto label_24;
            }
            
            if(val_2 == (-1171108441))
            {
                goto label_25;
            }
            
            if((val_2 != (-1161807586)) || ((System.String.op_Equality(a:  val_1, b:  "pinkgoal")) == false))
            {
                goto label_120;
            }
            
            val_38 = 5;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_4:
            if(val_2 > 595662143)
            {
                goto label_29;
            }
            
            if(val_2 == 286722988)
            {
                goto label_30;
            }
            
            if((val_2 != 595662143) || ((System.String.op_Equality(a:  val_1, b:  "lightbulbgoal")) == false))
            {
                goto label_120;
            }
            
            val_38 = 36;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_11:
            if(val_2 > (-1854337311))
            {
                goto label_34;
            }
            
            if(val_2 == (-1925328762))
            {
                goto label_35;
            }
            
            if((val_2 != (-1854337311)) || ((System.String.op_Equality(a:  val_1, b:  "mailgoal")) == false))
            {
                goto label_120;
            }
            
            val_38 = 18;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_17:
            if(val_2 > 1291169204)
            {
                goto label_39;
            }
            
            if(val_2 == 1088844653)
            {
                goto label_40;
            }
            
            if((val_2 != 1291169204) || ((System.String.op_Equality(a:  val_1, b:  "orangegoal")) == false))
            {
                goto label_120;
            }
            
            val_38 = 3;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_23:
            if(val_2 > (-476362537))
            {
                goto label_44;
            }
            
            if(val_2 == (-553174875))
            {
                goto label_45;
            }
            
            if((val_2 != (-476362537)) || ((System.String.op_Equality(a:  val_1, b:  "coingoal")) == false))
            {
                goto label_120;
            }
            
            val_38 = 21;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_5:
            if(val_2 == 72423830)
            {
                goto label_49;
            }
            
            if((val_2 != 102389280) || ((System.String.op_Equality(a:  val_1, b:  "cookiegoal")) == false))
            {
                goto label_120;
            }
            
            val_38 = 39;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_12:
            if(val_2 == (-2091465274))
            {
                goto label_53;
            }
            
            if((val_2 != (-2020957316)) || ((System.String.op_Equality(a:  val_1, b:  "piggygoal")) == false))
            {
                goto label_120;
            }
            
            val_38 = 27;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_18:
            if(val_2 == 832492895)
            {
                goto label_57;
            }
            
            if((val_2 != 854174119) || ((System.String.op_Equality(a:  val_1, b:  "vasegoal")) == false))
            {
                goto label_120;
            }
            
            val_38 = 12;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_24:
            if(val_2 == (-1142963065))
            {
                goto label_61;
            }
            
            if((val_2 != (-1111925390)) || ((System.String.op_Equality(a:  val_1, b:  "tntgoal")) == false))
            {
                goto label_120;
            }
            
            val_38 = 9;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_29:
            if(val_2 == 655105613)
            {
                goto label_65;
            }
            
            if((val_2 != 698390418) || ((System.String.op_Equality(a:  val_1, b:  "flowerpotgoal")) == false))
            {
                goto label_120;
            }
            
            val_38 = 29;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_34:
            if(val_2 == (-1611108215))
            {
                goto label_69;
            }
            
            if(val_2 == (-1564618594))
            {
                goto label_70;
            }
            
            if((val_2 != (-1209072190)) || ((System.String.op_Equality(a:  val_1, b:  "yellowgoal")) == false))
            {
                goto label_120;
            }
            
            val_38 = 6;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_39:
            if(val_2 == 1406207400)
            {
                goto label_74;
            }
            
            if(val_2 == 1637589229)
            {
                goto label_75;
            }
            
            if((val_2 != 1746811083) || ((System.String.op_Equality(a:  val_1, b:  "safegoal")) == false))
            {
                goto label_120;
            }
            
            val_38 = 20;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_44:
            if(val_2 == (-433947444))
            {
                goto label_79;
            }
            
            if(val_2 == (-384499734))
            {
                goto label_80;
            }
            
            if((val_2 != (-40108128)) || ((System.String.op_Equality(a:  val_1, b:  "pumpkingoal")) == false))
            {
                goto label_120;
            }
            
            val_38 = 41;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_6:
            if((System.String.op_Equality(a:  val_1, b:  "metalcrushergoal")) == false)
            {
                goto label_120;
            }
            
            val_38 = 38;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_13:
            if((System.String.op_Equality(a:  val_1, b:  "rockgoal")) == false)
            {
                goto label_120;
            }
            
            val_38 = 34;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_19:
            if((System.String.op_Equality(a:  val_1, b:  "egggoal")) == false)
            {
                goto label_120;
            }
            
            val_38 = 16;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_25:
            if((System.String.op_Equality(a:  val_1, b:  "redgoal")) == false)
            {
                goto label_120;
            }
            
            val_38 = 4;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_30:
            if((System.String.op_Equality(a:  val_1, b:  "shelfgoal")) == false)
            {
                goto label_120;
            }
            
            val_38 = 32;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_35:
            if((System.String.op_Equality(a:  val_1, b:  "oystergoal")) == false)
            {
                goto label_120;
            }
            
            val_38 = 28;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_40:
            if((System.String.op_Equality(a:  val_1, b:  "birdgoal")) == false)
            {
                goto label_120;
            }
            
            val_38 = 23;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_45:
            if((System.String.op_Equality(a:  val_1, b:  "potiongoal")) == false)
            {
                goto label_120;
            }
            
            val_38 = 19;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_49:
            if((System.String.op_Equality(a:  val_1, b:  "owlgoal")) == false)
            {
                goto label_120;
            }
            
            val_38 = 17;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_53:
            if((System.String.op_Equality(a:  val_1, b:  "rocketgoal")) == false)
            {
                goto label_120;
            }
            
            val_38 = 7;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_57:
            if((System.String.op_Equality(a:  val_1, b:  "icecrushergoal")) == false)
            {
                goto label_120;
            }
            
            val_38 = 26;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_61:
            if((System.String.op_Equality(a:  val_1, b:  "greengoal")) == false)
            {
                goto label_120;
            }
            
            val_38 = 2;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_65:
            if((System.String.op_Equality(a:  val_1, b:  "lightballgoal")) == false)
            {
                goto label_120;
            }
            
            val_38 = 10;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_69:
            if((System.String.op_Equality(a:  val_1, b:  "chaingoal")) == false)
            {
                goto label_120;
            }
            
            val_38 = 42;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_70:
            if((System.String.op_Equality(a:  val_1, b:  "cupboardgoal")) == false)
            {
                goto label_120;
            }
            
            val_38 = 15;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_74:
            if((System.String.op_Equality(a:  val_1, b:  "froggoal")) == false)
            {
                goto label_120;
            }
            
            val_38 = 37;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_75:
            if((System.String.op_Equality(a:  val_1, b:  "boxgoal")) == false)
            {
                goto label_120;
            }
            
            val_38 = 11;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_79:
            if((System.String.op_Equality(a:  val_1, b:  "dynamiteboxgoal")) == false)
            {
                goto label_120;
            }
            
            val_38 = 31;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            label_80:
            if((System.String.op_Equality(a:  val_1, b:  "colorboxgoal")) != false)
            {
                    val_38 = 25;
                return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
            }
            
            label_120:
            val_38 = 0;
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)val_38;
        }
        public static Royal.Scenes.Game.Mechanics.Matches.MatchType GetColorForTiledId(Royal.Scenes.Game.Utils.LevelParser.TiledId tileId)
        {
            if(tileId <= 126)
            {
                    if((tileId - 71) >= 56)
            {
                    return 0;
            }
            
                return (Royal.Scenes.Game.Mechanics.Matches.MatchType)36626336 + ((tileId - 71)) << 2;
            }
            
            if(tileId <= 136)
            {
                    if(tileId == 127)
            {
                    return 2;
            }
            
                if(tileId != 136)
            {
                    return 0;
            }
            
                return 3;
            }
            
            if(tileId == 137)
            {
                    return 4;
            }
            
            if(tileId != 138)
            {
                    return 0;
            }
            
            return 5;
        }
        public static Royal.Scenes.Game.Mechanics.Boosters.BoosterType ToBoosterType(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId)
        {
            if(tiledId <= 20)
            {
                    tiledId = (tiledId == 10) ? 8 : ((tiledId == 20) ? 1 : 0);
                return (Royal.Scenes.Game.Mechanics.Boosters.BoosterType)tiledId;
            }
            
            if(tiledId == 30)
            {
                    return 1;
            }
            
            if(tiledId == 40)
            {
                    return 2;
            }
            
            if(tiledId != 50)
            {
                    return 0;
            }
            
            return 3;
        }
        public static bool IsOneOf(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId, Royal.Scenes.Game.Utils.LevelParser.TiledId firstTiledId, Royal.Scenes.Game.Utils.LevelParser.TiledId secondTiledId, Royal.Scenes.Game.Utils.LevelParser.TiledId thirdTiledId)
        {
            if(tiledId == firstTiledId)
            {
                    return true;
            }
            
            tiledId = ((tiledId == secondTiledId) ? 1 : 0) | ((tiledId == thirdTiledId) ? 1 : 0);
            return (bool)tiledId;
        }
    
    }

}
