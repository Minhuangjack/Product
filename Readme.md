## 專案說明
### BasisAPI
* 可根據 API 需要，寫出共用函式，例如會員驗證、Log、Exception處理 等等。

### Product.Biz
* 實現商務邏輯的部分，並且將資料連結至 Dao
* 主測測式專案要測試這邊的商務邏輯

### Product.Dao
將 Biz 處理完的資料傳送之資料庫或是將資料庫的檔案回傳至 Biz

### Product.Tests
* 商務邏輯測試

### Product
* WebAPI  
  * Models 定義 Reques t來的資料以及驗證
  * Response 定義要回傳出去的資料
  * Repository 將 Controller 傳進來的資料連接至 Biz，並且將資料轉換成物件後回傳至 Controller
  * Controller  接受 Request 並且做簡單的驗證，不做邏輯運算，將資料傳送至 Repoeitory 後，在接收 Repository 處理完後的資料回傳至前端
