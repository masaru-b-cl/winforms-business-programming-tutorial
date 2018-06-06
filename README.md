Windowsフォームによる業務プログラミングチュートリアル
=====

## はじめに

本文書は業務アプリケーションを作成するにはどのようにプログラミングを行えばよいか、チュートリアル形式で学んでいきます。業務アプリを作成するには、アルゴリズム、プログラミング言語、GUIプログラミング、DB、DBプログラミングといった各種の知識・スキルを組み合わて作業を行う必要があり、初心者が一からすべてを行うのは困難です。本文書では段階を踏み、どのようにそれぞれの技術要素を応用していくかを学びます。

### 想定する読者

- C#を使った基本的なプログラミングが行える
- 簡単なGUIプログラミングの基本を理解している
- RDBMSの基本的な知識（DDL、DML等のSQL、トランザクション制御など）を理解している
- 簡単なDBプログラミングの基本を理解している

### 本文書のゴール

- 業務システムが使うDBスキーマを作成できる
- 設計書を元に業務データを編集するアプリを作成できる
- アプリに必要な機能を、それぞれの責務に応じた型に分割できる

### 本文書の開発環境

- Windows 10 Pro 64bit
- Visual Studio 2017 Community
- Oracle Database 12c Release 1

### 作成するアプリ

場所ごとに管理された会議室に対し、期間と利用者を指定して予約情報を登録する、「会議室予約システム」を作成します。

会議室予約システムの仕様については[機能仕様書](doc/functional-spec.md)を参照してください。また、テーブルなどのデータベースオブジェクトについては、[DB設計書](doc/db-design.md)を参照してください。

なお、本チュートリアルでは、会議室の参照、編集を行う「会議室管理」機能のみを作成します。続きについては、各自で課題として取り組んでみてください。

## 目次

1. [DBを準備しよう](doc/01.md)
2. [ソリューションを作成しよう](doc/02.md)
3. [Entityクラスを作成しよう](doc/03.md)
4. [Modelクラスを作成しよう](doc/04.md)
5. [画面を作成しよう](doc/05.md)
6. [Modelクラスをの処理を画面から呼び出そう](doc/06.md)
7. [会議室を登録しよう](doc/07.md)
8. [会議室を検索しよう](doc/08.md)
9. [会議室を変更、削除しよう](doc/09.md)
10. [入力チェックを行おう](doc/10.md)
11. [アプリを完成させよう](doc/11.md)
12. [最後に](doc/99.md)

## サンプルについて

各章のサンプルコードは、`src`フォルダーの下にある章番号フォルダーの中にあります。リポジトリをクローンするか、zipファイル等でダウンロードして展開後、Visual Studioでソリューションを開いて内容を確認してください。

### 高DPI環境について

本文書内のコントロールのサイズや位置に指定する値は、ディスプレイの拡大率が100%の場合を想定しています。高DPIなディスプレイにおいて、拡大率を150%等にしている場合、サイズの指定が「ピクセル」単位のため、文字が見切れたりすることがあります。その場合、適宜コントロールのサイズを調整し、文字が見切れないようにしてください。

### DB接続文字列について

実行する際は、各プロジェクト内の`App.config`ファイルの以下の部分の`HOST`、`PORT`、`SERVICE_NAME`等を、各自の環境に合わせて変更してください。

```xml
  <!-- (4) -->
  <oracle.manageddataaccess.client>
    <version number="*">
      <dataSources>
        <!-- (5) -->
        <dataSource alias="ORCL"
          descriptor="(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=hostname)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL))) "/>
      </dataSources>
    </version>
  </oracle.manageddataaccess.client>
```
## 参考資料

- [GUIプログラミング入門 for Windows Forms](https://github.com/masaru-b-cl/introduction-to-winforms-programming)
- [DBプログラミング入門 by ODP.NET](https://github.com/masaru-b-cl/introduction-to-db-programming-by-odp-dot-net)
- [TDD のこころ @ OSH2014](https://www.slideshare.net/t_wada/osh2014-sprit-of-tdd)
