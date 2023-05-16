using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Cell.View
{
    public class HintParticles : MonoBehaviour, IPoolable
    {
        // Fields
        public static readonly int[] Neighbors;
        public UnityEngine.ParticleSystem[] sides;
        private int sideData;
        
        // Methods
        public void Prepare(int sideData)
        {
            this.sideData = sideData;
            this.Hide();
        }
        public void Show()
        {
            var val_20;
            bool val_21;
            var val_22;
            int val_23;
            val_20 = null;
            val_20 = null;
            this.sides[0].gameObject.SetActive(value:  (((Royal.Scenes.Game.Mechanics.Board.Cell.View.HintParticles.Neighbors + 32) & this.sideData) != 0) ? 1 : 0);
            this.sides[1].gameObject.SetActive(value:  (((Royal.Scenes.Game.Mechanics.Board.Cell.View.HintParticles.Neighbors + 36) & this.sideData) != 0) ? 1 : 0);
            this.sides[2].gameObject.SetActive(value:  (((Royal.Scenes.Game.Mechanics.Board.Cell.View.HintParticles.Neighbors + 40) & this.sideData) != 0) ? 1 : 0);
            this.sides[3].gameObject.SetActive(value:  (((Royal.Scenes.Game.Mechanics.Board.Cell.View.HintParticles.Neighbors + 44) & this.sideData) != 0) ? 1 : 0);
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_9 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetHintParticleSorting();
            val_21 = val_9.sortEverything;
            int val_11 = (val_9.layer >> 32) + 1;
            var val_27 = 0;
            do
            {
                val_22 = null;
                val_23 = this.sideData;
                val_22 = null;
                if((Royal.Scenes.Game.Mechanics.Board.Cell.View.HintParticles.Neighbors + 32) == val_23)
            {
                    UnityEngine.ParticleSystem val_24 = this.sides[val_27];
                val_24.Play();
                Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  val_24.GetComponent<UnityEngine.Renderer>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_9.layer, order = val_9.order, sortEverything = (X26 & (-4294967296)) | (val_21 & 4294967295)});
                int val_25 = val_16.Length;
                if(val_25 >= 1)
            {
                    var val_26 = 0;
                val_25 = val_25 & 4294967295;
                do
            {
                if(1152921506482711552 != val_24)
            {
                    val_21 = (val_21 & (-4294967296)) | 0;
                Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  1152921506482711552.GetComponent<UnityEngine.Renderer>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = val_21});
            }
            
                val_26 = val_26 + 1;
            }
            while(val_26 < (val_16.Length << ));
            
            }
            
            }
            
                val_27 = val_27 + 1;
            }
            while(val_27 < 3);
        
        }
        public void Hide()
        {
            var val_2 = 0;
            do
            {
                if(val_2 >= this.sides.Length)
            {
                    return;
            }
            
                this.sides[val_2].Stop();
                val_2 = val_2 + 1;
            }
            while(this.sides != null);
            
            throw new NullReferenceException();
        }
        public int GetPoolId()
        {
            return 39;
        }
        public void OnSpawn()
        {
        
        }
        public void OnRecycle()
        {
            this.sideData = 0;
            this.Hide();
        }
        public HintParticles()
        {
        
        }
        private static HintParticles()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.View.HintParticles.Neighbors = 18847;
        }
    
    }

}
