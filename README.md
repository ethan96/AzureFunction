# AzureFunction

### 1. Install node js
### 2. Install Azure func cli
### 3. Install Azure cli
### 4. Install postman
---
### Node.js version (TypeScript)
#### func new --name <ProjectName> --template "HTTP trigger"
#### cd to project folder
#### npm install
#### func init <ProjectName>
#### <Write codes>
#### npm start
---
### C# version (ASP.NET Core single)
#### func new --name <ProjectName> --template "HTTP trigger"
#### cd to project folder
#### func init <ProjectName>
#### dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson --version X.X.X
---
### Deploy to Azure Function
#### 上 Azure portal 建立 function & resource group
#### az login
#### az storage account create --new <AccountName> --location eastasia --resource-group <ResourceGroupName> --sku Standard_LRS
#### az function app create --resource-group <ResourceGroupName> --consumption-plan-location eastasia --runtime node --runtime-version 18 --function version 4 --name <FunctionAppName> --storage-account <AccountName>
#### 也可以用 visual studio code Azure plugin 部屬
#### func azure functionapp publish <FunctionAppName>  更新程式
