using UnityEngine;

namespace Royal.Scenes.Game.Utils
{
    public class VisitMatrix
    {
        // Fields
        private readonly byte[,] visited;
        private readonly int width;
        private readonly int height;
        
        // Methods
        public VisitMatrix(int width, int height)
        {
            this.visited = null;
            this.width = width;
            this.height = height;
        }
        public void Reset()
        {
            int val_1;
            val_1 = this.width;
            if(val_1 < 1)
            {
                    return;
            }
            
            var val_5 = 0;
            do
            {
                if(this.height >= 1)
            {
                    var val_4 = 32;
                do
            {
                System.Byte[,] val_3 = this.visited;
                var val_1 = val_4 - 32;
                val_3 = val_3 + (val_5 * (X11 + 16));
                val_3 = 0;
                val_4 = val_4 + 1;
            }
            while((val_4 - 31) < this.height);
            
                val_1 = this.width;
            }
            
                val_5 = val_5 + 1;
            }
            while(val_5 < (val_1 << ));
        
        }
        public void SetAsVisited(int x, int y, byte group)
        {
            if(((x | y) & 2147483648) != 0)
            {
                    return;
            }
            
            if(this.width <= x)
            {
                    return;
            }
            
            if(this.height <= y)
            {
                    return;
            }
            
            var val_2 = X9 + 16;
            val_2 = (long)y + (val_2 * (long)x);
            this.visited[val_2] = group;
        }
        public bool IsVisitedBy(int x, int y, byte group)
        {
            var val_2 = X9 + 16;
            val_2 = (long)y + (val_2 * (long)x);
            return (bool)(this.visited[val_2] == group) ? 1 : 0;
        }
        public bool IsVisited(int x, int y)
        {
            var val_3;
            if(((((x | y) & 2147483648) == 0) && (this.width > x)) && (this.height > y))
            {
                    var val_3 = X9 + 16;
                val_3 = (long)y + (val_3 * (long)x);
                var val_2 = (this.visited[val_3] != 0) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 1;
            return (bool)val_3;
        }
    
    }

}
