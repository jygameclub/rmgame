using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Sortings
{
    public static class Sorting
    {
        // Fields
        public static readonly int BackgroundLayerId;
        public static readonly int CellLayerId;
        public static readonly int ItemLayerId;
        public static readonly int ParticlesLayerId;
        public static readonly int FrontLayerId;
        public static readonly int UiLayerId;
        public static readonly int DialogLayerId;
        public static readonly int DefaultLayerId;
        public static readonly int LoadingLayerId;
        public const int DefaultItemSorting = 1000;
        private const int ReverseSortingStart = 1100;
        public const int ReverseSortingOffset = 100;
        private const int MaxRowCount = 10;
        private const int MaxReverseSorting = 2100;
        private const int MatchItemCollectSorting = 6100;
        private const int RocketItemAnimationSorting = 3200;
        private const int CurtainSorting = 2200;
        private const int CurtainTokenSorting = 2350;
        private const int HoneySorting = 1200;
        private const int SoilSorting = 1100;
        private const int ChainSortingStart = 1190;
        private const int CrossSortingUnderHoney = 1150;
        private const int CrossSorting = 2100;
        private const int GrassSortingStart = 150;
        private const int DrillSortingStart = 1990;
        
        // Methods
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetBackgroundSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DrillSortingStart, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DrillSortingStart, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetDefaultBoosterUseSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DrillSortingStart | 429496729600, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DrillSortingStart | 429496729600, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetCellSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.CellLayerId | 42949672960, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.CellLayerId | 42949672960, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetSwapParticleSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | (-4294967296), order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | (-4294967296), sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetItemSorting(int row = 0, bool isReverseSort = False)
        {
            var val_3;
            int val_4 = row;
            var val_3 = 99;
            val_3 = val_4 * val_3;
            val_4 = val_3 + 2100;
            val_3 = null;
            val_3 = null;
            val_3 = val_4 << 32;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = ((isReverseSort != true) ? (val_3) : 0) | Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, order = ((isReverseSort != true) ? (val_3) : 0) | Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetCrossSorting(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel item)
        {
            var val_8;
            var val_9;
            if(item.itemMediator.HasCurrentCell() != false)
            {
                    if(item.CurrentCell.HasTouchBlockingItem() == true)
            {
                goto label_6;
            }
            
            }
            
            if((item.itemMediator.HasNextCell() != false) && (item.itemMediator.NextCell.HasTouchBlockingItem() != false))
            {
                    label_6:
                val_8 = 1152921505085652992;
                val_9 = 4939212390400;
                return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = 9019431321600 | Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, order = 9019431321600 | Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, sortEverything = true};
            }
            
            val_8 = 1152921505085652992;
            val_9 = 9019431321600;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = 9019431321600 | Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, order = 9019431321600 | Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, sortEverything = true};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetHintParticleSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 9040906158080, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 9040906158080, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetHintSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 9062380994560, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 9062380994560, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetImpactSorting(int diff)
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, order = diff + 2110, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetSwapStartSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 13335873454080, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 13335873454080, sortEverything = true};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetIceCrusherExplodeSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 9062380994560, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 9062380994560, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetRocketAnimationSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 13743895347200, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 13743895347200, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetRocketUseSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ParticlesLayerId | (-4294967296), order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ParticlesLayerId | (-4294967296), sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetTntAnimationSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 13743895347200, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 13743895347200, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetCurtainSorting(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point)
        {
            null = null;
            int val_1 = 0 + (point.x * 42949672961);
            val_1 = val_1 & (-4294967296);
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1 | Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, order = val_1 | Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetCurtainTokenSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 10093173145600, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 10093173145600, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetChainSorting(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point)
        {
            null = null;
            int val_1 = point.x >> 32;
            val_1 = point.x + (val_1 * 10);
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = (5111011082240 + ((((point.x >> 32) * 10) + point.x) << 32)) | Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, order = (5111011082240 + ((((point.x >> 32) * 10) + point.x) << 32)) | Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetHoneySorting(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point)
        {
            null = null;
            int val_1 = point.x >> 32;
            val_1 = point.x + (val_1 * 10);
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = (5153960755200 + ((((point.x >> 32) * 10) + point.x) << 32)) | Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, order = (5153960755200 + ((((point.x >> 32) * 10) + point.x) << 32)) | Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetSoilSorting(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point)
        {
            null = null;
            int val_1 = point.x >> 32;
            val_1 = point.x + (val_1 * 10);
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = (4724464025600 + ((((point.x >> 32) * 10) + point.x) << 32)) | Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, order = (4724464025600 + ((((point.x >> 32) * 10) + point.x) << 32)) | Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetHoneySortingForCorner(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            null = null;
            var val_2 = 64424509440;
            val_2 = sortingData.layer + val_2;
            val_2 = val_2 & (-4294967296);
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2 | Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, order = val_2 | Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetHoneySortingForExplosion()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 6442450944000, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 6442450944000, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetLightballCreationSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 9448928051200, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 9448928051200, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetLightballUseSorting(int offset = 0)
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, order = offset + 5110, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetLightballRayItemSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 21904333209600, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 21904333209600, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetLightballItemBgSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 4720169058304, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 4720169058304, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetGrassSorting(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point, int layer)
        {
            null = null;
            int val_2 = point.x + (layer * 150);
            val_2 = val_2 + ((point.x >> 32) * 10);
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, order = val_2, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetGrassPatchSorting(int layer)
        {
            null = null;
            int val_1 = layer * 150;
            val_1 = val_1 - 10;
            val_1 = val_1 >> 1;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetGrassShadowSorting(int layer)
        {
            null = null;
            int val_1 = layer * 150;
            val_1 = val_1 - 20;
            val_1 = val_1 >> 1;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetGrassParticleSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ParticlesLayerId | 429496729600, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ParticlesLayerId | 429496729600, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetSpecialItemCreationSorting(int negativeOffset = 0)
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, order = 3100 - negativeOffset, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetBoosterSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId | 9019431321600, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId | 9019431321600, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetMatchItemOverlaySorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 13314398617600, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 13314398617600, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetMatchItemOverlaySortingUnderChain()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 4337916968960, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 4337916968960, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetMatchItemCollectSorting(int offset)
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, order = offset + 6100, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetMatchItemCollectShadowSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 25769803776000, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 25769803776000, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetHatParticleSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 9040906158080, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 9040906158080, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetMailCollectSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId | 9448928051200, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId | 9448928051200, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetMailCollectShadowSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId | 9405978378240, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId | 9405978378240, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetBirdCollectSorting(int offset, bool aboveUi)
        {
            var val_2;
            var val_3;
            int val_4;
            var val_5;
            val_2 = null;
            if(aboveUi != false)
            {
                    val_3 = null;
                val_4 = 1152921505085657108;
                return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4, order = offset + 6200, sortEverything = false};
            }
            
            val_5 = null;
            val_4 = 1152921505085657096;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4, order = offset + 6200, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetPearlCollectSorting(int offset)
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId, order = offset + 6200, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetPropellerFlyingSorting(bool isSpecialCombo)
        {
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetPropellerScaleDownSorting(isSpecialCombo:  isSpecialCombo, offset:  Royal.Scenes.Game.Levels.Units.Explode.ExplodeTargetFinder.GetNextSortingOffset());
            val_3.sortEverything = val_3.sortEverything & 4294967295;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetPropellerScaleDownSorting(bool isSpecialCombo, int offset = 0)
        {
            null = null;
            int val_1 = (isSpecialCombo != true) ? 150 : 100;
            val_1 = val_1 + offset;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId, order = val_1, sortEverything = true};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetMadnessAnimationSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId | 47244640256000, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId | 47244640256000, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetBirdNestBirdShadowSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 9448928051200, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 9448928051200, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetDrillSorting(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point)
        {
            null = null;
            int val_1 = point.x >> 32;
            val_1 = point.x + (val_1 * 10);
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = (8546984919040 + ((((point.x >> 32) * 10) + point.x) << 32)) | Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, order = (8546984919040 + ((((point.x >> 32) * 10) + point.x) << 32)) | Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetGeneratorParticleSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 9040906158080, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId | 9040906158080, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetTntFuseParticlesSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ParticlesLayerId, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ParticlesLayerId, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetCannonBoosterUseSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ParticlesLayerId, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ParticlesLayerId, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetDrillAnimationSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ParticlesLayerId | 42520176230400, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ParticlesLayerId | 42520176230400, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetCannonBoosterBallSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ParticlesLayerId | 42949672960000, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ParticlesLayerId | 42949672960000, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetJesterHatBoosterUseSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.FrontLayerId, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.FrontLayerId, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetJesterHatAnimationSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.FrontLayerId, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.FrontLayerId, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetBushExplode()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.FrontLayerId | 429496729600, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.FrontLayerId | 429496729600, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetHammerBoosterUseSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.FrontLayerId | 472446402560, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.FrontLayerId | 472446402560, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetHammerBoosterUseSortingOverUi()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DialogLayerId | 42949672960, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DialogLayerId | 42949672960, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetArrowBoosterUseSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.FrontLayerId | 472446402560, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.FrontLayerId | 472446402560, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetBallBallComboBackgroundSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.FrontLayerId, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.FrontLayerId, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetBallBallComboSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.FrontLayerId | 429496729600, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.FrontLayerId | 429496729600, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetMatchItemCollectUiSorting(int order)
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId, order = order + 2000, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetShopUiSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId | 4294967296000, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId | 4294967296000, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetLadderOfferUiSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId | 9019431321600, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId | 9019431321600, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetUiSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetUiBoosterTextSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId | 4724464025600, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId | 4724464025600, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetTntTntExplodeSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId | 34359738368000, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId | 34359738368000, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetTutorialBlackSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId | 34359738368000, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId | 34359738368000, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetTutorialBlackSortingOverDialog()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DialogLayerId | 34359738368000, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DialogLayerId | 34359738368000, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetHomeCoinCollectSorting(int index)
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId, order = index + 2600, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetRewardedItemSorting(int count)
        {
            null = null;
            var val_1 = 9;
            val_1 = count * val_1;
            val_1 = val_1 + 2500;
            val_1 = val_1 >> 1;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetRewardedItemShadowSorting(int count)
        {
            null = null;
            int val_1 = 9;
            val_1 = count * val_1;
            val_1 = val_1 + 2499;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId, order = val_1, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetShopRewardedItemSorting(int count)
        {
            null = null;
            int val_1 = count * 10;
            val_1 = val_1 + 2500;
            val_1 = val_1 >> 1;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetShopRewardedItemShadowSorting(int count)
        {
            null = null;
            int val_1 = count * 10;
            val_1 = val_1 + 2499;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId, order = val_1, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetShopRewardedItemTextSorting(int count)
        {
            null = null;
            int val_1 = count * 10;
            val_1 = val_1 + 2501;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId, order = val_1, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetTutorialArrowSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DialogLayerId | 38654705664000, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DialogLayerId | 38654705664000, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetDialogBackgroundSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DialogLayerId, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DialogLayerId, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetDialogSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DialogLayerId | 4294967296, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DialogLayerId | 4294967296, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetDialogScrollContentSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DialogLayerId | 12884901888, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DialogLayerId | 12884901888, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetDialogScrollContentSortingOnSwap()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DialogLayerId | 42949672960, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DialogLayerId | 42949672960, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetGameSceneRewardCoinCollectSorting(int index)
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DialogLayerId, order = index + 1000, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetSortingWithOffset(Royal.Scenes.Game.Mechanics.Sortings.SortingData data, int offset)
        {
            int val_1 = data.layer >> 32;
            val_1 = val_1 + offset;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = data.layer, order = val_1, sortEverything = (data.sortEverything != true) ? 1 : 0};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetHomeWinStarSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId | 8589934592000, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId | 8589934592000, sortEverything = false};
        }
        public static Royal.Scenes.Game.Mechanics.Sortings.SortingData GetGameWinStarSorting()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DialogLayerId | 8589934592000, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DialogLayerId | 8589934592000, sortEverything = false};
        }
        private static Sorting()
        {
            Royal.Scenes.Game.Mechanics.Sortings.Sorting.DrillSortingStart = UnityEngine.SortingLayer.NameToID(name:  "Background");
            Royal.Scenes.Game.Mechanics.Sortings.Sorting.CellLayerId = UnityEngine.SortingLayer.NameToID(name:  "Cell");
            Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId = UnityEngine.SortingLayer.NameToID(name:  "Item");
            Royal.Scenes.Game.Mechanics.Sortings.Sorting.ParticlesLayerId = UnityEngine.SortingLayer.NameToID(name:  "Particles");
            Royal.Scenes.Game.Mechanics.Sortings.Sorting.FrontLayerId = UnityEngine.SortingLayer.NameToID(name:  "Front");
            Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId = UnityEngine.SortingLayer.NameToID(name:  "Ui");
            Royal.Scenes.Game.Mechanics.Sortings.Sorting.DialogLayerId = UnityEngine.SortingLayer.NameToID(name:  "Dialog");
            Royal.Scenes.Game.Mechanics.Sortings.Sorting.DefaultLayerId = UnityEngine.SortingLayer.NameToID(name:  "Default");
            Royal.Scenes.Game.Mechanics.Sortings.Sorting.LoadingLayerId = UnityEngine.SortingLayer.NameToID(name:  "Loading");
        }
    
    }

}
