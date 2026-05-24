<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />
</div>

# Game Frame X AppsFlyer

[![GitHub release](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.appsflyer?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.appsflyer/releases)
[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.appsflyer?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.appsflyer/blob/main/LICENSE.md)
[![Documentation](https://img.shields.io/badge/Documentation-Online-blue?style=flat-square)](https://gameframex.doc.alianblank.com)

**인디 게임 개발자를 위한 올인원 솔루션 · 인디 개발자의 꿈을 실현**

[문서](https://gameframex.doc.alianblank.com) · [빠른 시작](#빠른-시작) · [QQ 그룹](https://qm.qq.com/q/5s5e1e6e6e)

**언어**: [English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | **한국어**

---

## 프로젝트 개요

Game Frame X AppsFlyer는 GameFrameX 프레임워크 기반의 AppsFlyer SDK Unity 래퍼로, Unity 게임에 모바일 앱 어트리뷰션 및 마케팅 분석 기능을 제공합니다.

## 기능

- 모바일 앱 어트리뷰션: 사용자 획득 출처 및 캠페인 성과 추적
- 마케팅 분석: 상세한 사용자 행동 및 전환 데이터 제공
- 간편한 통합: GameFrameX 프레임워크 기반 컴포넌트 설계
- 크로스 플랫폼: iOS 및 Android 동시 지원
- 개인정보 보호 규정 준수: 사용자 동의 관리 메커니즘 내장

## 빠른 시작

### 시스템 요구 사항

- Unity 2019.4 이상
- GameFrameX 프레임워크 1.1.1 이상
- AppsFlyer Unity SDK 6.17.1

### 설치

#### Unity Package Manager를 통한 설치

1. Unity Package Manager 열기
2. "+" 버튼을 클릭하고 "Add package from git URL" 선택
3. 다음 URL 입력:
   ```
   https://github.com/gameframex/com.gameframex.unity.appsflyer.git
   ```

#### 수동 설치

1. 이 저장소를 다운로드하거나 클론
2. 패키지 폴더를 Unity 프로젝트의 `Packages` 디렉토리에 복사

## 사용 예시

### 설정

#### 1. AppsFlyer 컴포넌트 추가

씬의 GameObject에 `AppsFlyerComponent` 컴포넌트를 추가합니다.

#### 2. 개발자 키 및 앱 ID 설정

`AppsFlyerComponent` 컴포넌트에서 다음 매개변수를 설정합니다:

##### iOS 설정
- **iOS Dev Key**: AppsFlyer 콘솔에서 가져온 iOS 개발자 키
- **iOS App ID**: iOS App Store ID

##### Android 설정
- **Android Dev Key**: AppsFlyer 콘솔에서 가져온 Android 개발자 키
- **Android App ID**: Android 앱 패키지명

#### 3. 디버그 모드 활성화 (선택사항)

`Debug` 옵션을 체크하여 AppsFlyer SDK 디버그 로그 출력을 활성화합니다.

### 기본 초기화

AppsFlyer 컴포넌트는 게임 시작 시 자동으로 초기화됩니다. 씬에 `AppsFlyerComponent`가 추가되고 올바르게 구성되었는지 확인하세요.

### 컴파일 기호

패키지는 `ENABLE_GAME_FRAME_X_APPSFLYER` 컴파일 기호를 사용하여 AppsFlyer 기능 활성화를 제어합니다. 프로젝트 설정에서 이 기호가 정의되어 있는지 확인하세요.

## 프로젝트 구조

```
Runtime/
├── AppsFlyerComponent.cs          # AppsFlyer Unity 컴포넌트
├── AppsFlyerManager.cs            # AppsFlyer 매니저 구현
├── IAppsFlyerManager.cs           # AppsFlyer 매니저 인터페이스
└── GameFrameXAppsFlyerCroppingHelper.cs  # 코드 스트리핑 헬퍼

Editor/
├── AppsFlyerComponentInspector.cs # 컴포넌트 인스펙터
└── GameFrameX.AppsFlyer.Editor.asmdef  # 에디터 어셈블리 정의
```

## 의존성

- `com.gameframex.unity`: GameFrameX 코어 프레임워크
- `com.appsflyer.unity`: AppsFlyer Unity SDK

## 문서 및 자료

- 문서: https://gameframex.doc.alianblank.com
- 저장소: https://github.com/gameframex/com.gameframex.unity.appsflyer
- 이슈: https://github.com/gameframex/com.gameframex.unity.appsflyer/issues

## 라이선스

이 프로젝트는 MIT 라이선스 및 Apache 라이선스(버전 2.0)에 따라 배포됩니다. 자세한 내용은 [LICENSE](LICENSE.md)를 참조하세요.
