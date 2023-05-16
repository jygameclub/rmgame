using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Episodes
{
    public class EpisodeRowData : IUiScrollContentData
    {
        // Fields
        public readonly int areaId;
        public readonly string areaName;
        public readonly Royal.Scenes.Home.Ui.Sections.Episodes.EpisodeState episodeState;
        public readonly float fontSizeMax;
        public readonly float curveScale;
        
        // Methods
        public EpisodeRowData(Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig config, Royal.Scenes.Home.Ui.Sections.Episodes.EpisodeState episodeState)
        {
            this.areaId = config.areaId;
            this.areaName = config.areaName;
            this.fontSizeMax = config.fontSizeMax;
            this.episodeState = episodeState;
            this.curveScale = config.curveScale;
        }
        public EpisodeRowData(Royal.Scenes.Home.Ui.Sections.Episodes.EpisodeState state)
        {
            this.areaId = (state == 4) ? (32766 + 1) : 32766;
            this.areaName = (state == 4) ? "RoyalLeague" : "ComingSoon";
            this.episodeState = state;
        }
    
    }

}
