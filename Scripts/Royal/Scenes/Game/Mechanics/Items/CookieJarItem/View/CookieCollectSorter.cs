using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View
{
    internal class CookieCollectSorter : IComparer<Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieCollectData>
    {
        // Fields
        private static readonly Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint invalidCell;
        
        // Methods
        public int Compare(Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieCollectData x, Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieCollectData y)
        {
            var val_6;
            UnityEngine.Vector3 val_2 = x.goalView.transform.position;
            UnityEngine.Vector3 val_4 = y.goalView.transform.position;
            if(val_2.y > val_4.y)
            {
                goto label_9;
            }
            
            if(val_2.y < 0)
            {
                goto label_10;
            }
            
            if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_2.y, b:  val_4.y, precision:  0.001f)) == false)
            {
                goto label_8;
            }
            
            if(val_2.x < 0)
            {
                goto label_9;
            }
            
            if(val_2.x > val_4.x)
            {
                goto label_10;
            }
            
            label_8:
            val_6 = 0;
            return (int)val_6;
            label_9:
            val_6 = 0;
            return (int)val_6;
            label_10:
            val_6 = 1;
            return (int)val_6;
        }
        public CookieCollectSorter()
        {
        
        }
        private static CookieCollectSorter()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_1 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  0);
            Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieCollectSorter.invalidCell = val_1.x;
        }
    
    }

}
