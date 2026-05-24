<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />
</div>

# Game Frame X AppsFlyer

[![GitHub release](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.appsflyer?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.appsflyer/releases)
[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.appsflyer?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.appsflyer/blob/main/LICENSE.md)
[![Documentation](https://img.shields.io/badge/Documentation-Online-blue?style=flat-square)](https://gameframex.doc.alianblank.com)

**インディゲーム開発者向けオールインワンソリューション · インディ開発者の夢を支援**

[ドキュメント](https://gameframex.doc.alianblank.com) · [クイックスタート](#クイックスタート) · [QQグループ](https://qm.qq.com/q/5s5e1e6e6e)

**言語**: [English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | **日本語** | [한국어](README.ko.md)

---

## プロジェクト概要

Game Frame X AppsFlyer は、GameFrameX フレームワークに基づく AppsFlyer SDK Unity ラッパーで、Unity ゲームにモバイルアプリのアトリビューションとマーケティング分析機能を提供します。

## 機能

- モバイルアプリアトリビューション: ユーザー獲得ソースとキャンペーン効果を追跡
- マーケティング分析: 詳細なユーザー行動とコンバージョンデータ
- 簡単統合: GameFrameX フレームワークのコンポーネントベース設計
- クロスプラットフォーム: iOS と Android の両方をサポート
- プライバシー準拠: ユーザー同意管理メカニズム内蔵

## クイックスタート

### 動作環境

- Unity 2019.4 以上
- GameFrameX フレームワーク 1.1.1 以上
- AppsFlyer Unity SDK 6.17.1

### インストール

#### Unity Package Manager 経由

1. Unity Package Manager を開く
2. "+" ボタンをクリックし、"Add package from git URL" を選択
3. 以下の URL を入力：
   ```
   https://github.com/gameframex/com.gameframex.unity.appsflyer.git
   ```

#### 手動インストール

1. このリポジトリをダウンロードまたはクローン
2. パッケージフォルダを Unity プロジェクトの `Packages` ディレクトリにコピー

## 使用例

### 設定

#### 1. AppsFlyer コンポーネントの追加

シーン内の GameObject に `AppsFlyerComponent` コンポーネントを追加します。

#### 2. 開発者キーとアプリ ID の設定

`AppsFlyerComponent` コンポーネントで以下のパラメータを設定します：

##### iOS 設定
- **iOS Dev Key**: AppsFlyer コンソールから取得した iOS 開発者キー
- **iOS App ID**: iOS App Store ID

##### Android 設定
- **Android Dev Key**: AppsFlyer コンソールから取得した Android 開発者キー
- **Android App ID**: Android アプリのパッケージ名

#### 3. デバッグモードの有効化（オプション）

`Debug` オプションをチェックして、AppsFlyer SDK のデバッグログ出力を有効にします。

### 基本的な初期化

AppsFlyer コンポーネントはゲーム起動時に自動的に初期化されます。シーンに `AppsFlyerComponent` が追加され、正しく設定されていることを確認してください。

### コンパイルシンボル

パッケージは `ENABLE_GAME_FRAME_X_APPSFLYER` コンパイルシンボルを使用して AppsFlyer 機能の有効化を制御します。プロジェクト設定でこのシンボルが定義されていることを確認してください。

## プロジェクト構成

```
Runtime/
├── AppsFlyerComponent.cs          # AppsFlyer Unity コンポーネント
├── AppsFlyerManager.cs            # AppsFlyer マネージャー実装
├── IAppsFlyerManager.cs           # AppsFlyer マネージャーインターフェース
└── GameFrameXAppsFlyerCroppingHelper.cs  # コードストリッピングヘルパー

Editor/
├── AppsFlyerComponentInspector.cs # コンポーネントインスペクター
└── GameFrameX.AppsFlyer.Editor.asmdef  # エディタアセンブリ定義
```

## 依存関係

- `com.gameframex.unity`: GameFrameX コアフレームワーク
- `com.appsflyer.unity`: AppsFlyer Unity SDK

## ドキュメントとリソース

- ドキュメント: https://gameframex.doc.alianblank.com
- リポジトリ: https://github.com/gameframex/com.gameframex.unity.appsflyer
- イシュー: https://github.com/gameframex/com.gameframex.unity.appsflyer/issues

## ライセンス

このプロジェクトは MIT ライセンスおよび Apache ライセンス（バージョン 2.0）の下で公開されています。詳細は [LICENSE](LICENSE.md) をご覧ください。
