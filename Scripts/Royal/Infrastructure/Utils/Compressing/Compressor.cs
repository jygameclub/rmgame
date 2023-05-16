using UnityEngine;

namespace Royal.Infrastructure.Utils.Compressing
{
    public static class Compressor
    {
        // Methods
        private static void CreateZipFile(string outPathname, string password, string folderName)
        {
            string val_7 = folderName;
            System.IO.FileStream val_1 = System.IO.File.Create(path:  outPathname);
            ICSharpCode.SharpZipLib.Zip.ZipOutputStream val_2 = new ICSharpCode.SharpZipLib.Zip.ZipOutputStream(baseOutputStream:  val_1);
            if(val_2 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_2.SetLevel(level:  3);
            val_2.Password = password;
            var val_7 = ~(val_7.EndsWith(value:  "\\"));
            val_7 = val_7 & 1;
            Royal.Infrastructure.Utils.Compressing.Compressor.CompressFolder(path:  val_7 = folderName, zipStream:  val_2, folderOffset:  folderName.m_stringLength + val_7);
            val_7 = 0;
            var val_8 = 0;
            if(mem[1152921505009811456] != null)
            {
                    val_8 = val_8 + 1;
            }
            else
            {
                    ICSharpCode.SharpZipLib.Zip.ZipOutputStream val_5 = 1152921505009774592 + ((mem[1152921505009811464]) << 4);
            }
            
            val_2.Dispose();
            if(val_7 != 0)
            {
                    throw val_7;
            }
            
            if(val_1 != null)
            {
                    var val_9 = 0;
                if(mem[1152921504641335296] != null)
            {
                    val_9 = val_9 + 1;
            }
            else
            {
                    System.IO.FileStream val_6 = 1152921504641298432 + ((mem[1152921504641335304]) << 4);
            }
            
                val_1.Dispose();
            }
            
            if(0 != 0)
            {
                    throw 0;
            }
        
        }
        private static void CompressFolder(string path, ICSharpCode.SharpZipLib.Zip.ZipOutputStream zipStream, int folderOffset)
        {
            var val_12;
            var val_13;
            if(val_1.Length >= 1)
            {
                    var val_16 = 0;
                var val_13 = 0;
                do
            {
                string val_12 = System.IO.Directory.GetFiles(path:  path)[val_16];
                System.IO.FileInfo val_2 = new System.IO.FileInfo(fileName:  val_12);
                ICSharpCode.SharpZipLib.Zip.ZipEntry val_5 = new ICSharpCode.SharpZipLib.Zip.ZipEntry(name:  ICSharpCode.SharpZipLib.Zip.ZipEntry.CleanName(name:  val_12.Substring(startIndex:  folderOffset)));
                System.DateTime val_6 = val_2.LastWriteTime;
                val_5.DateTime = new System.DateTime() {dateData = val_6.dateData};
                val_5.Size = val_2.Length;
                zipStream.PutNextEntry(entry:  val_5);
                System.IO.FileStream val_9 = System.IO.File.OpenRead(path:  val_12);
                val_13 = val_9;
                ICSharpCode.SharpZipLib.Core.StreamUtils.Copy(source:  val_9, destination:  zipStream, buffer:  new byte[4096]);
                val_12 = 0;
                val_13 = val_13 + 1;
                if(val_13 != null)
            {
                    var val_14 = 0;
                if(mem[1152921504641335296] != null)
            {
                    val_14 = val_14 + 1;
            }
            else
            {
                    System.IO.FileStream val_10 = 1152921504641298432 + ((mem[1152921504641335304]) << 4);
            }
            
                val_13.Dispose();
            }
            
                if(val_12 != 0)
            {
                    throw ???;
            }
            
                if(val_13 != 1)
            {
                    var val_15 = 0;
                val_15 = val_15 ^ (val_13 >> 31);
                val_13 = val_13 + val_15;
            }
            
                zipStream.CloseEntry();
                val_16 = val_16 + 1;
            }
            while(val_16 < val_1.Length);
            
            }
            
            int val_17 = val_11.Length;
            if(val_17 < 1)
            {
                    return;
            }
            
            var val_18 = 0;
            val_17 = val_17 & 4294967295;
            do
            {
                val_18 = val_18 + 1;
            }
            while(val_18 < (val_11.Length << ));
        
        }
        public static void Compress(string inputPath, string outputPath)
        {
            if((System.IO.File.Exists(path:  outputPath)) != false)
            {
                    System.IO.File.Delete(path:  outputPath);
            }
            
            Royal.Infrastructure.Utils.Compressing.Compressor.CreateZipFile(outPathname:  outputPath, password:  0, folderName:  inputPath);
        }
        public static byte[] ZipStr(string str, System.Text.Encoding encoding)
        {
            System.IO.Stream val_9;
            var val_10;
            var val_11;
            var val_13;
            var val_14;
            var val_15;
            var val_17;
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            System.IO.Compression.GZipStream val_2 = null;
            val_9 = val_2;
            val_2 = new System.IO.Compression.GZipStream(stream:  val_1, mode:  1);
            val_10 = 0;
            var val_8 = 0;
            val_11 = 1152921504638406664;
            if(mem[1152921504638406656] != null)
            {
                    val_8 = val_8 + 1;
                val_11 = 1152921504638406680;
            }
            else
            {
                    System.IO.BinaryWriter val_4 = 1152921504638369792 + ((mem[1152921504638406664]) << 4);
            }
            
            val_13 = public System.Void System.IDisposable::Dispose();
            new System.IO.BinaryWriter(output:  val_2, encoding:  encoding).Dispose();
            if(val_10 != 0)
            {
                    throw val_10 = 0;
            }
            
            val_15 = 0;
            if(val_9 != null)
            {
                    var val_9 = 0;
                val_11 = 1152921504745648136;
                if(mem[1152921504745648128] != null)
            {
                    val_9 = val_9 + 1;
                val_11 = 1152921504745648152;
            }
            else
            {
                    System.IO.Compression.GZipStream val_5 = 1152921504745611264 + ((mem[1152921504745648136]) << 4);
            }
            
                var val_11 = public System.Void System.IDisposable::Dispose();
                val_13 = public System.Void System.IDisposable::Dispose();
                val_2.Dispose();
            }
            
            if(val_15 != 0)
            {
                    throw val_15;
            }
            
            if(0 == 1)
            {
                goto label_13;
            }
            
            var val_6 = (51 == 51) ? 1 : 0;
            val_6 = ((0 >= 0) ? 1 : 0) & val_6;
            val_6 = 0 - val_6;
            val_14 = val_6 + 1;
            val_10 = (long)val_14;
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            label_19:
            val_15 = val_1;
            val_9 = 0;
            mem2[0] = 76;
            val_13 = null;
            var val_10 = 0;
            val_11 = 1152921504639631368;
            if(mem[1152921504639631360] == val_13)
            {
                goto label_16;
            }
            
            val_10 = val_10 + 1;
            goto label_18;
            label_13:
            if(val_1 != null)
            {
                goto label_19;
            }
            
            throw new NullReferenceException();
            label_16:
            val_11 = val_11 + ((mem[1152921504745648136]) << 4);
            val_17 = val_11 + 304;
            label_18:
            val_1.Dispose();
            if(val_9 != null)
            {
                    throw val_9;
            }
            
            return (System.Byte[])val_15;
        }
        public static string UnzipStr(byte[] bytes, System.Text.Encoding encoding)
        {
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream(buffer:  bytes);
            System.IO.Compression.GZipStream val_2 = new System.IO.Compression.GZipStream(stream:  val_1, mode:  0);
            System.IO.BinaryReader val_3 = new System.IO.BinaryReader(input:  val_2, encoding:  encoding);
            var val_7 = 0;
            if(mem[1152921504638353408] != null)
            {
                    val_7 = val_7 + 1;
            }
            else
            {
                    System.IO.BinaryReader val_4 = 1152921504638316544 + ((mem[1152921504638353416]) << 4);
            }
            
            val_3.Dispose();
            if(0 != 0)
            {
                    throw 0;
            }
            
            if(val_2 != null)
            {
                    var val_8 = 0;
                if(mem[1152921504745648128] != null)
            {
                    val_8 = val_8 + 1;
            }
            else
            {
                    System.IO.Compression.GZipStream val_5 = 1152921504745611264 + ((mem[1152921504745648136]) << 4);
            }
            
                val_2.Dispose();
            }
            
            if(0 != 0)
            {
                    throw 0;
            }
            
            if(val_1 != null)
            {
                    var val_9 = 0;
                if(mem[1152921504639631360] != null)
            {
                    val_9 = val_9 + 1;
            }
            else
            {
                    System.IO.MemoryStream val_6 = 1152921504639594496 + ((mem[1152921504639631368]) << 4);
            }
            
                val_1.Dispose();
            }
            
            if(0 != 0)
            {
                    throw 0;
            }
            
            return (string)val_3;
        }
    
    }

}
