DB設計書：会議室予約システム
=====

- 作成者 : 高野 将
- 作成日 : 2018/6/6

ユーザー定義
-----

| 項目 | 設定値 |
| --- | --- |
| ユーザー名 | MRRS_DEV |
| デフォルト表領域 | USERS |
| テンポラリ表領域 | TEMP |
| プロファイル | DEFAULT |
| クォータサイズ | UNLIMITED |

| 権限 |
| --- |
| CONNECT |
| CREATE PROCEDURE |
| CREATE SEQUENCE |
| CREATE TABLE |
| CREATE TRIGGER |
| CREATE TYPE |
| CREATE VIEW |

シーケンス定義
-----

| シーケンス名 | 増分 | 最小値 | 最大値 | 繰り返し | 順序保証 | キャッシュサイズ |
| --- | --- | --- | --- | --- | --- | --- |
| SEQ_LOCATION_ID | 1 | なし | なし | なし | なし | 20 |
| SEQ_MEETING_ROOM_ID | 1 | なし | なし | なし | なし | 20 |
| SEQ_TESTDB | 1 | なし | なし | なし | なし | 20 |

テーブル定義
-----

### LOCATION : 場所

| No. | 列ID | 列名 | データ型 | 総桁数 | 小数部桁数 | 必須 | 既定値 | 主キー | 備考 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| 1 | ID | ID | NUMBER | - | - | 〇 | - | 1 | シーケンスSEQ_LOCATION_IDにて自動生成 |
| 2 | NAME | 名称 | NVARCHAR | 20 | - | 〇 | - |   |   |

### MEETING_ROOM : 会議室

| No. | 列ID | 列名 | データ型 | 総桁数 | 小数部桁数 | 必須 | 既定値 | 主キー | 備考 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| 1 | ID | ID | NUMBER | - | - | ○ | - | 1 | シーケンスSEQ_MEETING_ROOM_IDにて自動生成
| 2 | LOCATION_ID | 場所ID | NUMBER | - | - | ○ | - |  | LOCATIONテーブルのID列に対する外部キー制約を付ける | 
| 3 | NAME | 名称 | NVARCHAR | 20 | - | ○ | - |  | 場所IDと名前でUNIQUE KEY制約を付ける |

### RESERVATION : 予約

| No. | 列ID | 列名 | データ型 | 総桁数 | 小数部桁数 | 必須 | 既定値 | 主キー | 備考 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| 1 | ID | ID | NUMBER | - | - | ○ | - | 1 | シーケンスSEQ_RESERVATION_IDにて自動生成
| 2 | MEETING_ROOM_ID | 会議室ID | NUMBER | - | - | ○ | - |  | MEETING_ROOMテーブルのID列に対する外部キー制約を付ける |
| 3 | RESERVATION_START_DATE | 予約開始日時 | DATE | - | - | ○ | - |  | 年月日と時分までを扱う / 会議室IDと予約開始日時でUNIQUE KEY制約を付ける |
| 4 | RESERVATION_END_DATE | 予約終了日時 | DATE | - | - | ○ | - |  | 年月日と時分までを扱う |
| 5 | USER_NAME | 利用者 | NVARCHAR | 50 | - | ○ | - |  |  |


