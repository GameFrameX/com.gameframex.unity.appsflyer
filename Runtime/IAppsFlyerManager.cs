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

using System.Collections.Generic;
using UnityEngine;

namespace GameFrameX.AppsFlyer.Runtime
{
    /// <summary>
    /// 管理接口
    /// </summary>
    [UnityEngine.Scripting.Preserve]
    public interface IAppsFlyerManager
    {
        /// <summary>
        /// 初始化 AppsFlyer SDK    
        /// </summary>
        /// <param name="debug">是否启用调试模式，启用后会输出详细的日志信息</param>
        /// <param name="appId">应用程序ID，iOS平台为App Store ID，Android平台为包名</param>
        /// <param name="appDevKey">AppsFlyer开发者密钥，从AppsFlyer控制台获取</param>
        /// <param name="monoBehaviour">MonoBehaviour实例，用于处理回调事件</param>
        [UnityEngine.Scripting.Preserve]
        void Init(bool debug, string appId, string appDevKey, MonoBehaviour monoBehaviour);

        /// <summary>
        /// 发送自定义事件到 AppsFlyer
        /// </summary>
        /// <param name="eventName">事件名称，用于标识特定的用户行为或应用内事件</param>
        /// <param name="eventValues">事件参数字典，包含与事件相关的键值对数据</param>
        [UnityEngine.Scripting.Preserve]
        void Event(string eventName, Dictionary<string, string> eventValues);
    }
}