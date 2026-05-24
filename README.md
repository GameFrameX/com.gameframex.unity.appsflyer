<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />
</div>

# Game Frame X AppsFlyer

[![GitHub release](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.appsflyer?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.appsflyer/releases)
[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.appsflyer?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.appsflyer/blob/main/LICENSE.md)
[![Documentation](https://img.shields.io/badge/Documentation-Online-blue?style=flat-square)](https://gameframex.doc.alianblank.com)

**All-in-One Solution for Indie Game Development · Empowering Indie Developers' Dreams**

[Documentation](https://gameframex.doc.alianblank.com) · [Quick Start](#quick-start) · [QQ Group](https://qm.qq.com/q/5s5e1e6e6e)

**Language**: **English** | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

---

## Project Overview

Game Frame X AppsFlyer is an AppsFlyer SDK Unity wrapper based on the GameFrameX framework, providing mobile app attribution and marketing analytics for Unity games.

## Features

- Mobile App Attribution: Track user acquisition sources and campaign performance
- Marketing Analytics: Detailed user behavior and conversion data
- Simple Integration: Component-based design built on GameFrameX
- Cross-Platform: Supports both iOS and Android
- Privacy Compliance: Built-in user consent management

## Quick Start

### System Requirements

- Unity 2019.4 or higher
- GameFrameX framework 1.1.1 or higher
- AppsFlyer Unity SDK 6.17.1

### Installation

#### Via Unity Package Manager

1. Open Unity Package Manager
2. Click the "+" button and select "Add package from git URL"
3. Enter the following URL:
   ```
   https://github.com/gameframex/com.gameframex.unity.appsflyer.git
   ```

#### Manual Installation

1. Download or clone this repository
2. Copy the package folder into your Unity project's `Packages` directory

## Usage Examples

### Configuration

#### 1. Add AppsFlyer Component

Add the `AppsFlyerComponent` component to a GameObject in your scene.

#### 2. Configure Developer Keys and App ID

Configure the following parameters in the `AppsFlyerComponent`:

##### iOS Configuration
- **iOS Dev Key**: iOS developer key from AppsFlyer console
- **iOS App ID**: iOS App Store ID

##### Android Configuration
- **Android Dev Key**: Android developer key from AppsFlyer console
- **Android App ID**: Android app package name

#### 3. Enable Debug Mode (Optional)

Check the `Debug` option to enable AppsFlyer SDK debug log output.

### Basic Initialization

The AppsFlyer component initializes automatically when the game starts. Make sure the `AppsFlyerComponent` is added to the scene and properly configured.

### Compilation Symbol

The package uses the `ENABLE_GAME_FRAME_X_APPSFLYER` compilation symbol to enable AppsFlyer functionality. Make sure this symbol is defined in your project settings.

## Project Structure

```
Runtime/
├── AppsFlyerComponent.cs          # AppsFlyer Unity component
├── AppsFlyerManager.cs            # AppsFlyer manager implementation
├── IAppsFlyerManager.cs           # AppsFlyer manager interface
└── GameFrameXAppsFlyerCroppingHelper.cs  # Code stripping helper

Editor/
├── AppsFlyerComponentInspector.cs # Component inspector
└── GameFrameX.AppsFlyer.Editor.asmdef  # Editor assembly definition
```

## Dependencies

- `com.gameframex.unity`: GameFrameX core framework
- `com.appsflyer.unity`: AppsFlyer Unity SDK

## Documentation & Resources

- Documentation: https://gameframex.doc.alianblank.com
- Repository: https://github.com/gameframex/com.gameframex.unity.appsflyer
- Issues: https://github.com/gameframex/com.gameframex.unity.appsflyer/issues

## License

This project is licensed under the MIT License and Apache License (Version 2.0). See [LICENSE](LICENSE.md) for details.
