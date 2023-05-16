using UnityEngine;

namespace Royal.Player.Context.Units
{
    public class LevelEpisodeHelper
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<int, Royal.Levels.Config.LevelEpisodeConfig> levelEpisodeConfigs;
        private const short MoveCountChangeAmount = 3;
        private const short EpisodeLevelCount = 50;
        private const short SectionLevelCount = 5;
        private const short MaxLevelForUpdateSkill = 100;
        private const short MaxLevelForBeginnerEgo = 10;
        private int[] maxTryCountsForSections;
        
        // Properties
        private bool NotApplicableForSkill { get; }
        
        // Methods
        private bool get_NotApplicableForSkill()
        {
            var val_2 = 1;
            return (bool);
        }
        public LevelEpisodeHelper()
        {
            this.levelEpisodeConfigs = Royal.Levels.Config.LevelEpisodeConfig.CreateDefaultConfigs();
            this.CreateLevelSectionMaxTryCounts();
        }
        private void CreateLevelSectionMaxTryCounts()
        {
            this.maxTryCountsForSections = new int[20] {5, 5, 6, 8, 9, 12, 9, 12, 10, 14, 12, 13, 10, 12, 13, 15, 12, 16, 11, 14};
        }
        public void IncrementTryCount()
        {
            if(this.NotApplicableForSkill == true)
            {
                    return;
            }
            
            UpdateTryCount(amount:  GetTryCount() + 1);
        }
        public void SetEpisodeId(int levelNo)
        {
            int val_4;
            var val_5;
            int val_12;
            if(this.NotApplicableForSkill == true)
            {
                    return;
            }
            
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = this.levelEpisodeConfigs.Keys.GetEnumerator();
            label_7:
            if(((-1922841632) & 1) == 0)
            {
                goto label_4;
            }
            
            if(this.levelEpisodeConfigs == null)
            {
                    throw new NullReferenceException();
            }
            
            Royal.Levels.Config.LevelEpisodeConfig val_6 = this.levelEpisodeConfigs.Item[val_4];
            if(val_6.levelEnd < levelNo)
            {
                goto label_7;
            }
            
            val_12 = val_6.id;
            if((val_6.id >> 32) > levelNo)
            {
                goto label_7;
            }
            
            val_5.Dispose();
            if(val_12 != 0)
            {
                goto label_8;
            }
            
            goto label_20;
            label_4:
            val_5.Dispose();
            label_20:
            Royal.Levels.Config.LevelEpisodeConfig val_9 = System.Linq.Enumerable.Last<Royal.Levels.Config.LevelEpisodeConfig>(source:  this.levelEpisodeConfigs.Values);
            double val_11 = 50;
            int val_10 = levelNo - val_9.levelEnd;
            val_11 = (double)val_10 / val_11;
            val_12 = val_10 + val_9.id;
            label_8:
            Royal.Player.Context.Data.Session.__il2cppRuntimeField_38 = val_12;
        }
        private Royal.Levels.Config.LevelEpisodeConfig GetCurrentEpisodeConfig()
        {
            int val_8;
            var val_9;
            if((this.levelEpisodeConfigs.ContainsKey(key:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_38)) != false)
            {
                    val_8 = Royal.Player.Context.Data.Session.__il2cppRuntimeField_38;
                Royal.Levels.Config.LevelEpisodeConfig val_2 = this.levelEpisodeConfigs.Item[val_8];
                val_9 = val_2.id;
                return new Royal.Levels.Config.LevelEpisodeConfig() {id = Royal.Player.Context.Data.Session.__il2cppRuntimeField_38, levelStart = (((Royal.Player.Context.Data.Session.__il2cppRuntimeField_38 + ~(val_4.id)) * 50) + val_4.levelEnd + 1), levelEnd = (((Royal.Player.Context.Data.Session.__il2cppRuntimeField_38 + ~(val_4.id)) * 50) + val_4.levelEnd + 50)};
            }
            
            Royal.Levels.Config.LevelEpisodeConfig val_4 = System.Linq.Enumerable.Last<Royal.Levels.Config.LevelEpisodeConfig>(source:  this.levelEpisodeConfigs.Values);
            return new Royal.Levels.Config.LevelEpisodeConfig() {id = Royal.Player.Context.Data.Session.__il2cppRuntimeField_38, levelStart = (((Royal.Player.Context.Data.Session.__il2cppRuntimeField_38 + ~(val_4.id)) * 50) + val_4.levelEnd + 1), levelEnd = (((Royal.Player.Context.Data.Session.__il2cppRuntimeField_38 + ~(val_4.id)) * 50) + val_4.levelEnd + 50)};
        }
        public void UpdateUserSkill()
        {
            bool val_1 = IsDynamicDifficultyEnabled();
            if(val_1 == false)
            {
                    return;
            }
            
            if(val_1.NotApplicableForSkill == true)
            {
                    return;
            }
            
            var val_5 = ((Royal.Player.Context.Data.Session.__il2cppRuntimeField_14 * 1717986919)) >> 33;
            val_5 = val_5 + (((Royal.Player.Context.Data.Session.__il2cppRuntimeField_14 * 1717986919)) >> 63);
            val_5 = val_5 + (val_5 << 2);
            UpdateSkill(skill:  this.CalculateNewSkill(levelNo:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_14>>0&0xFFFFFFFF));
            ResetTryCount();
        }
        public void UpdateUserSkillAndMoveCount()
        {
            if(IsDynamicDifficultyEnabled() == false)
            {
                    return;
            }
            
            if(GetSkill() == 1)
            {
                    return;
            }
            
            UpdateSkill(skill:  1);
            Royal.Player.Context.Data.Session.__il2cppRuntimeField_20 = (Royal.Player.Context.Data.Session.__il2cppRuntimeField_20 + 3);
        }
        public int CalculateMoveCountWithSkill(int moveCount)
        {
            var val_8;
            var val_9;
            val_8 = moveCount;
            Royal.Player.Context.Units.LeagueLevel val_2 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeagueManager>(id:  5).GetLeagueLevel(levelIndex:  125198928);
            val_8 = (val_2.level >> 32) + val_8;
            val_9 = val_8;
            return (int)val_9;
        }
        private Royal.Player.Context.Units.UserSkill CalculateNewSkill(int levelNo)
        {
            int val_1 = GetTryCount();
            if(val_1 == 0)
            {
                    return (Royal.Player.Context.Units.UserSkill)(val_1 <= (this.maxTryCountsForSections[-1])) ? (1 + 1) : 1;
            }
            
            if(GetSkill() == 1)
            {
                    return (Royal.Player.Context.Units.UserSkill)(val_1 <= (this.maxTryCountsForSections[-1])) ? (1 + 1) : 1;
            }
            
            return (Royal.Player.Context.Units.UserSkill)(val_1 <= (this.maxTryCountsForSections[-1])) ? (1 + 1) : 1;
        }
    
    }

}
