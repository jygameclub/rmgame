using UnityEngine;

namespace Royal.Infrastructure.Utils.Animation
{
    public static class QuadraticBezierPool
    {
        // Fields
        private static readonly System.Collections.Generic.Stack<Royal.Infrastructure.Utils.Animation.QuadraticBezier> Pool;
        
        // Methods
        public static void InitPool()
        {
            var val_2;
            var val_2 = 0;
            do
            {
                val_2 = null;
                val_2 = null;
                Royal.Infrastructure.Utils.Animation.QuadraticBezierPool.Pool.Push(item:  new Royal.Infrastructure.Utils.Animation.QuadraticBezier());
                val_2 = val_2 + 1;
            }
            while(val_2 < 9);
        
        }
        public static Royal.Infrastructure.Utils.Animation.QuadraticBezier Pop()
        {
            var val_3;
            System.Collections.Generic.Stack<Royal.Infrastructure.Utils.Animation.QuadraticBezier> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = Royal.Infrastructure.Utils.Animation.QuadraticBezierPool.Pool;
            if((Royal.Infrastructure.Utils.Animation.QuadraticBezierPool.Pool + 24) > 0)
            {
                    val_4 = Royal.Infrastructure.Utils.Animation.QuadraticBezierPool.Pool;
                val_5 = val_4.Pop();
                return (Royal.Infrastructure.Utils.Animation.QuadraticBezier)val_5;
            }
            
            Royal.Infrastructure.Utils.Animation.QuadraticBezier val_2 = null;
            val_5 = val_2;
            val_2 = new Royal.Infrastructure.Utils.Animation.QuadraticBezier();
            return (Royal.Infrastructure.Utils.Animation.QuadraticBezier)val_5;
        }
        public static void Push(Royal.Infrastructure.Utils.Animation.QuadraticBezier bezier)
        {
            null = null;
            Royal.Infrastructure.Utils.Animation.QuadraticBezierPool.Pool.Push(item:  bezier);
        }
        private static QuadraticBezierPool()
        {
            Royal.Infrastructure.Utils.Animation.QuadraticBezierPool.Pool = new System.Collections.Generic.Stack<Royal.Infrastructure.Utils.Animation.QuadraticBezier>();
        }
    
    }

}
