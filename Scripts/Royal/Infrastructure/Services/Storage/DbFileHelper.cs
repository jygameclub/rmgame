using UnityEngine;

namespace Royal.Infrastructure.Services.Storage
{
    public static class DbFileHelper
    {
        // Methods
        public static string GetAppDbPath()
        {
            null = null;
            return System.IO.Path.Combine(path1:  Royal.Infrastructure.Utils.Native.FileHelper.ApplicationDataPath, path2:  "App");
        }
        public static string GetUserDbPath(long userId)
        {
            null = null;
            return (string)System.IO.Path.Combine(path1:  Royal.Infrastructure.Utils.Native.FileHelper.ApplicationDataPath, path2:  "U_" + userId);
        }
        public static string MoveDbFile(string currentPath, long newName)
        {
            string val_1 = Royal.Infrastructure.Services.Storage.DbFileHelper.GetUserDbPath(userId:  newName);
            if((System.IO.File.Exists(path:  val_1)) == true)
            {
                    return val_1;
            }
            
            System.IO.File.Move(sourceFileName:  currentPath, destFileName:  val_1);
            return val_1;
        }
        public static void DeleteDbFile(string path)
        {
            if((System.IO.File.Exists(path:  path)) == false)
            {
                    return;
            }
            
            System.IO.File.Delete(path:  path);
        }
        private static int DbFileChangeCounter(string path)
        {
            System.IO.Stream val_5;
            var val_7;
            byte[] val_1 = new byte[4];
            System.IO.FileStream val_2 = null;
            val_5 = val_2;
            val_2 = new System.IO.FileStream(path:  path, mode:  3);
            System.IO.BinaryReader val_3 = new System.IO.BinaryReader(input:  val_2);
            if(val_3 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_5 = 0;
            var val_5 = 0;
            if(mem[1152921504638353408] != null)
            {
                    val_5 = val_5 + 1;
            }
            else
            {
                    System.IO.BinaryReader val_4 = 1152921504638316544 + ((mem[1152921504638353416]) << 4);
            }
            
            val_3.Dispose();
            if(val_5 != 0)
            {
                    throw val_5;
            }
            
            val_7 = null;
            val_7 = null;
            if(System.BitConverter.IsLittleEndian == false)
            {
                    return System.BitConverter.ToInt32(value:  val_1, startIndex:  0);
            }
            
            System.Array.Reverse(array:  val_1);
            val_7 = null;
            return System.BitConverter.ToInt32(value:  val_1, startIndex:  0);
        }
    
    }

}
