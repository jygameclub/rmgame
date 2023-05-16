using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.View
{
    public class TutorialCellMaskView : MonoBehaviour
    {
        // Fields
        public UnityEngine.SpriteRenderer center;
        public UnityEngine.SpriteRenderer topLeftPatch;
        public UnityEngine.SpriteRenderer topRightPatch;
        public UnityEngine.SpriteRenderer bottomPatch;
        public UnityEngine.Sprite cornerPatch;
        public UnityEngine.Sprite straightPatch;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[] allPoints;
        
        // Methods
        public void ArrangeMaskPatches(UnityEngine.Vector3 position, Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint cellPoint, Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint[] points)
        {
            this.transform.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
            UnityEngine.Vector3 val_3 = this.transform.localPosition;
            UnityEngine.Transform val_4 = this.transform;
            val_4.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = 0f};
            this.point = cellPoint;
            this.allPoints = points;
            val_4.ArrangeSorting(spriteMask:  0);
            this.ArrangeTopLeftPatch();
            this.ArrangeTopRightPatch();
            this.ArrangeBottomPatch();
        }
        private void ArrangeTopLeftPatch()
        {
            UnityEngine.Sprite val_11;
            var val_12;
            bool val_2 = this.HasNeighbor(neighborType:  1);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            val_11 = 0;
            if((this.HasNeighbor(neighborType:  7)) != true)
            {
                    if((val_2 & (this.HasNeighbor(neighborType:  0))) != false)
            {
                    val_11 = this.cornerPatch;
                val_12 = 1f;
            }
            else
            {
                    if(val_2 != false)
            {
                    val_11 = this.straightPatch;
                val_12 = 0f;
            }
            else
            {
                    val_11 = 0;
            }
            
            }
            
            }
            
            this.topLeftPatch.sprite = val_11;
            this.topLeftPatch.transform.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            this.topLeftPatch.transform.localRotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
            UnityEngine.Transform val_10 = this.topLeftPatch.transform;
            val_10.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            val_10.ArrangeSorting(spriteMask:  0);
        }
        private void ArrangeTopRightPatch()
        {
            UnityEngine.Sprite val_12;
            bool val_1 = this.HasNeighbor(neighborType:  3);
            bool val_2 = this.HasNeighbor(neighborType:  1);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            bool val_7 = val_1 & val_2;
            if((this.HasNeighbor(neighborType:  2)) == false)
            {
                goto label_5;
            }
            
            if(val_7 == false)
            {
                goto label_6;
            }
            
            val_12 = this.straightPatch;
            goto label_11;
            label_5:
            if(val_7 == false)
            {
                goto label_8;
            }
            
            val_12 = this.cornerPatch;
            goto label_9;
            label_6:
            if(val_2 == false)
            {
                goto label_10;
            }
            
            val_12 = this.cornerPatch;
            goto label_11;
            label_8:
            if(val_2 == false)
            {
                goto label_12;
            }
            
            val_12 = this.straightPatch;
            label_11:
            label_9:
            label_21:
            label_26:
            this.topRightPatch.sprite = val_12;
            this.topRightPatch.transform.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            this.topRightPatch.transform.localRotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
            UnityEngine.Transform val_10 = this.topRightPatch.transform;
            val_10.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            val_10.ArrangeSorting(spriteMask:  0);
            return;
            label_10:
            if(val_1 == false)
            {
                goto label_26;
            }
            
            goto label_21;
            label_12:
            if(val_1 == false)
            {
                goto label_26;
            }
            
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  90f);
            goto label_26;
        }
        private void ArrangeBottomPatch()
        {
            float val_13;
            float val_14;
            float val_15;
            float val_16;
            UnityEngine.Sprite val_20;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.identity;
            val_13 = val_6.x;
            val_14 = val_6.y;
            val_15 = val_6.z;
            val_16 = val_6.w;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            if(((((this.HasNeighbor(neighborType:  5)) != true) && ((this.HasNeighbor(neighborType:  6)) != true)) && ((this.HasNeighbor(neighborType:  4)) != true)) && ((this.HasNeighbor(neighborType:  7)) != false))
            {
                    val_20 = this.straightPatch;
                UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  90f);
                val_13 = val_8.x;
                val_14 = val_8.y;
                val_15 = val_8.z;
                val_16 = val_8.w;
            }
            else
            {
                    val_20 = 0;
            }
            
            this.bottomPatch.sprite = val_20;
            this.bottomPatch.transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            this.bottomPatch.transform.localRotation = new UnityEngine.Quaternion() {x = val_13, y = val_14, z = val_15, w = val_16};
            UnityEngine.Transform val_11 = this.bottomPatch.transform;
            val_11.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            val_11.ArrangeSorting(spriteMask:  0);
        }
        private bool HasNeighbor(int neighborType)
        {
            var val_1;
            var val_2;
            val_1 = 0;
            var val_1 = 32;
            label_4:
            if(val_1 >= (this.allPoints.Length << ))
            {
                goto label_1;
            }
            
            if((this.allPoints[val_1] & 1) != 0)
            {
                goto label_3;
            }
            
            val_1 = val_1 + 1;
            val_1 = val_1 + 8;
            if(this.allPoints != null)
            {
                goto label_4;
            }
            
            throw new NullReferenceException();
            label_1:
            val_2 = 0;
            return (bool)val_2;
            label_3:
            val_2 = 1;
            return (bool)val_2;
        }
        private void ArrangeSorting(UnityEngine.SpriteRenderer spriteMask)
        {
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTutorialBlackSorting();
            val_1.sortEverything = val_1.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_1.sortEverything}, offset:  0);
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTutorialBlackSorting();
            val_3.sortEverything = val_3.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything}, offset:  1);
        }
        public TutorialCellMaskView()
        {
        
        }
    
    }

}
