## Navigation
### View と View の移動
* View の中にあるコントロールのコマンドから別の View に遷移する
* https://github.com/PrismLibrary/Prism-Samples-Wpf/tree/master/24-NavigationJournal

## リソースにアクセスする
* DLL にリソースを含める場合はビルドアクションを `リソース` にする
* DLL の View でリソースにアクセスするときは URI を絶対パスで指定する
  ```
  pack://application:,,,/{dll の namespace};component/{リソースまでのパス}
  ```
* 例
  * dll の namespace が `ModuleNamespace`
  * リソースのパスが `/Resource/sample.png`
  ```
  pack://application:,,,/ModuleNamespace;component/Resource/sample.png
  ```
* [[WPF]DLLにあるファイルへの参照方法](https://daidev1976.wordpress.com/2012/12/06/wpfdll%E3%81%AB%E3%81%82%E3%82%8B%E3%83%95%E3%82%A1%E3%82%A4%E3%83%AB%E3%81%B8%E3%81%AE%E5%8F%82%E7%85%A7%E6%96%B9%E6%B3%95/)

## リソース
* <a href="https://pixabay.com/ja/users/iqbalnuril-12845379/?utm_source=link-attribution&amp;utm_medium=referral&amp;utm_campaign=image&amp;utm_content=4912211">iqbal nuril anwar</a>による<a href="https://pixabay.com/ja/?utm_source=link-attribution&amp;utm_medium=referral&amp;utm_campaign=image&amp;utm_content=4912211">Pixabay</a>からの画像

## 