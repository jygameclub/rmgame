using UnityEngine;

namespace Royal.Infrastructure.Contexts.Units
{
    public class CameraManager : IContextUnit
    {
        // Fields
        private const float TallDevice = 0.5;
        private const float WideDevice = 0.6;
        private const float DefaultCameraWidth = 9.3;
        private const float WideDeviceCameraWidth = 12.7;
        private float safeAreaOffset;
        private UnityEngine.Camera camera;
        private float cameraHeight;
        private float cameraWidth;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 1;
        }
        public void Bind()
        {
        
        }
        public void SetPosition(UnityEngine.Vector3 position)
        {
            this.camera.transform.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
        }
        public UnityEngine.Vector3 GetPosition()
        {
            return this.camera.transform.position;
        }
        public UnityEngine.Vector2 GetPositionVector2()
        {
            UnityEngine.Vector3 val_2 = this.camera.transform.position;
            return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public void SetSceneCamera(UnityEngine.Camera camera)
        {
            this.camera = camera;
            var val_2 = (camera.aspect < 0.6f) ? 1 : 0;
            this.cameraWidth = 36607900 + val_1 < 0.6f ? 1 : 0;
            this.SetSafeAreaOffset();
            this.UpdateSize();
        }
        public UnityEngine.Camera GetCamera()
        {
            return (UnityEngine.Camera)this.camera;
        }
        public void UpdateSize()
        {
            float val_1 = this.camera.aspect;
            val_1 = this.cameraWidth / val_1;
            this.cameraHeight = val_1;
            val_1 = val_1 * 0.5f;
            this.camera.orthographicSize = val_1;
        }
        public float GetHeight()
        {
            return (float)this.cameraHeight;
        }
        public float GetSafeHeight()
        {
            UnityEngine.Rect val_1 = UnityEngine.Screen.safeArea;
            val_1.m_XMin = val_1.m_XMin * this.cameraHeight;
            val_1.m_XMin = val_1.m_XMin / (float)UnityEngine.Screen.height;
            return (float)val_1.m_XMin;
        }
        public float GetWidth()
        {
            return (float)this.cameraWidth;
        }
        public float ScreenToWorldUnit(float screenUnits)
        {
            float val_2 = (float)UnityEngine.Screen.width;
            val_2 = this.cameraWidth / val_2;
            val_2 = val_2 * screenUnits;
            return (float)val_2;
        }
        private float WidthPixelRatio()
        {
            float val_2 = (float)UnityEngine.Screen.width;
            val_2 = this.cameraWidth / val_2;
            return (float)val_2;
        }
        public UnityEngine.Vector2 GetCenterPosition()
        {
            UnityEngine.Vector3 val_2 = this.camera.transform.position;
            return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public UnityEngine.Vector3 GetTopCenterOfCamera()
        {
            UnityEngine.Vector3 val_2 = this.camera.transform.position;
            val_2.y = val_2.y + this.camera.orthographicSize;
            return new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        public UnityEngine.Vector3 GetBottomCenterOfCamera()
        {
            UnityEngine.Vector3 val_2 = this.camera.transform.position;
            val_2.y = val_2.y - this.camera.orthographicSize;
            return new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        public UnityEngine.Vector3 GetSafeTopCenterOfCamera()
        {
            UnityEngine.Rect val_1 = UnityEngine.Screen.safeArea;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.m_XMin, y = val_1.m_YMin});
            UnityEngine.Vector3 val_3 = this.camera.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Rect val_4 = UnityEngine.Screen.safeArea;
            float val_9 = val_4.m_XMin;
            float val_5 = this.camera.orthographicSize;
            val_5 = val_9 * val_5;
            float val_11 = (float)UnityEngine.Screen.height;
            val_9 = val_5 / val_11;
            float val_10 = (float)UnityEngine.Screen.width;
            val_10 = this.cameraWidth / val_10;
            val_10 = val_10 * (float)Royal.Infrastructure.Utils.Native.DeviceHelper.GetLegacyNotchHeight();
            val_11 = this.safeAreaOffset + val_9;
            val_10 = val_11 - val_10;
            val_11 = val_3.y + val_10;
            return new UnityEngine.Vector3() {x = val_3.x, y = val_11, z = val_3.z};
        }
        public UnityEngine.Vector3 GetSafeBottomCenterOfCamera()
        {
            UnityEngine.Rect val_1 = UnityEngine.Screen.safeArea;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.m_XMin, y = val_1.m_YMin});
            UnityEngine.Vector3 val_3 = this.camera.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Rect val_4 = UnityEngine.Screen.safeArea;
            float val_8 = this.safeAreaOffset;
            float val_7 = val_4.m_XMin * this.camera.orthographicSize;
            val_7 = val_7 / (float)UnityEngine.Screen.height;
            val_8 = val_8 + val_7;
            val_7 = val_3.y - val_8;
            return new UnityEngine.Vector3() {x = val_3.x, y = val_7, z = val_3.z};
        }
        private float GetLegacyOffset()
        {
            float val_3 = (float)UnityEngine.Screen.width;
            val_3 = this.cameraWidth / val_3;
            val_3 = -(val_3 * (float)Royal.Infrastructure.Utils.Native.DeviceHelper.GetLegacyNotchHeight());
            return (float)val_3;
        }
        private void SetSafeAreaOffset()
        {
            this.safeAreaOffset = 0f;
            UnityEngine.Rect val_1 = UnityEngine.Screen.safeArea;
            float val_7 = val_1.m_XMin;
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsIos == false)
            {
                    return;
            }
            
            val_7 = val_7 / (float)UnityEngine.Screen.height;
            if(val_7 >= 0)
            {
                    return;
            }
            
            if(this.IsDeviceWide() == true)
            {
                    return;
            }
            
            var val_6 = (UnityEngine.Screen.height == 1792) ? 1 : 0;
            this.safeAreaOffset = 36607908 + val_5 == 1792 ? 1 : 0;
        }
        private float GetSafeAreaOffset()
        {
            return (float)this.safeAreaOffset;
        }
        public UnityEngine.Vector2 GetSafeCenterPosition()
        {
            UnityEngine.Rect val_1 = UnityEngine.Screen.safeArea;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.m_XMin, y = val_1.m_YMin});
            UnityEngine.Vector3 val_3 = this.camera.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            return new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
        }
        public UnityEngine.Vector2 GetScreenSize()
        {
            float val_2 = this.camera.orthographicSize + this.camera.orthographicSize;
            float val_3 = this.camera.aspect;
            val_3 = val_2 * val_3;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_3, y:  val_2);
            return new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
        }
        public float GetOrtographicSize()
        {
            if(this.camera != null)
            {
                    return this.camera.orthographicSize;
            }
            
            throw new NullReferenceException();
        }
        public float GetTopSafeHeightDiff()
        {
            UnityEngine.Vector3 val_1 = this.GetSafeTopCenterOfCamera();
            UnityEngine.Vector3 val_2 = this.GetTopCenterOfCamera();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            return (float)val_3.y;
        }
        public UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Vector2 screenCoordinates)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = screenCoordinates.x, y = screenCoordinates.y});
            return this.camera.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        public UnityEngine.Vector2 WorldToScreenPoint(UnityEngine.Vector3 worldPosition)
        {
            UnityEngine.Vector3 val_1 = this.camera.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = worldPosition.x, y = worldPosition.y, z = worldPosition.z});
            return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        public float GetAspect()
        {
            if(this.camera != null)
            {
                    return this.camera.aspect;
            }
            
            throw new NullReferenceException();
        }
        public bool IsDeviceWide()
        {
            return (bool)(this.camera.aspect >= 0.6f) ? 1 : 0;
        }
        public bool IsDeviceTall()
        {
            return (bool)(this.camera.aspect < 0) ? 1 : 0;
        }
        public bool HasBigNotch()
        {
            return (bool)(this.GetTopSafeHeightDiff() < 0) ? 1 : 0;
        }
        public CameraManager()
        {
        
        }
    
    }

}
