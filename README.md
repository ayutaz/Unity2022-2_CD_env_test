# Game CI for CD on GitHub Actions

<!-- TOC -->
* [Game CI for CD on GitHub Actions](#game-ci-for-cd-on-github-actions)
* [Demo](#demo)
* [requirements](#requirements)
* [Memo](#memo)
<!-- TOC -->

Unity 2022.2.0f1をGitHub Actions上でGameCIを使ってCD環境を構築サンプルプロジェクト

# Demo

# requirements

* Unity 2022.2.0f1

# Memo

* URPでは以下のエラーが起きるためビルドが成功しない

```
Building Library/Bee/artifacts/WebGL/build/debug_WebGL_wasm/build.js failed with output:
emcc: error: '/opt/unity/Editor/Data/PlaybackEngines/WebGLSupport/BuildTools/Emscripten/llvm/wasm-ld @/tmp/emscripten_ht7b_s5g.rsp.utf-8' failed (received SIGKILL (-9))
```
