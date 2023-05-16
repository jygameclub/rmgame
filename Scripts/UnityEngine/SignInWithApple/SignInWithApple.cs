using UnityEngine;

namespace UnityEngine.SignInWithApple
{
    public class SignInWithApple : MonoBehaviour
    {
        // Fields
        private static UnityEngine.SignInWithApple.SignInWithApple.Callback s_LoginCompletedCallback;
        private static UnityEngine.SignInWithApple.SignInWithApple.Callback s_CredentialStateCallback;
        private static readonly System.Collections.Generic.Queue<System.Action> s_EventQueue;
        public UnityEngine.SignInWithApple.SignInWithAppleEvent onLogin;
        public UnityEngine.SignInWithApple.SignInWithAppleEvent onCredentialState;
        public UnityEngine.SignInWithApple.SignInWithAppleEvent onError;
        
        // Methods
        private static void LoginCompletedCallback(int result, UnityEngine.SignInWithApple.UserInfo info)
        {
            int val_2;
            string val_3;
            var val_4;
            val_2 = result;
            if(val_2 != 0)
            {
                    val_2 = 1391548544;
                val_3 = 0;
            }
            else
            {
                    val_3 = info.error;
            }
            
            val_4 = null;
            val_4 = null;
            UnityEngine.SignInWithApple.SignInWithApple.s_LoginCompletedCallback.Invoke(args:  new CallbackArgs() {userInfo = new UnityEngine.SignInWithApple.UserInfo() {userDetectionStatus = val_2}, error = info.error});
            UnityEngine.SignInWithApple.SignInWithApple.s_LoginCompletedCallback = 0;
        }
        private static void GetCredentialStateCallback(UnityEngine.SignInWithApple.UserCredentialState state)
        {
            null = null;
            UnityEngine.SignInWithApple.SignInWithApple.s_CredentialStateCallback.Invoke(args:  new CallbackArgs() {credentialState = state, userInfo = new UnityEngine.SignInWithApple.UserInfo()});
            UnityEngine.SignInWithApple.SignInWithApple.s_CredentialStateCallback = 0;
        }
        public void GetCredentialState(string userID)
        {
            mem[1152921518883547040] = this;
            mem[1152921518883547048] = System.Void UnityEngine.SignInWithApple.SignInWithApple::TriggerCredentialStateEvent(UnityEngine.SignInWithApple.SignInWithApple.CallbackArgs args);
            mem[1152921518883547024] = System.Void UnityEngine.SignInWithApple.SignInWithApple::TriggerCredentialStateEvent(UnityEngine.SignInWithApple.SignInWithApple.CallbackArgs args);
            this.GetCredentialState(userID:  userID, callback:  new SignInWithApple.Callback());
        }
        public void GetCredentialState(string userID, UnityEngine.SignInWithApple.SignInWithApple.Callback callback)
        {
            var val_2;
            var val_3;
            string val_5;
            if(userID == null)
            {
                goto label_1;
            }
            
            val_2 = null;
            val_2 = null;
            if(UnityEngine.SignInWithApple.SignInWithApple.s_CredentialStateCallback != null)
            {
                goto label_4;
            }
            
            val_3 = 1152921505020108808;
            UnityEngine.SignInWithApple.SignInWithApple.s_CredentialStateCallback = callback;
            return;
            label_1:
            val_5 = "Credential state fetch called without a user id.";
            goto label_7;
            label_4:
            System.InvalidOperationException val_1 = null;
            val_5 = "Credential state fetch called while another request is in progress";
            label_7:
            val_1 = new System.InvalidOperationException(message:  val_5);
            throw val_1;
        }
        private void GetCredentialStateInternal(string userID)
        {
        
        }
        public void Login()
        {
            mem[1152921518883934624] = this;
            mem[1152921518883934632] = System.Void UnityEngine.SignInWithApple.SignInWithApple::TriggerOnLoginEvent(UnityEngine.SignInWithApple.SignInWithApple.CallbackArgs args);
            mem[1152921518883934608] = System.Void UnityEngine.SignInWithApple.SignInWithApple::TriggerOnLoginEvent(UnityEngine.SignInWithApple.SignInWithApple.CallbackArgs args);
            this.Login(callback:  new SignInWithApple.Callback());
        }
        public void Login(UnityEngine.SignInWithApple.SignInWithApple.Callback callback)
        {
            var val_2 = null;
            if(UnityEngine.SignInWithApple.SignInWithApple.s_LoginCompletedCallback != null)
            {
                    throw new System.InvalidOperationException(message:  "Login called while another login is in progress");
            }
            
            UnityEngine.SignInWithApple.SignInWithApple.s_LoginCompletedCallback = callback;
        }
        private void LoginInternal()
        {
        
        }
        private void TriggerOnLoginEvent(UnityEngine.SignInWithApple.SignInWithApple.CallbackArgs args)
        {
            var val_3;
            .<>4__this = this;
            mem[1152921518884375256] = args.userInfo.userDetectionStatus;
            mem[1152921518884375240] = args.userInfo.idToken;
            mem[1152921518884375224] = args.userInfo.email;
            .args = args.credentialState;
            if(null != 0)
            {
                    this.TriggerOnErrorEvent(args:  new CallbackArgs() {credentialState = (SignInWithApple.<>c__DisplayClass18_0)[1152921518884375184].args.credentialState, userInfo = new UnityEngine.SignInWithApple.UserInfo() {userId = (SignInWithApple.<>c__DisplayClass18_0)[1152921518884375184].args.credentialState, email = mem[(SignInWithApple.<>c__DisplayClass18_0)[1152921518884375184].args + 16], displayName = mem[(SignInWithApple.<>c__DisplayClass18_0)[1152921518884375184].args + 16], idToken = mem[(SignInWithApple.<>c__DisplayClass18_0)[1152921518884375184].args + 32], error = mem[(SignInWithApple.<>c__DisplayClass18_0)[1152921518884375184].args + 32], userDetectionStatus = mem[(SignInWithApple.<>c__DisplayClass18_0)[1152921518884375184].args + 32 + 16]}, error = mem[(SignInWithApple.<>c__DisplayClass18_0)[1152921518884375184].args + 32 + 16]});
                return;
            }
            
            val_3 = null;
            val_3 = null;
            UnityEngine.SignInWithApple.SignInWithApple.s_EventQueue.Enqueue(item:  new System.Action(object:  new SignInWithApple.<>c__DisplayClass18_0(), method:  System.Void SignInWithApple.<>c__DisplayClass18_0::<TriggerOnLoginEvent>b__0()));
        }
        private void TriggerCredentialStateEvent(UnityEngine.SignInWithApple.SignInWithApple.CallbackArgs args)
        {
            var val_3;
            .<>4__this = this;
            mem[1152921518884578360] = args.userInfo.userDetectionStatus;
            mem[1152921518884578344] = args.userInfo.idToken;
            mem[1152921518884578328] = args.userInfo.email;
            .args = args.credentialState;
            if(null != 0)
            {
                    this.TriggerOnErrorEvent(args:  new CallbackArgs() {credentialState = (SignInWithApple.<>c__DisplayClass19_0)[1152921518884578288].args.credentialState, userInfo = new UnityEngine.SignInWithApple.UserInfo() {userId = (SignInWithApple.<>c__DisplayClass19_0)[1152921518884578288].args.credentialState, email = mem[(SignInWithApple.<>c__DisplayClass19_0)[1152921518884578288].args + 16], displayName = mem[(SignInWithApple.<>c__DisplayClass19_0)[1152921518884578288].args + 16], idToken = mem[(SignInWithApple.<>c__DisplayClass19_0)[1152921518884578288].args + 32], error = mem[(SignInWithApple.<>c__DisplayClass19_0)[1152921518884578288].args + 32], userDetectionStatus = mem[(SignInWithApple.<>c__DisplayClass19_0)[1152921518884578288].args + 32 + 16]}, error = mem[(SignInWithApple.<>c__DisplayClass19_0)[1152921518884578288].args + 32 + 16]});
                return;
            }
            
            val_3 = null;
            val_3 = null;
            UnityEngine.SignInWithApple.SignInWithApple.s_EventQueue.Enqueue(item:  new System.Action(object:  new SignInWithApple.<>c__DisplayClass19_0(), method:  System.Void SignInWithApple.<>c__DisplayClass19_0::<TriggerCredentialStateEvent>b__0()));
        }
        private void TriggerOnErrorEvent(UnityEngine.SignInWithApple.SignInWithApple.CallbackArgs args)
        {
            var val_3;
            .<>4__this = this;
            mem[1152921518884781464] = args.userInfo.userDetectionStatus;
            mem[1152921518884781448] = args.userInfo.idToken;
            mem[1152921518884781432] = args.userInfo.email;
            .args = args.credentialState;
            val_3 = null;
            val_3 = null;
            UnityEngine.SignInWithApple.SignInWithApple.s_EventQueue.Enqueue(item:  new System.Action(object:  new SignInWithApple.<>c__DisplayClass20_0(), method:  System.Void SignInWithApple.<>c__DisplayClass20_0::<TriggerOnErrorEvent>b__0()));
        }
        public void Update()
        {
            var val_2;
            goto label_1;
            label_9:
            mem[47603712] + 184 + 16.Dequeue().Invoke();
            label_1:
            val_2 = null;
            val_2 = null;
            if((UnityEngine.SignInWithApple.SignInWithApple.s_EventQueue + 32) > 0)
            {
                goto label_9;
            }
        
        }
        public SignInWithApple()
        {
        
        }
        private static SignInWithApple()
        {
            UnityEngine.SignInWithApple.SignInWithApple.s_EventQueue = new System.Collections.Generic.Queue<System.Action>();
        }
    
    }

}
