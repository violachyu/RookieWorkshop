# Case 001 - Web Application
- 建立 Web API 並回傳任意資料  
ex. http://localhost/api/data

# Case 002 - Console Application
- 建立 Console 應用程式  
呼叫 http://localhost/api/data 並顯示回傳結果

# Case 003 - Service
- [FizzBuzz](https://codingdojo.org/kata/FizzBuzz/)   
呼叫 http://localhost/api/data/1 並回傳結果  
不同參數應根據 FizzBuzz 邏輯回傳結果

# Case 004 - Unit Test
- 針對 FizzBuzzService.GetResult(int input) 寫單元測試(至少4個測項)  
**限制條件** [xUnit](https://xunit.net/)

# Case 005 - Interface
- [FooBarQix](https://codingdojo.org/kata/FooBarQix/)(Step1)  
建立 IDateService  
替換 FizzBuzzService 為 FooBarQixService

# Case 006 - Stub
- 新增 IInputService.GetValue(int max)  
回傳 0 ~ max 整數
- 調整 FooBarQixService.GetResult(int input)  
input 必須先經由 IInputService.GetValue() 處理
- 對 FooBarQixService 撰寫單元測試  
**限制條件** [NSubstitute](https://nsubstitute.github.io/)

# Case 007 - Autofac
- Web Applicaiton 專案改以 Autofac 套件來進行 DI(Dependency Injection)

# Case 008 - FileCache
- 新增 ICacheService.GetData()，以檔案的方式將讓資料有 5 Sec 的快取
- 讓 FooBarQixService.GetResult() 使用 ICacheService 的快取特性

# Case 009 - Redis
- 改以 RedisCacheService 實作 ICacheService
```
# 以 docker 在本機啟用 redis server
docker run --rm -p 6379:6379 redis
```

# Case 010 - SqlServer
- 建立 DataDB 資料庫
- 建立 Data 資料表 Schema 如下
  - Data_Id int **IDENTITY**
  - Data_Input string
  - Data_Result string
- 建立 IDataRepository 存取 Data 資料表
- 將 IDateService.GetResult() 的資料寫入 Data 資料表  
**限制條件** 使用 Entity Framework Core
```
# 建立 Sql Server 容器(SA_PASSWORD 自行調整)
docker run --name SqlServer -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=yourStrong(!)Password' -e 'MSSQL_PID=Express' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2017-latest-ubuntu

# 啟動 Sql Server 容器
docker start SqlServer

# 停止 Sql Server 容器
docker stop SqlServer

# 查詢容器
docker ps -a

# 刪除 Sql Server 容器
docker rm SqlServer
```

# Case 011 - AutoMapper
- 建立 DataEntity
  - Id
  - Input
  - Result
- 建立 DataEntityMapperProfile : Profile 將 Data 轉換為 DataEntity  
並將 Data_Result 轉為大寫
