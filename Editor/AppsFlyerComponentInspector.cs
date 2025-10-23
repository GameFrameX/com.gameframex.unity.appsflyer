// GameFrameX 组织下的以及组织衍生的项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
// 
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE 文件。
// 
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

using GameFrameX.AppsFlyer.Runtime;
using GameFrameX.Editor;
using UnityEditor;

namespace GameFrameX.AppsFlyer.Editor
{
    [CustomEditor(typeof(AppsFlyerComponent))]
    internal sealed class AppsFlyerComponentInspector : ComponentTypeComponentInspector
    {
        private SerializedProperty m_devKeyiOS = null;
        private SerializedProperty m_appIdiOS = null;
        private SerializedProperty m_devKeyAndroid = null;
        private SerializedProperty m_appIdAndroid = null;
        private SerializedProperty m_debug = null;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            serializedObject.Update();
            EditorGUI.BeginDisabledGroup(EditorApplication.isPlayingOrWillChangePlaymode);
            {
                EditorGUILayout.PropertyField(m_debug);
                EditorGUILayout.PropertyField(m_devKeyiOS);
                EditorGUILayout.PropertyField(m_appIdiOS);
                EditorGUILayout.PropertyField(m_devKeyAndroid);
                EditorGUILayout.PropertyField(m_appIdAndroid);
            }
            EditorGUI.EndDisabledGroup();

            serializedObject.ApplyModifiedProperties();

            Repaint();
        }

        protected override void OnCompileComplete()
        {
            base.OnCompileComplete();

            RefreshTypeNames();
        }

        protected override void Enable()
        {
            m_debug = serializedObject.FindProperty("m_debug");
            m_devKeyiOS = serializedObject.FindProperty("m_iOSDevKey");
            m_appIdiOS = serializedObject.FindProperty("m_iOSAppId");
            m_devKeyAndroid = serializedObject.FindProperty("m_AndroidDevKey");
            m_appIdAndroid = serializedObject.FindProperty("m_AndroidAppId");

            RefreshTypeNames();
        }

        protected override void RefreshTypeNames()
        {
            RefreshComponentTypeNames(typeof(IAppsFlyerManager));
        }
    }
}