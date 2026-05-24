<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />
</div>

# Game Frame X AppsFlyer

[![GitHub release](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.appsflyer?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.appsflyer/releases)
[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.appsflyer?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.appsflyer/blob/main/LICENSE.md)
[![Documentation](https://img.shields.io/badge/Documentation-Online-blue?style=flat-square)](https://gameframex.doc.alianblank.com)

**独立游戏前后端一体化解决方案 · 独立游戏开发者的圆梦大使**

[文档](https://gameframex.doc.alianblank.com) · [快速开始](#快速开始) · [QQ群](https://qm.qq.com/q/5s5e1e6e6e)

**语言**: [English](README.md) | **简体中文** | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

---

## 项目简介

Game Frame X AppsFlyer 是一个基于 GameFrameX 框架的 AppsFlyer SDK Unity 包装器，为 Unity 游戏提供移动应用归因和营销分析功能。

## 功能特性

- 移动应用归因: 跟踪用户获取来源和营销活动效果
- 营销分析: 提供详细的用户行为和转化数据
- 简单集成: 基于 GameFrameX 框架的组件化设计
- 跨平台支持: 同时支持 iOS 和 Android 平台
- 隐私合规: 内置用户同意管理机制

## 快速开始

### 系统要求

- Unity 2019.4 或更高版本
- GameFrameX 框架 1.1.1 或更高版本
- AppsFlyer Unity SDK 6.17.1

### 安装

#### 通过 Unity Package Manager 安装

1. 打开 Unity Package Manager
2. 点击 "+" 按钮，选择 "Add package from git URL"
3. 输入以下 URL：
   ```
   https://github.com/gameframex/com.gameframex.unity.appsflyer.git
   ```

#### 手动安装

1. 下载或克隆此仓库
2. 将包文件夹复制到你的 Unity 项目的 `Packages` 目录中

## 使用示例

### 配置

#### 1. 添加 AppsFlyer 组件

在场景中的某个 GameObject 上添加 `AppsFlyerComponent` 组件。

#### 2. 配置开发者密钥和应用ID

在 `AppsFlyerComponent` 组件中配置以下参数：

##### iOS 配置
- **iOS Dev Key**: 从 AppsFlyer 控制台获取的 iOS 开发者密钥
- **iOS App ID**: iOS 应用的 App Store ID

##### Android 配置
- **Android Dev Key**: 从 AppsFlyer 控制台获取的 Android 开发者密钥
- **Android App ID**: Android 应用的包名

#### 3. 启用调试模式（可选）

勾选 `Debug` 选项以启用 AppsFlyer SDK 的调试日志输出。

### 基本初始化

AppsFlyer 组件会在游戏启动时自动初始化。确保在场景中添加了 `AppsFlyerComponent` 并正确配置了相关参数。

### 编译符号

包使用 `ENABLE_GAME_FRAME_X_APPSFLYER` 编译符号来控制 AppsFlyer 功能的启用。确保在项目设置中定义了此符号。

## 项目结构

```
Runtime/
├── AppsFlyerComponent.cs          # AppsFlyer Unity 组件
├── AppsFlyerManager.cs            # AppsFlyer 管理器实现
├── IAppsFlyerManager.cs           # AppsFlyer 管理器接口
└── GameFrameXAppsFlyerCroppingHelper.cs  # 代码裁剪辅助类

Editor/
├── AppsFlyerComponentInspector.cs # 组件检查器
└── GameFrameX.AppsFlyer.Editor.asmdef  # 编辑器程序集定义
```

## 依赖项

- `com.gameframex.unity`: GameFrameX 核心框架
- `com.appsflyer.unity`: AppsFlyer Unity SDK

## 文档与资源

- 文档地址: https://gameframex.doc.alianblank.com
- 仓库地址: https://github.com/gameframex/com.gameframex.unity.appsflyer
- 问题反馈: https://github.com/gameframex/com.gameframex.unity.appsflyer/issues

## 开源协议

本项目遵循 MIT 许可证和 Apache 许可证（版本 2.0）。详细信息请查看 [LICENSE](LICENSE.md) 文件。
