using UnityEngine;

namespace Development.ScreenCapture
{
    public class ScreenCapture : MonoBehaviour
    {
        // Fields
        private const int GuideResWidth = 1302;
        private const int GuideResHeight = 2818;
        public int fileCounter;
        
        // Methods
        private void LateUpdate()
        {
            if((UnityEngine.Input.GetKeyDown(key:  106)) == false)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.Capture());
        }
        public System.Collections.IEnumerator Capture()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new ScreenCapture.<Capture>d__4();
        }
        private void CamCapture()
        {
            int val_13;
            int val_14;
            int val_1 = UnityEngine.Screen.width;
            int val_2 = UnityEngine.Screen.height;
            object[] val_7 = new object[4];
            val_13 = val_7.Length;
            val_7[0] = System.IO.Directory.GetParent(path:  UnityEngine.Application.dataPath).FullName;
            val_13 = val_7.Length;
            val_7[1] = "/Backgrounds/ScreenShot";
            val_14 = val_7.Length;
            val_7[2] = this.fileCounter;
            val_14 = val_7.Length;
            val_7[3] = ".png";
            string val_9 = +val_7;
            UnityEngine.Debug.Log(message:  val_9);
            string val_10 = System.IO.Path.GetDirectoryName(path:  val_9);
            if((System.IO.Directory.Exists(path:  val_10)) != true)
            {
                    System.IO.DirectoryInfo val_12 = System.IO.Directory.CreateDirectory(path:  val_10);
            }
            
            System.IO.File.WriteAllBytes(path:  val_9, bytes:  UnityEngine.ImageConversion.EncodeToPNG(tex:  Development.ScreenCapture.ZzTransparencyCapture.Capture(pRect:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f})));
            int val_13 = this.fileCounter;
            val_13 = val_13 + 1;
            this.fileCounter = val_13;
        }
        public ScreenCapture()
        {
        
        }
    
    }

}
