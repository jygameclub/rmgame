using UnityEngine;

namespace Royal.Scenes.Start.Context
{
    public static class ApplicationContext
    {
        // Fields
        public static Royal.Scenes.Start.Context.ApplicationContextController controller;
        private static bool <IsActive>k__BackingField;
        private static readonly Royal.Infrastructure.Contexts.ContextContainer<Royal.Infrastructure.Contexts.IContextUnit> Container;
        
        // Properties
        public static bool IsActive { get; set; }
        
        // Methods
        public static bool get_IsActive()
        {
            null = null;
            return (bool)Royal.Scenes.Start.Context.ApplicationContext.<IsActive>k__BackingField;
        }
        private static void set_IsActive(bool value)
        {
            null = null;
            Royal.Scenes.Start.Context.ApplicationContext.<IsActive>k__BackingField = value;
        }
        public static void Add<T>(T unit)
        {
            null = null;
            Royal.Scenes.Start.Context.ApplicationContext.Container.Add(unit:  unit);
        }
        public static T Get<T>(Royal.Scenes.Start.Context.ApplicationContextId id)
        {
            null = null;
            goto __RuntimeMethodHiddenParam + 48;
        }
        public static void BindAll()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            Royal.Scenes.Start.Context.ApplicationContext.Container.BindAll();
            val_2 = null;
            val_2 = null;
            Royal.Scenes.Start.Context.ApplicationContext.<IsActive>k__BackingField = true;
        }
        public static void Clear()
        {
            var val_2;
            Royal.Infrastructure.Contexts.Units.App.AppManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3);
            val_2 = null;
            val_2 = null;
            Royal.Scenes.Start.Context.ApplicationContext.<IsActive>k__BackingField = false;
            if(val_1 != null)
            {
                    val_1.Clear();
            }
            
            Royal.Infrastructure.Services.Logs.Log.Stop();
        }
        public static void ManualUpdate()
        {
            null = null;
            Royal.Scenes.Start.Context.ApplicationContext.Container.ManualUpdate();
        }
        public static UnityEngine.Coroutine ManualStartCoroutine(System.Collections.IEnumerator iEnumerator)
        {
            null = null;
            return Royal.Scenes.Start.Context.ApplicationContext.controller.StartCoroutine(routine:  iEnumerator);
        }
        public static void ManualStartWaitForConsentCoroutine(System.Action onConsentGiven)
        {
            null = null;
            Royal.Scenes.Start.Context.ApplicationContext.controller.StartWaitForConsentCoroutine(onConsentGiven:  onConsentGiven);
        }
        public static void ManualStopCoroutine(UnityEngine.Coroutine iEnumerator)
        {
            null = null;
            Royal.Scenes.Start.Context.ApplicationContext.controller.StopCoroutine(routine:  iEnumerator);
        }
        private static ApplicationContext()
        {
            System.String[] val_2 = System.Enum.GetNames(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            Royal.Scenes.Start.Context.ApplicationContext.Container = new Royal.Infrastructure.Contexts.ContextContainer<Royal.Infrastructure.Contexts.IContextUnit>(contextUnitCount:  val_2.Length);
        }
    
    }

}
