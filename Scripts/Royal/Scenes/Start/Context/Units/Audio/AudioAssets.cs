using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.Audio
{
    public static class AudioAssets
    {
        // Fields
        private static Royal.Scenes.Game.Levels.Units.Sfx.GameSfxAssets <GameSfxAssets>k__BackingField;
        
        // Properties
        public static Royal.Scenes.Game.Levels.Units.Sfx.GameSfxAssets GameSfxAssets { get; set; }
        
        // Methods
        public static Royal.Scenes.Game.Levels.Units.Sfx.GameSfxAssets get_GameSfxAssets()
        {
            return (Royal.Scenes.Game.Levels.Units.Sfx.GameSfxAssets)Royal.Scenes.Start.Context.Units.Audio.AudioAssets.<GameSfxAssets>k__BackingField;
        }
        private static void set_GameSfxAssets(Royal.Scenes.Game.Levels.Units.Sfx.GameSfxAssets value)
        {
            Royal.Scenes.Start.Context.Units.Audio.AudioAssets.<GameSfxAssets>k__BackingField = value;
        }
        public static void LoadGameAssets()
        {
            Royal.Scenes.Start.Context.Units.Audio.AudioAssets.<GameSfxAssets>k__BackingField = UnityEngine.Resources.Load<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxAssets>(path:  "GameSfxAssets");
            Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory val_2 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            Royal.Scenes.Start.Context.Units.Audio.AudioAssets.<GameSfxAssets>k__BackingField = val_2.assetsLibrary;
        }
        private static string GetFilePath(Royal.Scenes.Start.Context.Units.Audio.AudioClipType type)
        {
            string val_9;
            string val_4 = System.Text.RegularExpressions.Regex.Replace(input:  System.Enum.GetName(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  type), pattern:  "([A-Z])", replacement:  "_$0", options:  8).ToLower();
            val_9 = val_4;
            if((val_4.StartsWith(value:  "_")) == false)
            {
                    return (string)UnityEngine.Application.persistentDataPath + "/Sounds/"("/Sounds/") + val_9 + ".wav";
            }
            
            val_9 = val_9.Substring(startIndex:  1);
            return (string)UnityEngine.Application.persistentDataPath + "/Sounds/"("/Sounds/") + val_9 + ".wav";
        }
        public static void ClearCache()
        {
        
        }
        public static UnityEngine.AudioClip GetAudioClip(Royal.Scenes.Start.Context.Units.Audio.AudioClipType type)
        {
            string val_7;
            if(type > 131)
            {
                goto label_1;
            }
            
            if(type > 76)
            {
                goto label_2;
            }
            
            if((type - 1) > 75)
            {
                    return Royal.Scenes.Start.Context.Units.Audio.AudioAssets.<GameSfxAssets>k__BackingField.GetClip(sfxType:  type);
            }
            
            var val_7 = 36531612 + ((type - 1)) << 2;
            val_7 = val_7 + 36531612;
            goto (36531612 + ((type - 1)) << 2 + 36531612);
            label_1:
            if(type > 254)
            {
                goto label_5;
            }
            
            if(type <= 190)
            {
                goto label_6;
            }
            
            if((type - 215) > 39)
            {
                goto label_7;
            }
            
            var val_8 = 36531396 + ((type - 215)) << 2;
            val_8 = val_8 + 36531396;
            goto (36531396 + ((type - 215)) << 2 + 36531396);
            label_2:
            if((type - 114) > 7)
            {
                goto label_9;
            }
            
            var val_9 = 36531580 + ((type - 114)) << 2;
            val_9 = val_9 + 36531580;
            goto (36531580 + ((type - 114)) << 2 + 36531580);
            label_5:
            if(type == 258)
            {
                goto label_11;
            }
            
            if(type == 263)
            {
                goto label_12;
            }
            
            if(type != 264)
            {
                    return Royal.Scenes.Start.Context.Units.Audio.AudioAssets.<GameSfxAssets>k__BackingField.GetClip(sfxType:  type);
            }
            
            val_7 = "Ui/well_done_star_hit";
            return (UnityEngine.AudioClip)UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  val_7 = "Ui/move_chest_appear");
            label_6:
            if((type - 142) > 25)
            {
                goto label_15;
            }
            
            var val_10 = 36531292 + ((type - 142)) << 2;
            val_10 = val_10 + 36531292;
            goto (36531292 + ((type - 142)) << 2 + 36531292);
            label_9:
            if((type - 90) > 5)
            {
                goto label_17;
            }
            
            var val_11 = 36531556 + ((type - 90)) << 2;
            val_11 = val_11 + 36531556;
            goto (36531556 + ((type - 90)) << 2 + 36531556);
            label_12:
            val_7 = "Ui/well_done_idle";
            return (UnityEngine.AudioClip)UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  val_7);
            label_11:
            val_7 = "Ui/tool_tip_open";
            return (UnityEngine.AudioClip)UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  val_7);
            label_17:
            if(type != 131)
            {
                    return Royal.Scenes.Start.Context.Units.Audio.AudioAssets.<GameSfxAssets>k__BackingField.GetClip(sfxType:  type);
            }
            
            val_7 = "Ui/goal_complete";
            return (UnityEngine.AudioClip)UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  val_7);
            label_15:
            if(type == 189)
            {
                goto label_31;
            }
            
            if(type != 190)
            {
                    return Royal.Scenes.Start.Context.Units.Audio.AudioAssets.<GameSfxAssets>k__BackingField.GetClip(sfxType:  type);
            }
            
            val_7 = "Ui/out_of_moves_enter";
            return (UnityEngine.AudioClip)UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  val_7);
            label_7:
            if(type != 191)
            {
                    return Royal.Scenes.Start.Context.Units.Audio.AudioAssets.<GameSfxAssets>k__BackingField.GetClip(sfxType:  type);
            }
            
            val_7 = "Ui/out_of_moves_exit";
            return (UnityEngine.AudioClip)UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  val_7);
            label_31:
            return (UnityEngine.AudioClip)UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  val_7);
        }
    
    }

}
