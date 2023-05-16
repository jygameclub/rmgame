using UnityEngine;

namespace Royal.Infrastructure.Utils.Native
{
    public static class FileHelper
    {
        // Fields
        public static readonly string ApplicationDataPath;
        
        // Methods
        private static FileHelper()
        {
            var val_13;
            var val_14;
            System.Object[] val_15;
            var val_16;
            var val_17;
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_14 = val_1.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
            object[] val_3 = new object[2];
            val_15 = val_3;
            if(val_3 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            if(val_3.Length == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_15[0] = "pFiles";
            val_15[1] = 0;
            if(val_14 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_17 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_17 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_17 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_17 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_15 = 0;
            Royal.Infrastructure.Utils.Native.FileHelper.ApplicationDataPath = val_14.Call<UnityEngine.AndroidJavaObject>(methodName:  "getDir", args:  val_3).Call<System.String>(methodName:  "getAbsolutePath", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            var val_12 = 0;
            if(mem[1152921504805339136] != null)
            {
                    val_12 = val_12 + 1;
            }
            else
            {
                    UnityEngine.AndroidJavaObject val_6 = 1152921504805302272 + ((mem[1152921504805339144]) << 4);
            }
            
            val_14.Dispose();
            if(val_15 == 0)
            {
                    if(0 != 1)
            {
                    var val_7 = (89 == 89) ? 1 : 0;
                val_7 = ((0 >= 0) ? 1 : 0) & val_7;
                val_7 = 0 - val_7;
                val_7 = val_7 + 1;
                val_13 = 1152921527478718096 + (val_7 << 2);
            }
            
                val_14 = 0;
                val_13 = 101;
                if(val_1 != null)
            {
                    var val_13 = 0;
                if(mem[1152921504805392384] != null)
            {
                    val_13 = val_13 + 1;
            }
            else
            {
                    UnityEngine.AndroidJavaClass val_9 = 1152921504805355520 + ((mem[1152921504805392392]) << 4);
            }
            
                val_1.Dispose();
            }
            
                if(val_14 != 0)
            {
                    throw X20;
            }
            
                return;
            }
            
            val_16 = X21;
            throw val_16;
        }
    
    }

}
