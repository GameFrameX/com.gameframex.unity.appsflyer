// ==========================================================================================
//  GameFrameX 组织及其衍生项目的版权、商标、专利及其他相关权利
//  GameFrameX organization and its derivative projects' copyrights, trademarks, patents, and related rights
//  均受中华人民共和国及相关国际法律法规保护。
//  are protected by the laws of the People's Republic of China and relevant international regulations.
// 
//  使用本项目须严格遵守相应法律法规及开源许可证之规定。
//  Usage of this project must strictly comply with applicable laws, regulations, and open-source licenses.
// 
//  本项目采用 MIT 许可证与 Apache License 2.0 双许可证分发，
//  This project is dual-licensed under the MIT License and Apache License 2.0,
//  完整许可证文本请参见源代码根目录下的 LICENSE 文件。
//  please refer to the LICENSE file in the root directory of the source code for the full license text.
// 
//  禁止利用本项目实施任何危害国家安全、破坏社会秩序、
//  It is prohibited to use this project to engage in any activities that endanger national security, disrupt social order,
//  侵犯他人合法权益等法律法规所禁止的行为！
//  or infringe upon the legitimate rights and interests of others, as prohibited by laws and regulations!
//  因基于本项目二次开发所产生的一切法律纠纷与责任，
//  Any legal disputes and liabilities arising from secondary development based on this project
//  本项目组织与贡献者概不承担。
//  shall be borne solely by the developer; the project organization and contributors assume no responsibility.
// 
//  GitHub 仓库：https://github.com/GameFrameX
//  GitHub Repository: https://github.com/GameFrameX
//  Gitee  仓库：https://gitee.com/GameFrameX
//  Gitee Repository:  https://gitee.com/GameFrameX
//  官方文档：https://gameframex.doc.alianblank.com/
//  Official Documentation: https://gameframex.doc.alianblank.com/
// ==========================================================================================

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