// GameFrameX 组织下的以及组织衍生的项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
// 
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE 文件。
// 
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

using System;
using System.Collections.Generic;
using AppsFlyerSDK;
using GameFrameX.Runtime;
using UnityEngine;

namespace GameFrameX.AppsFlyer.Runtime
{
    /// <summary>
    /// AppsFlyer组件。
    /// </summary>
    [DisallowMultipleComponent]
    [AddComponentMenu("GameFrameX/AppsFlyer")]
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
#if UNITY_ANDROID
            _appsFlyerManager.Init(m_debug, m_AndroidAppId, m_AndroidDevKey, this);
#elif UNITY_IOS
            _appsFlyerManager.Init(m_debug, m_iOSAppId, m_iOSDevKey, this);
#endif
        }

        /// <summary>
        /// 发送自定义事件到 AppsFlyer
        /// </summary>
        /// <param name="eventName">事件名称，用于标识特定的用户行为或应用内事件</param>
        /// <param name="eventValues">事件参数字典，包含与事件相关的键值对数据</param>
        public void Event(string eventName, Dictionary<string, string> eventValues)
        {
            _appsFlyerManager.Event(eventName, eventValues);
        }
    }
}