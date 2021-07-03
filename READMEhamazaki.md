# Azure Object Anchors

## 流れ

1. 学習モデル作成アプリとサンプルアプリを用意する(済)
2. サンプルアプリをHolo2に入れる(済)
3. Holo2やLider機能を使ってスキャンメッシュデータを取得する
4. メッシュデータを学習モデルに変換する
5. 学習モデルをHolo2のアプリ内に入れる
6. 実行

## 用意するもの

- VisualStudio2019
- HoloLens2
- Blender

## 使いかた

[参考文献](http://akihiro-document.azurewebsites.net/post/hololens2_azureobjectanchor_quickstart/)

### 学習モデルの作り方

#### スキャンメッシュデータについて

- HoloLensのSpatialMapから得られたメッシュデータを利用する場合には，デバイスポータルから`View/3D View`から`Spatial mapping`のUpdateとSaveからダウンロードが行えます．
- ダウンロードしたしたSpatialMapのobjファイルは余分な部分も含まれているのでBlender等でトリミングを行うことで精度の良い3Dモデルにすることができます．

##### 補足

1. デバイスポータルの入り方はHoloLens2とPCを共通Wi-Fiに入ってHoloLens2のIPアドレスを確認(HoloLens2でWiFi→詳細な設定とか見ると書いてると思います)
   PC上でhttp://192.168. ...
   とやるとアクセスできます

2. Blenderでobjファイルのインポートは
   ファイル→インポート　から

   いろいろ作業して保存するときはLightやCamera Lightなどは不要なので消しておきましょう

   

#### 学習モデルへの変換

visual studioでquickstarts/conversion/Conversion.sln を開いて

`InputAssetPath` : 作成する学習用3Dモデルデータのファイルパスを変更して実行すると同一ファイルに.ouファイルが作成される



### アプリ

作成した学習モデルはHoloLensのデバイスポータルから，作成したアプリの`LocalState`フォルダにアップロードします

- 学習モデルアップロード後のアプリ起動でboxが空間に配置されます．(起動位置によってはboxがSpatialMapに埋まってしまうことがあります．)
- ObjectAnchorを設置したい場所が含まれるようにboxを移動，拡大して`Start Search`ボタンを押下することで位置合わせを行います．

(Hololensに入ってます AOASampleSceneみたいな名前です)
