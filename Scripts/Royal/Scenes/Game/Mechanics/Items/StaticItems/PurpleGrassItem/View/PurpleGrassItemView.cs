using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View
{
    public class PurpleGrassItemView : StaticItemView
    {
        // Fields
        public UnityEngine.Transform viewParent;
        public UnityEngine.SpriteRenderer baseView;
        public UnityEngine.SpriteRenderer topPatch;
        public UnityEngine.SpriteRenderer rightPatch;
        public UnityEngine.SpriteRenderer shadow;
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemAssets itemAssets;
        private Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors neighbors;
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.PurpleGrassItemModel itemModel;
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassViewData viewData;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.PurpleGrassItemModel item, UnityEngine.Vector3 position, Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassViewData viewData)
        {
            this.itemModel = item;
            this.itemAssets = 185636.Load<Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemAssets>();
            this.InitTransform(type:  0, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.neighbors = public System.Void System.Func<System.Threading.SemaphoreSlim>::.ctor(object object, IntPtr method);
            this.UpdateView(layer:  -1764300912, grassViewData:  new Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassViewData() {baseData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}, patchData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}, shadowData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}});
        }
        public override void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            sortingData.sortEverything = sortingData.sortEverything & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.baseView, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = sortingData.sortEverything});
        }
        public void UpdateView(int layer, Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassViewData grassViewData)
        {
            this.baseView.sprite = grassViewData.baseData.sprite;
            this.shadow.sprite = grassViewData.shadowData.sprite;
            this.shadow.color = new UnityEngine.Color() {r = grassViewData.shadowData.color.r, g = grassViewData.shadowData.color.g, b = grassViewData.shadowData.color.b, a = grassViewData.shadowData.color.a};
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.shadow, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = grassViewData.shadowData.sorting.layer, order = grassViewData.shadowData.sorting.layer, sortEverything = grassViewData.shadowData.sorting.sortEverything});
            this.shadow.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  1.12f);
            this.shadow.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            this.UpdatePatches();
            this.UpdateNeighbors();
        }
        public void UpdatePatches()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.neighbors.Get(type:  3);
            if(val_1 != null)
            {
                    Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemView.ArrangePatch(neighbor:  val_1, patchRenderer:  this.rightPatch, itemAssets:  this.itemAssets, layer:  W20);
            }
            else
            {
                    this.rightPatch.enabled = false;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.neighbors.Get(type:  1);
            if(val_2 != null)
            {
                    Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemView.ArrangePatch(neighbor:  val_2, patchRenderer:  this.topPatch, itemAssets:  this.itemAssets, layer:  W20);
                return;
            }
            
            this.topPatch.enabled = false;
        }
        public static void ArrangePatch(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel neighbor, UnityEngine.SpriteRenderer patchRenderer, Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemAssets itemAssets, int layer)
        {
            Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel val_1 = 28419.GetStaticItem(itemType:  0);
            if(null >= 1)
            {
                    int val_2 = UnityEngine.Mathf.Min(a:  layer, b:  1);
                patchRenderer.enabled = true;
                patchRenderer.sprite = itemAssets.GetPatch(layer:  val_2);
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetGrassPatchSorting(layer:  val_2);
                Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  patchRenderer, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_4.sortEverything & 4294967295});
                return;
            }
            
            patchRenderer.enabled = false;
        }
        public void Explode()
        {
            this.SpawnParticle(particleLayer:  0);
            this.UpdateNeighbors();
            this.RecycleSelf();
        }
        public void Damage(int damagedLayer)
        {
            this.UpdateView(layer:  this.viewData, grassViewData:  new Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassViewData() {baseData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}, patchData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}, shadowData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}});
            this.SpawnParticle(particleLayer:  this.viewData);
            this.UpdateNeighbors();
        }
        private void UpdateNeighbors()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.neighbors.Get(type:  7);
            if(val_1 != null)
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel val_2 = val_1.GetStaticItem(itemType:  0);
                if(val_2 != null)
            {
                    val_2.UpdatePatches();
            }
            
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = this.neighbors.Get(type:  5);
            if(val_3 == null)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel val_4 = val_3.GetStaticItem(itemType:  0);
            if(val_4 == null)
            {
                    return;
            }
            
            var val_5 = (((Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.PurpleGrassItemModel.__il2cppRuntimeField_ + -8) == null) ? (val_4) : 0;
        }
        private void SpawnParticle(int particleLayer)
        {
            PlaySfx(type:  ((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5).Next(min:  0, max:  2)) != 0) ? (132 + 1) : 132, offset:  0.04f);
            Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemExplodeParticles val_4 = Spawn<Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemExplodeParticles>(poolId:  88, activate:  true);
            val_4.Play(particleLayer:  88);
            UnityEngine.Vector3 val_7 = this.transform.position;
            val_4.transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        }
        public override int GetPoolId()
        {
            return 87;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
            this.neighbors = 0;
            this.rightPatch.enabled = false;
            this.topPatch.enabled = false;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemView).__il2cppRuntimeField_200;
        }
        public override void Hide()
        {
            if(W8 != 0)
            {
                    return;
            }
            
            this.viewParent.gameObject.SetActive(value:  false);
            mem[1152921520024097328] = 1;
        }
        public override void Show()
        {
            if(W8 == 0)
            {
                    return;
            }
            
            this.viewParent.gameObject.SetActive(value:  true);
            mem[1152921520024225712] = 0;
        }
        public PurpleGrassItemView()
        {
        
        }
    
    }

}
