<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />
</div>

# Game Frame X AppsFlyer

[![GitHub release](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.appsflyer?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.appsflyer/releases)
[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.appsflyer?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.appsflyer/blob/main/LICENSE.md)
[![Documentation](https://img.shields.io/badge/Documentation-Online-blue?style=flat-square)](https://gameframex.doc.alianblank.com)

**獨立遊戲前後端一體化解決方案 · 獨立遊戲開發者的圓夢大使**

[文檔](https://gameframex.doc.alianblank.com) · [快速開始](#快速開始) · [QQ群](https://qm.qq.com/q/5s5e1e6e6e)

**語言**: [English](README.md) | [简体中文](README.zh-CN.md) | **繁體中文** | [日本語](README.ja.md) | [한국어](README.ko.md)

---

## 項目簡介

Game Frame X AppsFlyer 是一個基於 GameFrameX 框架的 AppsFlyer SDK Unity 包裝器，為 Unity 遊戲提供行動應用歸因和行銷分析功能。

## 功能特性

- 行動應用歸因: 追蹤使用者獲取來源和行銷活動效果
- 行銷分析: 提供詳細的使用者行為和轉換資料
- 簡單整合: 基於 GameFrameX 框架的元件化設計
- 跨平台支援: 同時支援 iOS 和 Android 平台
- 隱私合規: 內建使用者同意管理機制

## 快速開始

### 系統需求

- Unity 2019.4 或更高版本
- GameFrameX 框架 1.1.1 或更高版本
- AppsFlyer Unity SDK 6.17.1

### 安裝

#### 透過 Unity Package Manager 安裝

1. 開啟 Unity Package Manager
2. 點擊 "+" 按鈕，選擇 "Add package from git URL"
3. 輸入以下 URL：
   ```
   https://github.com/gameframex/com.gameframex.unity.appsflyer.git
   ```

#### 手動安裝

1. 下載或克隆此倉庫
2. 將包資料夾複製到你的 Unity 專案的 `Packages` 目錄中

## 使用範例

### 配置

#### 1. 添加 AppsFlyer 元件

在場景中的某個 GameObject 上添加 `AppsFlyerComponent` 元件。

#### 2. 配置開發者密鑰和應用 ID

在 `AppsFlyerComponent` 元件中配置以下參數：

##### iOS 配置
- **iOS Dev Key**: 從 AppsFlyer 控制台獲取的 iOS 開發者密鑰
- **iOS App ID**: iOS 應用的 App Store ID

##### Android 配置
- **Android Dev Key**: 從 AppsFlyer 控制台獲取的 Android 開發者密鑰
- **Android App ID**: Android 應用的包名

#### 3. 啟用除錯模式（可選）

勾選 `Debug` 選項以啟用 AppsFlyer SDK 的除錯日誌輸出。

### 基本初始化

AppsFlyer 元件會在遊戲啟動時自動初始化。確保在場景中添加了 `AppsFlyerComponent` 並正確配置了相關參數。

### 編譯符號

包使用 `ENABLE_GAME_FRAME_X_APPSFLYER` 編譯符號來控制 AppsFlyer 功能的啟用。確保在專案設定中定義了此符號。

## 專案結構

```
Runtime/
├── AppsFlyerComponent.cs          # AppsFlyer Unity 元件
├── AppsFlyerManager.cs            # AppsFlyer 管理器實作
├── IAppsFlyerManager.cs           # AppsFlyer 管理器介面
└── GameFrameXAppsFlyerCroppingHelper.cs  # 代碼裁剪輔助類

Editor/
├── AppsFlyerComponentInspector.cs # 元件檢查器
└── GameFrameX.AppsFlyer.Editor.asmdef  # 編輯器組件定義
```

## 依賴項

- `com.gameframex.unity`: GameFrameX 核心框架
- `com.appsflyer.unity`: AppsFlyer Unity SDK

## 文檔與資源

- 文檔地址: https://gameframex.doc.alianblank.com
- 倉庫地址: https://github.com/gameframex/com.gameframex.unity.appsflyer
- 問題回報: https://github.com/gameframex/com.gameframex.unity.appsflyer/issues

## 開源協議

本專案遵循 MIT 許可證和 Apache 許可證（版本 2.0）。詳細資訊請查看 [LICENSE](LICENSE.md) 檔案。
