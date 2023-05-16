using UnityEngine;

namespace Royal.Scenes.Game.Utils.Spline
{
    public static class ArrayUtil
    {
        // Methods
        public static string ToString<T>(T[] array, string format = "")
        {
            string val_6;
            string val_7;
            val_6 = format;
            val_7 = val_6;
            int val_6 = array.Length;
            if(val_6 >= 1)
            {
                    val_6 = "{0" + val_7 + "}";
                var val_7 = 0;
                val_6 = val_6 & 4294967295;
                do
            {
                if(val_7 < (((-4294967296) + (((array.Length & 4294967295)) << 32)) >> 32))
            {
                    val_7 = val_6 + ", ";
            }
            else
            {
                    val_7 = val_6;
            }
            
                System.Text.StringBuilder val_5 = new System.Text.StringBuilder().AppendFormat(format:  val_7, arg0:  null);
                val_7 = val_7 + 1;
            }
            while(val_7 < (array.Length << ));
            
            }
        
        }
    
    }

}
