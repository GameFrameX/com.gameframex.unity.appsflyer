// GameFrameX 组织下的以及组织衍生的项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
// 
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE 文件。
// 
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

using AppsFlyerSDK;
using GameFrameX.Runtime;
using UnityEngine;

namespace GameFrameX.AppsFlyer.Runtime
{
    /// <summary>
    /// AppsFlyer组件。
    /// </summary>
    [DisallowMultipleComponent]
    [AddComponentMenu("Game Framework/AppsFlyer")]
    [UnityEngine.Scripting.Preserve]
    public class AppsFlyerComponent : GameFrameworkComponent
    {
        private IAppsFlyerManager _appsFlyerManager = null;
        [SerializeField] private bool m_debug = false;

        /// <summary>
        /// iOS平台的AppsFlyer开发者密钥，用于初始化AppsFlyer SDK
        /// </summary>
        [SerializeField] private string m_iOSDevKey = string.Empty;

        /// <summary>
        /// iOS平台的应用ID，用于标识iOS应用
        /// </summary>
        [SerializeField] private string m_iOSAppId = string.Empty;

        /// <summary>
        /// Android平台的AppsFlyer开发者密钥，用于初始化AppsFlyer SDK
        /// </summary>
        [SerializeField] private string m_AndroidDevKey = string.Empty;

        /// <summary>
        /// Android平台的应用ID，用于标识Android应用
        /// </summary>
        [SerializeField] private string m_AndroidAppId = string.Empty;

        /// <summary>
        /// 游戏框架组件初始化。
        /// </summary>
        protected override void Awake()
        {
            ImplementationComponentType = Utility.Assembly.GetType(componentType);
            InterfaceComponentType = typeof(IAppsFlyerManager);
            base.Awake();

            _appsFlyerManager = GameFrameworkEntry.GetModule<IAppsFlyerManager>();
            if (_appsFlyerManager == null)
            {
                Log.Fatal("Apps Flyer manager is invalid.");
                return;
            }
        }

        [UnityEngine.Scripting.Preserve]
        public void Start()
        {
#if ENABLE_GAME_FRAME_X_APPSFLYER
            if (m_debug)
            {
                AppsFlyerSDK.AppsFlyer.setIsDebug(true);
            }
#if UNITY_ANDROID
            AppsFlyerSDK.AppsFlyer.initSDK(m_AndroidDevKey, m_AndroidAppId, this);
#elif UNITY_IOS
            AppsFlyerSDK.AppsFlyer.initSDK(m_iOSDevKey, m_iOSAppId, this);
#endif
            AppsFlyerConsent consent = new AppsFlyerConsent(true, true);
            AppsFlyerSDK.AppsFlyer.setConsentData(consent);

            AppsFlyerSDK.AppsFlyer.setCustomerUserId(SystemInfo.deviceUniqueIdentifier);
            AppsFlyerSDK.AppsFlyer.startSDK();
#endif
        }
    }
}