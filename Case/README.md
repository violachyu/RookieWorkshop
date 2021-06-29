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