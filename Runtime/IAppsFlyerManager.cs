// GameFrameX 组织下的以及组织衍生的项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
// 
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE 文件。
// 
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

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
    }
}