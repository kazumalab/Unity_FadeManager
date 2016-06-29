# Unity_FadeManager

# 機能
- フェードアウト
enableFadeとenableFadeOutをtrue
- フェードイン
enableFadeとenableFadeInをtrue
- フェードオン
enableFadeとenableFadeOnをtrue

# フェードオンとは？
シーンを切り替えずにフェードイン、フェードアウトを行う。
時空や背景をこっそり変える時など・・・。

# 使い方
1. シーンに空のゲームオブジェクトFadeManagerを作り、FadeManager.csをアタッチ
2. UI/Imageを画面いっぱいに配置(VRモードの場合はCanvasをWorldSpaceにしてカメラ全体に映るように)
3. アタッチしたFadeManager.csのInspectorから2のイメージを選択
4. 外部、もしくは内部から 使いたい機能のbool + enableFadeをtrueに変更
